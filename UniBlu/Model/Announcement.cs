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
    public class Announcement
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Title { get; set; }
        public string PostedBy { get; set; }
        public string PostedTo { get; set; }
        public string Content { get; set; }
    }
}