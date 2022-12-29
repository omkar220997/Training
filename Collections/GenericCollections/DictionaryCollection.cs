using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    internal class DictionaryCollection
    {
        Dictionary<string, Object> dictionaryCollections = new Dictionary<string, object>();
        public void AddStudentInfo()
        {
            dictionaryCollections.Add("Omkar Kadam", 8080770371);
            dictionaryCollections.Add("Pankaj Mahale", 9146555111);
            dictionaryCollections.Add("Shubham jadhav", 9511555111);
            dictionaryCollections.Add("Suraj Saste", 9823615487);
            dictionaryCollections.Add("Sagar Kalbhor", 7879123789);
        }
        public void DisplayStudent()
        {
            foreach(KeyValuePair<string, Object> Info in dictionaryCollections)
            {
                Console.WriteLine("Sutdent Name and mobile number is " +Info);
            }
        }
    }
}
