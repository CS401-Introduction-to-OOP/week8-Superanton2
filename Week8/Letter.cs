namespace Week8;

public class Letter : DeliveryItem
{
    public Letter(string Number, double Weight) : base(Number, Weight) { }

    public override double CalculateCost()
    {
        return 15 + (Weight * 10);
    }
}