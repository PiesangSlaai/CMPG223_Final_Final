using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CMPG223_Shop_System
{
    public partial class Log_In : Form
    {
        //created method for rounding the edges of the form
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse

        );
            

        
        public Log_In()
        {
            //Login button is highlighted when form loads
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));  //calls the method to round form 
            pnlNavigate.Height = btnLogIn.Height;
            pnlNavigate.Top = btnLogIn.Top;
            pnlNavigate.Left = btnLogIn.Left;
            btnLogIn.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Log_In_Load(object sender, EventArgs e)
        {
           
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            //when buttons are clicked they are highlighted to show the user what he/she has selected
            pnlNavigate.Height = btnLogIn.Height;
            pnlNavigate.Top = btnLogIn.Top;
            pnlNavigate.Left = btnLogIn.Left;
            btnLogIn.BackColor = Color.FromArgb(46, 51, 73);

            Trans1.HideSync(pBoxLogo);

            Forms.LogInForms.CustomerLogIn child = new Forms.LogInForms.CustomerLogIn();
            child.MdiParent = this;
            child.Show();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            pnlNavigate.Height = btnCreateAccount.Height;
            pnlNavigate.Top = btnCreateAccount.Top;
            btnCreateAccount.BackColor = Color.FromArgb(46, 51, 73);

            Trans1.HideSync(pBoxLogo);

            Forms.LogInForms.CustomerCreateAccount child2 = new Forms.LogInForms.CustomerCreateAccount();
            child2.MdiParent = this;
            child2.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            pnlNavigate.Height = btnExit.Height;
            pnlNavigate.Top = btnExit.Top;
            btnExit.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnLogIn_Leave(object sender, EventArgs e)
        {
            //when the user removes his/her cursor from the button then it is no longer highlighted 
            btnLogIn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCreateAccount_Leave(object sender, EventArgs e)
        {
            btnCreateAccount.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnExit_Leave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void pnlNavigate_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
