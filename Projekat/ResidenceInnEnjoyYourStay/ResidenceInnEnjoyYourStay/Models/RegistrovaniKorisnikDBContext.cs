﻿using Microsoft.Data.Entity;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace ResidenceInnEnjoyYourStay.Models
{
    public class RegistrovaniKorisnikDBContext : DbContext
    {
        public DbSet<RegistrovaniKorisnikModel> korisnici { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string databaseFilePath = "Ooadbaza.db";
            try
            {
                databaseFilePath = Path.Combine(ApplicationData.Current.LocalFolder.Path, databaseFilePath);
            }
            catch (InvalidOperationException) { }
            optionsBuilder.UseSqlite($"Data source = {databaseFilePath}");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //jedno od polja je image da se zna šta je zapravo predstavlja byte[]
            modelBuilder.Entity<RegistrovaniKorisnikModel>().Property(p => p.ProfilnaSlika).HasColumnType("image");
        }
    }
}
