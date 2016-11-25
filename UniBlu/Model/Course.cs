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
        public int CourseId { get; set; }           // Auto incremented by the database
        public int SectionId { get; set; }          // i.e., some 5 digit number
        public string Subject { get; set; }         // i.e., COMP
        public int CourseNumber { get; set; }       // i.e., 1501
        public string Title { get; set; }           // i.e., Introduction to Programming
        public List<Section> Sections { get; set; } // i.e., an array of section objects
        //todo check for full feature class
    }
}
