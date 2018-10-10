using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_KevinThompson
{
    public partial class DisplayQuote : Form
    {
        private DeskQuote deskQuote;

        public DisplayQuote()
        {
            InitializeComponent();
        }

        public void InitializeFields(DeskQuote _deskQuote)
        {
            DeskQuote = _deskQuote;
            lblDate.Text = DeskQuote.quoteDate.ToString("dd-MMM-yyyy");
            lblName.Text = DeskQuote.name;
            lblShippingOption.Text = DeskQuote.shippingOption.ToString() + " Day Shipping";
            lblHeight.Text = DeskQuote.desk.height.ToString();
            lblWidth.Text = DeskQuote.desk.width.ToString();
            lblDepth.Text = DeskQuote.desk.depth.ToString();
            lblDrawer.Text = DeskQuote.desk.drawers.ToString();
            lblMaterial.Text = DeskQuote.desk.material.ToString();
            lblPrice.Text = "$" + DeskQuote.price.ToString();
        }

        internal DeskQuote DeskQuote { get => deskQuote; set => deskQuote = value; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Tag = this;
            mainMenu.Show();
            Close();
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }
    }
}
