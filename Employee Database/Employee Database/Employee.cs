using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Database
{
    class Employee
    {
       
        private int id;
        private string employeeName;
        private double payrate;
        private double PayRaise;
        private DateTime termination;
        public Employee(int newId, string newName, double newPayRate)
        {
            id = newId;
            employeeName = newName;
            payrate = newPayRate;
        }

        public int Id { get; }
        public string EmployeeName { get; }
        public double PayRate { get; }

        public DateTime Termination
        {
            get
            {
                return termination;
            }

           
        }

        public double PayRaise1
        {
            get
            {
                return PayRaise;
            }

        }

        public void Termdate()
        {
            termination = DateTime.MinValue;
        }
        public void raise()
        {
            PayRaise = PayRate * .05;
        }
       
    }
   
}

