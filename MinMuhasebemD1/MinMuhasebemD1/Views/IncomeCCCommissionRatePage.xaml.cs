using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MinMuhasebemD1.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class IncomeCCCommissionRatePage : ContentPage
	{
		public IncomeCCCommissionRatePage ()
		{
			InitializeComponent ();
		}
        private void Button_Clicked(object sender, EventArgs e)
        {
            Commission.IsVisible = false;
            UpdateCommission.IsVisible = true;

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Commission.IsVisible = true;
            UpdateCommission.IsVisible = false;
        }
    }
}