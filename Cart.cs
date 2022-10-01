class Cart{

//Make a list to hold the products in the shopping cart
public List<Products>ProductList { get; set; }

//Initialize the list
public Cart()
{
    ProductList = new List<Products>();
}
//Get total of product list (method)
public double Total()
{
    //Set starting cost to 0.
    double TotalCost = 0;
    //Loop for the Product list adding the price from teach to total cost.
    foreach (var P in ProductList)
    {
        TotalCost += P.Price;
    }
    return TotalCost;

}
}