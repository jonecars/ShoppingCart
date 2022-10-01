class Cart{

public List<Products>ProductList { get; set; }


public Cart()
{
    ProductList = new List<Products>();
}

public double Total()
{
    double TotalCost = 0;

    foreach (var P in ProductList)
    {
        TotalCost += P.Price;
    }
    return TotalCost;

}
}