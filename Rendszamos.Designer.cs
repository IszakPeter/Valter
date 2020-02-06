namespace _2020_01_17
{
    partial class Rendszamos
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Box1 = new System.Windows.Forms.TextBox();
            this.Box2 = new System.Windows.Forms.TextBox();
            this.Box3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Box4 = new System.Windows.Forms.TextBox();
            this.Box5 = new System.Windows.Forms.TextBox();
            this.Box6 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Box1);
            this.flowLayoutPanel1.Controls.Add(this.Box2);
            this.flowLayoutPanel1.Controls.Add(this.Box3);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.Box4);
            this.flowLayoutPanel1.Controls.Add(this.Box5);
            this.flowLayoutPanel1.Controls.Add(this.Box6);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(253, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(193, 30);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Box1
            // 
            this.Box1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Box1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Box1.Location = new System.Drawing.Point(3, 3);
            this.Box1.MaxLength = 1;
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(22, 23);
            this.Box1.TabIndex = 1;
            this.Box1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Nyomi);
            // 
            // Box2
            // 
            this.Box2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Box2.Location = new System.Drawing.Point(31, 3);
            this.Box2.MaxLength = 1;
            this.Box2.Name = "Box2";
            this.Box2.Size = new System.Drawing.Size(22, 23);
            this.Box2.TabIndex = 2;
            this.Box2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Nyomi);
            // 
            // Box3
            // 
            this.Box3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Box3.Location = new System.Drawing.Point(59, 3);
            this.Box3.MaxLength = 1;
            this.Box3.Name = "Box3";
            this.Box3.Size = new System.Drawing.Size(22, 23);
            this.Box3.TabIndex = 3;
            this.Box3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Nyomi);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(87, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "-";
            // 
            // Box4
            // 
            this.Box4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Box4.Location = new System.Drawing.Point(106, 3);
            this.Box4.MaxLength = 1;
            this.Box4.Name = "Box4";
            this.Box4.Size = new System.Drawing.Size(22, 23);
            this.Box4.TabIndex = 4;
            this.Box4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Nyomi);
            // 
            // Box5
            // 
            this.Box5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Box5.Location = new System.Drawing.Point(134, 3);
            this.Box5.MaxLength = 1;
            this.Box5.Name = "Box5";
            this.Box5.Size = new System.Drawing.Size(22, 23);
            this.Box5.TabIndex = 5;
            this.Box5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Nyomi);
            // 
            // Box6
            // 
            this.Box6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Box6.Location = new System.Drawing.Point(162, 3);
            this.Box6.MaxLength = 1;
            this.Box6.Name = "Box6";
            this.Box6.Size = new System.Drawing.Size(22, 23);
            this.Box6.TabIndex = 6;
            this.Box6.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Nyomi);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(785, 402);
            this.dataGridView1.TabIndex = 1;
            // 
            // Rendszamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Rendszamos";
            this.Text = "Rendszamos";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox Box1;
        private System.Windows.Forms.TextBox Box2;
        private System.Windows.Forms.TextBox Box3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Box4;
        private System.Windows.Forms.TextBox Box5;
        private System.Windows.Forms.TextBox Box6;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}