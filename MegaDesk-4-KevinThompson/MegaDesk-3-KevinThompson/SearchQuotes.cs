using MegaDesk_4_KevinThompson;
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
    public partial class SearchQuotes : Form
    {
        List<DeskQuote> deskQuotes;

        public SearchQuotes()
        {
            InitializeComponent();
            comboBoxMaterials.DataSource = Enum.GetValues(typeof(Material));
            deskQuotes = FileHelper.FromCsv();
        }

        private void inputHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void comboBoxMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (deskQuotes != null)
            {
                List<DeskQuote> matches = deskQuotes.Where(dq => dq.desk.material.Equals(comboBoxMaterials.SelectedValue)).ToList();
                string matchText = "";
                string row = "Name: {name}" + Environment.NewLine +
                    "Date: {date}" + Environment.NewLine +
                    "Shipping Option: {shippingOption}-Day Shipping" + Environment.NewLine +
                    "Desk Information: " + Environment.NewLine +
                    "Height: {height}" + Environment.NewLine +
                    "Width: {width}" + Environment.NewLine +
                    "Depth: {depth}" + Environment.NewLine +
                    "Drawers: {drawers}" + Environment.NewLine +
                    "Material: {material}" + Environment.NewLine +
                    "Price: {price}" + Environment.NewLine + Environment.NewLine;
                matches.ForEach(match =>
               {
                   matchText += row.Replace("{name}", match.name)
                    .Replace("{date}", match.quoteDate.ToString("dd-MMM-yyyy"))
                    .Replace("{shippingOption}", match.shippingOption.ToString())
                    .Replace("{height}", match.desk.height.ToString())
                    .Replace("{width}", match.desk.width.ToString())
                    .Replace("{depth}", match.desk.depth.ToString())
                    .Replace("{drawers}", match.desk.drawers.ToString())
                    .Replace("{material}", match.desk.material.ToString())
                    .Replace("{price}", match.price.ToString());
               });
                if (matches.Count == 0)
                {
                    matchText = "No Search Results Found";
                }
                tbResults.Visible = true;
                tbResults.Focus();
                tbResults.Text = matchText;
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
