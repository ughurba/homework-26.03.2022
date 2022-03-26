using System;

namespace Homework_26._03._2022
{
    public class Square : Figure
    {
        //  Bir Square class-ı olur side deyə bir property-i olur və side mənfi ola bilməz.
        //Side dəyəri təyin olunmamış Square obyekti yaradıla bilməz.
        //Square class-ı Figure class-ından miras alacaq və CalcArea methodunu özünə uyğun override edəcək.

        public int side { get; set; }
        public Square(int side)
        {
            Console.Clear();
            int num5 = 0;
            CalcArea(side, num5);
            Console.WriteLine($"Side deyeri: {this.side}");
            Console.WriteLine("\nDevam etmek ucun <Enter> duymesine click edin");
            Console.ReadLine();
        }

        public override int CalcArea(int side, int num5)
        {
            if (side > 0)
            {
                this.side = side;
                return this.side;
            }
            else
            {

                Console.WriteLine("Side deyeri menfi ola bilmez");
                return 0;
            }
        }
    }
}
