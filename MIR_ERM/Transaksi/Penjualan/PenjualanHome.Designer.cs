namespace MIR_ERM.Transaksi.Penjualan
{
    partial class PenjualanHome
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
            panel1 = new Panel();
            panel2 = new Panel();
            txtkodebarang = new TextBox();
            panel3 = new Panel();
            dgvDaftarBarang = new DataGridView();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDaftarBarang).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 608);
            panel1.Name = "panel1";
            panel1.Size = new Size(1322, 125);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtkodebarang);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1322, 125);
            panel2.TabIndex = 1;
            // 
            // txtkodebarang
            // 
            txtkodebarang.Location = new Point(12, 82);
            txtkodebarang.Name = "txtkodebarang";
            txtkodebarang.Size = new Size(381, 27);
            txtkodebarang.TabIndex = 0;
            txtkodebarang.TextChanged += txtkodebarang_TextChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvDaftarBarang);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 125);
            panel3.Name = "panel3";
            panel3.Size = new Size(1322, 483);
            panel3.TabIndex = 2;
            // 
            // dgvDaftarBarang
            // 
            dgvDaftarBarang.AllowUserToAddRows = false;
            dgvDaftarBarang.AllowUserToDeleteRows = false;
            dgvDaftarBarang.AllowUserToOrderColumns = true;
            dgvDaftarBarang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDaftarBarang.Dock = DockStyle.Fill;
            dgvDaftarBarang.Location = new Point(0, 0);
            dgvDaftarBarang.Name = "dgvDaftarBarang";
            dgvDaftarBarang.ReadOnly = true;
            dgvDaftarBarang.RowHeadersVisible = false;
            dgvDaftarBarang.RowHeadersWidth = 51;
            dgvDaftarBarang.Size = new Size(1322, 483);
            dgvDaftarBarang.TabIndex = 1;
            // 
            // PenjualanHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1322, 733);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "PenjualanHome";
            Text = "Penjualan";
            Load += PenjualanHome_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDaftarBarang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox txtkodebarang;
        private DataGridView dgvDaftarBarang;
    }
}