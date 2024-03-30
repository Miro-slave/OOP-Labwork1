namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public abstract record EngineFuelType
{
    private EngineFuelType() { }
#pragma warning disable CA1034
    public sealed record ActivePlasma() : EngineFuelType;

    public sealed record GravitonMatter : EngineFuelType;

#pragma warning restore CA1034
}
