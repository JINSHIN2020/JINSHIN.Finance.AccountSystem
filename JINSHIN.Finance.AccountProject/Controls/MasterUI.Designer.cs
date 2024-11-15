namespace FinanceAccountProgram.Controls
{
    partial class MasterUI
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dbMasterData = new System.Windows.Forms.DataGridView();
            this.btnMQuery = new System.Windows.Forms.Button();
            this.btnMDelete = new System.Windows.Forms.Button();
            this.btnMUpdate = new System.Windows.Forms.Button();
            this.btnMAdd = new System.Windows.Forms.Button();
            this.txtAccName = new System.Windows.Forms.TextBox();
            this.txtIAccName = new System.Windows.Forms.TextBox();
            this.txtSN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDesc01 = new System.Windows.Forms.Label();
            this.lblaccAffairs = new System.Windows.Forms.Label();
            this.txtDataCnt = new System.Windows.Forms.TextBox();
            this.lblDataAllCnt = new System.Windows.Forms.Label();
            this.lblSetupDataCnt = new System.Windows.Forms.Label();
            this.lblAllCnt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbMasterData)).BeginInit();
            this.SuspendLayout();
            // 
            // dbMasterData
            // 
            this.dbMasterData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbMasterData.Location = new System.Drawing.Point(10, 127);
            this.dbMasterData.Name = "dbMasterData";
            this.dbMasterData.ReadOnly = true;
            this.dbMasterData.RowTemplate.Height = 24;
            this.dbMasterData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dbMasterData.Size = new System.Drawing.Size(1140, 448);
            this.dbMasterData.TabIndex = 70;
            this.dbMasterData.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbMasterData_RowEnter);
            this.dbMasterData.SelectionChanged += new System.EventHandler(this.dbMasterData_SelectionChanged);
            // 
            // btnMQuery
            // 
            this.btnMQuery.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMQuery.Location = new System.Drawing.Point(575, 16);
            this.btnMQuery.Name = "btnMQuery";
            this.btnMQuery.Size = new System.Drawing.Size(174, 39);
            this.btnMQuery.TabIndex = 66;
            this.btnMQuery.Text = "查詢";
            this.btnMQuery.UseVisualStyleBackColor = true;
            this.btnMQuery.Click += new System.EventHandler(this.btnMQuery_Click);
            // 
            // btnMDelete
            // 
            this.btnMDelete.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMDelete.Location = new System.Drawing.Point(935, 76);
            this.btnMDelete.Name = "btnMDelete";
            this.btnMDelete.Size = new System.Drawing.Size(174, 40);
            this.btnMDelete.TabIndex = 67;
            this.btnMDelete.Text = "刪除";
            this.btnMDelete.UseVisualStyleBackColor = true;
            this.btnMDelete.Click += new System.EventHandler(this.btnMDelete_Click);
            // 
            // btnMUpdate
            // 
            this.btnMUpdate.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMUpdate.Location = new System.Drawing.Point(755, 76);
            this.btnMUpdate.Name = "btnMUpdate";
            this.btnMUpdate.Size = new System.Drawing.Size(174, 40);
            this.btnMUpdate.TabIndex = 68;
            this.btnMUpdate.Text = "更新";
            this.btnMUpdate.UseVisualStyleBackColor = true;
            this.btnMUpdate.Click += new System.EventHandler(this.btnMUpdate_Click);
            // 
            // btnMAdd
            // 
            this.btnMAdd.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMAdd.Location = new System.Drawing.Point(575, 76);
            this.btnMAdd.Name = "btnMAdd";
            this.btnMAdd.Size = new System.Drawing.Size(174, 39);
            this.btnMAdd.TabIndex = 69;
            this.btnMAdd.Text = "新增";
            this.btnMAdd.UseVisualStyleBackColor = true;
            this.btnMAdd.Click += new System.EventHandler(this.btnMAdd_Click);
            // 
            // txtAccName
            // 
            this.txtAccName.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAccName.Location = new System.Drawing.Point(374, 16);
            this.txtAccName.Multiline = true;
            this.txtAccName.Name = "txtAccName";
            this.txtAccName.Size = new System.Drawing.Size(181, 30);
            this.txtAccName.TabIndex = 63;
            // 
            // txtIAccName
            // 
            this.txtIAccName.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtIAccName.Location = new System.Drawing.Point(374, 76);
            this.txtIAccName.Multiline = true;
            this.txtIAccName.Name = "txtIAccName";
            this.txtIAccName.Size = new System.Drawing.Size(181, 30);
            this.txtIAccName.TabIndex = 64;
            // 
            // txtSN
            // 
            this.txtSN.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSN.Location = new System.Drawing.Point(76, 16);
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(138, 30);
            this.txtSN.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(230, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 19);
            this.label2.TabIndex = 58;
            this.label2.Text = "常用會計名稱";
            // 
            // lblSN
            // 
            this.lblSN.AutoSize = true;
            this.lblSN.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSN.Location = new System.Drawing.Point(85, 76);
            this.lblSN.Name = "lblSN";
            this.lblSN.Size = new System.Drawing.Size(114, 19);
            this.lblSN.TabIndex = 60;
            this.lblSN.Text = "                     ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(21, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 61;
            this.label1.Text = "編號";
            // 
            // lblDesc01
            // 
            this.lblDesc01.AutoSize = true;
            this.lblDesc01.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDesc01.Location = new System.Drawing.Point(230, 22);
            this.lblDesc01.Name = "lblDesc01";
            this.lblDesc01.Size = new System.Drawing.Size(123, 19);
            this.lblDesc01.TabIndex = 59;
            this.lblDesc01.Text = "常用會計名稱";
            // 
            // lblaccAffairs
            // 
            this.lblaccAffairs.AutoSize = true;
            this.lblaccAffairs.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblaccAffairs.Location = new System.Drawing.Point(21, 16);
            this.lblaccAffairs.Name = "lblaccAffairs";
            this.lblaccAffairs.Size = new System.Drawing.Size(47, 19);
            this.lblaccAffairs.TabIndex = 62;
            this.lblaccAffairs.Text = "編號";
            // 
            // txtDataCnt
            // 
            this.txtDataCnt.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDataCnt.Location = new System.Drawing.Point(1132, 7);
            this.txtDataCnt.Name = "txtDataCnt";
            this.txtDataCnt.Size = new System.Drawing.Size(70, 30);
            this.txtDataCnt.TabIndex = 74;
            this.txtDataCnt.Text = "150";
            // 
            // lblDataAllCnt
            // 
            this.lblDataAllCnt.AutoSize = true;
            this.lblDataAllCnt.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDataAllCnt.Location = new System.Drawing.Point(1152, 45);
            this.lblDataAllCnt.Name = "lblDataAllCnt";
            this.lblDataAllCnt.Size = new System.Drawing.Size(18, 19);
            this.lblDataAllCnt.TabIndex = 71;
            this.lblDataAllCnt.Text = "0";
            // 
            // lblSetupDataCnt
            // 
            this.lblSetupDataCnt.AutoSize = true;
            this.lblSetupDataCnt.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSetupDataCnt.Location = new System.Drawing.Point(1037, 7);
            this.lblSetupDataCnt.Name = "lblSetupDataCnt";
            this.lblSetupDataCnt.Size = new System.Drawing.Size(85, 19);
            this.lblSetupDataCnt.TabIndex = 72;
            this.lblSetupDataCnt.Text = "資料筆數";
            // 
            // lblAllCnt
            // 
            this.lblAllCnt.AutoSize = true;
            this.lblAllCnt.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAllCnt.Location = new System.Drawing.Point(1037, 45);
            this.lblAllCnt.Name = "lblAllCnt";
            this.lblAllCnt.Size = new System.Drawing.Size(104, 19);
            this.lblAllCnt.TabIndex = 73;
            this.lblAllCnt.Text = "資料總筆數";
            // 
            // MasterUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDataCnt);
            this.Controls.Add(this.lblDataAllCnt);
            this.Controls.Add(this.lblSetupDataCnt);
            this.Controls.Add(this.lblAllCnt);
            this.Controls.Add(this.dbMasterData);
            this.Controls.Add(this.btnMQuery);
            this.Controls.Add(this.btnMDelete);
            this.Controls.Add(this.btnMUpdate);
            this.Controls.Add(this.btnMAdd);
            this.Controls.Add(this.txtAccName);
            this.Controls.Add(this.txtIAccName);
            this.Controls.Add(this.txtSN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDesc01);
            this.Controls.Add(this.lblaccAffairs);
            this.Name = "MasterUI";
            this.Size = new System.Drawing.Size(1245, 595);
            ((System.ComponentModel.ISupportInitialize)(this.dbMasterData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dbMasterData;
        public System.Windows.Forms.Button btnMQuery;
        public System.Windows.Forms.Button btnMDelete;
        public System.Windows.Forms.Button btnMUpdate;
        public System.Windows.Forms.Button btnMAdd;
        private System.Windows.Forms.TextBox txtAccName;
        private System.Windows.Forms.TextBox txtIAccName;
        private System.Windows.Forms.TextBox txtSN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDesc01;
        private System.Windows.Forms.Label lblaccAffairs;
        private System.Windows.Forms.TextBox txtDataCnt;
        private System.Windows.Forms.Label lblDataAllCnt;
        private System.Windows.Forms.Label lblSetupDataCnt;
        private System.Windows.Forms.Label lblAllCnt;
    }
}
