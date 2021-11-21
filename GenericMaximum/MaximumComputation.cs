using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsMaximum
{
    public class MaximumComputation
    {
        public static int FindMax(int firstNumber, int secondNumber, int thirdNumber)
        {
            if (firstNumber.CompareTo(secondNumber) > 0 && firstNumber.CompareTo(thirdNumber) > 0)
            {
                return firstNumber;
            }
            if (secondNumber.CompareTo(firstNumber) > 0 && secondNumber.CompareTo(thirdNumber) > 0)
            {
                return secondNumber;
            }
            else
            {
                return thirdNumber;
            }
        }
        public static double FindMax(double firstNumber, double secondNumber, double thirdNumber)
        {
            if (firstNumber.CompareTo(secondNumber) > 0 && firstNumber.CompareTo(thirdNumber) > 0)
            {
                return firstNumber;
            }
            if (secondNumber.CompareTo(firstNumber) > 0 && secondNumber.CompareTo(thirdNumber) > 0)
            {
                return secondNumber;
            }
            else
            {
                return thirdNumber;
            }
        }
        public static string FindMax(string firstWord, string secondWord, string thirdWord)
        {
            if (firstWord.CompareTo(secondWord) > 0 && firstWord.CompareTo(thirdWord) > 0)
            {
                return firstWord;
            }
            if (secondWord.CompareTo(firstWord) > 0 && secondWord.CompareTo(thirdWord) > 0)
            {
                return secondWord;
            }
            else
            {
                return thirdWord;
            }
        }
    }
}