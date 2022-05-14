using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {

        string connectionstring = "server=DESKTOP-96JHUCM; database=carmanagement; Integrated Security=true";

        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();

            connection = new SqlConnection(connectionstring);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string command ="select * from cars";

            SqlCommand sqlcommand = new SqlCommand(command, connection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlcommand);

            DataTable dt = new DataTable();

            sqlDataAdapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string carbrand = txtcarbrand.Text;
            string carversion = txtcarversion.Text;
            string platenumber = txtplatenumber.Text;

            string command = $"insert into cars values('{carbrand}', '{carversion}', '{platenumber}')";
            SqlCommand sqlcommand = new SqlCommand(command, connection);
            if(connection.State != ConnectionState.Open)
                connection.Open();

            sqlcommand.ExecuteNonQuery();

            connection.Close();
        }
    }
}
