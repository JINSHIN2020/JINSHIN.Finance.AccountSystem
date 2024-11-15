namespace FinanceAccountProgram.Controls
{
    partial class MasterUserControl
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
            this.dgClassData = new System.Windows.Forms.DataGridView();
            this.btnClassUpdate = new System.Windows.Forms.Button();
            this.btnClassAdd = new System.Windows.Forms.Button();
            this.lblSN = new System.Windows.Forms.Label();
            this.lblClassName = new System.Windows.Forms.Label();
            this.txClassNO = new System.Windows.Forms.TextBox();
            this.txClassName = new System.Windows.Forms.TextBox();
            this.lstClassName = new System.Windows.Forms.ListBox();
            this.lblClassType = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgClassData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgClassData
            // 
            this.dgClassData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClassData.Location = new System.Drawing.Point(390, 102);
            this.dgClassData.MultiSelect = false;
            this.dgClassData.Name = "dgClassData";
            this.dgClassData.RowTemplate.Height = 24;
            this.dgClassData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgClassData.Size = new System.Drawing.Size(576, 576);
            this.dgClassData.TabIndex = 12;
            this.dgClassData.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClassData_RowEnter);
            this.dgClassData.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgClassData_MouseClick);
            // 
            // btnClassUpdate
            // 
            this.btnClassUpdate.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClassUpdate.Location = new System.Drawing.Point(390, 56);
            this.btnClassUpdate.Name = "btnClassUpdate";
            this.btnClassUpdate.Size = new System.Drawing.Size(144, 40);
            this.btnClassUpdate.TabIndex = 10;
            this.btnClassUpdate.Text = "更新";
            this.btnClassUpdate.UseVisualStyleBackColor = true;
            this.btnClassUpdate.Click += new System.EventHandler(this.btnClassUpdate_Click);
            // 
            // btnClassAdd
            // 
            this.btnClassAdd.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClassAdd.Location = new System.Drawing.Point(390, 11);
            this.btnClassAdd.Name = "btnClassAdd";
            this.btnClassAdd.Size = new System.Drawing.Size(144, 38);
            this.btnClassAdd.TabIndex = 11;
            this.btnClassAdd.Text = "產生序號";
            this.btnClassAdd.UseVisualStyleBackColor = true;
            this.btnClassAdd.Click += new System.EventHandler(this.btnClassAdd_Click);
            // 
            // lblSN
            // 
            this.lblSN.AutoSize = true;
            this.lblSN.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSN.Location = new System.Drawing.Point(583, 11);
            this.lblSN.Name = "lblSN";
            this.lblSN.Size = new System.Drawing.Size(35, 19);
            this.lblSN.TabIndex = 7;
            this.lblSN.Text = "NO";
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblClassName.Location = new System.Drawing.Point(758, 11);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(47, 19);
            this.lblClassName.TabIndex = 9;
            this.lblClassName.Text = "名稱";
            // 
            // txClassNO
            // 
            this.txClassNO.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txClassNO.Location = new System.Drawing.Point(631, 11);
            this.txClassNO.Name = "txClassNO";
            this.txClassNO.Size = new System.Drawing.Size(121, 30);
            this.txClassNO.TabIndex = 5;
            this.txClassNO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txClassNO_KeyDown);
            // 
            // txClassName
            // 
            this.txClassName.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txClassName.Location = new System.Drawing.Point(824, 11);
            this.txClassName.Name = "txClassName";
            this.txClassName.Size = new System.Drawing.Size(119, 30);
            this.txClassName.TabIndex = 6;
            this.txClassName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txClassName_KeyDown);
            // 
            // lstClassName
            // 
            this.lstClassName.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstClassName.FormattingEnabled = true;
            this.lstClassName.ItemHeight = 19;
            this.lstClassName.Location = new System.Drawing.Point(16, 48);
            this.lstClassName.Name = "lstClassName";
            this.lstClassName.Size = new System.Drawing.Size(355, 631);
            this.lstClassName.TabIndex = 14;
            this.lstClassName.SelectedIndexChanged += new System.EventHandler(this.lstClassName_SelectedIndexChanged);
            // 
            // lblClassType
            // 
            this.lblClassType.AutoSize = true;
            this.lblClassType.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblClassType.Location = new System.Drawing.Point(15, 14);
            this.lblClassType.Name = "lblClassType";
            this.lblClassType.Size = new System.Drawing.Size(85, 19);
            this.lblClassType.TabIndex = 9;
            this.lblClassType.Text = "類別名稱";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.Location = new System.Drawing.Point(553, 56);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(144, 40);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "刪除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Location = new System.Drawing.Point(720, 56);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(144, 40);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // MasterUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.lstClassName);
            this.Controls.Add(this.dgClassData);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClassUpdate);
            this.Controls.Add(this.btnClassAdd);
            this.Controls.Add(this.lblSN);
            this.Controls.Add(this.lblClassType);
            this.Controls.Add(this.lblClassName);
            this.Controls.Add(this.txClassNO);
            this.Controls.Add(this.txClassName);
            this.Name = "MasterUserControl";
            this.Size = new System.Drawing.Size(1068, 737);
            this.Load += new System.EventHandler(this.MasterUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgClassData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgClassData;
        private System.Windows.Forms.Button btnClassUpdate;
        private System.Windows.Forms.Button btnClassAdd;
        private System.Windows.Forms.Label lblSN;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.TextBox txClassNO;
        private System.Windows.Forms.TextBox txClassName;
        private System.Windows.Forms.ListBox lstClassName;
        private System.Windows.Forms.Label lblClassType;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
    }
}
