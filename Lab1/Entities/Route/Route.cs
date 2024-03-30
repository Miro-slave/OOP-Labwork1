using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Route;
public class Route
{
    public Route(IEnumerable<IRouteSegment> segments)
    {
        Guard.NotNull(segments, nameof(segments));
        Segments = segments;
    }

    public IEnumerable<IRouteSegment> Segments { get; }
}
