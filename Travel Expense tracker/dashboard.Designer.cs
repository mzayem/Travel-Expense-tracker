namespace Travel_Expense_tracker
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.btnregister = new System.Windows.Forms.Button();
            this.exData = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.travelTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenseTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pymtMethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addExpenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.travelExpensesDataSet3 = new Travel_Expense_tracker.travelExpensesDataSet3();
            this.monthFilter = new System.Windows.Forms.ComboBox();
            this.Filter = new System.Windows.Forms.Label();
            this.typeFilter = new System.Windows.Forms.ComboBox();
            this.expenseTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.travelExpensesDataSet2 = new Travel_Expense_tracker.travelExpensesDataSet2();
            this.expenseTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.travelExpensesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.travelExpensesDataSet = new Travel_Expense_tracker.travelExpensesDataSet();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.Banner = new System.Windows.Forms.Label();
            this.profileName = new System.Windows.Forms.Label();
            this.userImage = new System.Windows.Forms.PictureBox();
            this.expenseTypeTableAdapter = new Travel_Expense_tracker.travelExpensesDataSetTableAdapters.expenseTypeTableAdapter();
            this.expenseTypeTableAdapter1 = new Travel_Expense_tracker.travelExpensesDataSet2TableAdapters.expenseTypeTableAdapter();
            this.addExpenseTableAdapter = new Travel_Expense_tracker.travelExpensesDataSet3TableAdapters.addExpenseTableAdapter();
            this.Footer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.exData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addExpenseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpensesDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseTypeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpensesDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpensesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpensesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnregister
            // 
            this.btnregister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(57)))), ((int)(((byte)(17)))));
            this.btnregister.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnregister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnregister.FlatAppearance.BorderSize = 0;
            this.btnregister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnregister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregister.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnregister.Location = new System.Drawing.Point(445, 138);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(148, 53);
            this.btnregister.TabIndex = 0;
            this.btnregister.Text = "Register";
            this.btnregister.UseVisualStyleBackColor = false;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // exData
            // 
            this.exData.AutoGenerateColumns = false;
            this.exData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.exData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.exData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.travelTypeDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.expenseTypeDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.pymtMethodDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn});
            this.exData.DataSource = this.addExpenseBindingSource;
            this.exData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(135)))), ((int)(((byte)(106)))));
            this.exData.Location = new System.Drawing.Point(188, 297);
            this.exData.Name = "exData";
            this.exData.RowHeadersWidth = 62;
            this.exData.RowTemplate.Height = 28;
            this.exData.Size = new System.Drawing.Size(959, 333);
            this.exData.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 150;
            // 
            // travelTypeDataGridViewTextBoxColumn
            // 
            this.travelTypeDataGridViewTextBoxColumn.DataPropertyName = "travelType";
            this.travelTypeDataGridViewTextBoxColumn.HeaderText = "travelType";
            this.travelTypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.travelTypeDataGridViewTextBoxColumn.Name = "travelTypeDataGridViewTextBoxColumn";
            this.travelTypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.Width = 150;
            // 
            // expenseTypeDataGridViewTextBoxColumn
            // 
            this.expenseTypeDataGridViewTextBoxColumn.DataPropertyName = "expenseType";
            this.expenseTypeDataGridViewTextBoxColumn.HeaderText = "expenseType";
            this.expenseTypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.expenseTypeDataGridViewTextBoxColumn.Name = "expenseTypeDataGridViewTextBoxColumn";
            this.expenseTypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 150;
            // 
            // pymtMethodDataGridViewTextBoxColumn
            // 
            this.pymtMethodDataGridViewTextBoxColumn.DataPropertyName = "pymtMethod";
            this.pymtMethodDataGridViewTextBoxColumn.HeaderText = "pymtMethod";
            this.pymtMethodDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pymtMethodDataGridViewTextBoxColumn.Name = "pymtMethodDataGridViewTextBoxColumn";
            this.pymtMethodDataGridViewTextBoxColumn.Width = 150;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.Width = 150;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // addExpenseBindingSource
            // 
            this.addExpenseBindingSource.DataMember = "addExpense";
            this.addExpenseBindingSource.DataSource = this.travelExpensesDataSet3;
            // 
            // travelExpensesDataSet3
            // 
            this.travelExpensesDataSet3.DataSetName = "travelExpensesDataSet3";
            this.travelExpensesDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monthFilter
            // 
            this.monthFilter.FormattingEnabled = true;
            this.monthFilter.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "Jun",
            "Jul",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.monthFilter.Location = new System.Drawing.Point(321, 259);
            this.monthFilter.Name = "monthFilter";
            this.monthFilter.Size = new System.Drawing.Size(148, 28);
            this.monthFilter.TabIndex = 2;
            this.monthFilter.Text = "Month";
            this.monthFilter.SelectedIndexChanged += new System.EventHandler(this.monthFilter_SelectedIndexChanged);
            // 
            // Filter
            // 
            this.Filter.AutoSize = true;
            this.Filter.BackColor = System.Drawing.Color.Transparent;
            this.Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filter.Location = new System.Drawing.Point(250, 262);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(65, 25);
            this.Filter.TabIndex = 3;
            this.Filter.Text = "Filter: ";
            // 
            // typeFilter
            // 
            this.typeFilter.DataSource = this.expenseTypeBindingSource1;
            this.typeFilter.DisplayMember = "Name";
            this.typeFilter.FormattingEnabled = true;
            this.typeFilter.Location = new System.Drawing.Point(490, 258);
            this.typeFilter.Name = "typeFilter";
            this.typeFilter.Size = new System.Drawing.Size(148, 28);
            this.typeFilter.TabIndex = 4;
            this.typeFilter.ValueMember = "Id";
            this.typeFilter.SelectedIndexChanged += new System.EventHandler(this.typeFilter_SelectedIndexChanged);
            // 
            // expenseTypeBindingSource1
            // 
            this.expenseTypeBindingSource1.DataMember = "expenseType";
            this.expenseTypeBindingSource1.DataSource = this.travelExpensesDataSet2;
            // 
            // travelExpensesDataSet2
            // 
            this.travelExpensesDataSet2.DataSetName = "travelExpensesDataSet2";
            this.travelExpensesDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // expenseTypeBindingSource
            // 
            this.expenseTypeBindingSource.DataMember = "expenseType";
            this.expenseTypeBindingSource.DataSource = this.travelExpensesDataSetBindingSource;
            // 
            // travelExpensesDataSetBindingSource
            // 
            this.travelExpensesDataSetBindingSource.DataSource = this.travelExpensesDataSet;
            this.travelExpensesDataSetBindingSource.Position = 0;
            // 
            // travelExpensesDataSet
            // 
            this.travelExpensesDataSet.DataSetName = "travelExpensesDataSet";
            this.travelExpensesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(57)))), ((int)(((byte)(17)))));
            this.btnlogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnlogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnlogin.FlatAppearance.BorderSize = 0;
            this.btnlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnlogin.Location = new System.Drawing.Point(677, 138);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(148, 53);
            this.btnlogin.TabIndex = 5;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.Login_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(57)))), ((int)(((byte)(17)))));
            this.btnNew.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNew.Location = new System.Drawing.Point(831, 247);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(175, 44);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "Add New Expense";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // Banner
            // 
            this.Banner.AutoSize = true;
            this.Banner.BackColor = System.Drawing.Color.Transparent;
            this.Banner.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Banner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(57)))), ((int)(((byte)(17)))));
            this.Banner.Location = new System.Drawing.Point(363, 39);
            this.Banner.Name = "Banner";
            this.Banner.Size = new System.Drawing.Size(527, 55);
            this.Banner.TabIndex = 7;
            this.Banner.Text = "Travel Expense Tracker!";
            // 
            // profileName
            // 
            this.profileName.AutoSize = true;
            this.profileName.BackColor = System.Drawing.Color.Transparent;
            this.profileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileName.Location = new System.Drawing.Point(1097, 27);
            this.profileName.Name = "profileName";
            this.profileName.Size = new System.Drawing.Size(87, 20);
            this.profileName.TabIndex = 18;
            this.profileName.Text = "Username ";
            this.profileName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.profileName.Click += new System.EventHandler(this.profileName_Click);
            // 
            // userImage
            // 
            this.userImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userImage.BackgroundImage = global::Travel_Expense_tracker.Properties.Resources.user_placeholder;
            this.userImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.userImage.Location = new System.Drawing.Point(1190, 12);
            this.userImage.Name = "userImage";
            this.userImage.Size = new System.Drawing.Size(72, 50);
            this.userImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userImage.TabIndex = 19;
            this.userImage.TabStop = false;
            this.userImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // expenseTypeTableAdapter
            // 
            this.expenseTypeTableAdapter.ClearBeforeFill = true;
            // 
            // expenseTypeTableAdapter1
            // 
            this.expenseTypeTableAdapter1.ClearBeforeFill = true;
            // 
            // addExpenseTableAdapter
            // 
            this.addExpenseTableAdapter.ClearBeforeFill = true;
            // 
            // Footer
            // 
            this.Footer.AutoSize = true;
            this.Footer.BackColor = System.Drawing.Color.Transparent;
            this.Footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Footer.Location = new System.Drawing.Point(550, 655);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(174, 20);
            this.Footer.TabIndex = 20;
            this.Footer.Text = "Developed by M.Zayem";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(233)))));
            this.BackgroundImage = global::Travel_Expense_tracker.Properties.Resources.Untitled_design4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1274, 684);
            this.Controls.Add(this.Footer);
            this.Controls.Add(this.userImage);
            this.Controls.Add(this.profileName);
            this.Controls.Add(this.Banner);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.typeFilter);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.monthFilter);
            this.Controls.Add(this.exData);
            this.Controls.Add(this.btnregister);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1296, 740);
            this.MinimumSize = new System.Drawing.Size(1296, 740);
            this.Name = "Dashboard";
            this.Text = "ZayEx(Dashboard)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addExpenseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpensesDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseTypeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpensesDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpensesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpensesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.DataGridView exData;
        private System.Windows.Forms.ComboBox monthFilter;
        private System.Windows.Forms.Label Filter;
        private System.Windows.Forms.ComboBox typeFilter;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label Banner;
        private System.Windows.Forms.Label profileName;
        private System.Windows.Forms.PictureBox userImage;
        private travelExpensesDataSet travelExpensesDataSet;
        private System.Windows.Forms.BindingSource travelExpensesDataSetBindingSource;
        private System.Windows.Forms.BindingSource expenseTypeBindingSource;
        private travelExpensesDataSetTableAdapters.expenseTypeTableAdapter expenseTypeTableAdapter;
        private travelExpensesDataSet2 travelExpensesDataSet2;
        private System.Windows.Forms.BindingSource expenseTypeBindingSource1;
        private travelExpensesDataSet2TableAdapters.expenseTypeTableAdapter expenseTypeTableAdapter1;
        private travelExpensesDataSet3 travelExpensesDataSet3;
        private System.Windows.Forms.BindingSource addExpenseBindingSource;
        private travelExpensesDataSet3TableAdapters.addExpenseTableAdapter addExpenseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn travelTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expenseTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pymtMethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label Footer;
    }
}

