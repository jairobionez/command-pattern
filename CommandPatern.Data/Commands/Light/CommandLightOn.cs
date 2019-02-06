using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Data.Commands.Light
{
    public class CommandLightOn : ICommand
    {
        public Luz _luz;

        public CommandLightOn(Luz luz)
        {
            this._luz = luz;
            luz._local = "Sala";
        }

        public void Execute()
        {
            this._luz.TurnOn();
        }
    }
}
