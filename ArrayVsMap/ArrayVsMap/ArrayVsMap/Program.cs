using System;
using System.Collections.Generic;

namespace ArrayVsMap
{
    class Program
    {
        //this is our array. Arrays have a finite size so they are generally better for sets of information that don't change size, like the months of the year for example
        //the arrays items are indexed from 0 to n-1 which makes it easy to increment through
        string[] months;

        //Maps are different than arrays for a couple reasons. Maps are not finite in the way arrays are
        //Maps can continue to be updated as you get more items 
        //You can't shuffle a map like you can an array so maps are more useful for id systems where keys should never be changed
        //for our map example we are going to use a student id system. Using a students id number we can look up their name and potentially whatever other info we would like
        Dictionary<int, string> studentID;
        static void Main()
        {
            //this instantiates our array so we can use it in the code
            string[] months = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            //this instantiates our array so we can use it in the code
            Dictionary<int, string> studentID = new Dictionary<int, string>();

            //this will move through the array printing each month it's own line
            foreach (string month in months)
            {
                Console.WriteLine(month);
            }

            //adds sample students to the map
            studentID.Add(123456, "John Johnson");
            studentID.Add(654321, "Tim Timothy");
            studentID.Add(615243, "Samatha Samson");

            //print each student and their id numbers
            foreach (var pair in studentID)
            {
                int idNumber = pair.Key;
                string studentName = pair.Value;

                Console.WriteLine("Student Name: " + studentName + " ID Number: " + idNumber);
            }

            Console.ReadLine();
        }
    }
}
