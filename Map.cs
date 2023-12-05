namespace rogalik_exp
{
    public class Map
    {
        public int height { get; private set; }
        public int width { get; private set; }
        public char[,] graphics { get; private set; }
        //ДОДЕЛАТЬ
        //public Dictionary<int, Dictionary<int, int[]>> da;
        public Dictionary<int, int[]> objects { get; private set; }
        public Map()
        {
            height = 500; width = 500;

            graphics = new char[height,width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    graphics[i, j] = ' ';
                }
            }
            objects = new Dictionary<int, int[]>();
            spawn_structure_start();
        }
        void show_map_element(int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.Write(graphics[top, left]);
        }
        void spawn_stucture(int x, int y)
        {

        }
        void spawn_structure_start()
        {
            int start_room_height = 10;
            int start_room_weight = 15;
            var posx = 100;
            var posy = 100;
            objects.Add(1, new int[2] { posx + 3, posy + 3 });
            for (int i = 0; i < start_room_height; i++)
            {
                for (int j = 0; j < start_room_weight; j++)
                {
                    graphics[i+ posy, j+ posx] = '.';
                    if (i == 0 || i == start_room_height - 1)
                    {
                        graphics[i + posy, j+ posx] = '-';
                    }
                    if (j == 0 || j == start_room_weight - 1)
                    {
                        graphics[i+ posy, j + posx] = '|';
                    }
                }
            }

        }
        public void debug_spp(int h,int w)
        {
            
        }
    }
}