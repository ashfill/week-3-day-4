using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Database
{
    class Employee
    {
        private string id;
        private string employeeName;
        private double payrate;
        private double PayRaise;
        private DateTime termination;
        public Employee(string newId, string newName, double newPayRate)
        {
            id = newId;
            employeeName = newName;
            payrate = newPayRate;
        }

        public string Id { get; }
        public string EmployeeName { get; }
        public double PayRate { get; }

        public void Termdate()
        {
            termination = DateTime.Now;
        }
        public void raise()
        {
            PayRaise = PayRate * .05;
        }
        public void PayEmployee()
        {
           
            
        }
    }
   
}

