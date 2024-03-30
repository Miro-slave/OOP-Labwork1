using Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Models;
using Itmo.ObjectOrientedProgramming.Lab3;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Components.Hulls;
public abstract class HullBase : IDamageable
{
    private readonly ComponentResistance _resistance;
    private double _health;

    protected HullBase(ComponentResistance resistance, double health)
    {
        Guard.NotNull(resistance, nameof(resistance));
        _resistance = resistance;
        _health = health;
    }

    public bool IsDestroyedFlag { get { return _health <= 0; } }
    public void PassDamage(IDamager damager)
    {
        if (damager is Meteor)
        {
            _health -= (1 - _resistance.MeteorResistance) * damager.Damage;
        }
        else if (damager is Asteroid)
        {
            _health -= (1 - _resistance.MeteorResistance) * damager.Damage;
        }
        else if (damager is AntimatterFlash)
        {
            _health -= (1 - _resistance.MeteorResistance) * damager.Damage;
        }
        else if (damager is SpaceWhale)
        {
            _health -= (1 - _resistance.MeteorResistance) * damager.Damage;
        }
    }
}
