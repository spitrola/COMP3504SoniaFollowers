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

namespace UniBlu.Repository
{
	class AnnouncementRepository
	{
		// TODO: For proof of concept, we will just add data here, once we get Selenium, scraping,
		// parsing, database live we can make this a call to our database.
		private static List<AnnouncementGroup> announcementGroups = new List<AnnouncementGroup>()
		{
			new AnnouncementGroup()
			{
				AnnouncementGroupId = 1,
				Title = "Course",
				Announcements = new List<Announcement>()
				{
					new Announcement()
					{
						Id = 1,
						Date = "Thursday, October 27, 2016 2:18:14 PM MDT",
						Title = "New pluralsight course: Write less code with Xamarin Designer",
						PostedBy = "Jordan Kidney",
						PostedTo = "Comp 3504 F16 Prog IV: Software Engineering",
						Content = "\\r\\n\u00a0Pluralsight\u00a0course:\u00a0Write Less Code with Xamarin Designer\\r\\nhttps://app.pluralsight.com/library/courses/xamarin-designer-write-less-code/table-of-contents\\r\\n\\r\\n"
					},
					new Announcement()
					{
						Id = 2,
						Date = "Wednesday, October 29, 2016 9:37:39 PM MDT",
						Title = "Sample Xamarin.Android projects",
						PostedBy = "Jordan Kidney",
						PostedTo = "Comp 3504 F16 Prog IV: Software Engineering",
						Content = "https://developer.xamarin.com/samples/android/all/"
					}
				}
			},
			new AnnouncementGroup()
			{
				AnnouncementGroupId = 2,
				Title = "Instructor",
				Announcements = new List<Announcement>()
				{
					new Announcement()
					{
						Id = 3,
						Date = "Thursday, October 27, 2016 2:18:14 PM MDT",
						Title = "Web is Fun",
						PostedBy = "Randy Connolly",
						PostedTo = "BCIS Students",
						Content = "Stop whining about the work and fix the 1 pixel spacing"
					},
					new Announcement()
					{
						Id = 4,
						Date = "Wednesday, October 29, 2016 9:37:39 PM MDT",
						Title = "Security for the insecure",
						PostedBy = "Ming Wei Gong",
						PostedTo = "BCIS Students",
						Content = "Life is all about packets, now stop NACKing and start ACKing"
					}
				}
			},
			new AnnouncementGroup()
			{
				AnnouncementGroupId = 3,
				Title = "Student Society",
				Announcements = new List<Announcement>()
				{
					new Announcement()
					{
						Id = 5,
						Date = "Thursday, October 27, 2016 2:18:14 PM MDT",
						Title = "Pizza for all",
						PostedBy = "Priyash Bista",
						PostedTo = "CIS",
						Content = "Come one, come all for free pizza"
					},
					new Announcement()
					{
						Id = 6,
						Date = "Wednesday, November 2, 2016 9:37:39 PM MDT",
						Title = "Beer for all",
						PostedBy = "Priyash Bista",
						PostedTo = "CIS",
						Content = "Everyone is too stressed - we need to relax."
					}
				}
			}
		};

		public List<Announcement> GetAllAnnouncements()
		{
			IEnumerable<Announcement> announcements =
				from announcementGroup in announcementGroups
				from announcement in announcementGroup.Announcements

				select announcement;
			return announcements.ToList<Announcement>();
		}

		public Announcement GetAnnouncementById(int announcementId)
		{
			IEnumerable<Announcement> announcements =
				from announcementGroup in announcementGroups
				from announcement in announcementGroup.Announcements
				where announcement.Id == announcementId
				select announcement;
			return announcements.FirstOrDefault();
		}
		public List<AnnouncementGroup> GetGroupedAnnouncements()
		{
			return announcementGroups;
		}
		public List<Announcement> GetAnnouncementsForGroup(int announcementGroupId)
		{
			var group = announcementGroups.Where(h => h.AnnouncementGroupId == announcementGroupId).FirstOrDefault();

			if (group != null)
			{
				return group.Announcements;
			}
			return null;
		}
	}
}