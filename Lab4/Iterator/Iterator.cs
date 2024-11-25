using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Iterator
{
    internal class Iterator
    {
        class Customer
        {
            public void SeeCars(AutoShop shop)
            {
                ICarIterator iterator = shop.CreateNumerator();
                while (iterator.HasNext())
                {
                    Car car = iterator.Next();
                    Console.WriteLine(car.Name);
                }
            }
        }

        interface ICarIterator
        {
            bool HasNext();
            Car Next();
        }
        interface ICarNumerable
        {
            ICarIterator CreateNumerator();
            int Count { get; }
            Car this[int index] { get; }
        }
        class Car
        {
            public string Name { get; set; }
        }

        class AutoShop : ICarNumerable
        {
            private Car[] cars;
            public AutoShop()
            {
                cars = new Car[]
                {
                    new Car{Name="Машина 1"},
                    new Car {Name="Машина 2"},
                    new Car {Name="Машина 3"}
                };
            }
            public int Count
            {
                get { return cars.Length; }
            }

            public Car this[int index]
            {
                get { return cars[index]; }
            }
            public ICarIterator CreateNumerator()
            {
                return new AutoShopNumerator(this);
            }
        }
        class AutoShopNumerator : ICarIterator
        {
            ICarNumerable aggregate;
            int index = 0;
            public AutoShopNumerator(ICarNumerable a)
            {
                aggregate = a;
            }
            public bool HasNext()
            {
                return index < aggregate.Count;
            }

            public Car Next()
            {
                return aggregate[index++];
            }
        }
    }
}
