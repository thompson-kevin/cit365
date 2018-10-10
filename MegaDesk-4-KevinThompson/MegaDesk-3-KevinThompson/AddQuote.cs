using MegaDesk_4_KevinThompson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_KevinThompson
{
    public partial class AddQuote : Form
    {
        Desk newDesk = new Desk();

        public AddQuote()
        {
            InitializeComponent();
            comboBoxMaterials.DataSource = Enum.GetValues(typeof(Material));
            comboBoxDrawers.DataSource = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7};
            comboBoxShippingOption.DataSource = Enum.GetValues(typeof(ShippingOption));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void btnSaveDesk_Click(object sender, EventArgs e)
        {
            if ((newDesk.ValidateIntInput(tbHeight.Text) != -1) && ValidateNameInput() && ValidateDepth() && ValidateHeightInput() && ValidateWidth())
            {
                Enum.TryParse<Material>(comboBoxMaterials.SelectedValue.ToString(), out Material selectedMaterial);
                Enum.TryParse<ShippingOption>(comboBoxShippingOption.SelectedValue.ToString(), out ShippingOption shippingOption);
                int.TryParse(comboBoxDrawers.SelectedValue.ToString(), out int drawerCount);
                newDesk.height = newDesk.ValidateIntInput(tbHeight.Text);
                newDesk.material = selectedMaterial;
                newDesk.drawers = drawerCount;

                DeskQuote deskQuote = new DeskQuote
                {
                    name = tbName.Text,
                    shippingOption = shippingOption,
                    desk = newDesk
                };
                deskQuote.price = deskQuote.CalcPrice();
                deskQuote.quoteDate = DateTime.Now;
                
                FileHelper.ToCsv(deskQuote);

                DisplayQuote displayQuote = new DisplayQuote();
                displayQuote.Tag = this;
                displayQuote.InitializeFields(deskQuote);
                displayQuote.Show();
                Close();
            }
        }

        private void comboBoxDrawers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        

        private void ValidateDepth(object sender, EventArgs e)
        {
            int possibleNewDepth = newDesk.ValidateIntInput(tbDepth.Text);
            if (newDesk.ValidateDepth(possibleNewDepth) && possibleNewDepth != -1)
            {
                newDesk.depth = possibleNewDepth;
                lblInvalidDepth.Visible = false;
                lblInvalidDepthBetween.Visible = false;
            }
            else if (!newDesk.ValidateDepth(possibleNewDepth) && possibleNewDepth != -1)
            {
                lblInvalidDepth.Visible = true;
                lblInvalidDepthBetween.Visible = true;
            }
            else if (possibleNewDepth == -1)
            {
                // error
            }
        }

        private Boolean ValidateDepth()
        {
            int possibleNewDepth = newDesk.ValidateIntInput(tbDepth.Text);
            if (newDesk.ValidateDepth(possibleNewDepth) && possibleNewDepth != -1)
            {
                newDesk.depth = possibleNewDepth;
                lblInvalidDepth.Visible = false;
                lblInvalidDepthBetween.Visible = false;
                return true;
            }
            else
            {
                lblInvalidDepth.Visible = true;
                lblInvalidDepthBetween.Visible = true;
            }
            return false;
        }

        private void ValidateHeight(object sender, KeyPressEventArgs e)
        {
            //int possibleNewHeight = newDesk.ValidateIntInput(tbHeight.Text);
            //if (possibleNewHeight != -1)
            //{
            //    newDesk.height = possibleNewHeight;
            //    lblInvalidHeight.Visible = false;
            //}
            //else if (possibleNewHeight == -1)
            //{
            //    lblInvalidHeight.Visible = true;
            //}
        }

        private void ValidateHeightInput(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                lblInvalidHeight.Visible = false;
            }
            else if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                lblInvalidHeight.Visible = true;
            }
        }

        private Boolean ValidateHeightInput()
        {
            return !lblInvalidHeight.Visible;
        }

        private void ValidateWidth(object sender, CancelEventArgs e)
        {
            int possibleNewWidth = newDesk.ValidateIntInput(tbWidth.Text);
            if (newDesk.ValidateWidth(possibleNewWidth) && possibleNewWidth != -1)
            {
                newDesk.width = possibleNewWidth;
                lblInvalidWidth.Visible = false;
                lblInvalidWidthBetween.Visible = false;
            }
            else if (!newDesk.ValidateWidth(possibleNewWidth) && possibleNewWidth != -1)
            {
                lblInvalidWidth.Visible = true;
                lblInvalidWidthBetween.Visible = true;
            }
            else if (possibleNewWidth == -1)
            {
                lblInvalidWidth.Visible = true;
                lblInvalidWidthBetween.Visible = true;
            }
        }

        private Boolean ValidateWidth()
        {
            return !lblInvalidWidth.Visible;
        }

        private Boolean ValidateNameInput()
        {
            if (tbName.Text.Length > 0)
            {
                blbInvalidNameAndShipping.Visible = false;
                return true;
            }
            else
            {
                blbInvalidNameAndShipping.Visible = true;
                return false;
            }
        }

        private void lblInvalidWidthBetween_Click(object sender, EventArgs e)
        {

        }

        private void lblInvalidDepth_Click(object sender, EventArgs e)
        {

        }

        private void lblInvalidDepthBetween_Click(object sender, EventArgs e)
        {

        }

        private void lblInvalidHeight_Click(object sender, EventArgs e)
        {

        }

        private void lblInvalidWidth_Click(object sender, EventArgs e)
        {

        }

        private void blbInvalidNameAndShipping_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxShippingOption_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
