using System;
public class Logical
{
    public static void Main(string[] args)
    {
        //Fibonacci Series
        FibonacciSeries fibo = new FibonacciSeries();

        //Perfect Number
        PerfectNum perfect = new PerfectNum();

        //Prime Number
        Prime prime = new Prime();

      
        bool check = true;
        while (check)
        {
            Console.Write("Select Number:\n1)Fibonacci Series\n2)Perfect Number\n3)Prime Number\n\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    fibo.FiboSeries();
                    break;
                case 2:
                    perfect.CheckPerfect();
                    break;
                case 3:
                    prime.Checkprime();
                    break;
                default:
                    check = !check;
                    break;
              

            }
        }
    }
}
