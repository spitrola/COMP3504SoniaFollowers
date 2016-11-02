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

namespace UniBlu
{
    [Activity(Label = "Announcements")]
    public class AnnouncementMenuActivity :  Activity
    {
        private ListView announcementListView;
        private List<Announcement> allAnnouncements;
        private AnnouncementDataService announcementDataService;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;

            SetContentView(Resource.Layout.AnnouncementMenuView);

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

        private void AnnouncementListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var announcement = allAnnouncements[e.Position];
            var intent = new Intent(this, typeof(AnnouncementDetailActivity));
            intent.PutExtra("selectedAnnouncementId", announcement.Id);

            StartActivityForResult(intent, 100); //The second parameter is the request code
        }
        protected override void OnActivityResult(int requestCode, [GeneratedEnum] Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);

            if (resultCode == Result.Ok && requestCode == 100)
            {
                /* var selectedAnnouncement = announcementDataService.GetAnnouncementById(data.GetIntExtra("selectedAnnouncmentId", 1));
                var dialog = new AlertDialog.Builder(this);
                dialog.SetTitle("Confirmation");
                dialog.SetMessage(string.Format("You've add {0} time(s) the {1}", data.GetIntExtra("amount", 0), allHotDogs[data.GetIntExtra("selectedHotDogId", 0)].Name));
                dialog.Show(); */
            }
        }
    }
}