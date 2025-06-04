using System;
using System.Text;

namespace FirstDay;

public class SimpleParser
{
    public int ParseAndSum(string numbers)
    {
        if (numbers.Length == 0)
        {
            return 0;
        }

        if (!numbers.Contains(","))
        {
            return int.Parse(numbers);
        }
        else
        {
            throw new InvalidOperationException("I can only handle 0 or 1 numbers for now!");
        }
    }

    public string NoRepeat(string target, char ch)
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < target.Length; i++)
        {
            if (target[i] != ch)
                result.Append(target[i]);
        }

        return result.ToString();
    }

    public bool IsPrime(int number)
    {
        if (number < 2 || number > 10000000)
            throw new ArgumentOutOfRangeException("Number must be between 2 and 10,000,000");

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
}