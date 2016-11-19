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
    class CoreCourseRepository
    {
        private static List<CoreCourse> coreCourses = new List<CoreCourse>()
        {
            new CoreCourse() {
                Id = 1,
                Program = "COMP",
                CourseNumber = 1501,
                PreReq = null
            },
            new CoreCourse() {
                Id = 2,
                Program = "COMP",
                CourseNumber = 1502,
                PreReq = new string [,] {
                    { "COMP" , "1501" },
                    { "COMP" , "2511" } }
            },
            new CoreCourse() {
                Id = 3,
                Program = "COMP",
                CourseNumber = 1511,
                PreReq = new string [,] { { "COMP" , "1501" } }
            },
            new CoreCourse() {
                Id = 4,
                Program = "COMP",
                CourseNumber = 2503,
                PreReq = new string [,] { { "COMP" , "1502" } }
            },
            new CoreCourse() {
                Id = 5,
                Program = "COMP",
                CourseNumber = 2521,
                PreReq = new string [,] { { "COMP" , "1502" },
                                          { "COMP" , "2511" } }
            },
            new CoreCourse() {
                Id = 6,
                Program = "COMP",
                CourseNumber = 2533,
                PreReq = new string [,] { { "COMP" , "1502" } }
            },
            new CoreCourse() {
                Id = 7,
                Program = "COMP",
                CourseNumber = 2541,
                PreReq = new string [,] { { "COMP" , "2502" },
                                          { "COMP" , "2511" } }
            },
            new CoreCourse() {
                Id = 8,
                Program = "COMP",
                CourseNumber = 3512,
                PreReq = new string [,] { { "COMP" , "2511" },
                                          { "COMP" , "2503" } }
            },
            new CoreCourse() {
                Id = 9,
                Program = "COMP",
                CourseNumber = 3532,
                PreReq = new string [,] { { "COMP" , "2531" },
                                          { "COMP" , "2521" } }
            },
            new CoreCourse() {
                Id = 10,
                Program = "COMP",
                CourseNumber = 3533,
                PreReq = new string [,] { { "COMP" , "3532" } }
            },
            new CoreCourse() {
                Id = 11,
                Program = "COMP",
                CourseNumber = 4543,
                PreReq = new string [,] { { "COMP" , "2541" } }
            },
            new CoreCourse() {
                Id = 12,
                Program = "MGMT",
                CourseNumber = 2130,
                PreReq = new string [,] { {} }
            },
            new CoreCourse() {
                Id = 13,
                Program = "MTKG",
                CourseNumber = 2150,
                PreReq = new string [,] { {} }
            },
            new CoreCourse() {
                Id = 14,
                Program = "ACCT",
                CourseNumber = 2121,
                PreReq = new string [,] { {} }
            },
            new CoreCourse() {
                Id = 15,
                Program = "HRES",
                CourseNumber = 2170,
                PreReq = new string [,] { {} }
            },
            new CoreCourse() {
                Id = 16,
                Program = "COOP",
                CourseNumber = 0001,
                PreReq = new string [,] { {} }
            },
            new CoreCourse() {
                Id = 17,
                Program = "ENTR",
                CourseNumber = 2101,
                PreReq = new string[,] { { } }
            },
            new CoreCourse() {
                Id = 18,
                Program = "MATH",
                CourseNumber = 1505,
                PreReq = new string[,] { { } }
            }
        };
        public List<CoreCourse> GetAllAnnouncements()
        {
            IEnumerable<CoreCourse> theCoreCourses =
                from CoreCourse in coreCourses
                select CoreCourse;
            return theCoreCourses.ToList<CoreCourse>();
        }

        public CoreCourse GetCoreCourseById(int coreCourseId)
        {
            IEnumerable<CoreCourse> theCoreCourses =
                from CoreCourse in coreCourses
                where CoreCourse.Id == coreCourseId
                select CoreCourse;
            return theCoreCourses.FirstOrDefault();
        }
    }
}            