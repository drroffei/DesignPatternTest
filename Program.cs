using dp_test.Classes;
using dp_test.Interfaces;

IUserInterface IO = new ConsoleInterface();
LogisticsApp app = new LogisticsApp(IO);
app.Run();

