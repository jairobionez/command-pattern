using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Data
{
    public class VentiladorTeto
    {
        public enum Nivel
        {
            DESLIGADO = 0,
            BAIXO = 1,
            MEDIO = 2,
            ALTO = 3
        }

        public string _local = string.Empty;

        public Nivel _nivel = Nivel.DESLIGADO;

        public VentiladorTeto() { }

        public void High()
        {
            _nivel = Nivel.ALTO;
            Console.WriteLine("{0} ventilado está com velocidade alta", _local);
        }

        public void Medium()
        {
            _nivel = Nivel.MEDIO;

            Console.WriteLine("{0} ventilado está com velocidade média", _local);
        }

        public void Low()
        {
            _nivel = Nivel.BAIXO;
            Console.WriteLine("{0} ventilado está com velocidade baixa", _local);
        }

        public void Off()
        {
            _nivel = Nivel.DESLIGADO;
            Console.WriteLine("{0} ventilado está desligado", _local);
        }

        public void Atualizar()
        {
            switch (this._nivel)
            {
                case VentiladorTeto.Nivel.DESLIGADO:
                    this.Off();
                    break;
                case VentiladorTeto.Nivel.BAIXO:
                    this.Low();
                    break;
                case VentiladorTeto.Nivel.MEDIO:
                    this.Medium();
                    break;
                case VentiladorTeto.Nivel.ALTO:
                    this.High();
                    break;
                default:
                    break;
            }
        }
    }
}
