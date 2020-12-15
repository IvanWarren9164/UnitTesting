using System;

namespace TempConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class TestingClass
    {

        public double FahrenheitConvert(double temp)
        {
            temp = (temp * 1.8) + 32;
            return temp;
        }

        public double CelsiusConvert(double temp)
        {
            temp = (temp - 32) * 0.5556;
            return temp;
        }

        public string FizzBuzzBaz(int num)
        {
            if (num % 3 == 0 || num.ToString().Contains("3"))
            {
                if (num % 3 == 0 || num.ToString().Contains("3") && (num % 5 == 0 || num.ToString().Contains("5")))
                {
                    if (num % 3 == 0 || num.ToString().Contains("3") && (num % 5 == 0 || num.ToString().Contains("5")) && (num % 7 == 0 || num.ToString().Contains("7")))
                    {
                        return "FizzBuzzBaz";
                    }
                    return "FizzBuzz";
                }
                if (num % 3 == 0 || num.ToString().Contains("3") && (num % 5 == 0 || num.ToString().Contains("7")))
                {
                    if (num % 3 == 0 || num.ToString().Contains("3") && (num % 5 == 0 || num.ToString().Contains("5")) && (num % 7 == 0 || num.ToString().Contains("7")))
                    {
                        return "FizzBuzzBaz";
                    }
                    return "FizzBaz";
                }
                return "Fizz";
            }
            else if (num % 5 == 0 || num.ToString().Contains("5"))
            {
                if (num % 3 == 0 || num.ToString().Contains("3") && (num % 5 == 0 || num.ToString().Contains("5")))
                {
                    if (num % 3 == 0 || num.ToString().Contains("3") && (num % 5 == 0 || num.ToString().Contains("5")) && (num % 7 == 0 || num.ToString().Contains("7")))
                    {
                        return "FizzBuzzBaz";
                    }
                    return "FizzBuzz";
                }
                if (num % 5 == 0 || num.ToString().Contains("5") && (num % 5 == 0 || num.ToString().Contains("7")))
                {
                    if (num % 3 == 0 || num.ToString().Contains("3") && (num % 5 == 0 || num.ToString().Contains("5")) && (num % 7 == 0 || num.ToString().Contains("7")))
                    {
                        return "FizzBuzzBaz";
                    }
                    return "BuzzBaz";
                }
                return "Buzz";
            }
            else if (num % 7 == 0 || num.ToString().Contains("7"))
            {
                if (num % 3 == 0 || num.ToString().Contains("3") && (num % 5 == 0 || num.ToString().Contains("7")))
                {
                    if (num % 3 == 0 || num.ToString().Contains("3") && (num % 5 == 0 || num.ToString().Contains("5")) && (num % 7 == 0 || num.ToString().Contains("7")))
                    {
                        return "FizzBuzzBaz";
                    }
                    return "FizzBaz";
                }
                if (num % 5 == 0 || num.ToString().Contains("5") && (num % 5 == 0 || num.ToString().Contains("7")))
                {
                    if (num % 3 == 0 || num.ToString().Contains("3") && (num % 5 == 0 || num.ToString().Contains("5")) && (num % 7 == 0 || num.ToString().Contains("7")))
                    {
                        return "FizzBuzzBaz";
                    }
                    return "BuzzBaz";
                }
                return "Baz";
            }
            {
                return num.ToString();
            }

        }
    }
}
