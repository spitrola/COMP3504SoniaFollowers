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
    public class InstructorBioDataService
    {
        private static InstructorBioRepository instructorBioRepository = new InstructorBioRepository();

        public List<Instructor> GetAllInstructorBios()
        {
            return instructorBioRepository.GetAllInstructorBios();
        }
        public Instructor GetInstructorBioById(int Id)
        {
            return instructorBioRepository.GetInstructorBioById(Id);
        }
    }
}