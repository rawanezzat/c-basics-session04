namespace c_basics_session04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region session 5 assignment
            Console.WriteLine("assignment session 5");
            Console.WriteLine("-------------------------------------------------------------");


            #region Q1
            Console.WriteLine("---------Q1---------");
            double[] prices = { 25.5, 40.0, 33.75 };
            Console.WriteLine($"The secound price is : {prices[1]}");
            #endregion


            #region Q2
            Console.WriteLine("---------Q2---------");
            int[,] shelfCopies =
                {
                { 3,5},
                { 1,4}
                };
            Console.WriteLine($"the shelf 1 and slot 0 : {shelfCopies[1, 0]}   ");
            #endregion

            #region Q3
            Console.WriteLine("---------Q3---------");
            static void PrintWelcomeMessage()
            {
                Console.WriteLine("Welcome to the Library!");
            }
            PrintWelcomeMessage();
            #endregion

            #region Q4
            Console.WriteLine("---------Q4---------");
            static void PrintBookTitle(string title)
            {
                Console.WriteLine($"Book Title: {title}");
                Console.WriteLine("--------or--------");
                string result = "Book Title: " + title;
                Console.WriteLine(result);
            }
            PrintBookTitle("clean code");
            #endregion

            #region Q5
            Console.WriteLine("---------Q5---------");
            int pages = 400;
            static void AddBonusPages(int pages)
            {
                pages += 50;
                Console.WriteLine($"Total pages with bonus inside the function: {pages}");
            }
            AddBonusPages(pages);
            Console.WriteLine($"Total pages with bonus outside the function: {pages}");
            Console.WriteLine("400 is expected  because  we call by value and  (value type) and not by reference without ref not changing the original value");
            #endregion

            #region Q6
            Console.WriteLine("---------Q6---------");
            double[] prices6 = { 25.5, 40.0 };

            static void ApplyDiscount(double[] prices6)
            {
                prices6[0] -= 5;

            }
            Console.WriteLine($"Price before discount: {prices6[0]}");
            ApplyDiscount(prices6);
            Console.WriteLine($"Price after discount: {prices6[0]}");
            Console.WriteLine("20.5 is expected  because  we call by value and  (reference type) and not by value");

            #endregion

            #region Q7
            Console.WriteLine("---------Q7---------");
            int pages7 = 400;
            static void AddBonusPagesbyRef(ref int pages)
            {
                pages += 50;
                Console.WriteLine($"Total pages with bonus inside the function: {pages}");
            }
            AddBonusPagesbyRef(ref pages7);
            Console.WriteLine($"Total pages with bonus outside the function: {pages7}");
            Console.WriteLine("450 is expected  because  we call by reference and  (value type) and not by value it changes the original value");
            #endregion

            #region Q8
            Console.WriteLine("---------Q8---------");
            double[] prices8 = { 25.5, 40.0 };

            static void ReplaceArray(ref double[] prices8)
            {
                prices8 = new double[] { 10.0,12.5,15.0};
            }

            ReplaceArray(ref prices8);
            Console.WriteLine($"the array lenght is : {prices8.Length}");
            #endregion

            #region Q9
            Console.WriteLine("---------Q9---------");
            double price9 = 0;

            static bool TryGetPrice(string title9, out double price9)
            {
                if (title9 == "clean code")
                {
                    price9 = 25.5;
                    return true;
                }
                else
                {
                    price9 = 0;
                    return false;
                }
            }
            if (TryGetPrice("clean code", out price9))
            {
                Console.WriteLine($"Price of 'clean code': {price9}");
            }
            else 
            {
                Console.WriteLine("Book not found.");
            }
            #endregion

            #region Q10
            Console.WriteLine("---------Q10---------");
            static void PrintBookInfo(string title10, int pages10 = 300)
            {
                Console.WriteLine($"Title: {title10}, Pages: {pages10}");
            }
            Console.WriteLine(" when pages aren't passed");
            PrintBookInfo("clean code");
            Console.WriteLine(" when pages are passed");
            PrintBookInfo("clean code", 400);
            #endregion

            #region Q11
            Console.WriteLine("---------Q11---------");
            static void PrintBookInfo11(string title11, int pages11 = 300)
            {
                Console.WriteLine($"Title: {title11}, Pages: {pages11}");
            }
            Console.WriteLine(" when pages are passed");
            PrintBookInfo11("clean code");
            Console.WriteLine(" when pages aren't passed");
            PrintBookInfo11(pages11: 400, title11: "clean code");

            #endregion

            #region Q12
            Console.WriteLine("---------Q12---------");
            #endregion

            
            static void PrintAllTitles(params string[] titles)
            {
                foreach (var title in titles)
                {
                    Console.WriteLine(title);
                }
            }
            PrintAllTitles("clean code", "the clean coder", "the clean coder 2");

            #endregion
        }
    }
}
