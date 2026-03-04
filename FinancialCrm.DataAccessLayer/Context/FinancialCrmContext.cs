using FinancialCrm.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // Directory için bu şart!
using Microsoft.Extensions.Configuration.UserSecrets; // Add this using directive for AddUserSecrets

namespace FinancialCrm.DataAccessLayer.Context
{
    public class FinancialCrmContext : DbContext
    { 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Proje ayarlarını ve secrets dosyasını okuyoruz
            // PostgreSQL bağlantı adresin. ANA KÖPRÜ BURASI
            // Veritabanı ismini "FinancialCrmDb" olarak verebilirsin.
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath
                (AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .AddUserSecrets<FinancialCrmContext>() // Bilgiyi buradan çekecek
                .Build();

            optionsBuilder.UseNpgsql(configuration.GetConnectionString("FinancialCrmConnection"));
        }

        // PostreSql veritabanını küçük harflerle oluşturduğum için OnCreatingModel metodu ile düzeltiyorum.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Banks Tablosu ve Sütunları
            modelBuilder.Entity<Bank>().ToTable("banks");
            modelBuilder.Entity<Bank>().Property(x => x.BankId).HasColumnName("bankid");
            modelBuilder.Entity<Bank>().Property(x => x.BankAccountNumber).HasColumnName("bankaccountnumber");
            modelBuilder.Entity<Bank>().Property(x => x.BankTitle).HasColumnName("banktitle");
            modelBuilder.Entity<Bank>().Property(x => x.BankBalance).HasColumnName("bankbalance");

            // Categories Tablosu ve Sütunları
            modelBuilder.Entity<Category>().ToTable("categories");
            modelBuilder.Entity<Category>().Property(x => x.CategoryId).HasColumnName("categoryid");
            modelBuilder.Entity<Category>().Property(x => x.CategoryName).HasColumnName("categoryname");

            // Bills Tablosu ve Sütunları
            modelBuilder.Entity<Bill>().ToTable("bills");
            modelBuilder.Entity<Bill>().Property(x => x.BillId).HasColumnName("billid");
            modelBuilder.Entity<Bill>().Property(x => x.BillTitle).HasColumnName("billtitle");
            modelBuilder.Entity<Bill>().Property(x => x.BillAmount).HasColumnName("billamount");
            modelBuilder.Entity<Bill>().Property(x => x.BillPeriod).HasColumnName("billperiod");

            // Expends Tablosu ve Sütunları
            
            modelBuilder.Entity<Expend>().ToTable("expends");
            modelBuilder.Entity<Expend>().Property(x => x.ExpendId).HasColumnName("expendid");
            modelBuilder.Entity<Expend>().Property(x => x.ExpendTitle).HasColumnName("expendtitle");
            modelBuilder.Entity<Expend>().Property(x => x.ExpendAmount).HasColumnName("expendamount");
            modelBuilder.Entity<Expend>().Property(x => x.ExpendDate).HasColumnName("expenddate");
            modelBuilder.Entity<Expend>().Property(x => x.CategoryId).HasColumnName("categoryid");

            // PostgreSQL'in tabloyu tanıması
            modelBuilder.Entity<Category>().ToTable("categories");

            // Users Tablosu ve Sütunları
            modelBuilder.Entity<User>().ToTable("users");
            modelBuilder.Entity<User>().Property(x => x.UserId).HasColumnName("userid");
            modelBuilder.Entity<User>().Property(x => x.Username).HasColumnName("username");
            modelBuilder.Entity<User>().Property(x => x.Password).HasColumnName("password");
        }

        // Bu kısımlar C# sınıfların ile SQL tablolarını birbirine bağlar.
        public DbSet<Category> Categories { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<BankProcess> BankProcesses { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Expend> Expends { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
