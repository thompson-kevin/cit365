namespace MegaDesk_3_KevinThompson
{
    partial class AddQuote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxDrawers = new System.Windows.Forms.ComboBox();
            this.comboBoxMaterials = new System.Windows.Forms.ComboBox();
            this.btnSaveDesk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblInvalidHeight = new System.Windows.Forms.Label();
            this.lblInvalidWidth = new System.Windows.Forms.Label();
            this.lblInvalidWidthBetween = new System.Windows.Forms.Label();
            this.lblInvalidDepthBetween = new System.Windows.Forms.Label();
            this.lblInvalidDepth = new System.Windows.Forms.Label();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.tbDepth = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxShippingOption = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lineSeperator = new System.Windows.Forms.Label();
            this.blbInvalidNameAndShipping = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please fill out the following information:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Height (in)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Width (in)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Depth (in)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Drawers";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Materials";
            // 
            // comboBoxDrawers
            // 
            this.comboBoxDrawers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDrawers.FormattingEnabled = true;
            this.comboBoxDrawers.Location = new System.Drawing.Point(138, 298);
            this.comboBoxDrawers.Name = "comboBoxDrawers";
            this.comboBoxDrawers.Size = new System.Drawing.Size(121, 32);
            this.comboBoxDrawers.TabIndex = 6;
            this.comboBoxDrawers.SelectedIndexChanged += new System.EventHandler(this.comboBoxDrawers_SelectedIndexChanged);
            // 
            // comboBoxMaterials
            // 
            this.comboBoxMaterials.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaterials.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMaterials.FormattingEnabled = true;
            this.comboBoxMaterials.Location = new System.Drawing.Point(138, 336);
            this.comboBoxMaterials.Name = "comboBoxMaterials";
            this.comboBoxMaterials.Size = new System.Drawing.Size(121, 32);
            this.comboBoxMaterials.TabIndex = 7;
            this.comboBoxMaterials.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaterials_SelectedIndexChanged);
            // 
            // btnSaveDesk
            // 
            this.btnSaveDesk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDesk.Location = new System.Drawing.Point(12, 387);
            this.btnSaveDesk.Name = "btnSaveDesk";
            this.btnSaveDesk.Size = new System.Drawing.Size(126, 38);
            this.btnSaveDesk.TabIndex = 8;
            this.btnSaveDesk.Text = "Save Desk";
            this.btnSaveDesk.UseVisualStyleBackColor = true;
            this.btnSaveDesk.Click += new System.EventHandler(this.btnSaveDesk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(357, 387);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 38);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblInvalidHeight
            // 
            this.lblInvalidHeight.AutoSize = true;
            this.lblInvalidHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidHeight.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidHeight.Location = new System.Drawing.Point(243, 193);
            this.lblInvalidHeight.Name = "lblInvalidHeight";
            this.lblInvalidHeight.Size = new System.Drawing.Size(179, 20);
            this.lblInvalidHeight.TabIndex = 16;
            this.lblInvalidHeight.Text = "*Invalid Height in Inches";
            this.lblInvalidHeight.Visible = false;
            this.lblInvalidHeight.Click += new System.EventHandler(this.lblInvalidHeight_Click);
            // 
            // lblInvalidWidth
            // 
            this.lblInvalidWidth.AutoSize = true;
            this.lblInvalidWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidWidth.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidWidth.Location = new System.Drawing.Point(244, 228);
            this.lblInvalidWidth.Name = "lblInvalidWidth";
            this.lblInvalidWidth.Size = new System.Drawing.Size(119, 13);
            this.lblInvalidWidth.TabIndex = 17;
            this.lblInvalidWidth.Text = "*Invalid Width in Inches";
            this.lblInvalidWidth.Visible = false;
            this.lblInvalidWidth.Click += new System.EventHandler(this.lblInvalidWidth_Click);
            // 
            // lblInvalidWidthBetween
            // 
            this.lblInvalidWidthBetween.AutoSize = true;
            this.lblInvalidWidthBetween.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidWidthBetween.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidWidthBetween.Location = new System.Drawing.Point(244, 241);
            this.lblInvalidWidthBetween.Name = "lblInvalidWidthBetween";
            this.lblInvalidWidthBetween.Size = new System.Drawing.Size(187, 13);
            this.lblInvalidWidthBetween.TabIndex = 19;
            this.lblInvalidWidthBetween.Text = "Must be a number between 24 and 96";
            this.lblInvalidWidthBetween.Visible = false;
            this.lblInvalidWidthBetween.Click += new System.EventHandler(this.lblInvalidWidthBetween_Click);
            // 
            // lblInvalidDepthBetween
            // 
            this.lblInvalidDepthBetween.AutoSize = true;
            this.lblInvalidDepthBetween.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidDepthBetween.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidDepthBetween.Location = new System.Drawing.Point(244, 276);
            this.lblInvalidDepthBetween.Name = "lblInvalidDepthBetween";
            this.lblInvalidDepthBetween.Size = new System.Drawing.Size(187, 13);
            this.lblInvalidDepthBetween.TabIndex = 21;
            this.lblInvalidDepthBetween.Text = "Must be a number between 12 and 48";
            this.lblInvalidDepthBetween.Visible = false;
            this.lblInvalidDepthBetween.Click += new System.EventHandler(this.lblInvalidDepthBetween_Click);
            // 
            // lblInvalidDepth
            // 
            this.lblInvalidDepth.AutoSize = true;
            this.lblInvalidDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidDepth.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidDepth.Location = new System.Drawing.Point(244, 263);
            this.lblInvalidDepth.Name = "lblInvalidDepth";
            this.lblInvalidDepth.Size = new System.Drawing.Size(120, 13);
            this.lblInvalidDepth.TabIndex = 20;
            this.lblInvalidDepth.Text = "*Invalid Depth in Inches";
            this.lblInvalidDepth.Visible = false;
            this.lblInvalidDepth.Click += new System.EventHandler(this.lblInvalidDepth_Click);
            // 
            // tbHeight
            // 
            this.tbHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHeight.Location = new System.Drawing.Point(138, 193);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(100, 29);
            this.tbHeight.TabIndex = 2;
            this.tbHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateHeightInput);
            // 
            // tbWidth
            // 
            this.tbWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWidth.Location = new System.Drawing.Point(138, 228);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(100, 29);
            this.tbWidth.TabIndex = 3;
            this.tbWidth.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateWidth);
            // 
            // tbDepth
            // 
            this.tbDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDepth.Location = new System.Drawing.Point(138, 263);
            this.tbDepth.Name = "tbDepth";
            this.tbDepth.Size = new System.Drawing.Size(100, 29);
            this.tbDepth.TabIndex = 4;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(138, 79);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(242, 29);
            this.tbName.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Name";
            // 
            // comboBoxShippingOption
            // 
            this.comboBoxShippingOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShippingOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxShippingOption.FormattingEnabled = true;
            this.comboBoxShippingOption.Location = new System.Drawing.Point(138, 114);
            this.comboBoxShippingOption.Name = "comboBoxShippingOption";
            this.comboBoxShippingOption.Size = new System.Drawing.Size(121, 32);
            this.comboBoxShippingOption.TabIndex = 1;
            this.comboBoxShippingOption.SelectedIndexChanged += new System.EventHandler(this.comboBoxShippingOption_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Shipping Days";
            // 
            // lineSeperator
            // 
            this.lineSeperator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lineSeperator.Location = new System.Drawing.Point(14, 165);
            this.lineSeperator.Name = "lineSeperator";
            this.lineSeperator.Size = new System.Drawing.Size(472, 2);
            this.lineSeperator.TabIndex = 29;
            // 
            // blbInvalidNameAndShipping
            // 
            this.blbInvalidNameAndShipping.AutoSize = true;
            this.blbInvalidNameAndShipping.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blbInvalidNameAndShipping.ForeColor = System.Drawing.Color.Red;
            this.blbInvalidNameAndShipping.Location = new System.Drawing.Point(386, 79);
            this.blbInvalidNameAndShipping.Name = "blbInvalidNameAndShipping";
            this.blbInvalidNameAndShipping.Size = new System.Drawing.Size(102, 20);
            this.blbInvalidNameAndShipping.TabIndex = 30;
            this.blbInvalidNameAndShipping.Text = "*Insert Name";
            this.blbInvalidNameAndShipping.Visible = false;
            this.blbInvalidNameAndShipping.Click += new System.EventHandler(this.blbInvalidNameAndShipping_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 446);
            this.Controls.Add(this.blbInvalidNameAndShipping);
            this.Controls.Add(this.lineSeperator);
            this.Controls.Add(this.comboBoxShippingOption);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbDepth);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.lblInvalidDepthBetween);
            this.Controls.Add(this.lblInvalidDepth);
            this.Controls.Add(this.lblInvalidWidthBetween);
            this.Controls.Add(this.lblInvalidWidth);
            this.Controls.Add(this.lblInvalidHeight);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveDesk);
            this.Controls.Add(this.comboBoxMaterials);
            this.Controls.Add(this.comboBoxDrawers);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxDrawers;
        private System.Windows.Forms.ComboBox comboBoxMaterials;
        private System.Windows.Forms.Button btnSaveDesk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblInvalidHeight;
        private System.Windows.Forms.Label lblInvalidWidth;
        private System.Windows.Forms.Label lblInvalidWidthBetween;
        private System.Windows.Forms.Label lblInvalidDepthBetween;
        private System.Windows.Forms.Label lblInvalidDepth;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.TextBox tbDepth;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxShippingOption;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lineSeperator;
        private System.Windows.Forms.Label blbInvalidNameAndShipping;
    }
}