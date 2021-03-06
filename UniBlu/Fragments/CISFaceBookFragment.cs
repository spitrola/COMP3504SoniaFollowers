using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Android.Webkit;

namespace UniBlu.Fragments
{
    public class CISFaceBookFragment : Fragment
    {
        private WebView localWebView;
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.CISFragment, container, false);
            localWebView = view.FindViewById<WebView>(Resource.Id.CISWebView);
            localWebView.SetWebViewClient(new WebViewClient());
            localWebView.Settings.JavaScriptEnabled = true;
            localWebView.LoadUrl("https://www.facebook.com/groups/cis3org");
            return view;
        }
    }
}