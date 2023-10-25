namespace logİn
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.EmailText = new System.Windows.Forms.TextBox();
            this.ŞifreText = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SifremiUnuttum = new System.Windows.Forms.LinkLabel();
            this.Kayıt = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // EmailText
            // 
            this.EmailText.Location = new System.Drawing.Point(326, 113);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(162, 22);
            this.EmailText.TabIndex = 0;
            this.EmailText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ŞifreText
            // 
            this.ŞifreText.Location = new System.Drawing.Point(326, 244);
            this.ŞifreText.Name = "ŞifreText";
            this.ŞifreText.Size = new System.Drawing.Size(162, 22);
            this.ŞifreText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(363, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "e mail ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(363, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "şifre ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 52);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SifremiUnuttum
            // 
            this.SifremiUnuttum.AutoSize = true;
            this.SifremiUnuttum.Location = new System.Drawing.Point(525, 405);
            this.SifremiUnuttum.Name = "SifremiUnuttum";
            this.SifremiUnuttum.Size = new System.Drawing.Size(108, 17);
            this.SifremiUnuttum.TabIndex = 11;
            this.SifremiUnuttum.TabStop = true;
            this.SifremiUnuttum.Text = "Şifremi Unuttum";
            this.SifremiUnuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SifremiUnuttum_LinkClicked);
            // 
            // Kayıt
            // 
            this.Kayıt.AutoSize = true;
            this.Kayıt.Location = new System.Drawing.Point(226, 405);
            this.Kayıt.Name = "Kayıt";
            this.Kayıt.Size = new System.Drawing.Size(39, 17);
            this.Kayıt.TabIndex = 10;
            this.Kayıt.TabStop = true;
            this.Kayıt.Text = "Kayıt";
            this.Kayıt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Login_LinkClicked_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SifremiUnuttum);
            this.Controls.Add(this.Kayıt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ŞifreText);
            this.Controls.Add(this.EmailText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.MaskedTextBox ŞifreText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel SifremiUnuttum;
        private System.Windows.Forms.LinkLabel Kayıt;
    }
}

