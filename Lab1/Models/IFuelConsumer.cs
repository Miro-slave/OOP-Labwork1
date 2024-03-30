using Itmo.ObjectOrientedProgramming.Lab1.Entities.Route;
namespace Itmo.ObjectOrientedProgramming.Lab1.Models;
public interface IFuelConsumer
{
    public double? TryCountFuelConsumingPrice(IRouteSegment routeSegment, FuelPrice fuelPrice);
}
