using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Diagnostics;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using UniBlu.Model;
using Newtonsoft.Json;

namespace UniBlu.Repository
{
	class CourseRepository
	{
        private static List<CourseGroup> courseGroups = new List<CourseGroup>();
        private String url = "http://comp3504uniblu.azurewebsites.net/api/courses/";
        //      private static List<CourseGroup> courseGroups = new List<CourseGroup>()
        //{
        //	new CourseGroup()
        //	{
        //		CourseGroupId = 0,
        //		Title = "Core Courses",
        //		CourseGrouping = new List<Course>()
        //		{
        //			new Course()
        //			{
        //				CourseId = 0,
        //				SectionId = 12345,
        //				Subject = "COMP",
        //				CourseNumber = 1501,
        //                      Title = "Introduction to Programming",
        //				Sections = new List<Section>
        //                      {
        //                          new Section()
        //                          {
        //                              Instructor = "Randy Connoly",
        //                              Type = "LEC",
        //                              Day = "T",
        //                              Start = "2:00 PM",
        //                              End = "3:20 PM",
        //                              Location = "T234"
        //                          },
        //                          new Section()
        //                          {
        //                              Instructor = "Randy Connoly",
        //                              Type = "LEC",
        //                              Day = "R",
        //                              Start = "2:00 PM",
        //                              End = "3:20 PM",
        //                              Location = "T234"
        //                          },
        //                          new Section()
        //                          {
        //                              Instructor = "Randy Connoly",
        //                              Type = "TUT",
        //                              Day = "M",
        //                              Start = "11:00 AM",
        //                              End = "11:50 AM",
        //                              Location = "B215"
        //                          },
        //                          new Section()
        //                          {
        //                              Instructor = "Randy Connoly",
        //                              Type = "TUT",
        //                              Day = "M",
        //                              Start = "10:00 AM",
        //                              End = "10:50 AM",
        //                              Location = "B215"
        //                          },
        //                          new Section()
        //                          {
        //                              Instructor = "Randy Connoly",
        //                              Type = "TUT",
        //                              Day = "W",
        //                              Start = "1:00 PM",
        //                              End = "1:50 PM",
        //                              Location = "B215"
        //                          }
        //                      }
        //                  },
        //			new Course()
        //			{
        //				CourseId = 1,
        //				SectionId = 67890,
        //				Subject = "COMP",
        //				CourseNumber = 1502,
        //                      Title = "Programming II: Object Oriented Programming",
        //                      Sections = new List<Section>
        //                      {
        //                          new Section()
        //                          {
        //                              Instructor = "Ricardo Hoar",
        //                              Type = "LEC",
        //                              Day = "T",
        //                              Start = "2:00 PM",
        //                              End = "3:20 PM",
        //                              Location = "T234"
        //                          },
        //                          new Section()
        //                          {
        //                              Instructor = "Randy Connoly",
        //                              Type = "LEC",
        //                              Day = "R",
        //                              Start = "2:00 PM",
        //                              End = "3:20 PM",
        //                              Location = "T234"
        //                          },
        //                          new Section()
        //                          {
        //                              Instructor = "Randy Connoly",
        //                              Type = "TUT",
        //                              Day = "M",
        //                              Start = "11:00 AM",
        //                              End = "11:50 AM",
        //                              Location = "B215"
        //                          },
        //                          new Section()
        //                          {
        //                              Instructor = "Randy Connoly",
        //                              Type = "TUT",
        //                              Day = "M",
        //                              Start = "10:00 AM",
        //                              End = "10:50 AM",
        //                              Location = "B215"
        //                          },
        //                          new Section()
        //                          {
        //                              Instructor = "Randy Connoly",
        //                              Type = "TUT",
        //                              Day = "W",
        //                              Start = "1:00 PM",
        //                              End = "1:50 PM",
        //                              Location = "B215"
        //                          }
        //                      }
        //                  }
        //		}
        //	},
        //	new CourseGroup()
        //	{
        //		CourseGroupId = 1,
        //		Title = "GNED",
        //		CourseGrouping = new List<Course>()
        //		{
        //			new Course()
        //			{
        //				CourseId = 3,
        //				SectionId = 67890,
        //				Subject = "GNED",
        //				CourseNumber = 1103,
        //                      Title = "Scientific Innovation",
        //                      Sections = new List<Section>
        //                      {
        //                          new Section()
        //                          {
        //                              Instructor = "Jordan Kidney",
        //                              Type = "LEC",
        //                              Day = "T",
        //                              Start = "2:00 PM",
        //                              End = "3:20 PM",
        //                              Location = "T234"
        //                          },
        //                          new Section()
        //                          {
        //                              Instructor = "Randy Connoly",
        //                              Type = "LEC",
        //                              Day = "R",
        //                              Start = "2:00 PM",
        //                              End = "3:20 PM",
        //                              Location = "T234"
        //                          },
        //                          new Section()
        //                          {
        //                              Instructor = "Randy Connoly",
        //                              Type = "TUT",
        //                              Day = "M",
        //                              Start = "11:00 AM",
        //                              End = "11:50 AM",
        //                              Location = "B215"
        //                          },
        //                          new Section()
        //                          {
        //                              Instructor = "Randy Connoly",
        //                              Type = "TUT",
        //                              Day = "M",
        //                              Start = "10:00 AM",
        //                              End = "10:50 AM",
        //                              Location = "B215"
        //                          },
        //                          new Section()
        //                          {
        //                              Instructor = "Randy Connoly",
        //                              Type = "TUT",
        //                              Day = "W",
        //                              Start = "1:00 PM",
        //                              End = "1:50 PM",
        //                              Location = "B215"
        //                          }
        //                      }
        //                  },
        //			new Course()
        //			{
        //				CourseId = 4,
        //				SectionId = 67890,
        //				Subject = "GNED",
        //				CourseNumber = 1202,
        //                      //Section = 001,
        //                      Title = "Texts and Ideas",
        //                      Sections = new List<Section>
        //                      {
        //                          new Section()
        //                          {
        //                              Instructor = "Charles Hepler",
        //                              Type = "LEC",
        //                              Day = "T",
        //                              Start = "2:00 PM",
        //                              End = "3:20 PM",
        //                              Location = "T234"
        //                          },
        //                          new Section()
        //                          {
        //                              Instructor = "Randy Connoly",
        //                              Type = "LEC",
        //                              Day = "R",
        //                              Start = "2:00 PM",
        //                              End = "3:20 PM",
        //                              Location = "T234"
        //                          },
        //                          new Section()
        //                          {
        //                              Instructor = "Randy Connoly",
        //                              Type = "TUT",
        //                              Day = "M",
        //                              Start = "11:00 AM",
        //                              End = "11:50 AM",
        //                              Location = "B215"
        //                          },
        //                          new Section()
        //                          {
        //                              Instructor = "Randy Connoly",
        //                              Type = "TUT",
        //                              Day = "M",
        //                              Start = "10:00 AM",
        //                              End = "10:50 AM",
        //                              Location = "B215"
        //                          },
        //                          new Section()
        //                          {
        //                              Instructor = "Randy Connoly",
        //                              Type = "TUT",
        //                              Day = "W",
        //                              Start = "1:00 PM",
        //                              End = "1:50 PM",
        //                              Location = "B215"
        //                          }
        //                      }
        //                  }
        //		}
        //	},
        //	new CourseGroup()
        //	{
        //		CourseGroupId = 2,
        //		Title = "Electives",
        //		CourseGrouping = new List<Course>()
        //		{
        //			new Course()
        //			{
        //				CourseId = 5,
        //				SectionId = 67890,
        //				Subject = "CHEM",
        //				CourseNumber = 2211,
        //				Title = "The Chemistry Between Us",
        //                      Sections = new List<Section>
        //                      {
        //                          new Section()
        //                          {
        //                              Instructor = "Ruben Yumol",
        //                              Type = "LEC",
        //                              Day = "T",
        //                              Start = "2:00 PM",
        //                              End = "3:20 PM",
        //                              Location = "T234"
        //                          },
        //                          new Section()
        //                          {
        //                              Instructor = "Randy Connoly",
        //                              Type = "LEC",
        //                              Day = "R",
        //                              Start = "2:00 PM",
        //                              End = "3:20 PM",
        //                              Location = "T234"
        //                          },
        //                          new Section()
        //                          {
        //                              Instructor = "Randy Connoly",
        //                              Type = "TUT",
        //                              Day = "M",
        //                              Start = "11:00 AM",
        //                              End = "11:50 AM",
        //                              Location = "B215"
        //                          },
        //                          new Section()
        //                          {
        //                              Instructor = "Randy Connoly",
        //                              Type = "TUT",
        //                              Day = "M",
        //                              Start = "10:00 AM",
        //                              End = "10:50 AM",
        //                              Location = "B215"
        //                          },
        //                          new Section()
        //                          {
        //                              Instructor = "Randy Connoly",
        //                              Type = "TUT",
        //                              Day = "W",
        //                              Start = "1:00 PM",
        //                              End = "1:50 PM",
        //                              Location = "B215"
        //                          }
        //                      }
        //                  },
        //			 new Course()
        //			{
        //				CourseId = 6,
        //				SectionId = 67890,
        //				Subject = "HIST",
        //				CourseNumber = 1101,
        //				Title = "Europe to 1500",
        //                      Sections = new List<Section>
        //                      {
        //                          new Section()
        //                          {
        //                              Instructor = "Jordan Pratt",
        //                              Type = "LEC",
        //                              Day = "T",
        //                              Start = "2:00 PM",
        //                              End = "3:20 PM",
        //                              Location = "T234"
        //                          },
        //                          new Section()
        //                          {
        //                              Instructor = "Randy Connoly",
        //                              Type = "LEC",
        //                              Day = "R",
        //                              Start = "2:00 PM",
        //                              End = "3:20 PM",
        //                              Location = "T234"
        //                          },
        //                          new Section()
        //                          {
        //                              Instructor = "Randy Connoly",
        //                              Type = "TUT",
        //                              Day = "M",
        //                              Start = "11:00 AM",
        //                              End = "11:50 AM",
        //                              Location = "B215"
        //                          },
        //                          new Section()
        //                          {
        //                              Instructor = "Randy Connoly",
        //                              Type = "TUT",
        //                              Day = "M",
        //                              Start = "10:00 AM",
        //                              End = "10:50 AM",
        //                              Location = "B215"
        //                          },
        //                          new Section()
        //                          {
        //                              Instructor = "Randy Connoly",
        //                              Type = "TUT",
        //                              Day = "W",
        //                              Start = "1:00 PM",
        //                              End = "1:50 PM",
        //                              Location = "B215"
        //                          }
        //                      }
        //                  }
        //		}
        //	}
        //};

