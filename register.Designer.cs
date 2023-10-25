namespace logİn
{
    partial class register
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.TextBox();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.sifreText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SifremiUnuttum = new System.Windows.Forms.LinkLabel();
            this.Login = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(303, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "e mail ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(303, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "kullanıcı adı ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(303, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "şifre";
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(307, 86);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(131, 22);
            this.emailText.TabIndex = 3;
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(307, 177);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(131, 22);
            this.usernameText.TabIndex = 4;
            // 
            // sifreText
            // 
            this.sifreText.Location = new System.Drawing.Point(307, 270);
            this.sifreText.Name = "sifreText";
            this.sifreText.Size = new System.Drawing.Size(131, 22);
            this.sifreText.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 64);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SifremiUnuttum
            // 
            this.SifremiUnuttum.AutoSize = true;
            this.SifremiUnuttum.Location = new System.Drawing.Point(500, 407);
            this.SifremiUnuttum.Name = "SifremiUnuttum";
            this.SifremiUnuttum.Size = new System.Drawing.Size(108, 17);
            this.SifremiUnuttum.TabIndex = 8;
            this.SifremiUnuttum.TabStop = true;
            this.SifremiUnuttum.Text = "Şifremi Unuttum";
            this.SifremiUnuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SifremiUnuttum_LinkClicked);
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Location = new System.Drawing.Point(205, 407);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(37, 17);
            this.Login.TabIndex = 7;
            this.Login.TabStop = true;
            this.Login.Text = "Giriş";
            this.Login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Login_LinkClicked);
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SifremiUnuttum);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sifreText);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "register";
            this.Text = "register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.TextBox sifreText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel SifremiUnuttum;
        private System.Windows.Forms.LinkLabel Login;
    }
}