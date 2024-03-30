using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Components;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Components.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;
using Itmo.ObjectOrientedProgramming.Lab1.Services.Factories.ComponentFactories;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services.Factories.ShipFactories;
internal class MeridianFactory
{
    private readonly double _shipMass = 150.0;
    public Meridian Build(bool hasPhotonDeflector)
    {
        return new Meridian(
            _shipMass,
            new HullClass2Factory().Build(),
            new DeflectorClass2Factory().Build(hasPhotonDeflector),
            new List<IEngine>() { new ImpulseEngineClassEFactory().Buld() },
            new AntiNeutrinoEmitter());
    }
}
