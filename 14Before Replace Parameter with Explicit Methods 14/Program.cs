using System;

public class Order
{
    private double amount;

    public Order(double amount)
    {
        this.amount = amount;
    }

    // ❌ Một phương thức làm nhiều việc dựa vào tham số
    public void ProcessOrder(string type)
    {
        if (type == "normal")
        {
            Console.WriteLine("Processing normal order: " + amount);
        }
        else if (type == "express")
        {
            Console.WriteLine("Processing express order: " + amount);
        }
        else if (type == "international")
        {
            Console.WriteLine("Processing international order: " + amount);
        }
        else
        {
            Console.WriteLine("Unknown order type!");
        }
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Order o1 = new Order(500);
        o1.ProcessOrder("normal");

        Order o2 = new Order(800);
        o2.ProcessOrder("express");
    }
}