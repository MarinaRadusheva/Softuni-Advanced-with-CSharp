using System;
using System.Collections.Generic;

namespace P03.DetailPrinter
{
    class Program
    {
        static void Main()
        {
            Employee someEmployee = new Employee("Biser");
            Manager someManager = new Manager("Pesho", new List<string> { "doc1", "doc2", "doc3" });
            DetailsPrinter printer = new DetailsPrinter(new List<Employee> { someEmployee, someManager });
            printer.PrintDetails();
        }
    }
}
