using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPG223_Shop_System.Forms.LogInForms
{
    public partial class CustomerLogIn : Form
    {
        public CustomerLogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Maintain_Developers myform = new Maintain_Developers();
            myform.ShowDialog();
        }
    }
}
