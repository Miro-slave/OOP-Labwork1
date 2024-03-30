using Itmo.ObjectOrientedProgramming.Lab1.Entities.Components.Hulls;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services.Factories.ComponentFactories;
public class HullClass2Factory
{
    private readonly double _hullHealth = 700.0;
    private readonly double _asteriodResistance = 0.5;
    private readonly double _meteorResistance = 0.5;
    private readonly double _whaleResistance = 0.5;
    private readonly ComponentResistance _deflectorResistance;
    public HullClass2Factory()
    {
        _deflectorResistance = new ComponentResistance(_asteriodResistance, _meteorResistance, _whaleResistance);
    }

    public HullClass2 Build()
    {
        return new HullClass2(_deflectorResistance, _hullHealth);
    }
}
