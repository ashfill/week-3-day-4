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

            string fileName = "C:\\Users\\ashton\\Documents\\Employees.xml";

            if (File.Exists(fileName))
            {
                ReadInFile(fileName, emplist);
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
                        Termination(emplist);
                        break;
                    case "3":
                        GiveRaise(emplist);
                        break;
                    case "4":
                        PayEmployees(emplist);
                        break;
                    case "5":
                        DisplayAll(emplist);
                        break;
                    case "6":
                        Save(emplist);
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
        public static void CreatingNewEmployee(List<Employee> A)
        {
            Console.WriteLine("Please enter the new employee's ID.");
            int Y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the new employee's name.");
            string G = Console.ReadLine();

            Console.WriteLine("Please set PayRate.");
            double F = Convert.ToDouble(Console.ReadLine());
            Employee emp1 = new Employee(Y,G ,F);
            A.Add(emp1);
        }
        public static void Termination(List<Employee> A)
        {

            bool EmpFound = false;
            Console.WriteLine("please enter employee ID.");
            int X = Convert.ToInt32(Console.ReadLine());
            foreach (Employee C in A)
            {
                if (C.Id == X)
                {
                    C.Termdate();

                    EmpFound = true;
                }
                if (EmpFound == false)
                {
                    Console.WriteLine("I didn't find it.");
                }
            }
        }
        public static void GiveRaise(List<Employee> A)
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
                        Cash = true;
                    }
                    if (Cash == false)
                    {
                    }
                }


            }
        }
        public static void PayEmployees(List<Employee> A)
        {
            Console.WriteLine("Select Employee id to pay employee");

            {
                foreach (Employee C in A)
                    if (C.Termination != DateTime.MinValue)
                    {
                        Console.WriteLine("These employees got paid {0}", A);
                    }

            }
        }


        static void DisplayAll(List<Employee> A)
        {

            foreach (Employee C in A)
            {
               
                Console.WriteLine("{0}, {1}, {2}", C.Id, C.EmployeeName, C.PayRate);
                Console.ReadKey();
            }

        }

        static void FileNotFound(string file)
        {
            Console.WriteLine("This file does not exist. Please create a new one.");
            Console.WriteLine("");

            using (XmlWriter writer = XmlWriter.Create("C:\\Users\\ashton\\Documents\\Employees.xml"))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("COMPANY");
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }

        public static void ReadInFile(string fileName, List<Employee> A)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("C:\\Users\\ashton\\Documents\\Employees.xml");
            XmlNode comNode = doc.DocumentElement.SelectSingleNode("/COMPANY");

            foreach (XmlNode child in comNode.ChildNodes)
            {
                int empId = 0;
                string empName = "";
                double empPayRate = 0;
                foreach (XmlNode grandChild in child.ChildNodes)
                {
                    switch (grandChild.Name)
                    {
                        case "EmployeeName":
                            {
                                 empName = grandChild.InnerText;
                                break;
                            }
                        case "Employee Id":
                            {
                                empId = Convert.ToInt32(grandChild.InnerText);
                                break;
                            }
                        case "PayRate":
                            empPayRate = Convert.ToDouble(grandChild.InnerText);
                            break;
                        default:
                            break;
                      

                    }
                    Employee emp = new Employee(empId, empName, empPayRate);
                    A.Add(emp);
                }
            }
        }







        public static void Save(List<Employee> A)
        {
            using (XmlWriter writer = XmlWriter.Create("C:\\Users\\ashton\\Documents\\Employees.xml"))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("COMPANY");

                foreach (Employee C in A)
                {
                    writer.WriteStartElement("Employee");

                    writer.WriteElementString("Id", C.Id.ToString());
                    writer.WriteElementString("EmployeeName", C.EmployeeName);
                    writer.WriteElementString("PayRate", C.PayRate.ToString());

                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();

            }
        }

    }
}













