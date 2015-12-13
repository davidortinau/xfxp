using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Diagnostics;

namespace xfxp
{
	public partial class XamlPage : ContentPage
	{
		public XamlPage ()
		{
			Stopwatch sw = Stopwatch.StartNew();
			InitializeComponent ();
			Debug.WriteLine("XAML FINISHED IN " + sw.ElapsedMilliseconds.ToString());
		}

		public void ClickButton(Object sender, EventArgs args) {
			Debug.WriteLine ("Clicked");
		}
	}
}

