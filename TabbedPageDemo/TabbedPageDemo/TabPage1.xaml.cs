using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedPageDemo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TabPage1 : ContentPage
	{
		public TabPage1 ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Debug.WriteLine("Page 1 OnAppearing");
        }
    }
}