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
    [Activity(Label = "Landing Page sucks as a title")]
    class LandingPageActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.LandingPageView);
            FindViews();
            HandleEvents();
        }

        private void FindViews()
        {

        }
        private void HandleEvents()
        {

        }
    }
}