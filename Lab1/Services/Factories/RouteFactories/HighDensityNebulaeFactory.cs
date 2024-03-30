using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Route;
using Itmo.ObjectOrientedProgramming.Lab1.Services.Factories.ObstacleFactories;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services.Factories.RouteFactories;
public class HighDensityNebulaeFactory
{
    private IObstacleFactory? _obstacleFactory;
    public HighDensityNebulae Build(double length, int antimatterFlashCount = 0)
    {
        ICollection<ObstacleBase> obstacles = new List<ObstacleBase>();

        _obstacleFactory = new AntimatterFlashFacroty();
        for (int i = 0; i < antimatterFlashCount; i++)
        {
            obstacles.Add(_obstacleFactory.Build());
        }

        return new HighDensityNebulae(length, obstacles);
    }
}
