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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ofDialog = new System.Windows.Forms.OpenFileDialog();
            this.pbCurrentImage = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.lblCurrentImage = new System.Windows.Forms.Label();
            this.lblCurrentByte = new System.Windows.Forms.Label();
            this.lblCompressedByte = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblQuickLZ = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(162, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Image Size: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 42);
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
            this.label3.Location = new System.Drawing.Point(26, 73);
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
            this.pbCurrentImage.Location = new System.Drawing.Point(461, 12);
            this.pbCurrentImage.Name = "pbCurrentImage";
            this.pbCurrentImage.Size = new System.Drawing.Size(150, 150);
            this.pbCurrentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCurrentImage.TabIndex = 3;
            this.pbCurrentImage.TabStop = false;
            this.pbCurrentImage.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(211, 158);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(110, 31);
            this.btnUpload.TabIndex = 4;
            this.btnUpload.Text = "Upload an Image";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // lblCurrentImage
            // 
            this.lblCurrentImage.AutoSize = true;
            this.lblCurrentImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentImage.Location = new System.Drawing.Point(251, 11);
            this.lblCurrentImage.Name = "lblCurrentImage";
            this.lblCurrentImage.Size = new System.Drawing.Size(27, 16);
            this.lblCurrentImage.TabIndex = 5;
            this.lblCurrentImage.Text = "n/a";
            // 
            // lblCurrentByte
            // 
            this.lblCurrentByte.AutoSize = true;
            this.lblCurrentByte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentByte.Location = new System.Drawing.Point(251, 44);
            this.lblCurrentByte.Name = "lblCurrentByte";
            this.lblCurrentByte.Size = new System.Drawing.Size(27, 16);
            this.lblCurrentByte.TabIndex = 6;
            this.lblCurrentByte.Text = "n/a";
            // 
            // lblCompressedByte
            // 
            this.lblCompressedByte.AutoSize = true;
            this.lblCompressedByte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompressedByte.Location = new System.Drawing.Point(251, 75);
            this.lblCompressedByte.Name = "lblCompressedByte";
            this.lblCompressedByte.Size = new System.Drawing.Size(27, 16);
            this.lblCompressedByte.TabIndex = 7;
            this.lblCompressedByte.Text = "n/a";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(327, 158);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 31);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblQuickLZ
            // 
            this.lblQuickLZ.AutoSize = true;
            this.lblQuickLZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuickLZ.Location = new System.Drawing.Point(251, 108);
            this.lblQuickLZ.Name = "lblQuickLZ";
            this.lblQuickLZ.Size = new System.Drawing.Size(27, 16);
            this.lblQuickLZ.TabIndex = 10;
            this.lblQuickLZ.Text = "n/a";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 106);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(225, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "QuickLZ Compression Size: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 215);
            this.Controls.Add(this.lblQuickLZ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblCompressedByte);
            this.Controls.Add(this.lblCurrentByte);
            this.Controls.Add(this.lblCurrentImage);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.pbCurrentImage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Data Compression Test";
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog ofDialog;
        private System.Windows.Forms.PictureBox pbCurrentImage;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label lblCurrentImage;
        private System.Windows.Forms.Label lblCurrentByte;
        private System.Windows.Forms.Label lblCompressedByte;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblQuickLZ;
        private System.Windows.Forms.Label label4;
    }
}

