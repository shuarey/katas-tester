using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata_tester

{
    class Program
    {
        static void Main(string[] args)
        {
            //int evalInt = Convert.ToInt32(Console.ReadLine());
            //IsSquare(evalInt);
            //int evenEval = Convert.ToInt32(Console.ReadLine());
            //EvenOrOdd(evenEval);
            //basicOp("a", 12, 0);
            /*
             * TODO
             * 
             * Console.WriteLine(string.Join(", ", CountPositivesSumNegatives(new int[] {  })));
             * 
             */
            //var myBmi = Bmi(183.4, 6.1);
            //Console.WriteLine($"Based on your Bmi, you are: {myBmi}");
            //var mySample = RemoveExclamationMarks("!!!!!!!!!!!!!!!!!!!!!!!!!!I !!!!!!!!!!!!!!!!!!!!!!am !!!!!!!!!!!!!!!!Batman");
            //Console.WriteLine(mySample);
            DoubleChar("Hello");
        }

        public static string DoubleChar(string s)
        {
            char[] myCharArray = s.ToCharArray();
            Console.WriteLine(myCharArray);
            return "";
        }

        //public double[] Tribonacci(double[] signature, int n)
        //{
        //    double[] myArray = new double[n] { signature };
        //    return double; 
        //}

        // Completed
        public static string RemoveExclamationMarks(string s)
        {
            //string sample = s;
            return s.Replace("!", "");
        }

        // Completed
        public static string Bmi(double weight, double height)
        {
            var result = "";
            var bmi = (weight / Math.Pow((height * 12), 2)) * 703;
            if (bmi <= 18.5)
            {
                result = "Underweight";
            }
            else if (bmi <= 25.0)
            {
                result = "Normal";
            }
            else if (bmi <= 30.0)
            {
                result = "Overweight";
            }
            else if (bmi > 30.0)
            {
                result = "Obese";
            }
            return bmi + " " + result;
        }

        // TODO
        public static int[] CountPositivesSumNegatives(int[] input)
        {
            int negativeSum = 0, positiveCount = 0;

            foreach (var item in input)
            {
                if (input == null)
                {
                    return new[] { 0, 0 };
                }
                else if(item <= 0)
                {
                    negativeSum += item;
                }
                else
                {
                    positiveCount++;
                }
            }

            return new [] { positiveCount, negativeSum };
        }

        // Completed
        public static double basicOp(string op, double val1, double val2)
        {
            string switchCase = op.ToString().ToUpper();
            double returnValue = 0;

               switch (switchCase)
                {
                    case "A":
                        returnValue = val1 + val2;
                        break;

                    case "S":
                        returnValue =  val1 - val2;
                        break;

                    case "M":
                        returnValue =  val1 * val2;
                        break;

                    case "D":
                        if (val2 != 0)
                        {
                            returnValue =  val1 / val2;
                        }
                        else
                        {
                            Console.WriteLine("Cannot divide by zero");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid expression. Try again.");
                    returnValue = 0;
                    break;
                }
            Console.WriteLine($"Result: {returnValue}");
            return returnValue;
        }

        // Completed    
        public static string EvenOrOdd(int number)
        {
            return (number % 2 == 0) ? "Even" : "Odd";
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Even");
            //    return "Even";
            //}
            //else
            //{
            //    Console.WriteLine("Odd");
            //    return "Odd";
            //}
        }

        // Completed
        public static bool IsSquare(int n)
        {
            double myDouble = Math.Sqrt(n);
            bool returnedValue;
            if (myDouble % 1 == 0)
            {
                Console.WriteLine($"{n} is a perfect square!");
                returnedValue = true;
            }
            else
            {
                Console.WriteLine($"{n} is not a perfect square.");
                returnedValue = false;
            }
            return returnedValue;
        }
    }
}

