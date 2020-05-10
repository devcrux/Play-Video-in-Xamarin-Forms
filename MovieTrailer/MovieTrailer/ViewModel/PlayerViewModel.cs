using MovieTrailer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieTrailer.ViewModel
{
    public class PlayerViewModel : BaseViewModel
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
    }
}
