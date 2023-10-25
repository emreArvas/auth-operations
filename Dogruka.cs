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
    public partial class Dogruka : Form
    {
        ProjeEntities db = new ProjeEntities();
        
        public Dogruka()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kod = KodText.Text;
            Users dbUsers = db.Users.FirstOrDefault(x=>x.email==ForgotPassword._email);
            if (dbUsers.aktivasyon == kod)
            {
                MessageBox.Show("Kod Doğrulandi");
                dbUsers.aktivasyon = " ";
               
                db.SaveChanges();
                Degistir degis = new Degistir();
                degis.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Kod Doğrulanamadi");

            }
        }
    }
}
