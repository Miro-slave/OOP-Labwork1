using Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services.Factories.ObstacleFactories;
public class AsteroidFactory : IObstacleFactory
{
    private const double _asteroidDamage = 10.00;
    public ObstacleBase Build()
    {
        return new Asteroid(_asteroidDamage);
    }
}
