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

            //var exp = package.ExportObjects[0].PropertiesData["Slime"] as JackDataTableMeosiSlotMonsterParam;
            //exp.Attack1_Damage = exp.Attack2_Damage = exp.Attack3_Damage = exp.Attack4_Damage = 1;

            // Test writing out CSV
            var csvData = package.SerializeText();
            File.WriteAllText(@"C:\Games\DT_Custom\Test7.csv", csvData);

            // TODO: can't use this atm until hidden fields have default values set up
            // (see FTableRowBase::DeserializeText)
            // If hidden fields are removed from struct it seems to work fine though!
            // package.ExportObjects[0].PropertiesData.Clear();

            package.DeserializeText(csvData);

            // TODO: read in modified CSV

            // Test writing parsed/modded UAsset to UAsset+UExp pair
            using (var outputUAsset = new BinaryWriter(File.Create(@"C:\Games\DT_Custom\Test7.uasset")))
            using (var outputUexp = new BinaryWriter(File.Create(@"C:\Games\DT_Custom\Test7.uexp")))
                package.Serialize(outputUexp, outputUAsset);

            Console.WriteLine("Hello World!");
        }
    }
}
