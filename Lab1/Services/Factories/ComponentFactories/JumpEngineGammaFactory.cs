using Itmo.ObjectOrientedProgramming.Lab1.Entities.Components.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services.Factories.ComponentFactories;
internal class JumpEngineGammaFactory
{
    private readonly double _highDensityNebulaeEffectiveness = 0.5;
    private readonly double _maximumJumpLength = 200;
    public JumpEngineGamma Build()
    {
        return new JumpEngineGamma(_highDensityNebulaeEffectiveness, _maximumJumpLength);
    }
}
