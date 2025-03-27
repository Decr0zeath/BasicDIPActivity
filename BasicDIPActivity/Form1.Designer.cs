namespace BasicDIPActivity
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicDIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greyscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorInversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogLoadImage = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogLoadBackground = new System.Windows.Forms.OpenFileDialog();
            this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
            this.pictureBoxProcessed = new System.Windows.Forms.PictureBox();
            this.pictureBoxLoadImage = new System.Windows.Forms.PictureBox();
            this.pictureBoxLoadBackground = new System.Windows.Forms.PictureBox();
            this.pictureBoxSubtract = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imageButtonLoadBackground = new Bunifu.Framework.UI.BunifuImageButton();
            this.imageButtonLoadImage = new Bunifu.Framework.UI.BunifuImageButton();
            this.label3 = new System.Windows.Forms.Label();
            this.imageButtonSubtract = new Bunifu.Framework.UI.BunifuImageButton();
            this.sliderThreshold = new Bunifu.Framework.UI.BunifuSlider();
            this.labelThreshold = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProcessed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSubtract)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageButtonLoadBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageButtonLoadImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageButtonSubtract)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.basicDIPToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1186, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(126)))));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.openToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(126)))));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(126)))));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // basicDIPToolStripMenuItem
            // 
            this.basicDIPToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.basicDIPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageCopyToolStripMenuItem,
            this.greyscaleToolStripMenuItem,
            this.colorInversionToolStripMenuItem,
            this.histogramToolStripMenuItem,
            this.sepiaToolStripMenuItem});
            this.basicDIPToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basicDIPToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(126)))));
            this.basicDIPToolStripMenuItem.Name = "basicDIPToolStripMenuItem";
            this.basicDIPToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.basicDIPToolStripMenuItem.Text = "Basic DIP";
            // 
            // imageCopyToolStripMenuItem
            // 
            this.imageCopyToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.imageCopyToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(126)))));
            this.imageCopyToolStripMenuItem.Name = "imageCopyToolStripMenuItem";
            this.imageCopyToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.imageCopyToolStripMenuItem.Text = "Image Copy";
            this.imageCopyToolStripMenuItem.Click += new System.EventHandler(this.imageCopyToolStripMenuItem_Click);
            // 
            // greyscaleToolStripMenuItem
            // 
            this.greyscaleToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.greyscaleToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(126)))));
            this.greyscaleToolStripMenuItem.Name = "greyscaleToolStripMenuItem";
            this.greyscaleToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.greyscaleToolStripMenuItem.Text = "Greyscale";
            this.greyscaleToolStripMenuItem.Click += new System.EventHandler(this.greyscaleToolStripMenuItem_Click);
            // 
            // colorInversionToolStripMenuItem
            // 
            this.colorInversionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.colorInversionToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(126)))));
            this.colorInversionToolStripMenuItem.Name = "colorInversionToolStripMenuItem";
            this.colorInversionToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.colorInversionToolStripMenuItem.Text = "Color Inversion";
            this.colorInversionToolStripMenuItem.Click += new System.EventHandler(this.colorInversionToolStripMenuItem_Click);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.histogramToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(126)))));
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.histogramToolStripMenuItem.Text = "Histogram";
            this.histogramToolStripMenuItem.Click += new System.EventHandler(this.histogramToolStripMenuItem_Click);
            // 
            // sepiaToolStripMenuItem
            // 
            this.sepiaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.sepiaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(126)))));
            this.sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            this.sepiaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.sepiaToolStripMenuItem.Text = "Sepia";
            this.sepiaToolStripMenuItem.Click += new System.EventHandler(this.sepiaToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialogLoadImage
            // 
            this.openFileDialogLoadImage.FileName = "openFileDialogLoadImage";
            this.openFileDialogLoadImage.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogLoadImage_FileOk);
            // 
            // openFileDialogLoadBackground
            // 
            this.openFileDialogLoadBackground.FileName = "openFileDialogLoadBackground";
            this.openFileDialogLoadBackground.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogLoadBackground_FileOk);
            // 
            // pictureBoxOriginal
            // 
            this.pictureBoxOriginal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.pictureBoxOriginal.Location = new System.Drawing.Point(22, 42);
            this.pictureBoxOriginal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBoxOriginal.Name = "pictureBoxOriginal";
            this.pictureBoxOriginal.Size = new System.Drawing.Size(375, 244);
            this.pictureBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOriginal.TabIndex = 1;
            this.pictureBoxOriginal.TabStop = false;
            this.pictureBoxOriginal.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxOriginal_Paint);
            // 
            // pictureBoxProcessed
            // 
            this.pictureBoxProcessed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.pictureBoxProcessed.Location = new System.Drawing.Point(411, 42);
            this.pictureBoxProcessed.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBoxProcessed.Name = "pictureBoxProcessed";
            this.pictureBoxProcessed.Size = new System.Drawing.Size(375, 244);
            this.pictureBoxProcessed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProcessed.TabIndex = 2;
            this.pictureBoxProcessed.TabStop = false;
            this.pictureBoxProcessed.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxProcessed_Paint);
            // 
            // pictureBoxLoadImage
            // 
            this.pictureBoxLoadImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.pictureBoxLoadImage.Location = new System.Drawing.Point(22, 382);
            this.pictureBoxLoadImage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBoxLoadImage.Name = "pictureBoxLoadImage";
            this.pictureBoxLoadImage.Size = new System.Drawing.Size(375, 244);
            this.pictureBoxLoadImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLoadImage.TabIndex = 3;
            this.pictureBoxLoadImage.TabStop = false;
            this.pictureBoxLoadImage.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxLoadImage_Paint);
            // 
            // pictureBoxLoadBackground
            // 
            this.pictureBoxLoadBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.pictureBoxLoadBackground.Location = new System.Drawing.Point(411, 382);
            this.pictureBoxLoadBackground.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBoxLoadBackground.Name = "pictureBoxLoadBackground";
            this.pictureBoxLoadBackground.Size = new System.Drawing.Size(375, 244);
            this.pictureBoxLoadBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLoadBackground.TabIndex = 4;
            this.pictureBoxLoadBackground.TabStop = false;
            this.pictureBoxLoadBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxLoadBackground_Paint);
            // 
            // pictureBoxSubtract
            // 
            this.pictureBoxSubtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.pictureBoxSubtract.Location = new System.Drawing.Point(801, 382);
            this.pictureBoxSubtract.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBoxSubtract.Name = "pictureBoxSubtract";
            this.pictureBoxSubtract.Size = new System.Drawing.Size(375, 244);
            this.pictureBoxSubtract.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSubtract.TabIndex = 5;
            this.pictureBoxSubtract.TabStop = false;
            this.pictureBoxSubtract.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxSubtract_Paint);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 292);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1186, 35);
            this.bunifuSeparator1.TabIndex = 6;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(214)))));
            this.label1.Location = new System.Drawing.Point(314, 360);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(214)))));
            this.label2.Location = new System.Drawing.Point(660, 360);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Background";
            // 
            // imageButtonLoadBackground
            // 
            this.imageButtonLoadBackground.BackColor = System.Drawing.Color.Transparent;
            this.imageButtonLoadBackground.Image = ((System.Drawing.Image)(resources.GetObject("imageButtonLoadBackground.Image")));
            this.imageButtonLoadBackground.ImageActive = null;
            this.imageButtonLoadBackground.Location = new System.Drawing.Point(760, 348);
            this.imageButtonLoadBackground.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imageButtonLoadBackground.Name = "imageButtonLoadBackground";
            this.imageButtonLoadBackground.Size = new System.Drawing.Size(26, 28);
            this.imageButtonLoadBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageButtonLoadBackground.TabIndex = 9;
            this.imageButtonLoadBackground.TabStop = false;
            this.imageButtonLoadBackground.Zoom = 10;
            this.imageButtonLoadBackground.Click += new System.EventHandler(this.imageButtonLoadBackground_Click);
            // 
            // imageButtonLoadImage
            // 
            this.imageButtonLoadImage.BackColor = System.Drawing.Color.Transparent;
            this.imageButtonLoadImage.Image = ((System.Drawing.Image)(resources.GetObject("imageButtonLoadImage.Image")));
            this.imageButtonLoadImage.ImageActive = null;
            this.imageButtonLoadImage.Location = new System.Drawing.Point(370, 348);
            this.imageButtonLoadImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imageButtonLoadImage.Name = "imageButtonLoadImage";
            this.imageButtonLoadImage.Size = new System.Drawing.Size(26, 28);
            this.imageButtonLoadImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageButtonLoadImage.TabIndex = 10;
            this.imageButtonLoadImage.TabStop = false;
            this.imageButtonLoadImage.Zoom = 10;
            this.imageButtonLoadImage.Click += new System.EventHandler(this.imageButtonLoadImage_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(214)))));
            this.label3.Location = new System.Drawing.Point(1078, 360);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Subtract";
            // 
            // imageButtonSubtract
            // 
            this.imageButtonSubtract.BackColor = System.Drawing.Color.Transparent;
            this.imageButtonSubtract.Image = ((System.Drawing.Image)(resources.GetObject("imageButtonSubtract.Image")));
            this.imageButtonSubtract.ImageActive = null;
            this.imageButtonSubtract.Location = new System.Drawing.Point(1150, 351);
            this.imageButtonSubtract.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imageButtonSubtract.Name = "imageButtonSubtract";
            this.imageButtonSubtract.Size = new System.Drawing.Size(26, 28);
            this.imageButtonSubtract.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageButtonSubtract.TabIndex = 12;
            this.imageButtonSubtract.TabStop = false;
            this.imageButtonSubtract.Zoom = 10;
            this.imageButtonSubtract.Click += new System.EventHandler(this.imageButtonSubtract_Click);
            // 
            // sliderThreshold
            // 
            this.sliderThreshold.BackColor = System.Drawing.Color.Transparent;
            this.sliderThreshold.BackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(180)))));
            this.sliderThreshold.BorderRadius = 0;
            this.sliderThreshold.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(1)))));
            this.sliderThreshold.Location = new System.Drawing.Point(801, 351);
            this.sliderThreshold.MaximumValue = 100;
            this.sliderThreshold.Name = "sliderThreshold";
            this.sliderThreshold.Size = new System.Drawing.Size(211, 30);
            this.sliderThreshold.TabIndex = 15;
            this.sliderThreshold.Value = 10;
            this.sliderThreshold.ValueChanged += new System.EventHandler(this.sliderThreshold_ValueChanged);
            // 
            // labelThreshold
            // 
            this.labelThreshold.AutoSize = true;
            this.labelThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThreshold.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(1)))));
            this.labelThreshold.Location = new System.Drawing.Point(1017, 356);
            this.labelThreshold.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelThreshold.Name = "labelThreshold";
            this.labelThreshold.Size = new System.Drawing.Size(57, 20);
            this.labelThreshold.TabIndex = 16;
            this.labelThreshold.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(214)))));
            this.label4.Location = new System.Drawing.Point(857, 330);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Threshold Value";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1186, 648);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelThreshold);
            this.Controls.Add(this.sliderThreshold);
            this.Controls.Add(this.imageButtonSubtract);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.imageButtonLoadImage);
            this.Controls.Add(this.imageButtonLoadBackground);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.pictureBoxSubtract);
            this.Controls.Add(this.pictureBoxLoadBackground);
            this.Controls.Add(this.pictureBoxLoadImage);
            this.Controls.Add(this.pictureBoxProcessed);
            this.Controls.Add(this.pictureBoxOriginal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProcessed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSubtract)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageButtonLoadBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageButtonLoadImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageButtonSubtract)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialogLoadImage;
        private System.Windows.Forms.OpenFileDialog openFileDialogLoadBackground;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basicDIPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greyscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorInversionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sepiaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxOriginal;
        private System.Windows.Forms.PictureBox pictureBoxProcessed;
        private System.Windows.Forms.PictureBox pictureBoxLoadImage;
        private System.Windows.Forms.PictureBox pictureBoxLoadBackground;
        private System.Windows.Forms.PictureBox pictureBoxSubtract;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton imageButtonLoadBackground;
        private Bunifu.Framework.UI.BunifuImageButton imageButtonLoadImage;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuImageButton imageButtonSubtract;
        private Bunifu.Framework.UI.BunifuSlider sliderThreshold;
        private System.Windows.Forms.Label labelThreshold;
        private System.Windows.Forms.Label label4;
    }
}

