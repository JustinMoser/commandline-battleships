using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Battleships.Ships;

namespace Battleships.Managers
{
    public class FleetManager
    {
        public bool FleetIsDestroyed(Fleet fleet)
        {
            if(fleet.ShipCount == 0)
            {
                return true;
            }

            return false;
        }
    }
}
