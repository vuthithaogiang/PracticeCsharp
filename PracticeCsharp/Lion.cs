using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise2
{
    internal class Lion : Animal
    {

        public Lion(double weight, string name)
        {
            base.SetMe(weight, name);
        }

        public override void Show()
        {
            Console.WriteLine("Lion Information:");
            base.Show();
        }
    }
}
