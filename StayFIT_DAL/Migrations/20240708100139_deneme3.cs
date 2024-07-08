using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StayFIT_DAL.Migrations
{
    /// <inheritdoc />
    public partial class deneme3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Gender = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Height = table.Column<int>(type: "int", maxLength: 3, nullable: false),
                    Weight = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Calory = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    Portion = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Foods_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserDailyActivities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShouldTakenCalories = table.Column<int>(type: "int", nullable: false),
                    StepCount = table.Column<int>(type: "int", maxLength: 6, nullable: false),
                    Activity = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    TotalCalories = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDailyActivities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserDailyActivities_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UserDailyActivityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Meals_UserDailyActivities_UserDailyActivityId",
                        column: x => x.UserDailyActivityId,
                        principalTable: "UserDailyActivities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodMeals",
                columns: table => new
                {
                    FoodId = table.Column<int>(type: "int", nullable: false),
                    MealId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodMeals", x => new { x.MealId, x.FoodId });
                    table.ForeignKey(
                        name: "FK_FoodMeals_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FoodMeals_Meals_MealId",
                        column: x => x.MealId,
                        principalTable: "Meals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Et Yemekleri" },
                    { 2, "Etli Sebze Yemekleri" },
                    { 3, "Tahıllı Yemekler" },
                    { 4, "Zeytin Yağlı Sebze Yemekleri" },
                    { 5, "Çorbalar" },
                    { 6, "Tatlılar" },
                    { 7, "Salatalar" },
                    { 8, "Meyveler" },
                    { 9, "Kahvaltılıklar" },
                    { 10, "Süt ve Süt Ürünleri" },
                    { 11, "Soğuk İçecekler" },
                    { 12, "Sıcak İçecekler" }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Calory", "CategoryId", "Description", "Image", "Name", "Portion" },
                values: new object[,]
                {
                    { 1, 231, 1, "Protein = 20.5m, Fat = 15.3m, Carbonhydrate = 5.7m", null, "Terbiyeli Köfte", 0 },
                    { 2, 343, 1, "Protein = 18.2m, Fat = 28.4m, Carbonhydrate = 3.7m", null, "İzmir Köfte", 0 },
                    { 3, 275, 1, "Protein = 24.8m, Fat = 17.2m, Carbonhydrate = 1.8m", null, "Fırın Tavuk", 0 },
                    { 4, 420, 1, "Protein = 29.5m, Fat = 34.8m, Carbonhydrate = 0.9m", null, "Kuzu Tandır", 0 },
                    { 5, 310, 1, "Protein = 22.1m, Fat = 23.7m, Carbonhydrate = 2.4m", null, "Köfte Izgara", 0 },
                    { 6, 489, 1, "Protein = 24.8m, Fat = 23.2m, Carbonhydrate = 26.8m", null, "Beyti", 0 },
                    { 7, 265, 1, "Protein = 9.4m, Fat = 20.1m, Carbonhydrate = 12.7m", null, "Patlıcan Kebabı", 0 },
                    { 8, 380, 1, "Protein = 22.5m, Fat = 28.6m, Carbonhydrate = 8.3m", null, "Hünkar Beğendi", 0 },
                    { 9, 310, 1, "Protein = 17.8m, Fat = 24.5m, Carbonhydrate = 3.2m", null, "Cızlak Kebap", 0 },
                    { 10, 280, 1, "Protein = 18.6m, Fat = 21.4m, Carbonhydrate = 3.8m", null, "Ciğer Sote", 0 },
                    { 11, 320, 1, "Protein = 20.2m, Fat = 12.5m, Carbonhydrate = 28.1m", null, "Tavuklu Pilav", 0 },
                    { 12, 290, 1, "Protein = 26.8m, Fat = 19.3m, Carbonhydrate = 3.7m", null, "Fırın Mantarlı Tavuk", 0 },
                    { 13, 360, 1, "Protein = 22.3m, Fat = 29.8m, Carbonhydrate = 0.9m", null, "Dana Kavurma", 0 },
                    { 14, 180, 1, "Protein = 3.5m, Fat = 9.2m, Carbonhydrate = 22.8m", null, "Zeytinyağlı Yaprak Sarma", 0 },
                    { 15, 450, 1, "Protein = 30.7m, Fat = 36.2m, Carbonhydrate = 1.2m", null, "Kuzu İncik", 0 },
                    { 16, 260, 1, "Protein = 24.1m, Fat = 17.8m, Carbonhydrate = 0.6m", null, "Balık Tava", 0 },
                    { 17, 310, 1, "Protein = 22.5m, Fat = 23.7m, Carbonhydrate = 2.4m", null, "Kağıt Kebabı", 0 },
                    { 18, 280, 1, "Protein = 19.3m, Fat = 20.1m, Carbonhydrate = 3.8m", null, "Tavuk Kapama", 0 },
                    { 19, 340, 1, "Protein = 21.7m, Fat = 25.2m, Carbonhydrate = 6.3m", null, "Ali Nazik Kebabı", 0 },
                    { 20, 390, 1, "Protein = 28.2m, Fat = 31.6m, Carbonhydrate = 0.9m", null, "Kuzu Güveç", 0 },
                    { 21, 480, 1, "Protein = 26.7m, Fat = 33.2m, Carbonhydrate = 18.4m", null, "İskender", 0 },
                    { 22, 310, 1, "Protein = 24.5m, Fat = 21.2m, Carbonhydrate = 0.8m", null, "Fırın Tavuk But", 0 },
                    { 23, 240, 1, "Protein = 18.2m, Fat = 16.9m, Carbonhydrate = 5.7m", null, "Tavuklu Karnabahar", 0 },
                    { 24, 360, 1, "Protein = 25.6m, Fat = 14.8m, Carbonhydrate = 27.9m", null, "Balıklı Pilav", 0 },
                    { 25, 280, 1, "Protein = 20.3m, Fat = 18.9m, Carbonhydrate = 7.1m", null, "Hamsili Ekmek", 0 },
                    { 26, 290, 1, "Protein = 26.8m, Fat = 19.3m, Carbonhydrate = 3.7m", null, "Fırın Mantarlı Tavuk", 0 },
                    { 27, 420, 1, "Protein = 30.5m, Fat = 34.1m, Carbonhydrate = 1.9m", null, "Peynirli Kuzu Kuyma", 0 },
                    { 28, 380, 1, "Protein = 25.2m, Fat = 29.7m, Carbonhydrate = 5.3m", null, "Cevizli Kuzu Güveç", 0 },
                    { 29, 270, 1, "Protein = 23.4m, Fat = 18.1m, Carbonhydrate = 0.6m", null, "Fırın Tavuk Kanat", 0 },
                    { 30, 320, 1, "Protein = 22.8m, Fat = 24.5m, Carbonhydrate = 3.2m", null, "Yogurtlu Tavuk Şiş", 0 },
                    { 31, 180, 2, "Protein = 6.7m, Fat = 12.4m, Carbonhydrate = 15.8m", null, "Fırın Karnabahar Kızartması", 0 },
                    { 32, 250, 2, "Protein = 14.3m, Fat = 18.6m, Carbonhydrate = 7.9m", null, "Patlıcanlı Kıymalı Güveç", 0 },
                    { 33, 320, 2, "Protein = 22.5m, Fat = 25.1m, Carbonhydrate = 2.8m", null, "Kuzu Kapama", 0 },
                    { 34, 150, 2, "Protein = 4.6m, Fat = 10.2m, Carbonhydrate = 11.8m", null, "Zeytinyağlı Pırasa", 0 },
                    { 35, 200, 2, "Protein = 9.8m, Fat = 12.7m, Carbonhydrate = 13.5m", null, "Taze Fasulye Türlü", 0 },
                    { 36, 280, 2, "Protein = 13.6m, Fat = 19.3m, Carbonhydrate = 16.8m", null, "Kabak Karnabahar Graten", 0 },
                    { 37, 320, 2, "Protein = 18.7m, Fat = 24.5m, Carbonhydrate = 7.2m", null, "Sebzeli Kıymalı Börek", 0 },
                    { 38, 180, 2, "Protein = 4.2m, Fat = 13.8m, Carbonhydrate = 11.5m", null, "Zeytinyağlı Enginar", 0 },
                    { 39, 240, 2, "Protein = 12.3m, Fat = 18.9m, Carbonhydrate = 6.5m", null, "Kırmızı Mercimek Koftesi", 0 },
                    { 40, 210, 2, "Protein = 8.5m, Fat = 14.2m, Carbonhydrate = 16.7m", null, "Karnabahar Köftesi", 0 },
                    { 41, 180, 3, "Protein = 6.5m, Fat = 9.2m, Carbonhydrate = 19.8m", null, "Quinoa Salatası", 0 },
                    { 42, 220, 3, "Protein = 5.8m, Fat = 17.1m, Carbonhydrate = 11.3m", null, "Cevizli Kabak Tarator", 0 },
                    { 43, 250, 3, "Protein = 7.3m, Fat = 12.9m, Carbonhydrate = 28.4m", null, "Karnabahar Kuskusu", 0 },
                    { 44, 290, 3, "Protein = 6.7m, Fat = 1.5m, Carbonhydrate = 61.2m", null, "Bulgur Pilavı", 0 },
                    { 45, 310, 3, "Protein = 8.2m, Fat = 4.6m, Carbonhydrate = 66.5m", null, "İncirli Armut Pilavı", 0 },
                    { 46, 180, 3, "Protein = 5.4m, Fat = 3.2m, Carbonhydrate = 33.5m", null, "Yulaf Ezmesi", 0 },
                    { 47, 320, 3, "Protein = 6.9m, Fat = 1.8m, Carbonhydrate = 69.4m", null, "Pirinç Pilavı", 0 },
                    { 48, 250, 3, "Protein = 7.8m, Fat = 3.5m, Carbonhydrate = 47.2m", null, "Fasulye Pilavı", 0 },
                    { 49, 280, 3, "Protein = 10.1m, Fat = 4.7m, Carbonhydrate = 53.8m", null, "Beyaz Nohut Pilavı", 0 },
                    { 50, 210, 3, "Protein = 5.9m, Fat = 2.1m, Carbonhydrate = 43.7m", null, "Kabaklı Bulgur Pilavı", 0 },
                    { 51, 180, 4, "Protein = 3.5m, Fat = 12.6m, Carbonhydrate = 15.2m", null, "Zeytinyağlı Yaprak Sarma", 0 },
                    { 52, 150, 4, "Protein = 2.8m, Fat = 10.3m, Carbonhydrate = 12.4m", null, "Zeytinyağlı Kabak Dolması", 0 },
                    { 53, 120, 4, "Protein = 2.4m, Fat = 8.1m, Carbonhydrate = 9.7m", null, "Zeytinyağlı Pırasa", 0 },
                    { 54, 140, 4, "Protein = 3.1m, Fat = 8.8m, Carbonhydrate = 11.5m", null, "Zeytinyağlı Taze Fasulye", 0 },
                    { 55, 200, 4, "Protein = 4.6m, Fat = 15.4m, Carbonhydrate = 14.7m", null, "Zeytinyağlı Enginar", 0 },
                    { 56, 160, 4, "Protein = 3.2m, Fat = 11.5m, Carbonhydrate = 12.9m", null, "Zeytinyağlı Karnabahar", 0 },
                    { 57, 130, 4, "Protein = 2.9m, Fat = 8.6m, Carbonhydrate = 10.7m", null, "Zeytinyağlı Bamya", 0 },
                    { 58, 110, 4, "Protein = 2.1m, Fat = 7.2m, Carbonhydrate = 9.4m", null, "Zeytinyağlı Ispanak", 0 },
                    { 59, 140, 4, "Protein = 3.3m, Fat = 9.2m, Carbonhydrate = 11.8m", null, "Zeytinyağlı Pırasa Yemeği", 0 },
                    { 60, 150, 4, "Protein = 3.7m, Fat = 9.8m, Carbonhydrate = 12.5m", null, "Zeytinyağlı Taze Fasulye Pilaki", 0 },
                    { 71, 150, 5, "Protein = 9.5m, Fat = 3.2m, Carbonhydrate = 21.8m", null, "Mercimek Çorbası", 0 },
                    { 72, 120, 5, "Protein = 7.8m, Fat = 5.1m, Carbonhydrate = 12.6m", null, "Tarator Çorbası", 0 },
                    { 73, 110, 5, "Protein = 4.2m, Fat = 2.8m, Carbonhydrate = 18.5m", null, "Domates Çorbası", 0 },
                    { 74, 180, 5, "Protein = 12.3m, Fat = 4.6m, Carbonhydrate = 23.7m", null, "Tavuklu Şehriye Çorbası", 0 },
                    { 75, 160, 5, "Protein = 8.9m, Fat = 3.5m, Carbonhydrate = 24.2m", null, "Ezogelin Çorbası", 0 },
                    { 76, 140, 5, "Protein = 7.4m, Fat = 6.8m, Carbonhydrate = 15.9m", null, "Yoğurtlu Çorba", 0 },
                    { 77, 220, 5, "Protein = 5.6m, Fat = 18.3m, Carbonhydrate = 9.7m", null, "Kremalı Mantar Çorbası", 0 },
                    { 78, 130, 5, "Protein = 3.7m, Fat = 7.2m, Carbonhydrate = 14.8m", null, "Kabak Çorbası", 0 },
                    { 79, 160, 5, "Protein = 9.8m, Fat = 2.6m, Carbonhydrate = 25.4m", null, "Kırmızı Mercimek Çorbası", 0 },
                    { 80, 528, 6, "Protein = 7.6m, Fat = 29.8m, Carbonhydrate = 63.3m", null, "İrmik Helvası", 0 },
                    { 81, 347, 6, "Protein = 8.2m, Fat = 7.2m, Carbonhydrate = 67.2m", null, "Sütlaç", 0 },
                    { 82, 450, 6, "Protein = 7.5m, Fat = 29.5m, Carbonhydrate = 40.2m", null, "Baklava", 0 },
                    { 83, 280, 6, "Protein = 5.8m, Fat = 12.6m, Carbonhydrate = 35.2m", null, "Kazandibi", 0 },
                    { 84, 315, 6, "Protein = 6.2m, Fat = 15.8m, Carbonhydrate = 38.1m", null, "Revani", 0 },
                    { 85, 207, 6, "Protein = 5.4m, Fat = 11.2m, Carbonhydrate = 22.6m", null, "Dondurma", 0 },
                    { 86, 127, 7, "Protein = 2.5m, Fat = 8.4m, Carbonhydrate = 11.6m", null, "Domates Salatası", 0 },
                    { 87, 75, 7, "Protein = 3.2m, Fat = 5.6m, Carbonhydrate = 3.9m", null, "Cacık", 0 },
                    { 88, 64, 7, "Protein = 3.9m, Fat = 4.7m, Carbonhydrate = 2.9m", null, "Roka Salatası", 0 },
                    { 89, 184, 7, "Protein = 4.8m, Fat = 16.7m, Carbonhydrate = 3.2m", null, "Ceasar Salatası", 0 },
                    { 90, 95, 7, "Protein = 3.1m, Fat = 6.4m, Carbonhydrate = 7.6m", null, "Mevsim Salatası", 0 },
                    { 92, 63, 8, "Protein = 1.0m, Fat = 0.2m, Carbonhydrate = 15.3m", null, "Kayısı", 0 },
                    { 93, 96, 8, "Protein = 1.3m, Fat = 0.3m, Carbonhydrate = 25.0m", null, "Muz", 0 },
                    { 94, 63, 8, "Protein = 1.1m, Fat = 0.2m, Carbonhydrate = 16.0m", null, "Kiraz", 0 },
                    { 95, 69, 8, "Protein = 0.7m, Fat = 0.2m, Carbonhydrate = 17.5m", null, "Üzüm", 0 },
                    { 96, 73, 8, "Protein = 0.9m, Fat = 0.2m, Carbonhydrate = 18.0m", null, "Kavun", 0 },
                    { 97, 30, 8, "Protein = 0.6m, Fat = 0.2m, Carbonhydrate = 8.0m", null, "Karpuz", 0 },
                    { 98, 43, 8, "Protein = 1.0m, Fat = 0.2m, Carbonhydrate = 8.3m", null, "Portakal", 0 },
                    { 99, 70, 8, "Protein = 0.8m, Fat = 0.2m, Carbonhydrate = 13.5m", null, "Mandalina", 0 },
                    { 100, 38, 8, "Protein = 0.9m, Fat = 0.2m, Carbonhydrate = 9.6m", null, "Malta eriği", 0 },
                    { 101, 52, 8, "Protein = 0.3m, Fat = 0.2m, Carbonhydrate = 14.0m", null, "Elma", 0 },
                    { 102, 76, 9, "Protein = 0.0m, Fat = 0.0m, Carbonhydrate = 20.0m", null, "Toz Şeker", 0 },
                    { 103, 121, 9, "Protein = 6.0m, Fat = 10.0m, Carbonhydrate = 1.0m", null, "Peynir (Kaşar)", 0 },
                    { 104, 87, 9, "Protein = 7.0m, Fat = 6.0m, Carbonhydrate = 1.0m", null, "Peynir(Beyaz)", 0 },
                    { 105, 96, 9, "Protein = 0.3m, Fat = 0.1m, Carbonhydrate = 25.0m", null, "Reçel", 0 },
                    { 106, 221, 9, "Protein = 0.3m, Fat = 24.0m, Carbonhydrate = 0.0m", null, "Yağ(Margarin)", 0 },
                    { 107, 80, 9, "Protein = 6.0m, Fat = 5.0m, Carbonhydrate = 1.0m", null, "Yumurta", 0 },
                    { 108, 43, 9, "Protein = 0.5m, Fat = 4.0m, Carbonhydrate = 0.0m", null, "Zeytin(Yeşil)", 0 },
                    { 109, 62, 9, "Protein = 0.5m, Fat = 6.0m, Carbonhydrate = 1.0m", null, "Zeytin(Siyah)", 0 },
                    { 110, 276, 9, "Protein = 9.0m, Fat = 1.0m, Carbonhydrate = 56.0m", null, "Ekmek", 0 },
                    { 111, 61, 10, "Protein = 3.0m, Fat = 3.0m, Carbonhydrate = 5.0m", null, "İnek Sütü", 0 },
                    { 112, 63, 10, "Protein = 4.0m, Fat = 3.0m, Carbonhydrate = 4.0m", null, "Yoğurt", 0 },
                    { 115, 140, 11, "Protein = 0.0m, Fat = 0.0m, Carbonhydrate = 39.0m", null, "Kola", 0 },
                    { 116, 110, 11, "Protein = 2.0m, Fat = 0.5m, Carbonhydrate = 26.0m", null, "Portakal Suyu", 0 },
                    { 117, 120, 11, "Protein = 0.5m, Fat = 0.0m, Carbonhydrate = 30.0m", null, "Limonata", 0 },
                    { 118, 90, 11, "Protein = 0.0m, Fat = 0.0m, Carbonhydrate = 24.0m", null, "Gazoz", 0 },
                    { 119, 200, 11, "Protein = 2.5m, Fat = 1.0m, Carbonhydrate = 45.0m", null, "Meyve Smoothie", 0 },
                    { 120, 5, 12, "Protein = 0.5m, Fat = 0.2m, Carbonhydrate = 0.0m", null, "Türk Kahvesi", 0 },
                    { 121, 2, 12, "Protein = 0.1m, Fat = 0.0m, Carbonhydrate = 0.5m", null, "Siyah Çay", 0 },
                    { 122, 0, 12, "Protein = 0.0m, Fat = 0.0m, Carbonhydrate = 0.0m", null, "Yeşil Çay", 0 },
                    { 123, 4, 12, "Protein = 0.1m, Fat = 0.0m, Carbonhydrate = 0.8m", null, "Nane Limon Çayı", 0 },
                    { 124, 150, 12, "Protein = 1.5m, Fat = 2.0m, Carbonhydrate = 30.0m", null, "Salep", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FoodMeals_FoodId",
                table: "FoodMeals",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_CategoryId",
                table: "Foods",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Meals_UserDailyActivityId",
                table: "Meals",
                column: "UserDailyActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDailyActivities_UserId",
                table: "UserDailyActivities",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodMeals");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "UserDailyActivities");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
