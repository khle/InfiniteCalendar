using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace InfiniteCalendar
{
    public partial class CalendarGridView : ContentPage
    {
        public CalendarGridView()
        {
            InitializeComponent();

            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }
        private void OnCancelClicked(object sender, EventArgs args)
        {
            Xamarin.Forms.Application.Current.MainPage.Navigation.PopModalAsync();
        }
    }
}
