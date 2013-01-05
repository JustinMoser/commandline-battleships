using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Battleships.Ships
{
    public class Fleet
    {
        private static List<Ship> _ships { get; set; }
        public List<Ship> Ships { get; set; }
        public int ShipCount { get; set; }

        public Fleet(List<Ship> ships)
        {
            _ships = ships;
            Ships = _ships;
            ShipCount = ships.Count;
        }
    }
}
