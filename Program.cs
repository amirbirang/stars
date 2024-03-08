using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice5
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 4;
            for(int i =1; i <=9; i+=2)
            {
                //first blank
                for(int k=1; k<=max; k++ )
                {
                    Console.Write(" ");
                }
                max--;
                for(int j=1; j<=i; j++)
                    //stars
                {
                    Console.Write("*");
                }
                Console.WriteLine("");

            }
            //=========================================
            //sesseion2
            Console.WriteLine("SECEND MODEL OF STARS");
            int lines = 0;
            for (int line =1; line<=5; line++)
            {
                for(int space = 0; space<= (line*2)-1; space+=2)
                {
                    Console.Write(" ");
                }
                for (int star = 9; star>= 1; star -= 2)
                {
                    Console.Write("*");
                }
                
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
