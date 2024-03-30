using Itmo.ObjectOrientedProgramming.Lab1.Entities.Components.Hulls;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services.Factories.ComponentFactories;
public class HullClass1Factory
{
    private readonly double _hullHealth = 10.0;
    private readonly double _asteriodResistance = 0.5;
    private readonly double _meteorResistance = 0.5;
    private readonly double _whaleResistance = 0.5;
    private readonly ComponentResistance _deflectorResistance;
    public HullClass1Factory()
    {
        _deflectorResistance = new ComponentResistance(_asteriodResistance, _meteorResistance, _whaleResistance);
    }

    public HullClass1 Build()
    {
        return new HullClass1(_deflectorResistance, _hullHealth);
    }
}
