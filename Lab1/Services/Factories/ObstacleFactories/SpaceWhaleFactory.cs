using Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services.Factories.ObstacleFactories;
public class SpaceWhaleFactory : IObstacleFactory
{
    private const double _spaceWhaleDamage = 1000.00;
    public ObstacleBase Build()
    {
        return new SpaceWhale(_spaceWhaleDamage);
    }
}
