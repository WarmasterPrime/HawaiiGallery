namespace HawaiiGallery.src.Extensions.Images
{
	public static class ImageResizeExt
	{
		/// <summary>
		/// Resizes the image to the specified width and height.
		/// </summary>
		/// <param name="image"></param>
		/// <param name="width"></param>
		/// <param name="height"></param>
		/// <returns></returns>
		public static Image ResizeImage(this Image image, int width, int height)
		{
			var resized = new Bitmap(width, height);
			using (var graphics = Graphics.FromImage(resized))
			{
				graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
				graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
				graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
				graphics.DrawImage(image, 0, 0, width, height);
			}
			return resized;
		}

	}
}
