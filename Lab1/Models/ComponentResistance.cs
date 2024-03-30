namespace Itmo.ObjectOrientedProgramming.Lab1.Models;
public record class ComponentResistance
{
    public ComponentResistance(
        double asteroidResistance = 0,
        double meteorResistance = 0,
        double whaleResistance = 0,
        double antimatterResistance = 0)
    {
        AsteroidResistance = asteroidResistance;
        MeteorResistance = meteorResistance;
        WhaleResistance = whaleResistance;
        AntimatterResistance = antimatterResistance;
    }

    public double AsteroidResistance { get; }
    public double MeteorResistance { get; }
    public double WhaleResistance { get; }
    public double AntimatterResistance { get; }
}
