using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SimplePaint
{
    public partial class Form1 : Form
    {
        enum ToolType { Line, Rectangle, Circle }


        private ToolType currentTool = ToolType.Line;
        private Color currentColor = Color.Black;
        private int currentLineWidth = 2;
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbColor.SelectedIndex = 0;

            switch (cmbColor.SelectedIndex)
            {
                case 0: currentColor = Color.Black; break;
                case 1: currentColor = Color.Red; break;
                case 2: currentColor = Color.Blue; break;
                case 3: currentColor = Color.Green; break;
            }
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

        private void trbLineWidth_ValueChanged(object sender, EventArgs e)
        {
            currentLineWidth = trbLineWidth.Value;
        }
    }
}
