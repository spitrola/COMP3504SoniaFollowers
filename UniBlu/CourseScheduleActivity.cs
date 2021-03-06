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

namespace UniBlu
{
	[Activity(Label = "Course Schedule")]
	public class CourseScheduleActivity : BaseActivity
	{
		private Button goToCoursePlannerButton;
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.CourseScheduleLayout);
			FindViews();
			SetToolBar();
			HandleEvents();
		}

		private void HandleEvents()
		{
			goToCoursePlannerButton.Click += GoToCoursePlannerButton_Click;
		}

		private void GoToCoursePlannerButton_Click(object sender, EventArgs e)
		{
			Intent intent = new Intent(this, typeof(SchedulePlannerActivity));
			StartActivity(intent);
		}

		private void SetToolBar()
		{
			SetActionBar(this.toolbar);
			ActionBar.Title = GetString(Resource.String.currentSchedule);
		}

		private void FindViews()
		{
			this.toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
			goToCoursePlannerButton = FindViewById<Button>(Resource.Id.goToCoursePlannerButton);
		}
	}
}