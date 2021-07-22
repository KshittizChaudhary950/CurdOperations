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
            // Doublicate insert part
            string query2 = "select*from Employee where Id=@id";
            SqlCommand cmd2 = new SqlCommand(query2,con);
            cmd2.Parameters.AddWithValue("@id",IDtextBox.Text);
            con.Open();
           SqlDataReader dr= cmd2.ExecuteReader();
            if (dr.HasRows)
            {
                MessageBox.Show(IDtextBox.Text + " is already exists in record", "Faliure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con.Close();

            }
            else
            {


                con.Close();


                // Insert part

                string query = "insert into Employee values (@id,@name,@gender,@age,@position,@salary)";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@id", IDtextBox.Text);

                cmd.Parameters.AddWithValue("@name", NametextBox.Text);
                cmd.Parameters.AddWithValue("@gender", GendercomboBox.Text);
                cmd.Parameters.AddWithValue("@age", AgenumericUpDown.Value);
                cmd.Parameters.AddWithValue("@position", PositioncomboBox.Text);
                cmd.Parameters.AddWithValue("@salary", SalarytextBox.Text);

                con.Open();



                try
                {
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {

                        MessageBox.Show("Inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bindGridview();
                    }

                    else
                    {
                        MessageBox.Show("Please fill all fields in correct manner", "Failed", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Please fill up all field");
                }




                con.Close();
                clear();
            }



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
            try
            {
                IDtextBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                NametextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

                GendercomboBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                AgenumericUpDown.Value = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[3].Value);
                PositioncomboBox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                SalarytextBox.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Please select in id row");
            }
       
        }

        private void Update_Click(object sender, EventArgs e)
        {
            //update 
            SqlConnection con = new SqlConnection(cs);
            string query = "Update Employee set Id=@id, name=@name, Gender=@gender, Age=@age, position=@position, salary=@salary where Id=@id";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@id", IDtextBox.Text);

            cmd.Parameters.AddWithValue("@name", NametextBox.Text);
            cmd.Parameters.AddWithValue("@gender", GendercomboBox.Text);
            cmd.Parameters.AddWithValue("@age", AgenumericUpDown.Value);
            cmd.Parameters.AddWithValue("@position", PositioncomboBox.Text);
            cmd.Parameters.AddWithValue("@salary", SalarytextBox.Text);

            con.Open();



            try
            {
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {

                    MessageBox.Show("Update successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bindGridview();
                }

                else
                {
                    MessageBox.Show("Update is fail", "Failed", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Please fill up all field");
            }




            con.Close();
            clear();


        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "delete from Employee where Id=@id";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@id", IDtextBox.Text);

           
            con.Open();



            try
            {
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {

                    MessageBox.Show("Deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bindGridview();
                }

                else
                {
                    MessageBox.Show("Deletion  is fail", "Failed", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Please fill up all field");
            }




            con.Close();
            clear();
        }
        void clear()
        {
            IDtextBox.Clear();
            NametextBox.Clear();
            GendercomboBox.SelectedItem=null ;
            AgenumericUpDown.Value=0;
            PositioncomboBox.SelectedItem=null;
            SalarytextBox.Clear();
            IDtextBox.Focus();
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            if(SearchtextBox.Text!="")
            {
                // working on search
                SqlConnection con = new SqlConnection(cs);
                string query = "select*from Employee where name like @name + '%'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.Parameters.AddWithValue("@name", SearchtextBox.Text.Trim());

                DataTable data = new DataTable();
                sda.Fill(data);

                if(data.Rows.Count>0)
                {
                    dataGridView1.DataSource = data;

                }
                else
                {
                    MessageBox.Show("No data is found");
                    dataGridView1.DataSource = null;
                }

                SearchtextBox.Clear();



            }

            else
            {

                MessageBox.Show("Please enter some value to search !!");

            }

        }

        private void SearchtextBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchtextBox.Text != "")
            {
                // auto generated in text bar search
                SqlConnection con = new SqlConnection(cs);
                string query = "select*from Employee where name like @name + '%'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.Parameters.AddWithValue("@name", SearchtextBox.Text.Trim());

                DataTable data = new DataTable();
                sda.Fill(data);

                if (data.Rows.Count > 0)
                {
                    dataGridView1.DataSource = data;

                }
                else
                {
                  
                    dataGridView1.DataSource = null;
                }


            }
            else
            {
                SearchtextBox.Focus();
            }

        

        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            SearchtextBox.Clear();
            IDtextBox.Clear();
            NametextBox.Clear();
            GendercomboBox.SelectedItem = null;
            AgenumericUpDown.Value = 0;
            PositioncomboBox.SelectedItem = null;
            SalarytextBox.Clear();
            IDtextBox.Focus();
        }
    }
}
