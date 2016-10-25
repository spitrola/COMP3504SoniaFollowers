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
        }
        private void HandleEvents()
        {
        }
    }
}