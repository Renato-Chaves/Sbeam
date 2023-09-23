using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        MyDBConnection dbConn = new MyDBConnection();
        public Register(Login _login)
        {
            login = _login;
            InitializeComponent();
        }

        private void Login_link_Click(object sender, EventArgs e)
        {
            SwitchPages();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (UsernameInput.Text == "" || PasswordInput.Text == "" || PasswordConfirmInput.Text == "")
            {
                MessageBox.Show(" Por favor complete todos os campos.");
            }
            else if (PasswordInput.Text != PasswordConfirmInput.Text)
            {
                MessageBox.Show("Senha não condiz com sua confirmação, por favor verifique.");
            }
            else if (PasswordInput.Text != " " && (PasswordInput.Text != "" || PasswordInput.Text != " ") && PasswordConfirmInput.Text != " ")
            {
                dbConn.Querry(("insert into Users values(null, '" + UsernameInput.Text + "', '" + PasswordInput.Text + "', '" + 0 + "')"));
                SwitchPages();
                MessageBox.Show("Conta criada com sucesso!");
            }
        }

        private void SwitchPages()
        {
            login.FillRegister(this);
            login.Show();
            this.Hide();

            CleanInputs();
        }

        private void CleanInputs()
        {
            UsernameInput.Text = string.Empty;
            PasswordInput.Text = string.Empty;
            PasswordConfirmInput.Text = string.Empty;
        }
    }
}
