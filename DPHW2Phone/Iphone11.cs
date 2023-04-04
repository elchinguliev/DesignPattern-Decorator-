using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPHW2Phone
{
    public class Iphone11 : PhoneDecorator
    {
        public Iphone11(Phone basicPhone) : base(basicPhone)
        {
            base.basicPhone = basicPhone;
        }
        public override int GetCamreaCount()
        {
            return base.GetCamreaCount();
        }

        public override string GetName()
        {
            return base.GetName()+" 11";
        }

        public override double GetPrice()
        {
            return base.GetPrice()+300;
        }
    }
}
