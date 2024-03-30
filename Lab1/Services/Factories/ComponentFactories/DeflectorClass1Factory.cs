using Itmo.ObjectOrientedProgramming.Lab1.Entities.Components.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services.Factories.ComponentFactories;
public class DeflectorClass1Factory
{
    private readonly double _deflectorHealth = 10.0;
    private readonly double _asteriodResistance = 0.5;
    private readonly double _meteorResistance = 0.5;
    private readonly double _whaleResistance = 0.5;
    private readonly ComponentResistance _deflectorResistance;
    public DeflectorClass1Factory()
    {
        _deflectorResistance = new ComponentResistance(_asteriodResistance, _meteorResistance, _whaleResistance);
    }

    public DeflectorBase Build(bool hasPhotonDeflector = false)
    {
        if (hasPhotonDeflector)
        {
            return new PhotonDeflector(new DeflectorClass1(_deflectorResistance, _deflectorHealth));
        }
        else
        {
            return new DeflectorClass1(_deflectorResistance, _deflectorHealth);
        }
    }
}
