using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rogalik_exp
{
    public class Controls
    {
        //Moving
        private ConsoleKey left = ConsoleKey.LeftArrow;
        private ConsoleKey right = ConsoleKey.RightArrow;
        private ConsoleKey up = ConsoleKey.UpArrow;
        private ConsoleKey down = ConsoleKey.DownArrow;
        public Controls() { }

        public void detect_key(Game game)
        {
            var posx = game.map.objects[1][0];
            var posy = game.map.objects[1][1];
            if (game.button==left) 
            {
                if (posx>1) 
                {
                    var myvar = game.map.graphics[posy, posx-1];
                    if (myvar != '|' && myvar != '-')
                    {
                        game.map.objects[1][0] -= 1;
                    }
                }
                
                
            }
            if (game.button == right)
            {
                if (posx < game.map.width-1)
                {
                    var myvar = game.map.graphics[posy, posx + 1];
                    if (myvar != '|' && myvar != '-')
                    {
                        game.map.objects[1][0] += 1;
                    }
                }
            }
            if (game.button == up)
            {
                if (posy >0)
                {
                    var myvar = game.map.graphics[posy-1, posx];
                    if (myvar != '|' && myvar != '-')
                    {
                        game.map.objects[1][1] -= 1;
                    }
                }
            }
            if (game.button == down)
            {
                if (posy <game.map.height-1)
                {
                    var myvar = game.map.graphics[posy + 1, posx];
                    if (myvar != '|' && myvar != '-')
                    {
                        game.map.objects[1][1] += 1;
                    }
                }
            }
        }

    }
}
