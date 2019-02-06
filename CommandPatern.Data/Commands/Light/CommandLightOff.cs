using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Data.Commands.Light
{
    public class CommandLightOff : ICommand
    {
        public Luz _luz;

        public CommandLightOff(Luz luz)
        {
            this._luz = luz;
            luz._local = "Sala";
        }

        public void Execute()
        {
            this._luz.TurnOff();
        }
    }
}
