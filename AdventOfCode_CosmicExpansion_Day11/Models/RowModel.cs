using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_CosmicExpansion_Day11.Models
{
    public class RowModel
    {
        public List<string> Row {  get; set; }

        public RowModel(List<string> row)
        {
            Row = row;  
        }
    }
}
