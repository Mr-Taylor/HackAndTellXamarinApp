using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinApp.ViewModels;
using XamarinApp.Views;

namespace XamarinApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private void BtnAll_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EmployeeListView(JobTitleType.All));
        }

        private void BtnLeads_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EmployeeListView(JobTitleType.Lead));
        }

        private void BtnManager_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EmployeeListView(JobTitleType.Manager));
        }
    }
}
