﻿using System;
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


        public string EmployeeName
        {
            get
            {
                return employeeName;
            }
        }
        public double PayRate
        {
            get
            {
                return payrate;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }
            }

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

