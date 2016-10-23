
using System;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using Android.Views;
using Android.Graphics;
using Android.Views.Animations;
using Android.Animation;

namespace UniBlu
{
	[Activity(Label = "@string/appName", MainLauncher = true, Icon = "@drawable/logo2")]
	public class MainActivityCopy : Activity
	{
		Button loginButton;
		EditText password;
		EditText username;
        Toolbar toolbar;
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
                case Resource.Id.about:
                    intent = new Intent(this, typeof(AboutActivity));
                    StartActivity(intent);
                    return true;
                default:
                    Animation myAnimation = AnimationUtils.LoadAnimation(this, Resource.Animation.screenShake);
                    toolbar.StartAnimation(myAnimation);
                    Toast toast = Toast.MakeText(this, Resource.String.sorryNotDone, ToastLength.Long);
                    toast.SetGravity(GravityFlags.Center, 0, 0);
                    toast.Show();
                    return base.OnOptionsItemSelected(item);
            }
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
			toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
			SetActionBar(toolbar);
			ActionBar.SetDisplayUseLogoEnabled(true);
			ActionBar.Title = GetString(Resource.String.welcome);

			loginButton = FindViewById<Button>(Resource.Id.loginButton);
			password = FindViewById<EditText>(Resource.Id.passwordEditText);
			username = FindViewById<EditText>(Resource.Id.usernameEditText);
		}
	}
}

