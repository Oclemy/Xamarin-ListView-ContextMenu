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

namespace ListView_ContextMenu.mCode.mDetail
{
    [Activity(Label = "DetailActivity")]
    public class DetailActivity : Activity
    {
        private TextView actionTxt;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.DetailLayout);

            actionTxt = FindViewById<TextView>(Resource.Id.actionDetailTxt);

            //RECEIVE DATA
            Android.Content.Intent i = this.Intent;
            String action = i.Extras.GetString("NAME_KEY");

            actionTxt.Text = action;
        }
    }
}