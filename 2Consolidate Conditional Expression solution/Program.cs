using System;

class Program
{
    static void Main()
    {
        double result = DisabilityAmount(1.5, 8, false);
        Console.WriteLine($"Disability Amount: {result}");
    }

    static double DisabilityAmount(double seniority, int monthsDisabled, bool isPartTime)
    {
        if (IsNotEligibleForDisability(seniority, monthsDisabled, isPartTime))
        {
            return 0;
        }

        // Tính toán số tiền trợ cấp (giả sử)
        return 5000;
    }

    static bool IsNotEligibleForDisability(double seniority, int monthsDisabled, bool isPartTime)
    {
        return seniority < 2 || monthsDisabled > 12 || isPartTime;
    }
}