using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*************");
            Console.WriteLine("***Methods***");
            Console.WriteLine("*************");

            //task1 task2
            /*
            Console.Write("Please enter weight in kg: ");
            float weight = float.Parse(Console.ReadLine());
            Console.Write("Please enter height in m: ");
            float height = float.Parse(Console.ReadLine());

            float BMI = CalBMI(weight, height);
            

            Console.WriteLine("Your BMI is: " + BMI);
            Console.WriteLine("You are... " + BMIClass(BMI));
            
            Console.ReadLine();
            */

            /*
            Console.WriteLine("Enter the last cents value: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("the number needs to be rounded... " + CalRound(num));

            Console.ReadLine();
            */
            //task 4
            /*
            Console.Write("Enter a number 1-5 : ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(Hello(num));
            
            Console.ReadLine();
            */
            //task 5

            Console.Write("enter a number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("enter another number: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.Write("please enter an operator (+ - * / %): ");
            string op = Console.ReadLine();

            Console.WriteLine("{0} {1} {2} = {3}", num1, op, num2, Calculate(num1, op, num2));

            Console.ReadLine();

        }
        

        static float CalBMI(float weight, float height) //task1
        {
            float BMI = weight / (height * height);
            return BMI;
        }
        static string BMIClass(float BMI) //task2
        {
            string classification;
            if (BMI < 18.5)
            {
                classification = "Underweight";
                return classification;
            } else if (BMI >= 18.5 && BMI < 25)
            {
                classification = "Normal weight";
                return classification;
            } else if (BMI >= 25 && BMI < 30)
            {
                classification = "Overweight";
                return classification;
            } else if (BMI >= 30)
            {
                classification = "Obese";
                return classification;
            }
            else
            {
                classification = "invalid input";
                return classification;
            }
        }

        static string CalRound(int num) //task3
        {
            switch (num)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    return "down";
                    
                case 6:
                case 7:
                case 8:
                case 9:
                    return "up";
                    
                default:
                    return "error";
            }    
        }
        static string Hello(int num) //task4
        {
            string[] helloArray = new string[6] { "Hello", "Kia Ora", "Kon'nichiwa", "Namaste", "Bonjour", "Talofa" };
            string hello = helloArray[num];
            return hello;
        }

        static double Calculate(double num1, string op, double num2)
        {
            double answer;
            if (op == "+")
            {
                answer = num1 + num2;
                return answer;
            }
            else if (op == "-")
            {
                answer = num1 - num2;
                return answer;
            }
            else if (op == "*")
            {
                answer = num1 * num2;
                return answer;
            }
            else if (op == "/")
            {
                answer = num1 / num2;
                return answer;
            }
            else if (op == "%")
            {
                answer = num1 % num2;
                return answer;
            }
            else
            {
                answer = 0;
                return answer;
            }

        }
    }
}
