using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace BarcodedInventory;

public partial class MainForm : Form
{
    private DataContext? dbContext;
    public MainForm()
    {
        InitializeComponent();
    }
    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        this.dbContext = new DataContext();

        // Uncomment the line below to start fresh to keep changes in database.
        this.dbContext.Database.EnsureDeleted();
        this.dbContext.Database.EnsureCreated();

        this.dbContext.Pallets.Load();


        this.palletBindingSource.DataSource = dbContext.Pallets.Local.ToBindingList();
    }

    protected override void OnClosing(CancelEventArgs e)
    {
        base.OnClosing(e);

        this.dbContext?.Dispose();
        this.dbContext = null;
    }

    private void DataGridViewPallet_SelectionChanged(object sender, EventArgs e)
    {
        var category = (Pallet)this.DataGridViewPallet.CurrentRow.DataBoundItem;

        if (category != null)
        {
            dbContext.Entry(category).Collection(e => e.Boxes).Load();
        }
    }
}