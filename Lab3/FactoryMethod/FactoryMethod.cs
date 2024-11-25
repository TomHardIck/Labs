using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.FactoryMethod
{
    public class FactoryMethod
    {
        abstract class MainClass
        {

        }

        class ConcreteClassFirst : MainClass { }
        class ConcreteClassSecond : MainClass { }

        abstract class FabricClass
        {
            public abstract MainClass ReturnFactoryClass();
        }

        class ConcreteClassThird : FabricClass
        {
            public override MainClass ReturnFactoryClass()
            {
                throw new NotImplementedException();
            }
        }

        class ConcreteClassFourth : FabricClass
        {
            public override MainClass ReturnFactoryClass()
            {
                throw new NotImplementedException();
            }
        }
    }
}
