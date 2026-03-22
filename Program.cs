namespace ConsoleApp2
{
    internal class Program
    {
        static void Main()
    {
        int choice;
        Console.WriteLine("1. Input Subjects");
        Console.WriteLine("2. Input Schedule");
        Console.WriteLine("3. Exit");
        Console.WriteLine(" ");
        Console.Write("Enter your choice: ");
        choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                InputSubjects();
                break;
            case 2:
                InputSchedule();
                break;
            case 3:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }

    static void InputSubjects()
    {
        string[] subjects = new string[0];
        Console.WriteLine("Enter subjects (type 'done' if you're finish inputing the subjects):");
        while (true)
        {
            Console.Write("• ");
            string input = Console.ReadLine();
            if (input.ToLower() == "exit") break;
            Array.Resize(ref subjects, subjects.Length + 1);
            subjects[subjects.Length - 1] = input;
        }

        Console.WriteLine("\nSubjects:");
        foreach (var subject in subjects)
        {
            Console.WriteLine(subject);
        }
    }

    static void InputSchedule()
    {
        Console.Write("Enter day (Example: Monday): ");
        string day = Console.ReadLine();

        Console.Write($"Enter start time for {day} (Example: 7): ");
        int startTime = Convert.ToInt32(Console.ReadLine());

        Console.Write($"Enter end time for {day} (Example: 12): ");
        int endTime = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"\nSchedule for {day}: {startTime}:00 - {endTime}:00");
    }
    }
