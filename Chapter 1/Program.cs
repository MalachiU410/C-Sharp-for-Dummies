using System;
namespace Program1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Declare a decimal variable
            decimal m1 = 100; // Good 
            decimal m2 = 100M; // Better 
                               // The first declaration above creates a vairiable m1 and intializes it the the value of 100 
                               // 100 is aslo a type of int thus c # must convert the int into a decimal type before performing the intialization
                               // The declaration of m2 is initialized with the decimal constant 100M
                               // The letter M at the end of the number specifies that constant is the type decimal (no conversion is required 
                               // Checking out character type
                               // The char variable is a box capable of holding a single character
                               // A character constant appears as a character surrounded by a pair of single quotation marks 
            char c = 'a';
            // The string type
            // Declare now, intitialize later string someString1;
            string someString1 = "This is a string";
            // or initialize when declared - preferable
            string someString2 = "this is a string";
            // The following is not legal 
            string someString = "This is a line and so is this";
            // However the following is legal 
             someString = "This is a line \and so is this";
            // The + operator concatenates two strings into one 
            string s = "this is a phrase" + "and so is this";
            // the lines of code above set the string variable s equal to this character string
            // "this is a phrase and so is this"
            // The string with no character displayed as ("") is a valid string called an empty string (or sometimes refered to as null string)
            // a null string ("") is different from a null char ('\o)
            // and from a string containing any amount of space even one (" ")
            // Best practice is to initialize strings using the "String.Empty" value
            // Which is the same thing as "" and less prone to misinterpretation
            string mysecretName = string.Empty; // A property of the string type 
                          // Comparing String and Char 
                          // string ("") multiple characters 
                          // char ('') single characters 
            char c1 = 'a';
            char c2 = 'b';
            //char c3 = c1 + c2;
            // Declare string because above statements do not make sense 
            string S1 = "a";
            string S2 = "b";
            string S3 = "c";
            // Calculating a leap year the algorithm looks like the example below
            // It's a leap year if 
            // year is evenly divisible by 4 
            // and, if it happens to be evenly divisble by 100
            // it's also evenly divisble by 400
            // Due to not having the tools to accomplish the task that way I can ask the DateTime type (which is also a value type like int)
            DateTime thisYear = new DateTime(2011, 1, 1);
            bool isLeapYear = DateTime.IsLeapYear(thisYear.Year);
            // Hello 
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
            DateTime thisMoment = DateTime.Now;
            DateTime anHourFromNow = thisMoment.AddHours(1);
            // You can also extract specific parts of a DateTime
            int year = DateTime.Now.Year; // For example 2007
            DayOfWeek dayofWeek = DateTime.Now.DayOfWeek; // For example Sunday 
            // If you print that DayOfWeek object, it prints something like "Sunday"
            // You can also do other manipulations of DateTimes
            DateTime date = DateTime.Today;
            // Get just the date part 
            TimeSpan time = thisMoment.TimeOfDay;
            // Get just the time part 
            TimeSpan duration = new TimeSpan(3, 0, 0, 0);
            // Specify length in days 
            DateTime threeDaysFromNow = thisMoment.Add(duration);
            // The first two lines just extract portions of information in a DateTime ex. time & date
            // The next two lines add a duration (legnth of time) to a DateTime 
            // A duration differs from a moment in time;
            // You specify (durations) with the TimeSpan class
            // You specify (moments) with DateTime 
            // The third line sets up a TimeSpan of (Three Days, Zero Hours, Zero Minutes, and Zero Seconds 
            // The fourth line adds the three days duration to the DateTime respresenting right now
            // Resulting in a new DateTime whose day component is three greater than the day component for "thisMoment"
            // Subtracting a DateTime from another DateTime (or a TimeSpan from a DateTime) returns a DateTime
            TimeSpan duration1 = new TimeSpan(1, 0, 0); // One hour later.
            // Since Today gives 12:00:00 AM, the following gives 1:00:00 AM:
            DateTime anHourAfterMidnight = DateTime.Today.Add(duration1);
            Console.WriteLine ("An hour after midnight will be {0}", anHourAfterMidnight);
            DateTime midnight = anHourAfterMidnight.Subtract(duration1);
            Console.WriteLine("An hour before 1am is {0}", midnight);
            // The first line of the proceeding code creates a TimeSpan of one hour
            // The second line gets the date (actually, midnight this morning)
            // the adds the one hour span to it, resulting in a DateTime respresenting 1:00 a.m. today
            // The next-to-last line subtracts a one hour duration from 1:00 a.m. to get 12:00 a.m. (midnight)
        }
    }
}
