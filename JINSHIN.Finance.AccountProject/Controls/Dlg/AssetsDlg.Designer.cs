namespace JINSHIN.Finance.AccountSystem.Controls.Dlg
{
    partial class AssetsDlg
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
            this.dgData = new System.Windows.Forms.DataGridView();
            this.pltop = new System.Windows.Forms.Panel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblTitle03 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblTitle02 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.lbltitle01 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            this.pltop.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgData
            // 
            this.dgData.AllowUserToAddRows = false;
            this.dgData.AllowUserToDeleteRows = false;
            this.dgData.AllowUserToResizeColumns = false;
            this.dgData.AllowUserToResizeRows = false;
            this.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgData.Location = new System.Drawing.Point(48, 84);
            this.dgData.Name = "dgData";
            this.dgData.RowTemplate.Height = 24;
            this.dgData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgData.Size = new System.Drawing.Size(730, 491);
            this.dgData.TabIndex = 9;
            this.dgData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgData_CellClick);
            // 
            // pltop
            // 
            this.pltop.Controls.Add(this.btnConfirm);
            this.pltop.Controls.Add(this.txtPrice);
            this.pltop.Controls.Add(this.lblTitle03);
            this.pltop.Controls.Add(this.txtName);
            this.pltop.Controls.Add(this.lblTitle02);
            this.pltop.Controls.Add(this.btnClear);
            this.pltop.Controls.Add(this.btnQuery);
            this.pltop.Controls.Add(this.lbltitle01);
            this.pltop.Controls.Add(this.txtID);
            this.pltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pltop.Location = new System.Drawing.Point(0, 0);
            this.pltop.Name = "pltop";
            this.pltop.Size = new System.Drawing.Size(821, 70);
            this.pltop.TabIndex = 8;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnConfirm.Location = new System.Drawing.Point(723, 16);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(81, 35);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "確認";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPrice.Location = new System.Drawing.Point(423, 22);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 27);
            this.txtPrice.TabIndex = 4;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblTitle03
            // 
            this.lblTitle03.AutoSize = true;
            this.lblTitle03.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTitle03.Location = new System.Drawing.Point(370, 27);
            this.lblTitle03.Name = "lblTitle03";
            this.lblTitle03.Size = new System.Drawing.Size(39, 16);
            this.lblTitle03.TabIndex = 3;
            this.lblTitle03.Text = "價格";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(259, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 27);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblTitle02
            // 
            this.lblTitle02.AutoSize = true;
            this.lblTitle02.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTitle02.Location = new System.Drawing.Point(206, 27);
            this.lblTitle02.Name = "lblTitle02";
            this.lblTitle02.Size = new System.Drawing.Size(39, 16);
            this.lblTitle02.TabIndex = 3;
            this.lblTitle02.Text = "名稱";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(636, 16);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(81, 35);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnQuery.Location = new System.Drawing.Point(549, 16);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(81, 35);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "查詢";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // lbltitle01
            // 
            this.lbltitle01.AutoSize = true;
            this.lbltitle01.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbltitle01.Location = new System.Drawing.Point(11, 27);
            this.lbltitle01.Name = "lbltitle01";
            this.lbltitle01.Size = new System.Drawing.Size(71, 16);
            this.lbltitle01.TabIndex = 1;
            this.lbltitle01.Text = "會計編號";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtID.Location = new System.Drawing.Point(97, 22);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 27);
            this.txtID.TabIndex = 0;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // AssetsDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 593);
            this.Controls.Add(this.dgData);
            this.Controls.Add(this.pltop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AssetsDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "資財查詢";
            this.Shown += new System.EventHandler(this.AssetsDlg_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            this.pltop.ResumeLayout(false);
            this.pltop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgData;
        private System.Windows.Forms.Panel pltop;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblTitle02;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label lbltitle01;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblTitle03;
        private System.Windows.Forms.Button btnConfirm;
    }
}