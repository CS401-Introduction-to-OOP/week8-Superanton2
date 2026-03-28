namespace Week8;

public class CargoContainer<T> where T: DeliveryItem
{
    private List<DeliveryItem> _container;

    public CargoContainer()
    {
        _container = new List<DeliveryItem>();
    }

    public void AddItem(T item) => _container.Add(item);

    public double GetTotalCost()
    {
        double sum = 0;
        foreach (DeliveryItem item in _container)
            sum += item.CalculateCost();

        return sum;
    }
}