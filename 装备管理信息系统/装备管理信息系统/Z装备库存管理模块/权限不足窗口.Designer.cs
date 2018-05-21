namespace 装备库存管理
{
    partial class 权限不足窗口
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
            this.权限不足窗口确定 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(47, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "对不起！         您不是系统管理员   不能进行此操作！";
            // 
            // 权限不足窗口确定
            // 
            this.权限不足窗口确定.Location = new System.Drawing.Point(49, 102);
            this.权限不足窗口确定.Name = "权限不足窗口确定";
            this.权限不足窗口确定.Size = new System.Drawing.Size(75, 23);
            this.权限不足窗口确定.TabIndex = 1;
            this.权限不足窗口确定.Text = "确定";
            this.权限不足窗口确定.UseVisualStyleBackColor = true;
            // 
            // 权限不足窗口
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 149);
            this.Controls.Add(this.权限不足窗口确定);
            this.Controls.Add(this.label1);
            this.Name = "权限不足窗口";
            this.Text = "权限不足窗口";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button 权限不足窗口确定;
    }
}