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
using UniBlu.Utility;

namespace UniBlu
{
	[Activity(Label = "InstructorBioDetailActivity")]
	public class InstructorBioDetailActivity : BaseActivity
	{
		private TextView professorName;
		private TextView professorText;
		private ImageView professorImage;

		private InstructorBioDataService instructorBioDataService;
		private Instructor instructor;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			instructorBioDataService = new InstructorBioDataService();

			SetContentView(Resource.Layout.InstructorBioDetailView);
			FindViews();
			SetToolBar();

			int instructorId = Intent.GetIntExtra("Id", -1);
			instructorId = instructorId + 1;
			instructor = instructorBioDataService.GetInstructorBioById(instructorId);

			var imageBitmap = ImageHelper.GetImageBitmapFromUrl(instructor.ImagePath);
			professorImage.SetImageBitmap(imageBitmap);
			professorName.Text = instructor.Name;
			professorText.Text = instructor.Bio;

		}

		private void FindViews()
		{
			professorName = FindViewById<TextView>(Resource.Id.professorNameTextView);
			professorText = FindViewById<TextView>(Resource.Id.professorBioTextView);
			professorImage = FindViewById<ImageView>(Resource.Id.professorImageView);
			this.toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
		}

		private void SetToolBar()
		{
			SetActionBar(this.toolbar);
			ActionBar.Title = GetString(Resource.String.instructor);
		}
	}
}