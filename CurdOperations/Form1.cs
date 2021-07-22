using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace CurdOperations
{
    public partial class Form1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into Employee values (@id,@name,@gender,@age,@position,@salary)";
            SqlCommand cmd = new SqlCommand(query,con);

            cmd.Parameters.AddWithValue("@id",IDtextBox.Text);

            cmd.Parameters.AddWithValue("@name", NametextBox.Text);
            cmd.Parameters.AddWithValue("@gender",GendercomboBox.Text);
            cmd.Parameters.AddWithValue("@age", AgenumericUpDown.Value);
            cmd.Parameters.AddWithValue("@position", PositioncomboBox.Text);
            cmd.Parameters.AddWithValue("@salary", SalarytextBox.Text);

            con.Open();



            try
            {
                int a = cmd.ExecuteNonQuery();
                if (a>0)
                {

                    MessageBox.Show("Inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bindGridview();
                }

                else
                {
                    MessageBox.Show("Please fill all fields", "Failed", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Please fill up all field");
            }
              



            con.Close();



        }

        void bindGridview()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select*from Employee";
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;


        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            bindGridview();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            IDtextBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
           NametextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

            GendercomboBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            AgenumericUpDown.Value =Convert.ToInt32( dataGridView1.SelectedRows[0].Cells[3].Value);
            PositioncomboBox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            SalarytextBox.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }
    }
}
