using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace BarcodedInventory;

public partial class MainForm : Form
{
    private DataContext? dbContext;
    private List<string> messages = new List<string>();
    public MainForm()
    {
        InitializeComponent();
    }
    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        listBoxMessages.Items.Clear();

        this.dbContext = new DataContext();

        // Uncomment the line below to start fresh to keep changes in database.
        this.dbContext.Database.EnsureDeleted();
        this.dbContext.Database.EnsureCreated();

        this.dbContext.Pallets.Load();
        dbContext.Boxes.Load();


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
        if (this.dbContext != null)
        {
            var category = (Pallet)this.DataGridViewPallet.CurrentRow.DataBoundItem;

            if (category != null)
            {
                dbContext.Entry(category).Collection(e => e.Boxes).Load();
            }
        }
    }

    private void ButtonTakeBox_Click(object sender, EventArgs e)
    {
        var listOfBoxes = new List<Box>();
        foreach (var code in TextBoxesToTake.Text.Split(new []{Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries))
        {
            var box = dbContext.Boxes.FirstOrDefault(x => x.Barcode == code && !x.Deleted);
            if(box == null)
                listBoxMessages.Items.Add($"{code} cannot be found!");
            else
            {
                listOfBoxes.Add(box);
            }
        }

        foreach (var realBox in listOfBoxes)
        {
            listBoxMessages.Items.Add($"{realBox.Description} taken.");
            realBox.Dispose();
        }

        var category = (Pallet)this.DataGridViewPallet.CurrentRow.DataBoundItem;

        if (category != null)
        {
            dbContext.Entry(category).Collection(e => e.Boxes).Load();
        }


    }
    
}