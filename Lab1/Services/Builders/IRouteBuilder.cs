using Itmo.ObjectOrientedProgramming.Lab1.Entities.Route;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services.Builders;
public interface IRouteBuilder
{
    public Route Build();
    public IRouteBuilder Add(IRouteSegment segment);
    public IRouteBuilder Reset();
}
