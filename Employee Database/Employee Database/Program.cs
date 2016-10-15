using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Database
{
    class Program
    {
        static void Main(string[] args)
        {

            bool KeepLoop = true;
            List<Employee> emplist = new List<Employee>();
            while (KeepLoop)
            {
                Display();
                string userinput = GetInput();
                switch (userinput)
                {
                    case "1":
                        CreatingNewEmployee();
                        break;
                    case "2":
                        termination();
                        break;
                    case "3":
                        giveraise();
                        break;
                    case "4":
                        payemployees();
                        break;
                    case "5":
                        displayall();
                        break;
                    case "6":
                        KeepLoop = false;
                        break;
                    default:
                        break;
                }
            }
            
            string End = Console.ReadLine();
            if (End == "y")
            {
                KeepLoop = true;
            }
            else
            {
                KeepLoop = false;
            }
        }
        static void Display()
        {
            Console.Clear();
            Console.WriteLine("1.create");
            Console.WriteLine("-----------");
            Console.WriteLine("2.terminate");
            Console.WriteLine("-----------");
            Console.WriteLine("3.give raise");
            Console.WriteLine("-----------");
            Console.WriteLine("4.pay employee");
            Console.WriteLine("-----------");
            Console.WriteLine("5.display all employees");
            Console.WriteLine("-----------");
            Console.WriteLine("6.exit");
            Console.WriteLine("-----------");
        }
        public static string GetInput()
        {
            Console.WriteLine("Please choose an option.");
            string a = Console.ReadLine();
            return Console.ReadLine();


        }
        public static void CreatingNewEmployee()
        {
            Console.WriteLine("Please enter New Employee's ID.");
            string X = Console.ReadLine();



            Console.WriteLine("Please enter the new employee's name.");
            string Y = Console.ReadLine();

            Console.WriteLine("Please enter the new employee's pay rate.");
            double G = Convert.ToDouble(Console.ReadLine());

            Employee emp1 = new Employee(X, Y, G);
            List<Employee> emplist = new List<Employee>();
        }
        public static void termination()
        {
            List<Employee> emplist = new List<Employee>();
            bool EmpFound = false;
            Console.WriteLine("please enter employee ID.");
            string X = Console.ReadLine();
            foreach (Employee EMP in emplist)
            {
                if (EMP.Id == X)
                {
                    EMP.Termdate();
                }
                if (EmpFound == false)
                {
                    Console.WriteLine("I didn't find it.");
                }
            }
        }
        public static void giveraise()
        {
            List<Employee> emplist = new List<Employee>();
            bool Cash = false;
            Console.WriteLine("which employee do you want to give a raise?");
            string raise = Console.ReadLine();
            {
                foreach (Employee EMP4 in emplist)
                {
                    if (EMP4.Id == payemployees)
                    {
                        EMP4.raise();
                    }
                    if (Cash == false)
                    {
                    }
                }


            }
        }
        public static void payemployees()
        {
            List<Employee> emplist = new List<Employee>();
            Console.WriteLine("Press any key to pay employee");
            string GetPaid = Console.ReadLine();
            {
                foreach (Employee EMP5 in emplist)
                {
                    foreach (Employee EMP4 in emplist)
                    {
                        if (EMP4 == GetPaid) 
                        {
                            EMP4.raise();
                        }
                        if (Cash == false)
                        {
                        }
                        Console.WriteLine("The foloowing employee's have been paid,{0}", emplist);
                }
            }
        }
        public static void displayall()
        {

        }
    }
}
    

