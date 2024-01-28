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
	public partial class CreditCardMovementsPage : ContentPage
	{
		public CreditCardMovementsPage ()
		{
			InitializeComponent ();
		}

        private void creditCardsNamePicker_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void typeTransaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = typeTransaction.SelectedIndex;

            if (selectedIndex == 0)
            {
                entCreditCardCharges.Text = string.Empty;
                entCreditCardPayment.IsVisible = true;
                
            }
            else if (selectedIndex == 1)
            {
                entCreditCardPayment.Text = string.Empty;
                stclCreditCardCharges.IsVisible = true; 
            }
        }

        private void pckSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}