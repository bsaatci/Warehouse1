using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Security.Cryptography.Xml;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarcodedInventory
{
    public class Box 
    {
        public int BoxId { get; set; }
        public string? Barcode { get; set; }
        public string? Description { get; set; }
        public int? PalletId { get; set; }
        public int? MainBoxId { get; set; }
        public bool Deleted { get; set; }
        // public virtual Pallet Pallet { get; set; } = null!;
        // public virtual Box MainBox { get; set; } = null!;
        public void Dispose()
        {
            using (var context = new DataContext())
            {
                if (MainBoxId != null)
                {
                    var mainBox = context.Boxes.First(x=>x.BoxId == this.MainBoxId && !x.Deleted);
                    var otherBoxesInMain = context.Boxes.Where(x => x.MainBoxId == MainBoxId && x.BoxId != BoxId && !x.Deleted).ToList();
                    foreach (var otherBox in otherBoxesInMain)
                    {
                        otherBox.MainBoxId = null;
                        otherBox.PalletId = mainBox.PalletId;
                        context.SaveChanges();
                    }
                    mainBox.Dispose();
                }

                var otherBoxesWithin = context.Boxes.Where(x => x.MainBoxId == BoxId).ToList();
                foreach (var otherBox in otherBoxesWithin)
                {
                    context.Remove(otherBox);
                    context.SaveChanges();
                }


                
            }
        }

    }
}
