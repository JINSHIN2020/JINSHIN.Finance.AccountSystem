namespace JINSHIN.Finance.AccountSystem.FrmControl.Invoice
{
    partial class FrmOftenAccData
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
			this.btnMeidaShare = new System.Windows.Forms.Button();
			this.btnOffice = new System.Windows.Forms.Button();
			this.flowLayouts = new System.Windows.Forms.FlowLayoutPanel();
			this.btnRent = new System.Windows.Forms.Button();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.btnScanPic = new System.Windows.Forms.Button();
			this.dtPicker = new System.Windows.Forms.DateTimePicker();
			this.btnProduce = new System.Windows.Forms.Button();
			this.lblTime = new System.Windows.Forms.Label();
			this.gbQueryTime = new System.Windows.Forms.GroupBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.gbTexts = new System.Windows.Forms.GroupBox();
			this.txtInvVal = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnOther = new System.Windows.Forms.Button();
			this.btnCompute = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.lblDesc = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lbltax = new System.Windows.Forms.Label();
			this.lblsell = new System.Windows.Forms.Label();
			this.lblamount = new System.Windows.Forms.Label();
			this.txtBuyId = new System.Windows.Forms.TextBox();
			this.txtDesc = new System.Windows.Forms.TextBox();
			this.txtSellId = new System.Windows.Forms.TextBox();
			this.txtTax = new System.Windows.Forms.TextBox();
			this.txtAmount = new System.Windows.Forms.TextBox();
			this.btnOils = new System.Windows.Forms.Button();
			this.flowLayouts.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.gbQueryTime.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.gbTexts.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnMeidaShare
			// 
			this.btnMeidaShare.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnMeidaShare.Location = new System.Drawing.Point(4, 81);
			this.btnMeidaShare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnMeidaShare.Name = "btnMeidaShare";
			this.btnMeidaShare.Size = new System.Drawing.Size(225, 69);
			this.btnMeidaShare.TabIndex = 98;
			this.btnMeidaShare.Text = "媒體帳務分攤";
			this.btnMeidaShare.UseVisualStyleBackColor = true;
			this.btnMeidaShare.Click += new System.EventHandler(this.btnMeidaShare_Click);
			// 
			// btnOffice
			// 
			this.btnOffice.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnOffice.Location = new System.Drawing.Point(4, 158);
			this.btnOffice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnOffice.Name = "btnOffice";
			this.btnOffice.Size = new System.Drawing.Size(225, 69);
			this.btnOffice.TabIndex = 97;
			this.btnOffice.Text = "Office365";
			this.btnOffice.UseVisualStyleBackColor = true;
			this.btnOffice.Click += new System.EventHandler(this.btnOffice_Click);
			// 
			// flowLayouts
			// 
			this.flowLayouts.Controls.Add(this.btnRent);
			this.flowLayouts.Controls.Add(this.btnMeidaShare);
			this.flowLayouts.Controls.Add(this.btnOffice);
			this.flowLayouts.Location = new System.Drawing.Point(16, 15);
			this.flowLayouts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.flowLayouts.Name = "flowLayouts";
			this.flowLayouts.Size = new System.Drawing.Size(243, 230);
			this.flowLayouts.TabIndex = 99;
			// 
			// btnRent
			// 
			this.btnRent.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnRent.Location = new System.Drawing.Point(4, 4);
			this.btnRent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnRent.Name = "btnRent";
			this.btnRent.Size = new System.Drawing.Size(225, 69);
			this.btnRent.TabIndex = 97;
			this.btnRent.Text = "租金支出";
			this.btnRent.UseVisualStyleBackColor = true;
			this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.btnScanPic);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(795, 19);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(244, 72);
			this.flowLayoutPanel1.TabIndex = 100;
			this.flowLayoutPanel1.Visible = false;
			this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
			// 
			// btnScanPic
			// 
			this.btnScanPic.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnScanPic.Location = new System.Drawing.Point(4, 4);
			this.btnScanPic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnScanPic.Name = "btnScanPic";
			this.btnScanPic.Size = new System.Drawing.Size(225, 69);
			this.btnScanPic.TabIndex = 97;
			this.btnScanPic.Text = "匯入圖片掃描";
			this.btnScanPic.UseVisualStyleBackColor = true;
			this.btnScanPic.Click += new System.EventHandler(this.btnScanPic_Click);
			// 
			// dtPicker
			// 
			this.dtPicker.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.dtPicker.Location = new System.Drawing.Point(91, 30);
			this.dtPicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dtPicker.Name = "dtPicker";
			this.dtPicker.Size = new System.Drawing.Size(265, 39);
			this.dtPicker.TabIndex = 101;
			this.dtPicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// btnProduce
			// 
			this.btnProduce.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnProduce.Location = new System.Drawing.Point(20, 334);
			this.btnProduce.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnProduce.Name = "btnProduce";
			this.btnProduce.Size = new System.Drawing.Size(225, 69);
			this.btnProduce.TabIndex = 97;
			this.btnProduce.Text = "產生常用帳務";
			this.btnProduce.UseVisualStyleBackColor = true;
			this.btnProduce.Visible = false;
			this.btnProduce.Click += new System.EventHandler(this.btnProduce_Click);
			// 
			// lblTime
			// 
			this.lblTime.AutoSize = true;
			this.lblTime.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblTime.Location = new System.Drawing.Point(15, 39);
			this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new System.Drawing.Size(73, 27);
			this.lblTime.TabIndex = 103;
			this.lblTime.Text = "時間 ";
			// 
			// gbQueryTime
			// 
			this.gbQueryTime.Controls.Add(this.dtPicker);
			this.gbQueryTime.Controls.Add(this.lblTime);
			this.gbQueryTime.Location = new System.Drawing.Point(272, 10);
			this.gbQueryTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.gbQueryTime.Name = "gbQueryTime";
			this.gbQueryTime.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.gbQueryTime.Size = new System.Drawing.Size(513, 86);
			this.gbQueryTime.TabIndex = 105;
			this.gbQueryTime.TabStop = false;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(29, 575);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1023, 230);
			this.dataGridView1.TabIndex = 106;
			this.dataGridView1.Visible = false;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// gbTexts
			// 
			this.gbTexts.Controls.Add(this.txtInvVal);
			this.gbTexts.Controls.Add(this.label1);
			this.gbTexts.Controls.Add(this.btnOther);
			this.gbTexts.Controls.Add(this.btnCompute);
			this.gbTexts.Controls.Add(this.btnUpdate);
			this.gbTexts.Controls.Add(this.lblDesc);
			this.gbTexts.Controls.Add(this.label2);
			this.gbTexts.Controls.Add(this.lbltax);
			this.gbTexts.Controls.Add(this.lblsell);
			this.gbTexts.Controls.Add(this.lblamount);
			this.gbTexts.Controls.Add(this.txtBuyId);
			this.gbTexts.Controls.Add(this.txtDesc);
			this.gbTexts.Controls.Add(this.txtSellId);
			this.gbTexts.Controls.Add(this.txtTax);
			this.gbTexts.Controls.Add(this.txtAmount);
			this.gbTexts.Location = new System.Drawing.Point(271, 104);
			this.gbTexts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.gbTexts.Name = "gbTexts";
			this.gbTexts.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.gbTexts.Size = new System.Drawing.Size(768, 295);
			this.gbTexts.TabIndex = 107;
			this.gbTexts.TabStop = false;
			this.gbTexts.Enter += new System.EventHandler(this.gbTexts_Enter);
			// 
			// txtInvVal
			// 
			this.txtInvVal.Location = new System.Drawing.Point(344, 149);
			this.txtInvVal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtInvVal.Multiline = true;
			this.txtInvVal.Name = "txtInvVal";
			this.txtInvVal.Size = new System.Drawing.Size(161, 38);
			this.txtInvVal.TabIndex = 108;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(264, 155);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 27);
			this.label1.TabIndex = 107;
			this.label1.Text = "發票";
			// 
			// btnOther
			// 
			this.btnOther.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnOther.Location = new System.Drawing.Point(535, 211);
			this.btnOther.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnOther.Name = "btnOther";
			this.btnOther.Size = new System.Drawing.Size(225, 68);
			this.btnOther.TabIndex = 106;
			this.btnOther.Text = "其他營業費用";
			this.btnOther.UseVisualStyleBackColor = true;
			this.btnOther.Click += new System.EventHandler(this.btnOther_Click);
			// 
			// btnCompute
			// 
			this.btnCompute.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnCompute.Location = new System.Drawing.Point(535, 64);
			this.btnCompute.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnCompute.Name = "btnCompute";
			this.btnCompute.Size = new System.Drawing.Size(225, 56);
			this.btnCompute.TabIndex = 105;
			this.btnCompute.Text = "確認";
			this.btnCompute.UseVisualStyleBackColor = true;
			this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnUpdate.Location = new System.Drawing.Point(535, 138);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(225, 56);
			this.btnUpdate.TabIndex = 104;
			this.btnUpdate.Text = "產生郵電費";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// lblDesc
			// 
			this.lblDesc.AutoSize = true;
			this.lblDesc.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblDesc.Location = new System.Drawing.Point(12, 155);
			this.lblDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDesc.Name = "lblDesc";
			this.lblDesc.Size = new System.Drawing.Size(66, 27);
			this.lblDesc.TabIndex = 103;
			this.lblDesc.Text = "說明";
			this.lblDesc.Click += new System.EventHandler(this.lblMonth_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(264, 95);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 27);
			this.label2.TabIndex = 103;
			this.label2.Text = "買方";
			this.label2.Click += new System.EventHandler(this.lblMonth_Click);
			// 
			// lbltax
			// 
			this.lbltax.AutoSize = true;
			this.lbltax.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lbltax.Location = new System.Drawing.Point(12, 92);
			this.lbltax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbltax.Name = "lbltax";
			this.lbltax.Size = new System.Drawing.Size(66, 27);
			this.lbltax.TabIndex = 103;
			this.lbltax.Text = "稅入";
			this.lbltax.Click += new System.EventHandler(this.lblMonth_Click);
			// 
			// lblsell
			// 
			this.lblsell.AutoSize = true;
			this.lblsell.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblsell.Location = new System.Drawing.Point(264, 36);
			this.lblsell.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblsell.Name = "lblsell";
			this.lblsell.Size = new System.Drawing.Size(66, 27);
			this.lblsell.TabIndex = 103;
			this.lblsell.Text = "賣方";
			this.lblsell.Click += new System.EventHandler(this.lblMonth_Click);
			// 
			// lblamount
			// 
			this.lblamount.AutoSize = true;
			this.lblamount.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblamount.Location = new System.Drawing.Point(12, 34);
			this.lblamount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblamount.Name = "lblamount";
			this.lblamount.Size = new System.Drawing.Size(66, 27);
			this.lblamount.TabIndex = 103;
			this.lblamount.Text = "金額";
			this.lblamount.Click += new System.EventHandler(this.lblMonth_Click);
			// 
			// txtBuyId
			// 
			this.txtBuyId.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtBuyId.Location = new System.Drawing.Point(344, 89);
			this.txtBuyId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtBuyId.Name = "txtBuyId";
			this.txtBuyId.Size = new System.Drawing.Size(161, 39);
			this.txtBuyId.TabIndex = 102;
			this.txtBuyId.TextChanged += new System.EventHandler(this.txtMonth_TextChanged);
			// 
			// txtDesc
			// 
			this.txtDesc.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtDesc.Location = new System.Drawing.Point(92, 149);
			this.txtDesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtDesc.Name = "txtDesc";
			this.txtDesc.Size = new System.Drawing.Size(161, 39);
			this.txtDesc.TabIndex = 102;
			this.txtDesc.TextChanged += new System.EventHandler(this.txtMonth_TextChanged);
			// 
			// txtSellId
			// 
			this.txtSellId.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtSellId.Location = new System.Drawing.Point(344, 30);
			this.txtSellId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtSellId.Name = "txtSellId";
			this.txtSellId.Size = new System.Drawing.Size(161, 39);
			this.txtSellId.TabIndex = 102;
			this.txtSellId.TextChanged += new System.EventHandler(this.txtMonth_TextChanged);
			// 
			// txtTax
			// 
			this.txtTax.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtTax.Location = new System.Drawing.Point(92, 86);
			this.txtTax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtTax.Name = "txtTax";
			this.txtTax.Size = new System.Drawing.Size(161, 39);
			this.txtTax.TabIndex = 102;
			this.txtTax.TextChanged += new System.EventHandler(this.txtMonth_TextChanged);
			// 
			// txtAmount
			// 
			this.txtAmount.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtAmount.Location = new System.Drawing.Point(92, 28);
			this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtAmount.Name = "txtAmount";
			this.txtAmount.Size = new System.Drawing.Size(161, 39);
			this.txtAmount.TabIndex = 102;
			this.txtAmount.TextChanged += new System.EventHandler(this.txtMonth_TextChanged);
			// 
			// btnOils
			// 
			this.btnOils.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnOils.Location = new System.Drawing.Point(20, 253);
			this.btnOils.Margin = new System.Windows.Forms.Padding(4);
			this.btnOils.Name = "btnOils";
			this.btnOils.Size = new System.Drawing.Size(225, 69);
			this.btnOils.TabIndex = 108;
			this.btnOils.Text = "油資";
			this.btnOils.UseVisualStyleBackColor = true;
			this.btnOils.Click += new System.EventHandler(this.btnOils_Click);
			// 
			// FrmOftenAccData
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1084, 479);
			this.Controls.Add(this.btnOils);
			this.Controls.Add(this.gbTexts);
			this.Controls.Add(this.btnProduce);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.gbQueryTime);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.flowLayouts);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FrmOftenAccData";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "月份常用帳務處理";
			this.Load += new System.EventHandler(this.FrmOftenAccData_Load);
			this.flowLayouts.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.gbQueryTime.ResumeLayout(false);
			this.gbQueryTime.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.gbTexts.ResumeLayout(false);
			this.gbTexts.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMeidaShare;
        private System.Windows.Forms.Button btnOffice;
        private System.Windows.Forms.FlowLayoutPanel flowLayouts;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnScanPic;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.Button btnProduce;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.GroupBox gbQueryTime;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbTexts;
        private System.Windows.Forms.Label lblamount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lbltax;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblsell;
        private System.Windows.Forms.TextBox txtBuyId;
        private System.Windows.Forms.TextBox txtSellId;
        private System.Windows.Forms.Button btnOther;
        private System.Windows.Forms.TextBox txtInvVal;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnOils;
	}
}