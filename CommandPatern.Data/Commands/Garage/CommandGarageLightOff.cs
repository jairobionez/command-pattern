using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Data.Commands.Garage
{
    public class CommandGarageLightOff : ICommand
    {
        PortaEletronica _portaEletronica;

        public CommandGarageLightOff(PortaEletronica portaEletronica)
        {
            this._portaEletronica = portaEletronica;
            _portaEletronica._local = "Garagem";
        }

        public void Execute()
        {
            this._portaEletronica.TurnOffLight();
        }
    }
}
