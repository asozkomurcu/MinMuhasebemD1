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
	public partial class PaymentPage : ContentPage
	{
		public PaymentPage ()
		{
			InitializeComponent ();
		}

        private void pckPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
			var selectedItem = pckPaymentType.SelectedIndex;
			if (selectedItem == 0) 
				pckCreditCard.IsVisible = false;
			else if (selectedItem == 1)
                pckCreditCard.IsVisible = true;
        }
    }
}