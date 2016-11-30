using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Http;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using UniBlu.Model;

using Newtonsoft.Json;
using System.Threading.Tasks;

namespace UniBlu.Repository
{
    public class InstructorBioRepository
    {
        // TODO: For proof of concept, we will just add data here, once we get Selenium, scraping,
        // parsing, database live we can make this a call to our database.
        private string url = "http://comp3504uniblu.azurewebsites.net/api/instructors";
        private static List<Instructor> InstructorBioList;

        public InstructorBioRepository ()
        {
            loadInstructorData(url);
        }

        private void loadInstructorData(String url)
        {
            var instructorRequest = new WebClient();
            var json = instructorRequest.DownloadString(url);
            //List<Instructor> InstructorBioList = JsonConvert.DeserializeObject<List<Instructor>>(json);
            InstructorBioList = JsonConvert.DeserializeObject<List<Instructor>>(json);
        }
        

        public List<Instructor> GetAllInstructorBios()
        {
            IEnumerable<Instructor> instructorBioList =
                from instructorBio in InstructorBioList

                select instructorBio;
            return instructorBioList.ToList<Instructor>();
        }

        public Instructor GetInstructorBioById(int Id)
        {
            IEnumerable<Instructor> instructorBioList =
                from instructorBio in InstructorBioList
                where instructorBio.Id == Id
                select instructorBio;
            return instructorBioList.FirstOrDefault();
        }
    }
}