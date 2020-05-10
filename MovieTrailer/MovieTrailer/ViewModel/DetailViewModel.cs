using MovieTrailer.Model;
using MovieTrailer.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MovieTrailer.ViewModel
{
    public class DetailViewModel : BaseViewModel
    {
        private Movie selectedMovie;
        public Movie SelectedMovie
        {
            get { return selectedMovie; }
            set
            {
                selectedMovie = value;
                OnPropertyChanged();
            }
        }

        public ICommand PlayCommand => new Command(() =>
        {
            var vm = new PlayerViewModel { SelectedMovie = selectedMovie };
            var page = new PlayerPage { BindingContext = vm };
            Application.Current.MainPage.Navigation.PushAsync(page);
        });
    }
}
