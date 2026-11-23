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

            #endregion

        }
    }
}

