using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace logİn
{
    class KullaniciContext :DbContext
    {
        public DbSet<Kullanici> kullanicilar { get; set; } // Örnek bir DbSet

        public KullaniciContext() : base("Data Source=|DataDirectory|\\MyDatabase.sqlite")
        {
        }


    }
}
