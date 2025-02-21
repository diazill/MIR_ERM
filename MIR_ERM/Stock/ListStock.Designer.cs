namespace MIR_ERM.Stock
{
    partial class ListStock
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
            label1 = new Label();
            panel1 = new Panel();
            btnclose = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            dgvlistbarang = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvlistbarang).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(337, 62);
            label1.TabIndex = 0;
            label1.Text = "Daftar Barang";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnclose);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 446);
            panel1.Name = "panel1";
            panel1.Size = new Size(1311, 53);
            panel1.TabIndex = 1;
            // 
            // btnclose
            // 
            btnclose.Location = new Point(1205, 12);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(94, 29);
            btnclose.TabIndex = 9;
            btnclose.Text = "Close";
            btnclose.UseVisualStyleBackColor = true;
            btnclose.Click += btnclose_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1311, 80);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvlistbarang);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 80);
            panel3.Name = "panel3";
            panel3.Size = new Size(1311, 366);
            panel3.TabIndex = 3;
            // 
            // dgvlistbarang
            // 
            dgvlistbarang.AllowUserToAddRows = false;
            dgvlistbarang.AllowUserToDeleteRows = false;
            dgvlistbarang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvlistbarang.Dock = DockStyle.Fill;
            dgvlistbarang.Location = new Point(0, 0);
            dgvlistbarang.Name = "dgvlistbarang";
            dgvlistbarang.ReadOnly = true;
            dgvlistbarang.RowHeadersWidth = 51;
            dgvlistbarang.Size = new Size(1311, 366);
            dgvlistbarang.TabIndex = 0;
            dgvlistbarang.CellDoubleClick += dgvlistbarang_CellDoubleClick;
            // 
            // ListStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1311, 499);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ListStock";
            Text = "Daftar Barang";
            Load += ListStock_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvlistbarang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dgvlistbarang;
        private Button btnclose;
    }
}