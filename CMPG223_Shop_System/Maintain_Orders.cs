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

namespace CMPG223_Shop_System
{
    public partial class Maintain_Orders : Form
    {
        public Maintain_Orders()
        {
            InitializeComponent();
        }
        //Initializing global variables to connect to the database.
        string SQL = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\27677\Documents\CMPG223\CMPG223_Project_Submission\CMPG223_Shop_System\Database1.mdf;Integrated Security=True;Connect Timeout=30";
        public SqlConnection conn;
        public SqlDataAdapter adapter;
        public SqlCommand command;
        public DataSet fill;
        public SqlDataReader reader;

        //declaring variables
        public string orderID;
        public string orderName;
        public string consoleName;
        public string gameName;
        public string location;
        public string dateOfTransaction;

        //Ensuring that the databse is successfully connected.
        private void Maintain_Orders_Load(object sender, EventArgs e)
        {
            txtOrderID.Focus();

            try
            {
                conn = new SqlConnection(SQL);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    MessageBox.Show("Database connection succesful");
                }
                else
                {
                    MessageBox.Show("Database connection failed");
                }
                conn.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Method to displayOrders on dataGridView.
        private void DisplayOrder()
        {
            try
            {
                conn.Open();
                string conStr = ("SELECT * FROM OrderTable");
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand(conStr, conn);
                adapter.SelectCommand = command;

                DataSet fill = new DataSet();
                adapter.Fill(fill, "OrderTable");

                myGridView.DataSource = fill;
                myGridView.DataMember = "OrderTable";
                conn.Close();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //Method to delete a order from the database.
        private void Delete()
        {
            try
            {
                conn = new SqlConnection(SQL);
                conn.Open();

                string delete = ("DELETE FROM OrderTable WHERE Order_ID = '" + txtOrderID.Text + "'");
                command = new SqlCommand(delete, conn);
                adapter = new SqlDataAdapter();
                adapter.DeleteCommand = command;
                adapter.DeleteCommand.ExecuteNonQuery();

                conn.Close();

                string select = ("SELECT * FROM OrderTable");
                adapter = new SqlDataAdapter();
                command = new SqlCommand(select, conn);

                adapter.SelectCommand = command;

                fill = new DataSet();
                adapter.Fill(fill, "OrderTable");
                myGridView.DataSource = fill;
                myGridView.DataMember = "OrderTable";

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Calling the delete method.
            Delete();
        }

        //Filter according to the Order Name.
        private void FilterOrderName()
        {
            try
            {
                conn = new SqlConnection(SQL);


                conn.Open();
                string openSeats = ("SELECT * FROM OrderTable WHERE Order_ID = '" + txt_OrderName.Text + "'");
                command = new SqlCommand(openSeats, conn);
                adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                fill = new DataSet();
                adapter.Fill(fill, "OrderTable");
                myGridView.DataSource = fill;
                myGridView.DataMember = "OrderTable";

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
    

        private void txt_OrderName_TextChanged(object sender, EventArgs e)
        {
            //Calling the Filter methos, OrderName.
            FilterOrderName();
        }

        //Method to Filter according to the Game Name.
        private void FilterGameName()
        {
            try
            {
                conn = new SqlConnection(SQL);


                conn.Open();
                string openSeats = ("SELECT * FROM OrderTable WHERE Game_ID = '" + txt_GameName.Text + "'");
                command = new SqlCommand(openSeats, conn);
                adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                fill = new DataSet();
                adapter.Fill(fill, "OrderTable");
                myGridView.DataSource = fill;
                myGridView.DataMember = "OrderTable";

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void txt_GameName_TextChanged(object sender, EventArgs e)
        {
            //Calling the filter method GameName.
            FilterGameName();
        }

        //Method to Filter according to the ConsolName.
        private void FilterConsoleName()
        {
            try
            {
                conn = new SqlConnection(SQL);


                conn.Open();
                string openSeats = ("SELECT * FROM OrderTable  WHERE Console_ID = '" + txt_ConsoleName.Text + "'");
                command = new SqlCommand(openSeats, conn);
                adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                fill = new DataSet();
                adapter.Fill(fill, "OrderTable");
                myGridView.DataSource = fill;
                myGridView.DataMember = "OrderTable";

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void txt_ConsoleName_TextChanged(object sender, EventArgs e)
        {
            //Calling the Filter method ConsoleName
            FilterConsoleName();
        }

        //Method to Filter according to the location.
        private void Location_()
        {
            try
            {
                conn = new SqlConnection(SQL);


                conn.Open();
                string openSeats = ("SELECT * FROM OrderTable WHERE Location_ID = '" + txt_Location.Text + "'");
                command = new SqlCommand(openSeats, conn);
                adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                fill = new DataSet();
                adapter.Fill(fill, "OrderTable");
                myGridView.DataSource = fill;
                myGridView.DataMember = "OrderTable";

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void txt_Location_TextChanged(object sender, EventArgs e)
        {
            //Calling the location method.
            Location_();
         }

        //Filter according to the date of transaction
        private void dtp_DateOfTrans_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateOfTransaction = dtp_DateOfTrans.Value;

            command = new SqlCommand("SELECT * FROMOrderTable Where Order_Date = '" + dateOfTransaction + "'", conn);
            adapter = new SqlDataAdapter();
            fill = new DataSet();

            adapter.SelectCommand = command;
            adapter.Fill(fill, "Date" );

            myGridView.DataSource = fill;
            myGridView.DataMember = "Date";
        }
    }
    
}
