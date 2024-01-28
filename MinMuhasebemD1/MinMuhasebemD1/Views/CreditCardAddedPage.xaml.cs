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
	public partial class CreditCardAddedPage : ContentPage
	{
		public CreditCardAddedPage ()
		{
            InitializeComponent();
            LoadModels();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();


        }

        void LoadModels()
        {
            var models = new List<int>(31);
            for (int i = 1; i < 32; i++)
            {
                models.Add(i);
            }
            foreach (var model in models)
            {
                statementDay.Items.Add(model.ToString());
                paymentDueDay.Items.Add(model.ToString());
            }
        }


        void statementDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = statementDay.SelectedIndex;

            if (selectedIndex != -1)
            {
                statementDay.IsVisible = false;
                lblResultStatement.IsVisible = true;
                lblResultStatement.Text = statementDay.Items[selectedIndex];
            }
        }

        private void paymentDueDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = paymentDueDay.SelectedIndex;

            if (selectedIndex != -1)
            {
                paymentDueDay.IsVisible = false;
                lblResultPayment.IsVisible = true;
                lblResultPayment.Text = paymentDueDay.Items[selectedIndex];
            }
        }


        //public void paymentDueDay_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    int selectedIndex = paymentDueDay.SelectedIndex;
        //    if (selectedIndex != -1)
        //    {
        //        paymentDueDay.IsVisible = false;
        //        lblResult.IsVisible = true;
        //        lblResult.Text = paymentDueDay.Items[selectedIndex];
        //    }
        //}
    }
}