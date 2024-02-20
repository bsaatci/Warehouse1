using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BarcodedInventory
{
    public class DataContext : DbContext
    {
        public DbSet<Pallet> Pallets { get; set; }
        public DbSet<Box> Boxes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder.UseSqlite("Data Source=inventory.db").EnableSensitiveDataLogging();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pallet>().HasData(
                new Pallet { PalletId = 1, PalletName = "Pallet P1" },
                new Pallet { PalletId = 2, PalletName = "Pallet P2" },
                new Pallet { PalletId = 3, PalletName = "Pallet P3" });

            modelBuilder.Entity<Box>().HasData(
                new Box { BoxId = 1, PalletId = 1, Barcode = "abc10", Description = "BC1", Deleted = false},
                new Box { BoxId = 2, PalletId = null, Barcode = "abc11", Description = "BC2", MainBoxId = 1, Deleted = false },
                new Box { BoxId = 3, PalletId = null, Barcode = "abc12", Description = "BC3", MainBoxId = 1, Deleted = false },
                new Box { BoxId = 4, PalletId = 1, Barcode = "abc13", Description = "BC4", Deleted = false },
                new Box { BoxId = 5, PalletId = null, Barcode = "abc14", Description = "BC5", MainBoxId = 4, Deleted = false },
                new Box { BoxId = 6, PalletId = null, Barcode = "abc15", Description = "BC6", MainBoxId = 4, Deleted = false },
                new Box { BoxId = 7, PalletId = null, Barcode = "abc16", Description = "BC7", MainBoxId = 4, Deleted = false },
                new Box { BoxId = 8, PalletId = 2, Barcode = "abc17", Description = "BC8", Deleted = false },
                new Box { BoxId = 9, PalletId = 2, Barcode = "abc18", Description = "BC9", Deleted = false },
                new Box { BoxId = 10, PalletId = 2, Barcode = "abc19", Description = "BC10",  Deleted = false },
                new Box { BoxId = 11, PalletId = null, Barcode = "abc20", Description = "BC11", MainBoxId = 10, Deleted = false },
                new Box { BoxId = 12, PalletId = null, Barcode = "abc21", Description = "BC12", MainBoxId = 11, Deleted = false },
                new Box { BoxId = 13, PalletId = null, Barcode = "abc22", Description = "BC13", MainBoxId = 12, Deleted = false },
                new Box { BoxId = 14, PalletId = 2, Barcode = "abc23", Description = "BC14", Deleted = false },
                new Box { BoxId = 15, PalletId = 3, Barcode = "abc24", Description = "BC15", Deleted = false }
                );
        }
    }
}
