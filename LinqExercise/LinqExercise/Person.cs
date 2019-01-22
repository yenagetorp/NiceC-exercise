using System;
using System.Collections.Generic;
using System.Text;

namespace LinqExercise
{
    class Person
    {
        public string Name { get; set; }
        public DateTime NameDay { get; set; }

        public static Person FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(';');
            if (values.Length != 3)
            {
                return null;
            }
            else
            {
                Person person = new Person();
                person.Name = values[0];
                //person.NameDay = Convert.ToDateTime(values[1]);
                person.NameDay = DateTime.Parse(values[1]);

                return person;
            }
        }


    }

}
