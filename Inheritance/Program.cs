using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird HappyFeet = new Bird()
            {
                Name = "HappyFeet",
                Mammal = true,
                Legs = 2,
                Teeth = 100,
                Wings = 2,
                CanFly = false,
                ColdBlooded = true,
                Penguin = "Penguin",

            };

            Console.WriteLine($"{HappyFeet.Name} is a rare {HappyFeet.Penguin} and it is also {HappyFeet.Mammal} that he is a mammal and has   {HappyFeet.Legs} legs , {HappyFeet.Teeth} teeth and {HappyFeet.Wings} wings.");
            Console.WriteLine($"{HappyFeet.Name}  it is {HappyFeet.CanFly} can fly, but is {HappyFeet.ColdBlooded} that he is the only {HappyFeet.Penguin} that can dance.");
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile Charmander = new Reptile()
            {
                Name = "Charmander",
                Mammal = false,
                Legs = 2,
                Teeth = 100,
                Scales = true,
                Tail = true,
                SharpTeeth = true,
                Poisoness = true,
            };

            Console.WriteLine($"{Charmander.Name} is the strongest Pokemon, because it is {Charmander.Legs} and {Charmander.Teeth}");
            Console.WriteLine($"Also {Charmander.Name}'s scales are sharp which is {Charmander.Scales} and also the fact that he has sharpteeth, tail and Poisoness is{Charmander.Scales} {Charmander.SharpTeeth}{Charmander.Poisoness}");
        }
    }
}
    
