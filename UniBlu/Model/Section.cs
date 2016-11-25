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
    public class Section
    {
        public int SectionId { get; set; }          // Auto incremented by the database
        public string Instructor { get; set; }      // i.e., Jordan Kidney
        public string Type { get; set; }            // i.e., LEC or TUT
        public string Day { get; set; }             // i.e., M,T,W,R,F
        public string Start{ get; set; }            // i.e., "9:30 AM"
        public string End { get; set; }            // i.e., "9:30 AM"
        public string Location { get; set; }        // i.e., "B215"
    }
}