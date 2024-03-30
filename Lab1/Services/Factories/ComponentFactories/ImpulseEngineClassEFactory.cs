using Itmo.ObjectOrientedProgramming.Lab1.Entities.Components.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services.Factories.ComponentFactories;
public class ImpulseEngineClassEFactory
{
    private readonly double _engineCommonSpaceEffectiveness = 0.5;
    private readonly double _engineNitrinoParticleNebulaeEffectiveness = 0.5;
    private double _engineStartConsumption = 0.5;
    public ImpulseEngineClassE Buld()
    {
        return new ImpulseEngineClassE(
            _engineCommonSpaceEffectiveness,
            _engineNitrinoParticleNebulaeEffectiveness,
            _engineStartConsumption);
    }
}
