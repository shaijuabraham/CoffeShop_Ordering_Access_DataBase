using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace MyClassLibrary
{
    public class Employee
    {
        private string connectString;

        public Employee(string connectionString)
        {
            connectString = connectionString;
        }

        public void InsertMenuItem(string category, string itemName, string ourPrice, string itemPrice, string itemDescription, string itemImgUrl)
        {
            using (OleDbConnection myConnection = new OleDbConnection(connectString))
            {
                string queryString = "INSERT INTO MenuItemTable (Category, ItemName, OurPrice, ItemPrice, ItemDescription, itemImgUrl) " +
                                    $"VALUES ('{category}', '{itemName}', ' {ourPrice} ', ' {itemPrice}', '{itemDescription}', '{itemImgUrl}')";

                using (OleDbCommand myCommand = new OleDbCommand(queryString, myConnection))
                {
                    try
                    {
                        myConnection.Open();
                        myCommand.ExecuteNonQuery();
                        MessageBox.Show("Item added successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        public void MenuItemsByCategory(string selectedCategory, ListBox listBox)
        {
            // Clear existing items in the ListBox
            listBox.Items.Clear();

            using (OleDbConnection myConnection = new OleDbConnection(connectString))
            {
                string queryString = $"SELECT ItemName, OurPrice, ItemPrice FROM MenuItemTable WHERE Category = '{selectedCategory}'";

                using (OleDbCommand myCommand = new OleDbCommand(queryString, myConnection))
                {
                    try
                    {
                        myConnection.Open();

                        using (OleDbDataReader reader = myCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string itemName = reader["ItemName"].ToString();
                                string sellPrice = reader["ItemPrice"].ToString();
                                string ourPrice = reader["OurPrice"].ToString();
                                listBox.Items.Add($"{itemName}  ${ourPrice} ${sellPrice}");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        public void UpdateDescriptionAndImage(string selectedString, ListBox listBox, Label descriptionLabel, PictureBox pictureBox)
        {
            string selectedItemName = selectedString.Split('$')[0].Trim();

            if (selectedItemName != null)
            {
                using (OleDbConnection myConnection = new OleDbConnection(connectString))
                {
                    string queryString = $"SELECT ItemDescription, itemImgUrl FROM MenuItemTable WHERE ItemName = '{selectedItemName}'";

                    try
                    {
                        myConnection.Open();

                        using (OleDbCommand myCommand = new OleDbCommand(queryString, myConnection))
                        using (OleDbDataReader reader = myCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                descriptionLabel.Text = reader["ItemDescription"].ToString();

                                string imageUrl = reader["itemImgUrl"].ToString();
                                pictureBox.Load(imageUrl);
                                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }


        public void MenuCategory(string selectedCategory, ListBox listBox)
        {
            // Clear existing items in the ListBox
            listBox.Items.Clear();

            using (OleDbConnection myConnection = new OleDbConnection(connectString))
            {
                string queryString = $"SELECT ItemName, ItemPrice FROM MenuItemTable WHERE Category = '{selectedCategory}'";

                using (OleDbCommand myCommand = new OleDbCommand(queryString, myConnection))
                {
                    try
                    {
                        myConnection.Open();

                        using (OleDbDataReader reader = myCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string itemName = reader["ItemName"].ToString();
                                string sellPrice = reader["ItemPrice"].ToString();
                                listBox.Items.Add($"{itemName} ${sellPrice}");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }

}
