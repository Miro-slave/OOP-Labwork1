using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Components;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Components.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Components.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Components.Hulls;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;
public class Vaklas : ShipBase
{
    public Vaklas(
        double mass,
        HullBase hull,
        DeflectorBase deflector,
        IEnumerable<IEngine> engines,
        AntiNeutrinoEmitter? antiNeutrinoEmitter = null)
        : base(mass, hull, deflector, engines, antiNeutrinoEmitter)
    {
    }
}
