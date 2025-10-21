namespace HawaiiGallery
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			panel1 = new Panel();
			descriptionLabel = new Label();
			imageBox = new PictureBox();
			titleLabel = new Label();
			nextButton = new Button();
			previousButton = new Button();
			imageList1 = new ImageList(components);
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)imageBox).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(descriptionLabel);
			panel1.Controls.Add(imageBox);
			panel1.Controls.Add(titleLabel);
			panel1.Controls.Add(nextButton);
			panel1.Controls.Add(previousButton);
			panel1.Location = new Point(12, 12);
			panel1.Name = "panel1";
			panel1.Size = new Size(776, 426);
			panel1.TabIndex = 1;
			// 
			// descriptionLabel
			// 
			descriptionLabel.AutoSize = true;
			descriptionLabel.Location = new Point(337, 373);
			descriptionLabel.Name = "descriptionLabel";
			descriptionLabel.Size = new Size(94, 15);
			descriptionLabel.TabIndex = 4;
			descriptionLabel.Text = "descriptionLabel";
			// 
			// imageBox
			// 
			imageBox.Location = new Point(84, 46);
			imageBox.Name = "imageBox";
			imageBox.Size = new Size(608, 301);
			imageBox.TabIndex = 3;
			imageBox.TabStop = false;
			// 
			// titleLabel
			// 
			titleLabel.AutoSize = true;
			titleLabel.Location = new Point(356, 28);
			titleLabel.Name = "titleLabel";
			titleLabel.Size = new Size(55, 15);
			titleLabel.TabIndex = 2;
			titleLabel.Text = "titleLabel";
			// 
			// nextButton
			// 
			nextButton.Location = new Point(698, 204);
			nextButton.Name = "nextButton";
			nextButton.Size = new Size(75, 23);
			nextButton.TabIndex = 1;
			nextButton.Text = "Next";
			nextButton.UseVisualStyleBackColor = true;
			nextButton.Click += nextButton_Click;
			// 
			// previousButton
			// 
			previousButton.Location = new Point(3, 204);
			previousButton.Name = "previousButton";
			previousButton.Size = new Size(75, 23);
			previousButton.TabIndex = 0;
			previousButton.Text = "Previous";
			previousButton.UseVisualStyleBackColor = true;
			previousButton.Click += previousButton_Click;
			// 
			// imageList1
			// 
			imageList1.ColorDepth = ColorDepth.Depth32Bit;
			imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
			imageList1.TransparentColor = Color.Transparent;
			imageList1.Images.SetKeyName(0, "11243605054_0b4b7ec91c_k.jpg");
			imageList1.Images.SetKeyName(1, "Annexation_of_Hawaii_1898-1210x423-1.jpg");
			imageList1.Images.SetKeyName(2, "download (1).jpeg");
			imageList1.Images.SetKeyName(3, "download.jpeg");
			imageList1.Images.SetKeyName(4, "images (1).jpeg");
			imageList1.Images.SetKeyName(5, "images (2).jpeg");
			imageList1.Images.SetKeyName(6, "images (3).jpeg");
			imageList1.Images.SetKeyName(7, "images (4).jpeg");
			imageList1.Images.SetKeyName(8, "images (5).jpeg");
			imageList1.Images.SetKeyName(9, "images.jpeg");
			imageList1.Images.SetKeyName(10, "elementor-placeholder-image.png");
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(panel1);
			Name = "Form1";
			Text = "Hawaii Gallery";
			Load += Form1_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)imageBox).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Label descriptionLabel;
		private PictureBox imageBox;
		private Label titleLabel;
		private Button nextButton;
		private Button previousButton;
		private ImageList imageList1;
	}
}
