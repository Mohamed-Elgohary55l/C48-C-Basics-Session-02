using System.Net.NetworkInformation;

namespace sec2_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 Create a Book class 
            //book b1 = new book();
            //b1.title = "100 ways to cook potatos";
            //b1.pages = 100;
            //object b1Obj = b1;
            //Console.WriteLine(b1Obj.ToString());
            #endregion
            #region Q1 another answer Create a Book class 
            //book b1 = new book();
            //b1.title = "100 ways to cook potatos";
            //b1.pages = 100;
            //object b1Obj = b1;
            //Console.WriteLine($"title is :{b1.title} , number of padges = {b1.pages}");
            #endregion
            #region Q2 print the result of calling ToString(), Equals()(compare book with itself), GetHashCode(), and GetType() on book.
            //book b1 = new book();
            //b1.title = "100 ways to cook potatos";
            //b1.pages = 100;
            //Console.WriteLine(b1.ToString());
            //Console.WriteLine(b1.Equals(b1));
            //Console.WriteLine(b1.GetHashCode());
            //Console.WriteLine(b1.GetType());
            #endregion
            #region Q3 Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.
            /*
             1- Compile-time error — you can't put text (string) into an int variable.
            ans: false -> syntax error
       
             */


            #endregion

            #region   Q4 Write code that divides 10 by 0 inside a try block, catches the exception
            //int x = 10, y = 0;
            //try
            //{
            //    Console.WriteLine(x / y);

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("done");
            //}

            #endregion

            #region  Q5 Declare an int pages = 300; then store it in a double variable without using a cast.

            //int x = 300;
            //double y = x;




            #endregion

            #region Q6 Given string pagesText = "464";, convert it into an int using the Convert class.

            //double price = 49.99;
            //int iprice = Convert.ToInt32(price);

            #endregion

            #region Q7 Declare a double price = 49.99; then convert it into an int using a cast.
            //double price = 49.99;
            //int iprice = (int)price;
            #endregion
            #region Q8 Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = "abc";, use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.

            //string yearText = "2023" ,badText = "abc";

            //int iYearTect = int.Parse(yearText);
            //int.TryParse(badText, out int ibadText);


            #endregion

            #region Q9 Given int pages = 464;, convert it into a string using ToString() and print its type using GetType() to prove it's now a string.
            //int pages = 464;string spages = pages.ToString();
            //Console.WriteLine(spages.GetType());



            #endregion
            #region Q10 Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int variable, and print both.
            //int copies = 100;
            //Object ob = copies;
            //int resetOb = (int)ob;
            //Console.WriteLine(ob);
            //Console.WriteLine(resetOb);

            #endregion






        }
    }
    }
