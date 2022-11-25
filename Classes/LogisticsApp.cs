using dp_test.Interfaces;

namespace dp_test.Classes
{
    public class LogisticsApp
    {
        private IUserInterface IO;

        public LogisticsApp(IUserInterface userInterface)
        {
            IO = userInterface;
        }

        public void Run()
        {
            while(true)
            {
                string input = IO.PromptUser();

                ITransport transport;

                // Testa att göra detta med en dictionary.
                if (input == "1")
                {
                    transport = CreateTransport(new RoadLogistics());
                    transport.Deliver();
                }
                else if (input == "2")
                {
                    transport = CreateTransport(new SeaLogistics());
                    transport.Deliver();
                }
                else if (input == "q")
                {
                    break;
                }
                else
                {
                    IO.ErrorMessage();
                }
            }
        }

        public ITransport CreateTransport (Logistics logistics)
        {
            return logistics.CreateTransport();
        }
    }
}