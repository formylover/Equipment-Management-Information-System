namespace 装备管理信息系统
{
    partial class FormLogManage
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
            this.comboBoxSelectGenre = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSelectDate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSelectUser = new System.Windows.Forms.ComboBox();
            this.dataGridViewLog = new System.Windows.Forms.DataGridView();
            this.buttonDeleteOneByOne = new System.Windows.Forms.Button();
            this.buttonDeleteTheDay = new System.Windows.Forms.Button();
            this.buttonDeleteAll = new System.Windows.Forms.Button();
            this.buttonMyCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLog)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSelectGenre
            // 
            this.comboBoxSelectGenre.FormattingEnabled = true;
            this.comboBoxSelectGenre.Location = new System.Drawing.Point(95, 38);
            this.comboBoxSelectGenre.Name = "comboBoxSelectGenre";
            this.comboBoxSelectGenre.Size = new System.Drawing.Size(121, 23);
            this.comboBoxSelectGenre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "选择类别";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "选择日期";
            // 
            // comboBoxSelectDate
            // 
            this.comboBoxSelectDate.FormattingEnabled = true;
            this.comboBoxSelectDate.Location = new System.Drawing.Point(307, 38);
            this.comboBoxSelectDate.Name = "comboBoxSelectDate";
            this.comboBoxSelectDate.Size = new System.Drawing.Size(121, 23);
            this.comboBoxSelectDate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(461, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "选择用户";
            // 
            // comboBoxSelectUser
            // 
            this.comboBoxSelectUser.FormattingEnabled = true;
            this.comboBoxSelectUser.Location = new System.Drawing.Point(535, 38);
            this.comboBoxSelectUser.Name = "comboBoxSelectUser";
            this.comboBoxSelectUser.Size = new System.Drawing.Size(121, 23);
            this.comboBoxSelectUser.TabIndex = 5;
            // 
            // dataGridViewLog
            // 
            this.dataGridViewLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLog.Location = new System.Drawing.Point(25, 84);
            this.dataGridViewLog.Name = "dataGridViewLog";
            this.dataGridViewLog.RowTemplate.Height = 27;
            this.dataGridViewLog.Size = new System.Drawing.Size(631, 195);
            this.dataGridViewLog.TabIndex = 6;
            // 
            // buttonDeleteOneByOne
            // 
            this.buttonDeleteOneByOne.Location = new System.Drawing.Point(25, 297);
            this.buttonDeleteOneByOne.Name = "buttonDeleteOneByOne";
            this.buttonDeleteOneByOne.Size = new System.Drawing.Size(92, 53);
            this.buttonDeleteOneByOne.TabIndex = 7;
            this.buttonDeleteOneByOne.Text = "逐个删除";
            this.buttonDeleteOneByOne.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteTheDay
            // 
            this.buttonDeleteTheDay.Location = new System.Drawing.Point(199, 297);
            this.buttonDeleteTheDay.Name = "buttonDeleteTheDay";
            this.buttonDeleteTheDay.Size = new System.Drawing.Size(102, 53);
            this.buttonDeleteTheDay.TabIndex = 8;
            this.buttonDeleteTheDay.Text = "全天删除";
            this.buttonDeleteTheDay.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteAll
            // 
            this.buttonDeleteAll.Location = new System.Drawing.Point(390, 297);
            this.buttonDeleteAll.Name = "buttonDeleteAll";
            this.buttonDeleteAll.Size = new System.Drawing.Size(92, 53);
            this.buttonDeleteAll.TabIndex = 9;
            this.buttonDeleteAll.Text = "全部删除";
            this.buttonDeleteAll.UseVisualStyleBackColor = true;
            // 
            // buttonMyCancel
            // 
            this.buttonMyCancel.Location = new System.Drawing.Point(559, 297);
            this.buttonMyCancel.Name = "buttonMyCancel";
            this.buttonMyCancel.Size = new System.Drawing.Size(97, 53);
            this.buttonMyCancel.TabIndex = 10;
            this.buttonMyCancel.Text = "取消";
            this.buttonMyCancel.UseVisualStyleBackColor = true;
            // 
            // FormLogManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 383);
            this.Controls.Add(this.buttonMyCancel);
            this.Controls.Add(this.buttonDeleteAll);
            this.Controls.Add(this.buttonDeleteTheDay);
            this.Controls.Add(this.buttonDeleteOneByOne);
            this.Controls.Add(this.dataGridViewLog);
            this.Controls.Add(this.comboBoxSelectUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxSelectDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSelectGenre);
            this.Name = "FormLogManage";
            this.Text = "日志管理";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSelectGenre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSelectDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSelectUser;
        private System.Windows.Forms.DataGridView dataGridViewLog;
        private System.Windows.Forms.Button buttonDeleteOneByOne;
        private System.Windows.Forms.Button buttonDeleteTheDay;
        private System.Windows.Forms.Button buttonDeleteAll;
        private System.Windows.Forms.Button buttonMyCancel;
    }
}