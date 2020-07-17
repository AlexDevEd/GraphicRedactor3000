using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using GraphicRedactor000.Brush;
using GraphicRedactor000.Figure;
using GraphicRedactor000.Draw;


namespace GraphicRedactor000.Tool
{
   public class FigureTool: ITool
    {
        IFigure figure;
        bool cursorActive;
        int x1, y1, x2, y2;

        public FigureTool(IFigure figure)
        {
            this.figure = figure;
            cursorActive = false;

        }

        public void MouseDown(PictureBox sheet, IBrush brush, MouseEventArgs e)
        {
            Canva.GetCanva.SaveToCache();
            cursorActive = true;
            x1 = e.X;
            y1 = e.Y;
            x2 = e.X;
            y2 = e.Y;
            Canva.GetCanva.WriteToPictureBox(sheet);
        }

        public void MouseMove(PictureBox sheet, IBrush brush, MouseEventArgs e)
        {
            figure.Createdotlist(x1, y1, x2, y2);
            if (cursorActive == true)
            {
                Canva.GetCanva.LoadFromCache();
                x2 = e.X;
                y2 = e.Y;
                DrawFigure drawer = new DrawFigure(figure, brush);
                drawer.Draw();
                Canva.GetCanva.WriteToPictureBox(sheet);
            }
        }

        public void MouseUp(PictureBox sheet, IBrush brush, MouseEventArgs e)
        {
            cursorActive = false;
            x2 = e.X;
            y2 = e.Y;
            Canva.GetCanva.WriteToPictureBox(sheet);
        }
       
    }
}
