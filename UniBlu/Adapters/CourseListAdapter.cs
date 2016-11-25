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

namespace UniBlu.Adapters
{
    public class CourseListAdapter : BaseAdapter<Course>
    {
        List<Course> items;
        Activity context;

        public override int Count
        {
            get
            {
                return items.Count;
            }
        }

        public override Course this[int position]
        {
            get
            {
                return items[position];
            }
        }

        public CourseListAdapter(Activity context, List<Course> items) : base()
		{
            this.context = context;
            this.items = items;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = items[position];

            if (convertView == null)
            {
                convertView = context.LayoutInflater.Inflate(Resource.Layout.CourseRowView, null);
            }
            convertView.FindViewById<TextView>(Resource.Id.courseTitleTextView).Text = item.Title;
            convertView.FindViewById<TextView>(Resource.Id.courseDisciplineTextView).Text = item.Subject;
            convertView.FindViewById<TextView>(Resource.Id.courseNumberTextView).Text = item.CourseNumber.ToString();
            convertView.FindViewById<TextView>(Resource.Id.courseInstructorTextView).Text = item.Sections[0].Instructor;
            return convertView;

        }
    }
}