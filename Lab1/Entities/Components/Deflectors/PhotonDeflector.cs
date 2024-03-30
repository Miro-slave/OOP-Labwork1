using Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Models;
using Itmo.ObjectOrientedProgramming.Lab3;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Components.Deflectors;
public class PhotonDeflector : DeflectorBase
{
    private int _availableChargeCount;
    public PhotonDeflector(DeflectorBase basicDeflector)
        : base(basicDeflector)
    {
        Guard.NotNull(basicDeflector, nameof(basicDeflector));
        _availableChargeCount = 3;
    }

    public int AvailableChargeCount { get; }

    public override void PassDamage(IDamager damager)
    {
        if (damager is AntimatterFlash && _availableChargeCount > 0)
        {
            _availableChargeCount--;
        }
        else if (damager is not AntimatterFlash)
        {
            base.PassDamage(damager);
        }
        else
        {
            Health = 0;
        }
    }
}
