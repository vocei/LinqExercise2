using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Channels;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers

            Console.WriteLine("Sum of All Numbers in List:");
            int sum = numbers.Sum();
            Console.WriteLine(sum);
            Console.WriteLine();
            Thread.Sleep(1000);

            //TODO: Print the Average of numbers
            Console.WriteLine("Average of All Numbers in List:");
            
            Console.WriteLine(numbers.Average());
            Console.WriteLine();
            Thread.Sleep(1000);

            //TODO: Order numbers in ascending order and print to the console
            Console.WriteLine("Printing All Numbers in Ascending Order:");
            Thread.Sleep(1000);
            numbers.OrderBy(x => x).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine();
            Thread.Sleep(1000);

            //TODO: Order numbers in descending order and print to the console

            Console.WriteLine("Printing All Numbers in Descending Order:");
            var orderDesc = numbers.OrderByDescending(x => x);

            Thread.Sleep(1000);
            foreach (var number in orderDesc)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();
            Thread.Sleep(1000);
            //Console.WriteLine("Printing All Numbers in Descending Order:");
            //Thread.Sleep(1000);
            //numbers.OrderByDescending(x => x).ToList().ForEach(x => Console.WriteLine(x));
            //Console.WriteLine();
            //Thread.Sleep(1000);




            //TODO: Print to the console only the numbers greater than 6
            Console.WriteLine("Printing All Numbers Greater Than 6:");
            numbers.Where(x => x > 6).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine();
            Thread.Sleep(1000);
            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**


            Console.WriteLine("Printing Only 4 Numbers in Order:");
            foreach (var orderNumber in numbers.OrderBy(x => x).Take(4))
            {
                Console.WriteLine(orderNumber);
            }
            Console.WriteLine();
            Thread.Sleep(1000);


            //TODO: Change the value at index 4 to your age, then print the numbers in descending order

            numbers[4] = 24;
            //numbers.SetValue(24, 4);
           
                foreach (var number in orderDesc)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();



            // List of employees ****Do not remove this****
            List<Employee> employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            Console.WriteLine("Printing Employees Fullnames By 'C' or 'S' in Ascending Order by First Name:");
            employees.Where(x => x.FirstName.StartsWith('C') || x.FirstName.StartsWith('S')).OrderBy(x => x.FirstName).ToList().ForEach(x => Console.WriteLine(x.FullName));
            Console.WriteLine();
            Thread.Sleep(1000);


            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.

            Console.WriteLine("Printing The List Of Employees in the Twenty Six and Up Club:");
            var twentySixClub = employees.Where(x => x.Age > 26).OrderBy(x => x.Age).ThenBy(x => x.FirstName);
            foreach (var employee in twentySixClub)
            {

                Console.WriteLine($"Name: {employee.FullName} Age: {employee.Age}");
            }
            Console.WriteLine();
            Thread.Sleep(1000);




            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            Console.WriteLine("Printing The Sum and Then Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35:");
            var employeeSum = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Sum(x => x.YearsOfExperience);
            Console.WriteLine("Sum:");
            Console.WriteLine(employeeSum);
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine("_________________");
            Console.WriteLine("Average:");
            double employeeAvg = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Average(x => x.YearsOfExperience);
            Console.WriteLine(employeeAvg);
            Console.WriteLine();
            Thread.Sleep(1000);


            //TODO: Add an employee to the end of the list without using employees.Add()
            Console.WriteLine("Adding New Employee Mario!");
            Console.WriteLine("Employee List After Change:");
            Employee newEmployee = new Employee();
            newEmployee.FirstName = "Mario";
            newEmployee.LastName = "Toadstool";
            newEmployee.Age = 75;
            newEmployee.YearsOfExperience = 45;

            employees.Append(newEmployee).ToList().ForEach(x => Console.WriteLine(x.FullName));
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine("Employee List Before Change:");
            foreach (var e in employees)
            {
                Console.WriteLine(e.FullName);
            }



            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
