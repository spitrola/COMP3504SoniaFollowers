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
    public class CourseDataService
    {
        private static CourseRepository courseRepository = new CourseRepository();

        public List<Course> GetAllCourses()
        {
            return courseRepository.GetAllCourses();
        }
        public List<CourseGroup> GetGroupedCourses()
        {
            return courseRepository.GetGroupedCourses();
        }
        public List<Course> GetCoursesForGroup(int courseGroupId)
        {
            return courseRepository.GetCoursesForGroup(courseGroupId);
        }
        public Course GetCourseById(int courseId)
        {
            return courseRepository.GetCourseById(courseId);
        }
    }
}