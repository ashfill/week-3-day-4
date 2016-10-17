using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace Employee_Database
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> emplist = new List<Employee>();

            string fileName = "C:\\Users\\ashton\\Source\\Repos\\week-3-day-4\\week3day4\\week3day4\\bin\\Debug\\Employees.xml";

            if (File.Exists(fileName))
            {
                ReadInFile(fileName);
            }
            else
            {
                FileNotFound(fileName);
            }

            bool KeepLoop = true;
            while (KeepLoop)
            {
                Display();
                string userinput = GetInput();
                switch (userinput)
                {
                    case "1":
                        CreatingNewEmployee(emplist);
                        break;
                    case "2":
                        termination(emplist);
                        break;
                    case "3":
                        giveraise(emplist);
                        break;
                    case "4":
                        payemployees(emplist);
                        break;
                    case "5":
                        displayall(emplist);
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
        public static void CreatingNewEmployee(List<Employee> a)
        {
            Console.WriteLine("Please enter New Employee's ID.");
            int X = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Please enter the new employee's name.");
            string Y = Console.ReadLine();

            Console.WriteLine("Please enter the new employee's pay rate.");
            double G = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please set termination date.");
            DateTime H = DateTime.Now;
            Employee emp1 = new Employee(X, Y, G,H);
            a.Add(emp1);
        }
        public static void termination(List<Employee> C)
        {

            bool EmpFound = false;
            Console.WriteLine("please enter employee ID.");
            int X = Convert.ToInt32(Console.ReadLine());
            foreach (Employee A in C)
            {
                if (A.Id == X)
                {
                    A.Termdate();
                }
                if (EmpFound == false)
                {
                    Console.WriteLine("I didn't find it.");
                }
            }
        }
        public static void giveraise(List<Employee> A)
        {
            bool Cash = false;
            Console.WriteLine("which employee do you want to give a raise?");
            double GetRaise = Convert.ToDouble(Console.ReadLine());
            {
                foreach (Employee C in A)
                {
                    if (C.Id == GetRaise)
                    {
                        C.raise();
                    }
                    if (Cash == false)
                    {
                    }
                }


            }
        }
        public static void payemployees(List<Employee> A)
        {
            Console.WriteLine("Press any key to pay employee");

            {
                foreach (Employee C in A)
                    if (C.Termination != DateTime.MinValue)
                    {
                        Console.WriteLine("These employees got paid {0}", A);
                    }

            }
        }


        public static void displayall(List<Employee> A)
        {

            foreach (Employee C in A)
            {
                Console.WriteLine(string.Format("{0}, {1}, {2} {3}", C.Id, C.EmployeeName, C.PayRate, C.Termination));
                Console.ReadLine();
            }
        }


        static void FileNotFound(string file)
        {
            Console.WriteLine("This file does not exist. Please create a new one.");
            Console.WriteLine("");

            using (XmlWriter writer = XmlWriter.Create(file))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("catalog");
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }

        public static void ReadInFile(string fileName)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("C:\\Users\\ashton\\Source\\Repos\\week-3-day-4\\week3day4\\week3day4\\bin\\Debug\\Employees.xml");
            XmlNode catNode = doc.DocumentElement.SelectSingleNode("/catalog");

            foreach (XmlNode child in catNode.ChildNodes)
            {
                foreach (XmlNode grandChild in child.ChildNodes)
                {
                    switch (grandChild.Name)
                    {
                        case "name":
                            {
                                string EmployeeName = grandChild.InnerText;
                                break;
                            }


                    }
                }
            }
        }
    }
}
    











