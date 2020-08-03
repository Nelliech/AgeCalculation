using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace AgeCalculation
{
    public class File
    {
    
        private const string FILE_PATH =@"Age.csv";
        protected List<Person> people = new List<Person>();
        private List<String> lines = System.IO.File.ReadAllLines(FILE_PATH, Encoding.UTF8.GetString(Encoding.GetEncoding("iso-8859-1").GetBytes(temp))).ToList();
        public File()
        {
                
        }

        

        public void FileToPerson()
        {
            foreach (var line in lines)
            {
                string[] entries = line.Split(',');

                Person newPerson=new Person();

                newPerson.FirstName = entries[0];
                newPerson.LastName = entries[1];
                newPerson.Age = Convert.ToInt32(entries[2]);

                people.Add(newPerson);
                
            }
        }

        public object GivePeoples()
        {
            return people;
        }

    }
}
