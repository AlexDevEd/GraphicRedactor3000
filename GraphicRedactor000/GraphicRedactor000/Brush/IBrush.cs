using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphicRedactor000.Brush
{
    public interface IBrush
    {
        int BrushSize { get; set; }
        Color BrushColor { get; set; }
        void DrawDot(int x, int y);
        void DrawLine(int x1, int y1, int x2, int y2, bool drawFirstDot = false);
    }
}
