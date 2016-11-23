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
            Intent intent = new Intent(Context, typeof(SchedulePlannerActivity));
            intent.PutExtra("courseId", course.CourseId.ToString());
            intent.PutExtra("requestCode", ADDCOURSE);
            StartActivity(intent);            
        }
        protected void FindViews()
        {
            listView = this.View.FindViewById<ListView>(Resource.Id.coreCourseListView);
        }
    }
}