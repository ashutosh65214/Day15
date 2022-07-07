namespace Day15
{
    partial class Form1
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
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.GridDepartment = new System.Windows.Forms.DataGridView();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TxtLocation = new System.Windows.Forms.TextBox();
            this.TxtDepartHead = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDepartName = new System.Windows.Forms.TextBox();
            this.TxtDepartCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(628, 30);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 35;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.AutoSize = true;
            this.BtnRefresh.Location = new System.Drawing.Point(531, 202);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(78, 30);
            this.BtnRefresh.TabIndex = 34;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // GridDepartment
            // 
            this.GridDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDepartment.Location = new System.Drawing.Point(95, 282);
            this.GridDepartment.Name = "GridDepartment";
            this.GridDepartment.RowHeadersWidth = 51;
            this.GridDepartment.RowTemplate.Height = 24;
            this.GridDepartment.Size = new System.Drawing.Size(631, 220);
            this.GridDepartment.TabIndex = 33;
            // 
            // BtnDelete
            // 
            this.BtnDelete.AutoSize = true;
            this.BtnDelete.Location = new System.Drawing.Point(417, 202);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 30);
            this.BtnDelete.TabIndex = 32;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.AutoSize = true;
            this.BtnUpdate.Location = new System.Drawing.Point(296, 202);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 30);
            this.BtnUpdate.TabIndex = 31;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.AutoSize = true;
            this.BtnAdd.Location = new System.Drawing.Point(172, 202);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(86, 30);
            this.BtnAdd.TabIndex = 30;
            this.BtnAdd.Text = "Add New";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TxtLocation
            // 
            this.TxtLocation.Location = new System.Drawing.Point(368, 152);
            this.TxtLocation.Margin = new System.Windows.Forms.Padding(4);
            this.TxtLocation.Name = "TxtLocation";
            this.TxtLocation.Size = new System.Drawing.Size(219, 20);
            this.TxtLocation.TabIndex = 29;
            // 
            // TxtDepartHead
            // 
            this.TxtDepartHead.Location = new System.Drawing.Point(368, 111);
            this.TxtDepartHead.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDepartHead.Name = "TxtDepartHead";
            this.TxtDepartHead.Size = new System.Drawing.Size(219, 20);
            this.TxtDepartHead.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Department Head";
            // 
            // TxtDepartName
            // 
            this.TxtDepartName.Location = new System.Drawing.Point(368, 73);
            this.TxtDepartName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDepartName.Name = "TxtDepartName";
            this.TxtDepartName.Size = new System.Drawing.Size(219, 20);
            this.TxtDepartName.TabIndex = 25;
            // 
            // TxtDepartCode
            // 
            this.TxtDepartCode.Location = new System.Drawing.Point(368, 30);
            this.TxtDepartCode.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDepartCode.Name = "TxtDepartCode";
            this.TxtDepartCode.Size = new System.Drawing.Size(219, 20);
            this.TxtDepartCode.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Department Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Department Code";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 537);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.GridDepartment);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxtLocation);
            this.Controls.Add(this.TxtDepartHead);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtDepartName);
            this.Controls.Add(this.TxtDepartCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridDepartment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.DataGridView GridDepartment;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox TxtLocation;
        private System.Windows.Forms.TextBox TxtDepartHead;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtDepartName;
        private System.Windows.Forms.TextBox TxtDepartCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

