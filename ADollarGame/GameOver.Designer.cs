namespace ADollarGame
{
    partial class GameOver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOver));
            this.score_gp = new System.Windows.Forms.GroupBox();
            this.score_lb = new System.Windows.Forms.Label();
            this.continue_bt = new System.Windows.Forms.Button();
            this.backgroundGroup_pb = new System.Windows.Forms.PictureBox();
            this.title_lb = new System.Windows.Forms.Label();
            this.score_gp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundGroup_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // score_gp
            // 
            this.score_gp.BackColor = System.Drawing.Color.Transparent;
            this.score_gp.BackgroundImage = global::ADollarGame.Properties.Resources.Blur;
            this.score_gp.Controls.Add(this.score_lb);
            this.score_gp.Controls.Add(this.continue_bt);
            this.score_gp.Font = new System.Drawing.Font("Impact", 16F);
            this.score_gp.ForeColor = System.Drawing.Color.White;
            this.score_gp.Location = new System.Drawing.Point(291, 234);
            this.score_gp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.score_gp.Name = "score_gp";
            this.score_gp.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.score_gp.Size = new System.Drawing.Size(549, 252);
            this.score_gp.TabIndex = 4;
            this.score_gp.TabStop = false;
            this.score_gp.Text = "SCORE";
            // 
            // score_lb
            // 
            this.score_lb.AutoSize = true;
            this.score_lb.Font = new System.Drawing.Font("Impact", 32F);
            this.score_lb.Location = new System.Drawing.Point(102, 80);
            this.score_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.score_lb.Name = "score_lb";
            this.score_lb.Size = new System.Drawing.Size(226, 53);
            this.score_lb.TabIndex = 3;
            this.score_lb.Text = "R$ EXEMPLO";
            // 
            // continue_bt
            // 
            this.continue_bt.BackColor = System.Drawing.SystemColors.Control;
            this.continue_bt.ForeColor = System.Drawing.Color.Indigo;
            this.continue_bt.Location = new System.Drawing.Point(116, 166);
            this.continue_bt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.continue_bt.Name = "continue_bt";
            this.continue_bt.Size = new System.Drawing.Size(300, 77);
            this.continue_bt.TabIndex = 1;
            this.continue_bt.Text = "CONTINUE";
            this.continue_bt.UseVisualStyleBackColor = false;
            this.continue_bt.Click += new System.EventHandler(this.continue_bt_Click);
            // 
            // backgroundGroup_pb
            // 
            this.backgroundGroup_pb.BackColor = System.Drawing.Color.Transparent;
            this.backgroundGroup_pb.BackgroundImage = global::ADollarGame.Properties.Resources.Blur;
            this.backgroundGroup_pb.Location = new System.Drawing.Point(272, 191);
            this.backgroundGroup_pb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backgroundGroup_pb.Name = "backgroundGroup_pb";
            this.backgroundGroup_pb.Size = new System.Drawing.Size(588, 343);
            this.backgroundGroup_pb.TabIndex = 5;
            this.backgroundGroup_pb.TabStop = false;
            // 
            // title_lb
            // 
            this.title_lb.AutoSize = true;
            this.title_lb.BackColor = System.Drawing.Color.Transparent;
            this.title_lb.Font = new System.Drawing.Font("Impact", 32F);
            this.title_lb.ForeColor = System.Drawing.Color.White;
            this.title_lb.Location = new System.Drawing.Point(501, 14);
            this.title_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title_lb.Name = "title_lb";
            this.title_lb.Size = new System.Drawing.Size(212, 53);
            this.title_lb.TabIndex = 3;
            this.title_lb.Text = "GAME OVER";
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ADollarGame.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1940, 1100);
            this.Controls.Add(this.score_gp);
            this.Controls.Add(this.backgroundGroup_pb);
            this.Controls.Add(this.title_lb);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GameOver";
            this.Text = "GameOver";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GameOver_Load);
            this.score_gp.ResumeLayout(false);
            this.score_gp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundGroup_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox score_gp;
        private System.Windows.Forms.Label score_lb;
        private System.Windows.Forms.Button continue_bt;
        private System.Windows.Forms.PictureBox backgroundGroup_pb;
        private System.Windows.Forms.Label title_lb;
    }
}