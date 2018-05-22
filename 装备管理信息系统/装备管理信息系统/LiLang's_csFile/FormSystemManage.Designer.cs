namespace 装备管理信息系统
{
    partial class FormSystemManage
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
            this.buttonUserManage = new System.Windows.Forms.Button();
            this.buttonPwdModify = new System.Windows.Forms.Button();
            this.buttonLogManage = new System.Windows.Forms.Button();
            this.buttonExitSystemManage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonUserManage
            // 
            this.buttonUserManage.Location = new System.Drawing.Point(61, 69);
            this.buttonUserManage.Name = "buttonUserManage";
            this.buttonUserManage.Size = new System.Drawing.Size(122, 81);
            this.buttonUserManage.TabIndex = 0;
            this.buttonUserManage.Text = "用户管理";
            this.buttonUserManage.UseVisualStyleBackColor = true;
            this.buttonUserManage.Click += new System.EventHandler(this.buttonUserManage_Click);
            // 
            // buttonPwdModify
            // 
            this.buttonPwdModify.Location = new System.Drawing.Point(281, 70);
            this.buttonPwdModify.Name = "buttonPwdModify";
            this.buttonPwdModify.Size = new System.Drawing.Size(128, 80);
            this.buttonPwdModify.TabIndex = 1;
            this.buttonPwdModify.Text = "修改密码";
            this.buttonPwdModify.UseVisualStyleBackColor = true;
            this.buttonPwdModify.Click += new System.EventHandler(this.buttonPwdModify_Click);
            // 
            // buttonLogManage
            // 
            this.buttonLogManage.Location = new System.Drawing.Point(61, 180);
            this.buttonLogManage.Name = "buttonLogManage";
            this.buttonLogManage.Size = new System.Drawing.Size(122, 86);
            this.buttonLogManage.TabIndex = 2;
            this.buttonLogManage.Text = "日志管理";
            this.buttonLogManage.UseVisualStyleBackColor = true;
            this.buttonLogManage.Click += new System.EventHandler(this.buttonLogManage_Click);
            // 
            // buttonExitSystemManage
            // 
            this.buttonExitSystemManage.Location = new System.Drawing.Point(281, 179);
            this.buttonExitSystemManage.Name = "buttonExitSystemManage";
            this.buttonExitSystemManage.Size = new System.Drawing.Size(128, 87);
            this.buttonExitSystemManage.TabIndex = 3;
            this.buttonExitSystemManage.Text = "退出系统";
            this.buttonExitSystemManage.UseVisualStyleBackColor = true;
            this.buttonExitSystemManage.Click += new System.EventHandler(this.buttonExitSystemManage_Click);
            // 
            // FormSystemManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 331);
            this.Controls.Add(this.buttonExitSystemManage);
            this.Controls.Add(this.buttonLogManage);
            this.Controls.Add(this.buttonPwdModify);
            this.Controls.Add(this.buttonUserManage);
            this.Name = "FormSystemManage";
            this.Text = "系统管理";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUserManage;
        private System.Windows.Forms.Button buttonPwdModify;
        private System.Windows.Forms.Button buttonLogManage;
        private System.Windows.Forms.Button buttonExitSystemManage;
    }
}