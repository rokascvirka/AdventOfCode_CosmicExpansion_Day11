using AdventOfCode_CosmicExpansion_Day11.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_CosmicExpansion_Day11
{
    public class GalaxyProcessor
    {
        public static void ExpandGalaxy(GalaxyModel galaxy)
        {
            AddRows(galaxy);
            AddColumns(galaxy);
        }


        public static void AddRows(GalaxyModel galaxy)
        {
            for (int i = 0; i < galaxy.Galaxy.Count; i++)
            {
                
                if (galaxy.Galaxy[i].Contains("#"))
                {
                    galaxy.UpdatedGalaxy.Add(galaxy.Galaxy[i]);
                    continue;
                }
                else
                {
                    galaxy.UpdatedGalaxy.Add(galaxy.Galaxy[i]);
                    galaxy.UpdatedGalaxy.Add(galaxy.Galaxy[i]);
                }
            }
        }

        public static void AddColumns(GalaxyModel galaxy)
        {
            if (galaxy.Galaxy == null || galaxy.Galaxy.Count == 0 || galaxy.Galaxy[0].Count == 0)
                return;

            galaxy.UpdatedGalaxy = galaxy.Galaxy.Select(row => new List<string>(row)).ToList();
            int numColumns = galaxy.Galaxy[0].Count;

            for (int column = 0; column < numColumns; column++)
            {
                bool isAllDots = true;

                for (int row = 0; row < galaxy.Galaxy.Count; row++)
                {
                    if (galaxy.Galaxy[row].Count <= column || galaxy.Galaxy[row][column] != ".")
                    {
                        isAllDots = false;
                        break;
                    }
                }

                if (isAllDots)
                {
                    foreach (var line in galaxy.UpdatedGalaxy)
                    {
                        line.Insert(column + 1, ".");
                    }
                }
            }
        }

    }
}
