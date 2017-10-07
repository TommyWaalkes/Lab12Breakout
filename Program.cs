using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLab12
{
    class Program
    {
        static void Main(string[] args)
        {
            RPSGenerator rps = new RPSGenerator();
            Rocky r = new Rocky(rps);
            Console.WriteLine(r.GenerateRPS());
        }
    }
}
