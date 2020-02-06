namespace _2020_01_17
{
    partial class megyes
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.barPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.barText = new System.Windows.Forms.Label();
            this.bar = new System.Windows.Forms.ProgressBar();
            this.panel2.SuspendLayout();
            this.barPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(-1, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(165, 450);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(170, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 450);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.barPanel);
            this.panel2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1095, 450);
            this.panel2.TabIndex = 0;
            this.panel2.Visible = false;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // barPanel
            // 
            this.barPanel.AutoSize = true;
            this.barPanel.Controls.Add(this.barText);
            this.barPanel.Controls.Add(this.bar);
            this.barPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.barPanel.Location = new System.Drawing.Point(337, 145);
            this.barPanel.Name = "barPanel";
            this.barPanel.Size = new System.Drawing.Size(159, 43);
            this.barPanel.TabIndex = 1;
            // 
            // barText
            // 
            this.barText.AutoSize = true;
            this.barText.Location = new System.Drawing.Point(3, 0);
            this.barText.Name = "barText";
            this.barText.Size = new System.Drawing.Size(153, 13);
            this.barText.TabIndex = 1;
            this.barText.Text = "Adatok lekérése folyamatban...";
            // 
            // bar
            // 
            this.bar.Location = new System.Drawing.Point(3, 16);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(100, 23);
            this.bar.TabIndex = 0;
            // 
            // megyes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox1);
            this.MaximizeBox = false;
            this.Name = "megyes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "megyes";
            this.Load += new System.EventHandler(this.megyes_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.barPanel.ResumeLayout(false);
            this.barPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar bar;
        private System.Windows.Forms.FlowLayoutPanel barPanel;
        private System.Windows.Forms.Label barText;
    }
}