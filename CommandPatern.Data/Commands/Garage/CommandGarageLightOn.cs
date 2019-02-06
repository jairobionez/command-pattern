using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Data.Commands.Garage
{
    public class CommandGarageLightOn : ICommand
    {
        PortaEletronica _portaEletronica;

        public CommandGarageLightOn(PortaEletronica portaEletronica)
        {
            this._portaEletronica = portaEletronica;
            _portaEletronica._local = "Garagem";
        }

        public void Execute()
        {
            this._portaEletronica.TurnOnLight();
        }
    }
}
