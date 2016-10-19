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
			var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
			SetActionBar(toolbar);
			ActionBar.Title = GetString(Resource.String.appName);
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

		public override bool OnCreateOptionsMenu(IMenu menu)
		{
			MenuInflater.Inflate(Resource.Menu.SettingsMenu, menu);
			return base.OnCreateOptionsMenu(menu);
		}

		public override bool OnOptionsItemSelected(IMenuItem item)
		{
			switch (item.ItemId)
			{
				case Resource.Id.settings:
					var intent = new Intent(this, typeof(SettingsActivity));
					StartActivity(intent);
					return true;
                case Resource.Id.about:
                    intent = new Intent(this, typeof(AboutActivity));
                    StartActivity(intent);
                    return true;
			}
			return base.OnOptionsItemSelected(item);
		}

		private void FindViews()
		{

		}
		private void HandleEvents()
		{

		}
	}
}