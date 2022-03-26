using System;

namespace Homework_26._03._2022
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            do
            {

                do
                {
                    try
                    {
                        Console.WriteLine("====MENU BAR==== ");
                        Console.WriteLine("1. Square\n2. Rectangular\n0. Quit\n");
                        num = int.Parse(Console.ReadLine());
                        switch (num)
                        {
                            case 1:

                                Square square = new Square(InfoSide("Side deyerini qeyd edin"));
                                break;
                            case 2:
                                Restangular restangular = new Restangular(InfoSide("Length qeyd edin"), InfoSide("Width qeyd edin"));
                                break;

                            case 0:
                                Environment.Exit(0);
                                break;
                        }
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }


                } while (true);

            } while (num < 0 || num > 2);
        }
        static int InfoSide(string str)
        {
            int input;
            Console.WriteLine(str);
            input = int.Parse(Console.ReadLine());
            return input;
        }

    }
}
