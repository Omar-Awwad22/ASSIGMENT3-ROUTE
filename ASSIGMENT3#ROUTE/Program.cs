using System.Text;

namespace ASSIGMENT3
{
    internal class Program
    {
        #region question3
        // static void PrintWelcomeMessage()
        //{
        //  Console.WriteLine("Welcome to the Library!");
        // }
        #endregion
        #region question 4
        //static void PrintBookTitle(string title)
        //{
        //   Console.WriteLine("Book title: " + title);
        // }
        #endregion
        #region question 5
        // static void AddBonusPages(int pages)
        // {
        //    pages += 50;
        //  }
        #endregion
        #region question 6
        // static void ApplyDiscount(double[] prices)
        // {
        //    prices[0] -= 5;
        //  }
        #endregion
        #region question 7
        // static void AddBonusPagesByRef(ref int pages)
        // {
        //     pages += 50;
        //   }
        #endregion
        #region question 8
        // static void ReplaceArray(ref double[] prices)
        // {
        //     prices = new double[] { 10.0, 12.5, 15.0 };
        //   }

        #endregion
        #region question 9
        //  static bool TryGetPrice(string title, out double price)
        //    {
        //  if (title == "Clean Code")
        //  {
        // price = 25.5;
        //   return true;
        // }

        //   price = 0;
        //     return false;
        //   }
        #endregion
        #region question 10
        // static void PrintBookInfo(string title, int pages = 300)
        // {
        //     Console.WriteLine($"{title} - {pages} pages");
        //   }
        #endregion
        #region question 11
       // static void PrintAllTitles(params string[] titles)
       // {
           // foreach (string title in titles)
          //  {
         //       Console.WriteLine(title);
       //     }
     //   }

        #endregion

        static void Main(string[] args)
        {
            #region question 1
            //double[] prices = { 25.5, 40.0, 33.75 };

            //Console.WriteLine(prices[1]);
            #endregion
            #region question 2
            //          int[,] shelfCopies =
            //{
            //{ 3, 5 },   // shelf 0
            //  { 1, 4 }    // shelf 1
            //};

            //  Console.WriteLine(shelfCopies[1, 0]);
            #endregion
            #region question 3


            //   PrintWelcomeMessage();
            #endregion
            #region question 4
            //  PrintBookTitle("Clean Code");

            #endregion
            #region question 5
            // int pages = 400;
            // AddBonusPages(pages);
            // Console.WriteLine(pages);

            #endregion
            #region question 6
            // double[] prices = { 25.5, 40.0 };
            // ApplyDiscount(prices);
            //   Console.WriteLine(prices[0]);
            #endregion
            #region question 7
            //int pages = 400;
            //  AddBonusPagesByRef(ref pages);
            //    Console.WriteLine(pages);
            #endregion
            #region question 8
            // double[] prices = { 25.5, 40.0 };
            // ReplaceArray(ref prices);
            //   Console.WriteLine(prices.Length);
            #endregion
            #region question 9
            // if (TryGetPrice("Clean Code", out double price))
            // {
            //    Console.WriteLine(price);
            //  }
            #endregion
            #region question 10
            //   PrintBookInfo(pages: 464, title: "Clean Code");

            #endregion
            #region question 11
          //  PrintAllTitles("Clean Code", "The Pragmatic Programmer", "Refactoring");

            #endregion



        }

    }

}