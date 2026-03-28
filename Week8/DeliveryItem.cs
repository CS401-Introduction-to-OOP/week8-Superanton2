namespace Week8;

public abstract class DeliveryItem
{
    public string TrackingNumber;
    public double Weight;

    public DeliveryItem(string number, double weight)
    {
        TrackingNumber = number;
        Weight = weight;
    }

    public abstract double CalculateCost();

    public virtual void PrintInfo()
    {
        Console.WriteLine($"{TrackingNumber} - {Weight}кг");
    }
}