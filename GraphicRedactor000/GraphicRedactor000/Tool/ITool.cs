using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using GraphicRedactor000.Brush;

namespace GraphicRedactor000.Tool
{
   public interface ITool
    {
        void MouseDown(PictureBox sheet, IBrush brush, MouseEventArgs e);
        void MouseUp(PictureBox sheet, IBrush brush, MouseEventArgs e);
        void MouseMove(PictureBox sheet, IBrush brush, MouseEventArgs e);
    }
}
