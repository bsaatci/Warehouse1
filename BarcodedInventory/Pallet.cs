using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace BarcodedInventory
{
    public class Pallet
    {
        public int PalletId { get; set; }
        public string? PalletName { get; set; }
        public virtual ObservableCollectionListSource<Box> Boxes { get; } = new();
    }
}
