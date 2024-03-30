using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Route;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;
using Itmo.ObjectOrientedProgramming.Lab1.Models;
using Itmo.ObjectOrientedProgramming.Lab3;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services;
public class RoutePassingService : IRoutePassingService
{
    public PassResult TryPass(
        ShipBase ship,
        Route route,
        FuelPrice fuelPrice)
    {
        Guard.NotNull(ship, nameof(ship));
        Guard.NotNull(route, nameof(route));
        Guard.NotNull(fuelPrice, nameof(fuelPrice));

        double totalPrice = 0;
        foreach (IRouteSegment routSegment in route.Segments)
        {
            PassResult passResult = ship.TryPassSegment(routSegment, fuelPrice);

            if (passResult is PassResult.Success)
            {
                totalPrice += ((PassResult.Success)passResult).TotalPrice;
            }
            else
            {
                return passResult;
            }
        }

        return new PassResult.Success(totalPrice);
    }

    public ShipBase? TryChooseBestShip(
        IEnumerable<ShipBase> ships,
        Route route,
        FuelPrice fuelPrice)
    {
        Guard.NotNull(ships, nameof(ships));
        Guard.NotNull(route, nameof(route));
        Guard.NotNull(fuelPrice, nameof(fuelPrice));

        ShipBase? bestShip = null;
        double? bestPrice = null;
        foreach (ShipBase ship in ships)
        {
            PassResult shipResult = TryPass(ship, route, fuelPrice);

            if (shipResult is PassResult.Success)
            {
                if (!bestPrice.HasValue)
                {
                    bestPrice = ((PassResult.Success)shipResult).TotalPrice;
                    bestShip = ship;
                }
                else if (bestPrice > ((PassResult.Success)shipResult).TotalPrice)
                {
                    bestPrice = ((PassResult.Success)shipResult).TotalPrice;
                    bestShip = ship;
                }
            }
        }

        return bestShip;
    }
}
