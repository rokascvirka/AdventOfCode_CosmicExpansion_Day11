using System.Reflection;

namespace AdventOfCode_CosmicExpansion_Day11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var FILE_PATH = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? "", "FakeData.txt");

            var galaxy =  FileReader.ReadFromFile(FILE_PATH);
            GalaxyProcessor.AddRows(galaxy);
            GalaxyProcessor.AddCollumns_V2(galaxy);

            foreach(var row in galaxy.Galaxy)
            {
                var test = "";
                foreach(var letter in row)
                {
                    test += letter;
                }
                Console.WriteLine(test);
            }

            Console.WriteLine("");

            foreach (var row in galaxy.UpdatedGalaxy)
            {
                var test = "";
                foreach (var letter in row)
                {
                    test += letter;
                }
                Console.WriteLine(test);
            }

            Console.WriteLine("Done!");
        }
    }
}