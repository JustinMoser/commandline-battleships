using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Battleships.GridObjects
{
    public class GridCell
    {
        public KeyValuePair<string, int> Position { get; set; }
        public Guid ShipId { get; set; }
        public GridCellType GridCellType { get; set; }

        public GridCell(KeyValuePair<string, int> position, GridCellType gridCellType)
        {
            Position = position;
            GridCellType = gridCellType;
        }
    }
}
