using System.Reflection.Emit;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public void SetProduct(Product product)
    {
        _products.Add(product);
    }
    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }
    public double ComputeTotal()
    {
        double total = 0;

        foreach (Product product in _products)
        {
            total = total + product.GetTotal();
        }
        if (_customer.CheckAddress())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }
    public string DisplayPackingLabel()
    {
        string packing = "";
        foreach (Product product in _products)
        {
            string name = product.GetName();
            string id = product.GetId();
            string pack = $"Product name: {name}, ID: {id}";
            packing = packing + "|" + pack;
        }

        return packing;
    }
    public string DisplayShippingLabel()
    {
        string name = _customer.GetCustomerName();
        string customerAddress = _customer.GetCustomerAddress();

        string ship = $"Customer name: {name}\nAddress:\n{customerAddress}";

        return ship;
    }
}