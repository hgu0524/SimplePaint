namespace SimplePaint
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            picCanvas = new PictureBox();
            cmbColor = new ComboBox();
            trbLineWidth = new TrackBar();
            btnLine = new Button();
            btnRectangle = new Button();
            btnCircle = new Button();
            btnOpenFile = new Button();
            btnSaveFile = new Button();
            lblAppName = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)picCanvas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trbLineWidth).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // picCanvas
            // 
            picCanvas.Location = new Point(31, 292);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new Size(1221, 504);
            picCanvas.TabIndex = 0;
            picCanvas.TabStop = false;
            picCanvas.MouseDown += picCanvas_MouseDown;
            picCanvas.MouseMove += picCanvas_MouseMove;
            picCanvas.MouseUp += picCanvas_MouseUp;
            // 
            // cmbColor
            // 
            cmbColor.FormattingEnabled = true;
            cmbColor.Location = new Point(26, 67);
            cmbColor.Name = "cmbColor";
            cmbColor.Size = new Size(183, 40);
            cmbColor.TabIndex = 1;
            cmbColor.SelectedIndexChanged += cmbColor_SelectedIndexChanged;
            // 
            // trbLineWidth
            // 
            trbLineWidth.Location = new Point(6, 54);
            trbLineWidth.Minimum = 1;
            trbLineWidth.Name = "trbLineWidth";
            trbLineWidth.Size = new Size(231, 90);
            trbLineWidth.TabIndex = 2;
            trbLineWidth.Value = 2;
            trbLineWidth.ValueChanged += trbLineWidth_ValueChanged;
            // 
            // btnLine
            // 
            btnLine.AutoSize = true;
            btnLine.Image = (Image)resources.GetObject("btnLine.Image");
            btnLine.Location = new Point(6, 43);
            btnLine.Name = "btnLine";
            btnLine.Size = new Size(110, 101);
            btnLine.TabIndex = 3;
            btnLine.Text = "직선";
            btnLine.TextAlign = ContentAlignment.BottomCenter;
            btnLine.UseVisualStyleBackColor = true;
            btnLine.Click += btnLine_Click;
            // 
            // btnRectangle
            // 
            btnRectangle.Image = (Image)resources.GetObject("btnRectangle.Image");
            btnRectangle.Location = new Point(122, 43);
            btnRectangle.Name = "btnRectangle";
            btnRectangle.Size = new Size(110, 101);
            btnRectangle.TabIndex = 4;
            btnRectangle.Text = "사각형";
            btnRectangle.TextAlign = ContentAlignment.BottomCenter;
            btnRectangle.UseVisualStyleBackColor = true;
            btnRectangle.Click += btnRectangle_Click;
            // 
            // btnCircle
            // 
            btnCircle.Image = (Image)resources.GetObject("btnCircle.Image");
            btnCircle.Location = new Point(238, 43);
            btnCircle.Name = "btnCircle";
            btnCircle.Size = new Size(110, 101);
            btnCircle.TabIndex = 5;
            btnCircle.Text = "원";
            btnCircle.TextAlign = ContentAlignment.BottomCenter;
            btnCircle.UseVisualStyleBackColor = true;
            btnCircle.Click += btnCircle_Click;
            // 
            // btnOpenFile
            // 
            btnOpenFile.BackColor = Color.FromArgb(128, 255, 128);
            btnOpenFile.Location = new Point(975, 167);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(126, 114);
            btnOpenFile.TabIndex = 6;
            btnOpenFile.Text = "열기";
            btnOpenFile.UseVisualStyleBackColor = false;
            // 
            // btnSaveFile
            // 
            btnSaveFile.BackColor = Color.FromArgb(255, 128, 128);
            btnSaveFile.Location = new Point(1117, 167);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(126, 114);
            btnSaveFile.TabIndex = 7;
            btnSaveFile.Text = "저장";
            btnSaveFile.UseVisualStyleBackColor = false;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("맑은 고딕", 25.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblAppName.ForeColor = Color.Blue;
            lblAppName.Location = new Point(47, 25);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(431, 92);
            lblAppName.TabIndex = 8;
            lblAppName.Text = "Simple paint";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLine);
            groupBox1.Controls.Add(btnRectangle);
            groupBox1.Controls.Add(btnCircle);
            groupBox1.Location = new Point(47, 124);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(356, 162);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "도형 선택";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbColor);
            groupBox2.Location = new Point(439, 124);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(234, 162);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "색 선택";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(trbLineWidth);
            groupBox3.Location = new Point(701, 124);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(246, 162);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "선 두께";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 829);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblAppName);
            Controls.Add(btnSaveFile);
            Controls.Add(btnOpenFile);
            Controls.Add(picCanvas);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picCanvas).EndInit();
            ((System.ComponentModel.ISupportInitialize)trbLineWidth).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picCanvas;
        private ComboBox cmbColor;
        private TrackBar trbLineWidth;
        private Button btnLine;
        private Button btnRectangle;
        private Button btnCircle;
        private Button btnOpenFile;
        private Button btnSaveFile;
        private Label lblAppName;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}
