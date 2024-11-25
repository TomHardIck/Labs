using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.AbstractFactory
{
    internal class AbstractFactory
    {
        abstract class Phone
        {
            public abstract void Ring();
        }
        abstract class Car
        {
            public abstract void Ride();
        }

        class IPhone : Phone
        {
            public override void Ring()
            {
                Console.WriteLine("Звоним с Iphone");
            }
        }

        class Android : Phone
        {
            public override void Ring()
            {
                Console.WriteLine("Звоним с Android");
            }
        }

        class Mercedes : Car
        {
            public override void Ride()
            {
                Console.WriteLine("Едем на Mercedes");
            }
        }

        class BMW : Car
        {
            public override void Ride()
            {
                Console.WriteLine("Едем на BMW");
            }
        }

        abstract class HeroFactory
        {
            public abstract Phone CreatePhone();
            public abstract Car CreateCar();
        }

        class FirstTypeOfCustomer : HeroFactory
        {
            public override Phone CreatePhone()
            {
                return new IPhone();
            }

            public override Car CreateCar()
            {
                return new Mercedes();
            }
        }
        class SecondTypeOfCustomer : HeroFactory
        {
            public override Phone CreatePhone()
            {
                return new Android();
            }

            public override Car CreateCar()
            {
                return new BMW();
            }
        }

        class Customer
        {
            private Phone phone;
            private Car car;

            public Customer(HeroFactory factory)
            {
                phone = factory.CreatePhone();
                car = factory.CreateCar();
            }

            public void Ring()
            {
                phone.Ring();
            }

            public void Ride()
            {
                car.Ride();
            }
        }
    }
}
