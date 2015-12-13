using System;

using Xamarin.Forms;
using System.Threading.Tasks;
using System.Diagnostics;

namespace xfxp
{
	public class CSharpPage : ContentPage
	{
		public CSharpPage ()
		{
			Stopwatch sw = Stopwatch.StartNew();
			Content = new StackLayout { 
				Children = {
					new Button { Text = "Testing" },
				}
			};

			var content = (StackLayout)Content;

			Button button = null;
			for (int i = 0; i <900; i++) {
				button = new Button { Text = "Testing" };
				button.Clicked += ClickButton;
				content.Children.Add (button);
			}
			Debug.WriteLine("C SHARP FINISHED IN " + sw.ElapsedMilliseconds.ToString());
		}

		public void ClickButton(Object sender, EventArgs args) {
			Debug.WriteLine ("Clicked");
		}
	}
}


