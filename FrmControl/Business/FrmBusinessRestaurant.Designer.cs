namespace FinanceAccountProgram.FrmControl.Business
{
    partial class FrmBusinessRestaurant
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
            this.components = new System.ComponentModel.Container();
            this.tabPanels = new System.Windows.Forms.TabControl();
            this.tab01 = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.chTaxRate = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblRemainPrice = new System.Windows.Forms.Label();
            this.plTop = new System.Windows.Forms.Panel();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.txtCol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.plControls = new System.Windows.Forms.Panel();
            this.plMsg = new System.Windows.Forms.Panel();
            this.lblMsgProduct = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblMsgDisplay = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblCash = new System.Windows.Forms.Label();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.lblIssue = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.tab02 = new System.Windows.Forms.TabPage();
            this.datatodayfoods = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabPanels.SuspendLayout();
            this.tab01.SuspendLayout();
            this.plTop.SuspendLayout();
            this.plMsg.SuspendLayout();
            this.tab02.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datatodayfoods)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPanels
            // 
            this.tabPanels.Controls.Add(this.tab01);
            this.tabPanels.Controls.Add(this.tab02);
            this.tabPanels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanels.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPanels.Location = new System.Drawing.Point(0, 0);
            this.tabPanels.Name = "tabPanels";
            this.tabPanels.SelectedIndex = 0;
            this.tabPanels.Size = new System.Drawing.Size(1201, 822);
            this.tabPanels.TabIndex = 0;
            this.tabPanels.SelectedIndexChanged += new System.EventHandler(this.tabPanels_SelectedIndexChanged);
            // 
            // tab01
            // 
            this.tab01.Controls.Add(this.btnSave);
            this.tab01.Controls.Add(this.chTaxRate);
            this.tab01.Controls.Add(this.btnClear);
            this.tab01.Controls.Add(this.btnAdd);
            this.tab01.Controls.Add(this.lblRemainPrice);
            this.tab01.Controls.Add(this.plTop);
            this.tab01.Controls.Add(this.plControls);
            this.tab01.Controls.Add(this.plMsg);
            this.tab01.Controls.Add(this.txtPrice);
            this.tab01.Controls.Add(this.lblCash);
            this.tab01.Controls.Add(this.txtPayment);
            this.tab01.Controls.Add(this.lblIssue);
            this.tab01.Controls.Add(this.lblPayment);
            this.tab01.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tab01.Location = new System.Drawing.Point(4, 29);
            this.tab01.Name = "tab01";
            this.tab01.Padding = new System.Windows.Forms.Padding(3);
            this.tab01.Size = new System.Drawing.Size(1193, 789);
            this.tab01.TabIndex = 0;
            this.tab01.Text = "點餐系統";
            this.tab01.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.Location = new System.Drawing.Point(860, 14);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 78);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "儲檔";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chTaxRate
            // 
            this.chTaxRate.AutoSize = true;
            this.chTaxRate.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chTaxRate.Location = new System.Drawing.Point(791, 129);
            this.chTaxRate.Name = "chTaxRate";
            this.chTaxRate.Size = new System.Drawing.Size(85, 23);
            this.chTaxRate.TabIndex = 17;
            this.chTaxRate.Text = "加稅金";
            this.chTaxRate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(722, 14);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(132, 78);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Location = new System.Drawing.Point(584, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(132, 78);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "顯示";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblRemainPrice
            // 
            this.lblRemainPrice.AutoSize = true;
            this.lblRemainPrice.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblRemainPrice.Location = new System.Drawing.Point(685, 236);
            this.lblRemainPrice.Name = "lblRemainPrice";
            this.lblRemainPrice.Size = new System.Drawing.Size(89, 19);
            this.lblRemainPrice.TabIndex = 16;
            this.lblRemainPrice.Text = "                ";
            // 
            // plTop
            // 
            this.plTop.Controls.Add(this.txtHeight);
            this.plTop.Controls.Add(this.lblHeight);
            this.plTop.Controls.Add(this.txtWidth);
            this.plTop.Controls.Add(this.lblWidth);
            this.plTop.Controls.Add(this.txtCol);
            this.plTop.Controls.Add(this.label1);
            this.plTop.Location = new System.Drawing.Point(3, 6);
            this.plTop.Name = "plTop";
            this.plTop.Size = new System.Drawing.Size(512, 63);
            this.plTop.TabIndex = 13;
            this.plTop.Visible = false;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(389, 12);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 30);
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
            this.txtWidth.Size = new System.Drawing.Size(100, 30);
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
            this.txtCol.Size = new System.Drawing.Size(100, 30);
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
            // plControls
            // 
            this.plControls.AutoScroll = true;
            this.plControls.Location = new System.Drawing.Point(2, 122);
            this.plControls.Name = "plControls";
            this.plControls.Size = new System.Drawing.Size(583, 656);
            this.plControls.TabIndex = 14;
            // 
            // plMsg
            // 
            this.plMsg.AutoScroll = true;
            this.plMsg.Controls.Add(this.lblMsgProduct);
            this.plMsg.Controls.Add(this.lblProduct);
            this.plMsg.Controls.Add(this.lblMsgDisplay);
            this.plMsg.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plMsg.Location = new System.Drawing.Point(591, 276);
            this.plMsg.Name = "plMsg";
            this.plMsg.Size = new System.Drawing.Size(594, 464);
            this.plMsg.TabIndex = 15;
            // 
            // lblMsgProduct
            // 
            this.lblMsgProduct.AutoSize = true;
            this.lblMsgProduct.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMsgProduct.Location = new System.Drawing.Point(10, 13);
            this.lblMsgProduct.Name = "lblMsgProduct";
            this.lblMsgProduct.Size = new System.Drawing.Size(148, 22);
            this.lblMsgProduct.TabIndex = 1;
            this.lblMsgProduct.Text = "                       ";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblProduct.Location = new System.Drawing.Point(24, 13);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(278, 32);
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Text = "                                 ";
            // 
            // lblMsgDisplay
            // 
            this.lblMsgDisplay.AutoSize = true;
            this.lblMsgDisplay.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMsgDisplay.Location = new System.Drawing.Point(10, 409);
            this.lblMsgDisplay.Name = "lblMsgDisplay";
            this.lblMsgDisplay.Size = new System.Drawing.Size(172, 24);
            this.lblMsgDisplay.TabIndex = 18;
            this.lblMsgDisplay.Text = "                           ";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPrice.Location = new System.Drawing.Point(685, 173);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 30);
            this.txtPrice.TabIndex = 11;
            this.txtPrice.Text = "0";
            this.txtPrice.Click += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCash.Location = new System.Drawing.Point(600, 236);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(47, 19);
            this.lblCash.TabIndex = 8;
            this.lblCash.Text = "剩下";
            // 
            // txtPayment
            // 
            this.txtPayment.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPayment.Location = new System.Drawing.Point(685, 119);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(100, 30);
            this.txtPayment.TabIndex = 12;
            this.txtPayment.Text = "100";
            this.txtPayment.Click += new System.EventHandler(this.txtPayment_TextChanged);
            // 
            // lblIssue
            // 
            this.lblIssue.AutoSize = true;
            this.lblIssue.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblIssue.Location = new System.Drawing.Point(600, 179);
            this.lblIssue.Name = "lblIssue";
            this.lblIssue.Size = new System.Drawing.Size(47, 19);
            this.lblIssue.TabIndex = 9;
            this.lblIssue.Text = "價格";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPayment.Location = new System.Drawing.Point(600, 122);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(47, 19);
            this.lblPayment.TabIndex = 10;
            this.lblPayment.Text = "付款";
            // 
            // tab02
            // 
            this.tab02.Controls.Add(this.datatodayfoods);
            this.tab02.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tab02.Location = new System.Drawing.Point(4, 29);
            this.tab02.Name = "tab02";
            this.tab02.Padding = new System.Windows.Forms.Padding(3);
            this.tab02.Size = new System.Drawing.Size(1193, 789);
            this.tab02.TabIndex = 1;
            this.tab02.Text = "當日結帳餐點";
            this.tab02.UseVisualStyleBackColor = true;
            // 
            // datatodayfoods
            // 
            this.datatodayfoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datatodayfoods.Location = new System.Drawing.Point(3, 6);
            this.datatodayfoods.Name = "datatodayfoods";
            this.datatodayfoods.RowTemplate.Height = 24;
            this.datatodayfoods.Size = new System.Drawing.Size(1117, 658);
            this.datatodayfoods.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(710, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(8, 8);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(0, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(0, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 2500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmBusinessRestaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1201, 822);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tabPanels);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmBusinessRestaurant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "餐廳食品";
            this.Load += new System.EventHandler(this.FrmBusinessRestaurant_Load);
            this.Shown += new System.EventHandler(this.FrmBusinessRestaurant_Shown);
            this.tabPanels.ResumeLayout(false);
            this.tab01.ResumeLayout(false);
            this.tab01.PerformLayout();
            this.plTop.ResumeLayout(false);
            this.plTop.PerformLayout();
            this.plMsg.ResumeLayout(false);
            this.plMsg.PerformLayout();
            this.tab02.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datatodayfoods)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPanels;
        private System.Windows.Forms.TabPage tab01;
        private System.Windows.Forms.TabPage tab02;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox chTaxRate;
        private System.Windows.Forms.Label lblRemainPrice;
        private System.Windows.Forms.Label lblMsgDisplay;
        private System.Windows.Forms.Panel plTop;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox txtCol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel plControls;
        private System.Windows.Forms.Panel plMsg;
        private System.Windows.Forms.Label lblMsgProduct;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Label lblIssue;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView datatodayfoods;
    }
}