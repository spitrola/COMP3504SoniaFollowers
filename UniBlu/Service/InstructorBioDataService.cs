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
    class InstructorBioDataService
    {
        private static InstructorBioRepository instructorBioRepository = new InstructorBioRepository();

        public List<InstructorBio> GetAllInstructorBios()
        {
            return instructorBioRepository.GetAllInstructorBios();
        }
        public InstructorBio GetInstructorBioById(int Id)
        {
            return instructorBioRepository.GetInstructorBioById(Id);
        }
    }
}