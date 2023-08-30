using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise2
{
    internal class Tiger : Animal
    {
        public Tiger(double weight, string name)
        {
            base.SetMe(weight, name);
        }

        public override void Show()
        {
            Console.WriteLine("Tiger Information:");
            base.Show();
        }
    }
}
