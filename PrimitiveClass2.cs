using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPaperVendor
{
    public class PrimitiveClass2
    {

        /*Here is the final soultion to the vendor Accout management Console App*/
        /*ThIS vendor Accout management Console App allows existing customers to enter in their weekly sales records and also registers a new customer or new vendor before they can use the App*/
        public static void WelcomeUser()
        {
            int qty;
            decimal price;
            decimal sales = 0;
            decimal pmNewssales= 0;
            decimal punchSales = 0;
            decimal gurdianSales = 0;
            decimal theSunsales = 0;
            decimal maximumSales;
            decimal minimumSales;
            decimal averageSales;

           
            Console.WriteLine("****Welcome to Doshen Newspaper Vendor Account Managemnt Solution*****"); Console.WriteLine();
            Console.WriteLine("****This vendor account management system allows existing newsppaper vendors \t of the following newspapers to enter in their weekly sales records*****");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("**PM News NewsPaper\n**Punch NewsPaper\n**The Sun Newspaper\n**Guardian Newspaper"); Console.WriteLine();
            Console.WriteLine("Are you an existing vendor or a new vendor?");


            // If vendor type is existing customer or new user, then the appication makes a decision based on what type of user

            string venType = Console.ReadLine();
            string venTypeAnswer = venType.ToLower();
            if (venTypeAnswer == "existing")
            {

                Console.WriteLine("How many types of newspaper do you sell?");
                string newsCount = Console.ReadLine();
                int newsPpaperCount = int.Parse(newsCount);
                if (newsPpaperCount >= 1)
                {
                    try
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
                                            pmNewssales += sales; //logic not correct yet

                                            salesListPmNews.Add(sales);

                                        }


                                    }
                                    maximumSales = salesListPmNews.Max();
                                    minimumSales = salesListPmNews.Min();
                                    averageSales = salesListPmNews.Average();
                                    Console.WriteLine($" The total sales of PMNews is {pmNewssales} ");
                                    Console.WriteLine($" The first sales of PMNews for position 0 is : {salesListPmNews[0]} ");
                                    Console.WriteLine($" The total sales of PMNews for position 1 is : {salesListPmNews[1]} ");
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
                                            gurdianSales += sales;

                                            salesListGuardian.Add(sales);

                                        }

                                    }
                                    maximumSales = salesListGuardian.Max();
                                    minimumSales = salesListGuardian.Min();
                                    averageSales = salesListGuardian.Average();
                                    Console.WriteLine($" The total sales of PMNews is {gurdianSales} ");
                                    Console.WriteLine($" The first sales of PMNews for position 0 is : {salesListGuardian[0]} ");
                                    Console.WriteLine($" The total sales of PMNews for position 1 is : {salesListGuardian[1]} ");
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
                                            punchSales += sales;

                                            salesListPunch.Add(sales);

                                        }

                                    }
                                    maximumSales = salesListPunch.Max();
                                    minimumSales = salesListPunch.Min();
                                    averageSales = salesListPunch.Average();
                                    Console.WriteLine($" The total sales of PMNews is {punchSales} ");
                                    Console.WriteLine($" The first sales of PMNews for position 0 is : {salesListPunch[0]} ");
                                    Console.WriteLine($" The total sales of PMNews for position 1 is : {salesListPunch[1]} ");
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
                                            theSunsales += sales;

                                            salesListSun.Add(sales);

                                        }
                                    }
                                    maximumSales = salesListSun.Max();
                                    minimumSales = salesListSun.Min();
                                    averageSales = salesListSun.Average();
                                    Console.WriteLine($" The total sales of PMNews is {theSunsales} ");
                                    Console.WriteLine($" The first sales of PMNews for position 0 is : {salesListSun[0]} ");
                                    Console.WriteLine($" The total sales of PMNews for position 1 is : {salesListSun[1]} ");
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
                    catch (Exception)
                    {

                        throw;
                    }
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
                        Console.WriteLine("**PM News NewsPaper\n**Punch NewsPaper\n**The Sun Newspaper\n**Guardian Newspaper \nIf you preferred newspaper is not on the list displayed above then, type YES in capital letters to register you preferred newspapers"); Console.WriteLine();
                        string newUserRegNewsPaperName = Console.ReadLine();

                        //Allows new vendor to register different sets of newspaper not already on the list of what we are selling
                        if (newUserRegNewsPaperName == "YES")
                        {
                            Console.WriteLine("We are happy to have you here as a new newspaper vendor that wants to sell a different type of newspaper from the ones we are already selling at Doshen International");
                            Console.WriteLine( "please tell us how many new type of newspaper you want to sell?");
                            string newNewsPaperListNo = Console.ReadLine();
                            int newNewsPaperListNoInt = int.Parse(newNewsPaperListNo);
                            //creates an array based on the number of the new type of newspaper the new vendor wants ti start selling
                            
                            string[] listOfnewNewsPaper = new string[newNewsPaperListNoInt];
                            Console.WriteLine("Enter the names of the new type of newspapers you want to sell");
                            string NewnewsPaperNames = Console.ReadLine();
                            for (int i = 0; i < listOfnewNewsPaper.Length; i++)
                            {
                                listOfnewNewsPaper[i] = Convert.ToString(Console.ReadLine());


                            }

                            foreach (var item in listOfnewNewsPaper)
                            {
                                Console.WriteLine(item);    
                            }

                           

                        }
                       
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
