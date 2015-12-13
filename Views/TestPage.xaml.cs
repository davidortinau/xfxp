using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Threading.Tasks;

namespace xfxp
{
	public partial class TestPage : ContentPage
	{
		private bool LoadingNextPage = false;
		public TestPage ()
		{
			InitializeComponent ();

			XamlButton.Command = new Command (async () => {
				await Navigation.PushAsync (new XamlPage ());
			}, () => !LoadingNextPage
			);
				
			CSharpButton.Command = new Command (async () => {
				await Navigation.PushAsync (new CSharpPage ());
			}, () => !LoadingNextPage
			);

			XamlWithTaskButton.Command = new Command (async () => {
				await Navigation.PushAsync (new XamlPageWithTask ());
			}, () => !LoadingNextPage
			);

			XamlWithXamlCButton.Command = new Command (async () => {
				await Navigation.PushAsync (new XamlPageWithXamlC ());
			}, () => !LoadingNextPage
			);

			XamlWithTaskAndXamlCButton.Command = new Command (async () => {
				await Navigation.PushAsync (new XamlPageWithTaskAndXamlC ());
			}, () => !LoadingNextPage
			);

			CSharpWithTaskButton.Command = new Command (async () => {
				await Navigation.PushAsync (new CSharpPageWithTask ());
			}, () => !LoadingNextPage
			);
		}
	}
}

