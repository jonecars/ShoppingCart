public class Products
{
    //Values for each product that will be in the cart.
    public string ProductName { get; set; }
    public double Price { get; set; }

    //Constructor for Products
    public Products (string Name, double P)
    {
        ProductName = Name;
        Price = P;
    }
}