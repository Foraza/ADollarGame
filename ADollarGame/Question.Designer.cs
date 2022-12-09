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
            this.question_gb = new System.Windows.Forms.GroupBox();
            this.question_lb = new System.Windows.Forms.Label();
            this.backgroundGroup_pb = new System.Windows.Forms.PictureBox();
            this.options_gb = new System.Windows.Forms.GroupBox();
            this.lifelines_gb = new System.Windows.Forms.GroupBox();
            this.stop_bt = new System.Windows.Forms.Button();
            this.question_gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundGroup_pb)).BeginInit();
            this.lifelines_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_lb
            // 
            this.title_lb.AutoSize = true;
            this.title_lb.BackColor = System.Drawing.Color.Transparent;
            this.title_lb.Font = new System.Drawing.Font("Impact", 32F);
            this.title_lb.ForeColor = System.Drawing.Color.White;
            this.title_lb.Location = new System.Drawing.Point(452, 14);
            this.title_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title_lb.Name = "title_lb";
            this.title_lb.Size = new System.Drawing.Size(278, 53);
            this.title_lb.TabIndex = 4;
            this.title_lb.Text = "A DOLLAR GAME";
            // 
            // question_gb
            // 
            this.question_gb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.question_gb.Controls.Add(this.question_lb);
            this.question_gb.Font = new System.Drawing.Font("Impact", 16F);
            this.question_gb.ForeColor = System.Drawing.Color.Indigo;
            this.question_gb.Location = new System.Drawing.Point(63, 100);
            this.question_gb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.question_gb.Name = "question_gb";
            this.question_gb.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.question_gb.Size = new System.Drawing.Size(1754, 258);
            this.question_gb.TabIndex = 5;
            this.question_gb.TabStop = false;
            this.question_gb.Text = "QUESTION - N";
            // 
            // question_lb
            // 
            this.question_lb.AutoSize = true;
            this.question_lb.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question_lb.Location = new System.Drawing.Point(9, 63);
            this.question_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.question_lb.Name = "question_lb";
            this.question_lb.Size = new System.Drawing.Size(94, 27);
            this.question_lb.TabIndex = 8;
            this.question_lb.Text = "Loading...";
            // 
            // backgroundGroup_pb
            // 
            this.backgroundGroup_pb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.backgroundGroup_pb.Location = new System.Drawing.Point(44, 100);
            this.backgroundGroup_pb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backgroundGroup_pb.Name = "backgroundGroup_pb";
            this.backgroundGroup_pb.Size = new System.Drawing.Size(1792, 272);
            this.backgroundGroup_pb.TabIndex = 6;
            this.backgroundGroup_pb.TabStop = false;
            // 
            // options_gb
            // 
            this.options_gb.BackColor = System.Drawing.Color.Transparent;
            this.options_gb.BackgroundImage = global::ADollarGame.Properties.Resources.Blur;
            this.options_gb.Font = new System.Drawing.Font("Impact", 16F);
            this.options_gb.ForeColor = System.Drawing.Color.White;
            this.options_gb.Location = new System.Drawing.Point(44, 403);
            this.options_gb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.options_gb.Name = "options_gb";
            this.options_gb.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.options_gb.Size = new System.Drawing.Size(1112, 565);
            this.options_gb.TabIndex = 8;
            this.options_gb.TabStop = false;
            this.options_gb.Text = "ALTERNATIVES";
            // 
            // lifelines_gb
            // 
            this.lifelines_gb.BackColor = System.Drawing.Color.Transparent;
            this.lifelines_gb.BackgroundImage = global::ADollarGame.Properties.Resources.Blur;
            this.lifelines_gb.Controls.Add(this.stop_bt);
            this.lifelines_gb.Font = new System.Drawing.Font("Impact", 16F);
            this.lifelines_gb.ForeColor = System.Drawing.Color.White;
            this.lifelines_gb.Location = new System.Drawing.Point(1186, 403);
            this.lifelines_gb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lifelines_gb.Name = "lifelines_gb";
            this.lifelines_gb.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lifelines_gb.Size = new System.Drawing.Size(650, 565);
            this.lifelines_gb.TabIndex = 9;
            this.lifelines_gb.TabStop = false;
            this.lifelines_gb.Text = "LIFELINES";
            // 
            // stop_bt
            // 
            this.stop_bt.BackColor = System.Drawing.Color.White;
            this.stop_bt.ForeColor = System.Drawing.Color.Indigo;
            this.stop_bt.Location = new System.Drawing.Point(183, 478);
            this.stop_bt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stop_bt.Name = "stop_bt";
            this.stop_bt.Size = new System.Drawing.Size(300, 77);
            this.stop_bt.TabIndex = 0;
            this.stop_bt.Text = "STOP";
            this.stop_bt.UseVisualStyleBackColor = false;
            this.stop_bt.Click += new System.EventHandler(this.stop_bt_Click);
            // 
            // Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ADollarGame.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(2886, 1100);
            this.Controls.Add(this.lifelines_gb);
            this.Controls.Add(this.options_gb);
            this.Controls.Add(this.question_gb);
            this.Controls.Add(this.backgroundGroup_pb);
            this.Controls.Add(this.title_lb);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Question";
            this.Text = "Question";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Question_Load);
            this.question_gb.ResumeLayout(false);
            this.question_gb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundGroup_pb)).EndInit();
            this.lifelines_gb.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_lb;
        private System.Windows.Forms.GroupBox question_gb;
        private System.Windows.Forms.Label question_lb;
        private System.Windows.Forms.PictureBox backgroundGroup_pb;
        private System.Windows.Forms.GroupBox options_gb;
        private System.Windows.Forms.GroupBox lifelines_gb;
        private System.Windows.Forms.Button stop_bt;
    }
}