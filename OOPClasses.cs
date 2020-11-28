using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPaperVendor
{
    public class OOPClasses
    {


        public class NewsPaperWeeklyRecord
        {


            public NewsPaperWeeklyRecord()
            {

            }


            public static int WeekRecord(int weekId, string name)
            {
                List<int> weekNo = new List<int>();
                weekNo.Add(weekId);
                List<string> paperName = new List<string>();
                paperName.Add(name);

                return weekId;
            }

        }

        /* This class handles the bases or common properties that every newspaper has*/

        public class NewsPaper
        {
            public decimal Price { get; set; }
            public string Name { get; set; }
            public NewsPaperType Sales { get; set; }
            public int Quantity { get; set; }


            public int WeekId { get; set; }
        }

        /* This class handles newspaper per type*/

        public class NewsPaperType : NewsPaper
        {
            private int qty;
            private decimal price;
            //decimal salesPerType;
            private decimal totalSalesPerType;
            public decimal TotalSales { get; set; }


            public NewsPaperType()
            {
                Price = price;
                Quantity = qty;

            }


            //total sales per week per newspapre
            public static decimal NewsPaperSales(int qty, decimal price)
            {
                decimal salesPerType;
                decimal averageSales;
                decimal maximumSales;
                decimal minimumSales;
                decimal totalSales = 0;

                salesPerType = price * qty;

                List<decimal> salesAmount = new List<decimal>();
                foreach (var sales in salesAmount)
                {
                    totalSales += salesPerType;


                }
                maximumSales = salesAmount.Max();
                minimumSales = salesAmount.Min();
                averageSales = salesAmount.Average();
                Console.WriteLine($"The maximum sales per newspaper is {maximumSales}");
                Console.WriteLine($"The minimum revenue per newspaper is {minimumSales}");
                Console.WriteLine($"The minimum revenue per newspaper is {averageSales}");
                Console.WriteLine($"The sum of sales per newspaper is : {totalSales}" + "");

                return totalSales;

            }

            /* Calculates total sales per newspaper type*/
            public static decimal TotalSalesPerType(NewsPaperType name)
            {
                int qty = 0;
                decimal price = 0;
                var totalSalesPerType = NewsPaperSales(qty, price);


                return totalSalesPerType;

            }

            /* calculates the total revenue per week of all the newspaper sold for that week*/
            public static decimal RevenuePerWeeek(NewsPaperType name, int weekId, params decimal[] sales)
            {
                decimal totalRevenuePerWeek = 0;
                decimal maximumRevenue;
                decimal minimumRevenue;
                decimal averageRevenue;

                foreach (var salesPerNewsPaper in sales)
                {
                    totalRevenuePerWeek += salesPerNewsPaper;

                }
                maximumRevenue = sales.Max();
                minimumRevenue = sales.Min();
                averageRevenue = sales.Average();
                Console.WriteLine($"The maximum revenue per week is {maximumRevenue}");
                Console.WriteLine($"The minimum revenue per week is {minimumRevenue}");
                Console.WriteLine($"The average revenue per week is {averageRevenue}");

                return totalRevenuePerWeek;
            }
        }

        /* This class handles compuation of sales of newspaper per week per type*/

        public class NewsPaperSales
        {
            public NewsPaperSales(int weekId)
            {
                this.WeekId = weekId;
            }

            public int WeekId { get; set; }
            public decimal Sales { get; set; }

            public NewsPaperType NewsPaperQty { get; set; }

        }

        public class NewsPaperCost
        {
            public NewsPaperCost()
            {

            }

        }

        public class NewsPaperForcast
        {
            public NewsPaperForcast()
            {

            }

        }
    }
}
