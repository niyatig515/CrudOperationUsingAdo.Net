namespace StudentApllicationUsingADO.NET
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
            txtName = new TextBox();
            txtAge = new TextBox();
            txtCourse = new TextBox();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnLoadData = new Button();
            DataGridView = new DataGridView();
            lblAge = new Label();
            lblCourse = new Label();
            lblName = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            panel2 = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtName
            // 
            resources.ApplyResources(txtName, "txtName");
            txtName.Name = "txtName";
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtAge
            // 
            resources.ApplyResources(txtAge, "txtAge");
            txtAge.Name = "txtAge";
            // 
            // txtCourse
            // 
            resources.ApplyResources(txtCourse, "txtCourse");
            txtCourse.Name = "txtCourse";
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.PaleTurquoise;
            resources.ApplyResources(btnInsert, "btnInsert");
            btnInsert.Name = "btnInsert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.PaleTurquoise;
            resources.ApplyResources(btnUpdate, "btnUpdate");
            btnUpdate.Name = "btnUpdate";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.PaleTurquoise;
            resources.ApplyResources(btnDelete, "btnDelete");
            btnDelete.Name = "btnDelete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoadData
            // 
            btnLoadData.BackColor = Color.PaleTurquoise;
            resources.ApplyResources(btnLoadData, "btnLoadData");
            btnLoadData.Name = "btnLoadData";
            btnLoadData.UseVisualStyleBackColor = false;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // DataGridView
            // 
            resources.ApplyResources(DataGridView, "DataGridView");
            DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Name = "DataGridView";
            DataGridView.CellContentClick += DataGridView_CellContentClick;
            // 
            // lblAge
            // 
            resources.ApplyResources(lblAge, "lblAge");
            lblAge.Name = "lblAge";
            lblAge.Click += lblAge_Click;
            // 
            // lblCourse
            // 
            resources.ApplyResources(lblCourse, "lblCourse");
            lblCourse.Name = "lblCourse";
            // 
            // lblName
            // 
            resources.ApplyResources(lblName, "lblName");
            lblName.Name = "lblName";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.PaleTurquoise;
            resources.ApplyResources(btnSearch, "btnSearch");
            btnSearch.Name = "btnSearch";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            resources.ApplyResources(txtSearch, "txtSearch");
            txtSearch.Name = "txtSearch";
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // panel2
            // 
            resources.ApplyResources(panel2, "panel2");
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(lblName);
            panel2.Controls.Add(lblAge);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(txtSearch);
            panel2.Controls.Add(btnLoadData);
            panel2.Controls.Add(lblCourse);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(txtAge);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(txtCourse);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnInsert);
            panel2.Name = "panel2";
            panel2.Paint += panel2_Paint;
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.Controls.Add(DataGridView);
            panel1.Name = "panel1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtName;
        private TextBox txtAge;
        private TextBox txtCourse;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnLoadData;
        private DataGridView DataGridView;
        private Label lblAge;
        private Label lblCourse;
        private Label lblName;
        private Button btnSearch;
        private TextBox txtSearch;
        private Panel panel2;
        private Panel panel1;
    }
}
