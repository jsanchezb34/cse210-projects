
public class Product
{
    private string _name;
    private int _productID;
    private double _price;
    private int _quantity;

    public string GetName()
    {
        return _name;
    }

    public int GetProductID()
    {
        return _productID;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    public Product(string name, int productID, double price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }
    
}