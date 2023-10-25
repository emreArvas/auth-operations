
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
    

    public partial class Degistir : Form
    {
        ProjeEntities db = new ProjeEntities();

        public Degistir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sifre = SifreText.Text;
            Users dbUsers  = db.Users.FirstOrDefault(x => x.email == ForgotPassword._email);
            dbUsers.sifre = sifre;
            db.SaveChanges();
            MessageBox.Show("Şifre değiştirildi");
            Form1 login = new Form1();
            login.Show();
            this.Close();
            
        }
    }
}
