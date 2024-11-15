namespace FinanceAccountProgram.FrmControl
{
    partial class FrmSysSetting
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
            this.tabSysParameterSetup = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstYMD = new System.Windows.Forms.ListBox();
            this.lblYMD = new System.Windows.Forms.Label();
            this.lblNoNum = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnSetup = new System.Windows.Forms.Button();
            this.txtNoText = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnYearSetup = new System.Windows.Forms.Button();
            this.txtSYear = new System.Windows.Forms.TextBox();
            this.lblSYear = new System.Windows.Forms.Label();
            this.tabAccountClassMgt = new System.Windows.Forms.TabPage();
            this.masterCtl01 = new FinanceAccountProgram.Controls.MasterUserControl();
            this.tabInvClassMgt = new System.Windows.Forms.TabPage();
            this.coClassType = new System.Windows.Forms.ComboBox();
            this.dgClassData = new System.Windows.Forms.DataGridView();
            this.btnAddInv = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClassUpdate = new System.Windows.Forms.Button();
            this.btnClassAdd = new System.Windows.Forms.Button();
            this.lblSN = new System.Windows.Forms.Label();
            this.lblClassTitle01 = new System.Windows.Forms.Label();
            this.lblClassName = new System.Windows.Forms.Label();
            this.txClassNO = new System.Windows.Forms.TextBox();
            this.txClassName = new System.Windows.Forms.TextBox();
            this.tabSysParameterSetup.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabAccountClassMgt.SuspendLayout();
            this.tabInvClassMgt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClassData)).BeginInit();
            this.SuspendLayout();
            // 
            // tabSysParameterSetup
            // 
            this.tabSysParameterSetup.Controls.Add(this.tabPage1);
            this.tabSysParameterSetup.Controls.Add(this.tabPage2);
            this.tabSysParameterSetup.Controls.Add(this.tabAccountClassMgt);
            this.tabSysParameterSetup.Controls.Add(this.tabInvClassMgt);
            this.tabSysParameterSetup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSysParameterSetup.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabSysParameterSetup.Location = new System.Drawing.Point(0, 0);
            this.tabSysParameterSetup.Name = "tabSysParameterSetup";
            this.tabSysParameterSetup.SelectedIndex = 0;
            this.tabSysParameterSetup.Size = new System.Drawing.Size(1045, 749);
            this.tabSysParameterSetup.TabIndex = 2;
            this.tabSysParameterSetup.SelectedIndexChanged += new System.EventHandler(this.tabSysParameterSetup_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.datagrid);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1037, 716);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "系統編號設定";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // datagrid
            // 
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(3, 211);
            this.datagrid.Name = "datagrid";
            this.datagrid.RowTemplate.Height = 24;
            this.datagrid.Size = new System.Drawing.Size(811, 361);
            this.datagrid.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstYMD);
            this.groupBox1.Controls.Add(this.lblYMD);
            this.groupBox1.Controls.Add(this.lblNoNum);
            this.groupBox1.Controls.Add(this.txtNum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnQuery);
            this.groupBox1.Controls.Add(this.btnSetup);
            this.groupBox1.Controls.Add(this.txtNoText);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 199);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "編號設計";
            // 
            // lstYMD
            // 
            this.lstYMD.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstYMD.FormattingEnabled = true;
            this.lstYMD.ItemHeight = 19;
            this.lstYMD.Items.AddRange(new object[] {
            "yyyyMMdd",
            "yyyyMM",
            "yyyy"});
            this.lstYMD.Location = new System.Drawing.Point(155, 64);
            this.lstYMD.Name = "lstYMD";
            this.lstYMD.Size = new System.Drawing.Size(240, 80);
            this.lstYMD.TabIndex = 7;
            // 
            // lblYMD
            // 
            this.lblYMD.AutoSize = true;
            this.lblYMD.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblYMD.Location = new System.Drawing.Point(15, 78);
            this.lblYMD.Name = "lblYMD";
            this.lblYMD.Size = new System.Drawing.Size(104, 19);
            this.lblYMD.TabIndex = 6;
            this.lblYMD.Text = "年月日編碼";
            // 
            // lblNoNum
            // 
            this.lblNoNum.AutoSize = true;
            this.lblNoNum.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblNoNum.Location = new System.Drawing.Point(15, 160);
            this.lblNoNum.Name = "lblNoNum";
            this.lblNoNum.Size = new System.Drawing.Size(85, 19);
            this.lblNoNum.TabIndex = 4;
            this.lblNoNum.Text = "編碼位數";
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNum.Location = new System.Drawing.Point(155, 155);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(240, 30);
            this.txtNum.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "編碼前綴字";
            // 
            // btnQuery
            // 
            this.btnQuery.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnQuery.Location = new System.Drawing.Point(413, 154);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(94, 32);
            this.btnQuery.TabIndex = 1;
            this.btnQuery.Text = "查詢";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnSetup
            // 
            this.btnSetup.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSetup.Location = new System.Drawing.Point(413, 116);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(94, 32);
            this.btnSetup.TabIndex = 1;
            this.btnSetup.Text = "設定";
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // txtNoText
            // 
            this.txtNoText.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNoText.Location = new System.Drawing.Point(155, 28);
            this.txtNoText.Name = "txtNoText";
            this.txtNoText.Size = new System.Drawing.Size(240, 30);
            this.txtNoText.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnYearSetup);
            this.tabPage2.Controls.Add(this.txtSYear);
            this.tabPage2.Controls.Add(this.lblSYear);
            this.tabPage2.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1037, 716);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "管理年度設定";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnYearSetup
            // 
            this.btnYearSetup.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnYearSetup.Location = new System.Drawing.Point(209, 17);
            this.btnYearSetup.Name = "btnYearSetup";
            this.btnYearSetup.Size = new System.Drawing.Size(124, 52);
            this.btnYearSetup.TabIndex = 11;
            this.btnYearSetup.Text = "設定";
            this.btnYearSetup.UseVisualStyleBackColor = true;
            this.btnYearSetup.Click += new System.EventHandler(this.btnYearSetup_Click);
            // 
            // txtSYear
            // 
            this.txtSYear.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSYear.Location = new System.Drawing.Point(75, 18);
            this.txtSYear.Name = "txtSYear";
            this.txtSYear.Size = new System.Drawing.Size(114, 30);
            this.txtSYear.TabIndex = 10;
            // 
            // lblSYear
            // 
            this.lblSYear.AutoSize = true;
            this.lblSYear.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSYear.Location = new System.Drawing.Point(8, 19);
            this.lblSYear.Name = "lblSYear";
            this.lblSYear.Size = new System.Drawing.Size(47, 19);
            this.lblSYear.TabIndex = 9;
            this.lblSYear.Text = "年度";
            // 
            // tabAccountClassMgt
            // 
            this.tabAccountClassMgt.Controls.Add(this.masterCtl01);
            this.tabAccountClassMgt.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabAccountClassMgt.Location = new System.Drawing.Point(4, 29);
            this.tabAccountClassMgt.Name = "tabAccountClassMgt";
            this.tabAccountClassMgt.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccountClassMgt.Size = new System.Drawing.Size(1037, 716);
            this.tabAccountClassMgt.TabIndex = 2;
            this.tabAccountClassMgt.Text = "帳目類別管理";
            this.tabAccountClassMgt.UseVisualStyleBackColor = true;
            // 
            // masterCtl01
            // 
            this.masterCtl01.AutoSize = true;
            this.masterCtl01.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.masterCtl01.dbclassctl = null;
            this.masterCtl01.Location = new System.Drawing.Point(3, 3);
            this.masterCtl01.Name = "masterCtl01";
            this.masterCtl01.Size = new System.Drawing.Size(969, 682);
            this.masterCtl01.tab06 = null;
            this.masterCtl01.TabIndex = 2;
            // 
            // tabInvClassMgt
            // 
            this.tabInvClassMgt.Controls.Add(this.coClassType);
            this.tabInvClassMgt.Controls.Add(this.dgClassData);
            this.tabInvClassMgt.Controls.Add(this.btnAddInv);
            this.tabInvClassMgt.Controls.Add(this.btnDelete);
            this.tabInvClassMgt.Controls.Add(this.btnClassUpdate);
            this.tabInvClassMgt.Controls.Add(this.btnClassAdd);
            this.tabInvClassMgt.Controls.Add(this.lblSN);
            this.tabInvClassMgt.Controls.Add(this.lblClassTitle01);
            this.tabInvClassMgt.Controls.Add(this.lblClassName);
            this.tabInvClassMgt.Controls.Add(this.txClassNO);
            this.tabInvClassMgt.Controls.Add(this.txClassName);
            this.tabInvClassMgt.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabInvClassMgt.Location = new System.Drawing.Point(4, 29);
            this.tabInvClassMgt.Name = "tabInvClassMgt";
            this.tabInvClassMgt.Padding = new System.Windows.Forms.Padding(3);
            this.tabInvClassMgt.Size = new System.Drawing.Size(1037, 716);
            this.tabInvClassMgt.TabIndex = 3;
            this.tabInvClassMgt.Text = "憑證類別管理";
            this.tabInvClassMgt.UseVisualStyleBackColor = true;
            // 
            // coClassType
            // 
            this.coClassType.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.coClassType.FormattingEnabled = true;
            this.coClassType.Items.AddRange(new object[] {
            "會科類別",
            "憑證類別"});
            this.coClassType.Location = new System.Drawing.Point(245, 58);
            this.coClassType.Name = "coClassType";
            this.coClassType.Size = new System.Drawing.Size(121, 27);
            this.coClassType.TabIndex = 13;
            this.coClassType.SelectedValueChanged += new System.EventHandler(this.coClassType_SelectedValueChanged);
            // 
            // dgClassData
            // 
            this.dgClassData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgClassData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClassData.Location = new System.Drawing.Point(8, 94);
            this.dgClassData.MultiSelect = false;
            this.dgClassData.Name = "dgClassData";
            this.dgClassData.RowTemplate.Height = 24;
            this.dgClassData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgClassData.Size = new System.Drawing.Size(688, 576);
            this.dgClassData.TabIndex = 12;
            // 
            // btnAddInv
            // 
            this.btnAddInv.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddInv.Location = new System.Drawing.Point(552, 50);
            this.btnAddInv.Name = "btnAddInv";
            this.btnAddInv.Size = new System.Drawing.Size(144, 38);
            this.btnAddInv.TabIndex = 10;
            this.btnAddInv.Text = "新增";
            this.btnAddInv.UseVisualStyleBackColor = true;
            this.btnAddInv.Click += new System.EventHandler(this.btnAddInv_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.Location = new System.Drawing.Point(402, 50);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(144, 38);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "刪除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClassUpdate
            // 
            this.btnClassUpdate.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClassUpdate.Location = new System.Drawing.Point(8, 50);
            this.btnClassUpdate.Name = "btnClassUpdate";
            this.btnClassUpdate.Size = new System.Drawing.Size(144, 38);
            this.btnClassUpdate.TabIndex = 10;
            this.btnClassUpdate.Text = "更新";
            this.btnClassUpdate.UseVisualStyleBackColor = true;
            this.btnClassUpdate.Click += new System.EventHandler(this.btnClassUpdate_Click);
            // 
            // btnClassAdd
            // 
            this.btnClassAdd.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClassAdd.Location = new System.Drawing.Point(8, 6);
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
            this.lblSN.Location = new System.Drawing.Point(188, 20);
            this.lblSN.Name = "lblSN";
            this.lblSN.Size = new System.Drawing.Size(35, 19);
            this.lblSN.TabIndex = 7;
            this.lblSN.Text = "NO";
            // 
            // lblClassTitle01
            // 
            this.lblClassTitle01.AutoSize = true;
            this.lblClassTitle01.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblClassTitle01.Location = new System.Drawing.Point(175, 62);
            this.lblClassTitle01.Name = "lblClassTitle01";
            this.lblClassTitle01.Size = new System.Drawing.Size(47, 19);
            this.lblClassTitle01.TabIndex = 8;
            this.lblClassTitle01.Text = "型別";
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblClassName.Location = new System.Drawing.Point(398, 20);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(85, 19);
            this.lblClassName.TabIndex = 9;
            this.lblClassName.Text = "類別名稱";
            // 
            // txClassNO
            // 
            this.txClassNO.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txClassNO.Location = new System.Drawing.Point(245, 15);
            this.txClassNO.Name = "txClassNO";
            this.txClassNO.Size = new System.Drawing.Size(121, 30);
            this.txClassNO.TabIndex = 5;
            // 
            // txClassName
            // 
            this.txClassName.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txClassName.Location = new System.Drawing.Point(514, 15);
            this.txClassName.Name = "txClassName";
            this.txClassName.Size = new System.Drawing.Size(119, 30);
            this.txClassName.TabIndex = 6;
            this.txClassName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txClassName_KeyUp);
            // 
            // FrmSysSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1045, 749);
            this.Controls.Add(this.tabSysParameterSetup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSysSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系統參數設計";
            this.Shown += new System.EventHandler(this.FrmSysSetting_Shown);
            this.tabSysParameterSetup.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabAccountClassMgt.ResumeLayout(false);
            this.tabAccountClassMgt.PerformLayout();
            this.tabInvClassMgt.ResumeLayout(false);
            this.tabInvClassMgt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClassData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabSysParameterSetup;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstYMD;
        private System.Windows.Forms.Label lblYMD;
        private System.Windows.Forms.Label lblNoNum;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.TextBox txtNoText;
        private System.Windows.Forms.Button btnYearSetup;
        private System.Windows.Forms.TextBox txtSYear;
        private System.Windows.Forms.Label lblSYear;
        private System.Windows.Forms.TabPage tabAccountClassMgt;
        private System.Windows.Forms.TabPage tabInvClassMgt;
        private System.Windows.Forms.ComboBox coClassType;
        private System.Windows.Forms.DataGridView dgClassData;
        private System.Windows.Forms.Button btnClassUpdate;
        private System.Windows.Forms.Button btnClassAdd;
        private System.Windows.Forms.Label lblSN;
        private System.Windows.Forms.Label lblClassTitle01;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.TextBox txClassNO;
        private System.Windows.Forms.TextBox txClassName;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnDelete;
        private Controls.MasterUserControl masterCtl01;
        private System.Windows.Forms.Button btnAddInv;
    }
}