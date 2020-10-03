using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace MegaDesk_Klein
{
    public partial class AddQuote : Form
    {
        private DeskQuote newQuote = new DeskQuote();
        private Desk newDesk = new Desk();

        public AddQuote()
        {
            InitializeComponent();
        }

        private void AddReturnMainButton_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }

        //Handle the KeyPress event
        private void Depth_KeyPress(object sender, KeyPressEventArgs e)
        {               
            if (!Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                //Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;

                //Display error message
                string errorMessage = "Only digits may be entered";
                this.errorProviderDepth.SetError(DepthInput, errorMessage);
            }
            else
            {
                this.errorProviderDepth.SetError(DepthInput, "");
            }
        }

        private void SubmitOrder_Click(object sender, EventArgs e)
        {
            //Open Display form and close Add Quote form
            DisplayQuote viewDisplayQuote = new DisplayQuote(newQuote, newDesk);
            viewDisplayQuote.Show();
            Close();
        }

        private void Width_Validating(object sender, CancelEventArgs e)
        {
            if (WidthInput.Text != "")
            {
                int width = Convert.ToInt32(WidthInput.Text);
                //string errorMsg; 
                if (width < newDesk.GetWidthMin() || width > newDesk.GetWidthMax())
                {
                    string errorMessage = $"minimum {newDesk.GetWidthMin()} inches and " +
                        $"maximum {newDesk.GetWidthMax()} inches";
                    e.Cancel = true;
                    this.errorProviderWidth.SetError(WidthInput, errorMessage);
                }
                else
                {
                    this.errorProviderWidth.SetError(WidthInput, "");
                }
                newDesk.SetWidth(width);
            }
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            //Get and display today's date
            DateTime today = DateTime.Now;
            string dateToday = today.ToString("MM/dd/yyyy");
            displayDateToday.Text = dateToday;
            newQuote.SetDateToday(dateToday);

            //Focus on name textbox
            this.ActiveControl = NameInput;

            //Fill combo box for material type
            MaterialComboBox.DataSource = Enum.GetValues(typeof(DesktopMaterial));
        }

        private void NameInput_TextChanged(object sender, EventArgs e)
        {
            //Set name
            newQuote.SetName(NameInput.Text);
        }

        private void Width_Validated(object sender, EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            errorProviderWidth.SetError(WidthInput, "");
        }

        private void Depth_Vallidating(object sender, CancelEventArgs e)
        {
            if (WidthInput.Text != "")
            {
                int depth = Convert.ToInt32(DepthInput.Text);
                //string errorMsg; 
                if (depth < newDesk.GetDepthMin() || depth > newDesk.GetDepthMax())
                {
                    string errorMessage = $"minimum {newDesk.GetDepthMin()} inches and " +
                        $"maximum {newDesk.GetDepthMax()} inches";
                    e.Cancel = true;
                    this.errorProviderDepth.SetError(DepthInput, errorMessage);
                }
                else
                {
                    this.errorProviderDepth.SetError(DepthInput, "");
                }
                newDesk.SetDepth(depth);
            }
        }

        private void DrawersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object numberDrawers = DrawersComboBox.SelectedItem;
            int drawers = Convert.ToInt32(numberDrawers);
            newDesk.SetDrawerCount(drawers);           
        }

        private void Material_ComboBox(object sender, EventArgs e)
        {
            Object material = MaterialComboBox.SelectedItem;
            string materialType = Convert.ToString(material);
            newDesk.SetSurfacetype(materialType);
        }

        private void OrderProcessingTimeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object rush = OrderProcessingTimeBox.SelectedItem;
            int days = Convert.ToInt32(rush);
            newDesk.SetOrderDays(days);
        }
    }
}
