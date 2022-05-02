using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace character_and_digit_find
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Input :  ");
         
            char data = Convert.ToChar(Console.ReadLine());

            Console.WriteLine(" this a value {0} ",data);
            if (data >= 65 && data<=90 || data >= 97 && data <= 122)
                Console.WriteLine("this a character   ");

           /* else if(sam>=97 && sam<=122)
                Console.WriteLine(" this a samol  character");*/
            else
                Console.WriteLine(" this is a digit  ");
            Console.ReadLine();


        }
    }
}
