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
    public partial class ProductFrame : Form
    {
        private int currentProductId;
        private int userId;
        private decimal productPrice;
        private int maxQuantity;
        private int currentQuantity = 1;
        private decimal totalPrice;

        public ProductFrame(int productId, int userId)
        {
            InitializeComponent();

            this.currentProductId = productId;
            this.userId = userId;

            LoadProductDetails();

            addQuantityTextBox.Text = "1";
            UpdateTotalPrice();

            addQuantityTextBox.TextChanged += addQuantityTextBox_TextChanged;

        }
        private void LoadProductDetails()
        {
            try
            {

                string query = $"SELECT Price, StockQuantity FROM Products WHERE ProductID = {currentProductId}";
                DataTable result = DataAccess.GetData(query);

                if (result.Rows.Count > 0)
                {
                    productPrice = Convert.ToDecimal(result.Rows[0]["Price"]);
                    maxQuantity = Convert.ToInt32(result.Rows[0]["StockQuantity"]);

                    /*PriceLabel.Text = $"${productPrice:0.00}";
                    quantityLabel.Text = $"Available Quantity: {maxQuantity}";*/
                }
                else
                {
                    MessageBox.Show("Product not found");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading product: {ex.Message}");
                this.Close();
            }
        }
        private void UpdateTotalPrice()
        {
            if (int.TryParse(addQuantityTextBox.Text, out int quantity) && quantity > 0)
            {
                currentQuantity = quantity;
                decimal totalPrice = productPrice * currentQuantity;

                addToCardButton.Text = $"Add to Cart - £{totalPrice:0.00}";
            }
            else
            {
                cardbtn.Text = "Buy";
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProductNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void PriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void quantityLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddToCart(int quantity)
        {
            try
            {
                if (quantity > maxQuantity)
                {
                    MessageBox.Show($"Only {maxQuantity} available in stock");
                    return;
                }

                string cartQuery = $"SELECT CartID FROM Cart WHERE VisitorID = {userId}";
                DataTable cartResult = DataAccess.GetData(cartQuery);
                int cartId;

                if (cartResult.Rows.Count == 0)
                {
                    string createCartQuery = $"INSERT INTO Cart (VisitorID) VALUES ({userId})";
                    DataAccess.Execute(createCartQuery);
                }
                //else
                //{
                string cartQuery1 = $"SELECT CartID FROM Cart WHERE VisitorID = {userId}";
                DataTable cartResult1 = DataAccess.GetData(cartQuery1);
                cartId = Convert.ToInt32(cartResult1.Rows[0]["CartID"]);
                // }

                string checkItemQuery = $"SELECT CartItemID, Quantity FROM CartItems WHERE CartID = {cartId} AND ProductID = {currentProductId}";
                DataTable itemResult = DataAccess.GetData(checkItemQuery);

                if (itemResult.Rows.Count > 0)
                {
                    int currentQty = Convert.ToInt32(itemResult.Rows[0]["Quantity"]);
                    int newQty = currentQty + quantity;
                    int itemId = Convert.ToInt32(itemResult.Rows[0]["CartItemID"]);

                    string updateQuery = $"UPDATE CartItems SET Quantity = {newQty} WHERE CartItemID = {itemId}";
                    DataAccess.Execute(updateQuery);
                    MessageBox.Show($"{quantity} added to cart successfully!");
                }
                else
                {
                    string insertQuery = $"INSERT INTO CartItems (CartID, ProductID, Quantity) VALUES ({cartId}, {currentProductId}, {quantity})";
                    DataAccess.Execute(insertQuery);
                    MessageBox.Show($"{quantity} added to cart successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding to cart: {ex.Message}");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Shop shop = new Shop(userId);
            shop.Show();
            this.Close();
        }

        private void addToCardButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(addQuantityTextBox.Text, out int quantity) || quantity < 1)
            {
                MessageBox.Show("Please enter a valid quantity (minimum 1)");
                return;
            }

            AddToCart(quantity);
        }

        private void cardbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string cartQuery = $"SELECT CartID FROM Cart WHERE VisitorID = {userId}";
                DataTable cartResult = DataAccess.GetData(cartQuery);
                int cartId;

                if (cartResult.Rows.Count == 0)
                {
                    MessageBox.Show("Your cart is empty. Please add products first.");
                    return;
                }
                else
                {
                    cartId = Convert.ToInt32(cartResult.Rows[0]["CartID"]);
                }

                string totalQuery = $@"SELECT SUM(c.Quantity * p.Price) AS TotalPrice
                                       FROM CartItems c
                                       JOIN Products p ON c.ProductID = p.ProductID
                                       WHERE c.CartID = {cartId}";
                DataTable totalResult = DataAccess.GetData(totalQuery);

                if (totalResult.Rows.Count > 0 && totalResult.Rows[0]["TotalPrice"] != DBNull.Value)
                {
                    totalPrice = Convert.ToDecimal(totalResult.Rows[0]["TotalPrice"]);

                    string productQuery = $@"SELECT p.Name, c.Quantity, p.Price
                                            FROM CartItems c
                                            JOIN Products p ON c.ProductID = p.ProductID
                                            WHERE c.CartID = {cartId}";
                    DataTable productResult = DataAccess.GetData(productQuery);

                    List<string> productList = new List<string>();
                    foreach (DataRow row in productResult.Rows)
                    {
                        string name = row["Name"].ToString();
                        int qty = Convert.ToInt32(row["Quantity"]);
                        decimal price = Convert.ToDecimal(row["Price"]);
                        productList.Add($"{name} - {qty} pcs - £{price * qty:0.00}");
                    }

                    MembershipPayment payment = new MembershipPayment(userId, totalPrice, "Credit Card", productList);
                    payment.Show(this);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Your cart is empty. Please add products first.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing cart: {ex.Message}");
            }
        }

        private void addQuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void showCartItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                string cartQuery = $"SELECT CartID FROM Cart WHERE VisitorID = {userId}";
                DataTable cartResult = DataAccess.GetData(cartQuery);

                if (cartResult.Rows.Count == 0)
                {
                    MessageBox.Show("Your cart is empty.");
                    return;
                }

                int cartId = Convert.ToInt32(cartResult.Rows[0]["CartID"]);

                string productQuery = $@"SELECT p.Name, c.Quantity, p.Price
                                        FROM CartItems c
                                        JOIN Products p ON c.ProductID = p.ProductID
                                        WHERE c.CartID = {cartId}";
                DataTable productResult = DataAccess.GetData(productQuery);

                if (productResult.Rows.Count == 0)
                {
                    MessageBox.Show("Your cart is empty.");
                    return;
                }

                StringBuilder sb = new StringBuilder();
                decimal total = 0;

                foreach (DataRow row in productResult.Rows)
                {
                    string name = row["Name"].ToString();
                    int qty = Convert.ToInt32(row["Quantity"]);
                    decimal price = Convert.ToDecimal(row["Price"]);
                    decimal subtotal = price * qty;
                    total += subtotal;

                    sb.AppendLine($"{name} - {qty} pcs - £{subtotal:0.00}");
                }

                sb.AppendLine($"\nTotal Price: £{total:0.00}");

                MessageBox.Show(sb.ToString(), "Cart Items");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error showing cart items: {ex.Message}");
            }
        }

        private void clearCartButton_Click(object sender, EventArgs e)
        {
            try
            {
                string cartQuery = $"SELECT CartID FROM Cart WHERE VisitorID = {userId}";
                DataTable cartResult = DataAccess.GetData(cartQuery);

                if (cartResult.Rows.Count == 0)
                {
                    MessageBox.Show("Your cart is already empty.");
                    return;
                }

                int cartId = Convert.ToInt32(cartResult.Rows[0]["CartID"]);


                string deleteItemsQuery = $"DELETE FROM CartItems WHERE CartID = {cartId}";
                DataAccess.Execute(deleteItemsQuery);


                string deleteCartQuery = $"DELETE FROM Cart WHERE CartID = {cartId}";
                DataAccess.Execute(deleteCartQuery);

                MessageBox.Show("Cart and cart items cleared successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error clearing cart: {ex.Message}");
            }
        }

        private void removeLastItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                string cartQuery = $"SELECT CartID FROM Cart WHERE VisitorID = {userId}";
                DataTable cartResult = DataAccess.GetData(cartQuery);

                if (cartResult.Rows.Count == 0)
                {
                    MessageBox.Show("Your cart is empty.");
                    return;
                }

                int cartId = Convert.ToInt32(cartResult.Rows[0]["CartID"]);

                string lastItemQuery = $@"SELECT TOP 1 CartItemID
                                         FROM CartItems
                                         WHERE CartID = {cartId}
                                         ORDER BY CartItemID DESC";

                DataTable lastItemResult = DataAccess.GetData(lastItemQuery);

                if (lastItemResult.Rows.Count == 0)
                {
                    MessageBox.Show("Your cart is empty.");
                    return;
                }

                int lastItemId = Convert.ToInt32(lastItemResult.Rows[0]["CartItemID"]);


                string deleteQuery = $"DELETE FROM CartItems WHERE CartItemID = {lastItemId}";
                DataAccess.Execute(deleteQuery);


                string checkEmptyQuery = $"SELECT COUNT(*) AS ItemCount FROM CartItems WHERE CartID = {cartId}";
                DataTable checkResult = DataAccess.GetData(checkEmptyQuery);

                if (checkResult.Rows.Count > 0 && Convert.ToInt32(checkResult.Rows[0]["ItemCount"]) == 0)
                {

                    string deleteCartQuery = $"DELETE FROM Cart WHERE CartID = {cartId}";
                    DataAccess.Execute(deleteCartQuery);
                    MessageBox.Show("Last item removed and cart deleted.");
                }
                else
                {
                    MessageBox.Show("Last item removed from cart.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error removing last item: {ex.Message}");
            }
        }
    }
}
