namespace HawaiiGallery
{
	public partial class Form1 : Form
	{
		private Dictionary<string, string> _imageInfo = new(){
			{ "Native Hawaiians", "They are surfing in the ocean with an island in the background." },
			{ "Queen Liliʻuokalani", "Queen of Hawaii, she was overthrown illegally." },
			{ "Hawaiian Village", "A Hawaiian village with natives paddling in the foreground." },
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
			if (index > 0 && index < imageList1.Images.Count)
			{

			}
		}


	}
}