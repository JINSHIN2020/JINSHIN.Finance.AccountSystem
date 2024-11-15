namespace FinanceAccountProgram.FrmControl
{
    partial class FrmOftenNames
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
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblNo = new System.Windows.Forms.Label();
            this.lblProTitle = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.txtProName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid
            // 
            this.datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(22, 94);
            this.datagrid.Name = "datagrid";
            this.datagrid.RowTemplate.Height = 24;
            this.datagrid.Size = new System.Drawing.Size(592, 576);
            this.datagrid.TabIndex = 26;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdate.Location = new System.Drawing.Point(22, 50);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(173, 38);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Location = new System.Drawing.Point(22, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(173, 38);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblNo.Location = new System.Drawing.Point(215, 20);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(35, 19);
            this.lblNo.TabIndex = 22;
            this.lblNo.Text = "NO";
            // 
            // lblProTitle
            // 
            this.lblProTitle.AutoSize = true;
            this.lblProTitle.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblProTitle.Location = new System.Drawing.Point(384, 20);
            this.lblProTitle.Name = "lblProTitle";
            this.lblProTitle.Size = new System.Drawing.Size(85, 19);
            this.lblProTitle.TabIndex = 23;
            this.lblProTitle.Text = "會計名詞";
            // 
            // txtNo
            // 
            this.txtNo.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNo.Location = new System.Drawing.Point(257, 15);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(121, 27);
            this.txtNo.TabIndex = 20;
            // 
            // txtProName
            // 
            this.txtProName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtProName.Location = new System.Drawing.Point(479, 15);
            this.txtProName.Name = "txtProName";
            this.txtProName.Size = new System.Drawing.Size(119, 27);
            this.txtProName.TabIndex = 21;
            // 
            // FrmOftenNames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 699);
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.lblProTitle);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.txtProName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmOftenNames";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "常用專有名詞";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label lblProTitle;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.TextBox txtProName;
    }
}