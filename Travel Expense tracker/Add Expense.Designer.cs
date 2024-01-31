namespace Travel_Expense_tracker
{
    partial class Add_Expense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Expense));
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnAddex = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.sltMethod = new System.Windows.Forms.ComboBox();
            this.sltType = new System.Windows.Forms.ComboBox();
            this.expenseTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.travelExpensesDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.travelExpensesDataSet2 = new Travel_Expense_tracker.travelExpensesDataSet2();
            this.trlType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.Label();
            this.travelType = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.Banner = new System.Windows.Forms.Label();
            this.userImage = new System.Windows.Forms.PictureBox();
            this.profileName = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.errorLocation = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorAmount = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPymt = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorType = new System.Windows.Forms.ErrorProvider(this.components);
            this.response = new System.Windows.Forms.Label();
            this.expenseTypeTableAdapter = new Travel_Expense_tracker.travelExpensesDataSet2TableAdapters.expenseTypeTableAdapter();
            this.Footer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.expenseTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpensesDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpensesDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPymt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorType)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtNote.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNote.Location = new System.Drawing.Point(596, 534);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(245, 35);
            this.txtNote.TabIndex = 62;
            this.txtNote.Text = "eg. Buy a coffee";
            this.txtNote.Enter += new System.EventHandler(this.txtNote_Enter);
            this.txtNote.Leave += new System.EventHandler(this.txtNote_Leave);
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtAmount.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtAmount.Location = new System.Drawing.Point(596, 423);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(245, 35);
            this.txtAmount.TabIndex = 61;
            this.txtAmount.Text = "eg. $10";
            this.txtAmount.Enter += new System.EventHandler(this.txtAmount_Enter);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            this.txtAmount.Leave += new System.EventHandler(this.txtAmount_Leave);
            // 
            // btnAddex
            // 
            this.btnAddex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(57)))), ((int)(((byte)(17)))));
            this.btnAddex.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddex.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddex.FlatAppearance.BorderSize = 0;
            this.btnAddex.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddex.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddex.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddex.Location = new System.Drawing.Point(12, 27);
            this.btnAddex.Name = "btnAddex";
            this.btnAddex.Size = new System.Drawing.Size(194, 44);
            this.btnAddex.TabIndex = 60;
            this.btnAddex.Text = "Add Expense Type";
            this.btnAddex.UseVisualStyleBackColor = false;
            this.btnAddex.Click += new System.EventHandler(this.btnAddex_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(57)))), ((int)(((byte)(17)))));
            this.btnSubmit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.Location = new System.Drawing.Point(496, 604);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(318, 34);
            this.btnSubmit.TabIndex = 59;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // sltMethod
            // 
            this.sltMethod.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.sltMethod.FormattingEnabled = true;
            this.sltMethod.Items.AddRange(new object[] {
            "Cash",
            "Bank Transfer"});
            this.sltMethod.Location = new System.Drawing.Point(596, 482);
            this.sltMethod.Name = "sltMethod";
            this.sltMethod.Size = new System.Drawing.Size(245, 28);
            this.sltMethod.TabIndex = 58;
            this.sltMethod.Text = "Select";
            this.sltMethod.Leave += new System.EventHandler(this.sltMethod_Leave);
            // 
            // sltType
            // 
            this.sltType.DataSource = this.expenseTypeBindingSource;
            this.sltType.DisplayMember = "Name";
            this.sltType.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.sltType.FormattingEnabled = true;
            this.sltType.Location = new System.Drawing.Point(596, 369);
            this.sltType.Name = "sltType";
            this.sltType.Size = new System.Drawing.Size(245, 28);
            this.sltType.TabIndex = 57;
            this.sltType.ValueMember = "Id";
            this.sltType.Leave += new System.EventHandler(this.sltType_Leave);
            // 
            // expenseTypeBindingSource
            // 
            this.expenseTypeBindingSource.DataMember = "expenseType";
            this.expenseTypeBindingSource.DataSource = this.travelExpensesDataSet2BindingSource;
            // 
            // travelExpensesDataSet2BindingSource
            // 
            this.travelExpensesDataSet2BindingSource.DataSource = this.travelExpensesDataSet2;
            this.travelExpensesDataSet2BindingSource.Position = 0;
            // 
            // travelExpensesDataSet2
            // 
            this.travelExpensesDataSet2.DataSetName = "travelExpensesDataSet2";
            this.travelExpensesDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trlType
            // 
            this.trlType.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.trlType.FormattingEnabled = true;
            this.trlType.Items.AddRange(new object[] {
            "Business",
            "Personal",
            "Family",
            "Friends"});
            this.trlType.Location = new System.Drawing.Point(596, 263);
            this.trlType.MinimumSize = new System.Drawing.Size(44, 0);
            this.trlType.Name = "trlType";
            this.trlType.Size = new System.Drawing.Size(245, 28);
            this.trlType.TabIndex = 56;
            this.trlType.Text = "Select";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(444, 541);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 20);
            this.label8.TabIndex = 55;
            this.label8.Text = "Expense Note";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(418, 486);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 20);
            this.label7.TabIndex = 54;
            this.label7.Text = "Paymemt Method";
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Location = new System.Drawing.Point(491, 430);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(65, 20);
            this.Amount.TabIndex = 53;
            this.Amount.Text = "Amount";
            // 
            // travelType
            // 
            this.travelType.AutoSize = true;
            this.travelType.Location = new System.Drawing.Point(461, 267);
            this.travelType.Name = "travelType";
            this.travelType.Size = new System.Drawing.Size(89, 20);
            this.travelType.TabIndex = 52;
            this.travelType.Text = "Travel Type";
            this.travelType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(443, 373);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(109, 20);
            this.lblType.TabIndex = 51;
            this.lblType.Text = "Expense Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(484, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Location";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(512, 218);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(44, 20);
            this.date.TabIndex = 49;
            this.date.Text = "Date";
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtLocation.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtLocation.Location = new System.Drawing.Point(596, 315);
            this.txtLocation.Multiline = true;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(245, 35);
            this.txtLocation.TabIndex = 48;
            this.txtLocation.Text = "eg. London";
            this.txtLocation.Enter += new System.EventHandler(this.txtLocation_Enter);
            this.txtLocation.Leave += new System.EventHandler(this.txtLocation_Leave);
            // 
            // datePicker
            // 
            this.datePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(159)))), ((int)(((byte)(116)))));
            this.datePicker.Location = new System.Drawing.Point(596, 211);
            this.datePicker.MinimumSize = new System.Drawing.Size(4, 26);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(245, 26);
            this.datePicker.TabIndex = 47;
            // 
            // Banner
            // 
            this.Banner.AutoSize = true;
            this.Banner.BackColor = System.Drawing.Color.Transparent;
            this.Banner.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Banner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(57)))), ((int)(((byte)(17)))));
            this.Banner.Location = new System.Drawing.Point(485, 90);
            this.Banner.Name = "Banner";
            this.Banner.Size = new System.Drawing.Size(296, 55);
            this.Banner.TabIndex = 46;
            this.Banner.Text = "New Expense";
            // 
            // userImage
            // 
            this.userImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userImage.BackgroundImage = global::Travel_Expense_tracker.Properties.Resources.user_placeholder;
            this.userImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.userImage.Location = new System.Drawing.Point(1183, 25);
            this.userImage.Name = "userImage";
            this.userImage.Size = new System.Drawing.Size(80, 50);
            this.userImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userImage.TabIndex = 64;
            this.userImage.TabStop = false;
            this.userImage.Click += new System.EventHandler(this.userImage_Click);
            // 
            // profileName
            // 
            this.profileName.AutoSize = true;
            this.profileName.BackColor = System.Drawing.Color.Transparent;
            this.profileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileName.Location = new System.Drawing.Point(1090, 40);
            this.profileName.Name = "profileName";
            this.profileName.Size = new System.Drawing.Size(87, 20);
            this.profileName.TabIndex = 63;
            this.profileName.Text = "Username ";
            this.profileName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.profileName.Click += new System.EventHandler(this.profileName_Click);
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
            this.btnDashboard.Location = new System.Drawing.Point(233, 27);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(156, 44);
            this.btnDashboard.TabIndex = 65;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // errorLocation
            // 
            this.errorLocation.ContainerControl = this;
            // 
            // errorAmount
            // 
            this.errorAmount.ContainerControl = this;
            // 
            // errorPymt
            // 
            this.errorPymt.ContainerControl = this;
            // 
            // errorType
            // 
            this.errorType.ContainerControl = this;
            // 
            // response
            // 
            this.response.AutoSize = true;
            this.response.ForeColor = System.Drawing.Color.Green;
            this.response.Location = new System.Drawing.Point(592, 158);
            this.response.Name = "response";
            this.response.Size = new System.Drawing.Size(156, 20);
            this.response.TabIndex = 66;
            this.response.Text = "Added Successfully !";
            this.response.Visible = false;
            // 
            // expenseTypeTableAdapter
            // 
            this.expenseTypeTableAdapter.ClearBeforeFill = true;
            // 
            // Footer
            // 
            this.Footer.AutoSize = true;
            this.Footer.BackColor = System.Drawing.Color.Transparent;
            this.Footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Footer.Location = new System.Drawing.Point(550, 655);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(174, 20);
            this.Footer.TabIndex = 67;
            this.Footer.Text = "Developed by M.Zayem";
            // 
            // Add_Expense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(233)))));
            this.BackgroundImage = global::Travel_Expense_tracker.Properties.Resources.Untitled_design4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1274, 684);
            this.Controls.Add(this.Footer);
            this.Controls.Add(this.response);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.userImage);
            this.Controls.Add(this.profileName);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnAddex);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.sltMethod);
            this.Controls.Add(this.sltType);
            this.Controls.Add(this.trlType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.travelType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.date);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.Banner);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1296, 740);
            this.MinimumSize = new System.Drawing.Size(1296, 740);
            this.Name = "Add_Expense";
            this.Text = "Add Expense";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Add_Expense_FormClosed);
            this.Load += new System.EventHandler(this.Add_Expense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.expenseTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpensesDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpensesDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPymt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnAddex;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox sltMethod;
        private System.Windows.Forms.ComboBox sltType;
        public System.Windows.Forms.ComboBox trlType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Label travelType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label Banner;
        private System.Windows.Forms.PictureBox userImage;
        private System.Windows.Forms.Label profileName;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.ErrorProvider errorLocation;
        private System.Windows.Forms.ErrorProvider errorAmount;
        private System.Windows.Forms.ErrorProvider errorPymt;
        private System.Windows.Forms.ErrorProvider errorType;
        private System.Windows.Forms.Label response;
        private System.Windows.Forms.BindingSource travelExpensesDataSet2BindingSource;
        private travelExpensesDataSet2 travelExpensesDataSet2;
        private System.Windows.Forms.BindingSource expenseTypeBindingSource;
        private travelExpensesDataSet2TableAdapters.expenseTypeTableAdapter expenseTypeTableAdapter;
        private System.Windows.Forms.Label Footer;
    }
}