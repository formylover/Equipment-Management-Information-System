namespace 装备管理信息系统
{
    partial class FormArmsRepairAndAllocation
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
            this.buttonArmsRepair = new System.Windows.Forms.Button();
            this.buttonArmsAllocation = new System.Windows.Forms.Button();
            this.buttonExitArmsRepairAndAllocation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonArmsRepair
            // 
            this.buttonArmsRepair.Location = new System.Drawing.Point(69, 64);
            this.buttonArmsRepair.Name = "buttonArmsRepair";
            this.buttonArmsRepair.Size = new System.Drawing.Size(187, 67);
            this.buttonArmsRepair.TabIndex = 0;
            this.buttonArmsRepair.Text = "装备维修信息管理";
            this.buttonArmsRepair.UseVisualStyleBackColor = true;
            this.buttonArmsRepair.Click += new System.EventHandler(this.buttonArmsRepair_Click);
            // 
            // buttonArmsAllocation
            // 
            this.buttonArmsAllocation.Location = new System.Drawing.Point(69, 164);
            this.buttonArmsAllocation.Name = "buttonArmsAllocation";
            this.buttonArmsAllocation.Size = new System.Drawing.Size(187, 71);
            this.buttonArmsAllocation.TabIndex = 1;
            this.buttonArmsAllocation.Text = "装备调拨信息管理";
            this.buttonArmsAllocation.UseVisualStyleBackColor = true;
            this.buttonArmsAllocation.Click += new System.EventHandler(this.buttonArmsAllocation_Click);
            // 
            // buttonExitArmsRepairAndAllocation
            // 
            this.buttonExitArmsRepairAndAllocation.Location = new System.Drawing.Point(69, 273);
            this.buttonExitArmsRepairAndAllocation.Name = "buttonExitArmsRepairAndAllocation";
            this.buttonExitArmsRepairAndAllocation.Size = new System.Drawing.Size(187, 71);
            this.buttonExitArmsRepairAndAllocation.TabIndex = 2;
            this.buttonExitArmsRepairAndAllocation.Text = "退出装备维修与调拨";
            this.buttonExitArmsRepairAndAllocation.UseVisualStyleBackColor = true;
            this.buttonExitArmsRepairAndAllocation.Click += new System.EventHandler(this.buttonExitArmsRepairAndAllocation_Click);
            // 
            // FormArmsRepairAndAllocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 404);
            this.Controls.Add(this.buttonExitArmsRepairAndAllocation);
            this.Controls.Add(this.buttonArmsAllocation);
            this.Controls.Add(this.buttonArmsRepair);
            this.Name = "FormArmsRepairAndAllocation";
            this.Text = "装备维修与调拨";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonArmsRepair;
        private System.Windows.Forms.Button buttonArmsAllocation;
        private System.Windows.Forms.Button buttonExitArmsRepairAndAllocation;
    }
}