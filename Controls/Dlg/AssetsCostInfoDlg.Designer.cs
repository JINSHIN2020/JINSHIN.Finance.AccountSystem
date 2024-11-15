namespace JINSHIN.Finance.AccountSystem.Controls.Dlg
{
    partial class AssetsCostInfoDlg
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
            this.dgData.Location = new System.Drawing.Point(72, 65);
            this.dgData.Name = "dgData";
            this.dgData.RowTemplate.Height = 24;
            this.dgData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgData.Size = new System.Drawing.Size(730, 491);
            this.dgData.TabIndex = 9;
            // 
            // pltop
            // 
            this.pltop.Controls.Add(this.btnClear);
            this.pltop.Controls.Add(this.btnQuery);
            this.pltop.Controls.Add(this.lbltitle01);
            this.pltop.Controls.Add(this.txtID);
            this.pltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pltop.Location = new System.Drawing.Point(0, 0);
            this.pltop.Name = "pltop";
            this.pltop.Size = new System.Drawing.Size(860, 58);
            this.pltop.TabIndex = 8;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(541, 12);
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
            this.btnQuery.Location = new System.Drawing.Point(447, 12);
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
            this.lbltitle01.Location = new System.Drawing.Point(242, 21);
            this.lbltitle01.Name = "lbltitle01";
            this.lbltitle01.Size = new System.Drawing.Size(71, 16);
            this.lbltitle01.TabIndex = 1;
            this.lbltitle01.Text = "會計科目";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtID.Location = new System.Drawing.Point(329, 16);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 27);
            this.txtID.TabIndex = 0;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // AssetsCostInfoDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 565);
            this.Controls.Add(this.dgData);
            this.Controls.Add(this.pltop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AssetsCostInfoDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "折舊總額資訊";
            this.Shown += new System.EventHandler(this.AssetsCostInfoDlg_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            this.pltop.ResumeLayout(false);
            this.pltop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgData;
        private System.Windows.Forms.Panel pltop;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label lbltitle01;
        private System.Windows.Forms.TextBox txtID;
    }
}