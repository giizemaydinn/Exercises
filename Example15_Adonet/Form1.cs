using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
namespace Example15
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(
             ConfigurationManager.ConnectionStrings["AWConnStr"].ConnectionString);
        public Form1()
        {
            InitializeComponent();

            btnExecuteReader.Click += BtnExecuteReader_Click;
            btnExecuteScalar.Click += BtnExecuteScalar_Click;
            btnExecuteProcedure.Click += BtnExecuteProcedure_Click;
        }

        private void BtnExecuteProcedure_Click(object? sender, EventArgs e)
        {
            //ExecuteStoredProcedureGet();
            ExecuteStoredProcedure("Beşiktas", 1.2M, 1.1M, DateTime.Now);
        }

        private void BtnExecuteScalar_Click(object? sender, EventArgs e)
        {
            ExecuteScalar();
        }

        private void BtnExecuteReader_Click(object? sender, EventArgs e)
        {
            //ExecuteReader(7);
            ExecuteReaderNextResult();
        }

        void ExecuteReader(int value)
        {
            // Northwind DB
            string sql = "SELECT ProductID, ProductName FROM Products WHERE ProductID <= " + value.ToString();
            //string sql = "SELECT ProductID, Name FROM Production.Product WHERE ProductID <=7 "; //AW DB

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text; //default
                cmd.CommandText = sql;

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                StringBuilder builder = new StringBuilder();

                while (reader.Read())
                {
                    builder.Append("**********");
                    builder.Append(Environment.NewLine);
                    builder.Append("Ürün No: ");
                    builder.Append(reader[0]);
                    builder.Append(Environment.NewLine);
                    builder.Append("Ürün Ad: ");
                    builder.Append(reader[1]);
                    builder.Append(Environment.NewLine);

                }

                conn.Close();

                txtResult.Text = builder.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void ExecuteStoredProcedureGet()
        {

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "pr_UrunleriGetir";

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                StringBuilder builder = new StringBuilder();

                while (reader.Read())
                {
                    builder.Append("**********");
                    builder.Append(Environment.NewLine);
                    builder.Append("Ürün No: ");
                    builder.Append(reader.GetInt32(0));
                    builder.Append(Environment.NewLine);
                    builder.Append("Ürün Ad: ");
                    builder.Append(reader[1]);
                    builder.Append(Environment.NewLine);

                }

                conn.Close();

                txtResult.Text = builder.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void ExecuteStoredProcedure(string name, decimal costRate,
                                    decimal availability, DateTime modifiedDate)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "pr_AddLocation";

                SqlParameter pName = new SqlParameter();
                pName.ParameterName = "Name";
                pName.Value = name;
                pName.SqlDbType = SqlDbType.NVarChar;

                SqlParameter pCostRate = new SqlParameter();
                pName.ParameterName = "CostRate";
                pName.Value = costRate;
                pName.SqlDbType = SqlDbType.Decimal;

                SqlParameter pAvailability = new SqlParameter();
                pName.ParameterName = "Availability";
                pName.Value = availability;
                pName.SqlDbType = SqlDbType.Decimal;

                SqlParameter pModifiedDate = new SqlParameter();
                pName.ParameterName = "ModifiedDate";
                pName.Value = modifiedDate;
                pName.SqlDbType = SqlDbType.DateTime;

                cmd.Parameters.Add(pName);
                cmd.Parameters.Add(pCostRate);
                cmd.Parameters.Add(pAvailability);
                cmd.Parameters.Add(pModifiedDate);

                conn.Open();

                int x = cmd.ExecuteNonQuery();

                //conn.Close();

                txtResult.Text = x.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void ExecuteReaderNextResult()
        {
            string sql = "SELECT ProductID, ProductName FROM Products WHERE ProductID <= 5;SELECT CustomerID, CompanyName FROM Customers WHERE CustomerID LIKE 'A%'";

            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text; //default

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                bool bResult = false;

                StringBuilder builder = new StringBuilder();

                do
                {
                    while (reader.Read())
                    {
                        builder.Append("**********");
                        builder.Append(Environment.NewLine);
                        builder.Append("Ürün No: ");
                        builder.Append(reader[0]);
                        builder.Append(Environment.NewLine);
                        builder.Append("Ürün Ad: ");
                        builder.Append(reader[1]);
                        builder.Append(Environment.NewLine);

                    }

                    bResult = reader.NextResult();
                } while (bResult);

                txtResult.Text = builder.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }

        void ExecuteScalar()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text; //default
                cmd.CommandText = "SELECT COUNT(ProductID) FROM Products;";

                conn.Open();

                string s = cmd.ExecuteScalar().ToString();
                txtResult.Text = s + " kayıt bulundu.";

                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}