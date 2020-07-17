﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraphicRedactor000.Brush;
using GraphicRedactor000.Figure;

namespace GraphicRedactor000.Draw
{
   public  class DrawFigure : IDraw
    {
        IFigure figure;
        IBrush brush;       
        public DrawFigure(IFigure figure, IBrush brush)
        {
            this.figure = figure;
            this.brush = brush;
        }

        public void Draw()

        {
            for (int i = 0; i < figure.dotlist.Count - 1; i++)
            {
                brush.DrawLine(figure.dotlist[i].X, figure.dotlist[i].Y, figure.dotlist[i + 1].X, figure.dotlist[i + 1].Y);
            }
            brush.DrawLine(figure.dotlist[figure.dotlist.Count - 1].X, figure.dotlist[figure.dotlist.Count - 1].Y, figure.dotlist[0].X, figure.dotlist[0].Y);
        }

    }
}
