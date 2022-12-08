namespace ADollarGame
{
    partial class Question
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Question));
            this.title_lb = new System.Windows.Forms.Label();
            this.question_gp = new System.Windows.Forms.GroupBox();
            this.question_lb = new System.Windows.Forms.Label();
            this.backgroundGroup_pb = new System.Windows.Forms.PictureBox();
            this.options_gp = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stop_bt = new System.Windows.Forms.Button();
            this.question_gp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundGroup_pb)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_lb
            // 
            this.title_lb.AutoSize = true;
            this.title_lb.BackColor = System.Drawing.Color.Transparent;
            this.title_lb.Font = new System.Drawing.Font("Impact", 32F);
            this.title_lb.ForeColor = System.Drawing.Color.White;
            this.title_lb.Location = new System.Drawing.Point(301, 9);
            this.title_lb.Name = "title_lb";
            this.title_lb.Size = new System.Drawing.Size(278, 53);
            this.title_lb.TabIndex = 4;
            this.title_lb.Text = "A DOLLAR GAME";
            // 
            // question_gp
            // 
            this.question_gp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.question_gp.Controls.Add(this.question_lb);
            this.question_gp.Font = new System.Drawing.Font("Impact", 16F);
            this.question_gp.ForeColor = System.Drawing.Color.Indigo;
            this.question_gp.Location = new System.Drawing.Point(42, 65);
            this.question_gp.Name = "question_gp";
            this.question_gp.Size = new System.Drawing.Size(1169, 168);
            this.question_gp.TabIndex = 5;
            this.question_gp.TabStop = false;
            this.question_gp.Text = "QUESTION - N";
            // 
            // question_lb
            // 
            this.question_lb.AutoSize = true;
            this.question_lb.Font = new System.Drawing.Font("Impact", 12F);
            this.question_lb.Location = new System.Drawing.Point(6, 41);
            this.question_lb.Name = "question_lb";
            this.question_lb.Size = new System.Drawing.Size(912, 20);
            this.question_lb.TabIndex = 8;
            this.question_lb.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis nec malesuada dolor" +
    ". Integer bibendum mattis sem, in congue risus finibus eu.\r\n";
            this.question_lb.Click += new System.EventHandler(this.question_lb_Click);
            // 
            // backgroundGroup_pb
            // 
            this.backgroundGroup_pb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.backgroundGroup_pb.Location = new System.Drawing.Point(29, 65);
            this.backgroundGroup_pb.Name = "backgroundGroup_pb";
            this.backgroundGroup_pb.Size = new System.Drawing.Size(1195, 177);
            this.backgroundGroup_pb.TabIndex = 6;
            this.backgroundGroup_pb.TabStop = false;
            // 
            // options_gp
            // 
            this.options_gp.BackColor = System.Drawing.Color.Transparent;
            this.options_gp.BackgroundImage = global::ADollarGame.Properties.Resources.Blur;
            this.options_gp.Font = new System.Drawing.Font("Impact", 16F);
            this.options_gp.ForeColor = System.Drawing.Color.White;
            this.options_gp.Location = new System.Drawing.Point(29, 262);
            this.options_gp.Name = "options_gp";
            this.options_gp.Size = new System.Drawing.Size(741, 367);
            this.options_gp.TabIndex = 8;
            this.options_gp.TabStop = false;
            this.options_gp.Text = "ALTERNATIVES";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = global::ADollarGame.Properties.Resources.Blur;
            this.groupBox1.Controls.Add(this.stop_bt);
            this.groupBox1.Font = new System.Drawing.Font("Impact", 16F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(791, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 367);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LIFELINES";
            // 
            // stop_bt
            // 
            this.stop_bt.BackColor = System.Drawing.Color.White;
            this.stop_bt.ForeColor = System.Drawing.Color.Indigo;
            this.stop_bt.Location = new System.Drawing.Point(122, 311);
            this.stop_bt.Name = "stop_bt";
            this.stop_bt.Size = new System.Drawing.Size(200, 50);
            this.stop_bt.TabIndex = 0;
            this.stop_bt.Text = "STOP";
            this.stop_bt.UseVisualStyleBackColor = false;
            this.stop_bt.Click += new System.EventHandler(this.stop_bt_Click);
            // 
            // Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ADollarGame.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.options_gp);
            this.Controls.Add(this.question_gp);
            this.Controls.Add(this.backgroundGroup_pb);
            this.Controls.Add(this.title_lb);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Question";
            this.Text = "Question";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Question_Load);
            this.question_gp.ResumeLayout(false);
            this.question_gp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundGroup_pb)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_lb;
        private System.Windows.Forms.GroupBox question_gp;
        private System.Windows.Forms.Label question_lb;
        private System.Windows.Forms.PictureBox backgroundGroup_pb;
        private System.Windows.Forms.GroupBox options_gp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button stop_bt;
    }
}