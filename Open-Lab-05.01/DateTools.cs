using System;

namespace Open_Lab_05._01
{
    public class DateTools
    {
        public string Century(int year)
        {
            int answer = (int)(year / 100) + ((year % 100 == 0) ? 0 : 1);

            if (answer == 11)
            {
                return "11th century";
            }

            if (answer % 10 == 1)
            {
                return answer + "st century";
            }


            if (answer == 12)
            {
                return "12th century";
            }

            if (answer % 10 == 2)
            {
                return answer + "nd century";
            }


            if (answer == 13)
            {
                return "13th century";
            }

            if (answer % 10 == 3)
            {
                return answer + "rd century";
            }

            return answer + "th century";
        }
    }
}
