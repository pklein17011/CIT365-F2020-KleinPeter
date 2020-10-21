using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Klein
{
    public class DeskQuote
    {
        public string dateToday = "";
        public string name = "";
        public double deskTotal = 0;

        //Get and set date today
        public string GetDateToday() { return dateToday; }
        public void SetDateToday(string dateToday) { this.dateToday = dateToday; }

        //Get and set customer full name
        public string GetName() { return name; }
        public void SetName(string name) { this.name = name; }

        //Generic constructor
        public DeskQuote()
        {
        }

        //Constructor with variables
        public DeskQuote(string name, string dateToday, double deskTotal)
        {
            this.name = name;
            this.dateToday = dateToday;
        }

        public double CalculateTotalQuote(double width, double depth,
            int drawerCount, string surfaceType, double deliveryCost)
        {
            double deskCost = 1000; // Desk.CalculateDeskCost(width, depth, drawerCount, surfaceType);
            double quoteCost = deskCost + deliveryCost;
            return quoteCost;
        }
    }
}
