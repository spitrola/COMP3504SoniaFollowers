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
using UniBlu.Repository;
using UniBlu.Adapters;

namespace UniBlu.Adapters
{
	public class AnnouncementListAdapter : BaseAdapter<Announcement>
	{
		List<Announcement> items;
		Activity context;

		public override int Count
		{
			get
			{
				return items.Count;
			}
		}

		public override Announcement this[int position]
		{
			get
			{
				return items[position];
			}
		}

		public AnnouncementListAdapter(Activity context, List<Announcement> items) : base()
		{
			this.context = context;
			this.items = items;
		}

		public override long GetItemId(int position)
		{
			return position;
		}

		public override View GetView(int position, View convertView, ViewGroup parent)
		{
			var item = items[position];

			if (convertView == null)
			{
				convertView = context.LayoutInflater.Inflate(Resource.Layout.AnnouncementRowView, null);
			}
			convertView.FindViewById<TextView>(Resource.Id.announcementTitleTextView).Text = item.Title;
			convertView.FindViewById<TextView>(Resource.Id.announcementDateTextView).Text = item.Date;
			convertView.FindViewById<TextView>(Resource.Id.announcementPostedByTextView).Text = "Posted By: " + item.PostedBy;
			convertView.FindViewById<TextView>(Resource.Id.announcementPostedToTextView).Text = "Posted To: " + item.PostedTo;
			convertView.FindViewById<TextView>(Resource.Id.announcementContentTextView).Text = item.Content;
			return convertView;

		}
	}
}