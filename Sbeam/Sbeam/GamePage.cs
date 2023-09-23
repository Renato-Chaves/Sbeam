using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sbeam
{
    public partial class GamePage : Form
    {
        MyDBConnection db;
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlCommand cmd2;
        MySqlCommand cmd3;
        string cd_game;
        string cd_user;
        StorePage storePage;

        public GamePage(StorePage _storePage, string _cd_game, string _cd_user)
        {
            storePage = _storePage;
            cd_game = _cd_game;
            cd_user = _cd_user;
            db = new MyDBConnection();

            InitializeComponent();
            conn = db.DBConnect();
            UpdateGameInfo(cd_game);
        }

        public void UpdateGameInfo(string cd_game)
        {
            cmd = new MySqlCommand("select * from Games where cd_game = @cd_game", conn);
            cmd.Parameters.AddWithValue("@cd_game", cd_game);

            try
            {
                conn.Open();
                MySqlDataAdapter adpt = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpt.Fill(ds);
                DataTable dt = ds.Tables[0];

                foreach (DataRow dr in dt.Rows)
                {
                    MainGameTitle.Text = dr["nm_title"].ToString();
                    GameTitleText.Text = "Wishlist " + dr["nm_title"].ToString();
                    if (dr["base_price"].ToString() == "0") GamePrice.Text = "Free";
                    else GamePrice.Text = "R$ " + dr["base_price"];
                    GameDescription.Text = dr["str_desc"].ToString();
                    ReleaseDateTxt.Text = dr["release_date"].ToString();
                    PublisherTxt.Text = dr["publisher"].ToString();
                    DeveloperTxt.Text = dr["developer"].ToString();
                    GameCover.Load(dr["cover"].ToString());


                    cmd2 = new MySqlCommand("Select nm_tag from Game_Tags inner join Tags on cd_tag = id_tag inner join Games on cd_game = id_game where id_game = @cd_game;", conn);
                    cmd2.Parameters.AddWithValue("@cd_game", cd_game);
                    MySqlDataAdapter adpt2 = new MySqlDataAdapter(cmd2);
                    DataSet ds2 = new DataSet();
                    adpt2.Fill(ds2);
                    DataTable dt2 = ds2.Tables[0];

                    cmd3 = new MySqlCommand("Select id_user from Wishlist where id_user = @id_user && id_game = @id_game", conn);
                    cmd3.Parameters.AddWithValue("@id_game", cd_game);
                    cmd3.Parameters.AddWithValue("@id_user", cd_user);
                    MySqlDataAdapter adpt3 = new MySqlDataAdapter(cmd3);
                    DataSet ds3 = new DataSet();
                    adpt3.Fill(ds3);
                    DataTable dt3 = ds3.Tables[0];

                    if(dt3.Rows.Count > 0)
                    {
                        WishlistBtn.Text = "Wishlisted";
                        WishlistBtn.BackColor = Color.DarkCyan;
                    }
                    else
                    {
                        WishlistBtn.Text = "Wishlist";
                        WishlistBtn.BackColor = Color.FromArgb(0, 106, 43);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }
        }

        public void UpdateUserInfo(string _cd_user)
        {
            cd_user = _cd_user;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            storePage.Show();
        }

        private void WishlistBtn_Click(object sender, EventArgs e)
        {
            if(WishlistBtn.Text.Equals("Wishlist")) db.Querry("insert into Wishlist Values ("+cd_game+", "+cd_user+");");

        }
    }
}
