using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Text;

namespace OMC_G10_Final
{
    public static class DatabaseHelper
    {
        private static string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CareCart_Database_FINALOMC.accdb");
        private static string connString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};";

        public static OleDbConnection GetConnection()
        {
            return new OleDbConnection(connString);
        }
        public static DataTable GetAllSuppliers()
        {
            DataTable table = new DataTable();
            using (OleDbConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT [SupplierID], [BusinessName], [SSMRegNumber], [BusinessAddress], [BusinessContactNumber], [BusinessEmail], [Type], [Status], [Password], [RegisteredDate] FROM [Suppliers]";
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn))
                {
                    adapter.Fill(table);
                }
            }
            return table;
        }

        public static bool UpdateSupplier(string supplierId, string businessName, string type, string address, string status)
        {
            using (OleDbConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"UPDATE [Suppliers] 
                    SET [BusinessName] = ?, [Type] = ?, [BusinessAddress] = ?, [Status] = ? 
                    WHERE [SupplierID] = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.Add("@BusinessName", OleDbType.VarWChar).Value = businessName;
                        cmd.Parameters.Add("@Type", OleDbType.VarWChar).Value = type;
                        cmd.Parameters.Add("@BusinessAddress", OleDbType.VarWChar).Value = address;
                        cmd.Parameters.Add("@Status", OleDbType.VarWChar).Value = status;
                        cmd.Parameters.Add("@SupplierID", OleDbType.VarWChar).Value = supplierId;

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show($"Error updating supplier: {ex.Message}");
                    return false;
                }
            }
        }

        public static bool DeleteSupplier(string supplierId)
        {
            using (OleDbConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM [Suppliers] WHERE [SupplierID] = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.Add("@SupplierID", OleDbType.VarWChar).Value = supplierId;
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show($"Error deleting supplier: {ex.Message}");
                    return false;
                }
            }
        }
        public static List<string> GetFAQCategories()
        {
            List<string> categories = new List<string>();
            using (OleDbConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT DISTINCT [Type] FROM [FAQ_Chatbot]";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        categories.Add(reader["Type"].ToString());
                    }
                }
            }
            return categories;
        }

        public static List<string> GetQuestionsByCategory(string category)
        {
            List<string> questions = new List<string>();
            using (OleDbConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT [Question] FROM [FAQ_Chatbot] WHERE [Type] = ?";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.Add("@Type", OleDbType.VarWChar).Value = category;
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            questions.Add(reader["Question"].ToString());
                        }
                    }
                }
            }
            return questions;
        }

        public static string GetAnswerForQuestion(string question)
        {
            using (OleDbConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT [Answer] FROM [FAQ_Chatbot] WHERE [Question] = ?";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.Add("@Question", OleDbType.VarWChar).Value = question;
                    object result = cmd.ExecuteScalar();
                    return result?.ToString() ?? "Sorry, I don't have an answer for that.";
                }
            }
        }
        public static DataTable GetAllFAQs()
        {
            DataTable table = new DataTable();
            using (OleDbConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT [QuestionID], [Question], [Type], [Answer] FROM [FAQ_Chatbot]";
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn))
                {
                    adapter.Fill(table);
                }
            }
            return table;
        }

        public static bool UpdateFAQ(string questionId, string question, string category, string answer)
        {
            using (OleDbConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"UPDATE [FAQ_Chatbot] 
                SET [Question] = ?, [Type] = ?, [Answer] = ? 
                WHERE [QuestionID] = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.Add("@Question", OleDbType.VarWChar).Value = question;
                        cmd.Parameters.Add("@Type", OleDbType.VarWChar).Value = category;
                        cmd.Parameters.Add("@Answer", OleDbType.VarWChar).Value = answer;
                        cmd.Parameters.Add("@QuestionID", OleDbType.VarWChar).Value = questionId;

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show($"Error updating question: {ex.Message}");
                    return false;
                }
            }
        }

        public static bool DeleteFAQ(string questionId)
        {
            using (OleDbConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM [FAQ_Chatbot] WHERE [QuestionID] = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.Add("@QuestionID", OleDbType.VarWChar).Value = questionId;
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show($"Error deleting question: {ex.Message}");
                    return false;
                }
            }
        }
        public static DataRow GetUserById(string userId)
        {
            using (OleDbConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM [Users] WHERE [UserID] = ?";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.Add("@UserID", OleDbType.VarWChar).Value = userId;
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        return table.Rows.Count > 0 ? table.Rows[0] : null;
                    }
                }
            }
        }

        public static bool UpdateUserProfile(string userId, string name, string email, string phone,
                                              string address, string gender, string userCategory)
        {
            using (OleDbConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"UPDATE [Users] 
                SET [Name] = ?, [Email] = ?, [PhoneNumber] = ?, [Address] = ?, [Gender] = ?, [UserCategory] = ? 
                WHERE [UserID] = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.Add("@Name", OleDbType.VarWChar).Value = name;
                        cmd.Parameters.Add("@Email", OleDbType.VarWChar).Value = email;
                        cmd.Parameters.Add("@PhoneNumber", OleDbType.VarWChar).Value = phone;
                        cmd.Parameters.Add("@Address", OleDbType.VarWChar).Value = address;
                        cmd.Parameters.Add("@Gender", OleDbType.VarWChar).Value = gender;
                        cmd.Parameters.Add("@UserCategory", OleDbType.VarWChar).Value = userCategory;
                        cmd.Parameters.Add("@UserID", OleDbType.VarWChar).Value = userId;

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show($"Error updating profile: {ex.Message}");
                    return false;
                }
            }
        }
        public static DataRow GetAdminById(string adminId)
        {
            using (OleDbConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM [Admin] WHERE [AdminID] = ?";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.Add("@AdminID", OleDbType.VarWChar).Value = adminId;
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        return table.Rows.Count > 0 ? table.Rows[0] : null;
                    }
                }
            }
        }
        public static List<string> GetProductNamesBySupplier(string supplierId)
        {
            List<string> names = new List<string>();
            using (OleDbConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT [ProductName] FROM [Products] WHERE [SupplierID] = ?";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.Add("@SupplierID", OleDbType.VarWChar).Value = supplierId;
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            names.Add(reader["ProductName"].ToString());
                        }
                    }
                }
            }
            return names;
        }

        public static bool RestockProduct(string productName, string supplierId, int addQuantity)
        {
            using (OleDbConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"UPDATE [Products] 
                SET [StockQuantity] = [StockQuantity] + ? 
                WHERE [ProductName] = ? AND [SupplierID] = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.Add("@AddQuantity", OleDbType.Integer).Value = addQuantity;
                        cmd.Parameters.Add("@ProductName", OleDbType.VarWChar).Value = productName;
                        cmd.Parameters.Add("@SupplierID", OleDbType.VarWChar).Value = supplierId;

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show($"Error restocking product: {ex.Message}");
                    return false;
                }
            }
        }

        public static bool AddNewProduct(string supplierId, string productName, string imagePath,
                                          decimal price, string details, int quantity, string categoryId, string categoryName)
        {
            using (OleDbConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    string newProductId = GenerateNextProductId(conn);

                    string query = @"INSERT INTO [Products] 
                ([ProductID], [SupplierID], [ProductName], [PriceRM], [Details], [StockQuantity], [ImagePath], [CategoryID], [CategoryName], [AvgRating], [NumOfReviews]) 
                VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, 0, 0)";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.Add("@ProductID", OleDbType.VarWChar).Value = newProductId;
                        cmd.Parameters.Add("@SupplierID", OleDbType.VarWChar).Value = supplierId;
                        cmd.Parameters.Add("@ProductName", OleDbType.VarWChar).Value = productName;
                        cmd.Parameters.Add("@PriceRM", OleDbType.Decimal).Value = price;
                        cmd.Parameters.Add("@Details", OleDbType.VarWChar).Value = details;
                        cmd.Parameters.Add("@StockQuantity", OleDbType.Integer).Value = quantity;
                        cmd.Parameters.Add("@ImagePath", OleDbType.VarWChar).Value = imagePath;
                        cmd.Parameters.Add("@CategoryID", OleDbType.VarWChar).Value = categoryId;
                        cmd.Parameters.Add("@CategoryName", OleDbType.VarWChar).Value = categoryName;

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show($"Error adding product: {ex.Message}");
                    return false;
                }
            }
        }

        private static string GenerateNextProductId(OleDbConnection conn)
        {
            string query = "SELECT [ProductID] FROM [Products] ORDER BY [ProductID] DESC";
            int maxNum = 0;

            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            using (OleDbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    string lastId = reader["ProductID"].ToString(); // e.g. "PR32"
                    string numPart = lastId.Substring(2);            // "32"
                    int.TryParse(numPart, out maxNum);
                }
            }

            int nextNum = maxNum + 1;
            return "PR" + nextNum.ToString("D2"); // PR33, PR34...
        }
        public static Dictionary<string, string> GetCategoryNameToIdMap()
        {
            Dictionary<string, string> map = new Dictionary<string, string>();
            using (OleDbConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT [CategoryID], [CategoryName] FROM [Categories]";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string name = reader["CategoryName"].ToString();
                        string id = reader["CategoryID"].ToString();
                        if (!map.ContainsKey(name))
                            map.Add(name, id);
                    }
                }
            }
            return map;
        }
        public static bool AddToCart(string userId, string productId, string productName, decimal unitPrice, int quantity)
        {
            using (OleDbConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();

                    string checkQuery = "SELECT COUNT(*) FROM [Cart] WHERE [UserID] = ? AND [ProductID] = ?";
                    using (OleDbCommand checkCmd = new OleDbCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.Add("@UserID", OleDbType.VarWChar).Value = userId;
                        checkCmd.Parameters.Add("@ProductID", OleDbType.VarWChar).Value = productId;
                        int exists = (int)checkCmd.ExecuteScalar();

                        if (exists > 0)
                        {
                            string updateQuery = @"UPDATE [Cart] 
                        SET [Quantity] = [Quantity] + ?, [LineTotalRM] = ([Quantity] + ?) * [UnitPriceRM]
                        WHERE [UserID] = ? AND [ProductID] = ?";
                            using (OleDbCommand updateCmd = new OleDbCommand(updateQuery, conn))
                            {
                                updateCmd.Parameters.Add("@Qty1", OleDbType.Integer).Value = quantity;
                                updateCmd.Parameters.Add("@Qty2", OleDbType.Integer).Value = quantity;
                                updateCmd.Parameters.Add("@UserID", OleDbType.VarWChar).Value = userId;
                                updateCmd.Parameters.Add("@ProductID", OleDbType.VarWChar).Value = productId;
                                updateCmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            string cartId = GenerateNextCartId(conn);
                            decimal lineTotal = unitPrice * quantity;

                            string insertQuery = @"INSERT INTO [Cart] 
                        ([CartID], [UserID], [ProductID], [ProductName], [UnitPriceRM], [Quantity], [LineTotalRM], [SelectedForCheckout], [DateAdded]) 
                        VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";
                            using (OleDbCommand insertCmd = new OleDbCommand(insertQuery, conn))
                            {
                                insertCmd.Parameters.Add("@CartID", OleDbType.VarWChar).Value = cartId;
                                insertCmd.Parameters.Add("@UserID", OleDbType.VarWChar).Value = userId;
                                insertCmd.Parameters.Add("@ProductID", OleDbType.VarWChar).Value = productId;
                                insertCmd.Parameters.Add("@ProductName", OleDbType.VarWChar).Value = productName;
                                insertCmd.Parameters.Add("@UnitPriceRM", OleDbType.Decimal).Value = unitPrice;
                                insertCmd.Parameters.Add("@Quantity", OleDbType.Integer).Value = quantity;
                                insertCmd.Parameters.Add("@LineTotalRM", OleDbType.Decimal).Value = lineTotal;
                                insertCmd.Parameters.Add("@SelectedForCheckout", OleDbType.Boolean).Value = true;
                                insertCmd.Parameters.Add("@DateAdded", OleDbType.Date).Value = DateTime.Now;
                                insertCmd.ExecuteNonQuery();
                            }
                        }
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show($"Error adding to cart: {ex.Message}");
                    return false;
                }
            }
        }

        private static string GenerateNextCartId(OleDbConnection conn)
        {
            string query = "SELECT [CartID] FROM [Cart] ORDER BY [CartID] DESC";
            int maxNum = 0;

            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            using (OleDbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    string lastId = reader["CartID"].ToString(); // e.g. "CT02"
                    string numPart = lastId.Substring(2);
                    int.TryParse(numPart, out maxNum);
                }
            }

            int nextNum = maxNum + 1;
            return "CT" + nextNum.ToString("D2"); // CT03, CT04...
        }

        public static DataTable GetCartItemsByUser(string userId)
        {
            DataTable table = new DataTable();
            using (OleDbConnection conn = GetConnection())
            {
                conn.Open();
                string query = @"SELECT c.[CartID], c.[ProductID], c.[ProductName], c.[UnitPriceRM], 
                                 c.[Quantity], c.[LineTotalRM], c.[SelectedForCheckout],
                                 p.[ImagePath]
                          FROM [Cart] c
                          LEFT JOIN [Products] p ON c.[ProductID] = p.[ProductID]
                          WHERE c.[UserID] = ?";

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.Add("@UserID", OleDbType.VarWChar).Value = userId;
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                    {
                        adapter.Fill(table);
                    }
                }
            }
            return table;
        }

        public static bool UpdateCartQuantity(string cartId, int newQuantity)
        {
            using (OleDbConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"UPDATE [Cart] 
                SET [Quantity] = ?, [LineTotalRM] = ? * [UnitPriceRM] 
                WHERE [CartID] = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.Add("@Quantity", OleDbType.Integer).Value = newQuantity;
                        cmd.Parameters.Add("@Quantity2", OleDbType.Integer).Value = newQuantity;
                        cmd.Parameters.Add("@CartID", OleDbType.VarWChar).Value = cartId;
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show($"Error updating quantity: {ex.Message}");
                    return false;
                }
            }
        }

        public static bool RemoveFromCart(string cartId)
        {
            using (OleDbConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM [Cart] WHERE [CartID] = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.Add("@CartID", OleDbType.VarWChar).Value = cartId;
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show($"Error removing from cart: {ex.Message}");
                    return false;
                }
            }
        }

        public static bool UpdateCartSelection(string cartId, bool isSelected)
        {
            using (OleDbConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE [Cart] SET [SelectedForCheckout] = ? WHERE [CartID] = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.Add("@SelectedForCheckout", OleDbType.Boolean).Value = isSelected;
                        cmd.Parameters.Add("@CartID", OleDbType.VarWChar).Value = cartId;
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show($"Error updating selection: {ex.Message}");
                    return false;
                }
            }
        }
        public static DataTable GetSelectedCartItems(string userId)
        {
            DataTable table = new DataTable();
            using (OleDbConnection conn = GetConnection())
            {
                conn.Open();
                string query = @"SELECT c.[CartID], c.[ProductID], c.[ProductName], c.[UnitPriceRM], 
                                 c.[Quantity], c.[LineTotalRM]
                          FROM [Cart] c
                          WHERE c.[UserID] = ? AND c.[SelectedForCheckout] = True";

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.Add("@UserID", OleDbType.VarWChar).Value = userId;
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                    {
                        adapter.Fill(table);
                    }
                }
            }
            return table;
        }
        public static string CreateOrder(string userId, DataTable cartItems, decimal subtotal, decimal shipping, decimal total, string paymentMethod)
        {
            using (OleDbConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    string orderId = GenerateNextOrderId(conn);

                    string orderQuery = @"INSERT INTO [Orders] 
                ([OrderID], [UserID], [OrderDate], [SubtotalRM], [ShippingRM], [TotalRM], [PaymentMethod], [DeliveryStatus], [EstimatedArrival]) 
                VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";

                    using (OleDbCommand cmd = new OleDbCommand(orderQuery, conn))
                    {
                        cmd.Parameters.Add("@OrderID", OleDbType.VarWChar).Value = orderId;
                        cmd.Parameters.Add("@UserID", OleDbType.VarWChar).Value = userId;
                        cmd.Parameters.Add("@OrderDate", OleDbType.Date).Value = DateTime.Now;
                        cmd.Parameters.Add("@SubtotalRM", OleDbType.Decimal).Value = subtotal;
                        cmd.Parameters.Add("@ShippingRM", OleDbType.Decimal).Value = shipping;
                        cmd.Parameters.Add("@TotalRM", OleDbType.Decimal).Value = total;
                        cmd.Parameters.Add("@PaymentMethod", OleDbType.VarWChar).Value = paymentMethod;
                        cmd.Parameters.Add("@DeliveryStatus", OleDbType.VarWChar).Value = "Order Confirmed";
                        cmd.Parameters.Add("@EstimatedArrival", OleDbType.Date).Value = DateTime.Now.AddDays(3);
                        cmd.ExecuteNonQuery();
                    }

                    foreach (DataRow row in cartItems.Rows)
                    {
                        string orderItemId = GenerateNextOrderItemId(conn);

                        string itemQuery = @"INSERT INTO [Order_Items] 
                    ([OrderItemID], [CartID], [UserID], [OrderID], [ProductID], [ProductName], [Quantity], [UnitPriceRM], [LineTotalRM]) 
                    VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";

                        using (OleDbCommand cmd = new OleDbCommand(itemQuery, conn))
                        {
                            cmd.Parameters.Add("@OrderItemID", OleDbType.VarWChar).Value = orderItemId;
                            cmd.Parameters.Add("@CartID", OleDbType.VarWChar).Value = row["CartID"].ToString();
                            cmd.Parameters.Add("@UserID", OleDbType.VarWChar).Value = userId;
                            cmd.Parameters.Add("@OrderID", OleDbType.VarWChar).Value = orderId;
                            cmd.Parameters.Add("@ProductID", OleDbType.VarWChar).Value = row["ProductID"].ToString();
                            cmd.Parameters.Add("@ProductName", OleDbType.VarWChar).Value = row["ProductName"].ToString();
                            cmd.Parameters.Add("@Quantity", OleDbType.Integer).Value = Convert.ToInt32(row["Quantity"]);
                            cmd.Parameters.Add("@UnitPriceRM", OleDbType.Decimal).Value = Convert.ToDecimal(row["UnitPriceRM"]);
                            cmd.Parameters.Add("@LineTotalRM", OleDbType.Decimal).Value = Convert.ToDecimal(row["LineTotalRM"]);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    return orderId; // changed from "return true"
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show($"Error creating order: {ex.Message}");
                    return null; // changed from "return false"
                }
            }
        }

        private static string GenerateNextOrderId(OleDbConnection conn)
        {
            string query = "SELECT [OrderID] FROM [Orders] ORDER BY [OrderID] DESC";
            int maxNum = 1000;

            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            using (OleDbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    string lastId = reader["OrderID"].ToString(); // e.g. "OD1002"
                    string numPart = lastId.Substring(2);
                    int.TryParse(numPart, out maxNum);
                }
            }

            int nextNum = maxNum + 1;
            return "OD" + nextNum.ToString("D4"); // OD1003, OD1004...
        }

        private static string GenerateNextOrderItemId(OleDbConnection conn)
        {
            string query = "SELECT [OrderItemID] FROM [Order_Items] ORDER BY [OrderItemID] DESC";
            int maxNum = 0;

            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            using (OleDbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    string lastId = reader["OrderItemID"].ToString(); // e.g. "OI002"
                    string numPart = lastId.Substring(2);
                    int.TryParse(numPart, out maxNum);
                }
            }

            int nextNum = maxNum + 1;
            return "OI" + nextNum.ToString("D3"); // OI003, OI004...
        }

        public static bool ClearCheckedOutItems(string userId)
        {
            using (OleDbConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM [Cart] WHERE [UserID] = ? AND [SelectedForCheckout] = True";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.Add("@UserID", OleDbType.VarWChar).Value = userId;
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show($"Error clearing cart: {ex.Message}");
                    return false;
                }
            }
        }
        public static DataRow GetOrderById(string orderId)
        {
            using (OleDbConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM [Orders] WHERE [OrderID] = ?";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.Add("@OrderID", OleDbType.VarWChar).Value = orderId;
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        return table.Rows.Count > 0 ? table.Rows[0] : null;
                    }
                }
            }
        }

        public static DataTable GetOrderItemsByOrderId(string orderId)
        {
            DataTable table = new DataTable();
            using (OleDbConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT [ProductName], [Quantity] FROM [Order_Items] WHERE [OrderID] = ?";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.Add("@OrderID", OleDbType.VarWChar).Value = orderId;
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                    {
                        adapter.Fill(table);
                    }
                }
            }
            return table;
        }
        public static DataTable GetReviewsByProduct(string productId)
        {
            DataTable table = new DataTable();
            using (OleDbConnection conn = GetConnection())
            {
                conn.Open();
                string query = @"SELECT r.[Rating], r.[ReviewText], r.[ReviewDate], u.[Name] AS ReviewerName
                          FROM [Reviews] r
                          LEFT JOIN [Users] u ON r.[UserID] = u.[UserID]
                          WHERE r.[ProductID] = ?
                          ORDER BY r.[ReviewDate] DESC";

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.Add("@ProductID", OleDbType.VarWChar).Value = productId;
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                    {
                        adapter.Fill(table);
                    }
                }
            }
            return table;
        }
    }

}
