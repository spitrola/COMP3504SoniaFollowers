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
    public class ProgramFragment : BaseFragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);            
        }
        public override void OnActivityCreated(Bundle savedInstance)
        {
            base.OnActivityCreated(savedInstance);
            FindViews();
            // HandleEvents();

            announcements = announcementDataService.GetAnnouncementsForGroup(1);
            listView.Adapter = new AnnouncementListAdapter(this.Activity, announcements);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

            return inflater.Inflate(Resource.Layout.ProgramAnnouncementFragment, container, false);
        }
    }
}