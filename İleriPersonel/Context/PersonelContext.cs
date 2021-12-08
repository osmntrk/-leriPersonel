using İleriPersonel.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace İleriPersonel.Context
{
    public class PersonelContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        // Your context has been configured to use a 'PersonelContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'İleriPersonel.Context.PersonelContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'PersonelContext' 
        // connection string in the application configuration file.
        public PersonelContext()
            : base("name=Baglanti")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Calısan> Ogrenciler { get; set; }
        public virtual DbSet<Ilce> Ilce { get; set; }
        public virtual DbSet<Sehir> Sehir { get; set; }
        public virtual List<Egitim> Egitim { get; set; }
        public virtual List<Ogrenci> Ogrenci { get; set; }
        public virtual List<Egitmen> Egitmen { get; set; }
        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
    public class Sehir : TemelTanımlar
    {
        public Sehir()
        {
            Ilceler = new List<Ilce>();
        }
        public List<Ilce> Ilceler { get; set; }

    }
    public class Egitim : TemelTanımlar
    {

        public Egitim()
        {
            Ogrenciler = new List<Ogrenci>();
            Calısanlar = new List<Calısan>();
            Egitmenler = new List<Egitmen>();

        }
        public virtual List<Ogrenci> Ogrenciler { get; set; }
        public virtual List<Calısan> Calısanlar { get; set; }
        public virtual  List<Egitmen> Egitmenler { get; set; }

    }
    public class Ilce : TemelTanımlar
    {
        public int SehirId { get; set; }
        [ForeignKey("SehirId")]
        public virtual  Sehir sehir { get; set; }

    }
    public class Ogrenci : TemelInsan
    {
        
        [ForeignKey("EgitimId")]
        
        public Egitim Egitim { get; set; }
        [ForeignKey("IlceId")]
        public virtual Ilce Ilce { get; set; }

    }
    public class Egitmen : TemelInsan
    {
        
        public decimal Maas { get; set; }
        public string Unvan { get; set; }
        public override string UnvanYaz()
        {
            return "Sn" + Ad + "" + Soyad + "" + Unvan;
             
        }
        [ForeignKey("EgitimId")]
        public virtual Egitim Egitim { get; set; }
        [ForeignKey("IlceId")]
        public virtual Ilce  Ilce { get; set; }

    }
    public class Calısan : TemelInsan
    {
        [ForeignKey("EgitimId")]
        public virtual Egitim Egitim { get; set; }
        [ForeignKey("IlceId")]
        public virtual Ilce Ilce { get; set; }



    }

}