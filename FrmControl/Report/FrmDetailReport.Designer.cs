namespace JINSHIN.Finance.AccountSystem.FrmControl.Report
{
    partial class FrmDetailReport
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
            this.dgData = new System.Windows.Forms.DataGridView();
            this.btnInquire = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.lstType = new System.Windows.Forms.ListBox();
            this.lstmsg = new System.Windows.Forms.ListBox();
            this.lblmsg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgData
            // 
            this.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgData.Location = new System.Drawing.Point(197, 12);
            this.dgData.Name = "dgData";
            this.dgData.RowTemplate.Height = 24;
            this.dgData.Size = new System.Drawing.Size(795, 322);
            this.dgData.TabIndex = 0;
            this.dgData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgData_CellContentClick);
            // 
            // btnInquire
            // 
            this.btnInquire.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInquire.Location = new System.Drawing.Point(21, 189);
            this.btnInquire.Name = "btnInquire";
            this.btnInquire.Size = new System.Drawing.Size(169, 61);
            this.btnInquire.TabIndex = 2;
            this.btnInquire.Text = "查詢";
            this.btnInquire.UseVisualStyleBackColor = true;
            this.btnInquire.Click += new System.EventHandler(this.btnInquire_Click);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnExport.Location = new System.Drawing.Point(21, 256);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(169, 61);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "匯出";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lstType
            // 
            this.lstType.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstType.FormattingEnabled = true;
            this.lstType.ItemHeight = 19;
            this.lstType.Items.AddRange(new object[] {
            "成本明細表",
            "其他費用明細表",
            "研究發展明細表",
            "營業費用明細表"});
            this.lstType.Location = new System.Drawing.Point(22, 44);
            this.lstType.Name = "lstType";
            this.lstType.Size = new System.Drawing.Size(169, 99);
            this.lstType.TabIndex = 4;
            // 
            // lstmsg
            // 
            this.lstmsg.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstmsg.FormattingEnabled = true;
            this.lstmsg.ItemHeight = 19;
            this.lstmsg.Location = new System.Drawing.Point(1001, 45);
            this.lstmsg.Name = "lstmsg";
            this.lstmsg.Size = new System.Drawing.Size(231, 289);
            this.lstmsg.TabIndex = 5;
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblmsg.Location = new System.Drawing.Point(1000, 18);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(90, 19);
            this.lblmsg.TabIndex = 6;
            this.lblmsg.Text = "審查結果 ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "報表選擇";
            // 
            // dgList
            // 
            this.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgList.Location = new System.Drawing.Point(197, 344);
            this.dgList.Name = "dgList";
            this.dgList.RowTemplate.Height = 24;
            this.dgList.Size = new System.Drawing.Size(900, 329);
            this.dgList.TabIndex = 7;
            this.dgList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgList_CellContentClick);
            // 
            // FrmDetailReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 685);
            this.Controls.Add(this.dgList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.lstmsg);
            this.Controls.Add(this.lstType);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnInquire);
            this.Controls.Add(this.dgData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmDetailReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "國稅局明細表";
            this.Load += new System.EventHandler(this.FrmDetailReport_Load);
            this.Shown += new System.EventHandler(this.FrmDetailReport_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgData;
        private System.Windows.Forms.Button btnInquire;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.ListBox lstType;
        private System.Windows.Forms.ListBox lstmsg;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgList;
    }
}