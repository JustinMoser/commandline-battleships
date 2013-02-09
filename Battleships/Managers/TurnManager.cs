using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Battleships.GridObjects;
using Battleships.Ships;

namespace Battleships.Managers
{
    /// <summary>
    /// Manages turns
    /// Generic TakeTurn method, that takes x+y as string parameters
    /// Returns result of shot to console, abstracts any response logic and feedback to console into own class.
    /// Instantiates CellManager, ShipManager and FleetManager
    ///</summary>
    /// <example>
    /// var grid = new Grid(10,10)
    /// var fleet = new Fleet(new List<Ship>());
    /// var turnMgr = new TurnManager(grid, fleet)
    /// turnMgr.TakeTurn(5,7);
    /// </example>
    public class TurnManager
    {
        private CellManager _cellManager { get; set; }
        private ShipManager _shipManager { get; set; }
        private FleetManager _fleetManager { get; set; }

        private Fleet _fleet { get; set; }

        private TurnManager(Grid grid, Fleet fleet)
        {
            _cellManager = new CellManager(grid);
            _shipManager = new ShipManager(fleet);
            _fleetManager = new FleetManager();
        }

        public void TakeTurn(string x, string y)
        {
            var cell = _cellManager.CellAtCoordinate(x, y);
            if(cell.GridCellType == GridCellType.OpenWater)
            {
                Console.WriteLine("Splash! Shot Missed!");
            }
            else
            {
                Console.WriteLine("BOOM! Hit!");
                var shipAtCell = _shipManager.ShipById(cell.ShipId);
                shipAtCell.Health += -1;
                if (_shipManager.ShipIsSunk(shipAtCell))
                {
                    Console.WriteLine("Ship Destroyed! " + shipAtCell.ShipType + " Sunk!");
                    _fleet.ShipCount += -1;

                    if(_fleetManager.FleetIsDestroyed(_fleet))
                    {
                        Console.WriteLine("Fleet Destroyed! Congratulations! You Win!");
                    }
                }
                cell.GridCellType = GridCellType.OpenWater;
            }
        }
    }
}
