
namespace LingFragSystem
{
    partial class FrmOrderAdd
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
            this.picInfo = new System.Windows.Forms.PictureBox();
            this.lbName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBnote = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bntAdd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbNumber = new System.Windows.Forms.Label();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbPric = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // picInfo
            // 
            this.picInfo.Location = new System.Drawing.Point(13, 33);
            this.picInfo.Name = "picInfo";
            this.picInfo.Size = new System.Drawing.Size(96, 98);
            this.picInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picInfo.TabIndex = 0;
            this.picInfo.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("宋体", 15F);
            this.lbName.Location = new System.Drawing.Point(128, 49);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(69, 20);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "名称：";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(13, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 1);
            this.panel1.TabIndex = 2;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("宋体", 15F);
            this.lbPrice.Location = new System.Drawing.Point(128, 91);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(69, 20);
            this.lbPrice.TabIndex = 1;
            this.lbPrice.Text = "价格：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "口味:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(9, 8);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 16);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.Text = "家常";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(73, 8);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 16);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Text = "中辣";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(137, 8);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(47, 16);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.Text = "特辣";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Click += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "菜品:";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(10, 11);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(47, 16);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.Text = "平常";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.Click += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(74, 11);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(47, 16);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.Text = "少糖";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.Click += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(138, 11);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(47, 16);
            this.radioButton6.TabIndex = 4;
            this.radioButton6.Text = "多糖";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.Click += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "甜品:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "备注：";
            // 
            // txtBnote
            // 
            this.txtBnote.Location = new System.Drawing.Point(86, 284);
            this.txtBnote.Multiline = true;
            this.txtBnote.Name = "txtBnote";
            this.txtBnote.Size = new System.Drawing.Size(275, 55);
            this.txtBnote.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(13, 261);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 1);
            this.panel2.TabIndex = 2;
            // 
            // bntAdd
            // 
            this.bntAdd.Location = new System.Drawing.Point(303, 348);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(75, 23);
            this.bntAdd.TabIndex = 6;
            this.bntAdd.Text = "添加";
            this.bntAdd.UseVisualStyleBackColor = true;
            this.bntAdd.Click += new System.EventHandler(this.bntAdd_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioButton3);
            this.panel3.Controls.Add(this.radioButton2);
            this.panel3.Controls.Add(this.radioButton7);
            this.panel3.Controls.Add(this.radioButton1);
            this.panel3.Location = new System.Drawing.Point(15, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 32);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.radioButton6);
            this.panel4.Controls.Add(this.radioButton5);
            this.panel4.Controls.Add(this.radioButton8);
            this.panel4.Controls.Add(this.radioButton4);
            this.panel4.Location = new System.Drawing.Point(14, 36);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(271, 33);
            this.panel4.TabIndex = 8;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(206, 8);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(47, 16);
            this.radioButton7.TabIndex = 4;
            this.radioButton7.Text = "其它";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.Click += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label5.Location = new System.Drawing.Point(115, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "（其它选项添加到备注里面）";
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(207, 11);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(47, 16);
            this.radioButton8.TabIndex = 4;
            this.radioButton8.Text = "其它";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.Click += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(341, 104);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(20, 20);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbNumber
            // 
            this.lbNumber.AutoSize = true;
            this.lbNumber.Location = new System.Drawing.Point(322, 108);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(11, 12);
            this.lbNumber.TabIndex = 3;
            this.lbNumber.Text = "0";
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(294, 104);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(20, 20);
            this.btnSubtract.TabIndex = 9;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Location = new System.Drawing.Point(94, 168);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(299, 78);
            this.panel5.TabIndex = 10;
            // 
            // lbPric
            // 
            this.lbPric.AutoSize = true;
            this.lbPric.Location = new System.Drawing.Point(23, 353);
            this.lbPric.Name = "lbPric";
            this.lbPric.Size = new System.Drawing.Size(41, 12);
            this.lbPric.TabIndex = 3;
            this.lbPric.Text = "金额：";
            // 
            // FrmOrderAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 382);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.bntAdd);
            this.Controls.Add(this.txtBnote);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbNumber);
            this.Controls.Add(this.lbPric);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.picInfo);
            this.Name = "FrmOrderAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "下单";
            this.Load += new System.EventHandler(this.FrmOrderAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picInfo;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBnote;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bntAdd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbNumber;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbPric;
    }
}