namespace FinanceAccountProgram.ViewFrm
{
    partial class ModifyDataFrm
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
            this.datagridContent = new System.Windows.Forms.DataGridView();
            this.btnModifyData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridContent)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridContent
            // 
            this.datagridContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridContent.Location = new System.Drawing.Point(12, 52);
            this.datagridContent.Name = "datagridContent";
            this.datagridContent.RowTemplate.Height = 24;
            this.datagridContent.Size = new System.Drawing.Size(1004, 514);
            this.datagridContent.TabIndex = 0;
            // 
            // btnModifyData
            // 
            this.btnModifyData.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnModifyData.Location = new System.Drawing.Point(12, 3);
            this.btnModifyData.Name = "btnModifyData";
            this.btnModifyData.Size = new System.Drawing.Size(1004, 46);
            this.btnModifyData.TabIndex = 1;
            this.btnModifyData.Text = "修改";
            this.btnModifyData.UseVisualStyleBackColor = true;
            this.btnModifyData.Click += new System.EventHandler(this.btnModifyData_Click);
            // 
            // ModifyDataFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 589);
            this.Controls.Add(this.btnModifyData);
            this.Controls.Add(this.datagridContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ModifyDataFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifyDataFrm";
            this.Load += new System.EventHandler(this.ModifyDataFrm_Load);
            this.Shown += new System.EventHandler(this.ModifyDataFrm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.datagridContent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridContent;
        private System.Windows.Forms.Button btnModifyData;
    }
}