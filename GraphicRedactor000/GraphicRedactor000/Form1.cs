
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraphicRedactor000.Tool;
using GraphicRedactor000.Brush;
using GraphicRedactor000.Figure;
using System.Threading;
using System.Diagnostics;

namespace GraphicRedactor000
{
    public partial class Form1 :Form
    {
        public bool cursorAktive;
        ITool tool;
        IBrush brush;
        Color paintColor1;
        int brushSize;
        string title = "Приветствую вас! Это GraphicRedactor000.";
        string curTitle;
        
        public Form1()
        {
            InitializeComponent();
            this.Text = "";
            curTitle = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            startProgram();
            paintColor1 = Color.Black;
            brushSize = 3;
            brush = new CircleBrush(brushSize, paintColor1);
            tool = new PenTool();
        }
        private void startProgram()
        {
            Canva.GetCanva.Init(pictureBox1.Width, pictureBox1.Height);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (tool != null)
            {
                tool.MouseDown((PictureBox)sender, brush, e);
            }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (tool != null)
            {
                tool.MouseUp((PictureBox)sender, brush, e);
            }
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (tool != null)
            {
                tool.MouseMove((PictureBox)sender, brush, e);
            }
        }


        

      public void buttonChangeColor_MouseClick(object sender, MouseEventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            colorDialog1.AllowFullOpen = true;
            
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            { buttonChangeColor.BackColor = colorDialog1.Color; }
            brush.BrushColor = buttonChangeColor.BackColor;
        }

        private void buttonDrawLine_Click(object sender, EventArgs e)
        {
            tool = new FigureTool(new Figure.Line());
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
           
            tool = new PenTool();
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            tool = new FigureTool(new Figure.Rectangle());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            tool = new FigureTool(new TriangleRectangular());
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            startProgram();
        }

        private void buttonEquilaralTriangle_Click(object sender, EventArgs e)
        {
            tool = new FigureTool(new EquilateralTriangle());
        }

        private void Square_Click(object sender, EventArgs e)
        {
            tool = new FigureTool(new Square());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        if (curTitle.Length == title.Length) curTitle = "";
            {
                curTitle += title[curTitle.Length];
                this.Text = curTitle;
  
            }

        }

        private void buttonChangeColor_Click(object sender, EventArgs e)
        {
            tool = new FillTool();
        }

        private void buttonEraser_Click(object sender, EventArgs e)
        {
            tool = new EraserTool();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            labelSize.Text = trackBar1.Value + "";
            brush.BrushSize = Convert.ToInt32(labelSize.Text);
        }

        private void buttonEllipse_Click(object sender, EventArgs e)
        {
            tool = new FigureTool(new Figure.Ellips());
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            tool = new FigureTool(new Figure.Circle());
        }
    }
}
