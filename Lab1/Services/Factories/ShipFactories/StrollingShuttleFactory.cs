using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Components.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;
using Itmo.ObjectOrientedProgramming.Lab1.Services.Factories.ComponentFactories;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services.Factories.ShipFactories;
public class StrollingShuttleFactory
{
    private readonly double _shipMass = 20.0;
    public StrollingShuttle Build()
    {
        return new StrollingShuttle(
            _shipMass,
            new HullClass1Factory().Build(),
            null, // deflector
            new List<IEngine>() { new ImpulseEngineClassCFactory().Buld() },
            null); // AntiNeutrinoEmitter
    }
}
