using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using logİn.Models;

namespace logİn
{
    public partial class ForgotPassword : Form
    {
        ProjeEntities db = new ProjeEntities();
        public static string _email;
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = EmailText.Text;
           Users sendUser = db.Users.FirstOrDefault(x=>x.email==email);
            if (sendUser == null)
            {
                MessageBox.Show("Kullanici kayıtlı değil");
            }
            else
            {
                string kod = new Random().Next(100000, 999999).ToString();
                sendUser.aktivasyon = kod;
                _email = email;
                db.SaveChanges();
                ForgotPassword.emailMesajGonder(email, kod);
                MessageBox.Show("kod mail adresinize gönderildi doğrulayın");
                Dogruka dogrula = new Dogruka();
                dogrula.Show();
               // this.Close();
                
              
               
            }
            
        }
        public static void emailMesajGonder(string email, string kod)
        {
            try
            {
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("odev075@gmail.com", "tozi yrmw kewk komy"),
                    EnableSsl = true,
                };

                MailMessage mesaj = new MailMessage
                {
                    From = new MailAddress("your-email@example.com"),
                    Subject = "Doğrulama Kodu",
                    Body = $"Kodunuz: {kod}",
                    IsBodyHtml = true,
                };

                mesaj.To.Add(email);

                smtpClient.Send(mesaj);
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata: "+hata);

            }
        }

        private void EmailText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
