using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace BarcodedInventory
{
    public sealed class Pallet
    {
        public int PalletId { get; set; }
        public string? PalletName { get; set; }
        public ObservableCollectionListSource<Box> Boxes { get; } = new();
    }
}
