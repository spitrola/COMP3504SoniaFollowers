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
using UniBlu.Model;
using UniBlu.Service;

namespace UniBlu.Fragments
{
    public class BaseFragment : Fragment
    {
        protected ListView listView;
        protected List<Announcement> announcements;
        protected AnnouncementDataService announcementDataService;

        public BaseFragment()
        {
            announcementDataService = new AnnouncementDataService();
        }
        protected void HandleEvents()
        {
            listView.ItemClick += ListView_ItemClick;
        }
        protected void ListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Announcement selectedAnnouncement = announcements[e.Position];
            Intent intent = new Intent(this.Activity, typeof(AnnouncementDetailActivity));
            intent.PutExtra("selectedAnnouncementId", selectedAnnouncement.Id);

            StartActivity(intent);
        }
        protected void FindViews()
        {
            listView = this.View.FindViewById<ListView>(Resource.Id.announcementListView);
        }
    }
}