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
	public class InstructorBiosListActivity : BaseActivity
	{
		private ListView instructorBioListView;
		private InstructorBioDataService instructorBioDataService;
		private List<Instructor> allInstructorBios;
		private InstructorBioAdapter instructorBioAdapter;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.InstructorBioListView);
			
			FindViews();
			SetToolBar();
            BindData();
            HandleEvents();
		}

        private void HandleEvents()
        {
            instructorBioListView.ItemClick += ListView_ItemClick;
        }

        private void BindData()
        {
            instructorBioDataService = new InstructorBioDataService();
            allInstructorBios = instructorBioDataService.GetAllInstructorBios();
            instructorBioAdapter = new InstructorBioAdapter(this, allInstructorBios);
            instructorBioListView.Adapter = instructorBioAdapter;
        }

        private void FindViews()
		{
			instructorBioListView = FindViewById<ListView>(Resource.Id.instructorBioListView);
			this.toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
		}

		private void ListView_ItemClick(object sender, ListView.ItemClickEventArgs e)
		{
			Intent instructorBioIntent = new Intent(this, typeof(InstructorBioDetailActivity));
			instructorBioIntent.PutExtra("Id", (int)e.Position);
			StartActivity(instructorBioIntent);
		}

		private void SetToolBar()
		{
			SetActionBar(this.toolbar);
			ActionBar.Title = GetString(Resource.String.instructors);
		}
	}
}