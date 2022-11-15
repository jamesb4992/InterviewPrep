using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    internal class DetermineAnalogTimeFromAngle
    {
        public static void determineAnalogTime(int angle)
        {

            Func<int, string> time = (angle) => $"{angle / 30} : {angle % 30 * 2}";
            Console.WriteLine(time(angle));
        }
    }
}
