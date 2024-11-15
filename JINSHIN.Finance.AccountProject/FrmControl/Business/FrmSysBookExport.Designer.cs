namespace FinanceAccountProgram.FrmControl
{
    partial class FrmSysBookExport
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
            this.chExportVerify = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.lstAccounting = new System.Windows.Forms.ListBox();
            this.btnExportAccounting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chExportVerify
            // 
            this.chExportVerify.AutoSize = true;
            this.chExportVerify.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chExportVerify.Location = new System.Drawing.Point(895, 46);
            this.chExportVerify.Name = "chExportVerify";
            this.chExportVerify.Size = new System.Drawing.Size(104, 23);
            this.chExportVerify.TabIndex = 18;
            this.chExportVerify.Text = "預先結算";
            this.chExportVerify.UseVisualStyleBackColor = true;
            this.chExportVerify.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label19.Location = new System.Drawing.Point(12, 80);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 19);
            this.label19.TabIndex = 17;
            this.label19.Text = "訊息";
            // 
            // lstAccounting
            // 
            this.lstAccounting.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstAccounting.FormattingEnabled = true;
            this.lstAccounting.ItemHeight = 19;
            this.lstAccounting.Location = new System.Drawing.Point(17, 112);
            this.lstAccounting.Name = "lstAccounting";
            this.lstAccounting.Size = new System.Drawing.Size(857, 631);
            this.lstAccounting.TabIndex = 16;
            // 
            // btnExportAccounting
            // 
            this.btnExportAccounting.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnExportAccounting.Location = new System.Drawing.Point(12, 3);
            this.btnExportAccounting.Name = "btnExportAccounting";
            this.btnExportAccounting.Size = new System.Drawing.Size(862, 66);
            this.btnExportAccounting.TabIndex = 15;
            this.btnExportAccounting.Text = "匯出帳冊";
            this.btnExportAccounting.UseVisualStyleBackColor = true;
            this.btnExportAccounting.Click += new System.EventHandler(this.btnExportAccounting_Click);
            // 
            // FrmSysBookExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 738);
            this.Controls.Add(this.chExportVerify);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lstAccounting);
            this.Controls.Add(this.btnExportAccounting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSysBookExport";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "帳目匯出";
            this.Shown += new System.EventHandler(this.FrmSysBookExport_Shown);
            this.ResizeBegin += new System.EventHandler(this.FrmSysBookExport_ResizeBegin);
            this.SizeChanged += new System.EventHandler(this.FrmSysBookExport_SizeChanged);
            this.Resize += new System.EventHandler(this.FrmSysBookExport_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chExportVerify;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ListBox lstAccounting;
        private System.Windows.Forms.Button btnExportAccounting;
    }
}