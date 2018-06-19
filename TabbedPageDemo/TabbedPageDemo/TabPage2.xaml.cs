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
	public partial class TabPage2 : ContentPage
	{
		public TabPage2 ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Debug.WriteLine("Page 2 OnAppearing");
        }
    }
}