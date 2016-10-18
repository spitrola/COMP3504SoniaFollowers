using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Content;
using Android.Views;

namespace UniBlu
{
	[Activity(Label = "@string/appName", MainLauncher = true, Icon = "@drawable/logo2")]
	public class MainActivity : Activity
	{
		Button loginButton;
		EditText password;
		EditText username;
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.Main);
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
			}
			return base.OnOptionsItemSelected(item);
		}

		private void HandleEvents()
		{
			loginButton.Click += LoginButton_Click;
		}

		private void LoginButton_Click(object sender, EventArgs e)
		{
			var intent = new Intent(this, typeof(LandingPageActivity));
			StartActivity(intent);
		}

		private void FindViews()
		{
			var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
			SetActionBar(toolbar);
			ActionBar.SetDisplayUseLogoEnabled(true);
			ActionBar.Title = GetString(Resource.String.welcome);

			loginButton = FindViewById<Button>(Resource.Id.loginButton);
			password = FindViewById<EditText>(Resource.Id.passwordEditText);
			username = FindViewById<EditText>(Resource.Id.usernameEditText);
		}
	}
}

