using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Diagnostics;

namespace xfxp
{
	[XamlCompilation (XamlCompilationOptions.Compile)]
	public partial class XamlPageWithXamlC : ContentPage
	{
		public XamlPageWithXamlC ()
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

