namespace HawaiiGallery
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void setImage(string imagePath)
		{
			try
			{
				imageBox.Image = Image.FromFile(imagePath);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading image: " + ex.Message);
			}
		}

	}
}
