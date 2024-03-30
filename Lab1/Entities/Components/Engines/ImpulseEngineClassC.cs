using System;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Route;
using Itmo.ObjectOrientedProgramming.Lab1.Models;
using Itmo.ObjectOrientedProgramming.Lab3;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Components.Engines;
public class ImpulseEngineClassC : IEngine
{
    private readonly double _commonSpaceEffectiveness;
    private readonly double _nitrinoParticleNebulaeEffectiveness;
    private double _startConsumption;
    public ImpulseEngineClassC(
        double commonSpaceEffecctiveness,
        double nitrinoParticleNebulaeEffectiveness,
        double startConsumption = 0)
    {
        _commonSpaceEffectiveness = commonSpaceEffecctiveness;
        _nitrinoParticleNebulaeEffectiveness = nitrinoParticleNebulaeEffectiveness;
        FuelType = new EngineFuelType.ActivePlasma();
        _startConsumption = startConsumption;
    }

    public EngineFuelType FuelType { get; }
    public double? TryCountFuelConsuming(IRouteSegment routeSegment, double mass)
    {
        Guard.NotNull(routeSegment, nameof(routeSegment));

        double totalConsumption = _startConsumption;
        if (routeSegment is CommonSpace)
        {
            totalConsumption += routeSegment.Length * mass / _commonSpaceEffectiveness;
        }
        else if (routeSegment is HighDensityNebulae)
        {
            return null;
        }
        else if (routeSegment is NitrinoParticleNebulae)
        {
            totalConsumption += routeSegment.Length * mass / _nitrinoParticleNebulaeEffectiveness;
        }
        else
        {
            throw new ArgumentException("unknown route segment type");
        }

        return totalConsumption;
    }
}
