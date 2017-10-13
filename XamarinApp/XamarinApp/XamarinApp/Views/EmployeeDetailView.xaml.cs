using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApp.Models;
using XamarinApp.ViewModels;

namespace XamarinApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmployeeDetailView : ContentPage
    {
        EmployeeDetailViewModel viewModel;

        public EmployeeDetailView()
        {
            InitializeComponent();
        }

        public EmployeeDetailView(EmployeeDetailViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;

            if (vm.TeamMembers.Count == 0)
                LblMembers.IsVisible = false;
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var employee = args.SelectedItem as Employee;
            if (employee == null)
                return;

            Navigation.PushAsync(new EmployeeDetailView(new EmployeeDetailViewModel(employee)));

            EmployeeList.SelectedItem = null;
        }
    }
}