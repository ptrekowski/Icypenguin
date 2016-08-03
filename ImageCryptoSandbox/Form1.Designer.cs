namespace ImageCryptoSandbox
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
            this.btnShowPicture = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txtBoxOriginal = new System.Windows.Forms.TextBox();
            this.txtBoxEncrypted = new System.Windows.Forms.TextBox();
            this.btnSaveEncrypted = new System.Windows.Forms.Button();
            this.btnShowEncryptedImage = new System.Windows.Forms.Button();
            this.picBoxShowEncrypted = new System.Windows.Forms.PictureBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.openImageFile = new System.Windows.Forms.OpenFileDialog();
            this.btnClearnEncryption = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBoxDecrypted = new System.Windows.Forms.TextBox();
            this.btnTestLoss = new System.Windows.Forms.Button();
            this.txtBoxTestIterations = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShowEncrypted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowPicture
            // 
            this.btnShowPicture.Location = new System.Drawing.Point(12, 60);
            this.btnShowPicture.Name = "btnShowPicture";
            this.btnShowPicture.Size = new System.Drawing.Size(115, 31);
            this.btnShowPicture.TabIndex = 1;
            this.btnShowPicture.Text = "Show Picture";
            this.btnShowPicture.UseVisualStyleBackColor = true;
            this.btnShowPicture.Click += new System.EventHandler(this.btnShowPicture_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(298, 68);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 4;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(298, 226);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 5;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // txtBoxOriginal
            // 
            this.txtBoxOriginal.Location = new System.Drawing.Point(454, 11);
            this.txtBoxOriginal.Multiline = true;
            this.txtBoxOriginal.Name = "txtBoxOriginal";
            this.txtBoxOriginal.Size = new System.Drawing.Size(264, 167);
            this.txtBoxOriginal.TabIndex = 6;
            // 
            // txtBoxEncrypted
            // 
            this.txtBoxEncrypted.Location = new System.Drawing.Point(454, 184);
            this.txtBoxEncrypted.Multiline = true;
            this.txtBoxEncrypted.Name = "txtBoxEncrypted";
            this.txtBoxEncrypted.Size = new System.Drawing.Size(264, 167);
            this.txtBoxEncrypted.TabIndex = 7;
            // 
            // btnSaveEncrypted
            // 
            this.btnSaveEncrypted.Location = new System.Drawing.Point(12, 22);
            this.btnSaveEncrypted.Name = "btnSaveEncrypted";
            this.btnSaveEncrypted.Size = new System.Drawing.Size(75, 23);
            this.btnSaveEncrypted.TabIndex = 9;
            this.btnSaveEncrypted.Text = "Save Encrypted";
            this.btnSaveEncrypted.UseVisualStyleBackColor = true;
            this.btnSaveEncrypted.Click += new System.EventHandler(this.btnSaveEncrypted_Click);
            // 
            // btnShowEncryptedImage
            // 
            this.btnShowEncryptedImage.Location = new System.Drawing.Point(24, 388);
            this.btnShowEncryptedImage.Name = "btnShowEncryptedImage";
            this.btnShowEncryptedImage.Size = new System.Drawing.Size(75, 23);
            this.btnShowEncryptedImage.TabIndex = 12;
            this.btnShowEncryptedImage.Text = "btnShowEncrypted";
            this.btnShowEncryptedImage.Click += new System.EventHandler(this.btnShowEncryptedImage_Click);
            // 
            // picBoxShowEncrypted
            // 
            this.picBoxShowEncrypted.Location = new System.Drawing.Point(24, 438);
            this.picBoxShowEncrypted.Name = "picBoxShowEncrypted";
            this.picBoxShowEncrypted.Size = new System.Drawing.Size(314, 302);
            this.picBoxShowEncrypted.TabIndex = 11;
            this.picBoxShowEncrypted.TabStop = false;
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.Location = new System.Drawing.Point(145, 22);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(75, 23);
            this.btnOpenImage.TabIndex = 13;
            this.btnOpenImage.Text = "Open Image";
            this.btnOpenImage.UseVisualStyleBackColor = true;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // btnClearnEncryption
            // 
            this.btnClearnEncryption.Location = new System.Drawing.Point(274, 375);
            this.btnClearnEncryption.Name = "btnClearnEncryption";
            this.btnClearnEncryption.Size = new System.Drawing.Size(99, 23);
            this.btnClearnEncryption.TabIndex = 14;
            this.btnClearnEncryption.Text = "Clear Encryption";
            this.btnClearnEncryption.UseVisualStyleBackColor = true;
            this.btnClearnEncryption.Click += new System.EventHandler(this.btnClearnEncryption_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(39, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // txtBoxDecrypted
            // 
            this.txtBoxDecrypted.Location = new System.Drawing.Point(454, 357);
            this.txtBoxDecrypted.Multiline = true;
            this.txtBoxDecrypted.Name = "txtBoxDecrypted";
            this.txtBoxDecrypted.Size = new System.Drawing.Size(264, 167);
            this.txtBoxDecrypted.TabIndex = 16;
            // 
            // btnTestLoss
            // 
            this.btnTestLoss.Location = new System.Drawing.Point(759, 21);
            this.btnTestLoss.Name = "btnTestLoss";
            this.btnTestLoss.Size = new System.Drawing.Size(75, 23);
            this.btnTestLoss.TabIndex = 17;
            this.btnTestLoss.Text = "Test Loss";
            this.btnTestLoss.UseVisualStyleBackColor = true;
            this.btnTestLoss.Click += new System.EventHandler(this.btnTestLoss_Click);
            // 
            // txtBoxTestIterations
            // 
            this.txtBoxTestIterations.Location = new System.Drawing.Point(855, 21);
            this.txtBoxTestIterations.Name = "txtBoxTestIterations";
            this.txtBoxTestIterations.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTestIterations.TabIndex = 18;
            this.txtBoxTestIterations.Text = "100";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 811);
            this.Controls.Add(this.txtBoxTestIterations);
            this.Controls.Add(this.btnTestLoss);
            this.Controls.Add(this.txtBoxDecrypted);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClearnEncryption);
            this.Controls.Add(this.btnOpenImage);
            this.Controls.Add(this.picBoxShowEncrypted);
            this.Controls.Add(this.btnShowEncryptedImage);
            this.Controls.Add(this.btnSaveEncrypted);
            this.Controls.Add(this.txtBoxEncrypted);
            this.Controls.Add(this.txtBoxOriginal);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnShowPicture);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShowEncrypted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowPicture;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox txtBoxOriginal;
        private System.Windows.Forms.TextBox txtBoxEncrypted;
        private System.Windows.Forms.Button btnSaveEncrypted;
        private System.Windows.Forms.Button btnShowEncryptedImage;
        private System.Windows.Forms.PictureBox picBoxShowEncrypted;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btnOpenImage;
        private System.Windows.Forms.OpenFileDialog openImageFile;
        private System.Windows.Forms.Button btnClearnEncryption;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBoxDecrypted;
        private System.Windows.Forms.Button btnTestLoss;
        private System.Windows.Forms.TextBox txtBoxTestIterations;
    }
}

