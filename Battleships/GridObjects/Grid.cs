using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using Battleships.Ships;

namespace Battleships.GridObjects
{
    public class Grid
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public List<GridCell> Cells { get; set; }
        public Grid(int width, int height)
        {
            Width = width;
            Height = height;
            PopulateGrid();
        }

        private void PopulateGrid()
        {
            Cells = new List<GridCell>();
            char[] alpha = ConfigurationManager.AppSettings["VerticalKey"].ToCharArray();
            char[] horizontalCells = alpha.Take(Height).ToArray();

            for (var x = 0; x < horizontalCells.Length; x++)
            {
                for (var y = 0; y < Height; y++)
                {
                    var cell = new GridCell(new KeyValuePair<string, int>(horizontalCells[x].ToString(), y), GridCellType.OpenWater);
                    Cells.Add(cell);
                }
            }
        }

        public void PlaceShipsOnGrid(Fleet fleet)
        {
            foreach (var ship in fleet.Ships)
            {
                if(ship.Orientation == ShipOrientation.Vertical)
                {
                    
                }
                else if(ship.Orientation == ShipOrientation.Horizontal)
                {
                    
                }
            }
        }

        public void UpdateCells()
        {
            
        }
    }
}
