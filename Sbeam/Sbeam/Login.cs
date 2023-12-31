﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sbeam
{
    public partial class Login : Form
    {
        Register register;
        StorePage storePage;
        private string cd_user;
        public Login()
        {
            InitializeComponent();
        }

        private void Register_link_Click(object sender, EventArgs e)
        {
            if (register == null) register = new Register(this);
            this.Hide();
            register.Show();
            CleanInputs();
        }

        public void FillRegister(Register _register)
        {
            register = _register;
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            //AddGame addGame = new AddGame();
            //addGame.Show();
            //if(register != null) register.Hide();
            //this.Hide();

            if (UsernameInput.Text == "" && PasswordInput.Text == "")
            {
                MessageBox.Show(" Por favor coloque o nome de usuário e a senha.");
            }
            else
            {

                string connectionString = "Data Source=sql10.freesqldatabase.com; username=sql10647862; password=35ASdvQdUI; database=sql10647862";
                MySqlConnection conn = new MySqlConnection(connectionString);
                MySqlCommand cmd = new MySqlCommand("select * from Users where nm_username=@UserName and password=@UserPass", conn);
                try
                {
                    cmd.Parameters.AddWithValue("@UserName", UsernameInput.Text);
                    cmd.Parameters.AddWithValue("@UserPass", PasswordInput.Text);

                    conn.Open();
                    MySqlDataAdapter adpt = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adpt.Fill(ds);

                    int count = ds.Tables[0].Rows.Count;

                    if (count == 1)
                    {
                        cd_user = ds.Tables[0].Rows[0]["cd_user"].ToString();

                        if (storePage == null) storePage = new StorePage(this, cd_user);
                        else storePage.AdmCheck(this, cd_user);
                        this.Hide();
                        CleanInputs();
                        storePage.Show();
                    }
                    else MessageBox.Show("Nome de usuário e senha incorretos");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { conn.Close(); }

            }
        }

        private void CleanInputs()
        {
            UsernameInput.Text = string.Empty;
            PasswordInput.Text = string.Empty;
        }
    }
}
