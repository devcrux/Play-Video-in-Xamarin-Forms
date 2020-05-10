using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MovieTrailer.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WatchListPage : ContentPage
    {
        public WatchListPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            moviesColView.SelectedItem = null;
        }
    }
}