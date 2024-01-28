using MinMuhasebemD1.DataBases;
using MinMuhasebemD1.Views;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MinMuhasebemD1
{
    public partial class App : Application
    {
        public static string FolderPath {  get; private set; }
        private static MMContext mMContext;
        public static MMContext MMContext
        {
            get
            {
                if (mMContext == null)
                {
                    mMContext = new MMContext(Path.Combine(App.FolderPath,"MMDb.db3"));
                }
                return mMContext;
            }
        }
        public App()
        {
            InitializeComponent();

            FolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));

            MainPage = new CreditCardsPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
