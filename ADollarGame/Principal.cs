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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            AjustPositions();
        }

        public void AjustPositions()
        {
            //Logo
            logo_pb.Left = (this.ClientSize.Width - logo_pb.Width) / 2;
            logo_pb.Top = (this.ClientSize.Height - logo_pb.Height) / 12;

            //Botão "New Game"
            newgame_bt.Left = (this.ClientSize.Width - newgame_bt.Width) / 2;
            newgame_bt.Top = ((this.ClientSize.Height - newgame_bt.Height) / 2) +(newgame_bt.Height * 2);

            //Botão "Ranking"
            ranking_bt.Left = (this.ClientSize.Width - ranking_bt.Width) / 2;
            ranking_bt.Top = ((this.ClientSize.Height - ranking_bt.Height) / 2) + (ranking_bt.Height * 4);
        }

        private void close_bt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newgame_bt_Click(object sender, EventArgs e)
        {
            Form initGame = new InitGame();
            initGame.Tag = this;
            initGame.Show(this);

            Hide();
        }

        private void ranking_bt_Click(object sender, EventArgs e)
        {
            Form ranking = new Ranking();
            ranking.Tag = this;
            ranking.Show(this);

            Hide();
        }

        private void test_bt_Click(object sender, EventArgs e)
        {
            Form game_over = new GameOver();
            game_over.Tag = this;
            game_over.Show(this);

            Hide();
        }
    }
}
