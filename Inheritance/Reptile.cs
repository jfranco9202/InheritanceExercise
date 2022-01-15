using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    


    class Reptile : Animal
    {
        public bool Scales { get; set; }
        public bool Tail { get; set; }
        public bool SharpTeeth { get; set; }
        public bool Poisoness { get; set; }


        public Reptile()
        {

        }

        public Reptile(string name, int Teeth, bool mammal, int legs, bool Scales, bool Tail, bool SharpTeeth, bool Poisoness)
        {
            Name = name;
            Teeth = Teeth;
            Mammal = mammal;
            Legs = legs;
            Scales = Scales;
            Tail = Tail;
            SharpTeeth = SharpTeeth;
            Poisoness = Poisoness;
        }

    }
}
