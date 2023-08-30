using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Filter : IFilter
    {

        public bool IsRadiusValid(double radius)
        {
            if (radius <=  0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
       public bool IsHeightValid(double height)
        {
            if(height <= 0)
            {
                return false;
            }
            else
            {
                return true ;
            }
        }
        
    }

   
}
