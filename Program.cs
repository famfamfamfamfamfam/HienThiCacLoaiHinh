using System;

namespace SUDUNGCAULENHLAP
{
    class HienThiCacLoaiHinh
    {
        static void Main(string[] args)
        {
            int luachon = 0;
            while (luachon != 4)
            {
                Console.WriteLine("1. Print the rectangle\n2. Print the square triangle (The corner is square at 4 different angles: top-left, top-right, botton-left, botton-right)\n3. Print isosceles triangle\n4. Exit");
                luachon = int.Parse(Console.ReadLine());
                switch (luachon)
                {
                    case 1:
                        for (int i = 0; i < 10; i++)
                        {
                            for (int j = 0; j < 20; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 2:
                        for (int i = 10; i > 0; i--)
                        {
                            for (int j = 0; j < 10; j++)
                            {
                                if (j <= i - 1)
                                {
                                    Console.Write("*");
                                }
                            }
                            Console.WriteLine();
                        }
                        for (int i = 0; i < 10; i++)
                        {
                            for (int j = 0; j < 10; j++)
                            {
                                if (j >= i)
                                {
                                    Console.Write("*");
                                }
                                else Console.Write(" ");
                            }
                            Console.WriteLine();
                        }
                        for (int i = 0; i < 10; i++)
                        {
                            for (int j = 0; j < 10; j++)
                            {
                                if (j < i + 1)
                                {
                                    Console.Write("*");
                                }
                            }
                            Console.WriteLine();
                        }
                        for (int i = 10; i > 0; i--)
                        {
                            for (int j = 0; j < 10; j++)
                            {
                                if (j >= i - 1)
                                {
                                    Console.Write("*");
                                }
                                else Console.Write(" ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 3:
                        for (int i = 0; i < 10; i++)
                        {
                            for (int j = 0; j < 20; j++)
                            {
                                if (j >= 10 - i && j <= 10 + i)
                                {
                                    Console.Write("*");
                                }
                                else Console.Write(" ");
                            }
                            Console.WriteLine();
                        }
                        break;
                }
            }

        }
    }
}