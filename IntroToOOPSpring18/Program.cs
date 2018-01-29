using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOPSpring18
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat firstCat = new Cat();
            firstCat.Name = "Mr. Fuzzy";

            Cat secondCat = new Cat("Midnight", 14, "black");

            Console.WriteLine(firstCat.Name);
            Console.WriteLine(secondCat.Name);

            firstCat.Eat();

            secondCat.Meow();

            firstCat.HairLength = "nice and short";
            secondCat.HairLength = "too long";

            Console.WriteLine(firstCat.Hairball());
            Console.WriteLine(secondCat.Hairball());

            Cat thirdCat = new Cat(1, true);

        }
    }
}
