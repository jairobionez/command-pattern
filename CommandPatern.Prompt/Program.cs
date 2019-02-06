using CommandPattern.Data;
using CommandPattern.Data.Commands.Fan;
using CommandPattern.Data.Commands.Garage;
using CommandPattern.Data.Commands.Light;
using System;

namespace CommandPattern.Prompt
{
    class Program
    {
        static void Main(string[] args)
        {
            ControleRemoto controle = new ControleRemoto();

            Luz luzSala = new Luz();
            PortaEletronica portaoGaragem = new PortaEletronica();
            VentiladorTeto ventiladorSala = new VentiladorTeto();

            controle.SetCommand(0, new CommandLightOn(luzSala), new CommandLightOff(luzSala));
            controle.SetCommand(1, new CommandGarageLightOn(portaoGaragem), new CommandGarageLightOff(portaoGaragem));
            controle.SetCommand(2, new CommandOpenDoorGarage(portaoGaragem), new CommandCloseDoorGarage(portaoGaragem));
            controle.SetCommand(3, new CommandUpFan(ventiladorSala), new CommandDownFan(ventiladorSala));

            controle.OnPressionado(0);
            controle.OnPressionado(1);
            controle.OnPressionado(2);
            controle.OffPressionado(0);
            controle.OffPressionado(1);
            controle.OffPressionado(2);
            controle.OnPressionado(3);
            controle.OnPressionado(3);
            controle.OnPressionado(3);
            controle.OffPressionado(3);
            controle.OnPressionado(6);
            controle.OffPressionado(6);

            Console.WriteLine(controle);
            Console.ReadKey();
        }
    }
}
