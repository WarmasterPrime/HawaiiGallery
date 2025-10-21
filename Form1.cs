namespace HawaiiGallery
{
	public partial class Form1 : Form
	{
		private Dictionary<string, string> _imageInfo = new(){
			{ "Native Hawaiians", "Native Hawaiians are the indigenous Polynesian people of the Hawaiian islands who invented the Olelo Hawaii." },
			{ "Queen Liliʻuokalani", "Queen of Hawaii reigning from January 29, 1891, until the overthrow of the Hawaiian Kingdom on January 17, 1893." },
			{ "Hawaiian Village", "A Hawaiian village with natives paddling in the foreground." },
			{ "TITLE", "DESCRIPTION" },
			{ "TITLE", "DESCRIPTION" },
		};

		_

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
			if (index > 0 && index < imageList1.Images.Count)
			{

			}
		}


	}
}