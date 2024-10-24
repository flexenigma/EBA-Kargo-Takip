using EBA_Kargo_Takip;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

public class KargoTakipContext : DbContext
{
    public KargoTakipContext(DbContextOptions<KargoTakipContext> options) : base(options)
    {
    }

    public DbSet<Kullanici> Kullanicilar { get; set; }
    public DbSet<Kargo> Kargolar { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // Model konfigürasyonu burada yapılır
    }
}
