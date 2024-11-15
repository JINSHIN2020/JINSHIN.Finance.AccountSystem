namespace FinanceAccountProgram.FrmControl
{
    partial class FrmAffairsSetupSingleForm
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
            this.gbaffairs = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnQuery = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txDiaAccDesc = new System.Windows.Forms.TextBox();
            this.DescID = new System.Windows.Forms.TextBox();
            this.lblDesc01 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbAccid = new System.Windows.Forms.GroupBox();
            this.btnAccInputNew = new System.Windows.Forms.Button();
            this.txDiaAccDesc01 = new System.Windows.Forms.TextBox();
            this.txDiaAccID = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dgAccAccountsData = new System.Windows.Forms.DataGridView();
            this.gbaffairs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbAccid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccAccountsData)).BeginInit();
            this.SuspendLayout();
            // 
            // gbaffairs
            // 
            this.gbaffairs.Controls.Add(this.dataGridView1);
            this.gbaffairs.Controls.Add(this.btnQuery);
            this.gbaffairs.Controls.Add(this.button1);
            this.gbaffairs.Controls.Add(this.txDiaAccDesc);
            this.gbaffairs.Controls.Add(this.DescID);
            this.gbaffairs.Controls.Add(this.lblDesc01);
            this.gbaffairs.Controls.Add(this.label1);
            this.gbaffairs.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbaffairs.Location = new System.Drawing.Point(12, 12);
            this.gbaffairs.Name = "gbaffairs";
            this.gbaffairs.Size = new System.Drawing.Size(1157, 324);
            this.gbaffairs.TabIndex = 53;
            this.gbaffairs.TabStop = false;
            this.gbaffairs.Text = "事務";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1064, 228);
            this.dataGridView1.TabIndex = 57;
            // 
            // btnQuery
            // 
            this.btnQuery.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnQuery.Location = new System.Drawing.Point(744, 37);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(251, 38);
            this.btnQuery.TabIndex = 56;
            this.btnQuery.Text = "查詢";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(487, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 38);
            this.button1.TabIndex = 56;
            this.button1.Text = "新增";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txDiaAccDesc
            // 
            this.txDiaAccDesc.Location = new System.Drawing.Point(290, 45);
            this.txDiaAccDesc.Multiline = true;
            this.txDiaAccDesc.Name = "txDiaAccDesc";
            this.txDiaAccDesc.Size = new System.Drawing.Size(181, 26);
            this.txDiaAccDesc.TabIndex = 54;
            // 
            // DescID
            // 
            this.DescID.Location = new System.Drawing.Point(81, 45);
            this.DescID.Multiline = true;
            this.DescID.Name = "DescID";
            this.DescID.Size = new System.Drawing.Size(138, 26);
            this.DescID.TabIndex = 55;
            // 
            // lblDesc01
            // 
            this.lblDesc01.AutoSize = true;
            this.lblDesc01.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDesc01.Location = new System.Drawing.Point(235, 45);
            this.lblDesc01.Name = "lblDesc01";
            this.lblDesc01.Size = new System.Drawing.Size(49, 19);
            this.lblDesc01.TabIndex = 52;
            this.lblDesc01.Text = "事務";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(26, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 53;
            this.label1.Text = "編號";
            // 
            // gbAccid
            // 
            this.gbAccid.Controls.Add(this.btnAccInputNew);
            this.gbAccid.Controls.Add(this.txDiaAccDesc01);
            this.gbAccid.Controls.Add(this.txDiaAccID);
            this.gbAccid.Controls.Add(this.label17);
            this.gbAccid.Controls.Add(this.label16);
            this.gbAccid.Controls.Add(this.dgAccAccountsData);
            this.gbAccid.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbAccid.Location = new System.Drawing.Point(12, 360);
            this.gbAccid.Name = "gbAccid";
            this.gbAccid.Size = new System.Drawing.Size(1157, 376);
            this.gbAccid.TabIndex = 54;
            this.gbAccid.TabStop = false;
            this.gbAccid.Text = "會計資料";
            // 
            // btnAccInputNew
            // 
            this.btnAccInputNew.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAccInputNew.Location = new System.Drawing.Point(517, 29);
            this.btnAccInputNew.Name = "btnAccInputNew";
            this.btnAccInputNew.Size = new System.Drawing.Size(251, 38);
            this.btnAccInputNew.TabIndex = 58;
            this.btnAccInputNew.Text = "新增";
            this.btnAccInputNew.UseVisualStyleBackColor = true;
            // 
            // txDiaAccDesc01
            // 
            this.txDiaAccDesc01.Location = new System.Drawing.Point(318, 37);
            this.txDiaAccDesc01.Multiline = true;
            this.txDiaAccDesc01.Name = "txDiaAccDesc01";
            this.txDiaAccDesc01.Size = new System.Drawing.Size(181, 26);
            this.txDiaAccDesc01.TabIndex = 55;
            // 
            // txDiaAccID
            // 
            this.txDiaAccID.Location = new System.Drawing.Point(104, 37);
            this.txDiaAccID.Multiline = true;
            this.txDiaAccID.Name = "txDiaAccID";
            this.txDiaAccID.Size = new System.Drawing.Size(138, 26);
            this.txDiaAccID.TabIndex = 56;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label17.Location = new System.Drawing.Point(253, 37);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 19);
            this.label17.TabIndex = 53;
            this.label17.Text = "名稱";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.Location = new System.Drawing.Point(12, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 19);
            this.label16.TabIndex = 54;
            this.label16.Text = "會計科目";
            // 
            // dgAccAccountsData
            // 
            this.dgAccAccountsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAccAccountsData.Location = new System.Drawing.Point(11, 73);
            this.dgAccAccountsData.Name = "dgAccAccountsData";
            this.dgAccAccountsData.RowTemplate.Height = 24;
            this.dgAccAccountsData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAccAccountsData.Size = new System.Drawing.Size(1146, 284);
            this.dgAccAccountsData.TabIndex = 57;
            // 
            // FrmAffairsSetupSingleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 749);
            this.Controls.Add(this.gbAccid);
            this.Controls.Add(this.gbaffairs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAffairsSetupSingleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "帳目設定";
            this.Shown += new System.EventHandler(this.FrmAffairsSetupSingleForm_Shown);
            this.gbaffairs.ResumeLayout(false);
            this.gbaffairs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbAccid.ResumeLayout(false);
            this.gbAccid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccAccountsData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbaffairs;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txDiaAccDesc;
        private System.Windows.Forms.TextBox DescID;
        private System.Windows.Forms.Label lblDesc01;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbAccid;
        private System.Windows.Forms.Button btnAccInputNew;
        private System.Windows.Forms.TextBox txDiaAccDesc01;
        private System.Windows.Forms.TextBox txDiaAccID;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgAccAccountsData;
        private System.Windows.Forms.Button btnQuery;
    }
}