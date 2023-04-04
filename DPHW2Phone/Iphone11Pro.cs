using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPHW2Phone
{
    public class Iphone11Pro :PhoneDecorator
    {

        public Iphone11Pro(Phone basicPhone) : base(basicPhone)
        {
            base.basicPhone = basicPhone;
        }


        public override int GetCamreaCount()
        {
            return base.GetCamreaCount()+1;
        }

        public override string GetName()
        {
            return base.GetName()+" 11 Pro";
        }

        public override double GetPrice()
        {
            return base.GetPrice()+500;
        }
    }
}
