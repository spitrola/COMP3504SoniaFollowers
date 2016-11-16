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
using UniBlu.Adapters;

namespace UniBlu.Fragments
{
    public class GNEDFragment : CourseBaseFragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            base.OnActivityCreated(savedInstanceState);
            FindViews();
            HandleEvents();

            courses = courseDataService.GetCoursesForGroup(1);
            listView.Adapter = new CourseListAdapter(this.Activity, courses);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.GNEDFragment, container, false);
        }
    }
}