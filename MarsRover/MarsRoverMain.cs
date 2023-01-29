using MarsRover.Commandes;
using MarsRover.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace MarsRover
{
    public sealed class MarsRoverMain
    {
        private const string Quit = "quit";

        
        private readonly IConsole _console;

        private Reasonable reasonable = new ();

        public static void Main()
        {
            new MarsRoverMain(new RealConsole()).Run(CancellationToken.None);

        }
        public MarsRoverMain(IConsole console)
        { 
            this._console = console;
            
        }

        public void Run(CancellationToken token)
        {

            while (RunOnce())
            {
                token.ThrowIfCancellationRequested();
            }
        }
        private bool RunOnce() 
        {
            _console.Write("> ");
            var command = _console.ReadLine();
            if (command == Quit) return false;

            Execute(command);
            return true ;
        }

        private void Execute(string commandLine)
        {
            var commandToChar = commandLine.ToCharArray();

            for (int i = 0; i < commandToChar.Length; i++)
            {
                switch (commandToChar[i].ToString().ToLower())
                {
                    case "a":
                        _console.WriteLine(reasonable.AvancerCommande());
                        break;

                    case "g":
                        _console.WriteLine(reasonable.TourneAGaucheCommande());
                        break;

                    case "d":
                        _console.WriteLine(reasonable.TournerADroiteCommande());
                        break;

                    default:
                        _console.WriteLine(reasonable.ErreurCommande(commandToChar[i].ToString().ToLower()));
                        break;
                }
            }
        }
    }
}
