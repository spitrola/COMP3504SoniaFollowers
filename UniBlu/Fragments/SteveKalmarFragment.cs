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
    public class SteveKalmarFragment : Fragment
    {
        private WebView localWebView;
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.LabSchedulesFragment, container, false);
            localWebView = view.FindViewById<WebView>(Resource.Id.labSchedulesWebView);
            localWebView.SetWebViewClient(new WebViewClient());
            localWebView.Settings.JavaScriptEnabled = true;
            localWebView.LoadUrl("http://bit.ly/b162-fall-2016");
            return view;
        }
    }
}