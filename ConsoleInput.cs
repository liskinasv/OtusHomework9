using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusHomework9
{
    public class ConsoleInput : IInput
    {
        public void Write(string text)
        {
            Console.WriteLine(text);
        }
    }
}
