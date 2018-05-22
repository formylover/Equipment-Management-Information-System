namespace 装备管理信息系统
{
    partial class FormArmsRepairAdd
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxArmsName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxUnitName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxRepairManName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxConfirmManName = new System.Windows.Forms.ComboBox();
            this.textBoxReason = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonMyCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "装备名称";
            // 
            // comboBoxArmsName
            // 
            this.comboBoxArmsName.FormattingEnabled = true;
            this.comboBoxArmsName.Location = new System.Drawing.Point(128, 30);
            this.comboBoxArmsName.Name = "comboBoxArmsName";
            this.comboBoxArmsName.Size = new System.Drawing.Size(121, 23);
            this.comboBoxArmsName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "维修单位";
            // 
            // comboBoxUnitName
            // 
            this.comboBoxUnitName.FormattingEnabled = true;
            this.comboBoxUnitName.Location = new System.Drawing.Point(128, 81);
            this.comboBoxUnitName.Name = "comboBoxUnitName";
            this.comboBoxUnitName.Size = new System.Drawing.Size(121, 23);
            this.comboBoxUnitName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "*维修负责人";
            // 
            // comboBoxRepairManName
            // 
            this.comboBoxRepairManName.FormattingEnabled = true;
            this.comboBoxRepairManName.Location = new System.Drawing.Point(404, 30);
            this.comboBoxRepairManName.Name = "comboBoxRepairManName";
            this.comboBoxRepairManName.Size = new System.Drawing.Size(121, 23);
            this.comboBoxRepairManName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "*送修验收人";
            // 
            // comboBoxConfirmManName
            // 
            this.comboBoxConfirmManName.FormattingEnabled = true;
            this.comboBoxConfirmManName.Location = new System.Drawing.Point(404, 80);
            this.comboBoxConfirmManName.Name = "comboBoxConfirmManName";
            this.comboBoxConfirmManName.Size = new System.Drawing.Size(121, 23);
            this.comboBoxConfirmManName.TabIndex = 8;
            // 
            // textBoxReason
            // 
            this.textBoxReason.Location = new System.Drawing.Point(136, 131);
            this.textBoxReason.Multiline = true;
            this.textBoxReason.Name = "textBoxReason";
            this.textBoxReason.Size = new System.Drawing.Size(389, 120);
            this.textBoxReason.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "*故障原因";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "注：含*的选项可以不选择";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(103, 317);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(135, 39);
            this.buttonConfirm.TabIndex = 12;
            this.buttonConfirm.Text = "确认";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            // 
            // buttonMyCancel
            // 
            this.buttonMyCancel.Location = new System.Drawing.Point(311, 317);
            this.buttonMyCancel.Name = "buttonMyCancel";
            this.buttonMyCancel.Size = new System.Drawing.Size(139, 39);
            this.buttonMyCancel.TabIndex = 13;
            this.buttonMyCancel.Text = "取消";
            this.buttonMyCancel.UseVisualStyleBackColor = true;
            this.buttonMyCancel.Click += new System.EventHandler(this.buttonMyCancel_Click);
            // 
            // FormArmsRepairAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 382);
            this.Controls.Add(this.buttonMyCancel);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxReason);
            this.Controls.Add(this.comboBoxConfirmManName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxRepairManName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxUnitName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxArmsName);
            this.Controls.Add(this.label2);
            this.Name = "FormArmsRepairAdd";
            this.Text = "装备修理信息添加";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxArmsName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxUnitName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxRepairManName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxConfirmManName;
        private System.Windows.Forms.TextBox textBoxReason;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonMyCancel;
    }
}