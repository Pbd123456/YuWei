
namespace LingFragSystem
{
    partial class FrmPlaceOrder
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
            this.cboType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDishes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelect = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtBtaste = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBnote = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRid = new System.Windows.Forms.TextBox();
            this.FlpPan = new System.Windows.Forms.Panel();
            this.FlpPans = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbPric = new System.Windows.Forms.Label();
            this.FlpPan.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(252, 29);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(126, 20);
            this.cboType.TabIndex = 0;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "类型：";
            // 
            // cboDishes
            // 
            this.cboDishes.FormattingEnabled = true;
            this.cboDishes.Location = new System.Drawing.Point(255, 95);
            this.cboDishes.Name = "cboDishes";
            this.cboDishes.Size = new System.Drawing.Size(126, 20);
            this.cboDishes.TabIndex = 0;
            this.cboDishes.SelectedIndexChanged += new System.EventHandler(this.cboDishes_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "菜名：";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(603, 364);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 27);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "刷新";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(594, 29);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelect
            // 
            this.btnDelect.Location = new System.Drawing.Point(522, 364);
            this.btnDelect.Name = "btnDelect";
            this.btnDelect.Size = new System.Drawing.Size(75, 27);
            this.btnDelect.TabIndex = 2;
            this.btnDelect.Text = "删除";
            this.btnDelect.UseVisualStyleBackColor = true;
            this.btnDelect.Click += new System.EventHandler(this.btnDelect_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(441, 364);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 27);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // txtBtaste
            // 
            this.txtBtaste.Location = new System.Drawing.Point(441, 28);
            this.txtBtaste.Name = "txtBtaste";
            this.txtBtaste.Size = new System.Drawing.Size(126, 21);
            this.txtBtaste.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "口味：";
            // 
            // txtBnote
            // 
            this.txtBnote.Location = new System.Drawing.Point(408, 68);
            this.txtBnote.Multiline = true;
            this.txtBnote.Name = "txtBnote";
            this.txtBnote.Size = new System.Drawing.Size(265, 63);
            this.txtBnote.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "备注：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "已点菜品：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "房号/桌号：";
            // 
            // txtRid
            // 
            this.txtRid.Location = new System.Drawing.Point(101, 29);
            this.txtRid.Name = "txtRid";
            this.txtRid.ReadOnly = true;
            this.txtRid.Size = new System.Drawing.Size(79, 21);
            this.txtRid.TabIndex = 5;
            // 
            // FlpPan
            // 
            this.FlpPan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FlpPan.Controls.Add(this.FlpPans);
            this.FlpPan.Controls.Add(this.label11);
            this.FlpPan.Controls.Add(this.label12);
            this.FlpPan.Controls.Add(this.label10);
            this.FlpPan.Controls.Add(this.label9);
            this.FlpPan.Controls.Add(this.label8);
            this.FlpPan.Location = new System.Drawing.Point(55, 148);
            this.FlpPan.Name = "FlpPan";
            this.FlpPan.Size = new System.Drawing.Size(623, 210);
            this.FlpPan.TabIndex = 8;
            // 
            // FlpPans
            // 
            this.FlpPans.AutoScroll = true;
            this.FlpPans.Location = new System.Drawing.Point(3, 42);
            this.FlpPans.Name = "FlpPans";
            this.FlpPans.Size = new System.Drawing.Size(613, 160);
            this.FlpPans.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(561, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "金额";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(447, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "数量";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(246, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "备注";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(137, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "口味";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "菜品名";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(100, 65);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(69, 21);
            this.txtNumber.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(58, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 6;
            this.label13.Text = "数量：";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(100, 100);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(69, 21);
            this.txtPrice.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "金额";
            // 
            // lbPric
            // 
            this.lbPric.AutoSize = true;
            this.lbPric.Location = new System.Drawing.Point(107, 375);
            this.lbPric.Name = "lbPric";
            this.lbPric.Size = new System.Drawing.Size(0, 12);
            this.lbPric.TabIndex = 9;
            // 
            // FrmPlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 404);
            this.Controls.Add(this.lbPric);
            this.Controls.Add(this.FlpPan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBnote);
            this.Controls.Add(this.txtRid);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtBtaste);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDelect);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboDishes);
            this.Controls.Add(this.cboType);
            this.Name = "FrmPlaceOrder";
            this.Text = "点单界面";
            this.Load += new System.EventHandler(this.FrmPlaceOrder_Load);
            this.FlpPan.ResumeLayout(false);
            this.FlpPan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDishes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelect;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtBtaste;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBnote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRid;
        private System.Windows.Forms.Panel FlpPan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel FlpPans;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbPric;
    }
}