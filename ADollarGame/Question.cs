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
    public partial class Question : Form
    {
        private QuestionController qCtrl = new QuestionController();
        private PlayerController pCtrl;
        public Question()
        {
            InitializeComponent();

        }


        private void stop_bt_Click(object sender, EventArgs e)
        {
            Form game_over = new GameOver();
            game_over.Show();

            Close();
        }

        private async void Question_Load(object sender, EventArgs e)
        {
            string questionTxt = await qCtrl.getQuestionTxt(0);
            question_lb.Text = questionTxt;
        }

        private void question_lb_Click(object sender, EventArgs e)
        {
            
        }
    }
}
