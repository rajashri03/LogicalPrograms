using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class FibonacciSeries
    {
    int Num, firstNumber=0, secondNumber=1;
    int Result;
    public void FiboSeries()
    {
        Console.Write("Enter Number to Find  Fibonacci Series:");
        Num = Convert.ToInt32(Console.ReadLine());
        Console.Write(firstNumber + " " + secondNumber+" ");
        for(int i=2;i<Num;i++)
        {
           
            Result = firstNumber + secondNumber;
            firstNumber = secondNumber;
            secondNumber = Result;
            Console.Write(Result + " ");
        }

    }
     
    }
