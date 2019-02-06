using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Data
{
    public class PortaEletronica
    {
        public string _local = string.Empty;

        public PortaEletronica() { }

        public void Open()
        {
            Console.WriteLine("{0} porta aberta", _local);
        }
   
        public void Close()
        {
            Console.WriteLine("{0} porta fechada", _local);
        }

        public void TurnOnLight()
        {
            Console.WriteLine("{0} luz ligada", _local);
        }

        public void TurnOffLight()
        {
            Console.WriteLine("{0} luz desligada", _local);
        }
    }
}
