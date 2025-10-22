vusing System;

public class Employee
{
    private double salary;

    public Employee(double salary)
    {
        this.salary = salary;
    }

    // ✅ Dùng tham số để truyền tỉ lệ tăng lương
    public void IncreaseSalary(double percent)
    {
        salary += salary * (percent / 100);
    }

    public double GetSalary()
    {
        return salary;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee(1000);

        emp.IncreaseSalary(10); // tăng 10%
        Console.WriteLine("After 10% increase: " + emp.GetSalary());

        emp.IncreaseSalary(20); // tăng 20%
        Console.WriteLine("After 20% increase: " + emp.GetSalary());

        emp.IncreaseSalary(30); // tăng 30%
        Console.WriteLine("After 30% increase: " + emp.GetSalary());
    }
}
