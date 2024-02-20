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
        public void Dispose(DataContext context)
        {
            
            if (MainBoxId != null)
            {
                var mainBox = context.Boxes.FirstOrDefault(x=>x.BoxId == this.MainBoxId );
                if (mainBox != null)
                {
                    var otherBoxesInMain = context.Boxes.Where(x => x.MainBoxId == MainBoxId && x.BoxId != BoxId ).ToList();
                    foreach (var otherBox in otherBoxesInMain)
                    {
                        otherBox.MainBoxId = null;
                        otherBox.PalletId = mainBox.PalletId;
                        context.SaveChanges();
                    }
                    mainBox.Dispose(context);
                }
            }

            var otherBoxesWithin = context.Boxes.Where(x => x.MainBoxId == BoxId).ToList();
            foreach (var otherBox in otherBoxesWithin.Where(otherBox => context.Boxes.Any(x => x.BoxId == otherBox.BoxId)))
            {
                context.Remove(otherBox);
                context.SaveChanges();
            }

            if (!context.Boxes.Any(x => x.BoxId == this.BoxId)) return;
            context.Remove(this);
            context.SaveChanges();

        }

    }
}
