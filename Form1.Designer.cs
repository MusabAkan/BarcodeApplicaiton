namespace BarcodeApplicaiton
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
            btnGenerateBarcode = new Button();
            btnReadBarcode = new Button();
            txtBarcodeData = new RichTextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnGenerateBarcode
            // 
            btnGenerateBarcode.Location = new Point(85, 50);
            btnGenerateBarcode.Margin = new Padding(2);
            btnGenerateBarcode.Name = "btnGenerateBarcode";
            btnGenerateBarcode.Size = new Size(120, 53);
            btnGenerateBarcode.TabIndex = 0;
            btnGenerateBarcode.Text = "Generate Barcode";
            btnGenerateBarcode.UseVisualStyleBackColor = true;
            btnGenerateBarcode.Click += btnGenerateBarcode_Click_1;
            // 
            // btnReadBarcode
            // 
            btnReadBarcode.Location = new Point(291, 50);
            btnReadBarcode.Margin = new Padding(2);
            btnReadBarcode.Name = "btnReadBarcode";
            btnReadBarcode.Size = new Size(120, 53);
            btnReadBarcode.TabIndex = 0;
            btnReadBarcode.Text = "Read Barcode";
            btnReadBarcode.UseVisualStyleBackColor = true;
            btnReadBarcode.Click += btnReadBarcode_Click;
            // 
            // txtBarcodeData
            // 
            txtBarcodeData.Location = new Point(85, 120);
            txtBarcodeData.Margin = new Padding(2);
            txtBarcodeData.Name = "txtBarcodeData";
            txtBarcodeData.Size = new Size(327, 95);
            txtBarcodeData.TabIndex = 1;
            txtBarcodeData.Text = "BarcodeData";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(488, 50);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(285, 164);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 270);
            Controls.Add(pictureBox1);
            Controls.Add(txtBarcodeData);
            Controls.Add(btnReadBarcode);
            Controls.Add(btnGenerateBarcode);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGenerateBarcode;
        private Button btnReadBarcode;
        private RichTextBox txtBarcodeData;
        private PictureBox pictureBox1;
    }
}