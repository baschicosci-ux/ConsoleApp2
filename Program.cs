
using System;
using subjectSchedule;
using subSchedDL;

namespace ConsoleApp2
{

    internal class Program
    {
        static SubjectSchedule[] schedules = new SubjectSchedule[15];
        static int scheduleCount = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("SUBJECT AND SCHEDULING MANAGEMENT:\n");

            while (true)
            {
                Console.WriteLine("OPTIONS:");
                Console.WriteLine("1. Input");
                Console.WriteLine("2. Show Inputs");
                Console.WriteLine("3. Exit\n");

                Console.WriteLine("Choose an option: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        inputSchedules();
                        break;

                    case 2:
                        showSchedules();
                        break;

                    case 3:
                        return;

                    default:
                        Console.WriteLine("Invalid option. Please choose again...");
                        break;
                }
            }
        }

        static void inputSchedules()
        {
            if (scheduleCount >= schedules.Length)
            {
                Console.WriteLine("Schedule List Is Full...");
                return;
            }
            Console.Write("Enter subject: ");
            string subject = Console.ReadLine();

            Console.Write($"Day for {subject} (Example: Monday): ");
            string day = Console.ReadLine();

            Console.Write($"Start Time (Example: 13:30): ");
            string startTime = Console.ReadLine();

            Console.Write($"End Time (Example: 7:00): ");
            string endTime = Console.ReadLine();

            schedules[scheduleCount] = new SubjectSchedule
            {
                Subject = subject,
                Day = day,
                StartTime = startTime,
                EndTime = endTime
            };
            scheduleCount++;

            Console.WriteLine($"Added {subject} schedule successfully!!!");
        }

        static void showSchedules()
        {
            if (scheduleCount == 0)
            {
                Console.WriteLine("No Schedule yet...");
            }
            for (int i = 0; i < scheduleCount; i++)
            {
                var schedule = schedules[i];
                Console.WriteLine($"{i + 1}. {schedule.Subject} -  {schedule.Day}, {schedule.StartTime} - {schedule.EndTime}");
            }
        }
    }
}
