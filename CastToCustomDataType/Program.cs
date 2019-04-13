/*
 Write code to Explicit Cast Struct to Class 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastToCustomDataType
{
    class Program
    {
        static void Main(string[] args)
        {

            #region CustToCustomData
            //Person p = new Person("yasser Gamal", 2000);
            //Console.WriteLine(p);
            ////cast struct to class 
            //Employee emp = (Employee)p;
            //Console.WriteLine(emp);

            #endregion

            #region DunamicBinding

            //PolymorphismA a = new PolymorphismB();
            //a.Display();                             //B
            //a = new PolymorphismC();
            //a.Display();                            //C
            //a = new PolymorphismD();
            //a.Display();                            //C
            //a = new PolymorphismF();
            //a.Display();                            //C
            //PolymorphismD d = new PolymorphismF();
            //d.Display();                            //F
            //PolymorphismB b = new PolymorphismF();
            //b.Display();            //C

            #endregion
           
            #region ExplicitImplemntaion
            MyClass myClass = new MyClass();
            myClass.fun();
            // need casting befor calling
            int x = ((I02)myClass).fun();
            Console.WriteLine(x);
            #endregion
        }
    }
}
