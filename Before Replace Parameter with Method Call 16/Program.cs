using System;

public class Product
{
    private double price;
    private double discount;

    public Product(double price, double discount)
    {
        this.price = price;
        this.discount = discount;
    }

    public double GetDiscount()
    {
        return discount;
    }

    // ❌ Phải truyền discount vào, dù có thể tự tính bên trong
    public double GetFinalPrice(double discount)
    {
        return price - (price * discount);
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Product p = new Product(1000, 0.1);

        // Gọi GetDiscount() rồi truyền vào GetFinalPrice()
        double finalPrice = p.GetFinalPrice(p.GetDiscount());
        Console.WriteLine("Final Price: " + finalPrice);
    }
}
