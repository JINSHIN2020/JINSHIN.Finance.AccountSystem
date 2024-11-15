namespace CardClick.FormControl
{
    partial class FrmPowerSetting
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
            this.plPerson = new System.Windows.Forms.Panel();
            this.lblNameVal = new System.Windows.Forms.Label();
            this.lblNameTitle = new System.Windows.Forms.Label();
            this.lblNoVal = new System.Windows.Forms.Label();
            this.lblnotitle = new System.Windows.Forms.Label();
            this.plQuery = new System.Windows.Forms.Panel();
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPower = new System.Windows.Forms.Label();
            this.lstPower = new System.Windows.Forms.ListBox();
            this.btnSetup = new System.Windows.Forms.Button();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.plPerson.SuspendLayout();
            this.plQuery.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // plPerson
            // 
            this.plPerson.Controls.Add(this.lblNameVal);
            this.plPerson.Controls.Add(this.lblNameTitle);
            this.plPerson.Controls.Add(this.lblNoVal);
            this.plPerson.Controls.Add(this.lblnotitle);
            this.plPerson.Location = new System.Drawing.Point(21, 12);
            this.plPerson.Name = "plPerson";
            this.plPerson.Size = new System.Drawing.Size(1027, 48);
            this.plPerson.TabIndex = 18;
            // 
            // lblNameVal
            // 
            this.lblNameVal.AutoSize = true;
            this.lblNameVal.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblNameVal.Location = new System.Drawing.Point(330, 13);
            this.lblNameVal.Name = "lblNameVal";
            this.lblNameVal.Size = new System.Drawing.Size(69, 19);
            this.lblNameVal.TabIndex = 18;
            this.lblNameVal.Text = "xxxxxx";
            // 
            // lblNameTitle
            // 
            this.lblNameTitle.AutoSize = true;
            this.lblNameTitle.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblNameTitle.Location = new System.Drawing.Point(270, 13);
            this.lblNameTitle.Name = "lblNameTitle";
            this.lblNameTitle.Size = new System.Drawing.Size(49, 19);
            this.lblNameTitle.TabIndex = 18;
            this.lblNameTitle.Text = "名稱";
            // 
            // lblNoVal
            // 
            this.lblNoVal.AutoSize = true;
            this.lblNoVal.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblNoVal.Location = new System.Drawing.Point(62, 13);
            this.lblNoVal.Name = "lblNoVal";
            this.lblNoVal.Size = new System.Drawing.Size(49, 19);
            this.lblNoVal.TabIndex = 18;
            this.lblNoVal.Text = "xxxx";
            // 
            // lblnotitle
            // 
            this.lblnotitle.AutoSize = true;
            this.lblnotitle.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblnotitle.Location = new System.Drawing.Point(10, 13);
            this.lblnotitle.Name = "lblnotitle";
            this.lblnotitle.Size = new System.Drawing.Size(49, 19);
            this.lblnotitle.TabIndex = 18;
            this.lblnotitle.Text = "編號";
            // 
            // plQuery
            // 
            this.plQuery.Controls.Add(this.btnQuery);
            this.plQuery.Controls.Add(this.txtName);
            this.plQuery.Controls.Add(this.lblName);
            this.plQuery.Location = new System.Drawing.Point(21, 220);
            this.plQuery.Name = "plQuery";
            this.plQuery.Size = new System.Drawing.Size(1027, 58);
            this.plQuery.TabIndex = 19;
            // 
            // btnQuery
            // 
            this.btnQuery.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnQuery.Location = new System.Drawing.Point(488, 8);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(106, 41);
            this.btnQuery.TabIndex = 20;
            this.btnQuery.Text = "查詢";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(67, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(415, 30);
            this.txtName.TabIndex = 19;
            this.txtName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyUp);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblName.Location = new System.Drawing.Point(10, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 19);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "名稱";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPower);
            this.panel1.Controls.Add(this.lstPower);
            this.panel1.Controls.Add(this.btnSetup);
            this.panel1.Location = new System.Drawing.Point(21, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 140);
            this.panel1.TabIndex = 20;
            // 
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPower.Location = new System.Drawing.Point(270, 8);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(49, 19);
            this.lblPower.TabIndex = 23;
            this.lblPower.Text = "權限";
            // 
            // lstPower
            // 
            this.lstPower.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstPower.FormattingEnabled = true;
            this.lstPower.ItemHeight = 19;
            this.lstPower.Location = new System.Drawing.Point(331, 7);
            this.lstPower.Name = "lstPower";
            this.lstPower.Size = new System.Drawing.Size(139, 118);
            this.lstPower.TabIndex = 22;
            this.lstPower.SelectedIndexChanged += new System.EventHandler(this.lstPower_SelectedIndexChanged);
            // 
            // btnSetup
            // 
            this.btnSetup.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSetup.Location = new System.Drawing.Point(489, 3);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(106, 41);
            this.btnSetup.TabIndex = 21;
            this.btnSetup.Text = "設定";
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // datagrid
            // 
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(21, 296);
            this.datagrid.MultiSelect = false;
            this.datagrid.Name = "datagrid";
            this.datagrid.RowTemplate.Height = 24;
            this.datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid.Size = new System.Drawing.Size(1027, 412);
            this.datagrid.TabIndex = 21;
            this.datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_CellContentClick);
            this.datagrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.datagrid_CellFormatting);
            this.datagrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datagrid_CellMouseClick);
            this.datagrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_RowEnter);
            this.datagrid.SelectionChanged += new System.EventHandler(this.datagrid_SelectionChanged);
            this.datagrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.datagrid_MouseClick);
            this.datagrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.datagrid_MouseDown);
            // 
            // FrmPowerSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 778);
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.plQuery);
            this.Controls.Add(this.plPerson);
            this.Name = "FrmPowerSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "人員設定";
            this.Load += new System.EventHandler(this.FrmPowerSetting_Load);
            this.plPerson.ResumeLayout(false);
            this.plPerson.PerformLayout();
            this.plQuery.ResumeLayout(false);
            this.plQuery.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plPerson;
        private System.Windows.Forms.Label lblNameVal;
        private System.Windows.Forms.Label lblNameTitle;
        private System.Windows.Forms.Label lblNoVal;
        private System.Windows.Forms.Label lblnotitle;
        private System.Windows.Forms.Panel plQuery;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstPower;
        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.Label lblPower;
        private System.Windows.Forms.DataGridView datagrid;
    }
}