using System;
using System.Net.NetworkInformation;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ALBRIGHT_ASSIGNMENT_1_3_1
{
    internal class Program
    {
        static void AreaTriangle()
        {
            Console.WriteLine("\nPlease enter the base dimension:");
            double base_Double = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nPlease enter the height dimension:");
            double height_Double = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nTriangle Area: (1/2)*(" + base_Double + ")*(" + height_Double + ") == (" + (0.5) * ((base_Double) * (height_Double)) + ")");
        }
        static void AreaSquare_Rectangle()
        {
            Console.WriteLine("\nPlease enter the base dimension:");
            double base_Double = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nPlease enter the height dimension:");
            double height_Double = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nSquare Area: (" + base_Double + ")*(" + height_Double + ") == (" + ((base_Double) * (height_Double)) + ")");

        }
        static void Main(string[] args)
        {

            // MSSA CCAD16
            // CHRISTOPHER ALBRIGHT
            // 06NOV2024 -- COURSE DAY 3
            // ASSIGNMENT 1-3

            

            // SOLUTION 1-3-1

            Console.WriteLine("\nSolution 1-3-1");
            Console.WriteLine("\nWelcome to AreaSolver!");
            string continue_String;

            do
            {
                Console.WriteLine("\nShape Guide: 1-TRIANGLE, 2-SQUARE, 3-RECTANGLE");
                Console.WriteLine("\nPlease type the corresponding number (i.e. 1,2,3) for the desired shape's area calculation: ");
                int selection_Int = Convert.ToInt32(Console.ReadLine());

                switch (selection_Int)
                {
                    case 1:
                        AreaTriangle();
                        break;
                    case 2:
                        AreaSquare_Rectangle();
                        break;
                    case 3:
                        AreaSquare_Rectangle();
                        break;
                    default:
                        Console.WriteLine("\nIncorrect Input");
                        break;
                }
                Console.WriteLine("\nType c to continue area calculations or any other character to exit");
                continue_String = Console.ReadLine();
            }
            while (continue_String == "c");

            Console.WriteLine("\nGoodbye!");

            //---------------------------------------------------------------------------------------------------------------------------------------------------------------------

            // SOLUTION 1-3-2

            Console.WriteLine("\n\n\n\nSolution 1-3-2");

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine("\nThe elements stored in the \"cars\" array are:");
            foreach (string item in cars)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n\nThere are "+cars.Length+ " items (length) in the \"cars\" array");

            int[] numbers = new int[7] { 23, 47, 56, 29, 101, 82, 115 };
            Console.WriteLine("\nThe elements stored in the \"numbers\" array are:");
            foreach (int item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n\nThe \"numbers\" array sorted from least to greatest is as follows:");
            Array.Sort(numbers);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            //---------------------------------------------------------------------------------------------------------------------------------------------------------------------

            // SOLUTION 1-3-3

            Console.WriteLine("\n\n\n\nSolution 1-3-3");
            Console.WriteLine("\nWelcome to ArrayReverser!");
            string continue_String_2;

            do
            {
                Console.WriteLine("\nHow many elements would you like in your array? (i.e. \"n\"). Enter below:");
                int n_Int = Convert.ToInt32(Console.ReadLine());

                int[] array = new int[n_Int];

                for (int i = 0; i < n_Int; i++)
                    {
                        Console.WriteLine("\nEnter array value "+(i+1)+":");
                        array[i] = int.Parse(Console.ReadLine());
                    }

                Console.WriteLine("\nThe elements stored in the array are:");
                    foreach (int item in array)
                    {
                        Console.Write(item + " ");
                    }

                Console.WriteLine("\nThe elements stored in the reverse array are:");
                for (int i = 0, j = n_Int - 1; i < j; i++, j--)
                    {
                        int reverse_Int = array[i];
                        array[i] = array[j]; 
                        array[j] = reverse_Int;
                    }
                    foreach (int item in array)
                    {
                        Console.Write(item+" ");
                    }
                Console.WriteLine("\n");
                Console.WriteLine("\nType c to continue reversing arrays or any other character to exit");
                continue_String_2 = Console.ReadLine();

            }
            while (continue_String_2 == "c");

            Console.WriteLine("\nGoodbye!");
        }
    }
}
