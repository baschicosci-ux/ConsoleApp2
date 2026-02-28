namespace ConsoleApp2
{
    internal class Program
    {
        static void Main()
        {
            string[] subjects = new string[0];

            Console.WriteLine("Enter subjects (type 'done' if youre finish inputing the subjects):");

            while (true)
            {
                Console.Write("> ");
                string input = Console.ReadLine();

                if (input.ToLower() == "done")
                    break;
                //Turo ni sir well.. yubg array.resize is magdedepende yung size nang array sa dami nang input nang user
                Array.Resize(ref subjects, subjects.Length + 1);
                subjects[subjects.Length - 1] = input;
            }
            //gagamitin mo yung foreach each para yung loop konis naka depende sa kada input nang user...
            Console.WriteLine("\nSubjects:");
            foreach (var subject in subjects)
            {
                Console.WriteLine(subject);
            }
        }
    }
}
