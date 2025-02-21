namespace MIR_ERM.Home
{
    partial class Home
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            transaksiToolStripMenuItem = new ToolStripMenuItem();
            penjualanToolStripMenuItem = new ToolStripMenuItem();
            stockToolStripMenuItem = new ToolStripMenuItem();
            inputBarangToolStripMenuItem = new ToolStripMenuItem();
            daftarBarangToolStripMenuItem = new ToolStripMenuItem();
            settingToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            lbljam = new Label();
            panel2 = new Panel();
            dgvStockHome = new DataGridView();
            timer1 = new System.Windows.Forms.Timer(components);
            btn_refresh = new Button();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStockHome).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, transaksiToolStripMenuItem, stockToolStripMenuItem, settingToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(64, 24);
            homeToolStripMenuItem.Text = "Home";
            // 
            // transaksiToolStripMenuItem
            // 
            transaksiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { penjualanToolStripMenuItem });
            transaksiToolStripMenuItem.Name = "transaksiToolStripMenuItem";
            transaksiToolStripMenuItem.Size = new Size(82, 24);
            transaksiToolStripMenuItem.Text = "Transaksi";
            // 
            // penjualanToolStripMenuItem
            // 
            penjualanToolStripMenuItem.Name = "penjualanToolStripMenuItem";
            penjualanToolStripMenuItem.Size = new Size(155, 26);
            penjualanToolStripMenuItem.Text = "Penjualan";
            penjualanToolStripMenuItem.Click += penjualanToolStripMenuItem_Click;
            // 
            // stockToolStripMenuItem
            // 
            stockToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { inputBarangToolStripMenuItem, daftarBarangToolStripMenuItem });
            stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            stockToolStripMenuItem.Size = new Size(59, 24);
            stockToolStripMenuItem.Text = "Stock";
            // 
            // inputBarangToolStripMenuItem
            // 
            inputBarangToolStripMenuItem.Name = "inputBarangToolStripMenuItem";
            inputBarangToolStripMenuItem.Size = new Size(177, 26);
            inputBarangToolStripMenuItem.Text = "Input Barang";
            inputBarangToolStripMenuItem.Click += inputBarangToolStripMenuItem_Click;
            // 
            // daftarBarangToolStripMenuItem
            // 
            daftarBarangToolStripMenuItem.Name = "daftarBarangToolStripMenuItem";
            daftarBarangToolStripMenuItem.Size = new Size(177, 26);
            daftarBarangToolStripMenuItem.Text = "List Barang";
            daftarBarangToolStripMenuItem.Click += daftarBarangToolStripMenuItem_Click;
            // 
            // settingToolStripMenuItem
            // 
            settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            settingToolStripMenuItem.Size = new Size(70, 24);
            settingToolStripMenuItem.Text = "Setting";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(64, 24);
            aboutToolStripMenuItem.Text = "About";
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_refresh);
            panel1.Controls.Add(lbljam);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 407);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 43);
            panel1.TabIndex = 1;
            // 
            // lbljam
            // 
            lbljam.AutoSize = true;
            lbljam.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbljam.Location = new Point(689, 9);
            lbljam.Name = "lbljam";
            lbljam.Size = new Size(59, 25);
            lbljam.TabIndex = 0;
            lbljam.Text = "label1";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvStockHome);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 379);
            panel2.TabIndex = 2;
            // 
            // dgvStockHome
            // 
            dgvStockHome.AllowUserToAddRows = false;
            dgvStockHome.AllowUserToDeleteRows = false;
            dgvStockHome.AllowUserToOrderColumns = true;
            dgvStockHome.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStockHome.Dock = DockStyle.Fill;
            dgvStockHome.Location = new Point(0, 0);
            dgvStockHome.Name = "dgvStockHome";
            dgvStockHome.ReadOnly = true;
            dgvStockHome.RowHeadersVisible = false;
            dgvStockHome.RowHeadersWidth = 51;
            dgvStockHome.Size = new Size(800, 379);
            dgvStockHome.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // btn_refresh
            // 
            btn_refresh.Location = new Point(12, 7);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(94, 29);
            btn_refresh.TabIndex = 1;
            btn_refresh.Text = "Refresh";
            btn_refresh.UseVisualStyleBackColor = true;
            btn_refresh.Click += btn_refresh_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Home";
            Text = "Home";
            FormClosed += Home_FormClosed;
            Load += Home_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStockHome).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem stockToolStripMenuItem;
        private ToolStripMenuItem settingToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem inputBarangToolStripMenuItem;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvStockHome;
        private System.Windows.Forms.Timer timer1;
        private Label lbljam;
        private ToolStripMenuItem transaksiToolStripMenuItem;
        private ToolStripMenuItem penjualanToolStripMenuItem;
        private ToolStripMenuItem daftarBarangToolStripMenuItem;
        private Button btn_refresh;
    }
}