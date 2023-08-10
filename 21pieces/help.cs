using System;
using System.Windows.Forms;
namespace _21pieces
{
    public partial class help : Form
    {
        souds s1 = new souds();
        static int i;
        private void dis(int j)
        {
            if (j == 0)
                lbl_help.Text = "There are 21 matchsticks";
            if (j == 1)
                lbl_help.Text = "The computer asks the palyer \nto pick 1,2,3 or 4 matchsticks";
            if (j == 2)
                lbl_help.Text = "After Your picks, the computer \n does its picking";
            if (j == 3)
                lbl_help.Text = "Whoever is forced to pick up \nthe last matchstick lose the game\n\t....end....";
        }
        public help()
        {
            InitializeComponent();
        }
        private void btn_pre_Click(object sender, EventArgs e)
        {
            s1.btn_pre_play();
            if (i > 0)
            {
                i -= 1;
                dis(i);
            }
        }
        private void btn_next_Click(object sender, EventArgs e)
        {
            s1.btn_next_play();
            if (i < 4)
            {
                i += 1;
                dis(i);
            }
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().ShowDialog();
            this.Close();      
        }
    }
}
