using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using logİn.Models;

namespace logİn
{
    public partial class register : Form
    {
        ProjeEntities db = new ProjeEntities();
        public register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.ad = usernameText.Text;
            users.email = emailText.Text;
            users.sifre = sifreText.Text;
            Users dbUser = db.Users.FirstOrDefault(x => x.email ==emailText.Text);
            bool düzgünEmailMi = emailText.Text.Contains("@");
            if (usernameText.Text=="" || emailText.Text=="" || sifreText.Text == "" || !düzgünEmailMi )
            {
                MessageBox.Show("Hatali veya eksik bilgi var lütfen tekrar deneyiniz");
            }
           else if (dbUser != null)
            {
                MessageBox.Show("Bu Kullanici kayıtlı");
                    
            }
            else
            {
                db.Users.Add(users);
                db.SaveChanges();
                Form1 login = new Form1();
                login.Show();
                this.Close();

            }
          
        }

        private void Login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
        }

        private void SifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword f = new ForgotPassword();
            f.Show();
            this.Close();
          
        }
    }
}
