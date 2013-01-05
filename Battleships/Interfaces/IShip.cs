using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Battleships.Interfaces
{
    public interface IShip
    {
        Guid Id { get; set; }
        int Length { get; }
        Point Position { get; set; }
        ShipOrientation Orientation { get; set; }
        int HitCount { get; set; }


        Point SetShipPosition(int xRange, int yRange);
    }
}
