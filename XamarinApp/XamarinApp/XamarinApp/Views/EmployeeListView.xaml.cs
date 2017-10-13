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
    public partial class EmployeeListView : ContentPage
    {
        public EmployeeListView(JobTitleType type)
        {
            InitializeComponent();
            BindingContext = new EmployeeListViewModel(type);
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