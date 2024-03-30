using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;
public abstract class ObstacleBase : IDamager
{
    protected ObstacleBase(double damage)
    {
        Damage = damage;
    }

    public double Damage { get; }
}
