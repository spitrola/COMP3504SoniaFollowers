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
		private CalendarView schedulePlannerCalendarView;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

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
			StartActivityForResult(intent, 100);
		}
		protected override void OnActivityResult(int requestCode, [GeneratedEnum] Result resultCode, Intent data)
		{
			// Todo - how do we now add a filter to the searches
			base.OnActivityResult(requestCode, resultCode, data);
		}

		private void AddCourse_Click(object sender, EventArgs e)
		{
			notDone();
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
			//schedulePlannerCalendarView = FindViewById<CalendarView>(Resource.Id.currentScheduleCalendarView);
			addCourse = FindViewById<Button>(Resource.Id.addCourseButton);
			addFilter = FindViewById<Button>(Resource.Id.addFilterButton);
			clearCalendar = FindViewById<Button>(Resource.Id.clearCalendarButton);
			removeFromCalendar = FindViewById<Button>(Resource.Id.removeFromCalendarButton);
			saveCalendar = FindViewById<Button>(Resource.Id.saveCalendarButton);
		}
	}
}