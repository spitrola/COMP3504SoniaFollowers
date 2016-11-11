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
    class Course
    {
        public int Id { get; set; }             // Auto incremented by the database
        public int CRN { get; set; }            // i.e., some 5 digit number
        public string Subject { get; set; }     // i.e., COMP
        public int CourseNumber { get; set; }   // i.e., 1501
        public int Section { get; set; }        // i.e., 001
        public DateTime Time { get; set; }      // i.e., 9:30 AM - 10:50 AM
        public string Title { get; set; }       // i.e., Introduction to Programming
        public char [] days { get; set; }       // i.e., TR (Tuesday and Thursday)
        public string Instructor { get; set; }  // i.e., Jordan Kidney
        public string Location { get; set; }    // i.e., B215
        public bool FullClass { get; set; }     // i.e., true = full, false = room available
    }
}