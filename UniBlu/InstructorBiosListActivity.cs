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
using UniBlu.Adapters;
using UniBlu.Model;
using UniBlu.Service;

namespace UniBlu
{
    [Activity(Label = "Instructor Bios List Activity")]
    public class InstructorBiosListActivity : Activity
    {
        private ListView instructorBioListView;
        private InstructorBioDataService instructorBioDataService;
        private List<InstructorBio> allInstructorBios;
        private InstructorBioAdapter InstructorBioAdapter;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.InstructorBioListView);
            instructorBioDataService = new InstructorBioDataService();
            allInstructorBios = instructorBioDataService.GetAllInstructorBios();
            FindViews();
            
            InstructorBioAdapter = new InstructorBioAdapter(this, allInstructorBios);

            instructorBioListView.Adapter = InstructorBioAdapter;
            // TODO Need to get the data and bind to view
            
            instructorBioListView.ItemClick += ListView_ItemClick;
        }

        private void FindViews()
        {
            instructorBioListView = FindViewById<ListView>(Resource.Id.listView1);
        }

        private void ListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var instructorBio = allInstructorBios[e.Position];
            Android.Widget.Toast.MakeText(this, instructorBio.Bio, ToastLength.Long).Show();
        }
    }
}