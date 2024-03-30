using Itmo.ObjectOrientedProgramming.Lab1.Entities.Components.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services.Factories.ComponentFactories;
internal class JumpEngineAlphaFactory
{
    private readonly double _highDensityNebulaeEffectiveness = 0.5;
    private readonly double _maximumJumpLength = 50;
    public JumpEngineAlpha Build()
    {
        return new JumpEngineAlpha(_highDensityNebulaeEffectiveness, _maximumJumpLength);
    }
}
