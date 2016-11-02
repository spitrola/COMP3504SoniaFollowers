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
using Android.Graphics;
using Android.Views.Animations;
using Android.Animation;

namespace UniBlu
{
	[Activity(Label = "Landing Page sucks as a title")]
	class LandingPageActivity : BaseActivity
	{
        private Button coursePlannerButton;
        private Button announcementButton;
        private Button instructorBiosButton;
        private Button labSchedulesButton;
        private Button studentSocietyButton;
        protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.LandingPageView);
			FindViews();
            SetToolBar();
			HandleEvents();
		}

        private void SetToolBar()
        {
            SetActionBar(this.toolbar);
            ActionBar.Title = GetString(Resource.String.appName);
        }

        private void FindViews()
		{
            this.toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            coursePlannerButton = FindViewById<Button>(Resource.Id.coursePlannerButton);
            announcementButton = FindViewById<Button>(Resource.Id.announcementButton);
            instructorBiosButton = FindViewById<Button>(Resource.Id.instructorBiosButton);
            labSchedulesButton = FindViewById<Button>(Resource.Id.labSchedulesButton);
            studentSocietyButton = FindViewById<Button>(Resource.Id.studentSocietyButton);
        }
		private void HandleEvents()
		{
            coursePlannerButton.Click += CoursePlannerButton_Click;
            announcementButton.Click += AnnouncementButton_Click;
            instructorBiosButton.Click += InstructorBiosButton_Click;
            labSchedulesButton.Click += LabSchedulesButton_Click;
            studentSocietyButton.Click += StudentSocietyButton_Click;
        }

        private void StudentSocietyButton_Click(object sender, EventArgs e)
        {
            notDone();
        }

        private void notDone()
        {
            Toast toast = Toast.MakeText(this, Resource.String.sorryNotDone, ToastLength.Long);
            toast.SetGravity(GravityFlags.Center, 0, 0);
            toast.Show();
        }

        private void LabSchedulesButton_Click(object sender, EventArgs e)
        {
            notDone();
        }

        private void InstructorBiosButton_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(InstructorBiosListActivity));
            StartActivity(intent);
        }

        private void AnnouncementButton_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(AnnouncementMenuActivity));
            StartActivity(intent);
        }

        private void CoursePlannerButton_Click(object sender, EventArgs e)
        {
            notDone();
        }
    }
}