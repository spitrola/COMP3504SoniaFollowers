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
	class CourseRepository
	{
		private static List<CourseGroup> courseGroups = new List<CourseGroup>()
		{
			new CourseGroup()
			{
				CourseGroupId = 0,
				Title = "Core Courses",
				CourseGrouping = new List<Course>()
				{
					new Course()
					{
						CourseId = 0,
						SectionId = 12345,
						Subject = "COMP",
						CourseNumber = 1501,
                        Title = "Introduction to Programming",
						days = null,
						Instructor = "Jordan Kidney",
						Location = "B215"
                    },
					new Course()
					{
						CourseId = 1,
						SectionId = 67890,
						Subject = "COMP",
						CourseNumber = 1501,
                        Title = "Introduction to Programming",
						days = null,
						Instructor = "Jordan Kidney",
						Location = "B215"
                    }
				}
			},
			new CourseGroup()
			{
				CourseGroupId = 1,
				Title = "GNED",
				CourseGrouping = new List<Course>()
				{
					new Course()
					{
						CourseId = 3,
						SectionId = 67890,
						Subject = "COMP",
						CourseNumber = 1501,
                        Title = "Introduction to Programming",
						days = null,
						Instructor = "Jordan Kidney",
						Location = "B215"
                    },
					new Course()
					{
						CourseId = 4,
						SectionId = 67890,
						Subject = "COMP",
						CourseNumber = 1501,
                        //Section = 001,
                        Title = "Introduction to Programming",
						days = null,
						Instructor = "Jordan Kidney",
						Location = "B215"
                    }
				}
			},
			new CourseGroup()
			{
				CourseGroupId = 2,
				Title = "Electives",
				CourseGrouping = new List<Course>()
				{
					new Course()
					{
						CourseId = 5,
						SectionId = 67890,
						Subject = "COMP",
						CourseNumber = 1501,
						Title = "Introduction to Programming",
						days = null,
						Instructor = "Jordan Kidney",
						Location = "B215"
                    },
					 new Course()
					{
						CourseId = 6,
						SectionId = 67890,
						Subject = "COMP",
						CourseNumber = 1501,
						Title = "Introduction to Programming",
						days = null,
						Instructor = "Jordan Kidney",
						Location = "B215"
                    }
				}
			}
		};

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