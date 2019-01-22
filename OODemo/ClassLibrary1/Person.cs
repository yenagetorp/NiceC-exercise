using System;

namespace ClassLibrary1
{
    public class Person//man can referera till
    {
        public string name { get; set; }
    }

    internal class Foo// andra classer can not nå.
    {
        public int MyProperty { get; set; }
    }
}
