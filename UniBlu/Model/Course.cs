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
    public class Course
    {
        public int CourseId { get; set; }             // Auto incremented by the database
        public int SectionId { get; set; }            // i.e., some 5 digit number
        public string Subject { get; set; }     // i.e., COMP
        public int CourseNumber { get; set; }   // i.e., 1501
        //public int Section { get; set; }        // i.e., 001
        public string Title { get; set; }       // i.e., Introduction to Programming
        public string [][] days { get; set; }       // i.e., TR (Tuesday and Thursday) with start & end time 9 and 10:20
        public string Instructor { get; set; }  // i.e., Jordan Kidney
        public string Location { get; set; }    // i.e., B215
        //todo check for full feature class
        //public bool FullClass { get; set; }     // i.e., true = full, false = room available
    }
}
