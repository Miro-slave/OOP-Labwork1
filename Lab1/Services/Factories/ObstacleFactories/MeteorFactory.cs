using Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services.Factories.ObstacleFactories;
public class MeteorFactory : IObstacleFactory
{
    private const double _meteorDamage = 100.00;
    public ObstacleBase Build()
    {
        return new Meteor(_meteorDamage);
    }
}
