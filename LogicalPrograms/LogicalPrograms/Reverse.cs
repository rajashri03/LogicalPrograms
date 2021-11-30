using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Reverse
    {
    int Number;
    int rev = 0, remainder;
    public void CheckReverse()
    {
        Console.Write("Enter Number:");
        Number = Convert.ToInt16(Console.ReadLine());
        Console.Write("Reversed Number of " + Number + "");
       while (Number!=0)
        {
            remainder = Number % 10;
            rev = rev * 10 + remainder;
            Number = Number / 10;
        }
        Console.Write(" is " + rev+"\n\n");
    }


}
