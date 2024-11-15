namespace FinanceAccountProgram.FrmControl.Business.Dialog
{
    partial class ResturantDlg
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
            this.btnQuery = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblClassTitle = new System.Windows.Forms.Label();
            this.txtDataCnt = new System.Windows.Forms.TextBox();
            this.lblDataAllCnt = new System.Windows.Forms.Label();
            this.lblSetupDataCnt = new System.Windows.Forms.Label();
            this.lblAllCnt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuery
            // 
            this.btnQuery.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnQuery.Location = new System.Drawing.Point(634, 6);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(107, 42);
            this.btnQuery.TabIndex = 0;
            this.btnQuery.Text = "查詢";
            this.btnQuery.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(89, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 27);
            this.comboBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(274, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(329, 30);
            this.textBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(652, 381);
            this.dataGridView1.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTitle.Location = new System.Drawing.Point(221, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(47, 19);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "名稱";
            // 
            // lblClassTitle
            // 
            this.lblClassTitle.AutoSize = true;
            this.lblClassTitle.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblClassTitle.Location = new System.Drawing.Point(32, 9);
            this.lblClassTitle.Name = "lblClassTitle";
            this.lblClassTitle.Size = new System.Drawing.Size(47, 19);
            this.lblClassTitle.TabIndex = 4;
            this.lblClassTitle.Text = "分類";
            // 
            // txtDataCnt
            // 
            this.txtDataCnt.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDataCnt.Location = new System.Drawing.Point(813, 66);
            this.txtDataCnt.Name = "txtDataCnt";
            this.txtDataCnt.Size = new System.Drawing.Size(70, 30);
            this.txtDataCnt.TabIndex = 42;
            this.txtDataCnt.Text = "150";
            // 
            // lblDataAllCnt
            // 
            this.lblDataAllCnt.AutoSize = true;
            this.lblDataAllCnt.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDataAllCnt.Location = new System.Drawing.Point(809, 104);
            this.lblDataAllCnt.Name = "lblDataAllCnt";
            this.lblDataAllCnt.Size = new System.Drawing.Size(18, 19);
            this.lblDataAllCnt.TabIndex = 39;
            this.lblDataAllCnt.Text = "0";
            // 
            // lblSetupDataCnt
            // 
            this.lblSetupDataCnt.AutoSize = true;
            this.lblSetupDataCnt.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSetupDataCnt.Location = new System.Drawing.Point(694, 66);
            this.lblSetupDataCnt.Name = "lblSetupDataCnt";
            this.lblSetupDataCnt.Size = new System.Drawing.Size(85, 19);
            this.lblSetupDataCnt.TabIndex = 40;
            this.lblSetupDataCnt.Text = "資料筆數";
            // 
            // lblAllCnt
            // 
            this.lblAllCnt.AutoSize = true;
            this.lblAllCnt.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAllCnt.Location = new System.Drawing.Point(694, 104);
            this.lblAllCnt.Name = "lblAllCnt";
            this.lblAllCnt.Size = new System.Drawing.Size(104, 19);
            this.lblAllCnt.TabIndex = 41;
            this.lblAllCnt.Text = "資料總筆數";
            // 
            // ResturantDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 450);
            this.Controls.Add(this.txtDataCnt);
            this.Controls.Add(this.lblDataAllCnt);
            this.Controls.Add(this.lblSetupDataCnt);
            this.Controls.Add(this.lblAllCnt);
            this.Controls.Add(this.lblClassTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnQuery);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ResturantDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "商品查詢";
            this.Shown += new System.EventHandler(this.ResturantDlg_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblClassTitle;
        private System.Windows.Forms.TextBox txtDataCnt;
        private System.Windows.Forms.Label lblDataAllCnt;
        private System.Windows.Forms.Label lblSetupDataCnt;
        private System.Windows.Forms.Label lblAllCnt;
    }
}