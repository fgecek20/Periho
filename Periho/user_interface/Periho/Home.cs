using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Periho
{
    public partial class Home : Form
    {
        public Home(string loggedUser)
        {
            InitializeComponent();
            lblWelcome.Text += loggedUser;
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
