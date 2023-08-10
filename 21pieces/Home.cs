using System;
using System.Windows.Forms;

namespace _21pieces
{
    public partial class Home : Form
    {
        souds s1 = new souds();   
        public Home()
        {
            InitializeComponent();  
        }   
        private void btn_exit_Click(object sender, EventArgs e)
        {
            s1.btn_options_play();
            DialogResult dialogResult= MessageBox.Show("Do you want really close","Yes/No",MessageBoxButtons.YesNo);
             if (dialogResult == DialogResult.Yes)
             {  
                 this.Close();           
             }    
             else
                s1.Homemusic_play();

        }
        private void btn_sp_Click(object sender, EventArgs e)
        {
            this.Hide();
            s1.single_play();
            new single_play().ShowDialog();
            this.Close();
            
        }
        private void btn_help_Click(object sender, EventArgs e)
        {
            this.Hide();
            new help().ShowDialog();
            this.Close();
        }
        private void Home_Load(object sender, EventArgs e)
        {
           s1.Homemusic_play();
        }

        private void btn_mlp_Click(object sender, EventArgs e)
        {
            this.Hide();
            s1.single_play();
            new multi_play().ShowDialog();
            this.Close();
        }
    }
}
