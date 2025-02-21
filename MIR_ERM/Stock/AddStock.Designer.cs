namespace MIR_ERM.Stock
{
    partial class AddStock
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
            txtkodebarang = new TextBox();
            txtnamabarang = new TextBox();
            label2 = new Label();
            pboxbarcode = new PictureBox();
            cmbCAM = new ComboBox();
            btnscan = new Button();
            btnsave = new Button();
            btnclose = new Button();
            ((System.ComponentModel.ISupportInitialize)pboxbarcode).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 457);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 0;
            label1.Text = "Kode Barang";
            // 
            // txtkodebarang
            // 
            txtkodebarang.Location = new Point(185, 454);
            txtkodebarang.Name = "txtkodebarang";
            txtkodebarang.Size = new Size(448, 27);
            txtkodebarang.TabIndex = 1;
            // 
            // txtnamabarang
            // 
            txtnamabarang.Location = new Point(185, 514);
            txtnamabarang.Name = "txtnamabarang";
            txtnamabarang.Size = new Size(448, 27);
            txtnamabarang.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 517);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 2;
            label2.Text = "Nama Barang";
            // 
            // pboxbarcode
            // 
            pboxbarcode.BorderStyle = BorderStyle.Fixed3D;
            pboxbarcode.Location = new Point(144, 49);
            pboxbarcode.Name = "pboxbarcode";
            pboxbarcode.Size = new Size(1068, 381);
            pboxbarcode.TabIndex = 4;
            pboxbarcode.TabStop = false;
            pboxbarcode.WaitOnLoad = true;
            // 
            // cmbCAM
            // 
            cmbCAM.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCAM.FormattingEnabled = true;
            cmbCAM.Location = new Point(144, 12);
            cmbCAM.Name = "cmbCAM";
            cmbCAM.Size = new Size(448, 28);
            cmbCAM.TabIndex = 5;
            // 
            // btnscan
            // 
            btnscan.Location = new Point(614, 11);
            btnscan.Name = "btnscan";
            btnscan.Size = new Size(94, 29);
            btnscan.TabIndex = 6;
            btnscan.Text = "Scan";
            btnscan.UseVisualStyleBackColor = true;
            btnscan.Click += btnscan_Click;
            // 
            // btnsave
            // 
            btnsave.Location = new Point(1118, 621);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(94, 29);
            btnsave.TabIndex = 7;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // btnclose
            // 
            btnclose.Location = new Point(1018, 621);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(94, 29);
            btnclose.TabIndex = 8;
            btnclose.Text = "Close";
            btnclose.UseVisualStyleBackColor = true;
            btnclose.Click += btnclose_Click;
            // 
            // AddStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1259, 676);
            Controls.Add(btnclose);
            Controls.Add(btnsave);
            Controls.Add(btnscan);
            Controls.Add(cmbCAM);
            Controls.Add(pboxbarcode);
            Controls.Add(txtnamabarang);
            Controls.Add(label2);
            Controls.Add(txtkodebarang);
            Controls.Add(label1);
            Name = "AddStock";
            Text = "AddStock";
            FormClosing += AddStock_FormClosing;
            Load += AddStock_Load;
            ((System.ComponentModel.ISupportInitialize)pboxbarcode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtkodebarang;
        private TextBox txtnamabarang;
        private Label label2;
        private PictureBox pboxbarcode;
        private ComboBox cmbCAM;
        private Button btnscan;
        private Button btnsave;
        private Button btnclose;
    }
}