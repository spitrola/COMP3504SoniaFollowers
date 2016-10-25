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
	public class MainActivity : BaseActivity
	{
		private Button loginButton;
		private EditText password;
		private EditText username;
        private Button notRegistered;
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.Main);
			FindViews();
            SetToolBar();
            HandleEvents();
		}
        private void SetToolBar()
        {
            SetActionBar(this.toolbar);
            ActionBar.Title = GetString(Resource.String.welcome);
        }

        private void HandleEvents()
		{
			loginButton.Click += LoginButton_Click;
            notRegistered.Click += NotRegistered_Click;
		}

        private void NotRegistered_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(RegistrationActivity));
            StartActivity(intent);
        }

        private void LoginButton_Click(object sender, EventArgs e)
		{
			var intent = new Intent(this, typeof(LandingPageActivity));
			StartActivity(intent);
		}

		private void FindViews()
		{
			this.toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
			loginButton = FindViewById<Button>(Resource.Id.loginButton);
            notRegistered = FindViewById<Button>(Resource.Id.notRegistered);
            password = FindViewById<EditText>(Resource.Id.passwordEditText);
			username = FindViewById<EditText>(Resource.Id.usernameEditText);
		}
	}
}

