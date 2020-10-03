using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Klein
{
    public partial class DisplayQuote : Form
    {
        private DeskQuote newQuote;
        private Desk newDesk;

        public DisplayQuote()
        {
        }

        public DisplayQuote(DeskQuote newQuote, Desk newDesk)
        {
            this.newQuote = newQuote;
            this.newDesk = newDesk;
            InitializeComponent();
        }

        private void DisplayReturnMainButton_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = new MainMenu();
            viewMainMenu.Show();
            Close();
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            //Create new variable names
            int width = newDesk.GetWidth();
            int depth = newDesk.GetDepth();
            int drawerCount = newDesk.GetDrawerCount();
            string surfaceType = newDesk.GetSurfaceType();
            int days = newDesk.GetOrderDays();
        
            //Calculate surface area
            int area = newDesk.CalculateSurfaceArea(width, depth);

            //Calculate surface area cost
            int areaCost = newDesk.CalculateAreaCost(width, depth);

            //Calculate drawer cost
            int drawerCost = newDesk.CalculateDrawerCost(drawerCount);

            //Get desktop material cost
            int desktopCost = newDesk.GetSurfaceCost(surfaceType);

            //Calculate shipping
            int shipping = newDesk.Calculateshipping(days, width, depth);

            //Calculate total cost
            int totalCost = newDesk.CalculateDeskCost(width, depth, drawerCount, surfaceType);

            DisplayDate.Text = Convert.ToString(newQuote.GetDateToday());
            DisplayName.Text = Convert.ToString(newQuote.GetName());
            DisplayWidth.Text = Convert.ToString(newDesk.GetWidth());
            DisplayDepth.Text = Convert.ToString(newDesk.GetDepth());
            DisplayArea.Text = Convert.ToString(area);
            DisplayDrawerCount.Text = Convert.ToString(newDesk.GetDrawerCount());
            DisplayDesktopMaterial.Text = Convert.ToString(newDesk.GetSurfaceType());
            DisplayDays.Text = Convert.ToString(newDesk.GetOrderDays());

            //Right side of form for costs
            DisplayBasePrice.Text = $"${Convert.ToString(newDesk.GetBasePrice())}";
            DisplayAreaCost.Text = $"${Convert.ToString(areaCost)}";
            DisplayDrawerCost.Text = $"${Convert.ToString(drawerCost)}";
            DisplayDesktopCost.Text = $"${Convert.ToString(desktopCost)}";
            DisplayShipping.Text = $"${Convert.ToString(shipping)}";
            DisplayTotalCost.Text = $"${Convert.ToString(totalCost)}";
        }
    }
}
