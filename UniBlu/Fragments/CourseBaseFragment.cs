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
    public class CourseBaseFragment : Fragment
    {
        protected ListView listView;
        protected List<Course> courses;
        protected CourseDataService courseDataService;
        private const int ADDCOURSE = 200;
        public CourseBaseFragment()
        {
            courseDataService = new CourseDataService();
        }
        protected void HandleEvents()
        {
            listView.ItemClick += ListView_ItemClick;
        }
        protected void ListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var course = courses[e.Position];
            Intent intent = new Intent(Activity.BaseContext, typeof(SchedulePlannerActivity));
            intent.PutExtra("courseNumber", course.CourseNumber.ToString());
            intent.PutExtra("courseSubject", course.Subject.ToString());
            intent.PutExtra("professor", course.Sections[e.Position].Instructor.ToString());
            intent.PutExtra("requestCode", ADDCOURSE);
            //commented out for testing james' problem
            //string msg = "course selected was: " + intent.GetStringExtra("courseSubject") + intent.GetStringExtra("courseNumber");
            //Toast toast = Toast.MakeText(Activity, msg, ToastLength.Long);
            //toast.SetGravity(GravityFlags.Center, 0, 0);
            //toast.Show();
            StartActivity(intent);            
        }
        protected void FindViews()
        {
            listView = this.View.FindViewById<ListView>(Resource.Id.coreCourseListView);
        }
    }
}