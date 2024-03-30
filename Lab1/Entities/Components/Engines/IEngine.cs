using Itmo.ObjectOrientedProgramming.Lab1.Entities.Route;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Components.Engines;
public interface IEngine
{
    public EngineFuelType FuelType { get; }
    public double? TryCountFuelConsuming(IRouteSegment routeSegment, double mass);
}
