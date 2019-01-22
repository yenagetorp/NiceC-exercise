using System;
using System.Collections.Generic;
using System.Text;

namespace Repetitionmed_H
{
    enum TagType
    {
        None,
        BoldTag,
        ItalicsTag,
        HyperlinkTag,
    }
   abstract class Person
    {
        protected int fingerprint; 
        //* Man kan ha fler constructor beror på vilken sort instans, och vilket värde man vill tilldela.
        public int Age { get; set; }
        public string Name { get; set; }
        public Person(int age)
        {
            Age = age;
        }
        public Person()
        {

        }
        public Person(string name)
        {
            Name = name;
        }

        //public Person(int age, string name)
        //{
        //    Age = age;
        //    Name = name;
        //}

            // is the same as the following. The following anropa en anna constructor som ta name som parameter.
        public Person(int age, string name): this (name)
        {
            Age = age;
        }

        public virtual void CelebrateBirthday()
        {
            Console.WriteLine("Hura hura hura");
        }

        public abstract void OptionalMethod();

       

       
    }
}
