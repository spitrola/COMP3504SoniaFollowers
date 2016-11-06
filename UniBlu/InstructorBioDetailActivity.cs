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
	[Activity(Label = "InstructorBioDetailActivity")]
	public class InstructorBioDetailActivity : Activity
	{
		private TextView professorName;
		private TextView professorText;

		private InstructorBioDataService instructorBioDataService;
		private Instructor instructor;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			instructorBioDataService = new InstructorBioDataService();

			SetContentView(Resource.Layout.InstructorBiosView);
			FindViews();

			int instructorId = Intent.GetIntExtra("Id", -1);
			instructorId = instructorId + 1;
			instructor = instructorBioDataService.GetInstructorBioById(instructorId);
			professorName.Text = instructor.Name;
			professorText.Text = instructor.Bio;
		}

		private void FindViews()
		{
			professorName = FindViewById<TextView>(Resource.Id.professorNameTextView);
			professorText = FindViewById<TextView>(Resource.Id.professorBioTextView);
		}
	}
}