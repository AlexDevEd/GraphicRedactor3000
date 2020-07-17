using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraphicRedactor000.Brush;


namespace GraphicRedactor000.Tool
{
   public class FillTool : ITool
    {
        public void MouseDown(PictureBox sheet, IBrush brush, MouseEventArgs e) 
        {
            Canva.GetCanva.Fill(e.X, e.Y, brush.BrushColor);
            Canva.GetCanva.WriteToPictureBox(sheet);
        }
        public void MouseUp(PictureBox sheet, IBrush brush, MouseEventArgs e) { return; }
        public void MouseMove(PictureBox sheet, IBrush brush, MouseEventArgs e) { return; }
    }
}
