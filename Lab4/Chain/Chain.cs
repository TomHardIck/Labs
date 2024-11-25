using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Chain
{
    internal class Chain
    {
        class Phone
        {
            public bool buttonPhone { get; set; }
            public bool touchScreenPhone { get; set; }
            public Phone(bool buttonPhone, bool touchScreenPhone)
            {
                this.buttonPhone = buttonPhone;
                this.touchScreenPhone = touchScreenPhone;
            }
        }

        abstract class PhoneChooser
        {
            public PhoneChooser Phone { get; set; }
            public abstract void Choose(Phone phone);
        }

        class ButtonPhone : PhoneChooser
        {
            public override void Choose(Phone phone)
            {
                if(phone.buttonPhone)
                {
                    Console.WriteLine("Вы выбрали кнопочный телефон!");
                }
                else if(Phone != null)
                {
                    Phone.Choose(phone);
                }
            }
        }

        class TouchScreenPhone : PhoneChooser
        {
            public override void Choose(Phone phone)
            {
                if (phone.touchScreenPhone)
                {
                    Console.WriteLine("Вы выбрали сенсорный телефон!");
                }
                else if (Phone != null)
                {
                    Phone.Choose(phone);
                }
            }
        }
    }
}
