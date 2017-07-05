using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASSN709_EKF
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare Variables
            double hours, payrate, gross, overtime;
            string hoursString, payrateString;

            //User input
            Console.WriteLine("Enter the amount of hours you worked: ");
            hoursString = Console.ReadLine();
            hours = Convert.ToDouble(hoursString);

            Console.WriteLine("Enter your pay rate: ");
            payrateString = Console.ReadLine();
            payrate = Convert.ToDouble(payrateString);

            //Process
            if (hours <= 40)
            {
                gross = hours * payrate;
                Console.WriteLine("Your gross pay is: ${0}", gross);
                Console.ReadLine();
            }
            else if (hours > 40)
            {
                overtime = hours - 40;
                gross = (overtime * (payrate * 1.5)) + (40 * payrate);
                Console.WriteLine("Your gross pay is: ${0}", gross);
                Console.ReadLine();
            }//end if

        }//end main
    }//end class
}//end program
