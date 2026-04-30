using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimplePaint
{
    public partial class Form1 : Form
    {
        enum ToolType { Line, Rectangle, Circle }

        private ToolType currentTool = ToolType.Line;
        private Color currentColor = Color.Black;
        private int currentLineWidth = 2;

        private Bitmap canvasBitmap;
        private Graphics canvasGraphics;

        private bool isDrawing = false;
        private Point startPoint;
        private Point endPoint;

        public Form1()
        {
            InitializeComponent();

           
            cmbColor.Items.Add("Black");
            cmbColor.Items.Add("Red");
            cmbColor.Items.Add("Blue");
            cmbColor.Items.Add("Green");
            cmbColor.SelectedIndex = 0;

            
            trbLineWidth.Minimum = 1;
            trbLineWidth.Maximum = 10;
            trbLineWidth.Value = 2;

           
            canvasBitmap = new Bitmap(picCanvas.Width, picCanvas.Height);
            canvasGraphics = Graphics.FromImage(canvasBitmap);
            canvasGraphics.Clear(Color.White);
            picCanvas.Image = canvasBitmap;
        }

       
        private void btnLine_Click(object sender, EventArgs e)
        {
            currentTool = ToolType.Line;
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            currentTool = ToolType.Rectangle;
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            currentTool = ToolType.Circle;
        }

       
        private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbColor.SelectedIndex)
            {
                case 0: currentColor = Color.Black; break;
                case 1: currentColor = Color.Red; break;
                case 2: currentColor = Color.Blue; break;
                case 3: currentColor = Color.Green; break;
            }
        }

       
        private void trbLineWidth_ValueChanged(object sender, EventArgs e)
        {
            currentLineWidth = trbLineWidth.Value;
        }

        
        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            startPoint = e.Location;
        }

        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isDrawing) return;

            endPoint = e.Location;
        }

       
        private void picCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (!isDrawing) return;

            isDrawing = false;
            endPoint = e.Location;

            Pen pen = new Pen(currentColor, currentLineWidth);

            if (currentTool == ToolType.Line)
            {
                canvasGraphics.DrawLine(pen, startPoint, endPoint);
            }
            else if (currentTool == ToolType.Rectangle)
            {
                Rectangle rect = MakeRect(startPoint, endPoint);
                canvasGraphics.DrawRectangle(pen, rect);
            }
            else if (currentTool == ToolType.Circle)
            {
                Rectangle rect = MakeRect(startPoint, endPoint);
                canvasGraphics.DrawEllipse(pen, rect);
            }

            picCanvas.Invalidate(); 
        }

        
        private Rectangle MakeRect(Point p1, Point p2)
        {
            return new Rectangle(
                Math.Min(p1.X, p2.X),
                Math.Min(p1.Y, p2.Y),
                Math.Abs(p1.X - p2.X),
                Math.Abs(p1.Y - p2.Y)
            );
        }
    }
}