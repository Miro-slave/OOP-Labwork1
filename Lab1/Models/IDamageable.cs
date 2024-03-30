namespace Itmo.ObjectOrientedProgramming.Lab1.Models;
public interface IDamageable
{
    public bool IsDestroyedFlag { get; }
    public void PassDamage(IDamager damager);
}
