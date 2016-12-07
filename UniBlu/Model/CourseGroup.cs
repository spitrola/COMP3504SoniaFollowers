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

namespace UniBlu.Model
{
    public class CourseGroup
    {
        //internal List<Course> Courses;

        public int CourseGroupId { get; set; }
        public string Title { get; set; }
        public List<Course> CourseGrouping { get; set; }
    }
}