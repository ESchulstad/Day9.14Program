using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9._14Program
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            for(int row=1;row<= 5;row++)
            {
                for(int col =1; col<=5;col++)
                {
                    Console.Write(row * col + " ");
               
                }
                Console.WriteLine();

            }
            
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row<=n;row++)
            {
                for(int col = 1;col<= n;col++)
                {
                    Console.Write(row * col + " ");
                }
                Console.WriteLine();

            }
              

            int n = int.Parse(Console.ReadLine());
            

            for (int i = 1; i <= n; i++)
            {
                if (i % 7 == 0 && i % 3 == 0)
                {
                    continue;
                }
                
                Console.WriteLine(i);
            }

           
            Console.WriteLine("Hello World!");
            SayHi();
            
            int userOneNum = int.Parse(Console.ReadLine());
            int userTwoNum = int.Parse(Console.ReadLine());

            Console.WriteLine(Add(userOneNum, userTwoNum));
            

            for(row=1; row <=4;row++)
            {

            }

            */

            Console.WriteLine("Please enter a multi digit number.");
            string number = Console.ReadLine();
            Console.WriteLine(ReverseNumbers(number));

        }

        static void SayHi()
        {
            Console.WriteLine("Hi!!");
        }

        static int Add (int x, int y)
        {
            int z = x + y;
            return z; 
        }
        static string ReverseNumbers(string number)
        {
            string answer = "";
            //start loop at end of string and count backwards
            for(int i=(number.Length-1);i>=0;i--)
            {
                //answer = answer + number[i]
                answer += number[i];
            }
            return answer;
        }
    }
}
