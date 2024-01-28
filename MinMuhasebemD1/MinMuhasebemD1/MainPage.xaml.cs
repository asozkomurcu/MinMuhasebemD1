using MinMuhasebemD1.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MinMuhasebemD1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnAddedIncome_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new IncomeStatementAddedPage());
        }

        private void btnPaymentPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PaymentPage());
        }

        private void btnCreditCardAdded_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CreditCardAddedPage());
        }

        private void btnCreditCardMovement_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CreditCardMovementsPage());
        }

        private void btnAddedSupplier_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SupplierAddedPage());
        }

        private void btnCCCommision_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new IncomeCCCommissionRatePage());
        }
    }
}
