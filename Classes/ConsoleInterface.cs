using dp_test.Interfaces;

namespace dp_test.Classes
{
    public class ConsoleInterface : IUserInterface
    {
        public void ErrorMessage()
        {
            Console.WriteLine("Something went wrong :( try again");
        }

        public string PromptUser()
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Road transportation");
            Console.WriteLine("2. Sea Transportation");
            Console.WriteLine("Press 'Q' to quit");
            return Console.ReadLine();
        }

        public string ReadInput()
        {
            bool isCorrect;
            string input = Console.ReadLine().Trim().ToLower();
            while (input != "")
            {
                Console.WriteLine("Please give an input");
                input = Console.ReadLine();
            }
            return input;
        }
    }
}