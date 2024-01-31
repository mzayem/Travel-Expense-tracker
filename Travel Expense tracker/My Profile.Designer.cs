namespace Travel_Expense_tracker
{
    partial class My_Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(My_Profile));
            this.imgSelect = new System.Windows.Forms.Button();
            this.userImage = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userpass = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.phone = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.Banner = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.showPass = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Footer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).BeginInit();
            this.SuspendLayout();
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
            this.imgSelect.Location = new System.Drawing.Point(544, 257);
            this.imgSelect.Name = "imgSelect";
            this.imgSelect.Size = new System.Drawing.Size(147, 34);
            this.imgSelect.TabIndex = 33;
            this.imgSelect.Text = "Select";
            this.imgSelect.UseVisualStyleBackColor = false;
            this.imgSelect.Click += new System.EventHandler(this.imgSelect_Click);
            // 
            // userImage
            // 
            this.userImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userImage.BackgroundImage = global::Travel_Expense_tracker.Properties.Resources.user_placeholder;
            this.userImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.userImage.Location = new System.Drawing.Point(713, 178);
            this.userImage.Name = "userImage";
            this.userImage.Size = new System.Drawing.Size(129, 132);
            this.userImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userImage.TabIndex = 32;
            this.userImage.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(539, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 29);
            this.label2.TabIndex = 31;
            this.label2.Text = "Profile Photo";
            // 
            // userpass
            // 
            this.userpass.Location = new System.Drawing.Point(533, 494);
            this.userpass.Name = "userpass";
            this.userpass.Size = new System.Drawing.Size(309, 26);
            this.userpass.TabIndex = 30;
            this.userpass.Text = "Password";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(533, 447);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(309, 26);
            this.email.TabIndex = 29;
            this.email.Text = "Email";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(57)))), ((int)(((byte)(17)))));
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(533, 586);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(175, 34);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(533, 395);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(309, 26);
            this.phone.TabIndex = 27;
            this.phone.Text = "Phone no";
            this.phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_KeyPress);
            // 
            // username
            // 
            this.username.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.username.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.username.Location = new System.Drawing.Point(533, 346);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(309, 26);
            this.username.TabIndex = 26;
            this.username.Text = "Username";
            // 
            // Banner
            // 
            this.Banner.AutoSize = true;
            this.Banner.BackColor = System.Drawing.Color.Transparent;
            this.Banner.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Banner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(57)))), ((int)(((byte)(17)))));
            this.Banner.Location = new System.Drawing.Point(550, 59);
            this.Banner.Name = "Banner";
            this.Banner.Size = new System.Drawing.Size(271, 55);
            this.Banner.TabIndex = 25;
            this.Banner.Text = "Profile Data";
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(57)))), ((int)(((byte)(17)))));
            this.btnDashboard.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDashboard.Location = new System.Drawing.Point(12, 12);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(182, 34);
            this.btnDashboard.TabIndex = 36;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(207)))), ((int)(((byte)(105)))));
            this.btnreset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnreset.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnreset.FlatAppearance.BorderSize = 0;
            this.btnreset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnreset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnreset.Location = new System.Drawing.Point(1022, 79);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(182, 34);
            this.btnreset.TabIndex = 37;
            this.btnreset.Text = "Reset Expenses";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndelete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btndelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btndelete.FlatAppearance.BorderSize = 0;
            this.btndelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btndelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndelete.Location = new System.Drawing.Point(1022, 21);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(182, 34);
            this.btndelete.TabIndex = 38;
            this.btndelete.Text = "Delete Account";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(57)))), ((int)(((byte)(17)))));
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(1022, 130);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(182, 34);
            this.btnLogout.TabIndex = 39;
            this.btnLogout.Text = "LogOut";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // showPass
            // 
            this.showPass.AutoSize = true;
            this.showPass.Location = new System.Drawing.Point(533, 537);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(148, 24);
            this.showPass.TabIndex = 40;
            this.showPass.Text = "Show Password";
            this.showPass.UseVisualStyleBackColor = true;
            this.showPass.CheckedChanged += new System.EventHandler(this.showPass_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Footer
            // 
            this.Footer.AutoSize = true;
            this.Footer.BackColor = System.Drawing.Color.Transparent;
            this.Footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Footer.Location = new System.Drawing.Point(550, 655);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(174, 20);
            this.Footer.TabIndex = 41;
            this.Footer.Text = "Developed by M.Zayem";
            // 
            // My_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(233)))));
            this.BackgroundImage = global::Travel_Expense_tracker.Properties.Resources.Untitled_design4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1216, 684);
            this.Controls.Add(this.Footer);
            this.Controls.Add(this.showPass);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.imgSelect);
            this.Controls.Add(this.userImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userpass);
            this.Controls.Add(this.email);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.username);
            this.Controls.Add(this.Banner);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1238, 740);
            this.MinimumSize = new System.Drawing.Size(1238, 740);
            this.Name = "My_Profile";
            this.Text = "My Profile";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.My_Profile_FormClosed);
            this.Load += new System.EventHandler(this.My_Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button imgSelect;
        private System.Windows.Forms.PictureBox userImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userpass;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label Banner;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.CheckBox showPass;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label Footer;
    }
}