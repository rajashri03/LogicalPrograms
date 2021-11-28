using System;
public class Logical
{
    public static void Main(string[] args)
    {
        FibonacciSeries fibo = new FibonacciSeries();
       
        PerfectNum perfect = new PerfectNum();
       
        Console.Write("Select Number:\n1)FibonacciSeries\n2)PerfectNumber\n\n");
        int option = Convert.ToInt32(Console.ReadLine());
        switch(option)
        {
            case 1:
                fibo.FiboSeries();
                break;
            case 2:
                perfect.CheckPerfect();
                break;
            default:
                Console.Write("Please Select Correct Number");
                break;

        }
    }
}
