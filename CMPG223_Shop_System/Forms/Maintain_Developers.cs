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
        public string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Desktop\CMPG223_Final_Final\CMPG223_Shop_System\Database1.mdf;Integrated Security = True; Connect Timeout = 30";

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
             

                string sql = @"SELECT * FROM DeveloperTable WHERE Developer_Name LIKE '%" + txtName.Text + "%'";
                SqlCommand command = new SqlCommand(sql, con);

                   SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet dataSet = new DataSet();
                // Filling the dataset
                adapter.SelectCommand = command;
                adapter.Fill(dataSet, "DeveloperTable");

                //Adding the data into the data grid

                dataGridView1.DataSource = dataSet;
                dataGridView1.DataMember = "DeveloperTable";

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

                string sql = @"DELETE FROM DeveloperTable WHERE Developer_ID = '" + txtID.Text + "'";
                ds = new DataSet();
                adapter = new SqlDataAdapter();


                command = new SqlCommand(sql, con);
                adapter.SelectCommand = command;
                adapter.Fill(ds);

                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = ("DeveloperTable"); 

                con.Close();

                con = new SqlConnection(conn);// creating new connection
                con.Open();// opening connection

                sql = @"SELECT * FROM DeveloperTable";
                ds = new DataSet();
                adapter = new SqlDataAdapter();


                command = new SqlCommand(sql, con);
                adapter.SelectCommand = command;
                adapter.Fill(ds);

                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = ("DeveloperTable"); 

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

                string sql = $"INSERT INTO DeveloperTable(Developer_ID,Console_ID,Game_ID,Developer_Name)VALUES({id}, '{console}','{game}','{name}')";


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

        private void Maintain_Developers_Load(object sender, EventArgs e)
        {
            
            con = new SqlConnection(conn);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                MessageBox.Show("Connection Succesful");
            }
            else
            {
                MessageBox.Show("Connection Failed");
            }
            
            ds = new DataSet();



            string sql = "Select * from DeveloperTable";
            SqlCommand command = new SqlCommand(sql, con);

            SqlDataAdapter adapter = new SqlDataAdapter();
            // Filling the dataset
            adapter.SelectCommand = command;
            adapter.Fill(ds, "DeveloperTable");

            //Adding the data into the data grid

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "DeveloperTable";
            con.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }
    

