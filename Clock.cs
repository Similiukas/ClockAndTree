using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

namespace ClockAndTree
{
    class Clock
    {
        private static double minutes;
        private static double hours;

        /// <summary>
        /// Validating user input
        /// </summary>
        /// <param name="text">Display text for user</param>
        /// <returns>User input converted to double</returns>
        private static double ValidateInput(string text)
        {
            double output;
            Console.Write(text);
            string input = Console.ReadLine();

            while (!double.TryParse(input, out output))
            {
                Console.Write("Please put only doubles: ");
                input = Console.ReadLine();
            }
            return output;
        }

        /// <summary>
        /// Converting clock hand to angles in degrees. Angle is from 12 o'clock to user input
        /// </summary>
        /// <param name="isMinute">Is this a minute stick?</param>
        /// <param name="stick">What does the stick show?</param>
        /// <returns>Angle from 12 o'clock to sticks value in degrees</returns>
        private static double AngleFromTop(bool isMinute, double stick)
        {
            if (isMinute)
            {
                return stick * 6;
            }
            return stick * 30 + (minutes * .5);     // For hour hand, need to also add the minute hand
        }
        public static void ClockStart()
        {
            Console.WriteLine("Let's go with the clock then");
            minutes = ValidateInput("Put minutes: ") % 60;
            hours = ValidateInput("Put hours: ") % 12;

            double minutesAngle = AngleFromTop(true, minutes);
            double hoursAngle = AngleFromTop(false, hours);
            // Angle between the sticks
            double angle = Math.Max(minutesAngle, hoursAngle) - Math.Min(minutesAngle, hoursAngle);
            double smallerAngle = Math.Min(angle, 360 - angle); // Taking the smaller angle

            Console.WriteLine($"The angle is: {smallerAngle}\nOr in radians: {Math.Round(smallerAngle/180, 3)}*Pi");
        }
    }
}
