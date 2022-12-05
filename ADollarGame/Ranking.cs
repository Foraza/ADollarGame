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
    public partial class Ranking : Form
    {
        public Ranking()
        {
            InitializeComponent();
            AjustPositions();
        }

        public void AjustPositions()
        {
            //Titulo
            title_lb.Left = (this.ClientSize.Width - title_lb.Width) / 2;
            title_lb.Top = title_lb.Height;

        }

        private void back_bt_Click(object sender, EventArgs e)
        {
            Form principal = (Principal)Tag;
            principal.Show();

            Close();
        }
    }
}
