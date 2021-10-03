using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_1._0
{
    enum DesktopMaterial { Oak = 200, Laminate = 100, Pine = 50, Rosewood = 300, Veneer = 125};

    //This class will define the attributes of the desk object with width, depth, number of drawers, and the surface material.
    public class Desk
    {
        private string Name;
        private int DeskWidth;
        private int DeskDepth;
        private int DeskDrawers;
        private int DeskMaterial;
        private int RushOrder;
        private int DepthMaximum = 48;
        private int DepthMinimum = 12;
        private string QuoteDate;

        public void setName(string First, string Last)
        {
            Name = First + " " + Last;
        }
        public void SetWidth(int Width)
        {
            DeskWidth = Width;
        }
        public void SetDepth(int Depth)
        {
            DeskDepth = Depth;
        }
        public void SetDrawers(int Drawers)
        {
            DeskDrawers = Drawers;
        }
        public void SetMaterial(int Material)
        {
            DeskMaterial = Material;
        }
        public void SetRushOrder(int Rush)
        {
            RushOrder = Rush;
        }

        public void SetDate(string Date)
        {
            QuoteDate = Date;
        }

        public string getName()
        {
            return Name;
        }

        public int getWidth()
        {
            return DeskWidth;
        }

        public int getDepth()
        {
            return DeskDepth;
        }
        public int getDrawers()
        {
            return DeskDrawers;
        }
        public int getMaterial()
        {
            return DeskMaterial;
        }
        public int getRush()
        {
            return RushOrder;
        }
        public string getQuoteDate()
        {
            return QuoteDate;
        }
    }
}
