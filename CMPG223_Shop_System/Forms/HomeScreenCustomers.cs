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

namespace CMPG223_Shop_System.Forms
{
    public partial class HomeScreenCustomers : Form
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
        public HomeScreenCustomers()
        {
            //Home button is highlighted when form loads
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNavigate.Height = btnHome.Height;
            pnlNavigate.Top = btnHome.Top;
            pnlNavigate.Left = btnHome.Left;
            btnHome.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void HomeScreenCustomers_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //when buttons are clicked they are highlighted to show the user what he/she has selected
            pnlNavigate.Height = btnHome.Height;
            pnlNavigate.Top = btnHome.Top;
            pnlNavigate.Left = btnHome.Left;
            btnHome.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnMaintainGames_Click(object sender, EventArgs e)
        {
            pnlNavigate.Height = btnBrowseGames.Height;
            pnlNavigate.Top = btnBrowseGames.Top;
            btnBrowseGames.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnMaintainConsoles_Click(object sender, EventArgs e)
        {
            pnlNavigate.Height = btnBrowseConsoles.Height;
            pnlNavigate.Top = btnBrowseConsoles.Top;
            btnBrowseConsoles.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlNavigate.Height = btnSettings.Height;
            pnlNavigate.Top = btnSettings.Top;
            btnSettings.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            pnlNavigate.Height = btnExit.Height;
            pnlNavigate.Top = btnExit.Top;
            btnExit.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnHome_Leave(object sender, EventArgs e)
        {
            //when the user removes his/her cursor from the button then it is no longer highlighted 
            btnHome.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnBrowseGames_Leave(object sender, EventArgs e)
        {
            btnBrowseGames.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnBrowseConsoles_Leave(object sender, EventArgs e)
        {
            btnBrowseConsoles.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnExit_Leave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
