using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Components.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;
using Itmo.ObjectOrientedProgramming.Lab1.Services.Factories.ComponentFactories;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services.Factories.ShipFactories;
internal class VaklasFactory
{
    private readonly double _shipMass = 150.0;
    public Vaklas Build(bool hasPhotonDeflector)
    {
        return new Vaklas(
            _shipMass,
            new HullClass2Factory().Build(),
            new DeflectorClass1Factory().Build(hasPhotonDeflector),
            new List<IEngine>() { new ImpulseEngineClassEFactory().Buld(), new JumpEngineGammaFactory().Build() },
            null); // AntiNeutrinoEmitter
    }
}
