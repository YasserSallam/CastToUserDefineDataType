using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastToCustomDataType
{
    class PolymorphismA
    {
        public virtual void Display() {
            Console.WriteLine("A");
        }
    }
    class PolymorphismB:PolymorphismA
    {
        public override void Display()
        {
            Console.WriteLine("B");
        }
    }

    class PolymorphismC:PolymorphismB
    {
        public override void Display()
        {
            Console.WriteLine("C");
        }
    }

    class PolymorphismD:PolymorphismC
    {
        public new virtual void Display()
        {
            Console.WriteLine("D");
        }
    }

    class PolymorphismF : PolymorphismD
    {
        public override void Display()
        {
            Console.WriteLine("F");
        }
    }
}
