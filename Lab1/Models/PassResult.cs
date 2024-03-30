namespace Itmo.ObjectOrientedProgramming.Lab1.Models;
public abstract record PassResult
{
    private PassResult() { }
#pragma warning disable CA1034
    public sealed record Success(double TotalPrice) : PassResult;

    public sealed record ShipIsLost : PassResult;

    public sealed record ShipIsDestroyed : PassResult;

    public sealed record CrewIsDead : PassResult;
#pragma warning restore CA1034
}
