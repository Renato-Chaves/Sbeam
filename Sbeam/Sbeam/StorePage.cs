using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace Sbeam
{
    public partial class StorePage : Form
    {
        string cd_user;
        string lastQuarry;
        int gamePageOffset = 0;
        Login login;
        AddGame addGame;
        GamePage gamePage;
        MyDBConnection db;
        MySqlConnection conn;
        MySqlCommand cmd;
        bool isTagAll = true;

        PictureBox[] gameCovers;
        Label[] gameTitles;
        TextBox[] gamePrices;
        PictureBox[,] gamePlatforms;
        TextBox[] gameTags;

        public StorePage(Login _login, string _cd_user)
        {
            AdmCheck(_login, _cd_user);

            gameCovers = new PictureBox[5] { Game0Cover, Game1Cover, Game2Cover, Game3Cover, Game4Cover };
            gameTitles = new Label[5] { Game0Title, Game1Title, Game2Title, Game3Title, Game4Title };
            gamePrices = new TextBox[5] { Game0Price, Game1Price, Game2Price, Game3Price, Game4Price };
            gameTags = new TextBox[5] { Game0Tags, Game1Tags, Game2Tags, Game3Tags, Game4Tags };
            gamePlatforms = new PictureBox[5, 3] {{ Game0Windows, Game0Apple, Game0Linux },
                                                  { Game1Windows, Game1Apple, Game1Linux },
                                                  { Game2Windows, Game2Apple, Game2Linux },
                                                  { Game3Windows, Game3Apple, Game3Linux },
                                                  { Game4Windows, Game4Apple, Game4Linux }};

            db = new MyDBConnection();
            conn = db.DBConnect();
            lastQuarry = "Select cd_game, nm_title, cover, base_price from Games Order By nm_title Asc Limit 5";
            UpdateGameList(lastQuarry);
            ChangePage(-1);
            FillTagList();
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
            isTagAll = true;
            TagList.ClearSelected();
            ChangePage(-50);
            lastQuarry = "Select cd_game, nm_title, cover, base_price from Games Order By nm_title Asc Limit 5";
            UpdateGameList(lastQuarry);
        }

        //When tag in selected
        private void TagClicked(object sender, EventArgs e)
        {
            isTagAll = false;
            string tagIndex = TagList.SelectedIndex.ToString();
            if (Int32.Parse(tagIndex) >= 0)
            {
                ChangePage(-50);
                lastQuarry = "select cd_game, nm_title, cover, base_price from Games inner join Game_Tags on cd_game = id_game where id_tag = " + tagIndex + " Limit 5 ";
                UpdateGameList(lastQuarry);
            }

        }

        //Update games listed in page
        private void UpdateGameList(string cmdString)
        {
            ClearGamelist();
            cmd = new MySqlCommand(cmdString, conn);
            try
            {
                conn.Open();
                MySqlDataAdapter adpt = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpt.Fill(ds);
                DataTable dt = ds.Tables[0];

                int i = 0;
                string curCdGame;
                foreach (DataRow dr in dt.Rows)
                {
                    MySqlCommand cmd2 = new MySqlCommand("Select nm_tag from Game_Tags inner join Tags on cd_tag = id_tag inner join Games on cd_game = id_game where id_game = @cd_game;", conn);
                    cmd2.Parameters.AddWithValue("@cd_game", dt.Rows[i]["cd_game"]);
                    MySqlDataAdapter tagAdpt = new MySqlDataAdapter(cmd2);
                    DataSet dsTag = new DataSet();
                    tagAdpt.Fill(dsTag);
                    DataTable dtTag = dsTag.Tables[0];

                    MySqlCommand cmd3 = new MySqlCommand("Select id_platform from Game_Platform where id_game = @cd_game", conn);
                    cmd3.Parameters.AddWithValue("@cd_game", dt.Rows[i]["cd_game"]);
                    MySqlDataAdapter platAdpt = new MySqlDataAdapter(cmd3);
                    DataSet dsPlat = new DataSet();
                    platAdpt.Fill(dsPlat);
                    DataTable dtPlat = dsPlat.Tables[0];

                    int tagI = 0;
                    gameCovers[i].Load(dt.Rows[i]["cover"].ToString());
                    gameTitles[i].Text = dt.Rows[i]["nm_title"].ToString();
                    if (dt.Rows[i]["base_price"].ToString() == "0") gamePrices[i].Text = "Free";
                    else gamePrices[i].Text = "R$ " + dt.Rows[i]["base_price"].ToString();

                    foreach (DataRow drTag in dtTag.Rows)
                    {
                        if (tagI == 0)
                        {
                            gameTags[i].Text = drTag["nm_tag"].ToString();
                            tagI++;
                        }
                        else gameTags[i].Text += " | " + drTag["nm_Tag"].ToString();
                    }

                    foreach (DataRow drPlat in dtPlat.Rows)
                    {
                        switch (drPlat["id_platform"])
                        {
                            case 1:
                                gamePlatforms[i, 0].Visible = true;
                                break;
                            case 2:
                                gamePlatforms[i, 1].Visible = true;
                                break;
                            case 3:
                                gamePlatforms[i, 2].Visible = true;
                                break;
                        }
                    }

                    i++;
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }
        }

        //Check if the arrow buttons are clicked
        public void ArrowClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Name == "NextPageBtn") ChangePage(1);
            else if (btn.Name == "PrevPageBtn") ChangePage(-1);
        }

        //Handles changing page and updating game list
        private void ChangePage(int x)
        {
            ClearGamelist();
            gamePageOffset += x * 5;
            if (gamePageOffset < 0) gamePageOffset = 0;
            UpdateGameList(lastQuarry + " Offset " + gamePageOffset);

            MySqlCommand cmdCount;
            if (TagList.SelectedIndex >= 0) cmdCount = new MySqlCommand("select id_game from Game_Tags where id_tag = " + TagList.SelectedIndex, conn);
            else cmdCount = new MySqlCommand("select cd_game from Games", conn);

            MySqlCommand cmdCount2;
            if (TagList.SelectedIndex >= 0) cmdCount2 = new MySqlCommand("Select id_game from Game_Tags where id_tag = " + TagList.SelectedIndex + " Limit 5 Offset " + gamePageOffset, conn);
            else cmdCount2 = new MySqlCommand("Select cd_game from Games Limit 5 Offset " + gamePageOffset, conn);

            try
            {
                conn.Open();
                MySqlDataAdapter adptCount = new MySqlDataAdapter(cmdCount);
                MySqlDataAdapter adptCount2 = new MySqlDataAdapter(cmdCount2);
                DataSet dsCount = new DataSet();
                DataSet dsCount2 = new DataSet();
                adptCount.Fill(dsCount);
                adptCount2.Fill(dsCount2);

                int count = dsCount.Tables[0].Rows.Count;
                int count2 = dsCount2.Tables[0].Rows.Count;
                PageText.Text = ("Games " + (gamePageOffset + count2) + "/" + count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }

        //Clears game list for updating purposes
        private void ClearGamelist()
        {
            foreach (PictureBox cover in gameCovers)
            {
                cover.Image = null;
            }

            foreach (Label gameTitle in gameTitles)
            {
                gameTitle.Text = string.Empty;
            }

            foreach (TextBox gamePrice in gamePrices)
            {
                gamePrice.Text = string.Empty;
            }

            foreach (TextBox gameTag in gameTags)
            {
                gameTag.Text = string.Empty;
            }

            for (int i = 0; i < gamePlatforms.GetLength(0); i++)
            {
                for (int j = 0; j < gamePlatforms.GetLength(1); j++)
                {
                    gamePlatforms[i, j].Visible = false;
                }
            }
        }

        private void FillTagList()
        {
            MySqlCommand cmd = new MySqlCommand("select nm_tag from Tags", conn);
            try
            {
                conn.Open();
                cmd = new MySqlCommand("SELECT cd_tag, nm_tag FROM Tags", conn);
                MySqlDataReader rdr;
                rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("nm_tag", typeof(string));
                dt.Load(rdr);

                foreach (DataRow row in dt.Rows)
                {
                    string nm_tag = row["nm_tag"].ToString();
                    TagList.Items.Add(nm_tag);
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }
        }

        private void GameTitleBtn(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            string gameName = lbl.Text.ToString();

            cmd = new MySqlCommand("Select cd_game from Games where nm_title = @nm_title", conn);
            cmd.Parameters.AddWithValue("@nm_title", gameName);
            try
            {
                conn.Open();
                MySqlDataAdapter adpt = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpt.Fill(ds);

                int count = ds.Tables[0].Rows.Count;
                if (count > 0)
                {

                    if (gamePage == null) gamePage = new GamePage(this, ds.Tables[0].Rows[0]["cd_game"].ToString(), cd_user);
                    else
                    {
                        gamePage.UpdateGameInfo(ds.Tables[0].Rows[0]["cd_game"].ToString());
                        gamePage.UpdateUserInfo(cd_user);
                    }
                    this.Hide();
                    gamePage.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }

        private void MostWishedBtn_Click(object sender, EventArgs e)
        {
            isTagAll = false;
            TagList.ClearSelected();
            ChangePage(-50);
            lastQuarry = "select cd_game, nm_title, cover, base_price, count(id_game) as wishlisted from Wishlist inner join Games on cd_game = id_game group by id_game order by wishlisted desc Limit 5 ";
            UpdateGameList(lastQuarry);
        }

        private void WishlistBtn_Click(object sender, EventArgs e)
        {
            isTagAll = false;
            TagList.ClearSelected();
            ChangePage(-50);
            lastQuarry = "select * from Wishlist inner join Games on cd_game = id_game where id_user = " + cd_user + " Limit 5 ";
            UpdateGameList(lastQuarry);
        }
    }
}
