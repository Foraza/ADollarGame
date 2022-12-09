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
        private PlayerController pCtrl = new PlayerController();
        private int actualQuestion = 0;
        public Question()
        {
            InitializeComponent();
        }

        public void setCurrentPlayer(string nickname)
        {
            PlayerModel player = new PlayerModel();
            player.Nickname = nickname.ToUpper();
            player.StartTime = DateTime.Now.TimeOfDay;
            player.Score = 0;

            pCtrl.startGame(player);
        }

        private void stop_bt_Click(object sender, EventArgs e)
        {
            pCtrl.gameOver();

            GameOver game_over = new GameOver();
            game_over.Tag = (Principal)Tag;
            game_over.Score = pCtrl.getScore();

            game_over.Show();

            Close();
        }

        private async void Question_Load(object sender, EventArgs e)
        {
            string request = await qCtrl.getQuestionTxt(actualQuestion);

            ScreenBuild(actualQuestion);
        }

        private void ScreenBuild(int i) {
            List<string> ans = new List<string>();
            int space = 0;

            question_gb.Text = $"QUESTION - {actualQuestion+1}";
            question_lb.Text = qCtrl.getAnswer(actualQuestion);
            ans = qCtrl.getAnswers(actualQuestion);

            foreach (string answer in ans)
            {
                Button dynamicButton = new Button();
                dynamicButton.Text = answer;
                dynamicButton.Name = $"ans_bt_{space}";
                dynamicButton.Font = new Font("Impact", 16);
                dynamicButton.ForeColor = Color.FromName("Indigo");
                dynamicButton.Click += delegate {
                    DialogResult result = MessageBox.Show("Would you like to confirm this answer?", "Confirm", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                        if (qCtrl.verifyAnswer(dynamicButton.Text, actualQuestion) == true)
                        {
                            MessageBox.Show("It's Correct!!");
                            actualQuestion++;
                            ScreenBuild(actualQuestion);
                            Console.WriteLine(actualQuestion);
                        }
                        else
                        {
                            MessageBox.Show("It's Wrong!!");
                        }
                            
                };

                dynamicButton.Size = new Size(730, 60);

                if (options_gb != null)
                {
                    options_gb.Controls.Add(dynamicButton);
                    options_gb.Controls.SetChildIndex(dynamicButton, space);
                }

                dynamicButton.Left = (this.options_gb.Width - dynamicButton.Width) / 2;
                dynamicButton.Top = ((this.options_gb.Height - (dynamicButton.Height * 4)) / 2) * ++space;
            }
        }

        private void question_lb_Click(object sender, EventArgs e)
        {
            
        }

        private void options_gp_Enter(object sender, EventArgs e)
        {

        }
    }
}
