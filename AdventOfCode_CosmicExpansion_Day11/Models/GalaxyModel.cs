using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_CosmicExpansion_Day11.Models
{
    public class GalaxyModel
    {
        public List<List<string>> Galaxy { get; set; }
        public List<List<string>> UpdatedGalaxy { get; set; }

        public GalaxyModel()
        {
            Galaxy = new List<List<string>>();
            UpdatedGalaxy = new List<List<string>>();
        }
    }
}
