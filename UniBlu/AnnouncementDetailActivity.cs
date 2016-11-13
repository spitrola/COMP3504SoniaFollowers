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
using UniBlu.Model;
using UniBlu.Service;
using Android.Views.Animations;

namespace UniBlu
{
    [Activity(Label = "Announcements")]
    public class AnnouncementDetailActivity : TabBaseActivity
    {
        private TextView announcementTitleTextView;
        private TextView postedByTextView;

        private Button announcementCloseButton;

        private Announcement selectedAnnouncement;
        private AnnouncementDataService dataService;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.AnnouncementDetailView);
            dataService = new AnnouncementDataService();
            var selectedAnnouncementId = Intent.Extras.GetInt("selectedAnnouncementId");
            selectedAnnouncement = dataService.GetAnnouncementById(selectedAnnouncementId);

            FindViews();
            BindData();
            HandleEvents();
        }
        private void HandleEvents()
        {
            announcementCloseButton.Click += AnnouncementCloseButton_Click;
        }
        private void AnnouncementCloseButton_Click(object sender, EventArgs e)
        {
            var intent = new Intent();
            SetResult(Result.Ok, intent);
            this.Finish();
        }
        private void BindData()
        {
            announcementTitleTextView.Text = selectedAnnouncement.Title;
            postedByTextView.Text = selectedAnnouncement.PostedBy;
        }
        private void FindViews()
        {
            announcementTitleTextView = FindViewById<TextView>(Resource.Id.announcementTitleTextView);
            postedByTextView = FindViewById<TextView>(Resource.Id.postedByTextView);
            announcementCloseButton = FindViewById<Button>(Resource.Id.announcementCloseButton);
        }
    }
}