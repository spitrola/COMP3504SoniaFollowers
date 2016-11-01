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
using UniBlu.Repository;
using UniBlu.Model;

namespace UniBlu.Service
{
    public class AnnouncementDataService
    {
        private static AnnouncementRepository announcementRepository = new AnnouncementRepository();

        public List<Announcement> GetAllAnnouncements()
        {
            return announcementRepository.GetAllAnnouncements();
        }
        public List<AnnouncementGroup> GetGroupedAnnouncements()
        {
            return announcementRepository.GetGroupedAnnouncements();
        }
        public List<Announcement> GetAnnouncementsForGroup(int announcementGroupId)
        {
            return announcementRepository.GetAnnouncementsForGroup(announcementGroupId);
        }
        public Announcement GetAnnouncementById(int announcementId)
        {
            return announcementRepository.GetAnnouncementById(announcementId);
        }
    }
}