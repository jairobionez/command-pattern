using CommandPattern.Data.Commands;
using System.Text;

namespace CommandPattern.Data
{
    public class ControleRemoto
    {
        private ICommand[] _onComand;
        private ICommand[] _offComand;

        public ControleRemoto()
        {
            _onComand = new ICommand[7];

            _offComand = new ICommand[7];

            ICommand command = new Command();

            for (int i = 0; i < 7; i++)
            {
                _onComand[i] = command;
                _offComand[i] = command;
            };
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onComand[slot] = onCommand;
            _offComand[slot] = offCommand;
        }

        public void OnPressionado(int slot)
        {
            _onComand[slot].Execute();
        }

        public void OffPressionado(int slot)
        {
            _offComand[slot].Execute();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            return sb.ToString();
        }
    }
}
