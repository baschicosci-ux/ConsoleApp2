namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sched;
            string subject;

            Console.WriteLine("Subject and Scheduling");
            Console.WriteLine(" ");

            var subjects = new string[4];
            subjects[0] = "OOP";
            subjects[1] = "Info Management";
            subjects[2] = "Network Administration";
            subjects[3] = "Integrative Programming";
            subjects[4] = "Free Elective";

            Console.WriteLine("Enter the time: ");
            string sched = Console.ReadLine();
        }
    }
}
