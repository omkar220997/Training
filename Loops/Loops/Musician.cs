using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    public class Musician
    {
        public string NameOfMusician;
        public string InstrumentOfMusician;

        public void Announce()
        {
            Console.WriteLine( NameOfMusician + " on the " +InstrumentOfMusician+" ! ");

        }
    }
}
