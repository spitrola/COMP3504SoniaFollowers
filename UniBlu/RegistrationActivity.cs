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
    [Activity(Label = "RegistrationActivity")]
    public class RegistrationActivity : BaseActivity
    {
        EditText userNameRegistration;
        EditText password;
        EditText confirmPassword;
        Button registerButton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.registrationLayout);
            FindViews();
            SetToolBar();
            HandleEvents();
        }

        private void SetToolBar()
        {
            SetActionBar(this.toolbar);
            ActionBar.Title = GetString(Resource.String.registration);
        }

        private void FindViews()
        {
            this.toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            userNameRegistration = FindViewById<EditText>(Resource.Id.userNameEditText);
            password = FindViewById<EditText>(Resource.Id.passwordEditText);
            confirmPassword = FindViewById<EditText>(Resource.Id.confirmPasswordEditText);
            registerButton = FindViewById<Button>(Resource.Id.registerButton);
        }
        private void HandleEvents()
        {
            registerButton.Click += RegisterButton_Click;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Toast toast = Toast.MakeText(this, Resource.String.thankYouForRegistering, ToastLength.Long);
            toast.SetGravity(GravityFlags.Center, 0, 0);
            toast.Show();
            var intent = new Intent(this, typeof(LandingPageActivity));
            StartActivity(intent);
        }
    }
}