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
            int x = 10, y = 0;
            try
            {
                Console.WriteLine(x / y);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }






            #endregion








        }
    }
}
