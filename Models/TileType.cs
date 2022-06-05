using System;
using System.Collections.Generic;
using System.Text;

namespace Toolsy.Models
{
    public class TileType
    {
        private TileType(string value) { Value = value; }

        public string Value { get; private set; }

        public static TileType LINK { get { return new TileType("link"); } }
        public static TileType FILE_FOLDER { get { return new TileType("file-folder"); } }
    }
}
