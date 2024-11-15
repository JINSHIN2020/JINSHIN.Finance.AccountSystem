using System.Windows.Forms;

namespace JINSHIN.Finance.AccountSystem.FrmControl.Invoice.DBManagement
{
    partial class FrmDataForm
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
            this.dg01 = new System.Windows.Forms.DataGridView();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dg02 = new System.Windows.Forms.DataGridView();
            this.picdata = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblphoto = new System.Windows.Forms.Label();
            this.lbl01 = new System.Windows.Forms.Label();
            this.lblRs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picdata)).BeginInit();
            this.SuspendLayout();
            // 
            // dg01
            // 
            this.dg01.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg01.Location = new System.Drawing.Point(19, 31);
            this.dg01.Margin = new System.Windows.Forms.Padding(2);
            this.dg01.Name = "dg01";
            this.dg01.RowTemplate.Height = 27;
            this.dg01.Size = new System.Drawing.Size(439, 371);
            this.dg01.TabIndex = 0;
            // 
            // btnInvoice
            // 
            this.btnInvoice.Location = new System.Drawing.Point(1101, 35);
            this.btnInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(80, 30);
            this.btnInvoice.TabIndex = 1;
            this.btnInvoice.Text = "比對";
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("新細明體", 14F);
            this.txtYear.Location = new System.Drawing.Point(998, 35);
            this.txtYear.Margin = new System.Windows.Forms.Padding(2);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(92, 30);
            this.txtYear.TabIndex = 2;
            this.txtYear.Text = "2022";
            this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("新細明體", 14F);
            this.lblTitle.Location = new System.Drawing.Point(903, 41);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(85, 19);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "比對年度";
            // 
            // dg02
            // 
            this.dg02.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg02.Location = new System.Drawing.Point(473, 31);
            this.dg02.Margin = new System.Windows.Forms.Padding(2);
            this.dg02.Name = "dg02";
            this.dg02.RowTemplate.Height = 27;
            this.dg02.Size = new System.Drawing.Size(414, 371);
            this.dg02.TabIndex = 4;
            this.dg02.Click += new System.EventHandler(this.dg02_Click);
            // 
            // picdata
            // 
            this.picdata.Location = new System.Drawing.Point(907, 116);
            this.picdata.Margin = new System.Windows.Forms.Padding(2);
            this.picdata.Name = "picdata";
            this.picdata.Size = new System.Drawing.Size(414, 371);
            this.picdata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picdata.TabIndex = 6;
            this.picdata.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(16, 447);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(438, 220);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.HorizontalScrollbar = true;
            this.listBox2.ItemHeight = 24;
            this.listBox2.Location = new System.Drawing.Point(471, 448);
            this.listBox2.Margin = new System.Windows.Forms.Padding(2);
            this.listBox2.Name = "listBox2";
            this.listBox2.ScrollAlwaysVisible = true;
            this.listBox2.Size = new System.Drawing.Size(416, 220);
            this.listBox2.TabIndex = 7;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1187, 35);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(79, 30);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "清除傳票";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Visible = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F);
            this.label1.Location = new System.Drawing.Point(16, 423);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "資料庫資訊";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F);
            this.label2.Location = new System.Drawing.Point(470, 423);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "發票資訊";
            // 
            // lblphoto
            // 
            this.lblphoto.AutoSize = true;
            this.lblphoto.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F);
            this.lblphoto.Location = new System.Drawing.Point(903, 90);
            this.lblphoto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblphoto.Name = "lblphoto";
            this.lblphoto.Size = new System.Drawing.Size(86, 24);
            this.lblphoto.TabIndex = 11;
            this.lblphoto.Text = "發票影像";
            // 
            // lbl01
            // 
            this.lbl01.AutoSize = true;
            this.lbl01.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F);
            this.lbl01.Location = new System.Drawing.Point(20, 6);
            this.lbl01.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl01.Name = "lbl01";
            this.lbl01.Size = new System.Drawing.Size(124, 24);
            this.lbl01.TabIndex = 12;
            this.lbl01.Text = "資料庫的資料";
            // 
            // lblRs
            // 
            this.lblRs.AutoSize = true;
            this.lblRs.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F);
            this.lblRs.Location = new System.Drawing.Point(475, 6);
            this.lblRs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRs.Name = "lblRs";
            this.lblRs.Size = new System.Drawing.Size(86, 24);
            this.lblRs.TabIndex = 13;
            this.lblRs.Text = "比對結果";
            // 
            // FrmDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 692);
            this.Controls.Add(this.lblRs);
            this.Controls.Add(this.lbl01);
            this.Controls.Add(this.lblphoto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.picdata);
            this.Controls.Add(this.dg02);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.btnInvoice);
            this.Controls.Add(this.dg01);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "發票管理";
            this.Load += new System.EventHandler(this.FrmDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg01;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dg02;
        private System.Windows.Forms.PictureBox picdata;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button btnClear;
        private Label label1;
        private Label label2;
        private Label lblphoto;
        private Label lbl01;
        private Label lblRs;
    }
}