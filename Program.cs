using System;

class Product
{
    public int Id;
    public string Name;
    public double Price;
    public int Stock;

    public void DisplayProduct()
    {
        Console.WriteLine($"ID Number:{Id} | {Name} - {Price} (Stock: {Stock})");
    }

    public double GetItemTotal(int quantity)
    {
        return Price * quantity;
    }

    public bool HasEnoughStock(int quantity)
    {
        return quantity <= Stock;
    }

    public void DeductStock(int quantity)
    {
        Stock -= quantity;
    }
}