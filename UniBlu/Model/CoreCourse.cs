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
    public class CoreCourse
    {
        public int Id { get; set; }                 
        public string Program { get; set; }         // i.e., COMP
        public int CourseNumber { get; set; }       // i.e., 1501
        public string [,] PreReq { get; set; }      // ie { "COMP", "1501" }, { "COMP", "1502" }
    }
}