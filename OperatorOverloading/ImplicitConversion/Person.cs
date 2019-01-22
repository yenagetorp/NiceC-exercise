using System;
using System.Collections.Generic;
using System.Text;

namespace ImplicitConversion
{
    class Person
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public static Person ConvertStringToPerson(string semicolonSepartedString)
        {
            //join; doe; 35, to split string, we do
            string[] personInfo = semicolonSepartedString.Split(';');
            if (personInfo.Length!=3)
            {
                return null;
            }

            return new Person
            {
                FirstName = personInfo[0],
                LastName = personInfo[1],
                Age = int.TryParse(personInfo[2], out int age) ? age : 0
            };


            //implicit operator;
        }


        //implicit operator;

        public static implicit operator Person(string semicolonSepartedString)
        {
            //join; doe; 35, to split string, we do
            string[] personInfo = semicolonSepartedString.Split(';');
            if (personInfo.Length != 3)
            {
                return null;
            }

            return new Person
            {
                FirstName = personInfo[0],
                LastName = personInfo[1],
                Age = int.TryParse(personInfo[2], out int age) ? age : 0
            };

        }

        public static implicit operator string(Person person)
        {
            return $"{person.FirstName} {person.LastName} {person.Age}";
        }
    }
}
