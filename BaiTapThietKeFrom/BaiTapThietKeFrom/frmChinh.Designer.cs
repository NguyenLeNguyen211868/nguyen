namespace BaiTapThietKeFrom
{
    partial class frmChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChinh));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.nguyễnLêNguyênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiBai1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiBai2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiBai3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBai4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nguyễnLêNguyênToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // nguyễnLêNguyênToolStripMenuItem
            // 
            this.nguyễnLêNguyênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsiBai1,
            this.tmsiBai2,
            this.tmsiBai3,
            this.tsmiBai4});
            this.nguyễnLêNguyênToolStripMenuItem.Name = "nguyễnLêNguyênToolStripMenuItem";
            this.nguyễnLêNguyênToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.nguyễnLêNguyênToolStripMenuItem.Text = "Nguyễn Lê Nguyên";
            // 
            // tmsiBai1
            // 
            this.tmsiBai1.Image = ((System.Drawing.Image)(resources.GetObject("tmsiBai1.Image")));
            this.tmsiBai1.Name = "tmsiBai1";
            this.tmsiBai1.Size = new System.Drawing.Size(224, 26);
            this.tmsiBai1.Text = "Bài 1";
            this.tmsiBai1.Click += new System.EventHandler(this.tmsiBai1_Click);
            // 
            // tmsiBai2
            // 
            this.tmsiBai2.Image = ((System.Drawing.Image)(resources.GetObject("tmsiBai2.Image")));
            this.tmsiBai2.Name = "tmsiBai2";
            this.tmsiBai2.Size = new System.Drawing.Size(224, 26);
            this.tmsiBai2.Text = "Bài 2";
            this.tmsiBai2.Click += new System.EventHandler(this.tmsiBai2_Click);
            // 
            // tmsiBai3
            // 
            this.tmsiBai3.Image = ((System.Drawing.Image)(resources.GetObject("tmsiBai3.Image")));
            this.tmsiBai3.Name = "tmsiBai3";
            this.tmsiBai3.Size = new System.Drawing.Size(224, 26);
            this.tmsiBai3.Text = "Bài 3";
            this.tmsiBai3.Click += new System.EventHandler(this.tmsiBai3_Click);
            // 
            // tsmiBai4
            // 
            this.tsmiBai4.Name = "tsmiBai4";
            this.tsmiBai4.Size = new System.Drawing.Size(224, 26);
            this.tsmiBai4.Text = "Bài 4";
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmChinh";
            this.Text = "Chương Trình Chính";
            this.Load += new System.EventHandler(this.frmChinh_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem nguyễnLêNguyênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tmsiBai1;
        private System.Windows.Forms.ToolStripMenuItem tmsiBai2;
        private System.Windows.Forms.ToolStripMenuItem tmsiBai3;
        private System.Windows.Forms.ToolStripMenuItem tsmiBai4;
    }
}

