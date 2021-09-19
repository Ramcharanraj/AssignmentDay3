using System;

namespace EmpWage_D3
{
    class Program
    {
        private static object elseif;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Employee's");
            int IS_FULL_TIME = 2 ;
            int IS_PART_TIME = 1 ;
            int EMP_RATE_PER_HOUR = 20;
           


            int empHrs = 0;
            int empWage = 0;

            Random random = new Random(); 

            int empCheck = random.Next(0, 3);
            if (empCheck == IS_PART_TIME)
            {
                Console.WriteLine("The Part-time-wage is ");
                empHrs = 4;
            }
            else if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("The Full-Time-Wage is ");
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
                Console.WriteLine("Employee is absent"); ;
            }

            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage: " +empWage);
        }
    }
}
