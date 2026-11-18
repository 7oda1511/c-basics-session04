//session4 solve
using System;

namespace CSharpAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            double[] prices = { 25.5, 40.0, 33.75 };
            Console.WriteLine(prices[1]);
            #endregion

            #region Question 2
            int[,] shelfCopies = {
                { 3, 5 },
                { 1, 4 }
            };
            Console.WriteLine(shelfCopies[1, 0]);
            #endregion

            #region Question 3
            PrintWelcomeMessage();
            #endregion

            #region Question 4
            PrintBookTitle("Clean Code");
            #endregion

            #region Question 5
            int pages = 400;
            AddBonusPages(pages);
            Console.WriteLine(pages);
            #endregion

            #region Question 6
            double[] discountPrices = { 25.5, 40.0 };
            ApplyDiscount(discountPrices);
            Console.WriteLine(discountPrices[0]);
            #endregion

            #region Question 7
            AddBonusPagesByRef(ref pages);
            Console.WriteLine(pages);
            #endregion

            #region Question 8
            ReplaceArray(ref discountPrices);
            Console.WriteLine(discountPrices.Length);
            #endregion

            #region Question 9
            if (TryGetPrice("Clean Code", out double foundPrice))
            {
                Console.WriteLine(foundPrice);
            }
            #endregion

            #region Question 10
            PrintBookInfo("Clean Code");
            PrintBookInfo("Clean Code", 464);
            #endregion

            #region Question 11
            PrintBookInfo(pages: 464, title: "Clean Code");
            #endregion

            #region Question 12
            PrintAllTitles("Clean Code", "The Pragmatic Programmer", "Refactoring");
            #endregion
        }

        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }

        static void PrintBookTitle(string title)
        {
            Console.WriteLine("Book title: " + title);
        }

        static void AddBonusPages(int pages)
        {
            pages += 50;
        }

        static void ApplyDiscount(double[] prices)
        {
            prices[0] -= 5;
        }

        static void AddBonusPagesByRef(ref int pages)
        {
            pages += 50;
        }

        static void ReplaceArray(ref double[] prices)
        {
            prices = new double[] { 10.0, 12.5, 15.0 };
        }

        static bool TryGetPrice(string title, out double price)
        {
            if (title == "Clean Code")
            {
                price = 25.5;
                return true;
            }
            price = 0;
            return false;
        }

        static void PrintBookInfo(string title, int pages = 300)
        {
            Console.WriteLine($"Title: {title}, Pages: {pages}");
        }

        static void PrintAllTitles(params string[] titles)
        {
            foreach (string title in titles)
            {
                Console.WriteLine(title);
            }
        }
    }
}