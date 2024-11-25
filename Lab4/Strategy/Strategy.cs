using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Strategy
{
    internal class Strategy
    {
        interface IScreen
        {
            void Interact();
        }

        class TouchScreen : IScreen
        {
            public void Interact()
            {
                Console.WriteLine("Тачскрин");
            }
        }

        class LaptopScreen : IScreen
        {
            public void Interact()
            {
                Console.WriteLine("LaptopScreen");
            }
        }

        class Device
        {
            protected string model;
            public Device(string model)
            {
                this.model = model;
            }

            public IScreen screen { private get; set; }
            public void Interact()
            {
                screen.Interact();
            }
        }
    }
}
