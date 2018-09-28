using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LearnXamarin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GreetPage : ContentPage
	{
		public GreetPage ()
		{
			InitializeComponent ();
            slider.Value = 0;

            //if (Device.RuntimePlatform == Device.iOS)
            //    Padding = new Thickness(0, 20, 0, 0);
            //else if (Device.RuntimePlatform == Device.Android)
            //    Padding = new Thickness(10, 20, 0, 0);
            //else if (Device.RuntimePlatform == Device.UWP)
            //    Padding = new Thickness(30, 20, 0, 0);

        }

    }
}