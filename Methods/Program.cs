using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*************");
            Console.WriteLine("***Methods***");
            Console.WriteLine("*************");

            //exercise 1
            
            Console.Write("Please enter a number: ");
            int num= int.Parse(Console.ReadLine());

            Console.WriteLine("the opposite of your number is: " + Opposite(num));
            
            
            
            //exercise 2
            /*
            Console.Write("Please enter your distance in miles: ");
            double miles = double.Parse(Console.ReadLine());

            Console.WriteLine("{0} miles is {1} kilometres", miles, CalculateKM(miles));

            static double CalculateKM(double miles)
            {
                double kilometres = miles * 1.62137;
                return kilometres;
            }
            */
            //exercise 3
            /*
            Console.Write("Please enter the radius of your circle: ");
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine("with radius {0}, the circumference of your circle is {1}, and the area is {2}.", r, CalCircumference(r), CalArea(r));

            static double CalCircumference(double r)
            {
                double circumference = 2 * 3.1416 * r;
                return circumference;
            }
            static double CalArea(double r)
            {
                double area = 3.1416 * r * r;
                return area;
            }
            */
            //exercise 4
            /*
            string[] daysArray = new string[7] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            Console.Write("Enter a day number: ");
            int dayNum = int.Parse(Console.ReadLine());

            Console.WriteLine("day number {0} is {1}.", dayNum, GetDay(dayNum));

            string GetDay(int dayNum)
            {
                dayNum -= 1;
                string day = daysArray[dayNum];
                return day;
            }
            */
            //Task 1


        }
        static int Opposite(int num)
        {
            int numOpp = num * -1;

            return numOpp;
        }
    }
}
