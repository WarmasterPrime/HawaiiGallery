namespace HawaiiGallery
{
	public partial class Form1 : Form
	{
		private Dictionary<string, string> _imageInfo = new(){
			{ "TITLE", "DESCRIPTION" },
			{ "TITLE", "DESCRIPTION" },
			{ "TITLE", "DESCRIPTION" },
			{ "TITLE", "DESCRIPTION" },
			{ "TITLE", "DESCRIPTION" },
		};



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

		private void setImageByIndex(int index)
		{
			if (index > 0 && index < imageList1.Count)
			{

			}


	}
}