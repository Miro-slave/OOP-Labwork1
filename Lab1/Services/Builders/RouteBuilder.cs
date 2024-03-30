using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Route;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services.Builders;
internal class RouteBuilder : IRouteBuilder
{
    private List<IRouteSegment> _routeSegments = new List<IRouteSegment>();

    public Route Build()
    {
        return new Route(_routeSegments);
    }

    public IRouteBuilder Add(IRouteSegment segment)
    {
        _routeSegments.Add(segment);
        return this;
    }

    public IRouteBuilder Reset()
    {
        _routeSegments.Clear();
        return this;
    }
}
