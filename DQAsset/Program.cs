﻿using System;
using System.Collections.Generic;
using System.IO;

namespace DQAsset
{ 
    class Program
    {
        // Reads PackageFile from a UAsset file, if UExp exists next to it then they'll be merged before reading
        static PackageFile ReadPackage(string UAssetPath)
        {
            var UExpPath = Path.ChangeExtension(UAssetPath, ".uexp");

            var uasset = File.ReadAllBytes(UAssetPath);
            var uassetLength = uasset.Length;
            if(File.Exists(UExpPath))
            {
                var uexp = File.ReadAllBytes(UExpPath);
                var uexpLength = uexp.Length;

                Array.Resize(ref uasset, uasset.Length + uexp.Length);
                Array.Copy(uexp, 0, uasset, uassetLength, uexpLength);
            }

            using (var reader = new BinaryReader(new MemoryStream(uasset)))
            {
                var sum = new PackageFile();
                sum.Deserialize(reader);
                return sum;
            }
        }

        // some code to help with C++ -> C# struct conversion...
        static void JackDTStructsPostProcess()
        {
            var lines = File.ReadAllLines(@"C:\src\DQAsset\JackDTStructs.txt");
            var res = "";
            foreach(var line in lines)
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

                if(curLine.Contains("TEnumAsByte<"))
                    curLine = curLine.Replace("TEnumAsByte<", "").Replace(">", ""); // meh

                curLine = curLine.Replace(" : public ", " // : public ");

                curLine = curLine.Replace("public struct ", "public ");
                
                res += curLine + "\r\n";
            }
            File.WriteAllText(@"C:\src\DQAsset\JackDTStructs_new3.txt", res);
        }

        static void HandleInput(string inputFile)
        {
            var inputUAsset = inputFile;
            var outputFile = Path.ChangeExtension(inputFile, ".csv");

            bool convertingToText = true;

            var inputExtension = Path.GetExtension(inputFile);
            if (inputExtension == ".csv")
            {
                outputFile = Path.Combine(Path.GetDirectoryName(inputFile), Path.GetFileNameWithoutExtension(inputFile) + "_mod");
                convertingToText = false;
                inputUAsset = Path.ChangeExtension(inputFile, ".uasset");
            }
            if (!File.Exists(inputUAsset))
            {
                Console.WriteLine("failed to load base uasset from path");
                Console.WriteLine($"  {inputUAsset}");
                return;
            }

            var package = ReadPackage(inputUAsset);
            if (convertingToText)
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

            var outputUAsset = outputFile + ".uasset";
            var outputUexp = outputFile + ".uexp";

            using (var outputUAssetWriter = new BinaryWriter(File.Create(outputUAsset)))
            using (var outputUexpWriter = new BinaryWriter(File.Create(outputUexp)))
                package.Serialize(outputUexpWriter, outputUAssetWriter);

            Console.WriteLine("wrote out uasset/uexp files to path");
            Console.WriteLine($"  {outputFile}.uasset/uexp");
        }

        static List<string> FileBlackList = new List<string>()
        {
            // most of these seem to use UserDefinedStructs (UDS), not sure how to handle those yet
            "DT_CharaLookByMaps.uasset",
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
            "DT_NativizationAsset.uasset", // requires UObject struct?!
            "DT_NativizationAssetPath.uasset", // weird struct includes new bytes at random?
            "DT_BattleAutoCameraCollision.uasset", // UDS

            // mostly fixed, might have issues if they use bUsePlanarLimit
            //"DT_AnimDynamics_M004.uasset", // JackDataTableAnimDynamicsTableProperties
            //"DT_G377E005.uasset", //JackDataTableAnimDynamicsTableProperties

            "DT_PokerItem_.uasset" // UDS
        };

        static void BatchFolder(string folderPath)
        {
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
                HandleInput(asset);
            }
        }

        static void Main(string[] args)
        {
            //JackDTStructsPostProcess();
            //BatchFolder(@"C:\Games\JackGame\Content\DataTables");

            if (args.Length < 1)
            {
                Console.WriteLine("Usage: DQAsset.exe <path/to/uasset/or/csv>");
                Console.WriteLine("Will convert UAsset/UExp pair to CSV, or CSV to UAsset/UExp pair");
                Console.WriteLine();
                Console.WriteLine("Note that CSV should have the original UAsset/UExp files next to it, for DQAsset to use as a base to update");
                Console.WriteLine("Updated UAsset/UExp pair will be written to <path>_mod.uasset/uexp");
                Console.WriteLine();
                Console.WriteLine("(currently rows can't be removed but should be possible to add new ones - same for any FNames)");
                return;
            }

            var inputFile = args[0];
            HandleInput(inputFile);
        }
    }
}
