using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Content;

namespace UniBlu
{
    [Activity(Label="@string/appName", MainLauncher = true, Icon = "@drawable/logo")]
    public class MainActivity : Activity
    {
        Button loginButton;
        EditText password;
        EditText username;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView (Resource.Layout.Main);
            FindViews();
            HandleEvents();
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
            ActionBar.Title = GetString(Resource.String.appName);

            loginButton = FindViewById<Button>(Resource.Id.loginButton);
            password = FindViewById<EditText>(Resource.Id.passwordEditText);
            username = FindViewById<EditText>(Resource.Id.usernameEditText);
        }
    }
}

