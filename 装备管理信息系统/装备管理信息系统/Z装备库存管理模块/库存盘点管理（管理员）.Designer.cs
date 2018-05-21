namespace 装备库存管理
{
    partial class 库存盘点管理
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
            this.选择仓库 = new System.Windows.Forms.ComboBox();
            this.装备类别 = new System.Windows.Forms.ComboBox();
            this.装备名称 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.盘点 = new System.Windows.Forms.Button();
            this.取消 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择仓库";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "装备类别";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "装备名称";
            // 
            // 选择仓库
            // 
            this.选择仓库.FormattingEnabled = true;
            this.选择仓库.Location = new System.Drawing.Point(97, 27);
            this.选择仓库.Name = "选择仓库";
            this.选择仓库.Size = new System.Drawing.Size(121, 20);
            this.选择仓库.TabIndex = 3;
            // 
            // 装备类别
            // 
            this.装备类别.FormattingEnabled = true;
            this.装备类别.Location = new System.Drawing.Point(308, 27);
            this.装备类别.Name = "装备类别";
            this.装备类别.Size = new System.Drawing.Size(121, 20);
            this.装备类别.TabIndex = 4;
            // 
            // 装备名称
            // 
            this.装备名称.FormattingEnabled = true;
            this.装备名称.Location = new System.Drawing.Point(542, 27);
            this.装备名称.Name = "装备名称";
            this.装备名称.Size = new System.Drawing.Size(121, 20);
            this.装备名称.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(639, 249);
            this.dataGridView1.TabIndex = 6;
            // 
            // 盘点
            // 
            this.盘点.Location = new System.Drawing.Point(147, 353);
            this.盘点.Name = "盘点";
            this.盘点.Size = new System.Drawing.Size(89, 38);
            this.盘点.TabIndex = 7;
            this.盘点.Text = "盘点";
            this.盘点.UseVisualStyleBackColor = true;
            // 
            // 取消
            // 
            this.取消.Location = new System.Drawing.Point(430, 353);
            this.取消.Name = "取消";
            this.取消.Size = new System.Drawing.Size(89, 38);
            this.取消.TabIndex = 8;
            this.取消.Text = "取消";
            this.取消.UseVisualStyleBackColor = true;
            // 
            // 库存盘点管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 403);
            this.Controls.Add(this.取消);
            this.Controls.Add(this.盘点);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.装备名称);
            this.Controls.Add(this.装备类别);
            this.Controls.Add(this.选择仓库);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "库存盘点管理";
            this.Text = "库存盘点管理";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox 选择仓库;
        private System.Windows.Forms.ComboBox 装备类别;
        private System.Windows.Forms.ComboBox 装备名称;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button 盘点;
        private System.Windows.Forms.Button 取消;
    }
}