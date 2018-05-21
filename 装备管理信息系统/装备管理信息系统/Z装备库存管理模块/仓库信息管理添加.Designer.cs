namespace 装备库存管理
{
    partial class 仓库信息管理添加
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.仓库编号 = new System.Windows.Forms.TextBox();
            this.仓库名称 = new System.Windows.Forms.TextBox();
            this.仓库备注 = new System.Windows.Forms.TextBox();
            this.确定添加 = new System.Windows.Forms.Button();
            this.取消添加 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "仓库编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "仓库名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "仓库备注";
            // 
            // 仓库编号
            // 
            this.仓库编号.Location = new System.Drawing.Point(98, 34);
            this.仓库编号.Name = "仓库编号";
            this.仓库编号.Size = new System.Drawing.Size(100, 21);
            this.仓库编号.TabIndex = 3;
            // 
            // 仓库名称
            // 
            this.仓库名称.Location = new System.Drawing.Point(98, 74);
            this.仓库名称.Name = "仓库名称";
            this.仓库名称.Size = new System.Drawing.Size(100, 21);
            this.仓库名称.TabIndex = 4;
            // 
            // 仓库备注
            // 
            this.仓库备注.Location = new System.Drawing.Point(98, 120);
            this.仓库备注.Multiline = true;
            this.仓库备注.Name = "仓库备注";
            this.仓库备注.Size = new System.Drawing.Size(100, 97);
            this.仓库备注.TabIndex = 5;
            // 
            // 确定添加
            // 
            this.确定添加.Location = new System.Drawing.Point(31, 266);
            this.确定添加.Name = "确定添加";
            this.确定添加.Size = new System.Drawing.Size(75, 23);
            this.确定添加.TabIndex = 6;
            this.确定添加.Text = "确定";
            this.确定添加.UseVisualStyleBackColor = true;
            // 
            // 取消添加
            // 
            this.取消添加.Location = new System.Drawing.Point(163, 266);
            this.取消添加.Name = "取消添加";
            this.取消添加.Size = new System.Drawing.Size(75, 23);
            this.取消添加.TabIndex = 7;
            this.取消添加.Text = "取消";
            this.取消添加.UseVisualStyleBackColor = true;
            // 
            // 仓库信息管理添加
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 316);
            this.Controls.Add(this.取消添加);
            this.Controls.Add(this.确定添加);
            this.Controls.Add(this.仓库备注);
            this.Controls.Add(this.仓库名称);
            this.Controls.Add(this.仓库编号);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "仓库信息管理添加";
            this.Text = "仓库信息管理添加";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox 仓库编号;
        private System.Windows.Forms.TextBox 仓库名称;
        private System.Windows.Forms.TextBox 仓库备注;
        private System.Windows.Forms.Button 确定添加;
        private System.Windows.Forms.Button 取消添加;
    }
}