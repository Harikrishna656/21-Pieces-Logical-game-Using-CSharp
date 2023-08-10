using System;
using System.Windows.Forms;

namespace _21pieces
{
    public partial class single_play : Form
    {
        static int pieces = 21;
        int take = 0;
        string your = "";
        public single_play()
        {
            InitializeComponent();
        }
        private void text_you_TextChanged(object sender, EventArgs e)
        {
            text_you.Text = text_you.Text;
        }
        private void single_play_Load(object sender, EventArgs e)
        {
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            pieces = 21;
            this.Hide();
            new Home().ShowDialog();  
            this.Close();
        }
        private void btn_take_CheckedChanged(object sender, EventArgs e)    
        {
            your = text_you.Text + 0;
            
            for (int i = 0; i < your.Length; i++)
            {
                if (!Char.IsDigit(your[i]))
                {
                    MessageBox.Show("Only Numbers allowed");
                    text_you.Text = "";
                    break;
                }
            }
            take = int.Parse(text_you.Text + 0);
            take = take / 10;
            lbl_dis.Text = take.ToString();
            if (take > 4 || take == 0)
            {
                MessageBox.Show("take out of 4 pieces");
                text_you.Text = "";
            }
            else
            {
                lbl_remain.Text = (pieces - take).ToString();
                pieces = pieces - take;
                text_you.Text = "";
            }      
            if (take > 0 && take < 5)
            {
                take = 5 - take;
                lbl_comp.Text = take.ToString();
                lbl_remain.Text = (pieces - take).ToString();
                pieces = pieces - take;
            }   
            if (pieces > 1)
                lbl_dis.Text = "safe";                      
            if (pieces <= 1)
            {
                lbl_dis.Text = "unsafe";
                MessageBox.Show($"you are loosed.\ncomputer takes {take} matchsticks,\nremaining matchsticks {pieces}");
                pieces = 21;
                this.Hide();
                new Home().ShowDialog();
                this.Close();
            }   
        }   
    }
}
