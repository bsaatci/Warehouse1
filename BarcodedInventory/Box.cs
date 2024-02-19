using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BarcodedInventory
{
    public class Box
    {
        public int BoxId { get; set; }
        public string? Barcode { get; set; }
        public string? Description { get; set; }
        public int? PalletId { get; set; }
        public int? MainBoxId { get; set; }
        public virtual Pallet Pallet { get; set; } = null!;
        public virtual Box MainBox { get; set; } = null!;
        public virtual ObservableCollectionListSource<Box> InnerBoxes { get; } = new();


    }
}
