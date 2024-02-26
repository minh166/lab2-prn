namespace AutoMobileWinApp
{
    partial class fmrCarManagement
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
            lbReleaseYear = new Label();
            lbPrice = new Label();
            lbManufacturer = new Label();
            lbCarName = new Label();
            lbCarID = new Label();
            txtCarID = new TextBox();
            txtCarName = new TextBox();
            txtManufacturer = new TextBox();
            txtPrice = new TextBox();
            txtReleaseYear = new TextBox();
            btnLoad = new Button();
            btnDelete = new Button();
            btnNew = new Button();
            dgvCarList = new DataGridView();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            SuspendLayout();
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Location = new Point(332, 78);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new Size(68, 15);
            lbReleaseYear.TabIndex = 1;
            lbReleaseYear.Text = "ReleaseYear";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(332, 38);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(33, 15);
            lbPrice.TabIndex = 2;
            lbPrice.Text = "Price";
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Location = new Point(47, 121);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new Size(79, 15);
            lbManufacturer.TabIndex = 3;
            lbManufacturer.Text = "Manufacturer";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new Point(47, 78);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(60, 15);
            lbCarName.TabIndex = 4;
            lbCarName.Text = "Car Name";
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new Point(47, 38);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new Size(39, 15);
            lbCarID.TabIndex = 5;
            lbCarID.Text = "Car ID";
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(138, 35);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(151, 23);
            txtCarID.TabIndex = 6;
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(138, 75);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(151, 23);
            txtCarName.TabIndex = 7;
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(138, 118);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(151, 23);
            txtManufacturer.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(424, 35);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(151, 23);
            txtPrice.TabIndex = 7;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(424, 75);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(151, 23);
            txtReleaseYear.TabIndex = 7;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(138, 156);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(89, 26);
            btnLoad.TabIndex = 8;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(440, 156);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(89, 26);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(285, 156);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(89, 26);
            btnNew.TabIndex = 8;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // dgvCarList
            // 
            dgvCarList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new Point(12, 188);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.ReadOnly = true;
            dgvCarList.RowTemplate.Height = 25;
            dgvCarList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarList.Size = new Size(608, 202);
            dgvCarList.TabIndex = 9;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(285, 396);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(89, 26);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // fmrCarManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 426);
            Controls.Add(dgvCarList);
            Controls.Add(btnClose);
            Controls.Add(btnNew);
            Controls.Add(btnDelete);
            Controls.Add(btnLoad);
            Controls.Add(txtCarID);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(txtManufacturer);
            Controls.Add(txtCarName);
            Controls.Add(lbReleaseYear);
            Controls.Add(lbPrice);
            Controls.Add(lbManufacturer);
            Controls.Add(lbCarName);
            Controls.Add(lbCarID);
            Name = "fmrCarManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Management";
            Load += fmrCarManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbReleaseYear;
        private Label lbPrice;
        private Label lbManufacturer;
        private Label lbCarName;
        private Label lbCarID;
        private TextBox txtCarID;
        private TextBox txtCarName;
        private TextBox txtManufacturer;
        private TextBox txtPrice;
        private TextBox txtReleaseYear;
        private Button btnLoad;
        private Button btnDelete;
        private Button btnNew;
        private DataGridView dgvCarList;
        private Button btnClose;
    }
}