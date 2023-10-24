public class Order
{
    private List<Product> products = new List<Product>();
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double GetTotalCost()
    {
        double total = 0;
        foreach (var product in products)
        {
            total += product.GetTotalPrice();
        }
        total += customer.LivesInRSA() ? 5 : 35;
        return total;
    }

    public string GetPackingLabel()
    {
        var label = "";
        foreach (var product in products)
        {
            label += $"{product.Name} ({product.ProductId})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"{customer.Name}\n{customer.Address}";
    }
}
