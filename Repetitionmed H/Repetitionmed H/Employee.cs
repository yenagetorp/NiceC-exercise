using System;
using System.Collections.Generic;
using System.Text;

namespace Repetitionmed_H
{
    enum WeekDay
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday =6,
        Sunday =7,
    }

    //Constructors, looking for Q19 in quiz in week4. very good example!
    internal class Employee : Person
    {
        public Employee(int age, string name):base( age,  name)
        {

        }
        public void EmployeeMethod()
        {
            Name = "John";
            Age = 10;
            fingerprint = 5;
        }
        public bool IsPayDay(WeekDay dayOfWeek)
        {
            //bool yesItIsPayDay == DayOfWeek == 5;
            //return yesItIsPayDay;
            return dayOfWeek == WeekDay.Friday;
        }
        public override void CelebrateBirthday()
        {
            Console.WriteLine("Hura hura hura och bonus!");
        }

        public override void OptionalMethod()
        {
            Console.WriteLine("Nu gör vi flera saker");
        }

        public void GenericMethod<T>(T t)
        {
        }
        //Original method
        //inparameter is an collection of ints(array)
        public void SelectionSort(int[] collection)
        {
            for (int i = 0; i < collection.Length-1; i++)
            {
                int lowestElementValueIndex = i;
                for (int j = i+1; j < collection.Length; j++)
                {
                    if (collection[j] < collection[lowestElementValueIndex])
                        lowestElementValueIndex = j;
                }

                int temp = collection[i];
                collection[i] = collection[lowestElementValueIndex];
                collection[lowestElementValueIndex] = temp;
            }
        }

       
    } 
}
