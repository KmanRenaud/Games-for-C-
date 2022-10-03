using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class Settings
    {

        public static int Width { get; set; }
            
        public static int Height { get; set; }
        public static int Speed { get; set; }

        public static string directions;

        public Settings()
        {
            Speed = 0;
            Width = 16;
            Height = 16;
            directions = "left";
        }



    }
}
