using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceComparison
{
    class Program
    {
        static int SampleSize = 100000;
        static int loop = 1000;
        static Int64 ticksSum = 0;
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            for (int x = 0; x < 5; x++)
            {


                for (int i = 0; i < loop; i++)
                {
                    sw.Start();
                    //DecideDayIfFirst();
                    //DecideDayIfLast();

                    //Added for int value comparison
                    //DecideValueIfFirst();
                    //DecideValueIfLast();
                    
                    //DecideDayIfSimpleFirst();
                    //DecideDayIfSimpleLast();


                    //DayComparisonSwitchFirst();
                    //DayComparisonSwitchLast();

                    sw.Stop();
                    ticksSum = ticksSum + sw.ElapsedTicks;
                    //Console.WriteLine(sw.ElapsedTicks);
                    sw.Reset();
                }
                //Console.WriteLine($"Average Ticks in loop # {x} is  {ticksSum / loop}");
                Console.WriteLine($"{ticksSum / loop}");
            }

            Console.ReadLine();
        }

          static void DecideValueIfFirst()
        {
            int day = 1;
            string dayType = string.Empty;


            for (int i = 0; i < SampleSize; i++)
            {
                if (day == 1)
                {
                    dayType = "Weekend";
                }
                else if (day == 3)
                {
                    dayType = "Weekend";
                }
                else if (day == 4)
                {
                    dayType = "Weekday";
                }
                else if (day == 5)
                {
                    dayType = "Weekday";
                }
                else if (day == 6)
                {
                    dayType = "Weekday";
                }
                else if (day == 7)
                {
                    dayType = "Weekday";
                }
                else if (day == 8)
                {
                    dayType = "Weekday";
                }

                else
                {
                    dayType = "Something Wrong !!!";
                }
            }
        }
        static void DecideValueIfLast()
        {
            int day = 1;
            string dayType = string.Empty;


            for (int i = 0; i < SampleSize; i++)
            {

                if (day == 2)
                {
                    dayType = "Weekend";
                }
                else if (day == 3)
                {
                    dayType = "Weekday";
                }
                else if (day == 4)
                {
                    dayType = "Weekday";
                }
                else if (day == 5)
                {
                    dayType = "Weekday";
                }
                else if (day == 6)
                {
                    dayType = "Weekday";
                }
                else if (day == 7)
                {
                    dayType = "Weekday";
                }
                else if (day == 1)
                {
                    dayType = "Weekend";
                }
                else
                {
                    dayType = "Something Wrong !!!";
                }
            }
        }

        
        static void DecideDayIfFirst()
        {
            string day = "Saturday";
            string dayType = string.Empty;


            for (int i = 0; i < SampleSize; i++)
            {
                if (day == "Saturday")
                {
                    dayType = "Weekend";
                }
                else if (day == "Sunday")
                {
                    dayType = "Weekend";
                }
                else if (day == "Monday")
                {
                    dayType = "Weekday";
                }
                else if (day == "Tuesday")
                {
                    dayType = "Weekday";
                }
                else if (day == "Wednesday")
                {
                    dayType = "Weekday";
                }
                else if (day == "Thursday")
                {
                    dayType = "Weekday";
                }
                else if (day == "Friday")
                {
                    dayType = "Weekday";
                }

                else
                {
                    dayType = "Something Wrong !!!";
                }
            }
        }
        static void DecideDayIfLast()
        {
            string day = "Saturday";
            string dayType = string.Empty;


            for (int i = 0; i < SampleSize; i++)
            {

                if (day == "Sunday")
                {
                    dayType = "Weekend";
                }
                else if (day == "Monday")
                {
                    dayType = "Weekday";
                }
                else if (day == "Tuesday")
                {
                    dayType = "Weekday";
                }
                else if (day == "Wednesday")
                {
                    dayType = "Weekday";
                }
                else if (day == "Thursday")
                {
                    dayType = "Weekday";
                }
                else if (day == "Friday")
                {
                    dayType = "Weekday";
                }
                else if (day == "Saturday")
                {
                    dayType = "Weekend";
                }
                else
                {
                    dayType = "Something Wrong !!!";
                }
            }
        }

        static void DecideDayIfSimpleFirst()
        {
            string day = "Saturday";
            string dayType = string.Empty;


            for (int i = 0; i < SampleSize; i++)
            {
                if (day == "Saturday")
                {
                    dayType = "Weekend";
                }
                if (day == "Sunday")
                {
                    dayType = "Weekend";
                }
                if (day == "Monday")
                {
                    dayType = "Weekday";
                }
                if (day == "Tuesday")
                {
                    dayType = "Weekday";
                }
                if (day == "Wednesday")
                {
                    dayType = "Weekday";
                }
                if (day == "Thursday")
                {
                    dayType = "Weekday";
                }
                if (day == "Friday")
                {
                    dayType = "Weekday";
                }
                else
                {
                    dayType = "Something Wrong !!!";
                }
            }
        }
        static void DecideDayIfSimpleLast()
        {
            string day = "Saturday";
            string dayType = string.Empty;


            for (int i = 0; i < SampleSize; i++)
            {

                if (day == "Sunday")
                {
                    dayType = "Weekend";
                }
                if (day == "Monday")
                {
                    dayType = "Weekday";
                }
                if (day == "Tuesday")
                {
                    dayType = "Weekday";
                }
                if (day == "Wednesday")
                {
                    dayType = "Weekday";
                }
                if (day == "Thursday")
                {
                    dayType = "Weekday";
                }
                if (day == "Friday")
                {
                    dayType = "Weekday";
                }
                if (day == "Saturday")
                {
                    dayType = "Weekend";
                }
                else
                {
                    dayType = "Something Wrong !!!";
                }
            }
        }

        static void DayComparisonSwitchFirst()
        {
            string dayType = string.Empty;
            string day = "Saturday";
            for (int i = 0; i < SampleSize; i++)
            {
                switch (day)
                {
                    case "Saturday":
                        dayType = "Weekend";
                        break;
                    case "SundayS":
                        dayType = "Weekend";
                        break;
                    case "Monday":
                        dayType = "Weekday";
                        break;
                    case "Thursday":
                        dayType = "Weekday";
                        break;
                    case "Tuesday":
                        dayType = "Weekday";
                        break;
                    case "Wednesday":
                        dayType = "Weekday";
                        break;
                    case "Friday":
                        dayType = "Weekday";
                        break;
                    default:
                        break;
                }
            }

        }
        static void DayComparisonSwitchLast()
        {
            string dayType = string.Empty;
            string day = "Saturday";
            for (int i = 0; i < SampleSize; i++)
            {
                switch (day)
                {
                    case "Sunday":
                        dayType = "Weekend";
                        break;
                    case "Monday":
                        dayType = "Weekday";
                        break;
                    case "Thursday":
                        dayType = "Weekday";
                        break;
                    case "Tuesday":
                        dayType = "Weekday";
                        break;
                    case "Wednesday":
                        dayType = "Weekday";
                        break;
                    case "Friday":
                        dayType = "Weekday";
                        break;
                    case "Saturday":
                        dayType = "Weekend";
                        break;
                    default:
                        break;
                }
            }

        }

    }
}
