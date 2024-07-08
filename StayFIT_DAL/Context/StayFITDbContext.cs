using Microsoft.EntityFrameworkCore;
using StayFIT_CORE.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StayFIT_DAL.Context
{
    public class StayFITDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<FoodMeal> FoodMeals { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserDailyActivity> UserDailyActivities { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer("Server=DESKTOP-LGLV727\\SQLEXPRESS;Database=Sf2DbApp;Trusted_Connection=True;Integrated Security=True;Encrypt=False;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<Category>().HasData(
             new Category { Id = 1, Name = "Et Yemekleri" },
             new Category { Id = 2, Name = "Etli Sebze Yemekleri" },
             new Category { Id = 3, Name = "Tahıllı Yemekler" },
             new Category { Id = 4, Name = "Zeytin Yağlı Sebze Yemekleri" },
             new Category { Id = 5, Name = "Çorbalar" },
             new Category { Id = 6, Name = "Tatlılar" },
             new Category { Id = 7, Name = "Salatalar" },
             new Category { Id = 8, Name = "Meyveler" },
             new Category { Id = 9, Name = "Kahvaltılıklar" },
             new Category { Id = 10, Name = "Süt ve Süt Ürünleri" },
             new Category { Id = 11, Name = "Soğuk İçecekler" },
             new Category { Id = 12, Name = "Sıcak İçecekler" }
             );

            modelBuilder.Entity<Food>().HasData(
            new Food { Id = 1, Name = "Terbiyeli Köfte", Calory = 231, Description = "Protein = 20.5m, Fat = 15.3m, Carbonhydrate = 5.7m", CategoryId = 1 },
            new Food { Id = 2, Name = "İzmir Köfte", Calory = 343, Description = "Protein = 18.2m, Fat = 28.4m, Carbonhydrate = 3.7m", CategoryId = 1 },
            new Food { Id = 3, Name = "Fırın Tavuk", Calory = 275, Description = "Protein = 24.8m, Fat = 17.2m, Carbonhydrate = 1.8m", CategoryId = 1 },
            new Food { Id = 4, Name = "Kuzu Tandır", Calory = 420, Description = "Protein = 29.5m, Fat = 34.8m, Carbonhydrate = 0.9m", CategoryId = 1 },
            new Food { Id = 5, Name = "Köfte Izgara", Calory = 310, Description = "Protein = 22.1m, Fat = 23.7m, Carbonhydrate = 2.4m", CategoryId = 1 },
            new Food { Id = 6, Name = "Beyti", Calory = 489, Description = "Protein = 24.8m, Fat = 23.2m, Carbonhydrate = 26.8m", CategoryId = 1 },
            new Food { Id = 7, Name = "Patlıcan Kebabı", Calory = 265, Description = "Protein = 9.4m, Fat = 20.1m, Carbonhydrate = 12.7m", CategoryId = 1 },
            new Food { Id = 8, Name = "Hünkar Beğendi", Calory = 380, Description = "Protein = 22.5m, Fat = 28.6m, Carbonhydrate = 8.3m", CategoryId = 1 },
            new Food { Id = 9, Name = "Cızlak Kebap", Calory = 310, Description = "Protein = 17.8m, Fat = 24.5m, Carbonhydrate = 3.2m", CategoryId = 1 },
            new Food { Id = 10, Name = "Ciğer Sote", Calory = 280, Description = "Protein = 18.6m, Fat = 21.4m, Carbonhydrate = 3.8m", CategoryId = 1 },
            new Food { Id = 11, Name = "Tavuklu Pilav", Calory = 320, Description = "Protein = 20.2m, Fat = 12.5m, Carbonhydrate = 28.1m", CategoryId = 1 },
            new Food { Id = 12, Name = "Fırın Mantarlı Tavuk", Calory = 290, Description = "Protein = 26.8m, Fat = 19.3m, Carbonhydrate = 3.7m", CategoryId = 1 },
            new Food { Id = 13, Name = "Dana Kavurma", Calory = 360, Description = "Protein = 22.3m, Fat = 29.8m, Carbonhydrate = 0.9m", CategoryId = 1 },
            new Food { Id = 14, Name = "Zeytinyağlı Yaprak Sarma", Calory = 180, Description = "Protein = 3.5m, Fat = 9.2m, Carbonhydrate = 22.8m", CategoryId = 1 },
            new Food { Id = 15, Name = "Kuzu İncik", Calory = 450, Description = "Protein = 30.7m, Fat = 36.2m, Carbonhydrate = 1.2m", CategoryId = 1 },
            new Food { Id = 16, Name = "Balık Tava", Calory = 260, Description = "Protein = 24.1m, Fat = 17.8m, Carbonhydrate = 0.6m", CategoryId = 1 },
            new Food { Id = 17, Name = "Kağıt Kebabı", Calory = 310, Description = "Protein = 22.5m, Fat = 23.7m, Carbonhydrate = 2.4m", CategoryId = 1 },
            new Food { Id = 18, Name = "Tavuk Kapama", Calory = 280, Description = "Protein = 19.3m, Fat = 20.1m, Carbonhydrate = 3.8m", CategoryId = 1 },
            new Food { Id = 19, Name = "Ali Nazik Kebabı", Calory = 340, Description = "Protein = 21.7m, Fat = 25.2m, Carbonhydrate = 6.3m", CategoryId = 1 },
            new Food { Id = 20, Name = "Kuzu Güveç", Calory = 390, Description = "Protein = 28.2m, Fat = 31.6m, Carbonhydrate = 0.9m", CategoryId = 1 },
            new Food { Id = 21, Name = "İskender", Calory = 480, Description = "Protein = 26.7m, Fat = 33.2m, Carbonhydrate = 18.4m", CategoryId = 1 },
            new Food { Id = 22, Name = "Fırın Tavuk But", Calory = 310, Description = "Protein = 24.5m, Fat = 21.2m, Carbonhydrate = 0.8m", CategoryId = 1 },
            new Food { Id = 23, Name = "Tavuklu Karnabahar", Calory = 240, Description = "Protein = 18.2m, Fat = 16.9m, Carbonhydrate = 5.7m", CategoryId = 1 },
            new Food { Id = 24, Name = "Balıklı Pilav", Calory = 360, Description = "Protein = 25.6m, Fat = 14.8m, Carbonhydrate = 27.9m", CategoryId = 1 },
            new Food { Id = 25, Name = "Hamsili Ekmek", Calory = 280, Description = "Protein = 20.3m, Fat = 18.9m, Carbonhydrate = 7.1m", CategoryId = 1 },
            new Food { Id = 26, Name = "Fırın Mantarlı Tavuk", Calory = 290, Description = "Protein = 26.8m, Fat = 19.3m, Carbonhydrate = 3.7m", CategoryId = 1 },
            new Food { Id = 27, Name = "Peynirli Kuzu Kuyma", Calory = 420, Description = "Protein = 30.5m, Fat = 34.1m, Carbonhydrate = 1.9m", CategoryId = 1 },
            new Food { Id = 28, Name = "Cevizli Kuzu Güveç", Calory = 380, Description = "Protein = 25.2m, Fat = 29.7m, Carbonhydrate = 5.3m", CategoryId = 1 },
            new Food { Id = 29, Name = "Fırın Tavuk Kanat", Calory = 270, Description = "Protein = 23.4m, Fat = 18.1m, Carbonhydrate = 0.6m", CategoryId = 1 },
            new Food { Id = 30, Name = "Yogurtlu Tavuk Şiş", Calory = 320, Description = "Protein = 22.8m, Fat = 24.5m, Carbonhydrate = 3.2m", CategoryId = 1 },
            new Food { Id = 31, Name = "Fırın Karnabahar Kızartması", Calory = 180, Description = "Protein = 6.7m, Fat = 12.4m, Carbonhydrate = 15.8m", CategoryId = 2 },
            new Food { Id = 32, Name = "Patlıcanlı Kıymalı Güveç", Calory = 250, Description = "Protein = 14.3m, Fat = 18.6m, Carbonhydrate = 7.9m", CategoryId = 2 },
            new Food { Id = 33, Name = "Kuzu Kapama", Calory = 320, Description = "Protein = 22.5m, Fat = 25.1m, Carbonhydrate = 2.8m", CategoryId = 2 },
            new Food { Id = 34, Name = "Zeytinyağlı Pırasa", Calory = 150, Description = "Protein = 4.6m, Fat = 10.2m, Carbonhydrate = 11.8m", CategoryId = 2 },
            new Food { Id = 35, Name = "Taze Fasulye Türlü", Calory = 200, Description = "Protein = 9.8m, Fat = 12.7m, Carbonhydrate = 13.5m", CategoryId = 2 },
            new Food { Id = 36, Name = "Kabak Karnabahar Graten", Calory = 280, Description = "Protein = 13.6m, Fat = 19.3m, Carbonhydrate = 16.8m", CategoryId = 2 },
            new Food { Id = 37, Name = "Sebzeli Kıymalı Börek", Calory = 320, Description = "Protein = 18.7m, Fat = 24.5m, Carbonhydrate = 7.2m", CategoryId = 2 },
            new Food { Id = 38, Name = "Zeytinyağlı Enginar", Calory = 180, Description = "Protein = 4.2m, Fat = 13.8m, Carbonhydrate = 11.5m", CategoryId = 2 },
            new Food { Id = 39, Name = "Kırmızı Mercimek Koftesi", Calory = 240, Description = "Protein = 12.3m, Fat = 18.9m, Carbonhydrate = 6.5m", CategoryId = 2 },
            new Food { Id = 40, Name = "Karnabahar Köftesi", Calory = 210, Description = "Protein = 8.5m, Fat = 14.2m, Carbonhydrate = 16.7m", CategoryId = 2 },
            new Food { Id = 41, Name = "Quinoa Salatası", Calory = 180, Description = "Protein = 6.5m, Fat = 9.2m, Carbonhydrate = 19.8m", CategoryId = 3 },
            new Food { Id = 42, Name = "Cevizli Kabak Tarator", Calory = 220, Description = "Protein = 5.8m, Fat = 17.1m, Carbonhydrate = 11.3m", CategoryId = 3 },
            new Food { Id = 43, Name = "Karnabahar Kuskusu", Calory = 250, Description = "Protein = 7.3m, Fat = 12.9m, Carbonhydrate = 28.4m", CategoryId = 3 },
            new Food { Id = 44, Name = "Bulgur Pilavı", Calory = 290, Description = "Protein = 6.7m, Fat = 1.5m, Carbonhydrate = 61.2m", CategoryId = 3 },
            new Food { Id = 45, Name = "İncirli Armut Pilavı", Calory = 310, Description = "Protein = 8.2m, Fat = 4.6m, Carbonhydrate = 66.5m", CategoryId = 3 },
            new Food { Id = 46, Name = "Yulaf Ezmesi", Calory = 180, Description = "Protein = 5.4m, Fat = 3.2m, Carbonhydrate = 33.5m", CategoryId = 3 },
            new Food { Id = 47, Name = "Pirinç Pilavı", Calory = 320, Description = "Protein = 6.9m, Fat = 1.8m, Carbonhydrate = 69.4m", CategoryId = 3 },
            new Food { Id = 48, Name = "Fasulye Pilavı", Calory = 250, Description = "Protein = 7.8m, Fat = 3.5m, Carbonhydrate = 47.2m", CategoryId = 3 },
            new Food { Id = 49, Name = "Beyaz Nohut Pilavı", Calory = 280, Description = "Protein = 10.1m, Fat = 4.7m, Carbonhydrate = 53.8m", CategoryId = 3 },
            new Food { Id = 50, Name = "Kabaklı Bulgur Pilavı", Calory = 210, Description = "Protein = 5.9m, Fat = 2.1m, Carbonhydrate = 43.7m", CategoryId = 3 },
            new Food { Id = 51, Name = "Zeytinyağlı Yaprak Sarma", Calory = 180, Description = "Protein = 3.5m, Fat = 12.6m, Carbonhydrate = 15.2m", CategoryId = 4 },
            new Food { Id = 52, Name = "Zeytinyağlı Kabak Dolması", Calory = 150, Description = "Protein = 2.8m, Fat = 10.3m, Carbonhydrate = 12.4m", CategoryId = 4 },
            new Food { Id = 53, Name = "Zeytinyağlı Pırasa", Calory = 120, Description = "Protein = 2.4m, Fat = 8.1m, Carbonhydrate = 9.7m", CategoryId = 4 },
            new Food { Id = 54, Name = "Zeytinyağlı Taze Fasulye", Calory = 140, Description = "Protein = 3.1m, Fat = 8.8m, Carbonhydrate = 11.5m", CategoryId = 4 },
            new Food { Id = 55, Name = "Zeytinyağlı Enginar", Calory = 200, Description = "Protein = 4.6m, Fat = 15.4m, Carbonhydrate = 14.7m", CategoryId = 4 },
            new Food { Id = 56, Name = "Zeytinyağlı Karnabahar", Calory = 160, Description = "Protein = 3.2m, Fat = 11.5m, Carbonhydrate = 12.9m", CategoryId = 4 },
            new Food { Id = 57, Name = "Zeytinyağlı Bamya", Calory = 130, Description = "Protein = 2.9m, Fat = 8.6m, Carbonhydrate = 10.7m", CategoryId = 4 },
            new Food { Id = 58, Name = "Zeytinyağlı Ispanak", Calory = 110, Description = "Protein = 2.1m, Fat = 7.2m, Carbonhydrate = 9.4m", CategoryId = 4 },
            new Food { Id = 59, Name = "Zeytinyağlı Pırasa Yemeği", Calory = 140, Description = "Protein = 3.3m, Fat = 9.2m, Carbonhydrate = 11.8m", CategoryId = 4 },
            new Food { Id = 60, Name = "Zeytinyağlı Taze Fasulye Pilaki", Calory = 150, Description = "Protein = 3.7m, Fat = 9.8m, Carbonhydrate = 12.5m", CategoryId = 4 },
            new Food { Id = 71, Name = "Mercimek Çorbası", Calory = 150, Description = "Protein = 9.5m, Fat = 3.2m, Carbonhydrate = 21.8m", CategoryId = 5 },
            new Food { Id = 72, Name = "Tarator Çorbası", Calory = 120, Description = "Protein = 7.8m, Fat = 5.1m, Carbonhydrate = 12.6m", CategoryId = 5 },
            new Food { Id = 73, Name = "Domates Çorbası", Calory = 110, Description = "Protein = 4.2m, Fat = 2.8m, Carbonhydrate = 18.5m", CategoryId = 5 },
            new Food { Id = 74, Name = "Tavuklu Şehriye Çorbası", Calory = 180, Description = "Protein = 12.3m, Fat = 4.6m, Carbonhydrate = 23.7m", CategoryId = 5 },
            new Food { Id = 75, Name = "Ezogelin Çorbası", Calory = 160, Description = "Protein = 8.9m, Fat = 3.5m, Carbonhydrate = 24.2m", CategoryId = 5 },
            new Food { Id = 76, Name = "Yoğurtlu Çorba", Calory = 140, Description = "Protein = 7.4m, Fat = 6.8m, Carbonhydrate = 15.9m", CategoryId = 5 },
            new Food { Id = 77, Name = "Kremalı Mantar Çorbası", Calory = 220, Description = "Protein = 5.6m, Fat = 18.3m, Carbonhydrate = 9.7m", CategoryId = 5 },
            new Food { Id = 78, Name = "Kabak Çorbası", Calory = 130, Description = "Protein = 3.7m, Fat = 7.2m, Carbonhydrate = 14.8m", CategoryId = 5 },
            new Food { Id = 79, Name = "Kırmızı Mercimek Çorbası", Calory = 160, Description = "Protein = 9.8m, Fat = 2.6m, Carbonhydrate = 25.4m", CategoryId = 5 },
            new Food { Id = 80, Name = "İrmik Helvası", Calory = 528, Description = "Protein = 7.6m, Fat = 29.8m, Carbonhydrate = 63.3m", CategoryId = 6 },
            new Food { Id = 81, Name = "Sütlaç", Calory = 347, Description = "Protein = 8.2m, Fat = 7.2m, Carbonhydrate = 67.2m", CategoryId = 6 },
            new Food { Id = 82, Name = "Baklava", Calory = 450, Description = "Protein = 7.5m, Fat = 29.5m, Carbonhydrate = 40.2m", CategoryId = 6 },
            new Food { Id = 83, Name = "Kazandibi", Calory = 280, Description = "Protein = 5.8m, Fat = 12.6m, Carbonhydrate = 35.2m", CategoryId = 6 },
            new Food { Id = 84, Name = "Revani", Calory = 315, Description = "Protein = 6.2m, Fat = 15.8m, Carbonhydrate = 38.1m", CategoryId = 6 },
            new Food { Id = 85, Name = "Dondurma", Calory = 207, Description = "Protein = 5.4m, Fat = 11.2m, Carbonhydrate = 22.6m", CategoryId = 6 },
            new Food { Id = 86, Name = "Domates Salatası", Calory = 127, Description = "Protein = 2.5m, Fat = 8.4m, Carbonhydrate = 11.6m", CategoryId = 7 },
            new Food { Id = 87, Name = "Cacık", Calory = 75, Description = "Protein = 3.2m, Fat = 5.6m, Carbonhydrate = 3.9m", CategoryId = 7 },
            new Food { Id = 88, Name = "Roka Salatası", Calory = 64, Description = "Protein = 3.9m, Fat = 4.7m, Carbonhydrate = 2.9m", CategoryId = 7 },
            new Food { Id = 89, Name = "Ceasar Salatası", Calory = 184, Description = "Protein = 4.8m, Fat = 16.7m, Carbonhydrate = 3.2m", CategoryId = 7 },
            new Food { Id = 90, Name = "Mevsim Salatası", Calory = 95, Description = "Protein = 3.1m, Fat = 6.4m, Carbonhydrate = 7.6m", CategoryId = 7 },
            new Food { Id = 92, Name = "Kayısı", Calory = 63, Description = "Protein = 1.0m, Fat = 0.2m, Carbonhydrate = 15.3m", CategoryId = 8 },
            new Food { Id = 93, Name = "Muz", Calory = 96, Description = "Protein = 1.3m, Fat = 0.3m, Carbonhydrate = 25.0m", CategoryId = 8 },
            new Food { Id = 94, Name = "Kiraz", Calory = 63, Description = "Protein = 1.1m, Fat = 0.2m, Carbonhydrate = 16.0m", CategoryId = 8 },
            new Food { Id = 95, Name = "Üzüm", Calory = 69, Description = "Protein = 0.7m, Fat = 0.2m, Carbonhydrate = 17.5m", CategoryId = 8 },
            new Food { Id = 96, Name = "Kavun", Calory = 73, Description = "Protein = 0.9m, Fat = 0.2m, Carbonhydrate = 18.0m", CategoryId = 8 },
            new Food { Id = 97, Name = "Karpuz", Calory = 30, Description = "Protein = 0.6m, Fat = 0.2m, Carbonhydrate = 8.0m", CategoryId = 8 },
            new Food { Id = 98, Name = "Portakal", Calory = 43, Description = "Protein = 1.0m, Fat = 0.2m, Carbonhydrate = 8.3m", CategoryId = 8 },
            new Food { Id = 99, Name = "Mandalina", Calory = 70, Description = "Protein = 0.8m, Fat = 0.2m, Carbonhydrate = 13.5m", CategoryId = 8 },
            new Food { Id = 100, Name = "Malta eriği", Calory = 38, Description = "Protein = 0.9m, Fat = 0.2m, Carbonhydrate = 9.6m", CategoryId = 8 },
            new Food { Id = 101, Name = "Elma", Calory = 52, Description = "Protein = 0.3m, Fat = 0.2m, Carbonhydrate = 14.0m", CategoryId = 8 },
            new Food { Id = 102, Name = "Toz Şeker", Calory = 76, Description = "Protein = 0.0m, Fat = 0.0m, Carbonhydrate = 20.0m", CategoryId = 9 },
            new Food { Id = 103, Name = "Peynir (Kaşar)", Calory = 121, Description = "Protein = 6.0m, Fat = 10.0m, Carbonhydrate = 1.0m", CategoryId = 9 },
            new Food { Id = 104, Name = "Peynir(Beyaz)", Calory = 87, Description = "Protein = 7.0m, Fat = 6.0m, Carbonhydrate = 1.0m", CategoryId = 9 },
            new Food { Id = 105, Name = "Reçel", Calory = 96, Description = "Protein = 0.3m, Fat = 0.1m, Carbonhydrate = 25.0m", CategoryId = 9 },
            new Food { Id = 106, Name = "Yağ(Margarin)", Calory = 221, Description = "Protein = 0.3m, Fat = 24.0m, Carbonhydrate = 0.0m", CategoryId = 9 },
            new Food { Id = 107, Name = "Yumurta", Calory = 80, Description = "Protein = 6.0m, Fat = 5.0m, Carbonhydrate = 1.0m", CategoryId = 9 },
            new Food { Id = 108, Name = "Zeytin(Yeşil)", Calory = 43, Description = "Protein = 0.5m, Fat = 4.0m, Carbonhydrate = 0.0m", CategoryId = 9 },
            new Food { Id = 109, Name = "Zeytin(Siyah)", Calory = 62, Description = "Protein = 0.5m, Fat = 6.0m, Carbonhydrate = 1.0m", CategoryId = 9 },
            new Food { Id = 110, Name = "Ekmek", Calory = 276, Description = "Protein = 9.0m, Fat = 1.0m, Carbonhydrate = 56.0m", CategoryId = 9 },
            new Food { Id = 111, Name = "İnek Sütü", Calory = 61, Description = "Protein = 3.0m, Fat = 3.0m, Carbonhydrate = 5.0m", CategoryId = 10 },
            new Food { Id = 112, Name = "Yoğurt", Calory = 63, Description = "Protein = 4.0m, Fat = 3.0m, Carbonhydrate = 4.0m", CategoryId = 10 },
            new Food { Id = 115, Name = "Kola", Calory = 140, Description = "Protein = 0.0m, Fat = 0.0m, Carbonhydrate = 39.0m", CategoryId = 11 },
            new Food { Id = 116, Name = "Portakal Suyu", Calory = 110, Description = "Protein = 2.0m, Fat = 0.5m, Carbonhydrate = 26.0m", CategoryId = 11 },
            new Food { Id = 117, Name = "Limonata", Calory = 120, Description = "Protein = 0.5m, Fat = 0.0m, Carbonhydrate = 30.0m", CategoryId = 11 },
            new Food { Id = 118, Name = "Gazoz", Calory = 90, Description = "Protein = 0.0m, Fat = 0.0m, Carbonhydrate = 24.0m", CategoryId = 11 },
            new Food { Id = 119, Name = "Meyve Smoothie", Calory = 200, Description = "Protein = 2.5m, Fat = 1.0m, Carbonhydrate = 45.0m", CategoryId = 11 },
            new Food { Id = 120, Name = "Türk Kahvesi", Calory = 5, Description = "Protein = 0.5m, Fat = 0.2m, Carbonhydrate = 0.0m", CategoryId = 12 },
            new Food { Id = 121, Name = "Siyah Çay", Calory = 2, Description = "Protein = 0.1m, Fat = 0.0m, Carbonhydrate = 0.5m", CategoryId = 12 },
            new Food { Id = 122, Name = "Yeşil Çay", Calory = 0, Description = "Protein = 0.0m, Fat = 0.0m, Carbonhydrate = 0.0m", CategoryId = 12 },
            new Food { Id = 123, Name = "Nane Limon Çayı", Calory = 4, Description = "Protein = 0.1m, Fat = 0.0m, Carbonhydrate = 0.8m", CategoryId = 12 },
            new Food { Id = 124, Name = "Salep", Calory = 150, Description = "Protein = 1.5m, Fat = 2.0m, Carbonhydrate = 30.0m", CategoryId = 12 }
            );

            
        }
    }
}
