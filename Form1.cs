using HawaiiGallery.src.Extensions.Controls;
using HawaiiGallery.src.Extensions.Images;

namespace HawaiiGallery
{
	public partial class Form1 : Form
	{

		private int _galleryPosition = 0;

		private Dictionary<string, string> _imageInfo = new(){
			{ "Native Hawaiians", "Native Hawaiians are the indigenous Polynesian people of the Hawaiian islands who invented the Olelo Hawaii." },
			{ "Queen Liliʻuokalani", "Queen of Hawaii reigning from January 29, 1891, until the overthrow of the Hawaiian Kingdom on January 17, 1893." },
			{ "Ahupua'a", "An ahupuaʻa is a traditional Hawaiian land division system that runs from the mountain to the sea, translating to a pie slice." },
			{ "King Kamehameha", "DESCRIPTION" },
			{ "TITLE", "DESCRIPTION" },
		};



		public Form1()
		{
			InitializeComponent();
			CenterToScreen();
			SetImageByName("elementor-placeholder-image.png");
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			imageBox.CenterH();
		}

		private void SetImage(string imagePath)
		{
			if (File.Exists(imagePath) && Path.HasExtension(imagePath))
			{
				try
				{
					imageBox.Image = Image.FromFile(imagePath).ResizeImage(imageBox.Width, imageBox.Height);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error loading image: " + ex.Message);
				}
			}
		}

		private void SetImageByIndex(int index)
		{
			if (index > 0 && index < imageList1.Images.Count)
				imageBox.Image = imageList1.Images[index]!.ResizeImage(imageBox.Width, imageBox.Height);
		}

		private void SetImageByName(string name)
		{
			if (imageList1.Images.ContainsKey(name))
				imageBox.Image = imageList1.Images[name]!.ResizeImage(imageBox.Width, imageBox.Height);
			else
				MessageBox.Show("Error: Image key is invalid!");
		}
		/// <summary>
		/// Triggers when the previous button is clicked on.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void previousButton_Click(object sender, EventArgs e)
		{
			_galleryPosition--;
			if (_galleryPosition < 0)
				_galleryPosition = _imageInfo.Count - 1;
			UpdateInfo(_galleryPosition);
		}

		private void nextButton_Click(object sender, EventArgs e)
		{
			_galleryPosition++;
			if (_galleryPosition >= _imageInfo.Count)
				_galleryPosition = 0;
			UpdateInfo(_galleryPosition);
		}

		private void UpdateInfo(int index)
		{
			var sel = _imageInfo.ElementAt(index);
			titleLabel.Text = sel.Key;
			descriptionLabel.Text = sel.Value;
			titleLabel.CenterH();
			descriptionLabel.CenterH();
			SetImageByIndex(index);
		}

		public new void CenterToScreen()
		{
			base.CenterToScreen();
		}

	}
}