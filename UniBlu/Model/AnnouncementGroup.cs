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
    public class AnnouncementGroup
    {
        public int GroupId { get; set; }
        public string groupName { get; set; }
        public List<Announcement> Announcements { get; set; }
    }
}