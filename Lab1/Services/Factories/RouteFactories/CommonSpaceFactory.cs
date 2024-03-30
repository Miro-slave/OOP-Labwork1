using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Route;
using Itmo.ObjectOrientedProgramming.Lab1.Services.Factories.ObstacleFactories;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services.Factories.RouteFactories;
public class CommonSpaceFactory
{
    private IObstacleFactory? _obstacleFactory;
    public CommonSpace Build(double length, int asteriodCount = 0, int meteorCount = 0)
    {
        ICollection<ObstacleBase> obstacles = new List<ObstacleBase>();

        _obstacleFactory = new AsteroidFactory();
        for (int i = 0; i < asteriodCount; i++)
        {
            obstacles.Add(_obstacleFactory.Build());
        }

        _obstacleFactory = new MeteorFactory();
        for (int i = 0; i < meteorCount; i++)
        {
            obstacles.Add(_obstacleFactory.Build());
        }

        return new CommonSpace(length, obstacles);
    }
}
