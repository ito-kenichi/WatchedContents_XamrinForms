using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace check_to_travel_xamarin_forms
{
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public int PersonID { get; set; }
        public string Name { get; set; }

        public Person()
        {
        }
    }
}
