using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using Battleships.GridObjects;

namespace Battleships.Ships
{
    public class Ship
    {
        public Guid Id { get; set; }
        public ShipType ShipType { get; set; }
        public int Length { get; set; }
        public KeyValuePair<string,int> Position { get; set; }
        public ShipOrientation Orientation { get; set; }
        public List<KeyValuePair<string, int>> OccupiedCells { get; set; }
        public int Health { get; set; }

        public Ship(ShipType shipType, ShipOrientation orientation, int gridWidth, int gridHeight)
        {
            Id = Guid.NewGuid();
            ShipType = shipType;

            switch (shipType)
            {
                case ShipType.Destroyer:
                    Length = 4;
                    Health = 4;
                    break;
                case ShipType.Battleship:
                    Length = 5;
                    Health = 5;
                    break;
            }

            Orientation = orientation;
            Position = SetShipPosition(gridWidth, gridHeight);
            
        }

        public KeyValuePair<string,int> SetShipPosition(int xRange, int yRange)
        {
            var rX = new System.Random();
            var rY = new System.Random();
            
            var xInt = rX.Next(0, xRange);
            var x = ConfigurationManager.AppSettings["VerticalKey"].ToCharArray()[xInt].ToString();
            var y = rY.Next(0, yRange);
            return new KeyValuePair<string, int>(x,y);
        }

        //public List<KeyValuePair<string, int>> SetOccupiedCells()
        //{
            
        //}
    }
}
