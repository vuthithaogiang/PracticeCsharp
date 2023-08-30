using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise2
{
    public abstract class Animal
    {
        protected double weight;
        protected string name;

        public void SetMe(double weight, string name)
        {
            this.weight = weight;
            this.name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Weight: {weight}");
        }
    }
}
