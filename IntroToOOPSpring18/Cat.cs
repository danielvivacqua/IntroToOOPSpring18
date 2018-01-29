using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOPSpring18
{
    class Cat
    {
       //STATES
        //fields
        private string name;
        private int age;
        private string furColor;
        private bool isHungry = true;
        private string hairLength;

       //Properties
       public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string HairLength
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }
        }

        //BEHAVIORS
        //Constructors
        public Cat()
        {
            //default constructor
            //takes no parameters (nothing in the parentheses)
        }

        public Cat(string name, int age, string furColor)
        {
            this.name = name;
            this.age = age;
            this.furColor = furColor;
        }

        public Cat(int age, bool isHungry)
        {
            this.age = age;
            this.isHungry = isHungry;
        }

        //methods
        public void Eat()
        {
            if(isHungry)
            {
                isHungry = false;
            }

            Console.WriteLine("Is the cat hungry? " + isHungry);
        }

        public void Meow()
        {
            Console.WriteLine("\a");
        }

        public string Hairball()
        {
            if (hairLength == "too long")
            {
                return (this.name + " has a hairball.");
            }
            else
            {
                return (this.name + " is nicely groomed.");
            }
        }


    }
}
