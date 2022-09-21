using System.Text;

namespace Gr_44_ConsoleAppStringBuilding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //************************************* APPEND *******************************************

            //First example. This program uses StringBuilder to build up a buffer of characters.
            //We call Append() to add more data to our StringBuilder.

            //Part 1 We create a StringBuilder class instance (an object) by using the new-operator.      
            //Part 2 We call Append(). This method can be called directly on its own result, in the same statement.
            //Info Append(), and other methods like AppendFormat, return the same StringBuilder.

            // Part 1: create new StringBuilder and loop.

            //StringBuilder builder = new StringBuilder();
            //for (int i = 0; i <3; i++)
            //{
            //    builder.Append(i).Append("");
            //    // Part 2: append to StringBuilder.
            //}
            //Console.WriteLine(builder);
            //// Part 2: append to StringBuilder.


            //********************************** APPENDFORMAT ***********************************************

            //AppendFormat.With this method, we add text to a StringBuilder based on a pattern.
            //We can use substitution markers to fill fields in this pattern.
            //var builder = new StringBuilder();
            //builder.AppendFormat("R: {0} ({1}).", "ABC", 1);
            //Console.WriteLine(builder);


            //********************************** REPLACE **********************************************



            StringBuilder builder3 = new StringBuilder(
            "This is an example string that is an example.");
            builder3.Replace("an", "the"); // Replaces 'an' with 'the'.
            Console.WriteLine(builder3);

            //Replace. This method replaces all instances of one string with another.
            //A string is required, but we do not need to use a string literal.
            //The example exchanges "an" with "the."

            //Warning The Replace method will replace all instances of the specified value.
            //To replace one instance, we will need a custom method.

            // Replaces 'an' with 'the'.




            //**************************** LOOPS ****************************************************



            string[] items = { "Cat", "Dog", "Celebrity" };

            StringBuilder builder4 = new StringBuilder(
            "These items are required:").AppendLine();

            foreach (string item in items)
            {
                builder4.Append(item).AppendLine();
            }
            Console.WriteLine(builder4);

            //Loops. Often we use StringBuilders in loops.
            //If many appends are needed, sometimes
            //StringBuilder is helpful in other contexts.
            //Here is an example of StringBuilder in a foreach-loop.
            //Note
            //Many looping constructs, including for, while and foreach, are effective when used with StringBuilder.



            //************************** INDEXER ***********************************************************

            StringBuilder builder5 = new StringBuilder();
            builder5.Append("cat");

            // Write second letter.
            Console.WriteLine(builder5[1]);

            // Change first letter.
            builder5[0] = 'r';
            Console.WriteLine(builder5.ToString());




            //******************************* REMOVE ***********************************************************

            StringBuilder builder6 = new StringBuilder("Dot Net Csharp");
            builder6.Remove(4, 3);
            Console.WriteLine(builder6);

            //This method removes a range of characters by index
            //from the internal buffer.
            //As with other StringBuilder methods, this just rearranges the internal buffer.

            //string starsString = "";
            //DateTime stringStart = DateTime.Now;

            //for (int i = 0; i < 10000; i++)
            //{
            //    starsString += "*";
            //}

            //DateTime stringEnd = DateTime.Now;

            //StringBuilder sb = new StringBuilder();
            //DateTime sbStart = DateTime.Now;

            //for (int i = 0; i < 10000; i++)
            //{
            //    sb.Append("*");
            //}

            //DateTime sbEnd = DateTime.Now;

            //Console.WriteLine($"string time: {stringEnd - stringStart}");
            //Console.WriteLine($"StringBuilder time: {sbEnd - sbStart}");

        }
    }
}
