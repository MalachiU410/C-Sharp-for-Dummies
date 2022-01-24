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
            Console.WriteLine("An hour after midnight will be {0}", anHourAfterMidnight);
            DateTime midnight = anHourAfterMidnight.Subtract(duration1);
            Console.WriteLine("An hour before 1am is {0}", midnight);
            // The first line of the proceeding code creates a TimeSpan of one hour
            // The second line gets the date (actually, midnight this morning)
            // the adds the one hour span to it, resulting in a DateTime respresenting 1:00 a.m. today
            // The next-to-last line subtracts a one hour duration from 1:00 a.m. to get 12:00 a.m. (midnight)
            // Every expression has a value and a type
            // In a declaration such as "int n" you can easily see that the variable "n" is an int
            // Further you can reasonably assume that the type of calculation of n + 1 is an int
            // However what type if the constant 1 ?
            // The type of constant depends on two things its value and the presence of an optional descriptor at the end of the constant 
            // Any integer type less than 2 billion is assumed to be an int 
            // Numbers larger than 2 billion are assumed to be a long
            // Any floating-point number is assumed to be a double
            // 1 = int
            // 1u = unsigned int
            // 1L = long int
            // 1.0 = double 
            // 1.0F = float 
            // 1M = decimal
            // true = bool
            // false = bool
            // 'a' = char 
            // '\n' = char (the character new line)
            // '\x123' = char (the character whose numeric value is a hex 123)
            // hex = (hexadecimal) numbers in base 16 rather than 10
            // Convert an int into a long
            int intValue = 10;
            long longValue;
            longValue = intValue; // This is okay
            // An int can be stored into a long because any possible value of an int can be stored in a long
            // and because they are both counting numbers
            // The conversion that takes place automatically without command is called an implict conversion
            // A conversion in the opposite direction can cause problems
            // For example this line is illegal
            long longValue = 10;
            int intValue;
            intValue = longValue // This is illegal
            // It is illegal because when converting a long into an int data can be lost
            // So C # will generate an error code for this matter
            // If you know that the value won't exceed int numerical limitation you can override the system
            // With a cast
            long longValue 10;
            int intValue;
            intValue = (int)longValue; // This is now legal
            // To use a cast you must place the name of the type you want in parentheses and put it immediately in front of the value you want to convert
            // This cast forces C # to convert the long named longValue into an int and assumes you know what you are doing
            // A counting number can be converted into a floating-point number automatically
            // But converting a floating-point into a counting number requires a cast
            double doubleValue = 10.0;
            long longValue = (long)doubleValue;
            // All conversions to and from a decimal requires a cast
            // In fact, all numeric types can be converted into all other numeric types through the application of a cast
            // Neither bool nor string can be converted directly into the other type
            // When declaring a variable so far we have specified its exact data type like this 
            int i = 5;
            string s = "Hello C#";
            double d = 1.0;
            // You are able to offload some of that work onto the C# compiler using the var keyword
            var i = 5;
            var s = "Hello C# 4.0";
            var d = 1.0;
            // Now the compiler infers the data type for you
            // It looks at the stuff on the right side of the assignment (=) to see what type the left side is
            // The computer mostly does the calculating for you
            // For example you have an expression like this
            var x = 3.0 + 2 - 1.5;
            // The compiler can figure out that (x) is a doubleValue
            // It looks at (3.0) and (1.5) and sees that they're of type double
            // Then it notices that (2) is an int
            // Which the compiler can convert implicitly to a double for the calculation
            // All the additional terms in (x)'s intitialization expression ends up as double types
            // So the inferred type of x is double
            // But now you can simply utter the magic word "var" and supply an initialization expression
            // And the compiler does the rest
            var aVariable = <initialization expression here>;
            // var in C# does not signify a variant type
            // The object you declare with var definitely has a C# data type
            // Such as int, string, or double you just dont have to declare what it is
            var aString = "Hello C# 3.0";
            Console.WriteLine (aString.GetType ().ToString ());
        }
    }
}
