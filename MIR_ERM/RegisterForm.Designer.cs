namespace MIR_ERM
{
    partial class RegisterForm
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
            txtusername = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtnama = new TextBox();
            label3 = new Label();
            txtpassword = new TextBox();
            btnsubmit = new Button();
            SuspendLayout();
            // 
            // txtusername
            // 
            txtusername.Location = new Point(142, 82);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(262, 27);
            txtusername.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 87);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 145);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 3;
            label2.Text = "Nama";
            // 
            // txtnama
            // 
            txtnama.Location = new Point(142, 140);
            txtnama.Name = "txtnama";
            txtnama.Size = new Size(262, 27);
            txtnama.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 203);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(142, 198);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(262, 27);
            txtpassword.TabIndex = 4;
            // 
            // btnsubmit
            // 
            btnsubmit.Location = new Point(442, 318);
            btnsubmit.Name = "btnsubmit";
            btnsubmit.Size = new Size(94, 29);
            btnsubmit.TabIndex = 6;
            btnsubmit.Text = "Submit";
            btnsubmit.UseVisualStyleBackColor = true;
            btnsubmit.Click += btnsubmit_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 450);
            Controls.Add(btnsubmit);
            Controls.Add(label3);
            Controls.Add(txtpassword);
            Controls.Add(label2);
            Controls.Add(txtnama);
            Controls.Add(label1);
            Controls.Add(txtusername);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtusername;
        private Label label1;
        private Label label2;
        private TextBox txtnama;
        private Label label3;
        private TextBox txtpassword;
        private Button btnsubmit;
    }
}