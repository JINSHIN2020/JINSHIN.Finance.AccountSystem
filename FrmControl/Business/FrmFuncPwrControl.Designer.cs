namespace JINSHIN.Finance.AccountSystem.FrmControl.Business
{
    partial class FrmFuncPwrControl
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPowerVal = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnDelItem = new System.Windows.Forms.Button();
            this.dgdata02 = new System.Windows.Forms.DataGridView();
            this.lstClassType = new System.Windows.Forms.ListBox();
            this.lstPower = new System.Windows.Forms.ListBox();
            this.btnQuer02 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnQuer03 = new System.Windows.Forms.Button();
            this.txtPwr = new System.Windows.Forms.TextBox();
            this.lstNames = new System.Windows.Forms.ListBox();
            this.lbltitle01 = new System.Windows.Forms.Label();
            this.txtFunctionName = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQuer01 = new System.Windows.Forms.Button();
            this.lblprivelede = new System.Windows.Forms.Label();
            this.txtPowerName = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dgdata01 = new System.Windows.Forms.DataGridView();
            this.pltop = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdata02)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdata01)).BeginInit();
            this.pltop.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(10, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 47;
            this.label4.Text = "權限";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "權力";
            // 
            // txtPowerVal
            // 
            this.txtPowerVal.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPowerVal.Location = new System.Drawing.Point(65, 4);
            this.txtPowerVal.Name = "txtPowerVal";
            this.txtPowerVal.Size = new System.Drawing.Size(52, 27);
            this.txtPowerVal.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtPowerVal);
            this.panel3.Location = new System.Drawing.Point(711, 101);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(126, 34);
            this.panel3.TabIndex = 45;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddItem.Location = new System.Drawing.Point(980, 42);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(140, 42);
            this.btnAddItem.TabIndex = 44;
            this.btnAddItem.Text = "新增";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnDelItem
            // 
            this.btnDelItem.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelItem.Location = new System.Drawing.Point(847, 42);
            this.btnDelItem.Name = "btnDelItem";
            this.btnDelItem.Size = new System.Drawing.Size(127, 42);
            this.btnDelItem.TabIndex = 43;
            this.btnDelItem.Text = "刪除";
            this.btnDelItem.UseVisualStyleBackColor = true;
            this.btnDelItem.Click += new System.EventHandler(this.btnDelItem_Click);
            // 
            // dgdata02
            // 
            this.dgdata02.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdata02.Location = new System.Drawing.Point(847, 87);
            this.dgdata02.Name = "dgdata02";
            this.dgdata02.RowHeadersVisible = false;
            this.dgdata02.RowTemplate.Height = 24;
            this.dgdata02.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdata02.Size = new System.Drawing.Size(532, 488);
            this.dgdata02.TabIndex = 42;
            // 
            // lstClassType
            // 
            this.lstClassType.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstClassType.FormattingEnabled = true;
            this.lstClassType.ItemHeight = 16;
            this.lstClassType.Location = new System.Drawing.Point(191, 104);
            this.lstClassType.Name = "lstClassType";
            this.lstClassType.Size = new System.Drawing.Size(150, 308);
            this.lstClassType.TabIndex = 41;
            this.lstClassType.SelectedIndexChanged += new System.EventHandler(this.lstClassType_SelectedIndexChanged);
            // 
            // lstPower
            // 
            this.lstPower.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstPower.FormattingEnabled = true;
            this.lstPower.ItemHeight = 16;
            this.lstPower.Location = new System.Drawing.Point(711, 139);
            this.lstPower.Name = "lstPower";
            this.lstPower.Size = new System.Drawing.Size(130, 276);
            this.lstPower.TabIndex = 40;
            this.lstPower.SelectedIndexChanged += new System.EventHandler(this.lstPower_SelectedIndexChanged);
            // 
            // btnQuer02
            // 
            this.btnQuer02.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnQuer02.Location = new System.Drawing.Point(14, 44);
            this.btnQuer02.Name = "btnQuer02";
            this.btnQuer02.Size = new System.Drawing.Size(130, 27);
            this.btnQuer02.TabIndex = 2;
            this.btnQuer02.Text = "查詢";
            this.btnQuer02.UseVisualStyleBackColor = true;
            this.btnQuer02.Click += new System.EventHandler(this.btnQuer02_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "類別";
            // 
            // txtClass
            // 
            this.txtClass.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtClass.Location = new System.Drawing.Point(64, 10);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(78, 27);
            this.txtClass.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnQuer02);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtClass);
            this.panel2.Location = new System.Drawing.Point(189, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 77);
            this.panel2.TabIndex = 39;
            // 
            // btnQuer03
            // 
            this.btnQuer03.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnQuer03.Location = new System.Drawing.Point(195, 14);
            this.btnQuer03.Name = "btnQuer03";
            this.btnQuer03.Size = new System.Drawing.Size(123, 30);
            this.btnQuer03.TabIndex = 2;
            this.btnQuer03.Text = "查詢";
            this.btnQuer03.UseVisualStyleBackColor = true;
            this.btnQuer03.Click += new System.EventHandler(this.btnQuer03_Click);
            // 
            // txtPwr
            // 
            this.txtPwr.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPwr.Location = new System.Drawing.Point(83, 53);
            this.txtPwr.Name = "txtPwr";
            this.txtPwr.Size = new System.Drawing.Size(100, 27);
            this.txtPwr.TabIndex = 46;
            // 
            // lstNames
            // 
            this.lstNames.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstNames.FormattingEnabled = true;
            this.lstNames.ItemHeight = 19;
            this.lstNames.Location = new System.Drawing.Point(191, 420);
            this.lstNames.Name = "lstNames";
            this.lstNames.Size = new System.Drawing.Size(650, 156);
            this.lstNames.TabIndex = 37;
            this.lstNames.SelectedIndexChanged += new System.EventHandler(this.lstNames_SelectedIndexChanged);
            // 
            // lbltitle01
            // 
            this.lbltitle01.AutoSize = true;
            this.lbltitle01.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbltitle01.Location = new System.Drawing.Point(11, 22);
            this.lbltitle01.Name = "lbltitle01";
            this.lbltitle01.Size = new System.Drawing.Size(39, 16);
            this.lbltitle01.TabIndex = 1;
            this.lbltitle01.Text = "功能";
            // 
            // txtFunctionName
            // 
            this.txtFunctionName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtFunctionName.Location = new System.Drawing.Point(66, 17);
            this.txtFunctionName.Name = "txtFunctionName";
            this.txtFunctionName.Size = new System.Drawing.Size(109, 27);
            this.txtFunctionName.TabIndex = 0;
            this.txtFunctionName.TextChanged += new System.EventHandler(this.txtFunctionName_TextChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTitle.Location = new System.Drawing.Point(10, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(71, 16);
            this.lblTitle.TabIndex = 36;
            this.lblTitle.Text = "權限說明";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnQuer01);
            this.panel1.Controls.Add(this.lblprivelede);
            this.panel1.Controls.Add(this.txtPowerName);
            this.panel1.Location = new System.Drawing.Point(710, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 77);
            this.panel1.TabIndex = 31;
            // 
            // btnQuer01
            // 
            this.btnQuer01.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnQuer01.Location = new System.Drawing.Point(14, 44);
            this.btnQuer01.Name = "btnQuer01";
            this.btnQuer01.Size = new System.Drawing.Size(105, 27);
            this.btnQuer01.TabIndex = 2;
            this.btnQuer01.Text = "查詢";
            this.btnQuer01.UseVisualStyleBackColor = true;
            this.btnQuer01.Click += new System.EventHandler(this.btnQuer01_Click);
            // 
            // lblprivelede
            // 
            this.lblprivelede.AutoSize = true;
            this.lblprivelede.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblprivelede.Location = new System.Drawing.Point(11, 16);
            this.lblprivelede.Name = "lblprivelede";
            this.lblprivelede.Size = new System.Drawing.Size(39, 16);
            this.lblprivelede.TabIndex = 1;
            this.lblprivelede.Text = "名稱";
            // 
            // txtPowerName
            // 
            this.txtPowerName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPowerName.Location = new System.Drawing.Point(65, 11);
            this.txtPowerName.Name = "txtPowerName";
            this.txtPowerName.Size = new System.Drawing.Size(54, 27);
            this.txtPowerName.TabIndex = 0;
            this.txtPowerName.TextChanged += new System.EventHandler(this.txtPowerName_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnRefresh);
            this.flowLayoutPanel1.Controls.Add(this.btnSave);
            this.flowLayoutPanel1.Controls.Add(this.btnDel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(30, 92);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(129, 174);
            this.flowLayoutPanel1.TabIndex = 38;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRefresh.Location = new System.Drawing.Point(0, 3);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(125, 52);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "頁面更新";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.Location = new System.Drawing.Point(0, 58);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 52);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDel.Location = new System.Drawing.Point(0, 113);
            this.btnDel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(125, 52);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "刪除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(142, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "權限";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(83, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 27);
            this.txtName.TabIndex = 34;
            // 
            // dgdata01
            // 
            this.dgdata01.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdata01.Location = new System.Drawing.Point(349, 88);
            this.dgdata01.Name = "dgdata01";
            this.dgdata01.ReadOnly = true;
            this.dgdata01.RowHeadersVisible = false;
            this.dgdata01.RowTemplate.Height = 24;
            this.dgdata01.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdata01.Size = new System.Drawing.Size(355, 327);
            this.dgdata01.TabIndex = 33;
            this.dgdata01.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgdata01_CellFormatting);
            // 
            // pltop
            // 
            this.pltop.Controls.Add(this.btnQuer03);
            this.pltop.Controls.Add(this.lbltitle01);
            this.pltop.Controls.Add(this.txtFunctionName);
            this.pltop.Location = new System.Drawing.Point(349, 21);
            this.pltop.Name = "pltop";
            this.pltop.Size = new System.Drawing.Size(355, 61);
            this.pltop.TabIndex = 32;
            // 
            // FrmFuncPwrControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 594);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnDelItem);
            this.Controls.Add(this.dgdata02);
            this.Controls.Add(this.lstClassType);
            this.Controls.Add(this.lstPower);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtPwr);
            this.Controls.Add(this.lstNames);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dgdata01);
            this.Controls.Add(this.pltop);
            this.Name = "FrmFuncPwrControl";
            this.Text = "功能選擇";
            this.Shown += new System.EventHandler(this.FrmFuncPwrControl_Shown);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdata02)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgdata01)).EndInit();
            this.pltop.ResumeLayout(false);
            this.pltop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPowerVal;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnDelItem;
        private System.Windows.Forms.DataGridView dgdata02;
        private System.Windows.Forms.ListBox lstClassType;
        private System.Windows.Forms.ListBox lstPower;
        private System.Windows.Forms.Button btnQuer02;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnQuer03;
        private System.Windows.Forms.TextBox txtPwr;
        private System.Windows.Forms.ListBox lstNames;
        private System.Windows.Forms.Label lbltitle01;
        private System.Windows.Forms.TextBox txtFunctionName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQuer01;
        private System.Windows.Forms.Label lblprivelede;
        private System.Windows.Forms.TextBox txtPowerName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dgdata01;
        private System.Windows.Forms.Panel pltop;
    }
}