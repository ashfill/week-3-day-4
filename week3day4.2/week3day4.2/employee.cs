﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3day4._2
{
   public class Employee
    {
        private string id;
        private string employeeName;
        private string payrate;
        private DateTime termination;

        public Employee(string newId, string newName, string newPayRate)
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
        public string PayRate
        {
            get
            {
                return payrate;
            }
        }

        public string Id
        {
            get
            {
                return id;
            }
        }

        public void Termdate()
        {
            termination = DateTime.Now;
        }
           
    }
}

