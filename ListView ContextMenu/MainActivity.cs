using System;
using System.Runtime.InteropServices;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Java.Lang;
using ListView_ContextMenu.mCode.mData;
using ListView_ContextMenu.mCode.mDetail;
using ListView_ContextMenu.mCode.mListView;


namespace ListView_ContextMenu
{
    [Activity(Label = "ListView ContextMenu", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private ListView lv;
        private CustomAdapter adapter;
        private JavaList<TVShow> tvShows;
        private Intent i = null;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            lv = FindViewById<ListView>(Resource.Id.lv);
            tvShows = TVShowsCollection.GetTvShows();
            adapter=new CustomAdapter(this,tvShows);

            lv.Adapter = adapter;

            lv.ItemClick += lv_ItemClick;
            lv.ContextMenuCreated += lv_ContextMenuCreated;

        }

        void lv_ContextMenuCreated(object sender, View.CreateContextMenuEventArgs e)
        {
            e.Menu.SetHeaderTitle("ACTION : ");
            e.Menu.Add(0, 0, 0, "Watch");
            e.Menu.Add(0, 1, 0, "Share");
            e.Menu.Add(0, 2, 0, "Rate");

        }

        public override bool OnContextItemSelected(IMenuItem item)
        {
            string title = item.TitleFormatted.ToString();

            this.OpenDetailActivity(title);

            return base.OnContextItemSelected(item);
        }

        void lv_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Toast.MakeText(this,tvShows[e.Position].Name,ToastLength.Short).Show();
        }

        private void OpenDetailActivity(System.String action)
        {
            i=new Intent(this,typeof(DetailActivity));
            //ADD SOME DATA
            i.PutExtra("NAME_KEY", action);

            this.StartActivity(i);
        }

    }
}

