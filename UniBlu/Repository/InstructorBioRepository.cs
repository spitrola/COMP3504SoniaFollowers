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
    public class InstructorBioRepository
    {
        // TODO: For proof of concept, we will just add data here, once we get Selenium, scraping,
        // parsing, database live we can make this a call to our database.
        private static List<InstructorBio> InstructorBioList = new List<InstructorBio>()
        {
            new InstructorBio()
            {
                Id = 1,
                Name = "Jordan Kidney",
                Picture = "To Be Done",
                Bio = "A nice guy despite studying at U o C"
            },
            new InstructorBio()
            {
                Id = 2,
                Name = "Ming Wei Gong",
                Picture = "To Be Done",
                Bio = "Packets of fun"
            },
            new InstructorBio()
            {
                Id = 3,
                Name = "Ricardo Hoar",
                Picture = "To Be Done",
                Bio = "Take a seat, oh wait, I'm the chair"
            },
            new InstructorBio()
            {
                Id = 4,
                Name = "Jordan Pratt",
                Picture = "To Be Done",
                Bio = "King of Selenium, respected by the masses"
            }
        };

        public List<InstructorBio> GetAllInstructorBios()
        {
            IEnumerable<InstructorBio> instructorBioList =
                from instructorBio in InstructorBioList

                select instructorBio;
            return instructorBioList.ToList<InstructorBio>();
        }

        public InstructorBio GetInstructorBioById(int Id)
        {
            IEnumerable<InstructorBio> instructorBioList =
                from instructorBio in InstructorBioList
                where instructorBio.Id == Id
                select instructorBio;
            return instructorBioList.FirstOrDefault();
        }
    }
}