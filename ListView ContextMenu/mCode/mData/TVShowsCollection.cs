using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ListView_ContextMenu.mCode.mData
{
    class TVShowsCollection
    {
        public static JavaList<TVShow> GetTvShows()
        {
            JavaList<TVShow> tvShows=new JavaList<TVShow>();
            TVShow tvShow = null;

            //ADD DATA

            tvShow = new TVShow();
            tvShow.Name = "BlackList";
            tvShow.Image = Resource.Drawable.red;
            tvShows.Add(tvShow);

            tvShow = new TVShow();
            tvShow.Name = "Breaking Bad";
            tvShow.Image = Resource.Drawable.breaking;
            tvShows.Add(tvShow);

            tvShow = new TVShow();
            tvShow.Name = "Fruits";
            tvShow.Image = Resource.Drawable.fruits;
            tvShows.Add(tvShow);

            tvShow = new TVShow();
            tvShow.Name = "Game of Thrones";
            tvShow.Image = Resource.Drawable.thrones;
            tvShows.Add(tvShow);

            tvShow = new TVShow();
            tvShow.Name = "Star Wars";
            tvShow.Image = Resource.Drawable.starwars;
            tvShows.Add(tvShow);

            tvShow = new TVShow();
            tvShow.Name = "Star Trek";
            tvShow.Image = Resource.Drawable.space;
            tvShows.Add(tvShow);

            tvShow = new TVShow();
            tvShow.Name = "BlackList 2";
            tvShow.Image = Resource.Drawable.blacklist;
            tvShows.Add(tvShow);

            return tvShows;

        }
    }
}