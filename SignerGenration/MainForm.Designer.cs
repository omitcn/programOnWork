namespace SignerGenration
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.inputname = new System.Windows.Forms.TextBox();
            this.drawButton = new System.Windows.Forms.Button();
            this.department = new System.Windows.Forms.ComboBox();
            this.pinyininput = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.telephone = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inputname
            // 
            this.inputname.Font = new System.Drawing.Font("宋体", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.inputname.Location = new System.Drawing.Point(35, 34);
            this.inputname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputname.Name = "inputname";
            this.inputname.Size = new System.Drawing.Size(245, 26);
            this.inputname.TabIndex = 0;
            this.inputname.Text = "请输入姓名和职位中间用空格隔开";
            this.inputname.TextChanged += new System.EventHandler(this.inputText_TextChanged);
            // 
            // drawButton
            // 
            this.drawButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.drawButton.Location = new System.Drawing.Point(454, 218);
            this.drawButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(92, 33);
            this.drawButton.TabIndex = 1;
            this.drawButton.Text = "生成邮箱签名";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // department
            // 
            this.department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.department.Font = new System.Drawing.Font("宋体", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.department.FormattingEnabled = true;
            this.department.Items.AddRange(new object[] {
            "滕州人力行政中心",
            "技术部",
            "生产管理中心"});
            this.department.Location = new System.Drawing.Point(454, 34);
            this.department.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(92, 24);
            this.department.TabIndex = 3;
            this.department.SelectedIndexChanged += new System.EventHandler(this.department_SelectedIndexChanged);
            // 
            // pinyininput
            // 
            this.pinyininput.Font = new System.Drawing.Font("宋体", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pinyininput.Location = new System.Drawing.Point(284, 34);
            this.pinyininput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pinyininput.Name = "pinyininput";
            this.pinyininput.Size = new System.Drawing.Size(168, 26);
            this.pinyininput.TabIndex = 4;
            this.pinyininput.Text = "请输入姓名的拼音";
            this.pinyininput.TextChanged += new System.EventHandler(this.pinyininput_TextChanged);
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("宋体", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.phone.Location = new System.Drawing.Point(35, 74);
            this.phone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(179, 26);
            this.phone.TabIndex = 5;
            this.phone.Text = "请输入电话号码";
            this.phone.TextChanged += new System.EventHandler(this.phone_TextChanged);
            // 
            // telephone
            // 
            this.telephone.Font = new System.Drawing.Font("宋体", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.telephone.Location = new System.Drawing.Point(229, 74);
            this.telephone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.telephone.Name = "telephone";
            this.telephone.Size = new System.Drawing.Size(122, 26);
            this.telephone.TabIndex = 6;
            this.telephone.Text = "请输入座机号码";
            this.telephone.TextChanged += new System.EventHandler(this.telephone_TextChanged);
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("宋体", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.email.Location = new System.Drawing.Point(355, 74);
            this.email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(192, 26);
            this.email.TabIndex = 7;
            this.email.Text = "请输入个人邮箱";
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.email);
            this.Controls.Add(this.telephone);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.pinyininput);
            this.Controls.Add(this.department);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.inputname);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputname;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.ComboBox department;
        private System.Windows.Forms.TextBox pinyininput;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox telephone;
        private System.Windows.Forms.TextBox email;
    }
}

