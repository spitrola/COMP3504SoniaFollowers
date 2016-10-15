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
			var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar1);
			SetActionBar(toolbar);
			ActionBar.Title = "UniBlu";
			FindViews();
			HandleEvents();
		}
        protected override void OnResume()
        {
            base.OnResume();
            Music.play(this, Resource.Raw.pomp_loop);
        }
        protected override void OnPause()
        {
            base.OnPause();
            Music.stop(this);
        }

        private void FindViews()
		{

		}
		private void HandleEvents()
		{

		}
	}
}