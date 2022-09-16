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

namespace CMPG223_Shop_System.Forms
{
    public partial class Maintain_Developers : Form
    {
        public SqlConnection con;
        public SqlDataAdapter adapter;
        public DataSet ds;
        public SqlCommand command;
        public string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\JK_Pienaar_34227857_Assignment2\JK_Pienaar_34227857_Assignment2\App_Data\Dance.mdf;Integrated Security=True";

        //declaring variables
        public int id;
        public string console;
        public string game;
        public string name;
        public Maintain_Developers()
        {
            InitializeComponent();
        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(conn);// creating new connection
                // Opening connection to the database
                con.Open();
             

                string sql = @"SELECT * FROM Companies WHERE Developer_Name LIKE '%" + txtName.Text + "%'";
                SqlCommand command = new SqlCommand(sql, con);

                   SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet dataSet = new DataSet();
                // Filling the dataset
                adapter.SelectCommand = command;
                adapter.Fill(dataSet, "Companies");

                //Adding the data into the data grid

                dataGridView1.DataSource = dataSet;
                dataGridView1.DataMember = "Companies";

                // Closing the connection to the database
                con.Close();
            }

            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(conn);// creating new connection
                con.Open();// opening connection

                string sql = @"DELETE FROM Dance WHERE Genre = '" + txtID.Text + "'";
                ds = new DataSet();
                adapter = new SqlDataAdapter();


                command = new SqlCommand(sql, con);
                adapter.SelectCommand = command;
                adapter.Fill(ds);

                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = ("Dancers"); 

                con.Close();

                con = new SqlConnection(conn);// creating new connection
                con.Open();// opening connection

                sql = @"SELECT * FROM Dance";
                ds = new DataSet();
                adapter = new SqlDataAdapter();


                command = new SqlCommand(sql, con);
                adapter.SelectCommand = command;
                adapter.Fill(ds);

                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = ("Dancers"); 

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);// display error message
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //declaring variables
            id = int.Parse(txtDID.Text);
            console = txtConsole.Text;
            game = txtGame.Text;
            name = txtDName.Text;


            try
            {
                con = new SqlConnection(conn);// creating new connection
                con.Open();// opening connection

                string sql = $"INSERT INTO Dance(BookingID,Name,Surname,Genre)VALUES({id}, '{console}','{game}','{name}')";


                command = new SqlCommand(sql, con);
                command.ExecuteNonQuery();

                con.Close();

                txtID.Text = "";
                txtConsole.Text = "";
                txtGame.Text = "";
                txtDName.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);// display error message
            }

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
    }
    

