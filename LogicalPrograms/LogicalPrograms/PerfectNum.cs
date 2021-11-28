using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class PerfectNum
    {
    int Num,sum=0;
    public void CheckPerfect()
    {
        Console.Write("Enter Number:");
        Num = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <Num; i++)
        {
            if (Num % i == 0)
            {
               
                Console.Write(i + " ");
                sum = sum + i;
            }

        }
       if(sum==Num)
        {
            Console.Write("\n"+ Num + " Is Perfect Number\n");

        }
        else
        {
            Console.Write("\n" + Num + " Is Not Perfect Number\n");
        }
    
}
 
    }

