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
			{ "Prince Kuhio" , "Jonah Kūhiō Kalanianaʻole was a prince of the Kingdom of Hawaiʻi until it was overthrown by a coalition of American and European businessmen in 1893. He went on to become the delegate of the Territory of Hawaii to the United States Congress, and as such is the only royal-born member of Congress." },
			{ "King Kamehameha", "King Kamehameha, also known as Kamehameha the Great, was the conqueror and first ruler of the Kingdom of Hawaii" },
			{ "Canoe", "Hawaiian Outrigger Canoeing, it's History & Revival To Date Hawaiian canoes, or wa'a, are historically significant outrigger canoes used for fishing, travel, and warfare, and are now a symbol of cultural pride used in recreational and competitive paddling. They are defined by a long, narrow hull (wa'a) and a stabilizing float (ama) connected by spars (iako). The design is functional, with modern versions built from lightweight materials, and the cultural significance continues with modern-day canoe clubs and sports like canoe surfing. " },
			{ "King Kalakaua", "King Kalākaua, was the last king and penultimate monarch of the Kingdom of Hawaiʻi, reigning from February 12, 1874, until his death in 1891. Succeeding Lunalilo, he was elected to the vacant throne of Hawaiʻi against Queen Emma." },
			{ "TITLE8", "DESCRIPTION" },
			{ "TITLE9", "DESCRIPTION" },
			{ "TITLE10", "DESCRIPTION" },
			{ "TITLE11", "DESCRIPTION" },
		};



		public Form1()
		{
			InitializeComponent();
			CenterToScreen();
			UpdateInfo(0);
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
			if (index >= 0 && index < imageList1.Images.Count)
				imageBox.Image = imageList1.Images[index]!.ResizeImage(imageBox.Width, imageBox.Height);
		}
		/// <summary>
		/// Sets the image from the list with the given name.
		/// </summary>
		/// <param name="name"></param>
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
		/// <summary>
		/// Triggers when the next button is clicked on.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void nextButton_Click(object sender, EventArgs e)
		{
			_galleryPosition++;
			if (_galleryPosition >= _imageInfo.Count)
				_galleryPosition = 0;
			UpdateInfo(_galleryPosition);
		}
		/// <summary>
		/// Updates the information to be displayed to the user.
		/// </summary>
		/// <param name="index"></param>
		private void UpdateInfo(int index)
		{
			var sel = _imageInfo.ElementAt(index);
			titleLabel.Text = sel.Key + " - " + index.ToString();
			descriptionLabel.Text = sel.Value;
			titleLabel.CenterH();
			descriptionLabel.CenterH();
			SetImageByIndex(index);
		}
		/// <summary>
		/// Publicly accessible.
		/// </summary>
		public new void CenterToScreen() => base.CenterToScreen();

	}
}