using System;

namespace GenericsMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome To Generic Maximum Problems");
                Console.WriteLine("Enter the Program that want to be executed : \n 1. Maximum Integer \n 2. Maximum Float \n 3. Largest String \n 4. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter First number, Second number, Third number : ");
                        int first = Convert.ToInt32(Console.ReadLine());
                        int second = Convert.ToInt32(Console.ReadLine());
                        int third = Convert.ToInt32(Console.ReadLine());
                        int result = MaximumComputation.FindMax(first, second, third);
                        Console.WriteLine("The Maximum Number is : " + result);
                        break;
                    case 2:
                        Console.WriteLine("Enter First number, Second number, Third number : ");
                        double firstNum = Convert.ToDouble(Console.ReadLine());
                        double secondNum = Convert.ToDouble(Console.ReadLine());
                        double thirdNum = Convert.ToDouble(Console.ReadLine());
                        double res = MaximumComputation.FindMax(firstNum, secondNum, thirdNum);
                        Console.WriteLine("The Maximum Number is : " + res);
                        break;
                    case 3:
                        Console.WriteLine("Enter Three Strings : ");
                        string firstName = Convert.ToString(Console.ReadLine());
                        string secondName = Convert.ToString(Console.ReadLine());
                        string thirdName = Convert.ToString(Console.ReadLine());
                        string largest = MaximumComputation.FindMax(firstName, secondName, thirdName);
                        Console.WriteLine("The Largest String is : " + largest);
                        break;
                    case 4:
                        flag = false;
                        break;
                }
            }
        }
    }
}