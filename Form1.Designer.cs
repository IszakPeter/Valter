namespace _2020_01_17
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.tablak_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.emberekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magyaesnem = new System.Windows.Forms.ToolStripMenuItem();
            this.személyesAdatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aUTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mIAPÖCSÖMÖCSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablak_menu,
            this.emberekToolStripMenuItem,
            this.autosToolStripMenuItem,
            this.aUTOToolStripMenuItem});
            this.menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(700, 29);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip2";
            // 
            // tablak_menu
            // 
            this.tablak_menu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tablak_menu.Name = "tablak_menu";
            this.tablak_menu.Size = new System.Drawing.Size(65, 25);
            this.tablak_menu.Text = "Táblák";
            this.tablak_menu.Click += new System.EventHandler(this.tablak_menu_Click);
            // 
            // emberekToolStripMenuItem
            // 
            this.emberekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.magyaesnem,
            this.személyesAdatoToolStripMenuItem});
            this.emberekToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.emberekToolStripMenuItem.Name = "emberekToolStripMenuItem";
            this.emberekToolStripMenuItem.Size = new System.Drawing.Size(83, 25);
            this.emberekToolStripMenuItem.Text = "Emberek";
            // 
            // magyaesnem
            // 
            this.magyaesnem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.magyaesnem.Name = "magyaesnem";
            this.magyaesnem.Size = new System.Drawing.Size(189, 24);
            this.magyaesnem.Text = "megyék és nemek";
            this.magyaesnem.Click += new System.EventHandler(this.magyaesnem_Click);
            // 
            // személyesAdatoToolStripMenuItem
            // 
            this.személyesAdatoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.személyesAdatoToolStripMenuItem.Name = "személyesAdatoToolStripMenuItem";
            this.személyesAdatoToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.személyesAdatoToolStripMenuItem.Text = "személyes adatok";
            this.személyesAdatoToolStripMenuItem.Click += new System.EventHandler(this.személyesAdatoToolStripMenuItem_Click);
            // 
            // autosToolStripMenuItem
            // 
            this.autosToolStripMenuItem.Name = "autosToolStripMenuItem";
            this.autosToolStripMenuItem.Size = new System.Drawing.Size(50, 25);
            this.autosToolStripMenuItem.Text = "Autos";
            // 
            // aUTOToolStripMenuItem
            // 
            this.aUTOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mIAPÖCSÖMÖCSEToolStripMenuItem});
            this.aUTOToolStripMenuItem.Name = "aUTOToolStripMenuItem";
            this.aUTOToolStripMenuItem.Size = new System.Drawing.Size(50, 25);
            this.aUTOToolStripMenuItem.Text = "AUTO";
            // 
            // mIAPÖCSÖMÖCSEToolStripMenuItem
            // 
            this.mIAPÖCSÖMÖCSEToolStripMenuItem.Name = "mIAPÖCSÖMÖCSEToolStripMenuItem";
            this.mIAPÖCSÖMÖCSEToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.mIAPÖCSÖMÖCSEToolStripMenuItem.Text = "MI A PÖCSÖMÖCSE";
            this.mIAPÖCSÖMÖCSEToolStripMenuItem.Click += new System.EventHandler(this.mIAPÖCSÖMÖCSEToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(700, 519);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menu);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ablak";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem tablak_menu;
        private System.Windows.Forms.ToolStripMenuItem emberekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem magyaesnem;
        private System.Windows.Forms.ToolStripMenuItem személyesAdatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aUTOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mIAPÖCSÖMÖCSEToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

