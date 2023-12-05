using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rogalik_exp
{
    public class Game
    {
        public Map map { get; private set; }
        Display display;
        Controls controls;
        public ConsoleKey button{get; private set;}
        public Game()
        {   
            map = new();
            display = new(map);
            controls = new();

        }
        public void run_process()
        {
            while (true) 
            {   
                display=new(map);
                display.show(); 
                button = Console.ReadKey().Key;
                controls.detect_key(this);
            }
        }
    }

}
