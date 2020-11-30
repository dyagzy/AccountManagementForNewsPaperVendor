using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPaperVendor
{
    public class PrimitiveClasses
    {
        /* This is  not the right solution sir, see PrimitiveClasses2 for the final solution*/
        public static void  UserPrompt()
        {
            Console.WriteLine("How many types of newspapers do you sell?");
            string typesOfNewsPpaer = Console.ReadLine();
            int countOfNewsPpaer = int.Parse(typesOfNewsPpaer);
            if (countOfNewsPpaer > 1)
            {
                Console.WriteLine("Enter the name of the first newspaper");
                string name1 = Console.ReadLine();
                Console.WriteLine("Enter the quantity  sold of the first newspaper");
                string qty1 = Console.ReadLine();
                Console.WriteLine("Enter the selling price of the first newspaper");
                string price1 = Console.ReadLine();

                Console.WriteLine("Enter the name of the second newspaper");
                string name2 = Console.ReadLine();
                Console.WriteLine("Enter the quantity  sold of the second newspaper");
                string qty2 = Console.ReadLine();
                Console.WriteLine("Enter the selling price of the second newspaper");
                string price2 = Console.ReadLine();


                
            }
            Console.WriteLine("***Enter the name of the Newspaper type you would like to enter its weekly record from the list shown***");
            Console.WriteLine("PM News \nGuardian\nPunch\nThe Sun");
            string select = Console.ReadLine();
            string typeSelected = select.ToLower();
            Console.WriteLine("");

            

                switch (typeSelected)
                {

                    case "pm news":
                        decimal salesPerTypePmNews;
                        decimal salesAverage;
                        Console.WriteLine("please enter the week number:");
                        int weekIdPmNews = int.Parse(Console.ReadLine());

                        Console.Write("please enter the quantity of newspaper sold:");
                        decimal qtyPmNews = decimal.Parse(Console.ReadLine());

                        Console.WriteLine("please enter the sellling price of the newspaper sold:");
                        decimal pricePmNews = decimal.Parse(Console.ReadLine());
                        salesPerTypePmNews = pricePmNews * qtyPmNews;
                    for (decimal i = 0; i <= 6; i++)
                    {

                    }

                        List<decimal> salesList = new List<decimal>();

                        foreach (var sales in salesList)
                        {
                            salesList.Add(salesPerTypePmNews);
                        }
                        salesAverage = salesList.Average();
                        Console.WriteLine("The sales from {0} is : {1:c}", typeSelected, salesPerTypePmNews);
                        Console.WriteLine("The average sales of {0} newspaper  is : {1:c}", typeSelected, salesAverage);

                        Console.ReadLine();



                        break;
                    case "guardian":
                        decimal salesPerTypeGuardian;

                        Console.WriteLine("please enter the week number:");
                        int weekIdGuardian = int.Parse(Console.ReadLine());
                        Console.WriteLine("please enter the quantity of newspaper sold:");
                        decimal qtyGuardian = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("please enter the sellling price of the newspaper sold:");
                        decimal priceGuardian = decimal.Parse(Console.ReadLine());
                        salesPerTypeGuardian = priceGuardian * qtyGuardian;
                        Console.WriteLine("The sales from {0} is : {1:c}", typeSelected, salesPerTypeGuardian);
                        Console.ReadLine();

                        break;
                    case "punch":
                        decimal salesPerTypePunch;

                        Console.WriteLine("please enter the week number:");
                        int weekIdPunch = int.Parse(Console.ReadLine());
                        Console.WriteLine("please enter the quantity of newspaper sold:");
                        decimal qtyPunch = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("please enter the sellling price of the newspaper sold:");
                        decimal pricePunch = decimal.Parse(Console.ReadLine());
                        salesPerTypePunch = pricePunch * qtyPunch;
                        Console.WriteLine("The sales from {0} is : {1:c}", typeSelected, salesPerTypePunch);
                        Console.ReadLine();

                        break;
                    case "the sun":
                        decimal salesPerTypeSun;

                        Console.WriteLine("please enter the week number:");
                        int weekIdSun = int.Parse(Console.ReadLine());
                        Console.WriteLine("please enter the quantity of newspaper sold:");
                        decimal qtySun = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("please enter the sellling price of the newspaper sold:");
                        decimal priceSun = decimal.Parse(Console.ReadLine());
                        salesPerTypeSun = priceSun * qtySun;
                        Console.WriteLine("The sales from {0} is : {1:c}", typeSelected, salesPerTypeSun);
                        Console.ReadLine();

                        break;
                    default:
                        break;
                }

           
        }

       
        
    }
}
