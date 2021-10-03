using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_1._0
{
    //This class will define the attributes of a quote including Desk, rush days, customer name, and quote date. This class will also hold the logic in determining the desk quote total.
    class DeskQuote
    {
        private int QuotePrice;
        private string QuoteName;
        Desk desk;
        //quote date


        private int CalculateQuote()
        {
            //temp
            int Area;
            int WidthSave;
            int DepthSave;
            int DrawersSave;
            int MaterialSave;
            int RushOrderSave;
            //temp

            WidthSave = desk.getWidth();
            DepthSave = desk.getDepth();
            DrawersSave = desk.getDrawers();
            MaterialSave = desk.getMaterial();
            RushOrderSave = desk.getRush();

            int Total = 200;

            Area = WidthSave * DepthSave;

            Total += Area;

            Total += DrawersSave * 50;

            switch (MaterialSave)
            {
                case 0:
                    Total += 200;
                    break;
                case 1:
                    Total += 100;
                    break;
                case 2:
                    Total += 50;
                    break;
                case 3:
                    Total += 300;
                    break;
                case 4:
                    Total += 125;
                    break;

                default:
                    Total += 50;
                    break;
            }

            switch (RushOrderSave)
            {
                case 0:
                    if (Area < 1000)
                        Total += 60;
                    else if (Area > 2000)
                        Total += 80;
                    else
                        Total += 70;
                    break;
                case 1:
                    if (Area < 1000)
                        Total += 40;
                    else if (Area > 2000)
                        Total += 60;
                    else
                        Total += 50;
                    break;
                case 2:
                    if (Area < 1000)
                        Total += 30;
                    else if (Area > 2000)
                        Total += 40;
                    else
                        Total += 35;
                    break;

                default:
                    Total += 0;
                    break;
            }
            return Total;
        }

        public void SetQuotePrice()
        {
            QuotePrice = CalculateQuote();
        }

        public int getQuotePrice()
        {
            return QuotePrice;
        }
    }
}
