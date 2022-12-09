using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADollarGame
{
    public partial class GameOver : Form
    {
        private double score;

        public double Score { get; set; }

        public GameOver(bool gameRes)
        {
            InitializeComponent();
            score_lb.Text = $"US$ {score.ToString()}";
            AjustPositions();

            if (gameRes)
                title_lb.Text = "CONGRATS!!";
        }

        public void AjustPositions()
        {
            //Titulo
            title_lb.Left = (this.ClientSize.Width - title_lb.Width) / 2;
            title_lb.Top = title_lb.Height;

            //Background "Score"
            backgroundGroup_pb.Left = (this.ClientSize.Width - backgroundGroup_pb.Width) / 2;
            backgroundGroup_pb.Top = (this.ClientSize.Height - backgroundGroup_pb.Height) / 2;

            //Grupo "Score"
            score_gp.Left = (this.ClientSize.Width - score_gp.Width) / 2;
            score_gp.Top = (this.ClientSize.Height - score_gp.Height) / 2;
        }

        private void continue_bt_Click(object sender, EventArgs e)
        {
            Form principal = (Principal)Tag;
            principal.Show();

            Close();
        }

        private void GameOver_Load(object sender, EventArgs e)
        {
            
        }
    }
}
