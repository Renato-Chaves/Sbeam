using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sbeam
{
    public partial class Register : Form
    {
        Login login;
        public Register(Login _login)
        {
            login = _login;
            InitializeComponent();
        }

        private void Login_link_Click(object sender, EventArgs e)
        {
            login.FillRegister(this);
            login.Show();
            this.Hide();
        }
    }
}
