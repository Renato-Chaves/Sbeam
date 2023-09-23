using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using MySql.Data.MySqlClient;

namespace Sbeam
{
    public partial class StorePage : Form
    {
        string cd_user;
        Login login;
        AddGame addGame;
        public StorePage(Login _login, string _cd_user)
        {
            AdmCheck(_login, _cd_user);
        }

        //Returns to LoginPage
        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddGameBtn.Visible = false;
            login.Show();
        }

        //Check if logged account has Administrator privilages
        public void AdmCheck(Login _login, string _cd_user)
        {
            login = _login;
            cd_user = _cd_user;
            MyDBConnection db = new MyDBConnection();
            MySqlConnection conn = db.DBConnect();
            MySqlCommand cmd = new MySqlCommand("Select is_adm from Users where cd_user = " + cd_user, conn);
            InitializeComponent();
            try
            {
                conn.Open();
                MySqlDataAdapter adpt = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpt.Fill(ds);

                if (ds.Tables[0].Rows[0]["is_adm"].ToString().Equals("1"))
                {
                    AddGameBtn.Visible = true;
                    AddGameBtn.Refresh();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally { conn.Close(); }
        }

        //Open AddGamePage
        private void AddGameBtn_Click(object sender, EventArgs e)
        {
            if (addGame == null) addGame = new AddGame(this);
            this.Hide();
            addGame.Show();
        }

        //When tag All is Clicked
        private void TagAll_Click(object sender, EventArgs e)
        {
            TagList.SelectionMode = SelectionMode.None;
            TagList.SelectionMode = SelectionMode.One;
        }
    }
}
