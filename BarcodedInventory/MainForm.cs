using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace BarcodedInventory;

public partial class MainForm : Form
{
    private DataContext? _dbContext;
    private List<string> messages = new List<string>();
    public MainForm()
    {
        InitializeComponent();
    }
    #region EventHandlers
    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        

        this._dbContext = new DataContext();

        ResetDatabase();

        ResetForm();
    }

    protected override void OnClosing(CancelEventArgs e)
    {
        base.OnClosing(e);

        this._dbContext?.Dispose();
        this._dbContext = null;
    }

    private void DataGridViewPallet_SelectionChanged(object sender, EventArgs e)
    {
        PopulateBoxes(_dbContext);
    }
    

    private void ButtonResetDatabase_Click(object sender, EventArgs e)
    {
        ResetForm();
    }
    #endregion

    #region Private Methods

    private void PopulateBoxes(DataContext? dbContext)
    {
        if (dbContext != null)
        {
            var pallet = (Pallet)this.DataGridViewPallet.CurrentRow.DataBoundItem;

            if (pallet != null)
            {
                DataGridViewBoxOnPallet.DataSource = pallet.Boxes.Select(x => new { x.Barcode, x.Description }).ToList();
            }
        }
    }
    private void ResetDatabase()
    {
        this._dbContext.Database.EnsureDeleted();
        this._dbContext.Database.EnsureCreated();
    }
    private void ResetForm()
    {
        listBoxMessages.Items.Clear();
        ResetDatabase();
        _dbContext.Pallets.Load();
        _dbContext.Boxes.Load();


        this.palletBindingSource.DataSource = _dbContext.Pallets.Local.ToBindingList();
        PopulateBoxes(_dbContext);
    }

    private void ButtonTakeBox_Click(object sender, EventArgs e)
    {
        var listOfBoxes = GetListOfBoxes(_dbContext, TextBoxesToTake.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries));

        DisposeBoxes(_dbContext, listOfBoxes);

        PopulateBoxes(_dbContext);
    }
    #endregion

    #region Public Methods
    public List<Box> GetListOfBoxes(DataContext? dbContext, string[] inputList)
    {
        var listOfBoxes = new List<Box>();
        if (dbContext != null)
        {
            foreach (var code in inputList)
            {
                var box = dbContext.Boxes.FirstOrDefault(x => x.Barcode == code);
                if (box == null)
                    listBoxMessages.Items.Add($"{code} cannot be found!");
                else
                {
                    listOfBoxes.Add(box);
                }
            }
        }

        return listOfBoxes;
    }
    public void DisposeBoxes(DataContext? dbContext, List<Box> listOfBoxes)
    {
        if (dbContext != null)
        {
            foreach (var realBox in listOfBoxes)
            {
                listBoxMessages.Items.Add($"{realBox.Description} is taken.");
                realBox.Dispose(dbContext);
            }
        }
    }
    #endregion

}