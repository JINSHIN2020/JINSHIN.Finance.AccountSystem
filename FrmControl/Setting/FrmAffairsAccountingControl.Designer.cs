
namespace JINSHIN.Finance.AccountSystem.FrmControl
{
    partial class FrmAffairsAccountingControl
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
            this.dbMasterData = new System.Windows.Forms.DataGridView();
            this.btnMQuery = new System.Windows.Forms.Button();
            this.btnMDelete = new System.Windows.Forms.Button();
            this.btnMUpdate = new System.Windows.Forms.Button();
            this.btnMAdd = new System.Windows.Forms.Button();
            this.txtDiaAccDesc = new System.Windows.Forms.TextBox();
            this.txtIDiaAccDesc = new System.Windows.Forms.TextBox();
            this.txtSN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAffairsSN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblaccAffairs = new System.Windows.Forms.Label();
            this.gbAccid = new System.Windows.Forms.GroupBox();
            this.lblDescSN = new System.Windows.Forms.Label();
            this.lblaccDescNo = new System.Windows.Forms.Label();
            this.btnDDeleteAll = new System.Windows.Forms.Button();
            this.btnDdelete = new System.Windows.Forms.Button();
            this.txDiaAccDesc01 = new System.Windows.Forms.TextBox();
            this.btnDetailUpdate = new System.Windows.Forms.Button();
            this.btnDetailAdd = new System.Windows.Forms.Button();
            this.txDiaAccID = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dgDetailData = new System.Windows.Forms.DataGridView();
            this.lblDesc01 = new System.Windows.Forms.Label();
            this.gbaffairs = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dbMasterData)).BeginInit();
            this.gbAccid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetailData)).BeginInit();
            this.gbaffairs.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbMasterData
            // 
            this.dbMasterData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbMasterData.Location = new System.Drawing.Point(6, 142);
            this.dbMasterData.Name = "dbMasterData";
            this.dbMasterData.ReadOnly = true;
            this.dbMasterData.RowTemplate.Height = 24;
            this.dbMasterData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dbMasterData.Size = new System.Drawing.Size(1140, 287);
            this.dbMasterData.TabIndex = 57;
            this.dbMasterData.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbMasterData_RowEnter);
            this.dbMasterData.SelectionChanged += new System.EventHandler(this.dbMasterData_SelectionChanged);
            // 
            // btnMQuery
            // 
            this.btnMQuery.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMQuery.Location = new System.Drawing.Point(491, 31);
            this.btnMQuery.Name = "btnMQuery";
            this.btnMQuery.Size = new System.Drawing.Size(174, 41);
            this.btnMQuery.TabIndex = 56;
            this.btnMQuery.Text = "查詢";
            this.btnMQuery.UseVisualStyleBackColor = true;
            this.btnMQuery.Click += new System.EventHandler(this.btnMQuery_Click);
            // 
            // btnMDelete
            // 
            this.btnMDelete.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMDelete.Location = new System.Drawing.Point(851, 91);
            this.btnMDelete.Name = "btnMDelete";
            this.btnMDelete.Size = new System.Drawing.Size(174, 41);
            this.btnMDelete.TabIndex = 56;
            this.btnMDelete.Text = "刪除";
            this.btnMDelete.UseVisualStyleBackColor = true;
            this.btnMDelete.Click += new System.EventHandler(this.btnMDelete_Click);
            // 
            // btnMUpdate
            // 
            this.btnMUpdate.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMUpdate.Location = new System.Drawing.Point(671, 91);
            this.btnMUpdate.Name = "btnMUpdate";
            this.btnMUpdate.Size = new System.Drawing.Size(174, 41);
            this.btnMUpdate.TabIndex = 56;
            this.btnMUpdate.Text = "更新";
            this.btnMUpdate.UseVisualStyleBackColor = true;
            this.btnMUpdate.Click += new System.EventHandler(this.btnMUpdate_Click);
            // 
            // btnMAdd
            // 
            this.btnMAdd.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMAdd.Location = new System.Drawing.Point(491, 91);
            this.btnMAdd.Name = "btnMAdd";
            this.btnMAdd.Size = new System.Drawing.Size(174, 41);
            this.btnMAdd.TabIndex = 56;
            this.btnMAdd.Text = "新增";
            this.btnMAdd.UseVisualStyleBackColor = true;
            this.btnMAdd.Click += new System.EventHandler(this.btnMAdd_Click);
            // 
            // txtDiaAccDesc
            // 
            this.txtDiaAccDesc.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDiaAccDesc.Location = new System.Drawing.Point(290, 31);
            this.txtDiaAccDesc.Multiline = true;
            this.txtDiaAccDesc.Name = "txtDiaAccDesc";
            this.txtDiaAccDesc.Size = new System.Drawing.Size(181, 30);
            this.txtDiaAccDesc.TabIndex = 54;
            // 
            // txtIDiaAccDesc
            // 
            this.txtIDiaAccDesc.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtIDiaAccDesc.Location = new System.Drawing.Point(290, 91);
            this.txtIDiaAccDesc.Multiline = true;
            this.txtIDiaAccDesc.Name = "txtIDiaAccDesc";
            this.txtIDiaAccDesc.Size = new System.Drawing.Size(181, 30);
            this.txtIDiaAccDesc.TabIndex = 54;
            // 
            // txtSN
            // 
            this.txtSN.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSN.Location = new System.Drawing.Point(72, 31);
            this.txtSN.Multiline = true;
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(138, 26);
            this.txtSN.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(231, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 52;
            this.label2.Text = "事務";
            // 
            // lblAffairsSN
            // 
            this.lblAffairsSN.AutoSize = true;
            this.lblAffairsSN.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAffairsSN.Location = new System.Drawing.Point(81, 91);
            this.lblAffairsSN.Name = "lblAffairsSN";
            this.lblAffairsSN.Size = new System.Drawing.Size(114, 19);
            this.lblAffairsSN.TabIndex = 53;
            this.lblAffairsSN.Text = "                     ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(13, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 53;
            this.label1.Text = "編號";
            // 
            // lblaccAffairs
            // 
            this.lblaccAffairs.AutoSize = true;
            this.lblaccAffairs.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblaccAffairs.Location = new System.Drawing.Point(13, 31);
            this.lblaccAffairs.Name = "lblaccAffairs";
            this.lblaccAffairs.Size = new System.Drawing.Size(47, 19);
            this.lblaccAffairs.TabIndex = 53;
            this.lblaccAffairs.Text = "編號";
            // 
            // gbAccid
            // 
            this.gbAccid.Controls.Add(this.lblDescSN);
            this.gbAccid.Controls.Add(this.lblaccDescNo);
            this.gbAccid.Controls.Add(this.btnDDeleteAll);
            this.gbAccid.Controls.Add(this.btnDdelete);
            this.gbAccid.Controls.Add(this.txDiaAccDesc01);
            this.gbAccid.Controls.Add(this.btnDetailUpdate);
            this.gbAccid.Controls.Add(this.btnDetailAdd);
            this.gbAccid.Controls.Add(this.txDiaAccID);
            this.gbAccid.Controls.Add(this.label17);
            this.gbAccid.Controls.Add(this.label16);
            this.gbAccid.Controls.Add(this.dgDetailData);
            this.gbAccid.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbAccid.Location = new System.Drawing.Point(7, 459);
            this.gbAccid.Name = "gbAccid";
            this.gbAccid.Size = new System.Drawing.Size(1182, 450);
            this.gbAccid.TabIndex = 58;
            this.gbAccid.TabStop = false;
            this.gbAccid.Text = "會計資料";
            // 
            // lblDescSN
            // 
            this.lblDescSN.AutoSize = true;
            this.lblDescSN.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDescSN.Location = new System.Drawing.Point(75, 42);
            this.lblDescSN.Name = "lblDescSN";
            this.lblDescSN.Size = new System.Drawing.Size(114, 19);
            this.lblDescSN.TabIndex = 58;
            this.lblDescSN.Text = "                     ";
            // 
            // lblaccDescNo
            // 
            this.lblaccDescNo.AutoSize = true;
            this.lblaccDescNo.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblaccDescNo.Location = new System.Drawing.Point(14, 42);
            this.lblaccDescNo.Name = "lblaccDescNo";
            this.lblaccDescNo.Size = new System.Drawing.Size(47, 19);
            this.lblaccDescNo.TabIndex = 58;
            this.lblaccDescNo.Text = "編號";
            // 
            // btnDDeleteAll
            // 
            this.btnDDeleteAll.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDDeleteAll.Location = new System.Drawing.Point(921, 89);
            this.btnDDeleteAll.Name = "btnDDeleteAll";
            this.btnDDeleteAll.Size = new System.Drawing.Size(174, 40);
            this.btnDDeleteAll.TabIndex = 56;
            this.btnDDeleteAll.Text = "刪除全部";
            this.btnDDeleteAll.UseVisualStyleBackColor = true;
            this.btnDDeleteAll.Click += new System.EventHandler(this.btnDDeleteAll_Click);
            // 
            // btnDdelete
            // 
            this.btnDdelete.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDdelete.Location = new System.Drawing.Point(740, 89);
            this.btnDdelete.Name = "btnDdelete";
            this.btnDdelete.Size = new System.Drawing.Size(174, 40);
            this.btnDdelete.TabIndex = 56;
            this.btnDdelete.Text = "刪除";
            this.btnDdelete.UseVisualStyleBackColor = true;
            this.btnDdelete.Click += new System.EventHandler(this.btnDdelete_Click);
            // 
            // txDiaAccDesc01
            // 
            this.txDiaAccDesc01.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txDiaAccDesc01.Location = new System.Drawing.Point(519, 45);
            this.txDiaAccDesc01.Multiline = true;
            this.txDiaAccDesc01.Name = "txDiaAccDesc01";
            this.txDiaAccDesc01.Size = new System.Drawing.Size(181, 30);
            this.txDiaAccDesc01.TabIndex = 55;
            // 
            // btnDetailUpdate
            // 
            this.btnDetailUpdate.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDetailUpdate.Location = new System.Drawing.Point(921, 38);
            this.btnDetailUpdate.Name = "btnDetailUpdate";
            this.btnDetailUpdate.Size = new System.Drawing.Size(174, 40);
            this.btnDetailUpdate.TabIndex = 56;
            this.btnDetailUpdate.Text = "更新";
            this.btnDetailUpdate.UseVisualStyleBackColor = true;
            this.btnDetailUpdate.Click += new System.EventHandler(this.btnDetailUpdate_Click);
            // 
            // btnDetailAdd
            // 
            this.btnDetailAdd.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDetailAdd.Location = new System.Drawing.Point(740, 38);
            this.btnDetailAdd.Name = "btnDetailAdd";
            this.btnDetailAdd.Size = new System.Drawing.Size(174, 40);
            this.btnDetailAdd.TabIndex = 56;
            this.btnDetailAdd.Text = "新增";
            this.btnDetailAdd.UseVisualStyleBackColor = true;
            this.btnDetailAdd.Click += new System.EventHandler(this.btnDetailAdd_Click);
            // 
            // txDiaAccID
            // 
            this.txDiaAccID.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txDiaAccID.Location = new System.Drawing.Point(314, 45);
            this.txDiaAccID.Name = "txDiaAccID";
            this.txDiaAccID.Size = new System.Drawing.Size(138, 30);
            this.txDiaAccID.TabIndex = 56;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label17.Location = new System.Drawing.Point(460, 45);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 19);
            this.label17.TabIndex = 53;
            this.label17.Text = "名稱";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.Location = new System.Drawing.Point(213, 45);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 19);
            this.label16.TabIndex = 54;
            this.label16.Text = "會計科目";
            // 
            // dgDetailData
            // 
            this.dgDetailData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetailData.Location = new System.Drawing.Point(15, 147);
            this.dgDetailData.Name = "dgDetailData";
            this.dgDetailData.ReadOnly = true;
            this.dgDetailData.RowTemplate.Height = 24;
            this.dgDetailData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDetailData.Size = new System.Drawing.Size(1146, 284);
            this.dgDetailData.TabIndex = 57;
            this.dgDetailData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDetailData_CellClick);
            this.dgDetailData.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDetailData_RowEnter);
            this.dgDetailData.SelectionChanged += new System.EventHandler(this.dgDetailData_SelectionChanged);
            // 
            // lblDesc01
            // 
            this.lblDesc01.AutoSize = true;
            this.lblDesc01.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDesc01.Location = new System.Drawing.Point(231, 31);
            this.lblDesc01.Name = "lblDesc01";
            this.lblDesc01.Size = new System.Drawing.Size(47, 19);
            this.lblDesc01.TabIndex = 52;
            this.lblDesc01.Text = "事務";
            // 
            // gbaffairs
            // 
            this.gbaffairs.Controls.Add(this.dbMasterData);
            this.gbaffairs.Controls.Add(this.btnMQuery);
            this.gbaffairs.Controls.Add(this.btnMDelete);
            this.gbaffairs.Controls.Add(this.btnMUpdate);
            this.gbaffairs.Controls.Add(this.btnMAdd);
            this.gbaffairs.Controls.Add(this.txtDiaAccDesc);
            this.gbaffairs.Controls.Add(this.txtIDiaAccDesc);
            this.gbaffairs.Controls.Add(this.txtSN);
            this.gbaffairs.Controls.Add(this.label2);
            this.gbaffairs.Controls.Add(this.lblAffairsSN);
            this.gbaffairs.Controls.Add(this.label1);
            this.gbaffairs.Controls.Add(this.lblDesc01);
            this.gbaffairs.Controls.Add(this.lblaccAffairs);
            this.gbaffairs.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbaffairs.Location = new System.Drawing.Point(10, 5);
            this.gbaffairs.Name = "gbaffairs";
            this.gbaffairs.Size = new System.Drawing.Size(1157, 444);
            this.gbaffairs.TabIndex = 57;
            this.gbaffairs.TabStop = false;
            this.gbaffairs.Text = "事務";
            // 
            // FrmAffairsAccountingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1200, 932);
            this.Controls.Add(this.gbAccid);
            this.Controls.Add(this.gbaffairs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAffairsAccountingControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "事務設定";
            this.Shown += new System.EventHandler(this.FrmAffairsAccountingControl_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dbMasterData)).EndInit();
            this.gbAccid.ResumeLayout(false);
            this.gbAccid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetailData)).EndInit();
            this.gbaffairs.ResumeLayout(false);
            this.gbaffairs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dbMasterData;
        public System.Windows.Forms.Button btnMQuery;
        public System.Windows.Forms.Button btnMDelete;
        public System.Windows.Forms.Button btnMUpdate;
        public System.Windows.Forms.Button btnMAdd;
        private System.Windows.Forms.TextBox txtDiaAccDesc;
        private System.Windows.Forms.TextBox txtIDiaAccDesc;
        private System.Windows.Forms.TextBox txtSN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAffairsSN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblaccAffairs;
        private System.Windows.Forms.GroupBox gbAccid;
        private System.Windows.Forms.Label lblDescSN;
        private System.Windows.Forms.Label lblaccDescNo;
        public System.Windows.Forms.Button btnDDeleteAll;
        public System.Windows.Forms.Button btnDdelete;
        private System.Windows.Forms.TextBox txDiaAccDesc01;
        public System.Windows.Forms.Button btnDetailUpdate;
        public System.Windows.Forms.Button btnDetailAdd;
        private System.Windows.Forms.TextBox txDiaAccID;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.DataGridView dgDetailData;
        private System.Windows.Forms.Label lblDesc01;
        private System.Windows.Forms.GroupBox gbaffairs;
    }
}