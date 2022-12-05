namespace ADollarGame
{
    partial class InitGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitGame));
            this.title_lb = new System.Windows.Forms.Label();
            this.name_gp = new System.Windows.Forms.GroupBox();
            this.start_bt = new System.Windows.Forms.Button();
            this.back_bt = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.backgroundGroup_pb = new System.Windows.Forms.PictureBox();
            this.name_gp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundGroup_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // title_lb
            // 
            this.title_lb.AutoSize = true;
            this.title_lb.BackColor = System.Drawing.Color.Transparent;
            this.title_lb.Font = new System.Drawing.Font("Impact", 32F);
            this.title_lb.ForeColor = System.Drawing.Color.White;
            this.title_lb.Location = new System.Drawing.Point(333, 9);
            this.title_lb.Name = "title_lb";
            this.title_lb.Size = new System.Drawing.Size(116, 53);
            this.title_lb.TabIndex = 0;
            this.title_lb.Text = "NAME";
            // 
            // name_gp
            // 
            this.name_gp.BackColor = System.Drawing.Color.Transparent;
            this.name_gp.BackgroundImage = global::ADollarGame.Properties.Resources.Blur;
            this.name_gp.Controls.Add(this.start_bt);
            this.name_gp.Controls.Add(this.back_bt);
            this.name_gp.Controls.Add(this.textBox1);
            this.name_gp.Font = new System.Drawing.Font("Impact", 16F);
            this.name_gp.ForeColor = System.Drawing.Color.White;
            this.name_gp.Location = new System.Drawing.Point(193, 152);
            this.name_gp.Name = "name_gp";
            this.name_gp.Size = new System.Drawing.Size(366, 164);
            this.name_gp.TabIndex = 1;
            this.name_gp.TabStop = false;
            this.name_gp.Text = "INSERT YOUR NAME";
            // 
            // start_bt
            // 
            this.start_bt.BackColor = System.Drawing.SystemColors.Control;
            this.start_bt.ForeColor = System.Drawing.Color.Indigo;
            this.start_bt.Location = new System.Drawing.Point(196, 108);
            this.start_bt.Name = "start_bt";
            this.start_bt.Size = new System.Drawing.Size(100, 50);
            this.start_bt.TabIndex = 2;
            this.start_bt.Text = "START";
            this.start_bt.UseVisualStyleBackColor = false;
            this.start_bt.Click += new System.EventHandler(this.start_bt_Click);
            // 
            // back_bt
            // 
            this.back_bt.BackColor = System.Drawing.SystemColors.Control;
            this.back_bt.ForeColor = System.Drawing.Color.Indigo;
            this.back_bt.Location = new System.Drawing.Point(74, 108);
            this.back_bt.Name = "back_bt";
            this.back_bt.Size = new System.Drawing.Size(100, 50);
            this.back_bt.TabIndex = 1;
            this.back_bt.Text = "BACK";
            this.back_bt.UseVisualStyleBackColor = false;
            this.back_bt.Click += new System.EventHandler(this.back_bt_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(354, 34);
            this.textBox1.TabIndex = 0;
            // 
            // backgroundGroup_pb
            // 
            this.backgroundGroup_pb.BackColor = System.Drawing.Color.Transparent;
            this.backgroundGroup_pb.BackgroundImage = global::ADollarGame.Properties.Resources.Blur;
            this.backgroundGroup_pb.Location = new System.Drawing.Point(180, 124);
            this.backgroundGroup_pb.Name = "backgroundGroup_pb";
            this.backgroundGroup_pb.Size = new System.Drawing.Size(392, 223);
            this.backgroundGroup_pb.TabIndex = 2;
            this.backgroundGroup_pb.TabStop = false;
            // 
            // InitGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ADollarGame.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1940, 1100);
            this.Controls.Add(this.name_gp);
            this.Controls.Add(this.title_lb);
            this.Controls.Add(this.backgroundGroup_pb);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InitGame";
            this.Text = "InitGame";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.name_gp.ResumeLayout(false);
            this.name_gp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundGroup_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_lb;
        private System.Windows.Forms.GroupBox name_gp;
        private System.Windows.Forms.PictureBox backgroundGroup_pb;
        private System.Windows.Forms.Button back_bt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button start_bt;
    }
}