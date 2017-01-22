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
using ListView_ContextMenu.mCode.mData;
using Object = Java.Lang.Object;

namespace ListView_ContextMenu.mCode.mListView
{
    class CustomAdapter : BaseAdapter
    {

        private Context c;
        private JavaList<TVShow> tvShows;
        private LayoutInflater inflater;
        private TVShow tv;

        public CustomAdapter(Context c, JavaList<TVShow> tvShows)
        {
            this.c = c;
            this.tvShows = tvShows;
        }

        public override Object GetItem(int position)
        {
            return tvShows.Get(position);
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            if (inflater == null)
            {
                inflater = (LayoutInflater) c.GetSystemService(Context.LayoutInflaterService);
            }

            if (convertView == null)
            {
                convertView = inflater.Inflate(Resource.Layout.Model, parent, false);

            }

            TextView nametxt = convertView.FindViewById<TextView>(Resource.Id.nameTxt);
            ImageView img = convertView.FindViewById<ImageView>(Resource.Id.tvshowImg);

            tv = tvShows[position];

            nametxt.Text = tv.Name;
            img.SetImageResource(tv.Image);


            return convertView;
        }

        public override int Count
        {
            get { return tvShows.Size(); }
        }
    }
}