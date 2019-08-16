using System;

namespace Golf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            App app = new App();
            app.Setup();
            app.Run();
        }
    }
}
