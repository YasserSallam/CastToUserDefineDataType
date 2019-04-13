using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastToCustomDataType
{
    struct Person
    {
        #region properties
        public string FullName { get; set; }
        public int Salary { get; set; }

        #endregion
        #region ctor
        public Person(string name, int salary)
        {
            FullName = name;
            Salary = salary;
        } 
        #endregion        
        #region toString
        public override string ToString()
        {
            return $"i am  {FullName}, and my salary ={Salary}";
        }

        #endregion

    }
}
