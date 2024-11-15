namespace FinanceAccountProgram.FrmControl
{
    partial class FrmAffairs
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
            this.plControls = new System.Windows.Forms.Panel();
            this.plTop = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.txtCol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.plTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // plControls
            // 
            this.plControls.AutoScroll = true;
            this.plControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.plControls.Location = new System.Drawing.Point(0, 0);
            this.plControls.Name = "plControls";
            this.plControls.Size = new System.Drawing.Size(1028, 578);
            this.plControls.TabIndex = 0;
            this.plControls.Paint += new System.Windows.Forms.PaintEventHandler(this.plControls_Paint);
            // 
            // plTop
            // 
            this.plTop.Controls.Add(this.btnAdd);
            this.plTop.Controls.Add(this.txtHeight);
            this.plTop.Controls.Add(this.lblHeight);
            this.plTop.Controls.Add(this.txtWidth);
            this.plTop.Controls.Add(this.lblWidth);
            this.plTop.Controls.Add(this.txtCol);
            this.plTop.Controls.Add(this.label1);
            this.plTop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plTop.Location = new System.Drawing.Point(0, 584);
            this.plTop.Name = "plTop";
            this.plTop.Size = new System.Drawing.Size(1028, 52);
            this.plTop.TabIndex = 0;
            this.plTop.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Location = new System.Drawing.Point(508, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(132, 41);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "顯示";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(389, 12);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 22);
            this.txtHeight.TabIndex = 1;
            this.txtHeight.Text = "100";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblHeight.Location = new System.Drawing.Point(336, 12);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(47, 19);
            this.lblHeight.TabIndex = 0;
            this.lblHeight.Text = "高度";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(229, 12);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 22);
            this.txtWidth.TabIndex = 1;
            this.txtWidth.Text = "100";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblWidth.Location = new System.Drawing.Point(176, 12);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(47, 19);
            this.lblWidth.TabIndex = 0;
            this.lblWidth.Text = "寬度";
            // 
            // txtCol
            // 
            this.txtCol.Location = new System.Drawing.Point(64, 12);
            this.txtCol.Name = "txtCol";
            this.txtCol.Size = new System.Drawing.Size(100, 22);
            this.txtCol.TabIndex = 1;
            this.txtCol.Text = "6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "欄位";
            // 
            // FrmAffairs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 636);
            this.Controls.Add(this.plTop);
            this.Controls.Add(this.plControls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAffairs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "事務處理審核";
            this.Load += new System.EventHandler(this.FrmAffairs_Load);
            this.Shown += new System.EventHandler(this.FrmAffairs_Shown);
            this.plTop.ResumeLayout(false);
            this.plTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plControls;
        private System.Windows.Forms.Panel plTop;
        private System.Windows.Forms.TextBox txtCol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Button btnAdd;
    }
}