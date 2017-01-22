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
    class TVShow
    {
        private string name;
        private int image;

        public TVShow()
        {
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Image
        {
            get { return image; }
            set { image = value; }
        }

    }
}