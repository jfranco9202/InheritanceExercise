using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Bird : Animal
    {
        public int Wings { get; set; }
        public bool CanFly { get; set; }
        public bool ColdBlooded { get; set; }
        public string Penguin { get; set; }


        public Bird()
        {

        }

        public Bird(string name, int Teeth, bool mammal, int legs, int Wings, bool CanFly, bool ColdBolded, string Penguin)
        {
            Name = name;
            Teeth = Teeth;
            Mammal = mammal;
            Legs = legs;
            Wings = Wings;
            CanFly = CanFly;
            ColdBolded = ColdBolded;
            Penguin = Penguin;
        }

    }
}
