:using System;

namespace EmpWage_D3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Employee's");
            int IS_FULL_TIME = 1 ;
            Random random = new Random(); 

            int empCheck = random.Next(0, 2);
            if(empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
