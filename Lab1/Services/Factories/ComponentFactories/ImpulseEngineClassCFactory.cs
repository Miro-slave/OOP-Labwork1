using Itmo.ObjectOrientedProgramming.Lab1.Entities.Components.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services.Factories.ComponentFactories;
public class ImpulseEngineClassCFactory
{
    private readonly double _engineCommonSpaceEffectiveness = 0.5;
    private readonly double _engineNitrinoParticleNebulaeEffectiveness = 0.5;
    private double _engineStartConsumption = 0.5;
    public ImpulseEngineClassC Buld()
    {
        return new ImpulseEngineClassC(
            _engineCommonSpaceEffectiveness,
            _engineNitrinoParticleNebulaeEffectiveness,
            _engineStartConsumption);
    }
}
