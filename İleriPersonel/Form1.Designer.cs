
namespace İleriPersonel
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tanımlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kişilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışanlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eğitmenlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrencilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şehirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilçeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eğitimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tanımlarToolStripMenuItem,
            this.kişilerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tanımlarToolStripMenuItem
            // 
            this.tanımlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şehirToolStripMenuItem,
            this.ilçeToolStripMenuItem,
            this.eğitimToolStripMenuItem});
            this.tanımlarToolStripMenuItem.Name = "tanımlarToolStripMenuItem";
            this.tanımlarToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.tanımlarToolStripMenuItem.Text = "Tanımlar";
            // 
            // kişilerToolStripMenuItem
            // 
            this.kişilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çalışanlarToolStripMenuItem,
            this.eğitmenlerToolStripMenuItem,
            this.öğrencilerToolStripMenuItem});
            this.kişilerToolStripMenuItem.Name = "kişilerToolStripMenuItem";
            this.kişilerToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.kişilerToolStripMenuItem.Text = "Kişiler";
            // 
            // çalışanlarToolStripMenuItem
            // 
            this.çalışanlarToolStripMenuItem.Name = "çalışanlarToolStripMenuItem";
            this.çalışanlarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.çalışanlarToolStripMenuItem.Text = "Çalışanlar";
            this.çalışanlarToolStripMenuItem.Click += new System.EventHandler(this.çalışanlarToolStripMenuItem_Click);
            // 
            // eğitmenlerToolStripMenuItem
            // 
            this.eğitmenlerToolStripMenuItem.Name = "eğitmenlerToolStripMenuItem";
            this.eğitmenlerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eğitmenlerToolStripMenuItem.Text = "Eğitmenler";
            // 
            // öğrencilerToolStripMenuItem
            // 
            this.öğrencilerToolStripMenuItem.Name = "öğrencilerToolStripMenuItem";
            this.öğrencilerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.öğrencilerToolStripMenuItem.Text = "Öğrenciler";
            // 
            // şehirToolStripMenuItem
            // 
            this.şehirToolStripMenuItem.Name = "şehirToolStripMenuItem";
            this.şehirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.şehirToolStripMenuItem.Text = "Şehir";
            // 
            // ilçeToolStripMenuItem
            // 
            this.ilçeToolStripMenuItem.Name = "ilçeToolStripMenuItem";
            this.ilçeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ilçeToolStripMenuItem.Text = "İlçe";
            // 
            // eğitimToolStripMenuItem
            // 
            this.eğitimToolStripMenuItem.Name = "eğitimToolStripMenuItem";
            this.eğitimToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eğitimToolStripMenuItem.Text = "Eğitim";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tanımlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şehirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilçeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eğitimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kişilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çalışanlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eğitmenlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrencilerToolStripMenuItem;
    }
}

