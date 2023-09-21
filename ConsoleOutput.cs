using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusHomework9
{
    public class ConsoleOutput : IOutput
    {
        public string Read()
        {
            return Console.ReadLine();
        }
    }
}
