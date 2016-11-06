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
        private static List<Instructor> InstructorBioList = new List<Instructor>()
        {
            new Instructor()
            {
                Id = 1,
                Name = "Jordan Kidney",
                Bio = "Jordan Kidney has been teaching at MRU since 2011. His teaching interests include introduction and advanced programming, systems architecture and operating systems and web development.  Jordan’s research interests include Artificial Intelligence, specializing in machine learning and multi-agent systems. His personal interests include tattoos and body modification culture.",
                ImagePath = "http://www.mtroyal.ca/cs/groups/public/documents/image/faculty_bio_jorkidney.jpg",
            },
            new Instructor()
            {
                Id = 2,
                Name = "Mingwei Gong",
                ImagePath = "http://www.mtroyal.ca/cs/groups/public/documents/image/ssdata_csis_bio_mgong.jpg",
                Bio = "Mingwei Gong is an Associate Professor in the Department of Mathematics and Computing at Mount Royal University. He received his B.Eng. degree in computer engineering from Tianjin University, Tianjin, China, in 2001, and the M.Sc. and Ph.D. degrees in Computer Science from the University of Calgary, in 2003 and 2009, respectively. His research interests are in computer networking, resource allocation, and network security."
            },
            new Instructor()
            {
                Id = 3,
                Name = "Ricardo Hoar",
                ImagePath = "http://www.mtroyal.ca/cs/groups/public/documents/image/maco_rhoar_bio_2015.jpg",
                Bio = "Ricardo has been teaching at Mount Royal University since 2007. His teaching interests include introductory programming, computational thinking, software engineering, app and web development. Ricardo's research interests include web development, mobile computing and multi-agent systems as well as the application of information systems to a variety of domains including art, biology and transportation. He is currently working on a textbook on the foundations of web development. His consulting company maintains and develops websites and he has over a dozen games in Apple's app store."
            },
            new Instructor()
            {
                Id = 4,
                Name = "Jordan Pratt",
                ImagePath = "http://www.mtroyal.ca/cs/groups/public/documents/image/ssdata_csisbio_jpratt.jpg",
                Bio = "Jordan has been supporting students and instructors for the department since 2002. He very much enjoys helping students work through programming problems, playing boardgames, and referring to himself in the third person."
            }
        };

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