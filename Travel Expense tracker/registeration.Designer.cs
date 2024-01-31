namespace Travel_Expense_tracker
{
    partial class registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registration));
            this.btnRegister = new System.Windows.Forms.Button();
            this.phone = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.Banner = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userImage = new System.Windows.Forms.PictureBox();
            this.imgSelect = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lgntext = new System.Windows.Forms.Label();
            this.errorname = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPhone = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPass = new System.Windows.Forms.ErrorProvider(this.components);
            this.confirmPass = new System.Windows.Forms.TextBox();
            this.errorMatchPass = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Footer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMatchPass)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(57)))), ((int)(((byte)(17)))));
            this.btnRegister.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegister.Location = new System.Drawing.Point(483, 560);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(309, 34);
            this.btnRegister.TabIndex = 16;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(535, 369);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(257, 26);
            this.phone.TabIndex = 15;
            this.phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_KeyPress);
            this.phone.Leave += new System.EventHandler(this.phone_Leave);
            // 
            // username
            // 
            this.username.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.username.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.username.Location = new System.Drawing.Point(535, 320);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(257, 26);
            this.username.TabIndex = 14;
            this.username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.username_KeyPress);
            this.username.Leave += new System.EventHandler(this.username_Leave);
            // 
            // Banner
            // 
            this.Banner.AutoSize = true;
            this.Banner.BackColor = System.Drawing.Color.Transparent;
            this.Banner.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Banner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(57)))), ((int)(((byte)(17)))));
            this.Banner.Location = new System.Drawing.Point(494, 39);
            this.Banner.Name = "Banner";
            this.Banner.Size = new System.Drawing.Size(298, 55);
            this.Banner.TabIndex = 13;
            this.Banner.Text = "Register Now";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(535, 421);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(257, 26);
            this.email.TabIndex = 18;
            this.email.Leave += new System.EventHandler(this.email_Leave);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(535, 468);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(257, 26);
            this.Password.TabIndex = 19;
            this.Password.Leave += new System.EventHandler(this.Password_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(489, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "Profile Photo";
            // 
            // userImage
            // 
            this.userImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userImage.BackgroundImage = global::Travel_Expense_tracker.Properties.Resources.user_placeholder;
            this.userImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.userImage.Location = new System.Drawing.Point(663, 144);
            this.userImage.Name = "userImage";
            this.userImage.Size = new System.Drawing.Size(129, 132);
            this.userImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userImage.TabIndex = 21;
            this.userImage.TabStop = false;
            // 
            // imgSelect
            // 
            this.imgSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(57)))), ((int)(((byte)(17)))));
            this.imgSelect.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.imgSelect.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.imgSelect.FlatAppearance.BorderSize = 0;
            this.imgSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.imgSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.imgSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imgSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgSelect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imgSelect.Location = new System.Drawing.Point(494, 231);
            this.imgSelect.Name = "imgSelect";
            this.imgSelect.Size = new System.Drawing.Size(147, 34);
            this.imgSelect.TabIndex = 22;
            this.imgSelect.Text = "Select";
            this.imgSelect.UseVisualStyleBackColor = false;
            this.imgSelect.Click += new System.EventHandler(this.imgSelect_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lgntext
            // 
            this.lgntext.AutoSize = true;
            this.lgntext.Location = new System.Drawing.Point(531, 597);
            this.lgntext.Name = "lgntext";
            this.lgntext.Size = new System.Drawing.Size(217, 20);
            this.lgntext.TabIndex = 23;
            this.lgntext.Text = "Already have account ? Login";
            this.lgntext.Click += new System.EventHandler(this.lgntext_Click);
            // 
            // errorname
            // 
            this.errorname.ContainerControl = this;
            // 
            // errorPhone
            // 
            this.errorPhone.ContainerControl = this;
            // 
            // errorEmail
            // 
            this.errorEmail.ContainerControl = this;
            // 
            // errorPass
            // 
            this.errorPass.ContainerControl = this;
            // 
            // confirmPass
            // 
            this.confirmPass.Location = new System.Drawing.Point(535, 515);
            this.confirmPass.Name = "confirmPass";
            this.confirmPass.Size = new System.Drawing.Size(257, 26);
            this.confirmPass.TabIndex = 24;
            this.confirmPass.Leave += new System.EventHandler(this.confirmPass_Leave);
            // 
            // errorMatchPass
            // 
            this.errorMatchPass.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Phone No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(471, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(441, 474);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(382, 518);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Confirm Password";
            // 
            // Footer
            // 
            this.Footer.AutoSize = true;
            this.Footer.BackColor = System.Drawing.Color.Transparent;
            this.Footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Footer.Location = new System.Drawing.Point(550, 655);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(174, 20);
            this.Footer.TabIndex = 30;
            this.Footer.Text = "Developed by M.Zayem";
            // 
            // registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(233)))));
            this.BackgroundImage = global::Travel_Expense_tracker.Properties.Resources.Untitled_design4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1274, 684);
            this.Controls.Add(this.Footer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.confirmPass);
            this.Controls.Add(this.lgntext);
            this.Controls.Add(this.imgSelect);
            this.Controls.Add(this.userImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.email);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.username);
            this.Controls.Add(this.Banner);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1296, 740);
            this.MinimumSize = new System.Drawing.Size(1296, 740);
            this.Name = "registration";
            this.Text = "Registration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.registration_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMatchPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label Banner;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox userImage;
        private System.Windows.Forms.Button imgSelect;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lgntext;
        private System.Windows.Forms.ErrorProvider errorname;
        private System.Windows.Forms.ErrorProvider errorPhone;
        private System.Windows.Forms.ErrorProvider errorEmail;
        private System.Windows.Forms.ErrorProvider errorPass;
        private System.Windows.Forms.TextBox confirmPass;
        private System.Windows.Forms.ErrorProvider errorMatchPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Footer;
    }
}