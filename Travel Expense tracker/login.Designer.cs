namespace Travel_Expense_tracker
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.Banner = new System.Windows.Forms.Label();
            this.lgn_username = new System.Windows.Forms.TextBox();
            this.userPass = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.Footer = new System.Windows.Forms.Label();
            this.errorname = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPass = new System.Windows.Forms.ErrorProvider(this.components);
            this.registertext = new System.Windows.Forms.Label();
            this.showPass = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPass)).BeginInit();
            this.SuspendLayout();
            // 
            // Banner
            // 
            this.Banner.AutoSize = true;
            this.Banner.BackColor = System.Drawing.Color.Transparent;
            this.Banner.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Banner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(57)))), ((int)(((byte)(17)))));
            this.Banner.Location = new System.Drawing.Point(524, 126);
            this.Banner.Name = "Banner";
            this.Banner.Size = new System.Drawing.Size(248, 55);
            this.Banner.TabIndex = 8;
            this.Banner.Text = "Login Now";
            // 
            // lgn_username
            // 
            this.lgn_username.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lgn_username.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.lgn_username.Location = new System.Drawing.Point(493, 239);
            this.lgn_username.Name = "lgn_username";
            this.lgn_username.Size = new System.Drawing.Size(309, 26);
            this.lgn_username.TabIndex = 9;
            this.lgn_username.Text = "Username";
            this.lgn_username.Enter += new System.EventHandler(this.username_Enter);
            this.lgn_username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.username_KeyPress);
            this.lgn_username.Leave += new System.EventHandler(this.username_Leave);
            // 
            // userPass
            // 
            this.userPass.Location = new System.Drawing.Point(493, 309);
            this.userPass.Name = "userPass";
            this.userPass.Size = new System.Drawing.Size(309, 26);
            this.userPass.TabIndex = 10;
            this.userPass.Text = "Password";
            this.userPass.Enter += new System.EventHandler(this.userPass_Enter);
            this.userPass.Leave += new System.EventHandler(this.userPass_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(57)))), ((int)(((byte)(17)))));
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Location = new System.Drawing.Point(493, 403);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(309, 34);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Footer
            // 
            this.Footer.AutoSize = true;
            this.Footer.BackColor = System.Drawing.Color.Transparent;
            this.Footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Footer.Location = new System.Drawing.Point(550, 655);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(174, 20);
            this.Footer.TabIndex = 12;
            this.Footer.Text = "Developed by M.Zayem";
            // 
            // errorname
            // 
            this.errorname.ContainerControl = this;
            // 
            // errorPass
            // 
            this.errorPass.ContainerControl = this;
            // 
            // registertext
            // 
            this.registertext.AutoSize = true;
            this.registertext.Location = new System.Drawing.Point(545, 457);
            this.registertext.Name = "registertext";
            this.registertext.Size = new System.Drawing.Size(192, 20);
            this.registertext.TabIndex = 24;
            this.registertext.Text = "Want to Register? Signup";
            this.registertext.Click += new System.EventHandler(this.registertext_Click);
            // 
            // showPass
            // 
            this.showPass.AutoSize = true;
            this.showPass.Location = new System.Drawing.Point(493, 360);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(148, 24);
            this.showPass.TabIndex = 25;
            this.showPass.Text = "Show Password";
            this.showPass.UseVisualStyleBackColor = true;
            this.showPass.CheckedChanged += new System.EventHandler(this.showPass_CheckedChanged);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(233)))));
            this.BackgroundImage = global::Travel_Expense_tracker.Properties.Resources.Untitled_design4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1274, 684);
            this.Controls.Add(this.showPass);
            this.Controls.Add(this.registertext);
            this.Controls.Add(this.Footer);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.userPass);
            this.Controls.Add(this.lgn_username);
            this.Controls.Add(this.Banner);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1296, 740);
            this.MinimumSize = new System.Drawing.Size(1296, 740);
            this.Name = "login";
            this.Text = "ZayEx (Login)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.login_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.errorname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Banner;
        private System.Windows.Forms.TextBox lgn_username;
        private System.Windows.Forms.TextBox userPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label Footer;
        private System.Windows.Forms.ErrorProvider errorname;
        private System.Windows.Forms.ErrorProvider errorPass;
        private System.Windows.Forms.Label registertext;
        private System.Windows.Forms.CheckBox showPass;
    }
}