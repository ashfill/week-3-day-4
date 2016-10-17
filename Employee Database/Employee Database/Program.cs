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
            int X = Convert.ToInt32(Console.ReadLine());



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
            int X = Convert.ToInt32(Console.ReadLine());
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
            double raise = Convert.ToDouble(Console.ReadLine());
            {
                foreach (Employee EMP4 in emplist)
                {
                    if (EMP4.Id == raise)
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
            bool Money = false;
            Console.WriteLine("Press any key to pay employee");
            int GetPaid = Convert.ToInt32(Console.ReadLine());
            {
                foreach (Employee EMP5 in emplist)
                {
                    foreach (Employee EMP4 in emplist)
                    {
                        if (EMP4.Id == GetPaid)
                        {
                            EMP4.PayEmployee();
                        }
                        if (Money == false)
                        {
                        }
                        Console.WriteLine("The folowing employee's have been paid,{0}", emplist);
                    }
                }
            }
        }
        public static void displayall()
        {
            List<Employee> emplist = new List<Employee>();
            foreach (Employee g in emplist)
            {
                Console.WriteLine(string.Format("{0}, {1}, {2}", g.EmployeeName, g.Id, g.PayRate));

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
                                Console.WriteLine("/***********************/");
                                Console.WriteLine("");
                                break;
                            }


                    }
                }
            }
        }
    }
}










