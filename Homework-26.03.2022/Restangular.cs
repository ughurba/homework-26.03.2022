using System;
namespace Homework_26._03._2022
{

    public class Restangular : Figure
    {
        //Bir Rectangular class-ı olur width və length deyə property-ləri olacaq, width və length mənfi ola bilməz.
        //Width və length dəyərləri təyin olunmamış Rectangular obyekti yaradıla bilməz.
        //Rectangular class-ı Figure class-ından miras alacaq və CalcArea methodunu özünə uyğun override edəcək.

        public int width { get; set; }
        public int length { get; set; }
        int result;
        public Restangular(int width, int length)
        {
            Console.Clear();
            CalcArea(width, length);

            Console.WriteLine($"Restangular: {result}");
            Console.WriteLine("\nDevam etmek ucun <Enter> duymesine click edin");
            Console.ReadLine();
        }

        public override int CalcArea(int width, int length)
        {
            if (length > 0 && width > 0)
            {
                this.width = width;
                this.length = length;
                result = this.width * this.length;

                return result;
            }
            else
            {
                Console.WriteLine("Width ve length deyeri menfi ola bilmez");
                return 0;
            }

        }
    }
}
