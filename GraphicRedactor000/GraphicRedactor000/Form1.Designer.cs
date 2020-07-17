namespace GraphicRedactor000
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonEraser = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.Square = new System.Windows.Forms.Button();
            this.buttonEquilaralTriangle = new System.Windows.Forms.Button();
            this.buttonTriangle = new System.Windows.Forms.Button();
            this.buttonRectangle = new System.Windows.Forms.Button();
            this.buttonCircle = new System.Windows.Forms.Button();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.buttonDrawLine = new System.Windows.Forms.Button();
            this.buttonChangeColor = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonEraser);
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Controls.Add(this.Square);
            this.panel1.Controls.Add(this.buttonEquilaralTriangle);
            this.panel1.Controls.Add(this.buttonTriangle);
            this.panel1.Controls.Add(this.buttonRectangle);
            this.panel1.Controls.Add(this.buttonCircle);
            this.panel1.Controls.Add(this.buttonDraw);
            this.panel1.Controls.Add(this.buttonDrawLine);
            this.panel1.Controls.Add(this.buttonChangeColor);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 52);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonEraser
            // 
            this.buttonEraser.BackgroundImage = global::GraphicRedactor000.Properties.Resources.eraser;
            this.buttonEraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEraser.Location = new System.Drawing.Point(362, 17);
            this.buttonEraser.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEraser.Name = "buttonEraser";
            this.buttonEraser.Size = new System.Drawing.Size(28, 28);
            this.buttonEraser.TabIndex = 13;
            this.buttonEraser.UseVisualStyleBackColor = true;
            this.buttonEraser.Click += new System.EventHandler(this.buttonEraser_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonClear.BackgroundImage")));
            this.buttonClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClear.Location = new System.Drawing.Point(593, 17);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(28, 28);
            this.buttonClear.TabIndex = 12;
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Square
            // 
            this.Square.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Square.BackgroundImage")));
            this.Square.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Square.Location = new System.Drawing.Point(428, 17);
            this.Square.Margin = new System.Windows.Forms.Padding(2);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(28, 28);
            this.Square.TabIndex = 11;
            this.Square.UseVisualStyleBackColor = true;
            this.Square.Click += new System.EventHandler(this.Square_Click);
            // 
            // buttonEquilaralTriangle
            // 
            this.buttonEquilaralTriangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEquilaralTriangle.BackgroundImage")));
            this.buttonEquilaralTriangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEquilaralTriangle.Location = new System.Drawing.Point(396, 17);
            this.buttonEquilaralTriangle.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEquilaralTriangle.Name = "buttonEquilaralTriangle";
            this.buttonEquilaralTriangle.Size = new System.Drawing.Size(28, 28);
            this.buttonEquilaralTriangle.TabIndex = 10;
            this.buttonEquilaralTriangle.UseVisualStyleBackColor = true;
            this.buttonEquilaralTriangle.Click += new System.EventHandler(this.buttonEquilaralTriangle_Click);
            // 
            // buttonTriangle
            // 
            this.buttonTriangle.BackgroundImage = global::GraphicRedactor000.Properties.Resources.triangle;
            this.buttonTriangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTriangle.Location = new System.Drawing.Point(330, 17);
            this.buttonTriangle.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTriangle.Name = "buttonTriangle";
            this.buttonTriangle.Size = new System.Drawing.Size(28, 28);
            this.buttonTriangle.TabIndex = 6;
            this.buttonTriangle.UseVisualStyleBackColor = true;
            this.buttonTriangle.Click += new System.EventHandler(this.buttonTriangle_Click);
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.BackgroundImage = global::GraphicRedactor000.Properties.Resources.rectangle;
            this.buttonRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRectangle.Location = new System.Drawing.Point(292, 17);
            this.buttonRectangle.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(28, 28);
            this.buttonRectangle.TabIndex = 5;
            this.buttonRectangle.UseVisualStyleBackColor = true;
            this.buttonRectangle.Click += new System.EventHandler(this.buttonRectangle_Click);
            // 
            // buttonCircle
            // 
            this.buttonCircle.BackgroundImage = global::GraphicRedactor000.Properties.Resources.circle;
            this.buttonCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCircle.Location = new System.Drawing.Point(256, 17);
            this.buttonCircle.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(28, 28);
            this.buttonCircle.TabIndex = 4;
            this.buttonCircle.UseVisualStyleBackColor = true;
            // 
            // buttonDraw
            // 
            this.buttonDraw.BackgroundImage = global::GraphicRedactor000.Properties.Resources.editor_pencil_pen_edit_write_glyph_256;
            this.buttonDraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDraw.Location = new System.Drawing.Point(88, 17);
            this.buttonDraw.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(28, 28);
            this.buttonDraw.TabIndex = 3;
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // buttonDrawLine
            // 
            this.buttonDrawLine.BackgroundImage = global::GraphicRedactor000.Properties.Resources.line_icon_256;
            this.buttonDrawLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDrawLine.Location = new System.Drawing.Point(50, 17);
            this.buttonDrawLine.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDrawLine.Name = "buttonDrawLine";
            this.buttonDrawLine.Size = new System.Drawing.Size(28, 28);
            this.buttonDrawLine.TabIndex = 2;
            this.buttonDrawLine.UseVisualStyleBackColor = true;
            this.buttonDrawLine.Click += new System.EventHandler(this.buttonDrawLine_Click);
            // 
            // buttonChangeColor
            // 
            this.buttonChangeColor.BackgroundImage = global::GraphicRedactor000.Properties.Resources.fill;
            this.buttonChangeColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonChangeColor.Location = new System.Drawing.Point(166, 17);
            this.buttonChangeColor.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChangeColor.Name = "buttonChangeColor";
            this.buttonChangeColor.Size = new System.Drawing.Size(28, 28);
            this.buttonChangeColor.TabIndex = 0;
            this.buttonChangeColor.UseVisualStyleBackColor = true;
            this.buttonChangeColor.Click += new System.EventHandler(this.buttonChangeColor_Click);
            this.buttonChangeColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonChangeColor_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(987, 24);
            this.menuStrip1.TabIndex = 8;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(987, 548);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 548);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonChangeColor;
        private System.Windows.Forms.Button buttonCircle;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Button buttonDrawLine;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Button buttonTriangle;
        private System.Windows.Forms.Button buttonRectangle;
        private System.Windows.Forms.Button buttonEquilaralTriangle;
        private System.Windows.Forms.Button Square;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonEraser;
        private System.Windows.Forms.Button buttonClear;
    }
}

