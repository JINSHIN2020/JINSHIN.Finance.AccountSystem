namespace CardClick.User
{
    partial class UserMgtFrm02
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
            this.datePickEnd = new System.Windows.Forms.DateTimePicker();
            this.datePickStart = new System.Windows.Forms.DateTimePicker();
            this.lblEnd = new System.Windows.Forms.Label();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.lblStart = new System.Windows.Forms.Label();
            this.txtIdName = new System.Windows.Forms.TextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.dataToolBar1 = new CardClick.UsrControl.DataBar02();
            this.lblNoData = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // datePickEnd
            // 
            this.datePickEnd.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.datePickEnd.Location = new System.Drawing.Point(691, 95);
            this.datePickEnd.Name = "datePickEnd";
            this.datePickEnd.Size = new System.Drawing.Size(200, 30);
            this.datePickEnd.TabIndex = 17;
            // 
            // datePickStart
            // 
            this.datePickStart.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.datePickStart.Location = new System.Drawing.Point(395, 95);
            this.datePickStart.Name = "datePickStart";
            this.datePickStart.Size = new System.Drawing.Size(200, 30);
            this.datePickStart.TabIndex = 18;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblEnd.Location = new System.Drawing.Point(600, 106);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(85, 19);
            this.lblEnd.TabIndex = 12;
            this.lblEnd.Text = "結束日期";
            // 
            // datagrid
            // 
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(18, 148);
            this.datagrid.MultiSelect = false;
            this.datagrid.Name = "datagrid";
            this.datagrid.RowTemplate.Height = 24;
            this.datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid.Size = new System.Drawing.Size(1207, 491);
            this.datagrid.TabIndex = 16;
            this.datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_CellContentClick);
            this.datagrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_RowEnter);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStart.Location = new System.Drawing.Point(307, 106);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(85, 19);
            this.lblStart.TabIndex = 13;
            this.lblStart.Text = "開始日期";
            // 
            // txtIdName
            // 
            this.txtIdName.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtIdName.Location = new System.Drawing.Point(72, 95);
            this.txtIdName.Name = "txtIdName";
            this.txtIdName.Size = new System.Drawing.Size(208, 30);
            this.txtIdName.TabIndex = 15;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblFileName.Location = new System.Drawing.Point(19, 106);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(47, 19);
            this.lblFileName.TabIndex = 14;
            this.lblFileName.Text = "名稱";
            // 
            // dataToolBar1
            // 
            this.dataToolBar1.data = null;
            this.dataToolBar1.DeleteFunction = null;
            this.dataToolBar1.dgv = null;
            this.dataToolBar1.Location = new System.Drawing.Point(20, 10);
            this.dataToolBar1.Name = "dataToolBar1";
            this.dataToolBar1.NewFunction = null;
            this.dataToolBar1.QueryFunction = null;
            this.dataToolBar1.Size = new System.Drawing.Size(985, 70);
            this.dataToolBar1.TabIndex = 19;
            this.dataToolBar1.UpdateFunction = null;
            this.dataToolBar1.Load += new System.EventHandler(this.dataToolBar1_Load);
            // 
            // lblNoData
            // 
            this.lblNoData.AutoSize = true;
            this.lblNoData.BackColor = System.Drawing.Color.Transparent;
            this.lblNoData.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblNoData.ForeColor = System.Drawing.Color.Red;
            this.lblNoData.Location = new System.Drawing.Point(592, 599);
            this.lblNoData.Name = "lblNoData";
            this.lblNoData.Size = new System.Drawing.Size(93, 27);
            this.lblNoData.TabIndex = 20;
            this.lblNoData.Text = "無資料";
            // 
            // UserMgtFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 655);
            this.Controls.Add(this.lblNoData);
            this.Controls.Add(this.dataToolBar1);
            this.Controls.Add(this.datePickEnd);
            this.Controls.Add(this.datePickStart);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.txtIdName);
            this.Controls.Add(this.lblFileName);
            this.Name = "UserMgtFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理人員資料";
            this.Load += new System.EventHandler(this.UserMgtFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePickEnd;
        private System.Windows.Forms.DateTimePicker datePickStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.TextBox txtIdName;
        private System.Windows.Forms.Label lblFileName;
        private UsrControl.DataBar02 dataToolBar1;
        private System.Windows.Forms.Label lblNoData;
    }
}