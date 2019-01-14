using System;
using System.Collections.Generic;
using System.Text;

namespace Cat
{
    
    class Cat
    {
        public string name;
        public int weight;

        public Cat(string name, int weightvalue)
        {
            this.name = name;
            this.weight = 1;
            Console.WriteLine($"kissan paino on {this.weight}");
        }

        public Cat(int weightValue)
        {
            this.weight = weightValue;
            // Console.WriteLine($"Kissan paino{this.weight}");
        }
        public void IncreaseWeight(int value)
        {
            this.weight += value;

            Console.WriteLine($"Kissan{this.name} paino on {this.weight} ");
        }
        public void PrintWeight()
        {
            Console.WriteLine($"Kissan {this.name} paino on {this.weight}");
        }

    }
}

