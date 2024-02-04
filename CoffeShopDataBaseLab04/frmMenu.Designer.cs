
namespace CoffeShopDataBaseLab04
{
    partial class frmMenu
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
            this.grbCustomerInfromanation = new System.Windows.Forms.GroupBox();
            this.lblGmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.grbCustomerOrderView = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lisMenuView = new System.Windows.Forms.ListBox();
            this.prbImage = new System.Windows.Forms.PictureBox();
            this.cobCategory = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.grbCustomerInfromanation.SuspendLayout();
            this.grbCustomerOrderView.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // grbCustomerInfromanation
            // 
            this.grbCustomerInfromanation.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grbCustomerInfromanation.Controls.Add(this.lblGmail);
            this.grbCustomerInfromanation.Controls.Add(this.txtEmail);
            this.grbCustomerInfromanation.Controls.Add(this.txtPhoneNumber);
            this.grbCustomerInfromanation.Controls.Add(this.lblPhoneNumber);
            this.grbCustomerInfromanation.Controls.Add(this.txtName);
            this.grbCustomerInfromanation.Controls.Add(this.lblName);
            this.grbCustomerInfromanation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grbCustomerInfromanation.Location = new System.Drawing.Point(12, 355);
            this.grbCustomerInfromanation.Name = "grbCustomerInfromanation";
            this.grbCustomerInfromanation.Size = new System.Drawing.Size(295, 160);
            this.grbCustomerInfromanation.TabIndex = 14;
            this.grbCustomerInfromanation.TabStop = false;
            this.grbCustomerInfromanation.Text = "Customer Info..";
            // 
            // lblGmail
            // 
            this.lblGmail.AutoSize = true;
            this.lblGmail.Location = new System.Drawing.Point(6, 87);
            this.lblGmail.Name = "lblGmail";
            this.lblGmail.Size = new System.Drawing.Size(32, 13);
            this.lblGmail.TabIndex = 9;
            this.lblGmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(97, 84);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(182, 20);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.Text = "abcdegf@temple.edu";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(97, 58);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(182, 20);
            this.txtPhoneNumber.TabIndex = 7;
            this.txtPhoneNumber.Text = "123989891232";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(6, 61);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.lblPhoneNumber.TabIndex = 6;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(97, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(182, 20);
            this.txtName.TabIndex = 5;
            this.txtName.Text = "Shaiju  Abraham Rajan";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(85, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Enter You Name";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCheckOut.Location = new System.Drawing.Point(370, 530);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(141, 37);
            this.btnCheckOut.TabIndex = 13;
            this.btnCheckOut.Text = "CheckOut";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // grbCustomerOrderView
            // 
            this.grbCustomerOrderView.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grbCustomerOrderView.Controls.Add(this.groupBox1);
            this.grbCustomerOrderView.Controls.Add(this.lisMenuView);
            this.grbCustomerOrderView.Controls.Add(this.prbImage);
            this.grbCustomerOrderView.Controls.Add(this.cobCategory);
            this.grbCustomerOrderView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCustomerOrderView.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grbCustomerOrderView.Location = new System.Drawing.Point(12, 54);
            this.grbCustomerOrderView.Name = "grbCustomerOrderView";
            this.grbCustomerOrderView.Size = new System.Drawing.Size(499, 278);
            this.grbCustomerOrderView.TabIndex = 12;
            this.grbCustomerOrderView.TabStop = false;
            this.grbCustomerOrderView.Text = "You Order";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(9, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 86);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Description";
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(6, 18);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(472, 56);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lisMenuView
            // 
            this.lisMenuView.FormattingEnabled = true;
            this.lisMenuView.ItemHeight = 15;
            this.lisMenuView.Location = new System.Drawing.Point(6, 48);
            this.lisMenuView.Name = "lisMenuView";
            this.lisMenuView.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lisMenuView.Size = new System.Drawing.Size(225, 124);
            this.lisMenuView.TabIndex = 4;
            this.lisMenuView.SelectedIndexChanged += new System.EventHandler(this.lisMenuView_SelectedIndexChanged);
            // 
            // prbImage
            // 
            this.prbImage.Location = new System.Drawing.Point(237, 43);
            this.prbImage.Name = "prbImage";
            this.prbImage.Size = new System.Drawing.Size(241, 134);
            this.prbImage.TabIndex = 3;
            this.prbImage.TabStop = false;
            // 
            // cobCategory
            // 
            this.cobCategory.FormattingEnabled = true;
            this.cobCategory.Location = new System.Drawing.Point(6, 19);
            this.cobCategory.Name = "cobCategory";
            this.cobCategory.Size = new System.Drawing.Size(121, 23);
            this.cobCategory.TabIndex = 2;
            this.cobCategory.SelectedIndexChanged += new System.EventHandler(this.cobCategory_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBack.Location = new System.Drawing.Point(18, 530);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(121, 37);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(522, 595);
            this.Controls.Add(this.grbCustomerInfromanation);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.grbCustomerOrderView);
            this.Controls.Add(this.btnBack);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.grbCustomerInfromanation.ResumeLayout(false);
            this.grbCustomerInfromanation.PerformLayout();
            this.grbCustomerOrderView.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCustomerInfromanation;
        private System.Windows.Forms.Label lblGmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.GroupBox grbCustomerOrderView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ListBox lisMenuView;
        private System.Windows.Forms.PictureBox prbImage;
        private System.Windows.Forms.ComboBox cobCategory;
        private System.Windows.Forms.Button btnBack;
    }
}