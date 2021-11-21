﻿using System;
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
    }
}