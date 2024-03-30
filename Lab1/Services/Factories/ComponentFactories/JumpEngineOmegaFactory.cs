using Itmo.ObjectOrientedProgramming.Lab1.Entities.Components.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services.Factories.ComponentFactories;
internal class JumpEngineOmegaFactory
{
    private readonly double _highDensityNebulaeEffectiveness = 0.5;
    private readonly double _maximumJumpLength = 100;
    public JumpEngineOmega Build()
    {
        return new JumpEngineOmega(_highDensityNebulaeEffectiveness, _maximumJumpLength);
    }
}
