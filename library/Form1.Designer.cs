
namespace library
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            txtpwd = new TextBox();
            txtuser = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            login = new Button();
            Signup = new Button();
            insta = new PictureBox();
            wtsp = new PictureBox();
            fb = new PictureBox();
            close = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)insta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wtsp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fb).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(144, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(120, 139);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(201, 86);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // txtpwd
            // 
            txtpwd.BackColor = Color.Black;
            txtpwd.BorderStyle = BorderStyle.None;
            txtpwd.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtpwd.ForeColor = Color.White;
            txtpwd.Location = new Point(114, 284);
            txtpwd.Name = "txtpwd";
            txtpwd.Size = new Size(283, 24);
            txtpwd.TabIndex = 3;
            txtpwd.Text = "Password";
            txtpwd.MouseClick += txtpwd_MouseClick;
            // 
            // txtuser
            // 
            txtuser.BackColor = Color.Black;
            txtuser.BorderStyle = BorderStyle.None;
            txtuser.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtuser.ForeColor = Color.White;
            txtuser.Location = new Point(114, 231);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(283, 24);
            txtuser.TabIndex = 3;
            txtuser.Text = "Username";
            txtuser.MouseClick += txtuser_MouseClick;
            txtuser.TextChanged += txtuser_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(29, 224);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(71, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(29, 284);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(71, 27);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(114, 257);
            panel1.Name = "panel1";
            panel1.Size = new Size(283, 3);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(114, 310);
            panel2.Name = "panel2";
            panel2.Size = new Size(283, 3);
            panel2.TabIndex = 6;
            // 
            // login
            // 
            login.BackColor = SystemColors.MenuHighlight;
            login.FlatStyle = FlatStyle.Popup;
            login.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login.ForeColor = Color.Black;
            login.Location = new Point(99, 363);
            login.Name = "login";
            login.Size = new Size(225, 39);
            login.TabIndex = 7;
            login.Text = "Login";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // Signup
            // 
            Signup.BackColor = SystemColors.GradientInactiveCaption;
            Signup.FlatStyle = FlatStyle.Popup;
            Signup.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Signup.ForeColor = SystemColors.Highlight;
            Signup.Location = new Point(99, 418);
            Signup.Name = "Signup";
            Signup.Size = new Size(225, 39);
            Signup.TabIndex = 7;
            Signup.Text = "Sign up";
            Signup.UseVisualStyleBackColor = false;
            Signup.Click += Signup_Click;
            // 
            // insta
            // 
            insta.Image = (Image)resources.GetObject("insta.Image");
            insta.Location = new Point(52, 521);
            insta.Name = "insta";
            insta.Size = new Size(35, 33);
            insta.SizeMode = PictureBoxSizeMode.Zoom;
            insta.TabIndex = 8;
            insta.TabStop = false;
            insta.Click += insta_Click;
            // 
            // wtsp
            // 
            wtsp.Image = (Image)resources.GetObject("wtsp.Image");
            wtsp.Location = new Point(199, 521);
            wtsp.Name = "wtsp";
            wtsp.Size = new Size(35, 33);
            wtsp.SizeMode = PictureBoxSizeMode.Zoom;
            wtsp.TabIndex = 8;
            wtsp.TabStop = false;
            wtsp.Click += wtsp_Click;
            // 
            // fb
            // 
            fb.Image = (Image)resources.GetObject("fb.Image");
            fb.Location = new Point(349, 521);
            fb.Name = "fb";
            fb.Size = new Size(35, 33);
            fb.SizeMode = PictureBoxSizeMode.Zoom;
            fb.TabIndex = 8;
            fb.TabStop = false;
            fb.Click += fb_Click;
            // 
            // close
            // 
            close.BackColor = Color.Black;
            close.FlatStyle = FlatStyle.Popup;
            close.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            close.ForeColor = Color.Red;
            close.Location = new Point(389, 0);
            close.Name = "close";
            close.Size = new Size(47, 40);
            close.TabIndex = 9;
            close.Text = "X";
            close.UseVisualStyleBackColor = false;
            close.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(436, 578);
            Controls.Add(close);
            Controls.Add(fb);
            Controls.Add(wtsp);
            Controls.Add(insta);
            Controls.Add(Signup);
            Controls.Add(login);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(txtuser);
            Controls.Add(txtpwd);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            ForeColor = SystemColors.ControlDarkDark;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)insta).EndInit();
            ((System.ComponentModel.ISupportInitialize)wtsp).EndInit();
            ((System.ComponentModel.ISupportInitialize)fb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Signup_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private TextBox txtpwd;
        private TextBox txtuser;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private Panel panel1;
        private Panel panel2;
        private Button login;
        private Button Signup;
        private PictureBox insta;
        private PictureBox wtsp;
        private PictureBox fb;
        private Button close;
    }
}
