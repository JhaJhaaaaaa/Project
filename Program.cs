using System;

namespace demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Employee Time Keeping System: ");
            Console.Write($"The date today: {DateTime.Today}");

            Console.Write("Please Enter Your Employee id:");
            string EmployeeId = Console.ReadLine();

            TimeSpan timein = new TimeSpan(8, 0, 0);
            Console.WriteLine($"Your log in time is successfully recorded: {timein}");

            Console.WriteLine("*******************************************");
            Console.Write("To Log your time-out enter your employee id:");
            EmployeeId = Console.ReadLine();


            TimeSpan timeout = new TimeSpan(16, 0, 0);
            Console.WriteLine($"Your log out time is successfully recorded: {timeout}");

            TimeSpan lunchBreakDuration = new TimeSpan(1, 0, 0);
            TimeSpan totalHours = (timeout - timein) - lunchBreakDuration;

            Console.WriteLine($"Your total hours worked is: {totalHours}");

            TimeSpan regularHoursStart = new TimeSpan(8, 0, 0);
            TimeSpan regularHoursEnd = new TimeSpan(17, 0, 0);
            TimeSpan lateIn = new TimeSpan(0, 0, 0);
            TimeSpan earlyOut = new TimeSpan(0, 0, 0);
            TimeSpan totalUndertimeHours = new TimeSpan(1, 0, 0);

            if (timein > regularHoursStart)
            {
                lateIn = timein - regularHoursStart;
            }

            if (timeout > regularHoursEnd)
            {
                totalUndertimeHours = timeout - regularHoursEnd;


                Console.WriteLine($"Your total regular hours worked is: {totalUndertimeHours}");
            }
        }
    }
}
