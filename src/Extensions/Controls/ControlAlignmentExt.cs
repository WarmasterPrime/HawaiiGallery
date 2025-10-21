namespace HawaiiGallery.src.Extensions.Controls
{
	public static class ControlAlignmentExt
	{
		/// <summary>
		/// Centers the control or window horizontally center.
		/// </summary>
		/// <param name="control"></param>
		public static void CenterH(this Control control)
		{
			if (control is Form)
				((Form1)control).CenterToScreen();
			else
			{
				Control parent = control.Parent;
				control.Location = new Point((parent.Width / 2) - (control.Width/2), control.Location.Y);
			}
		}

	}
}
