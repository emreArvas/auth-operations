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
    public partial class Form1 : Form
    {
        ProjeEntities db = new ProjeEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = EmailText.Text;
            string sifre = ŞifreText.Text;
            Users dbUsers = db.Users.FirstOrDefault(x=>x.email==email);
            if (dbUsers == null)
            {
                MessageBox.Show("Kullanici Bulunamadi");
            }
            else
            {
                if (dbUsers.sifre != sifre)
                {
                    MessageBox.Show("Şifre yanlış Tekrar Dene");
                }
                else
                {
                    MessageBox.Show("Giriş Başarılı");
                    Anasayfacs home = new Anasayfacs();
                    home.Show();
                    this.Close();
                }
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
        }

        private void Login_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register register = new register();
            register.Show();
        }

        private void SifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword f = new ForgotPassword();
            f.Show();
            
        }
    }
}
