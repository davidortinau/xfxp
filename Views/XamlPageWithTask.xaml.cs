using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Threading.Tasks;
using System.Diagnostics;

namespace xfxp
{
	public partial class XamlPageWithTask : ContentPage
	{
		public XamlPageWithTask ()
		{
			Task.Run (async () => {
				Stopwatch sw = Stopwatch.StartNew();
				Device.BeginInvokeOnMainThread (() => {
					InitializeComponent ();
				});
				await Task.Yield();
				Debug.WriteLine("XAML ASYNC FINISHED IN " + sw.ElapsedMilliseconds.ToString());
			});
		}

		public void ClickButton(Object sender, EventArgs args) {
			Debug.WriteLine ("Clicked");
		}
	}
}

