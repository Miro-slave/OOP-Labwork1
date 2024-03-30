using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Route;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services;
public interface IRoutePassingService
{
    public PassResult TryPass(ShipBase ship, Route route, FuelPrice fuelPrice);
    public ShipBase? TryChooseBestShip(IEnumerable<ShipBase> ships, Route route, FuelPrice fuelPrice);
}
