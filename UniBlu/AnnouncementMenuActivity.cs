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
using UniBlu.Adapters;
using UniBlu.Model;
using UniBlu.Service;
using UniBlu.Fragments;
using Android.Views.Animations;
using static Android.App.ActionBar;

namespace UniBlu
{
    [Activity(Label = "Announcements", Theme = "@style/TabTheme")]
    public class AnnouncementMenuActivity : TabBaseActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            SetToolBar();
 
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.AnnouncementMenuView);
            FindViews();
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
            ActionBar.Title = GetString(Resource.String.announcementsTitle);
            AddTab("Program", new ProgramFragment());
            AddTab("Instructors", new InstructorsFragment());
            AddTab("Society", new SocietyFragment());
        }
        private void AddTab(string tabText, Fragment view)
        {
            var tab = this.ActionBar.NewTab();
            tab.SetText(tabText);

            tab.TabSelected += delegate (object sender, ActionBar.TabEventArgs e)
            {
                var fragment = this.FragmentManager.FindFragmentById(Resource.Id.fragmentContainer);
                if (fragment != null)
                {
                    e.FragmentTransaction.Remove(fragment);
                }
                e.FragmentTransaction.Add(Resource.Id.fragmentContainer, view);
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