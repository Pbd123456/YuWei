
namespace LingFragSystem
{
    partial class FromLogin
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUid = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.btnSest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtion = new System.Windows.Forms.RadioButton();
            this.rbtion1 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(285, 270);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "取消";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(46, 270);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(80, 30);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUid
            // 
            this.txtUid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUid.Font = new System.Drawing.Font("宋体", 15F);
            this.txtUid.Location = new System.Drawing.Point(113, 95);
            this.txtUid.Name = "txtUid";
            this.txtUid.Size = new System.Drawing.Size(257, 23);
            this.txtUid.TabIndex = 2;
            // 
            // txtPwd
            // 
            this.txtPwd.BackColor = System.Drawing.Color.White;
            this.txtPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPwd.Font = new System.Drawing.Font("宋体", 15F);
            this.txtPwd.ForeColor = System.Drawing.Color.Black;
            this.txtPwd.Location = new System.Drawing.Point(113, 172);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(257, 23);
            this.txtPwd.TabIndex = 2;
            // 
            // btnSest
            // 
            this.btnSest.Location = new System.Drawing.Point(166, 270);
            this.btnSest.Name = "btnSest";
            this.btnSest.Size = new System.Drawing.Size(80, 30);
            this.btnSest.TabIndex = 0;
            this.btnSest.Text = "重置";
            this.btnSest.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.label1.Location = new System.Drawing.Point(39, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "账号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(39, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(44, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "职位：";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(44, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 1);
            this.panel1.TabIndex = 6;
            // 
            // rbtion
            // 
            this.rbtion.AutoSize = true;
            this.rbtion.BackColor = System.Drawing.Color.Transparent;
            this.rbtion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtion.Location = new System.Drawing.Point(111, 228);
            this.rbtion.Name = "rbtion";
            this.rbtion.Size = new System.Drawing.Size(58, 16);
            this.rbtion.TabIndex = 8;
            this.rbtion.Text = "操作员";
            this.rbtion.UseVisualStyleBackColor = false;
            // 
            // rbtion1
            // 
            this.rbtion1.AutoSize = true;
            this.rbtion1.BackColor = System.Drawing.Color.Transparent;
            this.rbtion1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtion1.Location = new System.Drawing.Point(215, 228);
            this.rbtion1.Name = "rbtion1";
            this.rbtion1.Size = new System.Drawing.Size(58, 16);
            this.rbtion1.TabIndex = 9;
            this.rbtion1.Text = "管理员";
            this.rbtion1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(44, 197);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 1);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.rbtion1);
            this.panel3.Controls.Add(this.rbtion);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtPwd);
            this.panel3.Controls.Add(this.txtUid);
            this.panel3.Controls.Add(this.btnLogin);
            this.panel3.Controls.Add(this.btnSest);
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Location = new System.Drawing.Point(188, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(409, 337);
            this.panel3.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 12);
            this.label4.TabIndex = 11;
            // 
            // FromLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(837, 477);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "FromLogin";
            this.Text = "余味管理系统登录";
            this.Load += new System.EventHandler(this.FromLogin_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUid;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button btnSest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtion;
        private System.Windows.Forms.RadioButton rbtion1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
    }
}