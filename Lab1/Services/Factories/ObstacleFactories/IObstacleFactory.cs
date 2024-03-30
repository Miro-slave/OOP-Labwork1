using Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services.Factories.ObstacleFactories;
public interface IObstacleFactory
{
    public ObstacleBase Build();
}
