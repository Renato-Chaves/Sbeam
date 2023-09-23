using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sbeam
{
    public partial class AddGame : Form
    {
        StorePage storePage;
        MyDBConnection db;
        MySqlConnection conn;
        MySqlCommand cmd;

        public AddGame(StorePage _storePage)
        {
            this.storePage = _storePage;
            InitializeComponent();

            //Create a Database connection
            db = new MyDBConnection();
            conn = db.DBConnect();
        }

        string imageURL;

        //Updates Cover image automatically
        private void GameCoverInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                GameCover.BackgroundImage = null;
                imageURL = GameCoverInput.Text;
                GameCover.Load(imageURL);
                GameCover.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch
            {
                GameCover.BackgroundImage = Properties.Resources.FailedToLoad;
            }
        }

        //Remove tag from list
        private void TagList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TagList.SelectedIndex >= 0)
            {
                if (TagList.GetItemChecked(TagList.SelectedIndex) == true)
                {
                    TagList.Items.Remove(TagList.Items[TagList.SelectedIndex]);
                    TagList.Refresh();
                }
            }
        }

        //Returns to main StorePage
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CleanInputs();
            storePage.Show();
        }

        //Check and Insert values into database | publishing game
        private void PublishGameBtn_Click(object sender, EventArgs e)
        {

            if (StringCheck(GameTitleInput.Text) || StringCheck(GameCoverInput.Text) || StringCheck(DescriptionInput.Text) || StringCheck(DeveloperInput.Text) || StringCheck(PublisherInput.Text))
            {
                MessageBox.Show("Fill in all information before publishing");
            }
            else
            {

                try
                {
                    //Game Data Creation
                    float price = Convert.ToSingle(PriceInput.Text);
                    string releaseDate = ReleaseInput.Value.Year.ToString() + "-" + ReleaseInput.Value.Month.ToString() + "-" + ReleaseInput.Value.Day.ToString();
                    conn.Open();
                    cmd = new MySqlCommand("insert into Games values(null, @GameTitle, @Description, @GameCover, @Publisher, @Developer, @ReleaseDate, @Price)", conn);
                    cmd.Parameters.AddWithValue("@GameTitle", GameTitleInput.Text);
                    cmd.Parameters.AddWithValue("@Description", DescriptionInput.Text);
                    cmd.Parameters.AddWithValue("@GameCover", GameCoverInput.Text);
                    cmd.Parameters.AddWithValue("@Publisher", PublisherInput.Text);
                    cmd.Parameters.AddWithValue("@Developer", DeveloperInput.Text);
                    cmd.Parameters.AddWithValue("@ReleaseDate", releaseDate);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message); ;
                }
                finally { conn.Close(); }

                //Returning Added Game ID
                conn.Open();
                string cd_game = "0";
                cmd = new MySqlCommand("SELECT cd_game FROM Games ORDER BY cd_game DESC LIMIT 1", conn);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cd_game = reader.GetValue(0).ToString();
                }
                conn.Close();

                //Adding Game Platforms
                if (WindowsCheckBox.Checked)
                {
                    conn.Open();
                    cmd = new MySqlCommand("insert into Game_Platform values('" + cd_game + "','" + 1 + "')", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                if (AppleCheckBox.Checked)
                {
                    conn.Open();
                    cmd = new MySqlCommand("insert into Game_Platform values('" + cd_game + "','" + 2 + "')", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                if (LinuxCheckBox.Checked)
                {
                    conn.Open();
                    cmd = new MySqlCommand("insert into Game_Platform values('" + cd_game + "','" + 3 + "')", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                //Adding Tags

                for (int i = 0; i < TagList.Items.Count; i++)
                {
                    try
                    {
                        int tagIndex = TagDropDown.Items.IndexOf(TagList.Items[i].ToString());
                        MessageBox.Show(tagIndex.ToString());
                        conn.Open();
                        cmd = new MySqlCommand("insert into Game_Tags values(" + cd_game + ", " + tagIndex + ")", conn);
                        cmd.ExecuteNonQuery();

                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                    finally { conn.Close(); }
                }

                MessageBox.Show("Game added successfully.");
                CleanInputs();
            }
        }

        //Filling TagDropDown with Database Tags
        private void AddGame_Load(object sender, EventArgs e)
        {
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
                    TagDropDown.Items.Add(nm_tag);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }
        }

        //Add tag to list
        private void AddTagBtn_Click(object sender, EventArgs e)
        {
            string selectedItem = TagDropDown.Text;

            if (selectedItem != null)
            {
                bool notFound = true;
                foreach (string item in TagList.Items)
                {
                    if (selectedItem.Equals(item))
                    {
                        notFound = false;
                        break; // Item found, break loop
                    }
                }

                if (notFound)
                {
                    TagList.Items.Add(TagDropDown.Text, true);

                }
                else
                {
                    MessageBox.Show("Tag already selected.");
                }
            }
        }

        //Check if input is empty
        private bool StringCheck(string text)
        {
            return string.IsNullOrWhiteSpace(text);
        }

        //Reset all input values
        private void CleanInputs()
        {
            GameCoverInput.Text = string.Empty;
            GameTitleInput.Text = string.Empty;
            DescriptionInput.Text = string.Empty;
            DeveloperInput.Text = string.Empty;
            PublisherInput.Text = string.Empty;
            TagList.Items.Clear();
            ReleaseInput.Value = DateTime.Now;
            PriceInput.Value = 0;
        }

    }
}
