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
using UniBlu.Fragments;

namespace UniBlu
{
    [Activity(Label = "SchedulesActivity", Theme = "@style/TabTheme")]
    public class SchedulesActivity : TabBaseActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.SchedulesView);
            //FindViews();
            SetToolBar();
            //Note: Data binding and handling events occurs in the fragments.
        }
        private void FindViews()
        {
            this.toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
        }
        private void SetToolBar()
        {
            this.ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;
            ActionBar.Title = GetString(Resource.String.schedulesTitle);

            AddTab("Jordan", new JordanPrattFragment());
            AddTab("Steve", new SteveKalmarFragment());

            AddTab("B107", new B107Fragment());
            AddTab("B203", new B203Fragment());
            AddTab("B215", new B215Fragment()); 
        }
        private void AddTab(string tabText, Fragment view)
        {
            var tab = this.ActionBar.NewTab();
            tab.SetText(tabText);

            tab.TabSelected += delegate (object sender, ActionBar.TabEventArgs e)
            {
                var fragment = this.FragmentManager.FindFragmentById(Resource.Id.schedulesFragmentContainer);
                if (fragment != null)
                {
                    e.FragmentTransaction.Remove(fragment);
                }
                e.FragmentTransaction.Add(Resource.Id.schedulesFragmentContainer, view);
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