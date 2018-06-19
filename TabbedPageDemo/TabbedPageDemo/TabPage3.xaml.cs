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
	public partial class TabPage3 : ContentPage
	{
		public TabPage3 ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Debug.WriteLine("Page 3 OnAppearing");
        }
    }
}