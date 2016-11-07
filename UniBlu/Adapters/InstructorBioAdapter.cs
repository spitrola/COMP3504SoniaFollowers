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
using UniBlu.Model;
using UniBlu.Utility;

namespace UniBlu.Adapters
{
    public class InstructorBioAdapter : BaseAdapter<Instructor>
    {
        private List<Instructor> items;
        private Activity context;

        public InstructorBioAdapter(Activity context, List<Instructor> items) : base()
        {
            this.context = context;
            this.items = items;
        }
        public override long GetItemId(int position)
        {
            return position;
        }
        public override Instructor this[int position]
        {
            get { return items[position]; }
        }
        public override int Count
        {
            get { return items.Count; }
        }
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = items[position];
            View view = convertView;
            if (view == null) // no view to re-use, create new
                view = context.LayoutInflater.Inflate(Resource.Layout.InstructorBiosView, null);
            //TODo change image to a picture
            
            var imageBitmap = ImageHelper.GetImageBitmapFromUrl(item.ImagePath);
            view.FindViewById<ImageView>(Resource.Id.professorImageView).SetImageBitmap(imageBitmap);
            view.FindViewById<TextView>(Resource.Id.professorNameTextView).Text = item.Name;
            view.FindViewById<TextView>(Resource.Id.professorBioTextView).Text = item.Bio;
            return view;
        }
    }
}