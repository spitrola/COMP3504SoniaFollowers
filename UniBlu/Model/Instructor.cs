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
    public class Instructor
    {
        //TODO change Picture from string to image
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public string Bio { get; set; }
    }
}