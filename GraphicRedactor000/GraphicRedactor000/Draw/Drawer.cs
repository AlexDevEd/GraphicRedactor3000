using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphicRedactor000.Draw
{
    public class Drawer
    {
        public Point begin;
        public Point end;
        public int line;
        public Drawer(int x1, int y1, int x2, int y2)
        {
            int x=0;
            int y = 0;
            begin.X = x1;
            begin.Y = y1;
            end.X = x2;
            end.Y = y2;
            line = (y1 - y2) * x + (x2 - x1) * y + ((x1 * y2) - (x2 * y1)); 
            
        }
    }
}
