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
            AjustPositions();
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
            GameOver game_over = new GameOver(true, pCtrl.getScore());
            game_over.Tag = (Principal)Tag;

            game_over.Show();

            Close();
        }

        private async void Question_Load(object sender, EventArgs e)
        {
            string request = await qCtrl.getQuestionTxt(actualQuestion);

            ScreenBuild(actualQuestion);
        }

        private void ScreenBuild(int i)
        {
            List<string> ans = new List<string>();
            int space = 0;

            question_gb.Text = $"QUESTION - {actualQuestion + 1}";

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
                            pCtrl.updateScore(actualQuestion);

                            MessageBox.Show("It's Correct!!");                            

                            actualQuestion++;

                            if (actualQuestion == 15)
                            {
                                Form game_over = new GameOver(true, pCtrl.getScore());
                                game_over.Tag = (Principal)Tag;
                                game_over.Show();

                                Close();
                            }

                            ScreenBuild(actualQuestion);
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

        public void AjustPositions()
        {
            //Titulo
            title_lb.Left = (this.ClientSize.Width - title_lb.Width) / 2;
            title_lb.Top = title_lb.Height;

            //Background "Question"
            backgroundGroup_pb.Left = (this.ClientSize.Width - backgroundGroup_pb.Width) / 2;
            backgroundGroup_pb.Top = title_lb.Height * 3;
            //Group "Question"
            question_gb.Left = (this.ClientSize.Width - question_gb.Width) / 2;
            question_gb.Top = title_lb.Height * 3;

            //Group "Alternatives"
            options_gb.Left = ((this.ClientSize.Width - (options_gb.Width + lifelines_gb.Width)) / 2) - 10;
            options_gb.Top = lifelines_gb.Width;

            //Group "Lifelines"
            lifelines_gb.Left = ((this.ClientSize.Width - (options_gb.Width + lifelines_gb.Width)) / 2) + options_gb.Width + 10;
            lifelines_gb.Top = lifelines_gb.Width;
        }

       public void LifelineSkip(int i)
        {
            ScreenBuild(actualQuestion  +  1);
        }

        private void question_lb_Click(object sender, EventArgs e)
        {
            
        }

        private void options_gp_Enter(object sender, EventArgs e)
        {

        }
    }
}
