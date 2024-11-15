namespace FinanceAccountProgram.FrmControl.Business
{
    partial class FrmRestaurantFood
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
            this.dgClassData = new System.Windows.Forms.DataGridView();
            this.btnClassUpdate = new System.Windows.Forms.Button();
            this.btnClassAdd = new System.Windows.Forms.Button();
            this.lblSN = new System.Windows.Forms.Label();
            this.lblClassName = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDataCnt = new System.Windows.Forms.TextBox();
            this.lblDataAllCnt = new System.Windows.Forms.Label();
            this.lblSetupDataCnt = new System.Windows.Forms.Label();
            this.lblAllCnt = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.lblSnData = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgClassData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgClassData
            // 
            this.dgClassData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgClassData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClassData.Location = new System.Drawing.Point(12, 96);
            this.dgClassData.Name = "dgClassData";
            this.dgClassData.RowTemplate.Height = 24;
            this.dgClassData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgClassData.Size = new System.Drawing.Size(716, 617);
            this.dgClassData.TabIndex = 19;
            this.dgClassData.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClassData_RowEnter);
            this.dgClassData.SelectionChanged += new System.EventHandler(this.dgClassData_SelectionChanged);
            // 
            // btnClassUpdate
            // 
            this.btnClassUpdate.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClassUpdate.Location = new System.Drawing.Point(605, 49);
            this.btnClassUpdate.Name = "btnClassUpdate";
            this.btnClassUpdate.Size = new System.Drawing.Size(123, 38);
            this.btnClassUpdate.TabIndex = 7;
            this.btnClassUpdate.Text = "更新";
            this.btnClassUpdate.UseVisualStyleBackColor = true;
            this.btnClassUpdate.Click += new System.EventHandler(this.btnClassUpdate_Click);
            // 
            // btnClassAdd
            // 
            this.btnClassAdd.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClassAdd.Location = new System.Drawing.Point(605, 5);
            this.btnClassAdd.Name = "btnClassAdd";
            this.btnClassAdd.Size = new System.Drawing.Size(123, 38);
            this.btnClassAdd.TabIndex = 8;
            this.btnClassAdd.Text = "新增";
            this.btnClassAdd.UseVisualStyleBackColor = true;
            this.btnClassAdd.Click += new System.EventHandler(this.btnClassAdd_Click);
            // 
            // lblSN
            // 
            this.lblSN.AutoSize = true;
            this.lblSN.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSN.Location = new System.Drawing.Point(23, 12);
            this.lblSN.Name = "lblSN";
            this.lblSN.Size = new System.Drawing.Size(35, 19);
            this.lblSN.TabIndex = 15;
            this.lblSN.Text = "NO";
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblClassName.Location = new System.Drawing.Point(209, 12);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(47, 19);
            this.lblClassName.TabIndex = 16;
            this.lblClassName.Text = "類別";
            // 
            // txtClass
            // 
            this.txtClass.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtClass.Location = new System.Drawing.Point(264, 12);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(119, 30);
            this.txtClass.TabIndex = 1;
            this.txtClass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtClass_KeyDown);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(455, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(119, 30);
            this.txtName.TabIndex = 2;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(400, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "名稱";
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNum.Location = new System.Drawing.Point(69, 57);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(119, 30);
            this.txtNum.TabIndex = 3;
            this.txtNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNum_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(11, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "數量";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPrice.Location = new System.Drawing.Point(264, 57);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(119, 30);
            this.txtPrice.TabIndex = 5;
            this.txtPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrice_KeyDown);
            this.txtPrice.ImeModeChanged += new System.EventHandler(this.txtPrice_ImeModeChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(209, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "金額";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDiscount.Location = new System.Drawing.Point(456, 57);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(119, 30);
            this.txtDiscount.TabIndex = 6;
            this.txtDiscount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDiscount_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(401, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "折扣";
            // 
            // txtDataCnt
            // 
            this.txtDataCnt.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDataCnt.Location = new System.Drawing.Point(862, 20);
            this.txtDataCnt.Name = "txtDataCnt";
            this.txtDataCnt.Size = new System.Drawing.Size(70, 30);
            this.txtDataCnt.TabIndex = 38;
            this.txtDataCnt.Text = "150";
            // 
            // lblDataAllCnt
            // 
            this.lblDataAllCnt.AutoSize = true;
            this.lblDataAllCnt.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDataAllCnt.Location = new System.Drawing.Point(858, 58);
            this.lblDataAllCnt.Name = "lblDataAllCnt";
            this.lblDataAllCnt.Size = new System.Drawing.Size(18, 19);
            this.lblDataAllCnt.TabIndex = 35;
            this.lblDataAllCnt.Text = "0";
            // 
            // lblSetupDataCnt
            // 
            this.lblSetupDataCnt.AutoSize = true;
            this.lblSetupDataCnt.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSetupDataCnt.Location = new System.Drawing.Point(743, 20);
            this.lblSetupDataCnt.Name = "lblSetupDataCnt";
            this.lblSetupDataCnt.Size = new System.Drawing.Size(85, 19);
            this.lblSetupDataCnt.TabIndex = 36;
            this.lblSetupDataCnt.Text = "資料筆數";
            // 
            // lblAllCnt
            // 
            this.lblAllCnt.AutoSize = true;
            this.lblAllCnt.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAllCnt.Location = new System.Drawing.Point(743, 58);
            this.lblAllCnt.Name = "lblAllCnt";
            this.lblAllCnt.Size = new System.Drawing.Size(104, 19);
            this.lblAllCnt.TabIndex = 37;
            this.lblAllCnt.Text = "資料總筆數";
            // 
            // btnQuery
            // 
            this.btnQuery.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnQuery.Location = new System.Drawing.Point(734, 96);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(207, 38);
            this.btnQuery.TabIndex = 9;
            this.btnQuery.Text = "查詢";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // lblSnData
            // 
            this.lblSnData.AutoSize = true;
            this.lblSnData.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSnData.Location = new System.Drawing.Point(67, 12);
            this.lblSnData.Name = "lblSnData";
            this.lblSnData.Size = new System.Drawing.Size(119, 19);
            this.lblSnData.TabIndex = 39;
            this.lblSnData.Text = "                      ";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.Location = new System.Drawing.Point(734, 140);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(207, 38);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "刪除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmRestaurantFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 725);
            this.Controls.Add(this.lblSnData);
            this.Controls.Add(this.txtDataCnt);
            this.Controls.Add(this.lblDataAllCnt);
            this.Controls.Add(this.lblSetupDataCnt);
            this.Controls.Add(this.lblAllCnt);
            this.Controls.Add(this.dgClassData);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.btnClassUpdate);
            this.Controls.Add(this.btnClassAdd);
            this.Controls.Add(this.lblSN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblClassName);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtClass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmRestaurantFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新增商品";
            this.Load += new System.EventHandler(this.FrmRestaurantFood_Load);
            this.Shown += new System.EventHandler(this.FrmRestaurantFood_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgClassData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgClassData;
        private System.Windows.Forms.Button btnClassUpdate;
        private System.Windows.Forms.Button btnClassAdd;
        private System.Windows.Forms.Label lblSN;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDataCnt;
        private System.Windows.Forms.Label lblDataAllCnt;
        private System.Windows.Forms.Label lblSetupDataCnt;
        private System.Windows.Forms.Label lblAllCnt;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label lblSnData;
        private System.Windows.Forms.Button btnDelete;
    }
}