using Example15_Adonet;
using System.Data;
using System.Data.SqlClient;

namespace Example15
{
    public partial class Form2DisconnectedArch : Form
    {
        SqlDataAdapter adapter = null;
        DataTable dt = null;
        SqlCommandBuilder cmdBuilder = null;
        public Form2DisconnectedArch()
        {
            InitializeComponent();

            btnUygula.Click += BtnUygula_Click;
            btnFill.Click += BtnFill_Click;
        }

        private void BtnFill_Click(object? sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("Select * from Shippers", Connection.ConnectionString);
            dt = new DataTable();
            adapter.Fill(dt);
            dg.DataSource = dt;
        }

        private void BtnUygula_Click(object? sender, EventArgs e)
        {
            cmdBuilder = new SqlCommandBuilder(adapter);
            adapter.Update(dt);
        }
    }
}
