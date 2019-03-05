//by data layer 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harness
{
    class Harness
    {
        enum State
        {
            initState,
            exitState,

        };
        static void Main(string[] args)
        {
            State _state = State.initState;
            Console.WriteLine("Press 'a' to start harness");
            ConsoleKeyInfo ch;
            ch = Console.ReadKey();
            if (Char.IsLetterOrDigit(ch.KeyChar))
            {
                if (ch.KeyChar == 'a')
                {
                    _state = State.initState;
                    Console.WriteLine("initial state");
                    Console.WriteLine("press 'b' to go to exit state ");
                    ch = Console.ReadKey();
                }
                else if (ch.KeyChar == 'b')
                {
                    _state = State.exitState;
                    Console.WriteLine("exit state");
                    Console.WriteLine("current state:exit state ");
                    ch = Console.ReadKey();

                }


            }
        }

        static void SystemInit()
        {
            Console.WriteLine("In SystemInit");
        }

    }
}