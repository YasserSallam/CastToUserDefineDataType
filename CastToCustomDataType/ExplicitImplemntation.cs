using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastToCustomDataType
{
    interface I01 {
        void fun();
    }
    interface I02
    {
        int fun();
    }

    class MyClass : I01, I02
    {
        public void fun()
        {
            Console.WriteLine("first Interface");
        }

        // explicit Casting For I02 and can not be public 
         int I02.fun() {
            return 5;
        }
    }
}
