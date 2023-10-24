public class Product
{
    public string Name { get; set; }
    public int ProductId { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public double GetTotalPrice()
    {
        return Price * Quantity;
    }
}   
