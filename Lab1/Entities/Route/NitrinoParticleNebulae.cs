using System;
using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab3;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Route;

public class NitrinoParticleNebulae : IRouteSegment
{
    public NitrinoParticleNebulae(double length, IEnumerable<ObstacleBase> obstacles)
    {
        Guard.NotNull(obstacles, nameof(obstacles));
        if (obstacles.FirstOrDefault(obstacle => obstacle is not SpaceWhale) != null)
        {
            throw new ArgumentException("Wrong obstacle for route segment exception");
        }

        Length = length;
        Obstacles = obstacles;
    }

    public double Length { get; }
    public IEnumerable<ObstacleBase> Obstacles { get; }
}
