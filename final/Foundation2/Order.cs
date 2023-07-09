public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public Customer GetCustomer()
    {
        return _customer;
    }

    public List<Product> GetProducts()
    {
        return _products;
    }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.CalculatePrice();
        }

        decimal shippingCost = _customer.IsUSA() ? 5 :35;
        return totalCost + shippingCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += "Product: " + product.GetName() + ", ID: " + product.GetProductId() + "\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string customerName = _customer.GetName();
        string customerAddress = _customer.GetAddress().GetFullAddress();
        return "Name: " + customerName + "\nAddress: " + customerAddress;
    }
}
