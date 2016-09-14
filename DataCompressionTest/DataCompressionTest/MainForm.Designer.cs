namespace DataCompressionTest
{
    partial class MainForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ofDialog = new System.Windows.Forms.OpenFileDialog();
            this.pbCurrentImage = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.lblCurrentPNG = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPNG = new System.Windows.Forms.Label();
            this.lblBMP = new System.Windows.Forms.Label();
            this.lblGIF = new System.Windows.Forms.Label();
            this.lblCurrentBMP = new System.Windows.Forms.Label();
            this.lblCurrentGIF = new System.Windows.Forms.Label();
            this.lblCurrentJPG = new System.Windows.Forms.Label();
            this.lblJPG = new System.Windows.Forms.Label();
            this.lblCompressedJPG = new System.Windows.Forms.Label();
            this.lblJPG1 = new System.Windows.Forms.Label();
            this.lblCompressedGIF = new System.Windows.Forms.Label();
            this.lblCompressedBMP = new System.Windows.Forms.Label();
            this.lblGIF1 = new System.Windows.Forms.Label();
            this.lblBMP1 = new System.Windows.Forms.Label();
            this.lblPNG1 = new System.Windows.Forms.Label();
            this.lblCompressedPNG = new System.Windows.Forms.Label();
            this.lblQuickLZJPG = new System.Windows.Forms.Label();
            this.lblJPG2 = new System.Windows.Forms.Label();
            this.lblQuickLZGIF = new System.Windows.Forms.Label();
            this.lblQuickLZBMP = new System.Windows.Forms.Label();
            this.lblGIF2 = new System.Windows.Forms.Label();
            this.lblBMP2 = new System.Windows.Forms.Label();
            this.lblPNG2 = new System.Windows.Forms.Label();
            this.lblQuickLZPNG = new System.Windows.Forms.Label();
            this.lblFile = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblCurrentImage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 65);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(160, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current Byte[] Size: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 218);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(200, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Compressed Byte[] Size: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ofDialog
            // 
            this.ofDialog.Filter = "Image Files (*.bmp, *.png, *.jpg)|*.bmp;*.jpg;*.png";
            // 
            // pbCurrentImage
            // 
            this.pbCurrentImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCurrentImage.Location = new System.Drawing.Point(475, 98);
            this.pbCurrentImage.Name = "pbCurrentImage";
            this.pbCurrentImage.Size = new System.Drawing.Size(275, 275);
            this.pbCurrentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCurrentImage.TabIndex = 3;
            this.pbCurrentImage.TabStop = false;
            this.pbCurrentImage.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(235, 562);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(130, 50);
            this.btnUpload.TabIndex = 4;
            this.btnUpload.Text = "Upload an Image";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // lblCurrentPNG
            // 
            this.lblCurrentPNG.AutoSize = true;
            this.lblCurrentPNG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPNG.Location = new System.Drawing.Point(374, 98);
            this.lblCurrentPNG.Name = "lblCurrentPNG";
            this.lblCurrentPNG.Size = new System.Drawing.Size(27, 16);
            this.lblCurrentPNG.TabIndex = 6;
            this.lblCurrentPNG.Tag = "clear";
            this.lblCurrentPNG.Text = "n/a";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(371, 562);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 50);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 377);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(225, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "QuickLZ Compression Size: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPNG
            // 
            this.lblPNG.AutoSize = true;
            this.lblPNG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPNG.Location = new System.Drawing.Point(187, 98);
            this.lblPNG.Name = "lblPNG";
            this.lblPNG.Size = new System.Drawing.Size(107, 16);
            this.lblPNG.TabIndex = 11;
            this.lblPNG.Text = "Saved as PNG...";
            this.lblPNG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBMP
            // 
            this.lblBMP.AutoSize = true;
            this.lblBMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBMP.Location = new System.Drawing.Point(187, 125);
            this.lblBMP.Name = "lblBMP";
            this.lblBMP.Size = new System.Drawing.Size(107, 16);
            this.lblBMP.TabIndex = 12;
            this.lblBMP.Text = "Saved as BMP...";
            this.lblBMP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGIF
            // 
            this.lblGIF.AutoSize = true;
            this.lblGIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGIF.Location = new System.Drawing.Point(187, 155);
            this.lblGIF.Name = "lblGIF";
            this.lblGIF.Size = new System.Drawing.Size(99, 16);
            this.lblGIF.TabIndex = 13;
            this.lblGIF.Text = "Saved as GIF...";
            this.lblGIF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCurrentBMP
            // 
            this.lblCurrentBMP.AutoSize = true;
            this.lblCurrentBMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBMP.Location = new System.Drawing.Point(374, 125);
            this.lblCurrentBMP.Name = "lblCurrentBMP";
            this.lblCurrentBMP.Size = new System.Drawing.Size(27, 16);
            this.lblCurrentBMP.TabIndex = 14;
            this.lblCurrentBMP.Tag = "clear";
            this.lblCurrentBMP.Text = "n/a";
            // 
            // lblCurrentGIF
            // 
            this.lblCurrentGIF.AutoSize = true;
            this.lblCurrentGIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentGIF.Location = new System.Drawing.Point(374, 155);
            this.lblCurrentGIF.Name = "lblCurrentGIF";
            this.lblCurrentGIF.Size = new System.Drawing.Size(27, 16);
            this.lblCurrentGIF.TabIndex = 15;
            this.lblCurrentGIF.Tag = "clear";
            this.lblCurrentGIF.Text = "n/a";
            // 
            // lblCurrentJPG
            // 
            this.lblCurrentJPG.AutoSize = true;
            this.lblCurrentJPG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentJPG.Location = new System.Drawing.Point(374, 182);
            this.lblCurrentJPG.Name = "lblCurrentJPG";
            this.lblCurrentJPG.Size = new System.Drawing.Size(27, 16);
            this.lblCurrentJPG.TabIndex = 17;
            this.lblCurrentJPG.Tag = "clear";
            this.lblCurrentJPG.Text = "n/a";
            // 
            // lblJPG
            // 
            this.lblJPG.AutoSize = true;
            this.lblJPG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJPG.Location = new System.Drawing.Point(187, 182);
            this.lblJPG.Name = "lblJPG";
            this.lblJPG.Size = new System.Drawing.Size(104, 16);
            this.lblJPG.TabIndex = 16;
            this.lblJPG.Text = "Saved as JPG...";
            this.lblJPG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCompressedJPG
            // 
            this.lblCompressedJPG.AutoSize = true;
            this.lblCompressedJPG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompressedJPG.Location = new System.Drawing.Point(374, 340);
            this.lblCompressedJPG.Name = "lblCompressedJPG";
            this.lblCompressedJPG.Size = new System.Drawing.Size(27, 16);
            this.lblCompressedJPG.TabIndex = 25;
            this.lblCompressedJPG.Tag = "clear";
            this.lblCompressedJPG.Text = "n/a";
            // 
            // lblJPG1
            // 
            this.lblJPG1.AutoSize = true;
            this.lblJPG1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJPG1.Location = new System.Drawing.Point(187, 340);
            this.lblJPG1.Name = "lblJPG1";
            this.lblJPG1.Size = new System.Drawing.Size(104, 16);
            this.lblJPG1.TabIndex = 24;
            this.lblJPG1.Text = "Saved as JPG...";
            this.lblJPG1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCompressedGIF
            // 
            this.lblCompressedGIF.AutoSize = true;
            this.lblCompressedGIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompressedGIF.Location = new System.Drawing.Point(374, 313);
            this.lblCompressedGIF.Name = "lblCompressedGIF";
            this.lblCompressedGIF.Size = new System.Drawing.Size(27, 16);
            this.lblCompressedGIF.TabIndex = 23;
            this.lblCompressedGIF.Tag = "clear";
            this.lblCompressedGIF.Text = "n/a";
            // 
            // lblCompressedBMP
            // 
            this.lblCompressedBMP.AutoSize = true;
            this.lblCompressedBMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompressedBMP.Location = new System.Drawing.Point(374, 283);
            this.lblCompressedBMP.Name = "lblCompressedBMP";
            this.lblCompressedBMP.Size = new System.Drawing.Size(27, 16);
            this.lblCompressedBMP.TabIndex = 22;
            this.lblCompressedBMP.Tag = "clear";
            this.lblCompressedBMP.Text = "n/a";
            // 
            // lblGIF1
            // 
            this.lblGIF1.AutoSize = true;
            this.lblGIF1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGIF1.Location = new System.Drawing.Point(187, 313);
            this.lblGIF1.Name = "lblGIF1";
            this.lblGIF1.Size = new System.Drawing.Size(99, 16);
            this.lblGIF1.TabIndex = 21;
            this.lblGIF1.Text = "Saved as GIF...";
            this.lblGIF1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBMP1
            // 
            this.lblBMP1.AutoSize = true;
            this.lblBMP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBMP1.Location = new System.Drawing.Point(187, 283);
            this.lblBMP1.Name = "lblBMP1";
            this.lblBMP1.Size = new System.Drawing.Size(107, 16);
            this.lblBMP1.TabIndex = 20;
            this.lblBMP1.Text = "Saved as BMP...";
            this.lblBMP1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPNG1
            // 
            this.lblPNG1.AutoSize = true;
            this.lblPNG1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPNG1.Location = new System.Drawing.Point(187, 256);
            this.lblPNG1.Name = "lblPNG1";
            this.lblPNG1.Size = new System.Drawing.Size(107, 16);
            this.lblPNG1.TabIndex = 19;
            this.lblPNG1.Text = "Saved as PNG...";
            this.lblPNG1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCompressedPNG
            // 
            this.lblCompressedPNG.AutoSize = true;
            this.lblCompressedPNG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompressedPNG.Location = new System.Drawing.Point(374, 256);
            this.lblCompressedPNG.Name = "lblCompressedPNG";
            this.lblCompressedPNG.Size = new System.Drawing.Size(27, 16);
            this.lblCompressedPNG.TabIndex = 18;
            this.lblCompressedPNG.Tag = "clear";
            this.lblCompressedPNG.Text = "n/a";
            // 
            // lblQuickLZJPG
            // 
            this.lblQuickLZJPG.AutoSize = true;
            this.lblQuickLZJPG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuickLZJPG.Location = new System.Drawing.Point(374, 492);
            this.lblQuickLZJPG.Name = "lblQuickLZJPG";
            this.lblQuickLZJPG.Size = new System.Drawing.Size(27, 16);
            this.lblQuickLZJPG.TabIndex = 33;
            this.lblQuickLZJPG.Tag = "clear";
            this.lblQuickLZJPG.Text = "n/a";
            // 
            // lblJPG2
            // 
            this.lblJPG2.AutoSize = true;
            this.lblJPG2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJPG2.Location = new System.Drawing.Point(187, 492);
            this.lblJPG2.Name = "lblJPG2";
            this.lblJPG2.Size = new System.Drawing.Size(104, 16);
            this.lblJPG2.TabIndex = 32;
            this.lblJPG2.Text = "Saved as JPG...";
            this.lblJPG2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblQuickLZGIF
            // 
            this.lblQuickLZGIF.AutoSize = true;
            this.lblQuickLZGIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuickLZGIF.Location = new System.Drawing.Point(374, 465);
            this.lblQuickLZGIF.Name = "lblQuickLZGIF";
            this.lblQuickLZGIF.Size = new System.Drawing.Size(27, 16);
            this.lblQuickLZGIF.TabIndex = 31;
            this.lblQuickLZGIF.Tag = "clear";
            this.lblQuickLZGIF.Text = "n/a";
            // 
            // lblQuickLZBMP
            // 
            this.lblQuickLZBMP.AutoSize = true;
            this.lblQuickLZBMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuickLZBMP.Location = new System.Drawing.Point(374, 435);
            this.lblQuickLZBMP.Name = "lblQuickLZBMP";
            this.lblQuickLZBMP.Size = new System.Drawing.Size(27, 16);
            this.lblQuickLZBMP.TabIndex = 30;
            this.lblQuickLZBMP.Tag = "clear";
            this.lblQuickLZBMP.Text = "n/a";
            // 
            // lblGIF2
            // 
            this.lblGIF2.AutoSize = true;
            this.lblGIF2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGIF2.Location = new System.Drawing.Point(187, 465);
            this.lblGIF2.Name = "lblGIF2";
            this.lblGIF2.Size = new System.Drawing.Size(99, 16);
            this.lblGIF2.TabIndex = 29;
            this.lblGIF2.Text = "Saved as GIF...";
            this.lblGIF2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBMP2
            // 
            this.lblBMP2.AutoSize = true;
            this.lblBMP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBMP2.Location = new System.Drawing.Point(187, 435);
            this.lblBMP2.Name = "lblBMP2";
            this.lblBMP2.Size = new System.Drawing.Size(107, 16);
            this.lblBMP2.TabIndex = 28;
            this.lblBMP2.Text = "Saved as BMP...";
            this.lblBMP2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPNG2
            // 
            this.lblPNG2.AutoSize = true;
            this.lblPNG2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPNG2.Location = new System.Drawing.Point(187, 408);
            this.lblPNG2.Name = "lblPNG2";
            this.lblPNG2.Size = new System.Drawing.Size(107, 16);
            this.lblPNG2.TabIndex = 27;
            this.lblPNG2.Text = "Saved as PNG...";
            this.lblPNG2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblQuickLZPNG
            // 
            this.lblQuickLZPNG.AutoSize = true;
            this.lblQuickLZPNG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuickLZPNG.Location = new System.Drawing.Point(374, 408);
            this.lblQuickLZPNG.Name = "lblQuickLZPNG";
            this.lblQuickLZPNG.Size = new System.Drawing.Size(27, 16);
            this.lblQuickLZPNG.TabIndex = 26;
            this.lblQuickLZPNG.Tag = "clear";
            this.lblQuickLZPNG.Text = "n/a";
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFile.Location = new System.Drawing.Point(391, 11);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(27, 16);
            this.lblFile.TabIndex = 39;
            this.lblFile.Tag = "clear";
            this.lblFile.Text = "n/a";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.Location = new System.Drawing.Point(296, 9);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFileName.Size = new System.Drawing.Size(89, 18);
            this.lblFileName.TabIndex = 38;
            this.lblFileName.Text = "File Name:";
            this.lblFileName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCurrentImage
            // 
            this.lblCurrentImage.AutoSize = true;
            this.lblCurrentImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentImage.Location = new System.Drawing.Point(689, 67);
            this.lblCurrentImage.Name = "lblCurrentImage";
            this.lblCurrentImage.Size = new System.Drawing.Size(27, 16);
            this.lblCurrentImage.TabIndex = 37;
            this.lblCurrentImage.Tag = "clear";
            this.lblCurrentImage.Text = "n/a";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(493, 65);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(162, 18);
            this.label1.TabIndex = 36;
            this.label1.Text = "Current Image Size: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 638);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.lblCurrentImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblQuickLZJPG);
            this.Controls.Add(this.lblJPG2);
            this.Controls.Add(this.lblQuickLZGIF);
            this.Controls.Add(this.lblQuickLZBMP);
            this.Controls.Add(this.lblGIF2);
            this.Controls.Add(this.lblBMP2);
            this.Controls.Add(this.lblPNG2);
            this.Controls.Add(this.lblQuickLZPNG);
            this.Controls.Add(this.lblCompressedJPG);
            this.Controls.Add(this.lblJPG1);
            this.Controls.Add(this.lblCompressedGIF);
            this.Controls.Add(this.lblCompressedBMP);
            this.Controls.Add(this.lblGIF1);
            this.Controls.Add(this.lblBMP1);
            this.Controls.Add(this.lblPNG1);
            this.Controls.Add(this.lblCompressedPNG);
            this.Controls.Add(this.lblCurrentJPG);
            this.Controls.Add(this.lblJPG);
            this.Controls.Add(this.lblCurrentGIF);
            this.Controls.Add(this.lblCurrentBMP);
            this.Controls.Add(this.lblGIF);
            this.Controls.Add(this.lblBMP);
            this.Controls.Add(this.lblPNG);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblCurrentPNG);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.pbCurrentImage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Data Compression Test";
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog ofDialog;
        private System.Windows.Forms.PictureBox pbCurrentImage;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label lblCurrentPNG;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPNG;
        private System.Windows.Forms.Label lblBMP;
        private System.Windows.Forms.Label lblGIF;
        private System.Windows.Forms.Label lblCurrentBMP;
        private System.Windows.Forms.Label lblCurrentGIF;
        private System.Windows.Forms.Label lblCurrentJPG;
        private System.Windows.Forms.Label lblJPG;
        private System.Windows.Forms.Label lblCompressedJPG;
        private System.Windows.Forms.Label lblJPG1;
        private System.Windows.Forms.Label lblCompressedGIF;
        private System.Windows.Forms.Label lblCompressedBMP;
        private System.Windows.Forms.Label lblGIF1;
        private System.Windows.Forms.Label lblBMP1;
        private System.Windows.Forms.Label lblPNG1;
        private System.Windows.Forms.Label lblCompressedPNG;
        private System.Windows.Forms.Label lblQuickLZJPG;
        private System.Windows.Forms.Label lblJPG2;
        private System.Windows.Forms.Label lblQuickLZGIF;
        private System.Windows.Forms.Label lblQuickLZBMP;
        private System.Windows.Forms.Label lblGIF2;
        private System.Windows.Forms.Label lblBMP2;
        private System.Windows.Forms.Label lblPNG2;
        private System.Windows.Forms.Label lblQuickLZPNG;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblCurrentImage;
        private System.Windows.Forms.Label label1;
    }
}

