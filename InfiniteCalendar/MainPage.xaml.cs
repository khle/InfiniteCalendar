using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace InfiniteCalendar
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void LaunchCalendarClicked(object sender, EventArgs e)
        {
            var page = new Xamarin.Forms.NavigationPage(new CalendarGridView());
            await Application.Current.MainPage.Navigation.PushModalAsync(page, true);
        }
    }
}
