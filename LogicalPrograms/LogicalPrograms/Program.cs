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

        //Reverse Number
        Reverse rev = new Reverse();


        bool check = true;
        while (check)
        {
            Console.Write("Select Number:\n" +
                "1)Fibonacci Series\n" +
                "2)Perfect Number\n" +
                "3)Prime Number\n" +
                "4)Reverse Number\n" +
                "\n\n");
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
                case 4:
                    rev.CheckReverse();
                    break;
                default:
                    check = !check;
                    break;
              

            }
        }
    }
}
