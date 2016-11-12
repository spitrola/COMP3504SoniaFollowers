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
    public class SocietyFragment : BaseFragment
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

            announcements = announcementDataService.GetAnnouncementsForGroup(3);
            listView.Adapter = new AnnouncementListAdapter(this.Activity, announcements);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.StudentSocietyAnnouncementFragment, container, false);
        }
    }
}