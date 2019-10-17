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

                    /*
                     * Usage: Uncomment each test one at a time and record results
                     */

                    /*
                     * It was argued that integer comparison is faster than string comparison
                     * and this demonstrates that it true.
                     */
                    //BestCaseIfThenInteger();
                    //WorstCaseIfThenInteger();

                    /*
                     * Matching on the best case is the fastest of the set
                     */
                    //BestCaseIfThen();
                    //WorstCaseIfThen();

                    /*
                     * Time is constant because each condition gets evaluated
                     * This is the worst of all options
                     */
                    //BestCaseMultipleIf();
                    //WorstCaseMultipleIf();

                    /*
                     * Similar to IfThen, but less code/more readable
                     */
                    //BestCaseMultiORIf();
                    //WorstCaseMultiORIf();

                    /*
                     * switch is the fastest on average and constant for each case
                     */
                    //BestCaseSwitch();
                    //WorstCaseSwitch();

                    /*
                     * Switch is the best case and you can make it even better
                     * with fall-through cases
                     */
                    //BestCaseMultiORSwitch();
                    //WorstCaseMultiORSwitch();

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

        static void BestCaseIfThenInteger()
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
        static void WorstCaseIfThenInteger()
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

        static void BestCaseIfThen()
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
        static void WorstCaseIfThen()
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

        static void BestCaseMultipleIf()
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
        static void WorstCaseMultipleIf()
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


        static void BestCaseMultiORIf()
        {
            string day = "Saturday";
            string dayType = string.Empty;


            for (int i = 0; i < SampleSize; i++)
            {
                if (day == "Saturday" || day == "Sunday")
                {
                    dayType = "Weekend";
                }
                else if (day == "Monday" || day == "Tuesday"
                    || day == "Wednesday" || day == "Thursday" || day == "Friday")
                {
                    dayType = "Weekday";
                }
                else
                {
                    dayType = "Something Wrong !!!";
                }
            }
        }
        static void WorstCaseMultiORIf()
        {
            string day = "Friday";//"Saturday";    
            string dayType = string.Empty;


            for (int i = 0; i < SampleSize; i++)
            {
                if (day == "Saturday" || day == "Sunday")
                {
                    dayType = "Weekend";
                }
                else if (day == "Monday" || day == "Tuesday"
                    || day == "Wednesday" || day == "Thursday" || day == "Friday")
                {
                    dayType = "Weekday";
                }
                else
                {
                    dayType = "Something Wrong !!!";
                }
            }
        }

        static void BestCaseSwitch()
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
                    default:
                        break;
                }
            }

        }
        static void WorstCaseSwitch()
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


        static void BestCaseMultiORSwitch()
        {
            string dayType = string.Empty;
            string day = "Saturday";
            for (int i = 0; i < SampleSize; i++)
            {
                switch (day)
                {
                    case "Sunday":
                    case "Saturday":
                        dayType = "Weekend";
                        break;
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        dayType = "Weekday";
                        break;
                    default:
                        dayType = "Something wrong !!";
                        break;
                }
            }
        }
        static void WorstCaseMultiORSwitch()
        {
            string dayType = string.Empty;
            string day = "Friday";//"Saturday";    
            for (int i = 0; i < SampleSize; i++)
            {
                switch (day)
                {
                    case "Sunday":
                    case "Saturday":
                        dayType = "Weekend";
                        break;
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        dayType = "Weekday";
                        break;
                    default:
                        dayType = "Something wrong !!";
                        break;
                }
            }
        }
    }
}
