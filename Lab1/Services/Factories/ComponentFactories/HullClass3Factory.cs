using Itmo.ObjectOrientedProgramming.Lab1.Entities.Components.Hulls;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services.Factories.ComponentFactories;
public class HullClass3Factory
{
    private readonly double _hullHealth = 1000.0;
    private readonly double _asteriodResistance = 0.5;
    private readonly double _meteorResistance = 0.5;
    private readonly double _whaleResistance = 0.5;
    private readonly ComponentResistance _deflectorResistance;
    public HullClass3Factory()
    {
        _deflectorResistance = new ComponentResistance(_asteriodResistance, _meteorResistance, _whaleResistance);
    }

    public HullClass3 Build()
    {
        return new HullClass3(_deflectorResistance, _hullHealth);
    }
}
