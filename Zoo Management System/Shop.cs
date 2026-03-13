using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooManagementSystem
{
    public partial class Shop : Form
    {
        private int userId;
        private List<Product> productList = new List<Product>();

        public Shop(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            LoadProducts();
        }
        private void LoadProducts()
        {
            try
            {
                string query = "SELECT ProductID, Name FROM Products";
                DataTable dt = DataAccess.GetData(query);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No products found in the database.");
                    return;
                }

                productList.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    productList.Add(new Product
                    {
                        ProductID = Convert.ToInt32(row["ProductID"]),
                        Name = row["Name"].ToString()
                    });
                }

                if (productList.Count >= 1)
                    pnLabel1.Text = productList[0].Name;
                if (productList.Count >= 2)
                    pnLabel3.Text = productList[1].Name;
                if (productList.Count >= 3)
                    pnLabel2.Text = productList[2].Name;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
        }
        public class Product
        {
            public int ProductID { get; set; }
            public string Name { get; set; }
        }

        private void colorkitButton_Click(object sender, EventArgs e)
        {
            if (productList.Count >= 1)
                LoadProductDetails(productList[0].ProductID);
        }

        private void wallArtButton_Click(object sender, EventArgs e)
        {
            if (productList.Count >= 2)
                LoadProductDetails(productList[1].ProductID);
        }

        private void markerButton_Click(object sender, EventArgs e)
        {
            if (productList.Count >= 3)
                LoadProductDetails(productList[2].ProductID);
        }

        private void LoadProductDetails(int productId)
        {
            try
            {
                string query = $"SELECT Name, Price, ImagePath, StockQuantity FROM Products WHERE ProductID = {productId}";
                DataTable result = DataAccess.GetData(query);

                if (result.Rows.Count > 0)
                {
                    DataRow row = result.Rows[0];
                    ProductFrame productFrame = new ProductFrame(productId, userId);

                    SetControlValue(productFrame, "ProductNameLabel", row["Name"].ToString());
                    SetControlValue(productFrame, "PriceLabel", $"£{row["Price"]}");
                    SetControlValue(productFrame, "quantityLabel", row["StockQuantity"].ToString());

                    string imagePath = Application.StartupPath + "\\" + row["ImagePath"].ToString();
                    SetProductImage(productFrame, imagePath);

                    productFrame.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading product: " + ex.Message);
            }
        }
        private void SetControlValue(Control container, string controlName, string value)
        {
            foreach (Control control in container.Controls)
            {
                if (control.Name == controlName)
                {
                    control.Text = value;
                    return;
                }
                if (control.HasChildren)
                {
                    SetControlValue(control, controlName, value);
                }
            }
        }
        private void SetProductImage(Control container, string imagePath)
        {
            foreach (Control control in container.Controls)
            {
                if (control.Name == "productPictureBox" && control is PictureBox)
                {
                    if (System.IO.File.Exists(imagePath))
                    {
                        var pictureBox = (PictureBox)control;
                        var oldImage = pictureBox.Image;
                        pictureBox.BackgroundImage = Image.FromFile(imagePath);
                        oldImage?.Dispose();
                    }
                    else
                    {
                        MessageBox.Show($"Error: {imagePath}");
                    }
                    return;
                }
                if (control.HasChildren)
                {
                    SetProductImage(control, imagePath);
                }
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            visitorHome home = new visitorHome(userId);
            home.Show();
            this.Close();
        }
    }
}
