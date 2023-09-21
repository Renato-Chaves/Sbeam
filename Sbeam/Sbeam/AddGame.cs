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
    public partial class AddGame : Form
    {
        public AddGame()
        {
            InitializeComponent();
        }

        private void GameCoverInput_TextChanged(object sender, EventArgs e)
        {
            GameCover.Load(GameCoverInput.Text);
            GameCover.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void PublishGameBtn_Click(object sender, EventArgs e)
        {

        }

        private void AddTagBtn_Click(object sender, EventArgs e)
        {
            if (TagDropDown.Text != "")
            {
                TagList.Items.Add(TagDropDown.Text, true);
            }

            for (int i = 0; i < TagList.Items.Count; i++)
            {
                MessageBox.Show(TagDropDown.Items.IndexOf(TagList.Items[i].ToString()).ToString());
            }
        }

        private void TagList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //MessageBox.Show(TagList.GetItemText(e.Index));
            //if (e.Index >= 0)
            //{
            //    if (TagList.GetItemChecked(e.Index) == true)
            //    {
            //        TagList.Items.Remove(TagList.Items[e.Index]);
            //        TagList.Refresh();
            //    }
            //}


        }

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

    }
}
