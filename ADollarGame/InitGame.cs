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
    public partial class InitGame : Form
    {
        public InitGame()
        {
            InitializeComponent();
            AjustPositions();
        }

        public void AjustPositions()
        {
            //Titulo
            title_lb.Left = (this.ClientSize.Width - title_lb.Width) / 2;
            title_lb.Top = title_lb.Height;

            //Background "Insert your name"
            backgroundGroup_pb.Left = (this.ClientSize.Width - backgroundGroup_pb.Width) / 2;
            backgroundGroup_pb.Top = (this.ClientSize.Height - backgroundGroup_pb.Height) / 2;

            //Grupo "Insert your name"
            name_gp.Left = (this.ClientSize.Width - name_gp.Width) / 2;
            name_gp.Top = (this.ClientSize.Height - name_gp.Height) / 2;
        }

        private void back_bt_Click(object sender, EventArgs e)
        {
            Form principal = (Principal)Tag;
            principal.Show();

            Close();
        }

        private void start_bt_Click(object sender, EventArgs e)
        {
            Form question = new Question();
            question.Tag = this;
            question.Show(this);

            Close();
        }
    }
}
