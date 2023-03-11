using Raiding.IO.Interfaces;

namespace Raiding.IO
{
    public class ConsoleWriter : IWriter
    {
        public void WriteLine(string text)
        {
             Console.WriteLine(text);
        }
    }
}
