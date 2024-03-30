using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Route;
using Itmo.ObjectOrientedProgramming.Lab1.Services.Factories.ObstacleFactories;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services.Factories.RouteFactories;
public class NitrinoParticleNebulaeFactory
{
    private IObstacleFactory? _obstacleFactory;
    public NitrinoParticleNebulae Build(double length, int spaceWhaleCount = 0)
    {
        ICollection<ObstacleBase> obstacles = new List<ObstacleBase>();

        _obstacleFactory = new SpaceWhaleFactory();
        for (int i = 0; i < spaceWhaleCount; i++)
        {
            obstacles.Add(_obstacleFactory.Build());
        }

        return new NitrinoParticleNebulae(length, obstacles);
    }
}
