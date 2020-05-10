using System;
using System.Collections.Generic;
using System.Text;

namespace MovieTrailer.Model
{
    public class Movie
    {
        public string Title { get; set; }
        public string Synopsis { get; set; }
        public string Thumbnail { get; set; }
        public string Url { get; set; }
        public bool IsFeatured { get; set; }
    }
}
