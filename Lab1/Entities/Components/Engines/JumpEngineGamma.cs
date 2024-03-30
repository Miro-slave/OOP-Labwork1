using System;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Route;
using Itmo.ObjectOrientedProgramming.Lab1.Models;
using Itmo.ObjectOrientedProgramming.Lab3;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Components.Engines;
public class JumpEngineGamma : IEngine
{
    private readonly double _highDensityNebulaeEffectiveness;
    private readonly double _maximumJumpLength;
    public JumpEngineGamma(
        double highDensityNebulaeEffectiveness,
        double maximumJumpLength)
    {
        _highDensityNebulaeEffectiveness = highDensityNebulaeEffectiveness;
        FuelType = new EngineFuelType.GravitonMatter();
        _maximumJumpLength = maximumJumpLength;
    }

    public EngineFuelType FuelType { get; }
    public double? TryCountFuelConsuming(IRouteSegment routeSegment, double mass)
    {
        Guard.NotNull(routeSegment, nameof(routeSegment));

        double totalConsumption = 0;
        if (routeSegment is CommonSpace ||
            routeSegment is NitrinoParticleNebulae ||
            routeSegment.Length > _maximumJumpLength)
        {
            return null;
        }
        else if (routeSegment is HighDensityNebulae)
        {
            if (routeSegment.Length > _maximumJumpLength)
            {
                return null;
            }

            totalConsumption += Math.Pow(routeSegment.Length, 2) * mass / _highDensityNebulaeEffectiveness;
        }
        else
        {
            throw new ArgumentException("unknown route segment type");
        }

        return totalConsumption;
    }
}