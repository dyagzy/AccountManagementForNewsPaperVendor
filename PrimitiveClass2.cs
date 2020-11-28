using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPaperVendor
{
    public class PrimitiveClass2
    {

        /*It is left for me to add each gross sales from each news paer into a 
            list to then predict the one wth the highest prifitibilty*/
        public static void WelcomeUser()
        {
            int qty;
            decimal price;
            decimal sales = 0;
            decimal maximumSales;
            decimal minimumSales;
            decimal averageSales;

            Console.WriteLine("How many types of newspaper do you sell?");
            string newsCount = Console.ReadLine();
            int newsPpaperCount = int.Parse(newsCount);
            if (newsPpaperCount >= 1)
            {
                for (int i = 1; i <= newsPpaperCount; i++)
                {

                    Console.WriteLine("Enter name of the " + i + "newspaper");
                    string select = Console.ReadLine();
                    string typeSelected = select.ToLower();
                    Console.WriteLine("");

                    switch (typeSelected)
                    {

                        case "pm news":
                            //Console.WriteLine("Enter the name of the first newspaper");
                            Console.WriteLine("How many weeks data do you want to enter for the 1st type of newspaper selected?");
                            string countWeekPmNews = Console.ReadLine();
                            int countOfWeekPmNews = int.Parse(countWeekPmNews);

                            List<decimal> salesListPmNews = new List<decimal>();

                            if (countOfWeekPmNews >= 1)
                            {
                                for (int j = 1; j <= countOfWeekPmNews; j++)
                                {
                                    Console.WriteLine("Enter the quantity  sold for the " + j + " week");
                                    string qtyPerWeek = Console.ReadLine();
                                    qty = int.Parse(qtyPerWeek);
                                    Console.WriteLine("Enter the selling price for  the " + j + " week");
                                    string pricePerWeek = Console.ReadLine();
                                    price = decimal.Parse(pricePerWeek);
                                    sales = qty * price;
                                    sales += sales; //logic not correct yet

                                    salesListPmNews.Add(sales);

                                }


                            }
                            maximumSales = salesListPmNews.Max();
                            minimumSales = salesListPmNews.Min();
                            averageSales = salesListPmNews.Average();
                            Console.WriteLine($" The total sales of PMNews is {sales} ");
                            Console.WriteLine($" The maximum sales of PMNews is {maximumSales} ");
                            Console.WriteLine($" The minimum sales of PMNews is {minimumSales} ");
                            Console.WriteLine($" The average sales of PMNews is {averageSales} ");

                            break;

                        case "guardian":
                            Console.WriteLine("How many weeks data do you want to enter for the 1st type of newspaper selected?");
                            string countWeekGuardian = Console.ReadLine();
                            int countOfWeekGuardian = int.Parse(countWeekGuardian);
                            List<decimal> salesListGuardian = new List<decimal>();

                            if (countOfWeekGuardian >= 1)
                            {
                                for (int k = 1; k <= countOfWeekGuardian; k++)
                                {
                                    Console.WriteLine("Enter the quantity  sold for the " + k + " week");
                                    string qtyPerWeek = Console.ReadLine();
                                    qty = int.Parse(qtyPerWeek);
                                    Console.WriteLine("Enter the selling price for  the " + k + " week");
                                    string pricePerWeek = Console.ReadLine();
                                    price = decimal.Parse(pricePerWeek);
                                    sales = qty * price;
                                    sales += sales;

                                    salesListGuardian.Add(sales);

                                }

                            }
                            maximumSales = salesListGuardian.Max();
                            minimumSales = salesListGuardian.Min();
                            averageSales = salesListGuardian.Average();
                            Console.WriteLine($" The total sales of PMNews is {sales} ");
                            Console.WriteLine($" The maximum sales of PMNews is {maximumSales} ");
                            Console.WriteLine($" The minimum sales of PMNews is {minimumSales} ");
                            Console.WriteLine($" The average sales of PMNews is {averageSales} ");

                            break;
                        case "punch":
                            Console.WriteLine("How many weeks data do you want to enter for the 1st type of newspaper selected?");
                            string countWeekpunch = Console.ReadLine();
                            int countOfWeekPunch = int.Parse(countWeekpunch);
                            List<decimal> salesListPunch = new List<decimal>();
                            if (countOfWeekPunch >= 1)
                            {
                                for (int l = 1; l <= countOfWeekPunch; l++)
                                {
                                    Console.WriteLine("Enter the quantity  sold for the " + l + " week");
                                    string qtyPerWeek = Console.ReadLine();
                                    qty = int.Parse(qtyPerWeek);
                                    Console.WriteLine("Enter the selling price for  the " + l + " week");
                                    string pricePerWeek = Console.ReadLine();
                                    price = decimal.Parse(pricePerWeek);
                                    sales = qty * price;
                                    sales += sales;

                                    salesListPunch.Add(sales);

                                }

                            }
                            maximumSales = salesListPunch.Max();
                            minimumSales = salesListPunch.Min();
                            averageSales = salesListPunch.Average();
                            Console.WriteLine($" The total sales of PMNews is {sales} ");
                            Console.WriteLine($" The maximum sales of PMNews is {maximumSales} ");
                            Console.WriteLine($" The minimum sales of PMNews is {minimumSales} ");
                            Console.WriteLine($" The average sales of PMNews is {averageSales} ");


                            break;

                        case "the sun":
                            Console.WriteLine("How many weeks data do you want to enter for the 1st type of newspaper selected?");
                            string countWeeksun = Console.ReadLine();
                            int countOfWeekSun = int.Parse(countWeeksun);
                            List<decimal> salesListSun = new List<decimal>();
                            if (countOfWeekSun >= 1)
                            {
                                for (int m = 1; m <= countOfWeekSun; m++)
                                {
                                    Console.WriteLine("Enter the quantity  sold for the " + m + " week");
                                    string qtyPerWeek = Console.ReadLine();
                                    qty = int.Parse(qtyPerWeek);
                                    Console.WriteLine("Enter the selling price for  the " + m + " week");
                                    string pricePerWeek = Console.ReadLine();
                                    price = decimal.Parse(pricePerWeek);
                                    sales = qty * price;
                                    sales += sales;

                                    salesListSun.Add(sales);

                                }
                            }
                            maximumSales = salesListSun.Max();
                            minimumSales = salesListSun.Min();
                            averageSales = salesListSun.Average();
                            Console.WriteLine($" The total sales of PMNews is {sales} ");
                            Console.WriteLine($" The maximum sales of PMNews is {maximumSales} ");
                            Console.WriteLine($" The minimum sales of PMNews is {minimumSales} ");
                            Console.WriteLine($" The average sales of PMNews is {averageSales} ");

                            break;

                        default:
                            break;

                    }
                    //Console.ReadLine();
                }
                Console.ReadLine();

            }

        }

    }
}
