namespace P04.Recharge
{
    using System;

    class Program
    {
        static void Main()
        {
            Employee employee = new Employee("874");
            Robot robot = new Robot("342", 50);
            robot.CurrentPower = 30;
            employee.Work(8);
            robot.Work(20);
            Console.WriteLine(robot.CurrentPower);
        }
    }
}
