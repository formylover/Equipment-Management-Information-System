namespace 装备管理信息系统.LiLang_s_csFile
{
    partial class FormRepairFinishConfirm
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
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonMyCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxConfirmManName = new System.Windows.Forms.ComboBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "维修结果";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(121, 39);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(121, 23);
            this.comboBoxStatus.TabIndex = 1;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(51, 199);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 44);
            this.buttonConfirm.TabIndex = 2;
            this.buttonConfirm.Text = "确认";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            // 
            // buttonMyCancel
            // 
            this.buttonMyCancel.Location = new System.Drawing.Point(167, 199);
            this.buttonMyCancel.Name = "buttonMyCancel";
            this.buttonMyCancel.Size = new System.Drawing.Size(75, 44);
            this.buttonMyCancel.TabIndex = 3;
            this.buttonMyCancel.Text = "取消";
            this.buttonMyCancel.UseVisualStyleBackColor = true;
            this.buttonMyCancel.Click += new System.EventHandler(this.buttonMyCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "维修费用";
            // 
            // comboBoxConfirmManName
            // 
            this.comboBoxConfirmManName.FormattingEnabled = true;
            this.comboBoxConfirmManName.Location = new System.Drawing.Point(121, 140);
            this.comboBoxConfirmManName.Name = "comboBoxConfirmManName";
            this.comboBoxConfirmManName.Size = new System.Drawing.Size(121, 23);
            this.comboBoxConfirmManName.TabIndex = 5;
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(121, 87);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(121, 25);
            this.textBoxCost.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "验收人";
            // 
            // FormRepairFinishConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 276);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.comboBoxConfirmManName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonMyCancel);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.label1);
            this.Name = "FormRepairFinishConfirm";
            this.Text = "维修完成";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonMyCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxConfirmManName;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Label label3;
    }
}