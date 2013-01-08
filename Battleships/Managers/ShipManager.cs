using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Battleships.Ships;

namespace Battleships.Managers
{
    public class ShipManager
    {
        private static Fleet _fleet { get; set; }
        public ShipManager(Fleet fleet)
        {
            _fleet = fleet;
        }

        public Ship ShipById(Guid id)
        {
            for (int i = 0; i < _fleet.Ships.Count; i++)
            {
                Ship s = _fleet.Ships[i];
                if (s.Id == id) return s;
            }

            return null;
        }

        public List<Ship> AllShips()
        {
            return _fleet.Ships;
        }

        public bool ShipIsSunk(Ship ship)
        {
            return ship.Health == 0;
        }
    }
}
