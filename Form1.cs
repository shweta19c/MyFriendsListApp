using System;
namespace MyFriendsList

{
    public partial class btn_sortDescending : Form
    {
        List<string> myFriends = new List<string>();
        BindingSource bs = new BindingSource();
        public btn_sortDescending()
        {
            InitializeComponent();
            bs.DataSource = myFriends;
        }

        private void btn_addFriend_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Add(txt_newFriend.Text);
            myFriends.Add(txt_newFriend.Text);
            //listBox1.DataSource = myFriends;
            listBox1.DataSource = bs;
            bs.ResetBindings(false);
            label1.Text = "There are " + myFriends.Count + " people in the list.";
        }

        private void btn_AddFive_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = bs;
            myFriends.Add("Shweta");
            myFriends.Add("Shraddha");
            myFriends.Add("Sarvesh");
            myFriends.Add("Ash");
            myFriends.Add("bamne");
            bs.ResetBindings(false);
            label1.Text = "There are " + myFriends.Count + " people in the list.";
        }

        private void btn_sortAscending_Click(object sender, EventArgs e)
        {
            myFriends.Sort();
            bs.ResetBindings(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myFriends.Sort();
            myFriends.Reverse();
            bs.ResetBindings(false);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Clear();
            myFriends.Clear();
            txt_newFriend.Clear();
            label1.Text = "";
            bs.ResetBindings(false);
        }
    }
}
