namespace MIR_ERM
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtusername = new TextBox();
            txtpass = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnlogin = new Button();
            SuspendLayout();
            // 
            // txtusername
            // 
            txtusername.Location = new Point(122, 103);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(295, 27);
            txtusername.TabIndex = 0;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(122, 162);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(295, 27);
            txtpass.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 103);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 162);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(403, 241);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(94, 29);
            btnlogin.TabIndex = 4;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 328);
            Controls.Add(btnlogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtpass);
            Controls.Add(txtusername);
            Name = "LoginForm";
            Text = "Login Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtusername;
        private TextBox txtpass;
        private Label label1;
        private Label label2;
        private Button btnlogin;
    }
}
