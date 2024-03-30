namespace Itmo.ObjectOrientedProgramming.Lab1.Models;
public record class FuelPrice
{
    public FuelPrice(
        double activePlasmaPrice,
        double gravitonMatterPrice)
    {
        ActivePlasmaPrice = activePlasmaPrice;
        GravitonMatterPrice = gravitonMatterPrice;
    }

    public double ActivePlasmaPrice { get; }
    public double GravitonMatterPrice { get; }
}
