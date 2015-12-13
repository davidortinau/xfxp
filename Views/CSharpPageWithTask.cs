using System;

using Xamarin.Forms;
using System.Threading.Tasks;
using System.Diagnostics;

namespace xfxp
{
	public class CSharpPageWithTask : ContentPage
	{
		public CSharpPageWithTask ()
		{
			Stopwatch sw = Stopwatch.StartNew();
			var content = new StackLayout { 
				Children = {
					new Button { Text = "Testing" },
				}
			};
			Content = content;

			Button button = null;
			Task.Run (async () => {
				for (int i = 0; i <900; i++) {
					button = new Button { Text = "Testing" };
					button.Clicked += ClickButton;
					Device.BeginInvokeOnMainThread (() => {
						content.Children.Add (button);
					});
				}
				await Task.Yield();
				Debug.WriteLine("C SHARP ASYNC FINISHED IN " + sw.ElapsedMilliseconds.ToString());
			});
		}

		public void ClickButton(Object sender, EventArgs args) {
			Debug.WriteLine ("Clicked");
		}
	}
}


