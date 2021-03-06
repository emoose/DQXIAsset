using System;
using System.Collections.Generic;
using System.IO;

namespace DQAsset
{ 
    class Program
    {
        public static bool DoFNameCleanup = true;

        static bool CompareOutput = false;
        static string BadFiles = "";
        static bool SkipIfOutputExists = false;

        static List<string> FileBlackList = new List<string>()
        {
            // most of these seem to use UserDefinedStructs (UDS), not sure how to handle those yet
            "DT_Coordinate.uasset", // strange file
            "DT_Crowd_SetList.uasset",
            "DT_DebugAutoPlay.uasset",
            "DT_DebugChairAnimation.uasset",
            "DT_DebugCommandMacro.uasset", // seems to work fine, but contains newline chars (and is huge)
            "DT_DebugCsCoordinate.uasset",
            "DT_DebugNpcAnimation.uasset",
            "DT_DebugNpcAnimCheck.uasset",
            "DT_DebugNpcClassCoordinate.uasset",
            "DT_DebugNpcSpawnTable.uasset",
            "DT_NavBuild.uasset",
            "DT_BattleAutoCameraCollision.uasset", // UDS STRUCT_DT_AutoCameraCollision
            "DT_PokerItem_.uasset", // UDS
            "DT_TextDataTest.csv", // messes up our CSV splitting regex
        };

        // Reads PackageFile from a UAsset file, if UExp exists next to it then they'll be merged before reading
        static PackageFile ReadPackage(string UAssetPath, bool convertingFromCsv)
        {
            var UExpPath = Path.ChangeExtension(UAssetPath, ".uexp");

            var uasset = File.ReadAllBytes(UAssetPath);
            var uassetLength = uasset.Length;
            if (File.Exists(UExpPath))
            {
                var uexp = File.ReadAllBytes(UExpPath);
                var uexpLength = uexp.Length;

                Array.Resize(ref uasset, uasset.Length + uexp.Length);
                Array.Copy(uexp, 0, uasset, uassetLength, uexpLength);
            }

            using (var reader = new BinaryReader(new MemoryStream(uasset)))
            {
                var sum = new PackageFile();
                if (convertingFromCsv)
                    sum.SkipPropertyDataLoad = true;
                sum.Deserialize(reader);
                return sum;
            }
        }

        // some code to help with C++ -> C# struct conversion...
        static void JackDTStructsPostProcess()
        {
            var lines = File.ReadAllLines(@"C:\src\DQAsset\JackDTStructs.txt");
            var res = "";
            foreach (var line in lines)
            {
                var curLine = line;
                if (curLine.Contains(" MISSED OFFSET"))
                    continue;

                if ((curLine.Contains("[0x10]") || curLine.Contains("[0x18]")) && curLine.Contains("UNKNOWN PROPERTY:") &&
                    (curLine.Contains("SoftObjectProperty") || curLine.Contains("SoftClassProperty") || curLine.Contains("ArrayProperty")))
                {
                    var fieldLast = curLine.LastIndexOf('.');
                    var fieldName = curLine.Substring(fieldLast + 1);
                    if (!curLine.Contains("ArrayProperty"))
                        curLine = "    public FName " + fieldName + ";";
                    else
                        curLine = "    public List<FName> " + fieldName + ";";
                }
                else if (curLine.Contains("*") || curLine.Contains("TWeakObjectPtr"))
                    curLine = "    //" + curLine.Substring(4);

                if (curLine.Contains("TEnumAsByte<"))
                    curLine = curLine.Replace("TEnumAsByte<", "").Replace(">", ""); // meh

                curLine = curLine.Replace(" : public ", " // : public ");

                curLine = curLine.Replace("public struct ", "public ");
                
                res += curLine + "\r\n";
            }
            File.WriteAllText(@"C:\src\DQAsset\JackDTStructs_new3.txt", res);
        }

