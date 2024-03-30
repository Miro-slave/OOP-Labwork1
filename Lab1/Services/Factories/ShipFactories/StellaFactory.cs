using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Components.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;
using Itmo.ObjectOrientedProgramming.Lab1.Services.Factories.ComponentFactories;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services.Factories.ShipFactories;
internal class StellaFactory
{
    private readonly double _shipMass = 50.0;
    public Stella Build(bool hasPhotonDeflector)
    {
        return new Stella(
            _shipMass,
            new HullClass1Factory().Build(),
            new DeflectorClass1Factory().Build(hasPhotonDeflector),
            new List<IEngine>() { new ImpulseEngineClassCFactory().Buld(), new JumpEngineOmegaFactory().Build() },
            null); // AntiNeutrinoEmitter
    }
}
