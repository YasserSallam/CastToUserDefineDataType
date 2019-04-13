using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastToCustomDataType
{
    class Employee
    {
        #region properties
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int Salary { get; set; }
        #endregion

        #region Ctor
        public Employee(string Fname, string Lname, int Salary)
        {
            this.Fname = Fname;
            this.Lname = Lname;
            this.Salary = Salary;
        }        
        public Employee()
        {                
        }
        #endregion

        #region Explicit Casting For Custom DataType
        public static explicit operator Employee(Person P)
        {
            var names = P.FullName?.Split(' ');
            return new Employee()
            {
                //Fname = names.Length > 0 ? names[0] : "NA",
                //Lname = names.Length > 1 ? names[1] : "NA",
                Fname = names?[0] ?? "Not Available",
                Lname = names?[1] ?? "Not Available",
                Salary = P.Salary
            };
        } 
        #endregion
        public override string ToString()
        {
            return $"i am  {Fname}, and my last name is {Lname} and my salary ={Salary}";
        }
    }
}
