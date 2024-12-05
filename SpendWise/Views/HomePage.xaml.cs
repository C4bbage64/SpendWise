using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace SpendWise.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private  async void NavigateToAddExpense(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddExpensePage());
        }

        private async void NavigateToViewExpenses(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ViewExpensesPage());
        }
    }
}
