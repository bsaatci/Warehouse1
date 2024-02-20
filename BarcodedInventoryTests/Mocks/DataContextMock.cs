using BarcodedInventory;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodedInventoryTests
{
    public class DataContextMock : DataContext
    {
        private static readonly object _lock = new();
        private static bool _databaseInitialized;

        public DataContextMock() 
        {
            lock (_lock)
            {
                if (!_databaseInitialized)
                {
                    using (var context = CreateContext())
                    {
                        context.Database.EnsureDeleted();
                        context.Database.EnsureCreated();

                    }

                    _databaseInitialized = true;
                }
            }
        }

        public DataContext CreateContext()
            => new DataContext();
    }
}
