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
	[Activity(Label = "Schedule Planner")]
	public class SchedulePlannerActivity : BaseActivity
	{
		private Button addCourse;
		private Button addFilter;
		private Button clearCalendar;
		private Button removeFromCalendar;
		private Button saveCalendar;
		private const int FILTER = 100;
		private const int ADDCOURSE = 200;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
            //fix to problem is to access the bundle extra values through Intent as seen below
            var dialog = new AlertDialog.Builder(this);
            String test = "Your course: " + Intent.GetStringExtra("courseSubject") + Intent.GetStringExtra("courseNumber") + "\nInstructor: " + Intent.GetStringExtra("professor");
            dialog.SetMessage(test);
            dialog.Show();
            
            if (savedInstanceState != null && savedInstanceState.GetString("courseId") != null)
            {
                var courseId = savedInstanceState.GetString("courseId");
                var msg = "Yipee!!! you courseID = " + courseId;
                Toast toast = Toast.MakeText(this, msg, ToastLength.Long);
                toast.SetGravity(GravityFlags.Center, 0, 0);
                toast.Show();
            }

            SetContentView(Resource.Layout.SchedulePlannerLayout);
			FindViews();
			SetToolBar();
			HandleEvents();
		}

		private void HandleEvents()
		{
			addCourse.Click += AddCourse_Click;
			addFilter.Click += AddFilter_Click;
			clearCalendar.Click += ClearCalendar_Click;
			removeFromCalendar.Click += RemoveFromCalendar_Click;
			saveCalendar.Click += SaveCalendar_Click;
		}

		private void SaveCalendar_Click(object sender, EventArgs e)
		{
			notDone();
		}

		private void RemoveFromCalendar_Click(object sender, EventArgs e)
		{
			notDone();
		}

		private void ClearCalendar_Click(object sender, EventArgs e)
		{
			notDone();
		}

		private void AddFilter_Click(object sender, EventArgs e)
		{
			Intent intent = new Intent(this, typeof(CreateFilterActivity));
			StartActivityForResult(intent, FILTER);
		}
		protected override void OnActivityResult(int requestCode, [GeneratedEnum] Result resultCode, Intent data)
		{
			// Todo - how do we now add a filter to the searches (requestCode = 100)
			// Todo - how do we add a course to the calendar (requestCode = 200)
			base.OnActivityResult(requestCode, resultCode, data);
			var msg = "Request code " + requestCode + " was returned";
			Toast toast = Toast.MakeText(this, msg, ToastLength.Long);
			toast.SetGravity(GravityFlags.Center, 0, 0);
			toast.Show();
		}

		private void AddCourse_Click(object sender, EventArgs e)
		{
			Intent intent = new Intent(this, typeof(AddCourseActivity));
			intent.PutExtra("requestCode", ADDCOURSE);
			StartActivity(intent);
		}

		private void notDone()
		{
			Toast toast = Toast.MakeText(this, Resource.String.sorryNotDone, ToastLength.Long);
			toast.SetGravity(GravityFlags.Center, 0, 0);
			toast.Show();
		}

		private void SetToolBar()
		{
			SetActionBar(this.toolbar);
			ActionBar.Title = GetString(Resource.String.schedulePlannerTitle);
		}

		private void FindViews()
		{
			this.toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
			addCourse = FindViewById<Button>(Resource.Id.addCourseButton);
			addFilter = FindViewById<Button>(Resource.Id.addFilterButton);
			clearCalendar = FindViewById<Button>(Resource.Id.clearCalendarButton);
			removeFromCalendar = FindViewById<Button>(Resource.Id.removeFromCalendarButton);
			saveCalendar = FindViewById<Button>(Resource.Id.saveCalendarButton);
		}
	}
}