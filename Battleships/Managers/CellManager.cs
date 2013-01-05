using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Battleships.GridObjects;

namespace Battleships.Managers
{
    public class CellManager
    {
        private static Grid _grid { get; set; }

        public CellManager(Grid grid)
        {
            _grid = grid;
        }

        public GridCell CellAtCoordinate(string x, string y)
        {
            for (int index = 0; index < _grid.Cells.Count; index++)
            {
                GridCell c = _grid.Cells[index];
                if (c.Position.Key == x && c.Position.Value == Int32.Parse(y)) return c;
            }
            return null;
        }
    }
}
