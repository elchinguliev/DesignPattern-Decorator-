using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPHW2Phone
{
    public class Iphone : Phone
    {
        //concrete class
        public int GetCamreaCount()
        {
            return 2;
        }

        public string GetName()
        {
            return "Iphone ";
        }

        public double GetPrice()
        {
            return 900;
        }
    }
}
