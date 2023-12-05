

using System.Security.Policy;

namespace rogalik_exp
{
    public class Display
    {
        private char[,] curdisp=new char[height, width];
        private const int height=20;
        private const int width=20;
        private const int display_posL=5;
        private const int display_posT=5;
        public Display() 
        {
            curdisp = new char[height, width];
        }
        public Display(Map map)
        {
            var playerx = map.objects[1][0];
            var playery = map.objects[1][1];
            for (int i = 0;i < height;i++) 
            {
                for (int j = 0;j < width;j++)
                {   
                    if (playery - height / 2 + i>0 && playerx - width / 2 + j > 0)
                    {
                        if (curdisp[i, j] != map.graphics[playery - height / 2 + i, playerx - width / 2 + j])
                        {
                            curdisp[i, j] = ' ';
                            curdisp[i, j] = map.graphics[playery - height / 2 + i, playerx - width / 2 + j];
                        }
                        if(i- height / 2==0&& j- width / 2 == 0)
                        {
                            curdisp[i, j] = 'x';
                        }
                    }
                    
                }
            }
        }
        public void show()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.SetCursorPosition(display_posL+j, display_posT+i);
                    Console.CursorVisible = false;
                    Console.Write(curdisp[i,j]);
                }
            }
        }

    }
}
