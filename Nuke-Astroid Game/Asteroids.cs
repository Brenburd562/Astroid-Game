using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuke_Astroid_Game
{
    class Asteroids
    {
        public int x, y, size;
        public Asteroids(int _x, int _y, int _size)
        {
            x = _x;
            y = _y;
            size = _size;
        }
        public void Move()
        {
            int speed = 3;
            y += speed;
        }
    }
}