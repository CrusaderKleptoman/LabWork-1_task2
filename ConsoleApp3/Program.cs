using System;
using System.Collections.Generic;

namespace lab1_2
{
    public struct Square
    {
        public int side;
        public int amount;
    }
    public class Logic
    {
        public static List<Square> GetSquares(int a, int b)
        {

            List<Square> squares = new List<Square>();

            int count = 0;

            int maxSide;
            int minSide;
            if (a > b)
            {
                maxSide = a;
                minSide = b;
            }
            else
            {
                maxSide = b;
                minSide = a;
            }

            Square square;
            square.side = minSide;
            square.amount = 0;
            squares.Add(square);

            for (int i = 0; i < 1; i = 0)
            {

                if (maxSide < minSide)
                {
                    var swap = maxSide;
                    maxSide = minSide;
                    minSide = swap;

                    count++;
                    square.side = minSide;
                    square.amount = 0;
                    squares.Add(square);
                }

                square.amount++;
                squares[count] = square;
                maxSide -= minSide;
                if (maxSide <= 0 || minSide <= 0)
                {
                    break;
                }
            }

            return squares;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину сторон прямоугольника");

            Console.WriteLine("a = ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("b = ");
            int b = int.Parse(Console.ReadLine());

            List<Square> squares = Logic.GetSquares(a, b);

            for (int i = 0; i < squares.Count; i++)
            {
                Console.WriteLine("Длина стороны квадрата = " + squares[i].side + "\nИх количество = " + squares[i].amount + "\n");
            }

            Console.ReadLine();
        }
    }
}