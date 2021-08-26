﻿using System.Windows;
using System.Windows.Controls;

namespace Lol.Clash.UI.Units
{
	public class Title : Control
	{
		#region DefaultStyleKey

		static Title()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(Title), new FrameworkPropertyMetadata(typeof(Title)));
		}
		#endregion
	}
}
