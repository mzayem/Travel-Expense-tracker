namespace Travel_Expense_tracker
{
    partial class expense_type
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(expense_type));
            this.label1 = new System.Windows.Forms.Label();
            this.enterType = new System.Windows.Forms.Button();
            this.exName = new System.Windows.Forms.TextBox();
            this.Banner = new System.Windows.Forms.Label();
            this.userImage = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.successMsg = new System.Windows.Forms.Label();
            this.exTypeData = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dltType = new System.Windows.Forms.ComboBox();
            this.expenseTypeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.travelExpensesDataSet2 = new Travel_Expense_tracker.travelExpensesDataSet2();
            this.expenseTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.travelExpensesDataSet = new Travel_Expense_tracker.travelExpensesDataSet();
            this.expenseTypeTableAdapter = new Travel_Expense_tracker.travelExpensesDataSetTableAdapters.expenseTypeTableAdapter();
            this.expenseTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.expenseTypeTableAdapter1 = new Travel_Expense_tracker.travelExpensesDataSet2TableAdapters.expenseTypeTableAdapter();
            this.profileName = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnAddex = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exTypeData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseTypeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpensesDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpensesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseTypeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(550, 655);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Developed by Zayem and Waqas";
            // 
            // enterType
            // 
            this.enterType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(57)))), ((int)(((byte)(17)))));
            this.enterType.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.enterType.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.enterType.FlatAppearance.BorderSize = 0;
            this.enterType.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.enterType.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.enterType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.enterType.Location = new System.Drawing.Point(743, 226);
            this.enterType.Name = "enterType";
            this.enterType.Size = new System.Drawing.Size(106, 34);
            this.enterType.TabIndex = 16;
            this.enterType.Text = "Add ";
            this.enterType.UseVisualStyleBackColor = false;
            this.enterType.Click += new System.EventHandler(this.enterType_Click);
            // 
            // exName
            // 
            this.exName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.exName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.exName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exName.Location = new System.Drawing.Point(456, 226);
            this.exName.Multiline = true;
            this.exName.Name = "exName";
            this.exName.Size = new System.Drawing.Size(258, 35);
            this.exName.TabIndex = 14;
            this.exName.Enter += new System.EventHandler(this.exName_Enter);
            this.exName.Leave += new System.EventHandler(this.exName_Leave);
            // 
            // Banner
            // 
            this.Banner.AutoSize = true;
            this.Banner.BackColor = System.Drawing.Color.Transparent;
            this.Banner.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Banner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(57)))), ((int)(((byte)(17)))));
            this.Banner.Location = new System.Drawing.Point(443, 110);
            this.Banner.Name = "Banner";
            this.Banner.Size = new System.Drawing.Size(406, 55);
            this.Banner.TabIndex = 1;
            this.Banner.Text = "Add Expense Type";
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
            this.userImage.TabIndex = 21;
            this.userImage.TabStop = false;
            this.userImage.Click += new System.EventHandler(this.userImage_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(452, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(387, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "This help you to select more types of expense in travel";
            // 
            // successMsg
            // 
            this.successMsg.AutoSize = true;
            this.successMsg.BackColor = System.Drawing.Color.Transparent;
            this.successMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.successMsg.ForeColor = System.Drawing.Color.Green;
            this.successMsg.Location = new System.Drawing.Point(452, 270);
            this.successMsg.Name = "successMsg";
            this.successMsg.Size = new System.Drawing.Size(150, 20);
            this.successMsg.TabIndex = 23;
            this.successMsg.Text = "Successfully added!";
            this.successMsg.Visible = false;
            // 
            // exTypeData
            // 
            this.exTypeData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.exTypeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exTypeData.Location = new System.Drawing.Point(293, 349);
            this.exTypeData.Name = "exTypeData";
            this.exTypeData.ReadOnly = true;
            this.exTypeData.RowHeadersWidth = 62;
            this.exTypeData.RowTemplate.Height = 28;
            this.exTypeData.Size = new System.Drawing.Size(715, 255);
            this.exTypeData.TabIndex = 24;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(57)))), ((int)(((byte)(17)))));
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(902, 309);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 34);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dltType
            // 
            this.dltType.DataSource = this.expenseTypeBindingSource2;
            this.dltType.DisplayMember = "Name";
            this.dltType.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dltType.IntegralHeight = false;
            this.dltType.ItemHeight = 20;
            this.dltType.Location = new System.Drawing.Point(697, 309);
            this.dltType.Name = "dltType";
            this.dltType.Size = new System.Drawing.Size(190, 28);
            this.dltType.TabIndex = 26;
            this.dltType.ValueMember = "Id";
            // 
            // expenseTypeBindingSource2
            // 
            this.expenseTypeBindingSource2.DataMember = "expenseType";
            this.expenseTypeBindingSource2.DataSource = this.travelExpensesDataSet2;
            // 
            // travelExpensesDataSet2
            // 
            this.travelExpensesDataSet2.DataSetName = "travelExpensesDataSet2";
            this.travelExpensesDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // expenseTypeBindingSource
            // 
            this.expenseTypeBindingSource.DataMember = "expenseType";
            this.expenseTypeBindingSource.DataSource = this.travelExpensesDataSet;
            // 
            // travelExpensesDataSet
            // 
            this.travelExpensesDataSet.DataSetName = "travelExpensesDataSet";
            this.travelExpensesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // expenseTypeTableAdapter
            // 
            this.expenseTypeTableAdapter.ClearBeforeFill = true;
            // 
            // expenseTypeBindingSource1
            // 
            this.expenseTypeBindingSource1.DataMember = "expenseType";
            this.expenseTypeBindingSource1.DataSource = this.travelExpensesDataSet;
            // 
            // expenseTypeTableAdapter1
            // 
            this.expenseTypeTableAdapter1.ClearBeforeFill = true;
            // 
            // profileName
            // 
            this.profileName.AutoSize = true;
            this.profileName.BackColor = System.Drawing.Color.Transparent;
            this.profileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileName.Location = new System.Drawing.Point(1097, 28);
            this.profileName.Name = "profileName";
            this.profileName.Size = new System.Drawing.Size(87, 20);
            this.profileName.TabIndex = 64;
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
            this.btnDashboard.Location = new System.Drawing.Point(233, 28);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(156, 44);
            this.btnDashboard.TabIndex = 67;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
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
            this.btnAddex.Location = new System.Drawing.Point(12, 28);
            this.btnAddex.Name = "btnAddex";
            this.btnAddex.Size = new System.Drawing.Size(194, 44);
            this.btnAddex.TabIndex = 66;
            this.btnAddex.Text = "Add Expenses";
            this.btnAddex.UseVisualStyleBackColor = false;
            this.btnAddex.Click += new System.EventHandler(this.btnAddex_Click);
            // 
            // expense_type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(233)))));
            this.BackgroundImage = global::Travel_Expense_tracker.Properties.Resources.Untitled_design4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1274, 684);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.btnAddex);
            this.Controls.Add(this.profileName);
            this.Controls.Add(this.dltType);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.exTypeData);
            this.Controls.Add(this.successMsg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enterType);
            this.Controls.Add(this.exName);
            this.Controls.Add(this.Banner);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1296, 740);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1296, 740);
            this.Name = "expense_type";
            this.Text = "Add Expense Type ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.expense_type_FormClosed);
            this.Load += new System.EventHandler(this.expense_type_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exTypeData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseTypeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpensesDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpensesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseTypeBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button enterType;
        private System.Windows.Forms.TextBox exName;
        private System.Windows.Forms.Label Banner;
        private System.Windows.Forms.PictureBox userImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label successMsg;
        private System.Windows.Forms.DataGridView exTypeData;
        private System.Windows.Forms.Button btnDelete;
        private travelExpensesDataSet travelExpensesDataSet;
        private System.Windows.Forms.BindingSource expenseTypeBindingSource;
        private travelExpensesDataSetTableAdapters.expenseTypeTableAdapter expenseTypeTableAdapter;
        public System.Windows.Forms.ComboBox dltType;
        private System.Windows.Forms.BindingSource expenseTypeBindingSource1;
        private travelExpensesDataSet2 travelExpensesDataSet2;
        private System.Windows.Forms.BindingSource expenseTypeBindingSource2;
        private travelExpensesDataSet2TableAdapters.expenseTypeTableAdapter expenseTypeTableAdapter1;
        private System.Windows.Forms.Label profileName;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnAddex;
    }
}