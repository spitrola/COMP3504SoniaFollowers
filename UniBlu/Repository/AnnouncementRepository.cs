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
		// TODO: For proof of concept, we will just add data here, once we get PhanomJS/CasperJS, scraping,
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
						Content = "\r\n(1) Skills demo 1 period has been extended. You have from Oct 5 to Oct 31 to sign up for and do your demo. Each demo now has a 40 minute time period.\\r\\n\u00a0 \u00a0 \u00a0All previously booked demos have been cancelled\u00a0to allow for rebooking. If you have already done your demo you are good. If you have not done your demo please sign up for a demo again through the following link:\\r\\n\u00a0 \u00a0 \u00a0 \u00a0http://tinyurl.com/j76neg6\\r\\n\u00a0(2) The dates for Exams 3,4,\u00a0and 5\u00a0have been changed. The course calendar has been updated along with the main course content section to reflect this. The new dates are listed below\\r\\n(3) For Course material 3 you will now see \\\"Exam and Studying Prep Material\\\" this contains a document with questions to help you study the provided material. Exam 3 will be built using these questions. These questions will also help you with early prep for Skills demo 2\\r\\n(4) Phase 4 of the course project is now worth 11% ( some of the weight of phase 5 was moved here)\\r\\n(5) Phase 5 of the project now contains fewer steps. I will discuss this in class next week.\\r\\n\\r\\nCourse Link/Main course content/Course Material 3 (Oct 5 to Oct 25)/Exam and Studying Prep Material\\r\\n"
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