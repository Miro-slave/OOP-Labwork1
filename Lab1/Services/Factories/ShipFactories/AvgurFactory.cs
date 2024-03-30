using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Components.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;
using Itmo.ObjectOrientedProgramming.Lab1.Services.Factories.ComponentFactories;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services.Factories.ShipFactories;
internal class AvgurFactory
{
    private readonly double _shipMass = 250.0;
    public Avgur Build(bool hasPhotonDeflector)
    {
        return new Avgur(
            _shipMass,
            new HullClass3Factory().Build(),
            new DeflectorClass3Factory().Build(hasPhotonDeflector),
            new List<IEngine>() { new ImpulseEngineClassEFactory().Buld(), new JumpEngineAlphaFactory().Build() },
            null); // AntiNeutrinoEmitter
    }
}
