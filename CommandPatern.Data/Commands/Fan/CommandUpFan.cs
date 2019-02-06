using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Data.Commands.Fan
{
    public class CommandUpFan : ICommand
    {
        VentiladorTeto _ventiladorTeto;
        public CommandUpFan(VentiladorTeto ventiladorTeto)
        {
            this._ventiladorTeto = ventiladorTeto;
            _ventiladorTeto._local = "Sala";
        }

        public void Execute()
        {
            if (this._ventiladorTeto._nivel != VentiladorTeto.Nivel.ALTO)
            {
                this._ventiladorTeto._nivel++;
                this._ventiladorTeto.Atualizar();
            }
        }
    }
}
