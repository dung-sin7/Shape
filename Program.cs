using System;

class Program
{
    static void Main(string[] args)
    {
        int choice;

        do
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Print the rectangle");
            Console.WriteLine("2. Print the square triangle");
            Console.WriteLine("3. Print isosceles triangle");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    PrintRectangle();
                    break;
                case 2:
                    PrintSquareTriangle();
                    break;
                case 3:
                    PrintIsoscelesTriangle();
                    break;
                case 4:
                    Console.WriteLine("Exiting program...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        } while (choice != 4);
    }

    static void PrintRectangle()
    {
        Console.Write("Enter the width of the rectangle: ");
        int width = int.Parse(Console.ReadLine());

        Console.Write("Enter the height of the rectangle: ");
        int height = int.Parse(Console.ReadLine());

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    static void PrintSquareTriangle()
    {
        Console.Write("Enter the size of the square triangle: ");
        int size = int.Parse(Console.ReadLine());

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        for (int i = 0; i < size; i++)
        {
            for (int j = size - i; j > 0; j--)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        for (int i = 0; i < size; i++)
        {
            for (int j = size - i - 1; j > 0; j--)
            {
                Console.Write(" ");
            }
            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(" ");
            }
            for (int j = size - i; j > 0; j--)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    static void PrintIsoscelesTriangle()
    {
        Console.Write("Enter the size of the isosceles triangle: ");
        int size = int.Parse(Console.ReadLine());

        for (int i = 0; i < size; i++)
        {
            for (int j = size - i - 1; j > 0; j--)
            {
                Console.Write(" ");
            }
            for (int j = 0; j <= i * 2; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}