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
    public partial class Login : Form
    {
        Register register;
        public Login()
        {
            InitializeComponent();
        }

        private void Register_link_Click(object sender, EventArgs e)
        {
            if (register != null)
            {
                this.Hide();
                register.Show();
            }
            else
            {
                Register Register = new Register(this);
                this.Hide();
                Register.Show();
            }
        }

        public void FillRegister(Register _register)
        {
            register = _register;
        }
    }
}
