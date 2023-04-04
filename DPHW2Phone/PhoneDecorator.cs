using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPHW2Phone
{
    public class PhoneDecorator : Phone
    {
        protected Phone basicPhone;
        public PhoneDecorator( Phone basicPhone)
        {
            this.basicPhone=basicPhone;
        }

        public virtual int GetCamreaCount()
        {
           return basicPhone.GetCamreaCount();  
        }

        public virtual string GetName()
        {
            return   basicPhone.GetName();   
        }

        public virtual double GetPrice()
        {
            return basicPhone.GetPrice();
        }
    }
}
