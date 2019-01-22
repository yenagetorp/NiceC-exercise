using System;
using System.Collections.Generic;
using System.Text;

namespace Övn24
{
    class Person
    {
        public string Name { get; set; }
        public DateTime NameDay { get; set; }

        //public static Person ConvertStringToPerson(string s)
        //{
        //    string[] info = s.Split(';');

        //    return new Person
        //    {
        //        Name = info[0],
        //        NameDay = DateTime.Parse(info[1])
        //    };
        //}

        public static implicit operator Person(string s)
        {
            string[] info = s.Split(';');
            return new Person
            {
                Name = info[0],
                NameDay = DateTime.Parse(info[1])
            };
        }

        public override string ToString()
        {
            if(Name.Length > 7)
                return $"{Name}\t{NameDay.ToShortDateString()}";
            else
                return $"{Name}\t\t{NameDay.ToShortDateString()}";
        }
    }
}
