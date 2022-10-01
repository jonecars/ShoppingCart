public class Products
{
    public string ProductName { get; set; }
    public double Price { get; set; }

    public Products (string Name, double P)
    {
        ProductName = Name;
        Price = P;
    }
}