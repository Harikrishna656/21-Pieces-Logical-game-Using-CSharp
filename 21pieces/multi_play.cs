using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21pieces
{

    public partial class multi_play : Form
    {
        souds s1 = new souds();
        static int pieces = 21;
        int take = 0;
        string your = "";
        public multi_play()
        {
            InitializeComponent();
        }

        private void text_play1_TextChanged(object sender, EventArgs e)
        {
            text_play1.Text = text_play1.Text;
        }
        private void text_play2_TextChanged(object sender, EventArgs e)
        {
            text_play2.Text = text_play2.Text;
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            pieces = 21;
            this.Hide();
            new Home().ShowDialog();
            this.Close();
        }

        private void btn_player2_click(object sender, EventArgs e)
        {
            if (btn_player1_take.Text == "Take")
            {
                MessageBox.Show("Wait to take palyer 1");
                reset();
            }
            else
            {

                your = text_play2.Text + 0;
                for (int i = 0; i < your.Length; i++)
                {
                    if (!Char.IsDigit(your[i]))
                    {
                        MessageBox.Show("Only Numbers allowed");
                        reset();
                        break;
                    }
                }
                take = int.Parse(text_play2.Text + 0);
                take = take / 10;

                if (take > 4 || take == 0)
                {
                    MessageBox.Show("take out of 4 pieces");
                    reset();
                    btn_player1_take.Text = "Wait";
                    btn_player2_take.Text = "Take";
                }
                else if (pieces - take == 0)
                {
                    MessageBox.Show($"your are going to win  but take {take - 1} sticks");
                    reset();
                    btn_player1_take.Text = "Wait";
                    btn_player2_take.Text = "Take";
                }

                else
                {
                    text_reamain_dis.Text = (pieces - take).ToString();
                    pieces = pieces - take;
                    reset();
                    btn_player2_take.Text = "Wait";
                    btn_player1_take.Text = "Take";

                    if (pieces <= 1)
                    {
                        MessageBox.Show($" Player 1 loosed.\n Player 2 takes {take} matchsticks,\nremaining matchsticks {pieces}");
                        s1.single_pause();
                        pieces = 21;
                        this.Hide();
                        new Home().ShowDialog();
                        this.Close();
                    }
                }
            }

        }
        void reset()
        {
            text_play1.Text = "";
            text_play2.Text = "";
        }

        private void btn_player1_click(object sender, EventArgs e)
        {
            if (btn_player2_take.Text == "Take")
            {
                MessageBox.Show("Wait to take palyer 2");
                reset();
            }
            else
            {
                your = text_play1.Text + 0;
                for (int i = 0; i < your.Length; i++)
                {
                    if (!Char.IsDigit(your[i]))
                    {
                        MessageBox.Show("Only Numbers allowed");
                        reset();
                        break;
                    }
                }
                take = int.Parse(text_play1.Text + 0);
                take = take / 10;

                if (take > 4 || take == 0)
                {
                    MessageBox.Show("take out of 4 pieces");
                    reset();
                    btn_player2_take.Text = "Wait";
                    btn_player1_take.Text = "Take";
                }
                else if (pieces - take == 0)
                {
                    MessageBox.Show($"your are going to win  but take {take - 1} sticks");
                    reset();
                }
                else
                {
                    text_reamain_dis.Text = (pieces - take).ToString();
                    pieces = pieces - take;
                    reset();
                    btn_player1_take.Text = "Wait";
                    btn_player2_take.Text = "Take";
                    if (pieces <= 1)
                    {
                        MessageBox.Show($" Player 2 loosed.\n Player 1 takes {take} matchsticks,\nremaining matchsticks {pieces}");
                        s1.single_pause();
                        pieces = 21;
                        this.Hide();
                        new Home().ShowDialog();
                        this.Close();
                    }
                }

            }
        }
    }
}

        