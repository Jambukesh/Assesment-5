using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables_and_datatypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part 1 ----Variables and Datatypes
            string Name = "Jambukesh";
            int Age = 23;
            double Height = 177.3;
            Console.WriteLine("------------Part 1-----------");
            Console.WriteLine($"{Name}\n {Age}\n{Height}");

            // part 2 -----Loops
            Console.WriteLine("------------Part2--------------");

            for(int i=1;i<=10;i++)
            {
                Console.WriteLine("First ten natural numbers" + i);
            }
            Console.WriteLine("Natural Even Numbers");
            int number = 1;
            int count = 1;
            while(count <= 10)
            {
                if(number % 2 == 0)
                {
                    Console.WriteLine(number);
                    count++;
                }
                number++;
            }
            //part 3
            Console.WriteLine("------------part 3 --------------");
            Console.WriteLine("------------FibonacciSeries --------------");
            int n = 10;
            int a = 0;
            int b = 1;
            int c;
             for (int i = 0; i < n; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
             //part4
            Console.WriteLine("--------part 4------------");
            int[] numberArray = new int[] { 10, 20, 30, 40, 50 };
            int sum = 0;
            double average;
            foreach (int num in numberArray)
            {
                sum += num;
            }
            average = sum / numberArray.Length;
            Console.WriteLine($"Average:{average} \n Sum:{sum}");
            // part 5
            Console.WriteLine("------------part 5---------------");
            Console.WriteLine("Enter your marks");
            int score = int.Parse(Console.ReadLine());
            if(score >=90)
            {
                Console.WriteLine("Grade A");
            }
            else if(score >=80)
            {
                Console.WriteLine("Grade B");
            }
            else if (score >= 70)
            {
                Console.WriteLine("Grade C");
            }
            else if (score >= 60)
            {
                Console.WriteLine("Grade D");
            }
            else
            {
                Console.WriteLine("F");
            }


            Console.ReadKey();
        }
    }
}
