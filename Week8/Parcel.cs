namespace Week8;

public class Parcel : DeliveryItem
{
    private string Dimensions;
        
    public Parcel(string Number, double Weight, string Dimensions) : base(Number, Weight) { }

    public override double CalculateCost()
    {
        return 50 + (Weight * 25);
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Габарити: {Dimensions}");
    }
}