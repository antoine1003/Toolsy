using System;
using System.Collections.Generic;
using System.Text;

namespace Toolsy.Models
{
    public class Tile
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public Object Value { get; set; } // string or string[]
    }
}
