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
            InsertDataView();
        }

        public void AjustPositions()
        {
            //Titulo
            title_lb.Left = (this.ClientSize.Width - title_lb.Width) / 2;
            title_lb.Top = title_lb.Height;

            //DataView ranking
            topScore_gb.Size = new Size((this.ClientSize.Width / 3) * 2, (this.ClientSize.Height + (title_lb.Height * 3)));
            topScore_gb.Left = (this.ClientSize.Width - topScore_gb.Width) / 2;
            topScore_gb.Top = title_lb.Height * 3;
        }

        private void InsertDataView()
        {
            DataTable rank = new DataTable("players");

            string test = "";

            DataColumn colPos = new DataColumn("Position", test.GetType());
            DataColumn colName = new DataColumn("Name", test.GetType());
            DataColumn colScr = new DataColumn("Score", test.GetType());
            DataColumn colTime = new DataColumn("Time", test.GetType());

            rank.Columns.Add(colPos);
            rank.Columns.Add(colName);
            rank.Columns.Add(colScr);
            rank.Columns.Add(colTime);

            DataRow newRow;

            for(int i = 0; i < 10; i++)
            {
                newRow = rank.NewRow();
                newRow["Position"] = $"{i + 1}";
                newRow["Name"] = $"Name - {i + 1}";
                newRow["Score"] = $"US$ {i + 1}";
                newRow["Time"] = $"Time - {i + 1}";
                rank.Rows.Add(newRow);
            }
            PrintTable(rank, "");
        }

        private void PrintTable(DataTable t, string label)
        {
            for (int i = 0; i < t.Rows.Count; i++)
            {
                Label dynamicLabel = new Label();
                dynamicLabel.Text = $"{t.Rows[i]["Position"]} " +
                    $"                                      " +
                    $"{t.Rows[i]["Name"]}" +
                    $"                                      " +
                    $"{t.Rows[i]["Score"]}" +
                    $"                                      " +
                    $"{t.Rows[i]["Time"]:mm:ss}";
                //dynamicLabel.Text = "{0} \t\t {1} \t\t {2} \t\t {3}", t.Rows[i]["Position"], t.Rows[i]["Name"], t.Rows[i]["Score"], t.Rows[i]["Time"];
                dynamicLabel.Font = new Font("Impact", 20);
                dynamicLabel.TextAlign = ContentAlignment.MiddleCenter;
                dynamicLabel.BorderStyle = BorderStyle.FixedSingle;
                dynamicLabel.BackColor = Color.FromName("White");
                dynamicLabel.ForeColor = Color.FromName("Indigo");


                if (topScore_gb != null)
                {
                    topScore_gb.Controls.Add(dynamicLabel);
                    topScore_gb.Controls.SetChildIndex(dynamicLabel, i);
                }

                dynamicLabel.Size = new Size(topScore_gb.Size.Width - 10, dynamicLabel.Size.Height * 2);

                dynamicLabel.Left = (this.topScore_gb.Width - dynamicLabel.Width) / 2;
                dynamicLabel.Top = (dynamicLabel.Height + 30) * (i + 1) ;
            }
        }

        private void back_bt_Click(object sender, EventArgs e)
        {
            Form principal = (Principal)Tag;
            principal.Show();

            Close();
        }

    }
}
