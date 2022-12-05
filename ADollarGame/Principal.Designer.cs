namespace ADollarGame
{
    partial class Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.close_bt = new System.Windows.Forms.Button();
            this.newgame_bt = new System.Windows.Forms.Button();
            this.ranking_bt = new System.Windows.Forms.Button();
            this.logo_pb = new System.Windows.Forms.PictureBox();
            this.test_bt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // close_bt
            // 
            this.close_bt.Font = new System.Drawing.Font("Impact", 16F);
            this.close_bt.ForeColor = System.Drawing.Color.Indigo;
            this.close_bt.Location = new System.Drawing.Point(12, 12);
            this.close_bt.Name = "close_bt";
            this.close_bt.Size = new System.Drawing.Size(100, 50);
            this.close_bt.TabIndex = 0;
            this.close_bt.Text = "EXIT";
            this.close_bt.UseVisualStyleBackColor = true;
            this.close_bt.Click += new System.EventHandler(this.close_bt_Click);
            // 
            // newgame_bt
            // 
            this.newgame_bt.Font = new System.Drawing.Font("Impact", 28F);
            this.newgame_bt.ForeColor = System.Drawing.Color.Indigo;
            this.newgame_bt.Location = new System.Drawing.Point(301, 247);
            this.newgame_bt.Name = "newgame_bt";
            this.newgame_bt.Size = new System.Drawing.Size(200, 75);
            this.newgame_bt.TabIndex = 1;
            this.newgame_bt.Text = "NEW GAME";
            this.newgame_bt.UseVisualStyleBackColor = true;
            this.newgame_bt.Click += new System.EventHandler(this.newgame_bt_Click);
            // 
            // ranking_bt
            // 
            this.ranking_bt.Font = new System.Drawing.Font("Impact", 28F);
            this.ranking_bt.ForeColor = System.Drawing.Color.Indigo;
            this.ranking_bt.Location = new System.Drawing.Point(301, 341);
            this.ranking_bt.Name = "ranking_bt";
            this.ranking_bt.Size = new System.Drawing.Size(200, 75);
            this.ranking_bt.TabIndex = 1;
            this.ranking_bt.Text = "RANKING";
            this.ranking_bt.UseVisualStyleBackColor = true;
            this.ranking_bt.Click += new System.EventHandler(this.ranking_bt_Click);
            // 
            // logo_pb
            // 
            this.logo_pb.BackColor = System.Drawing.Color.Transparent;
            this.logo_pb.BackgroundImage = global::ADollarGame.Properties.Resources.Logo2;
            this.logo_pb.Location = new System.Drawing.Point(521, 12);
            this.logo_pb.Name = "logo_pb";
            this.logo_pb.Size = new System.Drawing.Size(450, 390);
            this.logo_pb.TabIndex = 2;
            this.logo_pb.TabStop = false;
            // 
            // test_bt
            // 
            this.test_bt.Font = new System.Drawing.Font("Impact", 16F);
            this.test_bt.ForeColor = System.Drawing.Color.Indigo;
            this.test_bt.Location = new System.Drawing.Point(118, 12);
            this.test_bt.Name = "test_bt";
            this.test_bt.Size = new System.Drawing.Size(132, 50);
            this.test_bt.TabIndex = 3;
            this.test_bt.Text = "score_test";
            this.test_bt.UseVisualStyleBackColor = true;
            this.test_bt.Click += new System.EventHandler(this.test_bt_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ADollarGame.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1940, 1100);
            this.Controls.Add(this.test_bt);
            this.Controls.Add(this.logo_pb);
            this.Controls.Add(this.ranking_bt);
            this.Controls.Add(this.newgame_bt);
            this.Controls.Add(this.close_bt);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.logo_pb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button close_bt;
        private System.Windows.Forms.Button newgame_bt;
        private System.Windows.Forms.Button ranking_bt;
        private System.Windows.Forms.PictureBox logo_pb;
        private System.Windows.Forms.Button test_bt;
    }
}

