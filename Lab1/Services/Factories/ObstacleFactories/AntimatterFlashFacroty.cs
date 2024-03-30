using Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services.Factories.ObstacleFactories;
public class AntimatterFlashFacroty : IObstacleFactory
{
    private const double _antimatterFlashDamage = 1.00;
    public ObstacleBase Build()
    {
        return new AntimatterFlash(_antimatterFlashDamage);
    }
}
