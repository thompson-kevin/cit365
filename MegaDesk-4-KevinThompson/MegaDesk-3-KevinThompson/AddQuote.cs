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
    public partial class AddQuote : Form
    {
        Desk newDesk = new Desk();

        public AddQuote()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void btnSaveDesk_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxDrawers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        

        private void ValidateDepth(object sender, EventArgs e)
        {
            int possibleNewWidth = newDesk.ValidateIntInput(tbDepth.Text);
            if (newDesk.ValidateWidth(possibleNewWidth) && possibleNewWidth != -1)
            {
                newDesk.depth = possibleNewWidth;
                lblInvalidDepth.Visible = false;
                lblInvalidDepthBetween.Visible = false;
            }
            else if (!newDesk.ValidateWidth(possibleNewWidth) && possibleNewWidth != -1)
            {
                lblInvalidDepth.Visible = true;
                lblInvalidDepthBetween.Visible = true;
            }
            else if (possibleNewWidth == -1)
            {
                // error
            }
        }

        private void ValidateHeight(object sender, KeyPressEventArgs e)
        {
            int possibleNewHeight = newDesk.ValidateIntInput(tbHeight.Text);
            if (possibleNewHeight != -1)
            {
                newDesk.height = possibleNewHeight;
                lblInvalidHeight.Visible = false;
            }
            else if (possibleNewHeight == -1)
            {
                lblInvalidHeight.Visible = true;
            }
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
    }
}
