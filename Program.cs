using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace assiment2Demo
{
    internal class Program
    {
        

        static void Main(string[] args)
        {

            #region 1
            /* string title = "clean code";

             string upperTitle = title.ToUpper();

             Console.WriteLine(title);
             Console.WriteLine(upperTitle);*/
            #endregion

            #region 2
            string book1 = "Clean Code";
            string book2 = "Clean Code";

            Console.WriteLine(ReferenceEquals(book1, book2));
            #endregion

            #region 3
            StringBuilder sb = new StringBuilder();

            sb.Append("Book List");
            sb.Append(" - Updated");

            Console.WriteLine(sb);
            #endregion
            #region 4
            StringBuilder sb = new StringBuilder();

            sb.Append("Book List");
            sb.Append(" - Updated");

            sb.Replace("Book List", "Library");

            Console.WriteLine(sb);
            #endregion

            #region 5
            string title = "Clean Code";
            int pages = 464;

            string result = "Book: " + title + ", Pages: " + pages;

            Console.WriteLine(result);
            #endregion

            #region 6
            string title = "Clean Code";
            int pages = 464;

            string result = $"Book: {title}, Pages: {pages}";

            Console.WriteLine(result);
            #endregion

            #region 7
            string title = "Clean Code";
            int pages = 464;

            string result = string.Format("Book: {0}, Pages: {1}", title, pages);

            Console.WriteLine(result);
            #endregion
            #region question1
            /* int pages = 464;
             bool isAvailable = true;
             if(pages>300&& isAvailable)
             {
                 Console.WriteLine("You can borrow this book");
             }*/
            #endregion

            #region question2
            /* string title = "Refactoring";
             switch (title)
             {
                 case "Clean Code":
                     Console.WriteLine("Great choice!");
                     break;

                 case "Refactoring":
                     Console.WriteLine("Nice pick!");
                     break;

                 default:
                     Console.WriteLine("Never heard of it");
                     break;
             }*/
            #endregion

            #region question3
            //int pages = 464;
            //string sizaLable = pages > 300 ? "long book" : "short book";
            #endregion

            #region question4
            /*string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"{i+1} : {books[i]}");
            }*/
            #endregion

            #region question5
            /* string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };


             int i = 0;

             while (i < books.Length)
             {
                 Console.WriteLine(books[i]);
                 i++;
             }*/
            #endregion

            #region question6
            /* int i = 3;
             do
             {

                 Console.WriteLine("Checking book...");
                 i--;
             } while (i > 0);*/
            #endregion

            #region question7
            /*string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            foreach (string book in books)
            {
                Console.WriteLine(book);
            }*/
            #endregion

            #region question8
            /* string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };


             for (int i = 0; i < books.Length; i++)
             {
                 if (books[i] == "Refactoring")
                 {
                     break;
                 }

                 Console.WriteLine(books[i]);
             }*/
            #endregion

            #region question9
            /* string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };


             for (int i = 0; i < books.Length; i++)
             {
                 if (books[i] == "The Pragmatic Programmer")
                 {
                     continue;
                 }

                 Console.WriteLine(books[i]);
             }*/
            #endregion

            #region question 10
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            

            void PrintFirstBook()
            {
                if (books.Length == 0)
                {
                    return;
                }

                Console.WriteLine(books[0]);
            }

            PrintFirstBook();
            #endregion





        }
    }
}