        public CourseRepository()
        {
            loadCourseGroups(url);
            loadCourseSections(url);
        }

        private void loadCourseGroups(String url)
        {
            WebClient courseRequest = new WebClient();
            String coresJson = courseRequest.DownloadString(url + "core");
            String gnedsJson = courseRequest.DownloadString(url + "gned");
            String electivesJson = courseRequest.DownloadString(url + "electives");

            CourseGroup coresGroup = JsonConvert.DeserializeObject<CourseGroup>(coresJson);
            CourseGroup gnedsGroup = JsonConvert.DeserializeObject<CourseGroup>(gnedsJson);
            CourseGroup electivesGroup = JsonConvert.DeserializeObject<CourseGroup>(electivesJson);
            
            courseGroups.Add(coresGroup);
            courseGroups.Add(gnedsGroup);
            courseGroups.Add(electivesGroup);
        }

        private void loadCourseSections(String url)
        {
            WebClient sectionRequest = new WebClient();
            string courseSections = "";
            courseGroups.ForEach(delegate (CourseGroup group) {
                System.Diagnostics.Debug.WriteLine("starting" + group.Title);
                group.CourseGrouping.ForEach(delegate (Course course) {
                    courseSections = sectionRequest.DownloadString(url + "sections/" + Convert.ToString(course.CourseId));
                    course.Sections = JsonConvert.DeserializeObject<List<Section>>(courseSections);
                    var test = "";
                });
                System.Diagnostics.Debug.WriteLine("finishing" + group.Title);
            });
        }

        public List<Course> GetAllCourses()
		{
			IEnumerable<Course> courses =
				from courseGroup in courseGroups
				from course in courseGroup.CourseGrouping

				select course;
			return courses.ToList<Course>();
		}

		public Course GetCourseById(int CourseId)
		{
			IEnumerable<Course> courses =
				from courseGroup in courseGroups
				from course in courseGroup.CourseGrouping
				where course.CourseId == CourseId
				select course;
			return courses.FirstOrDefault();
		}
		public List<CourseGroup> GetGroupedCourses()
		{
			return courseGroups;
		}
		public List<Course> GetCoursesForGroup(int courseGroupId)
		{
			var group = courseGroups.Where(h => h.CourseGroupId == courseGroupId).FirstOrDefault();

			if (group != null)
			{
				return group.CourseGrouping;
			}
			return null;
		}
	}
}