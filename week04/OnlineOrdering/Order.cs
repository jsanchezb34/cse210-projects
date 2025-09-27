
using System.Collections.Generic;   

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;


    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalcost()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        total += GetShippingCost();
        return total;
    }
    private double GetShippingCost()
    {
        return 5;
    }

    private double GetShipingCost()
    {
        return 5;
    }
    
    public string GetPackingLabel()
{
    string Label = "Packing Label:\n";
    foreach (Product product in _products)
    {
        Label += $"{product.GetName()} (ID: {product.GetProductID()}) - Quantity: {product.GetQuantity()}\n";
    }
    return Label;
    }
    public string GetShippingLabel()
    {
    return $"Shipping Label:\nCustomer: {_customer.GetName()}\nAddres: {_customer.GetAddress()}";
    }
}

