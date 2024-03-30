using Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Models;
using Itmo.ObjectOrientedProgramming.Lab3;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Components.Deflectors;
public abstract class DeflectorBase : IDamageable
{
    private readonly ComponentResistance _resistance;

    protected DeflectorBase(ComponentResistance resistance, double health)
    {
        Guard.NotNull(resistance, nameof(resistance));
        _resistance = resistance;
        Health = health;
    }

    protected DeflectorBase(DeflectorBase other)
    {
        Guard.NotNull(other, nameof(other));
        _resistance = other._resistance;
        Health = other.Health;
    }

    public bool IsDestroyedFlag { get { return Health <= 0; } }
    protected double Health { get; set; }
    public virtual void PassDamage(IDamager damager)
    {
        if (damager is Meteor)
        {
            Health -= (1 - _resistance.MeteorResistance) * damager.Damage;
        }
        else if (damager is Asteroid)
        {
            Health -= (1 - _resistance.MeteorResistance) * damager.Damage;
        }
        else if (damager is AntimatterFlash)
        {
            Health -= (1 - _resistance.MeteorResistance) * damager.Damage;
        }
        else if (damager is SpaceWhale)
        {
            Health -= (1 - _resistance.MeteorResistance) * damager.Damage;
        }
    }
}
