using System;
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

        static void Main(string[] args)
        {
            var package = ReadPackage(@"C:\Games\JackGame\Content\DataTables\MiniGame\MeosiSlot\Monster\DT_MeosiSlotMonsterParam.uasset");

            // Test writing out CSV
            var csvData = package.SerializeText();
            File.WriteAllText(@"C:\Games\DT_Custom\Test3.csv", csvData);

            // TODO: read in modified CSV

            // Test writing parsed/modded UAsset to UAsset+UExp pair
            var outputUAsset = new BinaryWriter(File.Create(@"C:\Games\DT_Custom\Test3.uasset"));
            var outputUexp = new BinaryWriter(File.Create(@"C:\Games\DT_Custom\Test3.uexp"));
            package.Serialize(outputUexp, outputUAsset);

            Console.WriteLine("Hello World!");
        }
    }
}
