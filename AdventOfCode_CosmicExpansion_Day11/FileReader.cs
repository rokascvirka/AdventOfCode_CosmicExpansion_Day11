using AdventOfCode_CosmicExpansion_Day11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_CosmicExpansion_Day11
{
    public static class FileReader
    {
        public static GalaxyModel ReadFromFile(string path)
        {
            GalaxyModel galaxy = new GalaxyModel();

            using (StreamReader sr = new StreamReader(path))
            {
                var text = sr.ReadToEnd().Split(Environment.NewLine);

                foreach (var line in text)
                {
                    if(!string.IsNullOrEmpty(line))
                    {
                        var row = line.Select(x => x.ToString()).ToList(); 
                        galaxy.Galaxy.Add(row);
                    }
                }
            }

            return galaxy;
        }
    }
}
