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
using Android.Webkit;

namespace UniBlu
{
    [Activity(Label = "CIS FaceBook Activity")]
    public class CISFaceBookActivity : BaseActivity
    {
        private WebView localWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.FaceBookLayout);
            FindViews();
            SetToolBar();
            SetWebView();
        }

        private void SetWebView()
        {
            localWebView.SetWebViewClient(new WebViewClient());
            localWebView.Settings.JavaScriptEnabled = true;
            localWebView.LoadUrl("http://www.cis3.org");
        }

        private void SetToolBar()
        {
            SetActionBar(this.toolbar);
            ActionBar.Title = GetString(Resource.String.cisTitle);
        }

        private void FindViews()
        {
            this.toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            localWebView = FindViewById<WebView>(Resource.Id.facebookWebView);
        }
    }
}