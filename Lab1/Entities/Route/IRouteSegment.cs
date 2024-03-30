using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Route;
public interface IRouteSegment
{
    public double Length { get; }
    public IEnumerable<ObstacleBase> Obstacles { get; }
}
