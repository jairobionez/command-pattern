using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Data
{
    public class Luz
    {
        public string _local = string.Empty;

        public Luz()
        {

        }

        public void TurnOn()
        {
            Console.WriteLine("{0} luz ligada", _local);
        }

        public void TurnOff()
        {
            Console.WriteLine("{0} luz desligada", _local);
        }
    }
}
