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

namespace UniBlu
{
    [Activity(Label = "About Us")]
    public class AboutActivity : BaseActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.aboutLayout);
            FindViews();
            SetToolBar();
            HandleEvents();
        }
        private void SetToolBar()
        {
            SetActionBar(this.toolbar);
            ActionBar.Title = GetString(Resource.String.appName);
        }
        private void FindViews()
        {
            this.toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
        }
        private void HandleEvents()
        {

        }
    }
}