using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Battleships.GridObjects;
using Battleships.Interfaces;
using Battleships.Ships;

namespace Battleships
{
    public class Program
    {

        static void Main(string[] args)
        {
            var grid = new Grid(10, 10);

            var fleet = new Fleet(new List<Ship>
            {
                new Ship(ShipType.Battleship, ShipOrientation.Horizontal, grid.Width, grid.Height),
                new Ship(ShipType.Destroyer, ShipOrientation.Vertical, grid.Width, grid.Height),
                new Ship(ShipType.Destroyer, ShipOrientation.Horizontal, grid.Width, grid.Height)
            });

            grid.PlaceShipsOnGrid(fleet);
        }
    }
}