﻿using Tyuiu.StepanyukMV.Sprint0.Task6.V0.Lib;
namespace Tyuiu.StepanyukMV.Sprint0.Task6.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Сумма элементов массива = " + DataService.AdditionArray(numsArray));
            Console.WriteLine("Сумма элементов массива = " + DataService.SubtractionArray(numsArray));
            Console.WriteLine("Сумма элементов массива = " + DataService.MultiplicationArray(numsArray));

        }
    }
}