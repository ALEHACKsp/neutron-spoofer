namespace Fatality_Menu
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.header2 = new theme_for_jack.header();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.header3 = new theme_for_jack.header();
            this.header4 = new theme_for_jack.header();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginbutton = new System.Windows.Forms.Button();
            this.passbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // header2
            // 
            this.header2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.header2.Location = new System.Drawing.Point(-32, 117);
            this.header2.Margin = new System.Windows.Forms.Padding(4);
            this.header2.Name = "header2";
            this.header2.Size = new System.Drawing.Size(468, 37);
            this.header2.TabIndex = 208;
            this.header2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.T_MouseDown);
            this.header2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.T_MouseMove);
            this.header2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.T_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // header3
            // 
            this.header3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(8)))), ((int)(((byte)(29)))));
            this.header3.Location = new System.Drawing.Point(-10, 53);
            this.header3.Name = "header3";
            this.header3.Size = new System.Drawing.Size(277, 221);
            this.header3.TabIndex = 245;
            // 
            // header4
            // 
            this.header4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.header4.Location = new System.Drawing.Point(1, 30);
            this.header4.Name = "header4";
            this.header4.Size = new System.Drawing.Size(266, 221);
            this.header4.TabIndex = 246;
            this.header4.Load += new System.EventHandler(this.header4_Load);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(-5, -85);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(8, 436);
            this.pictureBox3.TabIndex = 247;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Location = new System.Drawing.Point(268, -134);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(9, 531);
            this.pictureBox4.TabIndex = 248;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(1, 305);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 10);
            this.pictureBox1.TabIndex = 249;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.Picturebox1_Paint);
            // 
            // loginbutton
            // 
            this.loginbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.loginbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginbutton.Font = new System.Drawing.Font("Verdana", 6.75F);
            this.loginbutton.ForeColor = System.Drawing.Color.White;
            this.loginbutton.Location = new System.Drawing.Point(50, 142);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(172, 35);
            this.loginbutton.TabIndex = 251;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = false;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // passbox
            // 
            this.passbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.passbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passbox.Font = new System.Drawing.Font("Verdana", 6.75F);
            this.passbox.ForeColor = System.Drawing.Color.White;
            this.passbox.Location = new System.Drawing.Point(50, 92);
            this.passbox.Name = "passbox";
            this.passbox.Size = new System.Drawing.Size(173, 18);
            this.passbox.TabIndex = 252;
            this.passbox.TextChanged += new System.EventHandler(this.passbox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label3.Font = new System.Drawing.Font("Verdana", 6.75F);
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(109, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 12);
            this.label3.TabIndex = 253;
            this.label3.Text = "Enter Key";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(102, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 254;
            this.label1.Text = "Neutron";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(272, 218);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passbox);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.header4);
            this.Controls.Add(this.header3);
            this.Controls.Add(this.header2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.Text = "Neutron Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private theme_for_jack.header header2;
        private System.Windows.Forms.Timer timer1;
        private theme_for_jack.header header3;
        private theme_for_jack.header header4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.TextBox passbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}

