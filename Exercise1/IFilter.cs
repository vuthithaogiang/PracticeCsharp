using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal interface IFilter
    {
        bool IsRadiusValid(double radius);

        bool IsHeightValid(double height);
    }
}