        static void HandleInput(string inputFile, string outputFile)
        {
            var inputUAsset = inputFile;      

            bool convertingFromCsv = false;

            var inputExtension = Path.GetExtension(inputFile).ToLower();
            if (inputExtension == ".csv")
            {
                if (string.IsNullOrEmpty(outputFile))
                    outputFile = Path.Combine(Path.GetDirectoryName(inputFile), Path.GetFileNameWithoutExtension(inputFile) + "_mod");
                else
                {
                    // remove extension from output path if user gave .uasset/.uexp
                    var ext = Path.GetExtension(outputFile).ToLower();
                    if (ext == ".uasset" || ext == ".uexp")
                        outputFile = outputFile.Substring(0, outputFile.LastIndexOf('.'));
                }

                convertingFromCsv = true;
                inputUAsset = Path.ChangeExtension(inputFile, ".uasset");
            }
            else
                if (string.IsNullOrEmpty(outputFile))
                    outputFile = Path.ChangeExtension(inputFile, ".csv");

            var outputUAsset = outputFile + ".uasset";
            var outputUexp = outputFile + ".uexp";

            if (SkipIfOutputExists && (File.Exists(outputFile) || File.Exists(outputUAsset)))
                return;

            if (!File.Exists(inputUAsset))
            {
                Console.WriteLine("failed to load base uasset from path");
                Console.WriteLine($"  {inputUAsset}");
                return;
            }

            var package = ReadPackage(inputUAsset, convertingFromCsv);
            if (!convertingFromCsv)
            {
                File.WriteAllText(outputFile, package.SerializeText());
                Console.WriteLine("wrote out CSV to path");
                Console.WriteLine($"  {outputFile}");
                return;
            }

            // Not converting to text, must be converting from text
            if (!File.Exists(inputFile))
            {
                Console.WriteLine("failed to load csv data from path");
                Console.WriteLine($"  {inputFile}");
                return;
            }

            // Clear existing rows from loaded UAsset, so only ones defined in CSV will still exist
            // TODO: this shouldn't be used if any fields are marked with Serializer(Hidden=true), since atm we don't construct default object for them :(
            // If any structs are added which use that, comment this line to fix the serializer afterward...
            // (or alternatively, fix the serializer code properly so it constructs a default object ^^)
            package.ExportObjects[0].PropertiesData.Clear();

            var csvData = File.ReadAllText(inputFile);
            package.DeserializeText(csvData);

            using (var outputUAssetWriter = new BinaryWriter(File.Create(outputUAsset)))
            using (var outputUexpWriter = new BinaryWriter(File.Create(outputUexp)))
                package.Serialize(outputUexpWriter, outputUAssetWriter, Program.DoFNameCleanup);

            Console.WriteLine("wrote out uasset/uexp files to path");
            Console.WriteLine($"  {outputFile}.uasset/uexp");

            if (CompareOutput)
            {
                var hasher = System.Security.Cryptography.SHA256.Create();

                var origUAsset = Path.ChangeExtension(inputFile, ".uasset");
                var origUExp = Path.ChangeExtension(inputFile, ".uexp");
                var newUAsset = outputUAsset;
                var newUExp = outputUexp;

                var origUExpHash = hasher.ComputeHash(File.ReadAllBytes(origUExp));
                var newUExpHash = hasher.ComputeHash(File.ReadAllBytes(newUExp));
                if (origUExpHash.ToHexString() != newUExpHash.ToHexString())
                {
                    Console.WriteLine("INVALID UEXP:");
                    Console.WriteLine("  " + origUAsset);
                    BadFiles += inputFile + "\r\n";
                    return;
                }

                var origUAssetHash = hasher.ComputeHash(File.ReadAllBytes(origUAsset));
                var newUAssetHash = hasher.ComputeHash(File.ReadAllBytes(newUAsset));
                if (origUAssetHash.ToHexString() != newUAssetHash.ToHexString())
                {
                    Console.WriteLine("INVALID UASSET:");
                    Console.WriteLine("  " + origUAsset);
                    BadFiles += inputFile + "\r\n";
                    return;
                }
            }
        }

        static void BatchFolder(string folderPath)
        {
            SkipIfOutputExists = false;
            CompareOutput = true;
            var assets = Directory.GetFiles(folderPath, "*.uasset", SearchOption.AllDirectories);
            foreach (var asset in assets)
            {
                var fname = Path.GetFileName(asset);
                if (FileBlackList.Contains(fname) ||
                    fname.StartsWith("DT_PokerItem_"))

                {
                    Console.WriteLine("blacklisted: " + asset);
                    continue;
                }
                Console.WriteLine(asset);
                HandleInput(asset, string.Empty);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("DQXIAsset by emoose");
            Console.WriteLine("https://github.com/emoose/DQXIAsset");
            Console.WriteLine();

            //JackDTStructsPostProcess();
            //BatchFolder(@"C:\Games\DQXI\JackGame\Content\DataTables");
            //File.WriteAllText(@"C:\Games\DQXI\bad.txt", BadFiles);

            if (args.Length < 1)
            {
                Console.WriteLine("Allows converting UAsset/UExp pair to CSV, or CSV to UAsset/UExp pair");
                Console.WriteLine("Usage: DQAsset.exe [-o <output/path>] [-sf] <path/to/uasset/or/csv>");
                Console.WriteLine();
                Console.WriteLine("Options:");
                Console.WriteLine("  -o <output/path>: sets path to write output file to");
                Console.WriteLine("  -sf: skips fname cleanup, may improve uasset creation speed");
                Console.WriteLine();
                Console.WriteLine("Note that CSV should have the original UAsset/UExp files next to it, for DQAsset to use as a base to update");
                Console.WriteLine("Updated UAsset/UExp pair will be written to <path>_mod.uasset/uexp");
                Console.WriteLine();
                return;
            }

            var inputFile = string.Empty;
            var outputFile = string.Empty;

            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] == "-sf")
                    DoFNameCleanup = false;
                else if (args[i] == "-o" && args.Length > i+1)
                {
                    outputFile = args[i + 1];
                    i++;
                }
                else
                    inputFile = args[i];
            }

            if (string.IsNullOrEmpty(inputFile))
            {
                Console.WriteLine("error: no input file specified!");
                return;
            }

            HandleInput(inputFile, outputFile);
        }
    }
}
