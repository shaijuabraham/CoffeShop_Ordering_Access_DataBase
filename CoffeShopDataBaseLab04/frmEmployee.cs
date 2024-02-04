using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using MyClassLibrary;

namespace CoffeShopDataBaseLab04
{
    public partial class frmEmployee : Form
    {
        string connectString = "provider=Microsoft.ACE.OLEDB.12.0; Data Source=../../Database1.accdb;";

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            // Load categories into the ComboBox using a foreach loop
            foreach (var item in Enum.GetValues(typeof(MyClassLibrary.MenuItem.MenuCategory)))
            {
                cobCategory.Items.Add(item);
                cobAddCategory.Items.Add(item);
                cobSearchItem.Items.Add(item);
            }

        }
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain frmMain = new frmMain();
            frmMain.Show();

        }

        private void btnViewMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // IsNullOrWhiteSpace It checks if a string is null, empty, or contains only white-space characters.
            if (string.IsNullOrWhiteSpace(cobAddCategory.SelectedItem.ToString()) ||
                   string.IsNullOrWhiteSpace(txtItemName.Text) ||
                   string.IsNullOrWhiteSpace(txtDescription.Text) ||
                   string.IsNullOrWhiteSpace(txtRetailPrice.Text) ||
                   string.IsNullOrWhiteSpace(txtOurCost.Text) ||
                   string.IsNullOrWhiteSpace(txtImagurl.Text))
            {
                MessageBox.Show("Please fill all the requested fields.");
            }

            else
            {
                Employee employee = new Employee(connectString);
                string category = cobAddCategory.SelectedItem.ToString();
                string itemName = txtItemName.Text;
                string itemPrice = txtRetailPrice.Text;
                string itemDescription = txtDescription.Text;
                string itemImgUrl = txtImagurl.Text;
                string ourPrice = txtOurCost.Text;
                // InsertMenuItem method from the Employee class
                employee.InsertMenuItem(category, itemName, ourPrice, itemPrice, itemDescription, itemImgUrl);
            }
        }

        private void cobCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Get the selected category from the combo box
            string selectedCategory = cobCategory.SelectedItem.ToString();

            Employee employee = new Employee(connectString);
            employee.MenuItemsByCategory(selectedCategory,libMenu);

        }

        private void grbEmployeeView_Enter(object sender, EventArgs e)
        {
        
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Get the selected category from the combo box
            string selectedCategory = cobSearchItem.SelectedItem.ToString();
            Employee employee = new Employee(connectString);
            employee.MenuItemsByCategory(selectedCategory, libMenu);
            
        }

        private void libMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected category from the combo box
            string selecteditem = libMenu.SelectedItem.ToString();

            Employee employee = new Employee(connectString);
            employee.UpdateDescriptionAndImage(selecteditem, libMenu, lblDescription, prbImage);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
