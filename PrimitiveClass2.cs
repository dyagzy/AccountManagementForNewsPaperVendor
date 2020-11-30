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
            list to then predict the one wth the highest prifitibilty
        and to add try cathc or exceptions handlers*/
        public static void WelcomeUser()
        {
            int qty;
            decimal price;
            decimal sales = 0;
            decimal maximumSales;
            decimal minimumSales;
            decimal averageSales;

            /*It is left for me to add each gross sales from each news paer into a 
            list to then predict the one wth the highest prifitibilty*/
            Console.WriteLine("****Welcome to Doshen Newspaper Vendor Account Managemnt Solution*****"); Console.WriteLine();
            Console.WriteLine("****This vendor account management system allows existing newsppaper vendors \t of the following newspapers to enter in their weekly sales records*****");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("**PM News NewsPaper\n**Punch NewsPaper\n**The Sun Newspaper\n**Guardian Newspaper"); Console.WriteLine();
            Console.WriteLine("Are you an existing vendor or a new vendor?");


            // if vendor type is existing customer or new user, then the appication makes a decision based on what type of user

            string venType = Console.ReadLine();
            string venTypeAnswer = venType.ToLower();
            if (venTypeAnswer == "existing")
            {





                Console.WriteLine("How many types of newspaper do you sell?");
                string newsCount = Console.ReadLine();
                int newsPpaperCount = int.Parse(newsCount);
                if (newsPpaperCount >= 1)
                {
                    for (int i = 1; i <= newsPpaperCount; i++)
                    {

                        Console.WriteLine("Enter name of the " + i + "  " + "newspaper");
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
            //New vendor registration
            try
            {

                if (venTypeAnswer == "new")
                {
                    Console.WriteLine("You are required to register as a new user");
                    Console.WriteLine("Would you like to register?");
                    string regAnswer = Console.ReadLine();
                    string regAnswerLower = regAnswer.ToLower();
                    if (regAnswerLower == "yes")
                    {
                        Console.WriteLine(" Please enter your name below");
                        string newUserRegName = Console.ReadLine();
                        Console.WriteLine(" Please enter your Phone number below");
                        string newUserRegPhone = Console.ReadLine();
                        Console.WriteLine(" Please enter at least one newspaper name from the list belowe that you would like to sell");
                        Console.WriteLine("**PM News NewsPaper\n**Punch NewsPaper\n**The Sun Newspaper\n**Guardian Newspaper"); Console.WriteLine();
                        string newUserRegNewsPaperName = Console.ReadLine();
                        Console.ReadLine();
                        //string [] newUserRegNewsPaperNameArray =  new string [] ()newUserRegNewsPaperName.ToArray<string>();
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}
