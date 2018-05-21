namespace 装备库存管理
{
    partial class 装备信息管理删除
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
            this.仓库编号 = new System.Windows.Forms.Label();
            this.仓库名称 = new System.Windows.Forms.Label();
            this.仓库备注 = new System.Windows.Forms.Label();
            this.仓库编号显示 = new System.Windows.Forms.Label();
            this.仓库名称显示 = new System.Windows.Forms.Label();
            this.仓库备注显示 = new System.Windows.Forms.Label();
            this.确定删除 = new System.Windows.Forms.Button();
            this.取消删除 = new System.Windows.Forms.Button();
            this.提示信息 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // 仓库编号
            // 
            this.仓库编号.AutoSize = true;
            this.仓库编号.Location = new System.Drawing.Point(33, 36);
            this.仓库编号.Name = "仓库编号";
            this.仓库编号.Size = new System.Drawing.Size(53, 12);
            this.仓库编号.TabIndex = 0;
            this.仓库编号.Text = "仓库编号";
            // 
            // 仓库名称
            // 
            this.仓库名称.AutoSize = true;
            this.仓库名称.Location = new System.Drawing.Point(33, 79);
            this.仓库名称.Name = "仓库名称";
            this.仓库名称.Size = new System.Drawing.Size(53, 12);
            this.仓库名称.TabIndex = 1;
            this.仓库名称.Text = "仓库名称";
            // 
            // 仓库备注
            // 
            this.仓库备注.AutoSize = true;
            this.仓库备注.Location = new System.Drawing.Point(33, 121);
            this.仓库备注.Name = "仓库备注";
            this.仓库备注.Size = new System.Drawing.Size(53, 12);
            this.仓库备注.TabIndex = 2;
            this.仓库备注.Text = "仓库备注";
            // 
            // 仓库编号显示
            // 
            this.仓库编号显示.AutoSize = true;
            this.仓库编号显示.Location = new System.Drawing.Point(109, 36);
            this.仓库编号显示.Name = "仓库编号显示";
            this.仓库编号显示.Size = new System.Drawing.Size(41, 12);
            this.仓库编号显示.TabIndex = 3;
            this.仓库编号显示.Text = "label1";
            // 
            // 仓库名称显示
            // 
            this.仓库名称显示.AutoSize = true;
            this.仓库名称显示.Location = new System.Drawing.Point(109, 79);
            this.仓库名称显示.Name = "仓库名称显示";
            this.仓库名称显示.Size = new System.Drawing.Size(41, 12);
            this.仓库名称显示.TabIndex = 4;
            this.仓库名称显示.Text = "label2";
            // 
            // 仓库备注显示
            // 
            this.仓库备注显示.Location = new System.Drawing.Point(109, 121);
            this.仓库备注显示.Name = "仓库备注显示";
            this.仓库备注显示.Size = new System.Drawing.Size(87, 117);
            this.仓库备注显示.TabIndex = 5;
            this.仓库备注显示.Text = "label3";
            // 
            // 确定删除
            // 
            this.确定删除.Location = new System.Drawing.Point(25, 259);
            this.确定删除.Name = "确定删除";
            this.确定删除.Size = new System.Drawing.Size(75, 23);
            this.确定删除.TabIndex = 6;
            this.确定删除.Text = "确定";
            this.确定删除.UseVisualStyleBackColor = true;
            // 
            // 取消删除
            // 
            this.取消删除.Location = new System.Drawing.Point(153, 259);
            this.取消删除.Name = "取消删除";
            this.取消删除.Size = new System.Drawing.Size(75, 23);
            this.取消删除.TabIndex = 7;
            this.取消删除.Text = "取消";
            this.取消删除.UseVisualStyleBackColor = true;
            // 
            // 提示信息
            // 
            this.提示信息.Location = new System.Drawing.Point(33, 215);
            this.提示信息.Name = "提示信息";
            this.提示信息.Size = new System.Drawing.Size(163, 23);
            this.提示信息.TabIndex = 8;
            this.提示信息.Text = "是否删除该仓库信息？";
            this.提示信息.Click += new System.EventHandler(this.提示信息_Click);
            // 
            // 装备信息管理删除
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 319);
            this.Controls.Add(this.提示信息);
            this.Controls.Add(this.取消删除);
            this.Controls.Add(this.确定删除);
            this.Controls.Add(this.仓库备注显示);
            this.Controls.Add(this.仓库名称显示);
            this.Controls.Add(this.仓库编号显示);
            this.Controls.Add(this.仓库备注);
            this.Controls.Add(this.仓库名称);
            this.Controls.Add(this.仓库编号);
            this.Name = "装备信息管理删除";
            this.Text = "装备信息管理删除";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label 仓库编号;
        private System.Windows.Forms.Label 仓库名称;
        private System.Windows.Forms.Label 仓库备注;
        private System.Windows.Forms.Label 仓库编号显示;
        private System.Windows.Forms.Label 仓库名称显示;
        private System.Windows.Forms.Label 仓库备注显示;
        private System.Windows.Forms.Button 确定删除;
        private System.Windows.Forms.Button 取消删除;
        private System.Windows.Forms.Label 提示信息;
    }
}