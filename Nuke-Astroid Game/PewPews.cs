using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuke_Astroid_Game
{
    class PewPews
    {
        public int x, y, size = 5;
        public PewPews(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
        public void Move()
        {
            int speed = 5;
            y -= speed;
        }
    }
}
