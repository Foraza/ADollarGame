namespace ADollarGame
{
    partial class Ranking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ranking));
            this.title_lb = new System.Windows.Forms.Label();
            this.back_bt = new System.Windows.Forms.Button();
            this.topScore_gb = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // title_lb
            // 
            this.title_lb.AutoSize = true;
            this.title_lb.BackColor = System.Drawing.Color.Transparent;
            this.title_lb.Font = new System.Drawing.Font("Impact", 32F);
            this.title_lb.ForeColor = System.Drawing.Color.White;
            this.title_lb.Location = new System.Drawing.Point(404, 9);
            this.title_lb.Name = "title_lb";
            this.title_lb.Size = new System.Drawing.Size(172, 53);
            this.title_lb.TabIndex = 1;
            this.title_lb.Text = "RANKING";
            // 
            // back_bt
            // 
            this.back_bt.Font = new System.Drawing.Font("Impact", 16F);
            this.back_bt.ForeColor = System.Drawing.Color.Indigo;
            this.back_bt.Location = new System.Drawing.Point(12, 12);
            this.back_bt.Name = "back_bt";
            this.back_bt.Size = new System.Drawing.Size(100, 50);
            this.back_bt.TabIndex = 2;
            this.back_bt.Text = "BACK";
            this.back_bt.UseVisualStyleBackColor = true;
            this.back_bt.Click += new System.EventHandler(this.back_bt_Click);
            // 
            // topScore_gb
            // 
            this.topScore_gb.BackColor = System.Drawing.Color.Transparent;
            this.topScore_gb.BackgroundImage = global::ADollarGame.Properties.Resources.Blur;
            this.topScore_gb.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topScore_gb.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.topScore_gb.Location = new System.Drawing.Point(478, 278);
            this.topScore_gb.Name = "topScore_gb";
            this.topScore_gb.Size = new System.Drawing.Size(200, 100);
            this.topScore_gb.TabIndex = 3;
            this.topScore_gb.TabStop = false;
            this.topScore_gb.Text = "TOP 10 SCORES";
            // 
            // Ranking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ADollarGame.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1924, 715);
            this.Controls.Add(this.topScore_gb);
            this.Controls.Add(this.back_bt);
            this.Controls.Add(this.title_lb);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ranking";
            this.Text = "Ranking";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_lb;
        private System.Windows.Forms.Button back_bt;
        private System.Windows.Forms.GroupBox topScore_gb;
    }
}