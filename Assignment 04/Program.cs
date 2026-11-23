using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01
            //Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print
            //the second price(index 1).
            //double[] prices = { 25.5, 40.0, 33.75 };
            //Console.WriteLine(prices[1]);
            #endregion
            #region Question 02

            //Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and
            //shelf 1 has 1, 4 copies.Print the number of copies on shelf 1, slot 0.

            //int[,] shelfCopies = { { 3, 5 }, { 1, 4 } };
            //Console.WriteLine(shelfCopies[1, 0]);
            #endregion
            #region Question 03
            //Write a method called PrintWelcomeMessage that takes no parameters and prints
            //"Welcome to the Library!".Call it from Main.
            //void PrintWelcomeMessage()
            //{
            //    Console.WriteLine("Welcome to the Library!");
            //}
            //PrintWelcomeMessage();
            #endregion
            #region Question 04
            //Write a method PrintBookTitle(string title) that prints "Book title: " + title.Call it with
            ////"Clean Code".
            //void PrintBookTitle(string title)
            //{
            //    Console.WriteLine("Book title: " + title);
            //}
            //PrintBookTitle("GudFuther");
            //PrintBookTitle("Clean Code");
            #endregion
            #region Question 05
            //Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable
            //int pages = 400; and print pages afterward. What do you expect to see, and why?
            //int AddBonusPages(int pages)
            //{
            //    pages += 50;
            //    return pages;
            //}
            //int pages = 400;
            //pages = AddBonusPages(pages);//page = 400 and AddBonusPages = 50 //it add 400 to 50 and return it to pages 
            //Console.WriteLine(pages);//400 + 50 = 450
            //// if you don't assign the return value of AddBonusPages pages will remain 400 only
            #endregion
            #region Question 06
            //Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0].Call it
            //with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward.What do you expect to
            //see, and why?
            //double[] ApplyDiscount(double[] prices)
            //{
            //    prices[0] -= 5;
            //    return prices;
            //}
            //double[] prices = { 25.5, 40.0 };
            //prices = ApplyDiscount(prices);
            //Console.WriteLine(prices);
            //Console.WriteLine(prices[0]);//subtract 5 from price becouse i told it that but if i print [1] it dosen't change becouse i don't tolt it that
            #endregion
            #region Question 07
            //Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref.
            //Call it and print pages afterward. How is the result different from question 5 ?

            //int AddBonusPagesByRef(ref int pages)
            //{
            //    pages += 50;
            //    return pages;
            //}
            //int pages = 400;
            //pages = AddBonusPagesByRef(ref pages);
            //Console.WriteLine(pages);
            #endregion
            #region Question 08
            //Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a
            //new array { 10.0, 12.5, 15.0 }.Call it with your prices array and print prices.Length
            //afterward.
            //static void ReplaceArray(ref double[] prices)
            //{
            //    prices = new double[] { 10.0, 12.5, 15.0 };
            //}
            //double[] prices = {};
            //ReplaceArray(ref prices);
            //Console.WriteLine(prices.Length);
            #endregion
            #region Question 09
            //Write a method bool TryGetPrice(string title, out double price) that returns true and sets
            //price to 25.5 if title is "Clean Code", otherwise returns false and sets price to 0.Call it
            //static bool TryGetPrice(string title, out double price)
            //{
            //    if (title == "Clean Code")
            //    {
            //        price = 25.5;

            //        return true;
            //    }

            //        price = 0;
            //        return false;
            //    }
            //    if (TryGetPrice("Clean Code", out double price))
            //    {
            //        Console.WriteLine(price);
            //    }

            //}
            #endregion
            #region Question 10
            //Write a method PrintBookInfo(string title, int pages = 300) where pages is optional.Call
            //it once with only a title, and once passing both a title and pages.

            //static void PrintBookInfo(string title, int pages = 300)
            //{
            //    Console.WriteLine($"Title: {title}, Pages: {pages}");
            //}
            //Console.WriteLine("book");
            //Console.WriteLine("book" +  300);
            #endregion
            #region Question 11
            //Using the PrintBookInfo method from the question above, call it by naming the
            //parameters, passing pages before title

            //void PrintBookInfo(string title, int pages = 300)
            //{
            //    Console.WriteLine($"Title: {title}, Pages: {pages}");
            //}
            //PrintBookInfo(pages: 333, title: "Book");

            #endregion
            #region Question 12

            //Write a method PrintAllTitles(params string[] titles) that prints each title on its own line.
            //Call it with three book titles

            static void PrintAllTitles(params string[] titles)
            {
                foreach (string t in titles)
                {
                    Console.WriteLine(t);
                }
            }

            PrintAllTitles("Book", "The Pragmatic Programmer", "Refactoring");

            #endregion





        }
    }
}


