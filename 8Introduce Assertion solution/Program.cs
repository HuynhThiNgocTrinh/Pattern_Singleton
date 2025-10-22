using System;
using System.Diagnostics;

class Project
{
    public double GetMemberExpenseLimit() => 5000;
}

class Employee
{
    private const double NULL_EXPENSE = -1;
    private double expenseLimit;
    private Project primaryProject;

    public Employee(double expenseLimit, Project project)
    {
        this.expenseLimit = expenseLimit;
        this.primaryProject = project;
    }

    public double GetExpenseLimit()
    {
        // Assertion: must have either expenseLimit or primaryProject
        Debug.Assert(expenseLimit != NULL_EXPENSE || primaryProject != null,
            "Either expenseLimit must be set or primaryProject must not be null.");

        return (expenseLimit != NULL_EXPENSE)
            ? expenseLimit
            : primaryProject.GetMemberExpenseLimit();
    }
}

class Program
{
    static void Main()
    {
        Employee e1 = new Employee(3000, null);
        Employee e2 = new Employee(-1, new Project());

        Console.WriteLine("Employee 1 limit: " + e1.GetExpenseLimit());
        Console.WriteLine("Employee 2 limit: " + e2.GetExpenseLimit());
    }
}