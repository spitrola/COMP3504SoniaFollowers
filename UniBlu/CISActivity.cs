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
using UniBlu.Fragments;

namespace UniBlu
{
    [Activity(Label = "CIS Activity", Theme = "@style/TabTheme")]
    public class CISActivity : TabBaseActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.CISLayout);
            SetToolBar();
        }

        private void SetToolBar()
        {
            this.ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;
            ActionBar.Title = GetString(Resource.String.cisTitle);

            AddTab("Web Site", new CISWebSiteFragment());
            AddTab("Face Book", new CISFaceBookFragment());
        }

        private void AddTab(string tabText, Fragment view)
        {
            var tab = this.ActionBar.NewTab();
            tab.SetText(tabText);

            tab.TabSelected += delegate (object sender, ActionBar.TabEventArgs e)
            {
                var fragment = this.FragmentManager.FindFragmentById(Resource.Id.CISFragmentContainer);
                if (fragment != null)
                {
                    e.FragmentTransaction.Remove(fragment);
                }
                e.FragmentTransaction.Add(Resource.Id.CISFragmentContainer, view);
            };

            tab.TabUnselected += delegate (object sender, ActionBar.TabEventArgs e)
            {
                e.FragmentTransaction.Remove(view);
            };
            // Add tab to action bar tab collection
            this.ActionBar.AddTab(tab);
        }
    }
}