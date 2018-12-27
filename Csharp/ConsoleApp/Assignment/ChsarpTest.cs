using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Assignment
{
    public class ChsarpTest
    {
        public void Test()
        {
            Console.WriteLine("===Assignment Start===");
            Console.WriteLine("\n");
            // 1. string & stringBuilder		
            Console.WriteLine("===== 1. string & stringBuilder ======");

            string s = "During the development of the .NET Framework";
            s += "the class libraries were originally written";
            s += "using a managed code compiler system called";
            s += "Simple Managed C (SMC)";

            // assignment: change above using StringBuilder
            // 1. StringBuilder class is in different namespace. Therefore, you will have to type "using System.Text" very top of the line.
            // 2. namespace is contatiner where multiple classes reside. Please search c# namespace

            StringBuilder sb = new StringBuilder("During the development of the .NET Framework");
            sb.Append("the class libraries were originally written");
            sb.Append("using a managed code compiler system called");
            sb.Append("Simple Managed C (SMC)");

            Console.WriteLine(sb);
            Console.WriteLine("\n");

            // 2. double array
            Console.WriteLine("===== 2. double array ======");
            // assignment: define array type of double, size of 13. 
            //Initialize any double value. Then use for-loop statement to print out 13 values.

            double[] doubleArray = new double[13] { 3.4, 4.5, 6.7, 30.4, 90, 12.03, 12.3, 14, 34.78, 1.2, 3.4, 5.6, 7.0 };

            for (int i = 1; i < doubleArray.Length + 1; i++)
            {
                Console.WriteLine("Value of {0} st element : {1}", i, doubleArray[i - 1]);
            }
            Console.WriteLine("\n");


            // 3. string type has very useful methods which is used very often.
            Console.WriteLine("===== 3. string method ======");
            string s2 = "South and North Korea will be reunited very soon";
            // assignment: using s2 variables, test all methods of string. e.g Console.WriteLine(s2.Trim()); Console.WriteLine(s2.substring(3,6)); ...


            // Reference : https://www.completecsharptutorial.com/csharp-articles/csharp-string-function.php
            Console.WriteLine("1) Clone(): Make clone of string.");
            Console.WriteLine("s2.Clone()");
            Console.WriteLine(s2.Clone());
            Console.WriteLine("\n");

            Console.WriteLine("2) CompareTo(): Compare two strings and returns integer value as output. " +
                "It returns 0 for true and 1 for false.");
            string s3 = "South and North Korea will be reunited later   ";
            Console.WriteLine("s2.CompareTo(s3)");
            Console.WriteLine(s2.CompareTo(s3));
            Console.WriteLine("\n");



            Console.WriteLine("3) Contains(): The C# Contains method checks whether specified character or " +
                "string is exists or not in the string value.");
            Console.WriteLine("s2.Contains(\'k\');");
            Console.WriteLine(s2.Contains('k'));
            Console.WriteLine("s2.Contains(\'K\')");
            Console.WriteLine(s2.Contains('K'));
            Console.WriteLine("\n");



            Console.WriteLine("4) EndsWith():This EndsWith Method checks whether specified character is the last character of string or not.");
            Console.WriteLine("s2.EndsWith(\"m\");");
            Console.WriteLine(s2.EndsWith("m"));

            Console.WriteLine("s2.EndsWith(\"n\");");
            Console.WriteLine(s2.EndsWith("soon"));
            Console.WriteLine("\n");

            Console.WriteLine("5) Equals():The Equals Method in C# compares two string and returns Boolean value as output.");
            Console.WriteLine("s2.Equals(s3)");
            Console.WriteLine(s2.Equals(s3));
            Console.WriteLine("\n");


            Console.WriteLine("6) GetHashCode(): This method returns HashValue of specified string.");
            Console.WriteLine("s2.GetHashCode();");
            Console.WriteLine(s2.GetHashCode());
            Console.WriteLine("\n");

            Console.WriteLine("7) GetType(): It returns the System.Type of current instance.");
            Console.WriteLine("s2.GetType();");
            Console.WriteLine(s2.GetType());
            Console.WriteLine("\n");

            Console.WriteLine("8) GetTypeCode(): It returns the Stystem.TypeCode for class System.String.");
            Console.WriteLine("s2.GetTypeCode()");
            Console.WriteLine(s2.GetTypeCode());
            Console.WriteLine("\n");

            Console.WriteLine("9) IndexOf(): Returns the index position of first occurrence of specified character.");
            Console.WriteLine("s2.IndexOf(\'K\')");
            Console.WriteLine(s2.IndexOf('K'));
            Console.WriteLine("\n");

            Console.WriteLine("10) ToLower(): Converts String into lower case based on rules of the current culture.");
            Console.WriteLine("s2.ToLower();");
            Console.WriteLine(s2.ToLower());
            Console.WriteLine("\n");

            Console.WriteLine("11) ToUpper(): Converts String into Upper case based on rules of the current culture.");
            Console.WriteLine("s2.ToUpper();");
            Console.WriteLine(s2.ToUpper());
            Console.WriteLine("\n");


            Console.WriteLine("12) Insert(): Insert the string or character in the string at the specified position.");
            Console.WriteLine("s2.Insert(0,\"From my point of view,\")");
            Console.WriteLine(s2.Insert(0, "From my point of view, "));
            Console.WriteLine("\n");

            Console.WriteLine("13) IsNormalized(): This method checks whether this string is in Unicode normalization form C.");
            Console.WriteLine("s2.IsNormalized();");
            Console.WriteLine(s2.IsNormalized());
            Console.WriteLine("\n");



            Console.WriteLine("14) LastIndexOf(): Returns the index position of last occurrence of specified character.");
            Console.WriteLine("s2.LastIndexOf(\'o\')");
            Console.WriteLine(s2.LastIndexOf('o'));
            Console.WriteLine("\n");

            Console.WriteLine("15) Length: It is a string property that returns length of string.");
            Console.WriteLine("s2.Length");
            Console.WriteLine(s2.Length);
            Console.WriteLine("\n");


            Console.WriteLine("16) Remove(): This method deletes all the characters from beginning to specified index position..");
            Console.WriteLine("s2.Remove(30)");
            Console.WriteLine(s2.Remove(30));
            Console.WriteLine("\n");


            Console.WriteLine("17) Replace(): This method replaces the character.");
            Console.WriteLine("s2.Replace(\'K\',\'C\')");
            Console.WriteLine(s2.Replace("K", "C"));
            Console.WriteLine("\n");

            Console.WriteLine("18) Split()	This method splits the string based on specified value.");
            Console.WriteLine("s2.Split('d')[0]");
            Console.WriteLine(s2.Split('d')[0]);

            Console.WriteLine("s2.Split('d')[1]");
            Console.WriteLine(s2.Split('d')[1]);
            Console.WriteLine("\n");

            Console.WriteLine("19) StartsWith(): It checks whether the first character of string is same as specified character.");
            Console.WriteLine("s2.StartsWith(\"m\")");
            Console.WriteLine(s2.StartsWith("m"));
            Console.WriteLine("s2.StartsWith(\"S\")");
            Console.WriteLine(s2.StartsWith("S"));
            Console.WriteLine("\n");


            Console.WriteLine("20) Substring(): This method returns substring.");
            Console.WriteLine("s2.Substring(5)");
            Console.WriteLine(s2.Substring(5));
            Console.WriteLine("\n");


            Console.WriteLine("21) ToCharArray(): Converts string into char array.");
            Console.WriteLine("s2.ToCharArray()");
            Console.WriteLine(s2.ToCharArray());
            Console.WriteLine("\n");

            Console.WriteLine("22) Trim(): It removes extra whitespaces from beginning and ending of string.");
            string s4 = " Today is Boxing Day  ";
            Console.WriteLine("s4");
            Console.WriteLine(s4);
            Console.WriteLine("s4.Trim()");
            Console.WriteLine(s4.Trim());
            Console.WriteLine("\n");



            // 4. Type Conversion
            Console.WriteLine("===== 4. Type Conversion ======");
            // assingment use the link -->  https://code-maze.com/csharp-basics-type-conversion/ and print out the result. (copy and paste is fine)

            Console.WriteLine("(1) Implicit Conversion");
            double b = 12.45;
            Console.WriteLine("double b : {0}", b);
            int x = 10;
            Console.WriteLine("int x : {0}", x);
            b = b + x;
            Console.WriteLine("b = b + x;");
            Console.WriteLine("b : {0}", b);
            Console.WriteLine("\n");

            Console.WriteLine("(2) Explicit Conversion");
            int u = 34;
            int v = 3;

            double uv = (double)u / v;
            Console.WriteLine("int u : {0}", u);
            Console.WriteLine("int v : {0}", v);
            Console.WriteLine("double uv = (double)u / v;");
            Console.WriteLine("uv : {0}", uv);
            Console.WriteLine("\n");

            Console.WriteLine("(3) Using the Convert Class");
            int m = 17;
            string n1 = Convert.ToString(m);
            string n2 = m.ToString();

            Console.WriteLine("n1 : " + n1 + " " + "n2: " + n2);
            Console.WriteLine("\n");


            // 5. int Type
            Console.WriteLine("===== 5. int type ======");
            // assinment: 
            Console.WriteLine("1. what is maximum or minimum of int type. Use some method of int type. eg. int.METHODNAME()");

            //int MinValue = -2147483648;
            //int MaxValue = 2147483647;

            int intMax = int.MaxValue;
            int intMin = int.MinValue;

            Console.WriteLine("int intMax : {0}", intMax);
            Console.WriteLine("int intMin : {0}", intMin);
            Console.WriteLine("\n");


            Console.WriteLine("2. What does int.Parse() method do? show example");
            string thisYear = "2018";
            int intParseEx1 = Int32.Parse(thisYear);
            Console.WriteLine("string thisYear = \"2018\";");
            Console.WriteLine("int intParseExample = Int32.Parse(thisYear);");
            Console.WriteLine("int intParseExample : {0} ", intParseEx1);
            Console.WriteLine("int intParseExample + 100 : {0} ", intParseEx1 + 100);
            Console.WriteLine("\n");



            Console.WriteLine("3. What is the difference between int.Parse() and int.TryParse()? show example.");

            // Both methods are used to convert a string representation of number to an integer.  
            // In case of the string can’t be converted, 
            // *** the int.Parse() throws an exceptions where as int.TryParse() return a bool value, false. ***
            // Reference : https://dailydotnettips.com/back-to-basic-difference-between-int-parse-and-int-tryparse/

            string stringNull = null;
            string stringDouble = "100.37";

            //int intParseEx2 = Int32.Parse(stringNull);

            int result;
            bool intTryParse1 = Int32.TryParse(stringNull, out result);
            bool intTryParse2 = Int32.TryParse(stringDouble, out result);
            bool intTryParse3 = Int32.TryParse(thisYear, out result);

            Console.WriteLine("string stringNull = \"null\";");
            Console.WriteLine("int intParseEx2 = Int32.Parse(stringNull); <- error occured (uncomment line 264)");
            //Console.WriteLine("int intParseEx2 : {0} ", intParseEx2);
            Console.WriteLine("\n");

            Console.WriteLine("int result;");
            Console.WriteLine("bool intTryParse1 = Int32.TryParse(stringNull, out result);");
            Console.WriteLine("bool intTryParse1 : {0} ", intTryParse1);
            Console.WriteLine("bool intTryParse2 = Int32.TryParse(stringDouble, out result);");
            Console.WriteLine("bool intTryParse2 : {0} ", intTryParse2);
            Console.WriteLine("bool intTryParse3 = Int32.TryParse(thisYear, out result);");
            Console.WriteLine("bool intTryParse3 : {0} ", intTryParse3);
            Console.WriteLine("\n");

            Console.WriteLine("4. Above rule can be applied to float type as well. show examples");
            //float floatParseEx1 = float.Parse(stringNull);
            float resultF;
            bool floatTryParse1 = float.TryParse(stringNull, out resultF);
            bool floatTryParse2 = float.TryParse(stringDouble, out resultF);
            bool floatTryParse3 = float.TryParse(thisYear, out resultF);



            Console.WriteLine("float resultF;");
            Console.WriteLine("bool floatTryParse1 = float.TryParse(stringNull, out resultF);");
            Console.WriteLine("bool floatTryParse1  : {0} ", floatTryParse1);
            Console.WriteLine("bool floatTryParse2 = float.TryParse(stringDouble, out resultF);");
            Console.WriteLine("bool floatTryParse2  : {0} ", floatTryParse2);
            Console.WriteLine("bool floatTryParse3 = float.TryParse(thisYear, out resultF);");
            Console.WriteLine("bool floatTryParse3  : {0} ", floatTryParse3);
            Console.WriteLine("\n");


            // 6. datetime Type
            Console.WriteLine("===== 6. DateTime type ======");
            // assignment: Exercise all methods of DateTime and show result using Console.WriteLine
            DateTime today = new DateTime(2018, 12, 26);
            DateTime tomorrow = new DateTime(2018, 12, 27);

            Console.WriteLine("DateTime today = new DateTime (2018, 12, 26);");
            Console.WriteLine("today: {0}", today);
            Console.WriteLine("\n");


            Console.WriteLine("1) Add");

            TimeSpan sevenDays = new System.TimeSpan(7, 0, 0, 0);
            today.Add(sevenDays);
            Console.WriteLine("TimeSpan sevenDays = new System.TimeSpan(7, 0, 0, 0);");
            Console.WriteLine("today.Add(sevenDays) : {0}", today.Add(sevenDays));
            Console.WriteLine("\n");

            Console.WriteLine("2) AddDays");
            today.AddDays(3.7);
            Console.Write("today.AddDays(3.7): {0}", today.AddDays(3.7));
            Console.WriteLine("\n");

            Console.WriteLine("3) AddHours");
            today.AddHours(27.45);
            Console.Write("today.AddHours(27.45): {0}", today.AddHours(27.45));
            Console.WriteLine("\n");

            Console.WriteLine("4) AddMilliseconds");
            today.AddMilliseconds(3892.90);
            Console.Write("today.AddMilliseconds(3892.90): {0}", today.AddMilliseconds(3892.90));
            Console.WriteLine("\n");


            Console.WriteLine("5) AddMinutes");
            today.AddMinutes(793.58);
            Console.Write("today.AddMinutes(793.58): {0}", today.AddMinutes(793.58));
            Console.WriteLine("\n");

            Console.WriteLine("6) AddMonths");
            today.AddMonths(6);
            Console.Write("today.AddMonths(6): {0}", today.AddMonths(6));
            Console.WriteLine("\n");

            Console.WriteLine("7) AddSeconds");
            today.AddSeconds(3892.90);
            Console.Write("today.AddSeconds(3892.90): {0}", today.AddSeconds(3892.90)); // Compare to 4) AddMilliseconds
            Console.WriteLine("\n");

            Console.WriteLine("8) AddTicks");
            // A number of 100-nanosecond ticks. The value parameter can be positive or negative.
            today.AddTicks(1700000000);
            Console.Write("today.AddTicks(1700000000): {0}", today.AddTicks(1700000000));
            Console.WriteLine("\n");

            Console.WriteLine("9) AddYears");
            today.AddYears(17);
            Console.WriteLine("today.AddYears(17): {0}", today.AddYears(17));
            Console.WriteLine("\n");

            Console.WriteLine("10) Compare");
            int compareDate = DateTime.Compare(today, tomorrow);
            Console.WriteLine("int compareDate = DateTime.Compare(today, tomorrow);");
            Console.WriteLine("int compareDate : {0} ", compareDate);
            Console.WriteLine("\n");


            Console.WriteLine("11) CompareTo(DateTime)");
            today.CompareTo(tomorrow);
            Console.WriteLine("today.CompareTo(tomorrow);");
            Console.WriteLine("today.CompareTo(tomorrow) + 100 : {0}", today.CompareTo(tomorrow) + 100);
            Console.WriteLine("today.CompareTo(tomorrow) - 100 : {0}", today.CompareTo(tomorrow) - 100);
            Console.WriteLine("today.CompareTo(tomorrow) / 100 : {0}", today.CompareTo(tomorrow) / 100);
            Console.WriteLine("today.CompareTo(tomorrow) * 17.4 : {0}", today.CompareTo(tomorrow) * 17.4);
            Console.WriteLine("\n");

            Console.WriteLine("12) Equals(DateTime)");
            bool dateTimeEquals = today.Equals(tomorrow);
            Console.WriteLine("bool dateTimeEquals = today.Equals(tomorrow);");
            Console.WriteLine("bool dateTimeEquals : {0}", dateTimeEquals);
            Console.WriteLine("\n");


            Console.WriteLine("13) IsDaylightSavingTime");
            bool dateTimeDayLightSavingTime = today.IsDaylightSavingTime();
            Console.WriteLine("bool dateTimeDayLightSavingTime = today.IsDaylightSavingTime();");
            Console.WriteLine("bool dateTimeDayLightSavingTime : {0}", dateTimeDayLightSavingTime);
            Console.WriteLine("\n");

            Console.WriteLine("14) DaysInMonth");
            int daysInMonth = DateTime.DaysInMonth(2019, 1);
            Console.WriteLine("int daysInMonth = DateTime.DaysInMonth(2019, 1);");
            Console.WriteLine("int daysInMonth : {0}", daysInMonth);
            Console.WriteLine("\n");


            Console.WriteLine("15) ToFileTime");
            long toFileTime = today.ToFileTime();
            Console.WriteLine("long toFileTime = today.ToFileTime();");
            Console.WriteLine("long toFileTime : {0}", toFileTime);
            Console.WriteLine("\n");

            Console.WriteLine("16) ToLongDateString, ToShortDateString");
            string toLongDateString = today.ToLongDateString();
            Console.WriteLine("string toLongDateString = today.ToLongDateString();");
            Console.WriteLine("string toLongDateString : {0}", toLongDateString);
            Console.WriteLine("\n");
            string toShortDateString = today.ToShortDateString();
            Console.WriteLine("string toShortDateString = today.ToShortDateString();");
            Console.WriteLine("string toShortDateString : {0}", toShortDateString);
            Console.WriteLine("\n");


            Console.WriteLine("17) ToOADate");
            double toOADate = today.ToOADate();
            Console.WriteLine("double toOADate = today.ToOADate();");
            Console.WriteLine("double toOADate  : {0}", toOADate);
            Console.WriteLine("\n");


            Console.WriteLine("18) ToShortTimeString");
            string ToShortTimeString = today.ToShortTimeString();
            Console.WriteLine("string ToShortTimeString = today.ToShortTimeString();");
            Console.WriteLine("string ToShortTimeString  : {0}", ToShortTimeString);
            Console.WriteLine("\n");


            Console.WriteLine("19) ToLongTimeString");
            string ToLongTimeString = today.ToLongTimeString();
            Console.WriteLine("string ToLongTimeString = today.ToLongTimeString();");
            Console.WriteLine("string ToLongTimeString  : {0}", ToLongTimeString);
            Console.WriteLine("\n");



            Console.WriteLine("20) FromBinary, ToBinary");
            long binLocal = today.ToBinary() + 3000000000;
            DateTime today2 = DateTime.FromBinary(binLocal);

            Console.WriteLine("long binLocal = today.ToBinary() + 3000000000;");
            Console.WriteLine("DateTime today2 = DateTime.FromBinary(binLocal);");
            Console.WriteLine("long binLocal: {0}", binLocal);
            Console.WriteLine("DateTime today2: {0}", today2);
            Console.WriteLine("\n");


            Console.WriteLine("21) FromFileTime");
            long file = today.ToFileTime();
            Console.WriteLine("long file = today.ToFileTime();");
            Console.WriteLine("long file: {0}", file);
            Console.WriteLine("\n");

            Console.WriteLine("22) FromOADate, ToOADate");
            DateTime today3 = DateTime.FromOADate(toOADate + 300);
            Console.WriteLine("DateTime today3 = DateTime.FromOADate(toOADate+300);");
            Console.WriteLine("DateTime today3 : {0}", today3);
            Console.WriteLine("\n");

            Console.WriteLine("23) IsLeapYear");
            int nextYear = 2019;
            bool leapYear = DateTime.IsLeapYear(nextYear);
            Console.WriteLine("int nextYear = 2019;");
            Console.WriteLine("bool leapYear = DateTime.IsLeapYear(nextYear);");
            Console.WriteLine("bool leapYear : {0}", leapYear);
            Console.WriteLine("\n");


            Console.WriteLine("24) ToFileTimeUtc, FromFileTimeUtc");
            long fileUTC = today.ToFileTimeUtc();
            Console.WriteLine("long fileUTC = today.ToFileTimeUtc();");
            Console.WriteLine("long fileUTC: {0}", fileUTC);
            Console.WriteLine("\n");

            DateTime today4 = DateTime.FromFileTimeUtc(fileUTC);
            Console.WriteLine("DateTime today4 = DateTime.FromFileTimeUtc(fileUTC);");
            Console.WriteLine("DateTime today4: {0}", today4);
            Console.WriteLine("\n");


            Console.WriteLine("25) ToUniversalTime");
            DateTime universalTime = today.ToUniversalTime();
            Console.WriteLine("DateTime universalTime = today.ToUniversalTime();");
            Console.WriteLine("DateTime universalTime   : {0}", universalTime);
            Console.WriteLine("\n");

            Console.WriteLine("26) UtcNow");
            DateTime utcNow = DateTime.UtcNow;
            Console.WriteLine("DateTime utcNow = DateTime.UtcNow;");
            Console.WriteLine("DateTime utcNow : {0}", utcNow);
            Console.WriteLine("\n");


            Console.WriteLine("27) GetDateTimeFormats");
            string[] getDateTimeFormatsForToday = today.GetDateTimeFormats();
            Console.WriteLine("string[] getDateTimeFormatsForToday = today.GetDateTimeFormats();");
            Console.WriteLine("string[] getDateTimeFormatsForToday : {0}", getDateTimeFormatsForToday);

            foreach (string format in getDateTimeFormatsForToday)
            {
                Console.WriteLine(format);
            }
            Console.WriteLine("\n");



            // 7. c# operator
            Console.WriteLine("===== 7. c# operator ======");
            // assignment: go to https://www.programiz.com/csharp-programming/operators#compound-assignment 
            // print out the result. (Copy and Paste is fine)

            int myNum = 17;
            Console.WriteLine("int myNum = 17;");
            Console.WriteLine("\n");

            myNum += 5;
            Console.WriteLine("myNum += 5;");
            Console.WriteLine("myNum: {0}", myNum);
            Console.WriteLine("\n");



            myNum -= 8;
            Console.WriteLine("myNum -= 8;");
            Console.WriteLine("myNum: {0}", myNum);
            Console.WriteLine("\n");


            myNum *= 8;
            Console.WriteLine("myNum *= 8;");
            Console.WriteLine("myNum: {0}", myNum);
            Console.WriteLine("\n");


            myNum /= 3;
            Console.WriteLine("myNum /= 3;");
            Console.WriteLine("myNum: {0}", myNum);
            Console.WriteLine("\n");


            myNum %= 3;
            Console.WriteLine("myNum %= 3;");
            Console.WriteLine("myNum: {0}", myNum);
            Console.WriteLine("\n");

            myNum &= 3;
            Console.WriteLine("myNum &= 3;");
            Console.WriteLine("myNum: {0}", myNum);
            Console.WriteLine("\n");

            myNum |= 14;
            Console.WriteLine("myNum |= 14;");
            Console.WriteLine("myNum: {0}", myNum);
            Console.WriteLine("\n");


            myNum ^= 14;
            Console.WriteLine("myNum ^= 12;");
            Console.WriteLine("myNum: {0}", myNum);
            Console.WriteLine("\n");



            myNum <<= 2;
            Console.WriteLine("myNum <<= 2;");
            Console.WriteLine("myNum: {0}", myNum);
            Console.WriteLine("\n");

            myNum >>= 3;
            Console.WriteLine("myNum >>= 3;");
            Console.WriteLine("myNum: {0}", myNum);
            Console.WriteLine("\n");


            //8. access modifier
            Console.WriteLine("===== 8. c# access modifier ======");
            Console.WriteLine("\n");
            // assignment: go to https://www.tutlane.com/tutorial/csharp/csharp-access-modifiers-public-private-protected-internal   
            // print out the result  . (Copy and Paste is fine)
            // NOTE: You may need to create another class file for testing
            // NOTE: among six modifiers, just skip "protected internal" and "private protected"

            Console.WriteLine("1) C# Public Access Modifier");

            User user1 = new User("Dodam Shin", "Toronto", 34); 
            user1.GetUserDetails();
            Console.WriteLine("\n");


            Console.WriteLine("2) C# Private Access Modifier");
            Console.WriteLine("PrivateUser user2 = new PrivateUser(\"Songyi Shin\", \"Seoul\", 32, \"Nurse\" ");
            Console.WriteLine("Error above due to access modifier level");
            Console.WriteLine("\n");

            //PrivateUser user2 = new PrivateUser("elly", "Montreal", 42, "Student");
            //user2.GetPriveUserDetails();

            Console.WriteLine("3) C# Protected Access Modifier");
            //ProtectedUser user3 = new ProtectedUser()
            // Complier Error
            // protected members can only accessible with derived classes
            Console.WriteLine("\n");


            Console.WriteLine("4) C# Internal Access Modifier");
            InternalUser user4 = new InternalUser("Alicia Min", "Taipei", 27, "Lv3");
            user4.GetInternalUserDetails();
            Console.WriteLine("\n");


            // 9.   ?.   (questiong and dot operator)
            // refer to https://stackoverflow.com/questions/28352072/what-does-question-mark-and-dot-operator-mean-in-c-sharp-6-0
            // copy and paste is allowed
            Console.WriteLine("=====9. questiong and dot operator ======");
            Action<string> consoleWrite = null;

            consoleWrite?.Invoke("Test 1");

            consoleWrite = (ss) => Console.WriteLine(ss);

            consoleWrite?.Invoke("Test 2");
            Console.WriteLine("\n");

            // 10. Fibanocci array
            Console.WriteLine("===== 10. Fibanocci array ======");
            int[] fib = new int[9]{0, 1, 1, 2, 3, 5, 8, 13,21};
            // Print out sum of fib array using for or while loop
            // copy and paste is allowed

            Console.WriteLine("int[] fib : {0}", string.Join(",", fib));
            Console.WriteLine("Sum of int Array fib : {0}", sumFib(fib));
            Console.WriteLine("\n");


            // 11. Research "yield return" and make sample code of it 
            // copy and paste is allowed
            Console.WriteLine("===== 11. yield return ======");
            // Yield keyword helps to do custom stateful iteration over a collection
            // 1) Custom interation without temp collection
            // 2) Stateful iteration

            FillValues();
            foreach (int i in RunningTotal())
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

        }

        // #10. Fibanocci array method
        public int sumFib(int[] fibArray)
        {
            if (fibArray[fibArray.Length-1] <= 0)
                return 0;

            int sum = fibArray[0] + fibArray[1];

            for (int i = 2; i <= fibArray.Length - 1; i++)
            {
                fibArray[i] = fibArray[i - 1] + fibArray[i - 2];
                sum += fibArray[i];
            }
            return sum;
        }

        // #11. Yield keyword class
        static List<int> MyList = new List<int>();
        static void FillValues()
        {
            MyList.Add(1);
            MyList.Add(2);
            MyList.Add(3);
            MyList.Add(4);
            MyList.Add(5);
            MyList.Add(6);
        }

        static IEnumerable<int> Filter()
        {
            // WITHOUT YIELD
            /* List<int> temp = new List<int>();

             foreach(int i in MyList)
             {
                 if(i>3) //compare
                 {
                     temp.Add(i);
                 }
             }
             return temp;*/

            // WITH YIELD
            foreach (int i in MyList)
            {
                if (i > 3)
                {
                    yield return i;
                }
            }
        }


        static IEnumerable<int> RunningTotal()
        {
            int runningtotal = 0;
            foreach(int i in MyList)
            {
                runningtotal += i;
                yield return (runningtotal);
            }
        }


    }
}
