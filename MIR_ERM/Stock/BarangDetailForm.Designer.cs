namespace MIR_ERM.Stock
{
    partial class BarangDetailForm
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
            txtbarangid = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtnamabarang = new TextBox();
            label3 = new Label();
            txtharga = new TextBox();
            label4 = new Label();
            txtstock = new TextBox();
            label5 = new Label();
            txtsatuan = new TextBox();
            label6 = new Label();
            txtsuplier = new TextBox();
            btn_edit = new Button();
            btn_exit = new Button();
            btn_save = new Button();
            btn_cancel = new Button();
            SuspendLayout();
            // 
            // txtbarangid
            // 
            txtbarangid.Location = new Point(176, 66);
            txtbarangid.Name = "txtbarangid";
            txtbarangid.Size = new Size(378, 27);
            txtbarangid.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 66);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 1;
            label1.Text = "Kode Barang";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 119);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 3;
            label2.Text = "Nama Barang";
            // 
            // txtnamabarang
            // 
            txtnamabarang.Location = new Point(176, 119);
            txtnamabarang.Name = "txtnamabarang";
            txtnamabarang.Size = new Size(378, 27);
            txtnamabarang.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 172);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 5;
            label3.Text = "Harga";
            // 
            // txtharga
            // 
            txtharga.Location = new Point(176, 172);
            txtharga.Name = "txtharga";
            txtharga.Size = new Size(378, 27);
            txtharga.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 227);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 7;
            label4.Text = "Stock";
            // 
            // txtstock
            // 
            txtstock.Location = new Point(176, 227);
            txtstock.Name = "txtstock";
            txtstock.Size = new Size(378, 27);
            txtstock.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 285);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 9;
            label5.Text = "Satuan";
            // 
            // txtsatuan
            // 
            txtsatuan.Location = new Point(176, 285);
            txtsatuan.Name = "txtsatuan";
            txtsatuan.Size = new Size(378, 27);
            txtsatuan.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 343);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 11;
            label6.Text = "Suplier";
            // 
            // txtsuplier
            // 
            txtsuplier.Location = new Point(176, 343);
            txtsuplier.Name = "txtsuplier";
            txtsuplier.Size = new Size(378, 27);
            txtsuplier.TabIndex = 10;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(611, 64);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(94, 29);
            btn_edit.TabIndex = 12;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(611, 376);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(94, 29);
            btn_exit.TabIndex = 13;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(611, 110);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(94, 29);
            btn_save.TabIndex = 14;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(611, 163);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(94, 29);
            btn_cancel.TabIndex = 15;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // BarangDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 433);
            Controls.Add(btn_cancel);
            Controls.Add(btn_save);
            Controls.Add(btn_exit);
            Controls.Add(btn_edit);
            Controls.Add(label6);
            Controls.Add(txtsuplier);
            Controls.Add(label5);
            Controls.Add(txtsatuan);
            Controls.Add(label4);
            Controls.Add(txtstock);
            Controls.Add(label3);
            Controls.Add(txtharga);
            Controls.Add(label2);
            Controls.Add(txtnamabarang);
            Controls.Add(label1);
            Controls.Add(txtbarangid);
            Name = "BarangDetailForm";
            Text = "Form Detail Barang";
            Load += BarangDetailForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbarangid;
        private Label label1;
        private Label label2;
        private TextBox txtnamabarang;
        private Label label3;
        private TextBox txtharga;
        private Label label4;
        private TextBox txtstock;
        private Label label5;
        private TextBox txtsatuan;
        private Label label6;
        private TextBox txtsuplier;
        private Button btn_edit;
        private Button btn_exit;
        private Button btn_save;
        private Button btn_cancel;
    }
}