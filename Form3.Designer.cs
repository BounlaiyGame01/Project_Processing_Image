namespace Imageprocess
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            imageBox1 = new Emgu.CV.UI.ImageBox();
            imageBox2 = new Emgu.CV.UI.ImageBox();
            groupBox1 = new GroupBox();
            btnCapture = new Button();
            btnStipWeb = new Button();
            btnStartWeb = new Button();
            panel1 = new Panel();
            btnLoad = new Button();
            groupBox2 = new GroupBox();
            btn_BasicProcessing = new Button();
            cbBinary = new ComboBox();
            btnHistogram = new Button();
            groupBox3 = new GroupBox();
            btnMorphology1 = new Button();
            cbMorphology = new ComboBox();
            groupBox4 = new GroupBox();
            cbEDetection = new ComboBox();
            btnEDetection = new Button();
            groupBox5 = new GroupBox();
            cbFilter = new ComboBox();
            groupBox6 = new GroupBox();
            btnReset = new Button();
            btnSave = new Button();
            histogramBox1 = new Emgu.CV.UI.HistogramBox();
            ((System.ComponentModel.ISupportInitialize)imageBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imageBox2).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)histogramBox1).BeginInit();
            SuspendLayout();
            // 
            // imageBox1
            // 
            imageBox1.BackColor = SystemColors.ButtonHighlight;
            imageBox1.BorderStyle = BorderStyle.FixedSingle;
            imageBox1.Location = new Point(12, 12);
            imageBox1.Name = "imageBox1";
            imageBox1.Size = new Size(502, 254);
            imageBox1.TabIndex = 2;
            imageBox1.TabStop = false;
            // 
            // imageBox2
            // 
            imageBox2.BackColor = SystemColors.ButtonHighlight;
            imageBox2.BorderStyle = BorderStyle.FixedSingle;
            imageBox2.Location = new Point(12, 272);
            imageBox2.Name = "imageBox2";
            imageBox2.Size = new Size(502, 271);
            imageBox2.TabIndex = 2;
            imageBox2.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.AppWorkspace;
            groupBox1.Controls.Add(btnCapture);
            groupBox1.Controls.Add(btnStipWeb);
            groupBox1.Controls.Add(btnStartWeb);
            groupBox1.Controls.Add(panel1);
            groupBox1.Location = new Point(516, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(388, 120);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Input Source";
            // 
            // btnCapture
            // 
            btnCapture.BackColor = SystemColors.ButtonHighlight;
            btnCapture.Location = new Point(249, 69);
            btnCapture.Name = "btnCapture";
            btnCapture.Size = new Size(126, 31);
            btnCapture.TabIndex = 1;
            btnCapture.Text = "Capture Frame";
            btnCapture.UseVisualStyleBackColor = false;
            btnCapture.Click += button4_Click;
            // 
            // btnStipWeb
            // 
            btnStipWeb.BackColor = SystemColors.ButtonHighlight;
            btnStipWeb.Location = new Point(127, 69);
            btnStipWeb.Name = "btnStipWeb";
            btnStipWeb.Size = new Size(116, 31);
            btnStipWeb.TabIndex = 1;
            btnStipWeb.Text = "Stop Webcam";
            btnStipWeb.UseVisualStyleBackColor = false;
            btnStipWeb.Click += btnStipWeb_Click;
            // 
            // btnStartWeb
            // 
            btnStartWeb.BackColor = SystemColors.ButtonHighlight;
            btnStartWeb.Location = new Point(6, 69);
            btnStartWeb.Name = "btnStartWeb";
            btnStartWeb.Size = new Size(115, 31);
            btnStartWeb.TabIndex = 1;
            btnStartWeb.Text = "Start Webcam";
            btnStartWeb.UseVisualStyleBackColor = false;
            btnStartWeb.Click += btnStartWeb_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLoad);
            panel1.Location = new Point(6, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(369, 40);
            panel1.TabIndex = 0;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = SystemColors.ButtonHighlight;
            btnLoad.Location = new Point(8, 3);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(358, 31);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Choose File";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.AppWorkspace;
            groupBox2.Controls.Add(btn_BasicProcessing);
            groupBox2.Controls.Add(cbBinary);
            groupBox2.Location = new Point(520, 141);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(384, 112);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Basic Processing";
            // 
            // btn_BasicProcessing
            // 
            btn_BasicProcessing.BackColor = SystemColors.ControlLightLight;
            btn_BasicProcessing.Location = new Point(10, 65);
            btn_BasicProcessing.Name = "btn_BasicProcessing";
            btn_BasicProcessing.Size = new Size(359, 31);
            btn_BasicProcessing.TabIndex = 3;
            btn_BasicProcessing.Text = "Apply";
            btn_BasicProcessing.UseVisualStyleBackColor = false;
            btn_BasicProcessing.Click += btn_BasicProcessing_Click;
            // 
            // cbBinary
            // 
            cbBinary.BackColor = SystemColors.ControlLightLight;
            cbBinary.FormattingEnabled = true;
            cbBinary.Items.AddRange(new object[] { "Binary", "Binary Invert", "OT'Su", "Guassian", "Mean" });
            cbBinary.Location = new Point(6, 32);
            cbBinary.Name = "cbBinary";
            cbBinary.Size = new Size(363, 26);
            cbBinary.TabIndex = 2;
            cbBinary.Text = "Binary";
            // 
            // btnHistogram
            // 
            btnHistogram.BackColor = SystemColors.ControlLightLight;
            btnHistogram.Location = new Point(18, 60);
            btnHistogram.Name = "btnHistogram";
            btnHistogram.Size = new Size(309, 31);
            btnHistogram.TabIndex = 1;
            btnHistogram.Text = "Create Histogram";
            btnHistogram.UseVisualStyleBackColor = false;
            btnHistogram.Click += btnHistogram_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.AppWorkspace;
            groupBox3.Controls.Add(btnMorphology1);
            groupBox3.Controls.Add(cbMorphology);
            groupBox3.Location = new Point(910, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(333, 120);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Morphology";
            // 
            // btnMorphology1
            // 
            btnMorphology1.BackColor = SystemColors.ControlLightLight;
            btnMorphology1.Location = new Point(6, 73);
            btnMorphology1.Name = "btnMorphology1";
            btnMorphology1.Size = new Size(321, 28);
            btnMorphology1.TabIndex = 4;
            btnMorphology1.Text = "Apply";
            btnMorphology1.UseVisualStyleBackColor = false;
            btnMorphology1.Click += btnMorphology1_Click;
            // 
            // cbMorphology
            // 
            cbMorphology.BackColor = SystemColors.ControlLightLight;
            cbMorphology.FormattingEnabled = true;
            cbMorphology.Items.AddRange(new object[] { "Erosion", "Gradient", "Top Hat", "Black Hat" });
            cbMorphology.Location = new Point(6, 31);
            cbMorphology.Name = "cbMorphology";
            cbMorphology.Size = new Size(321, 26);
            cbMorphology.TabIndex = 2;
            cbMorphology.Text = "Erosion";
            cbMorphology.SelectedIndexChanged += cbMorphology_SelectedIndexChanged;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.AppWorkspace;
            groupBox4.Controls.Add(cbEDetection);
            groupBox4.Controls.Add(btnEDetection);
            groupBox4.Location = new Point(910, 141);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(333, 111);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Edge Detection";
            // 
            // cbEDetection
            // 
            cbEDetection.BackColor = SystemColors.ControlLightLight;
            cbEDetection.FormattingEnabled = true;
            cbEDetection.Items.AddRange(new object[] { "Sobel", "Laplacian", "Canny" });
            cbEDetection.Location = new Point(6, 23);
            cbEDetection.Name = "cbEDetection";
            cbEDetection.Size = new Size(321, 26);
            cbEDetection.TabIndex = 2;
            cbEDetection.Text = "Sobel";
            cbEDetection.SelectedIndexChanged += cbEDetection_SelectedIndexChanged;
            // 
            // btnEDetection
            // 
            btnEDetection.BackColor = SystemColors.ControlLightLight;
            btnEDetection.Location = new Point(6, 64);
            btnEDetection.Name = "btnEDetection";
            btnEDetection.Size = new Size(321, 31);
            btnEDetection.TabIndex = 1;
            btnEDetection.Text = "Edge Detection";
            btnEDetection.UseVisualStyleBackColor = false;
            btnEDetection.Click += btnEDetection_Click;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = SystemColors.AppWorkspace;
            groupBox5.Controls.Add(cbFilter);
            groupBox5.Controls.Add(btnHistogram);
            groupBox5.Location = new Point(910, 258);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(333, 111);
            groupBox5.TabIndex = 3;
            groupBox5.TabStop = false;
            groupBox5.Text = "Histogram";
            // 
            // cbFilter
            // 
            cbFilter.BackColor = SystemColors.ControlLightLight;
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "Equalize", "Gaussian", "Median" });
            cbFilter.Location = new Point(18, 28);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(309, 26);
            cbFilter.TabIndex = 2;
            cbFilter.Text = "Gaussian";
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // groupBox6
            // 
            groupBox6.BackColor = SystemColors.AppWorkspace;
            groupBox6.Controls.Add(btnReset);
            groupBox6.Controls.Add(btnSave);
            groupBox6.Location = new Point(910, 375);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(333, 112);
            groupBox6.TabIndex = 3;
            groupBox6.TabStop = false;
            groupBox6.Text = "Actions";
            // 
            // btnReset
            // 
            btnReset.BackColor = SystemColors.ControlLightLight;
            btnReset.Location = new Point(6, 63);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(321, 31);
            btnReset.TabIndex = 1;
            btnReset.Text = "Reset to Original";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ControlLightLight;
            btnSave.Location = new Point(6, 23);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(321, 34);
            btnSave.TabIndex = 1;
            btnSave.Text = "Download Result";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // histogramBox1
            // 
            histogramBox1.BackColor = SystemColors.ButtonHighlight;
            histogramBox1.BorderStyle = BorderStyle.FixedSingle;
            histogramBox1.Location = new Point(520, 272);
            histogramBox1.Name = "histogramBox1";
            histogramBox1.Size = new Size(384, 271);
            histogramBox1.TabIndex = 2;
            histogramBox1.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(1255, 553);
            Controls.Add(histogramBox1);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox6);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(imageBox2);
            Controls.Add(imageBox1);
            Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)imageBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)imageBox2).EndInit();
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)histogramBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private Emgu.CV.UI.ImageBox imageBox2;
        private GroupBox groupBox1;
        private Button btnCapture;
        private Button btnStipWeb;
        private Button btnStartWeb;
        private Panel panel1;
        private Button btnLoad;
        private GroupBox groupBox2;
        private Button btnHistogram;
        private GroupBox groupBox3;
        private ComboBox cbMorphology;
        private GroupBox groupBox4;
        private ComboBox cbEDetection;
        private Button btnEDetection;
        private GroupBox groupBox5;
        private ComboBox cbFilter;
        private GroupBox groupBox6;
        private Button btnReset;
        private Button btnSave;
        private Emgu.CV.UI.HistogramBox histogramBox1;
        private ComboBox cbBinary;
        private Button btnMorphology1;
        private Button btn_BasicProcessing;
    }
}