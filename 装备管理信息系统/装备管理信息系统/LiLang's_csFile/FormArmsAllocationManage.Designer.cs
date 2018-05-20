namespace 装备管理信息系统
{
    partial class FormArmsAllocationManage
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
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxSelectUnit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSelectDate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewArmsRepair = new System.Windows.Forms.DataGridView();
            this.comboBoxSelectArms = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMyCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArmsRepair)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(445, 362);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(106, 48);
            this.buttonModify.TabIndex = 20;
            this.buttonModify.Text = "修改";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(239, 362);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(104, 48);
            this.buttonDelete.TabIndex = 19;
            this.buttonDelete.Text = "删除";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(48, 362);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(107, 48);
            this.buttonAdd.TabIndex = 18;
            this.buttonAdd.Text = "添加";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBoxSelectUnit
            // 
            this.comboBoxSelectUnit.FormattingEnabled = true;
            this.comboBoxSelectUnit.Location = new System.Drawing.Point(641, 41);
            this.comboBoxSelectUnit.Name = "comboBoxSelectUnit";
            this.comboBoxSelectUnit.Size = new System.Drawing.Size(121, 23);
            this.comboBoxSelectUnit.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(493, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "选择拨出或拨入单位";
            // 
            // comboBoxSelectDate
            // 
            this.comboBoxSelectDate.FormattingEnabled = true;
            this.comboBoxSelectDate.Location = new System.Drawing.Point(338, 41);
            this.comboBoxSelectDate.Name = "comboBoxSelectDate";
            this.comboBoxSelectDate.Size = new System.Drawing.Size(121, 23);
            this.comboBoxSelectDate.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "选择日期";
            // 
            // dataGridViewArmsRepair
            // 
            this.dataGridViewArmsRepair.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArmsRepair.Location = new System.Drawing.Point(48, 96);
            this.dataGridViewArmsRepair.Name = "dataGridViewArmsRepair";
            this.dataGridViewArmsRepair.RowTemplate.Height = 27;
            this.dataGridViewArmsRepair.Size = new System.Drawing.Size(708, 233);
            this.dataGridViewArmsRepair.TabIndex = 13;
            // 
            // comboBoxSelectArms
            // 
            this.comboBoxSelectArms.FormattingEnabled = true;
            this.comboBoxSelectArms.Location = new System.Drawing.Point(118, 41);
            this.comboBoxSelectArms.Name = "comboBoxSelectArms";
            this.comboBoxSelectArms.Size = new System.Drawing.Size(121, 23);
            this.comboBoxSelectArms.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "选择装备";
            // 
            // buttonMyCancel
            // 
            this.buttonMyCancel.Location = new System.Drawing.Point(641, 362);
            this.buttonMyCancel.Name = "buttonMyCancel";
            this.buttonMyCancel.Size = new System.Drawing.Size(115, 48);
            this.buttonMyCancel.TabIndex = 21;
            this.buttonMyCancel.Text = "取消";
            this.buttonMyCancel.UseVisualStyleBackColor = true;
            this.buttonMyCancel.Click += new System.EventHandler(this.buttonMyCancel_Click);
            // 
            // FormArmsAllocationManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMyCancel);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxSelectUnit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxSelectDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewArmsRepair);
            this.Controls.Add(this.comboBoxSelectArms);
            this.Controls.Add(this.label1);
            this.Name = "FormArmsAllocationManage";
            this.Text = "装备调拨管理";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArmsRepair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBoxSelectUnit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSelectDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewArmsRepair;
        private System.Windows.Forms.ComboBox comboBoxSelectArms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMyCancel;
    }
}