namespace BarcodedInventory;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        ButtonTakeBox = new Button();
        LabelPalette = new Label();
        LabelBarcode = new Label();
        DataGridViewPallet = new DataGridView();
        palletNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        palletBindingSource = new BindingSource(components);
        DataGridViewBoxOnPallet = new DataGridView();
        boxIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        barcodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        palletIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        mainBoxIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        palletDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        mainBoxDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        boxesBindingSource = new BindingSource(components);
        ((System.ComponentModel.ISupportInitialize)DataGridViewPallet).BeginInit();
        ((System.ComponentModel.ISupportInitialize)palletBindingSource).BeginInit();
        ((System.ComponentModel.ISupportInitialize)DataGridViewBoxOnPallet).BeginInit();
        ((System.ComponentModel.ISupportInitialize)boxesBindingSource).BeginInit();
        SuspendLayout();
        // 
        // ButtonTakeBox
        // 
        ButtonTakeBox.Location = new Point(253, 317);
        ButtonTakeBox.Name = "ButtonTakeBox";
        ButtonTakeBox.Size = new Size(117, 57);
        ButtonTakeBox.TabIndex = 1;
        ButtonTakeBox.Text = "Take Box(es)";
        ButtonTakeBox.UseVisualStyleBackColor = true;
        // 
        // LabelPalette
        // 
        LabelPalette.AutoSize = true;
        LabelPalette.Location = new Point(36, 36);
        LabelPalette.Name = "LabelPalette";
        LabelPalette.Size = new Size(85, 17);
        LabelPalette.TabIndex = 3;
        LabelPalette.Text = "Select Palette";
        // 
        // LabelBarcode
        // 
        LabelBarcode.AutoSize = true;
        LabelBarcode.Location = new Point(36, 153);
        LabelBarcode.Name = "LabelBarcode";
        LabelBarcode.Size = new Size(88, 17);
        LabelBarcode.TabIndex = 4;
        LabelBarcode.Text = "Select Box(es)";
        // 
        // DataGridViewPallet
        // 
        DataGridViewPallet.AllowUserToAddRows = false;
        DataGridViewPallet.AllowUserToDeleteRows = false;
        DataGridViewPallet.AutoGenerateColumns = false;
        DataGridViewPallet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DataGridViewPallet.ColumnHeadersVisible = false;
        DataGridViewPallet.Columns.AddRange(new DataGridViewColumn[] { palletNameDataGridViewTextBoxColumn });
        DataGridViewPallet.DataSource = palletBindingSource;
        DataGridViewPallet.Location = new Point(172, 36);
        DataGridViewPallet.MultiSelect = false;
        DataGridViewPallet.Name = "DataGridViewPallet";
        DataGridViewPallet.ReadOnly = true;
        DataGridViewPallet.RowHeadersVisible = false;
        DataGridViewPallet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        DataGridViewPallet.Size = new Size(240, 97);
        DataGridViewPallet.TabIndex = 5;
        DataGridViewPallet.SelectionChanged += DataGridViewPallet_SelectionChanged;
        // 
        // palletNameDataGridViewTextBoxColumn
        // 
        palletNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        palletNameDataGridViewTextBoxColumn.DataPropertyName = "PalletName";
        palletNameDataGridViewTextBoxColumn.FillWeight = 200F;
        palletNameDataGridViewTextBoxColumn.HeaderText = "PalletName";
        palletNameDataGridViewTextBoxColumn.Name = "palletNameDataGridViewTextBoxColumn";
        palletNameDataGridViewTextBoxColumn.ReadOnly = true;
        palletNameDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
        // 
        // palletBindingSource
        // 
        palletBindingSource.DataSource = typeof(Pallet);
        // 
        // DataGridViewBoxOnPallet
        // 
        DataGridViewBoxOnPallet.AllowUserToAddRows = false;
        DataGridViewBoxOnPallet.AllowUserToDeleteRows = false;
        DataGridViewBoxOnPallet.AutoGenerateColumns = false;
        DataGridViewBoxOnPallet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DataGridViewBoxOnPallet.Columns.AddRange(new DataGridViewColumn[] { boxIdDataGridViewTextBoxColumn, barcodeDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, palletIdDataGridViewTextBoxColumn, mainBoxIdDataGridViewTextBoxColumn, palletDataGridViewTextBoxColumn, mainBoxDataGridViewTextBoxColumn });
        DataGridViewBoxOnPallet.DataSource = boxesBindingSource;
        DataGridViewBoxOnPallet.Location = new Point(172, 139);
        DataGridViewBoxOnPallet.Name = "DataGridViewBoxOnPallet";
        DataGridViewBoxOnPallet.ReadOnly = true;
        DataGridViewBoxOnPallet.RowHeadersVisible = false;
        DataGridViewBoxOnPallet.Size = new Size(603, 150);
        DataGridViewBoxOnPallet.TabIndex = 6;
        // 
        // boxIdDataGridViewTextBoxColumn
        // 
        boxIdDataGridViewTextBoxColumn.DataPropertyName = "BoxId";
        boxIdDataGridViewTextBoxColumn.HeaderText = "BoxId";
        boxIdDataGridViewTextBoxColumn.Name = "boxIdDataGridViewTextBoxColumn";
        boxIdDataGridViewTextBoxColumn.ReadOnly = true;
        boxIdDataGridViewTextBoxColumn.Visible = false;
        // 
        // barcodeDataGridViewTextBoxColumn
        // 
        barcodeDataGridViewTextBoxColumn.DataPropertyName = "Barcode";
        barcodeDataGridViewTextBoxColumn.HeaderText = "Barcode";
        barcodeDataGridViewTextBoxColumn.Name = "barcodeDataGridViewTextBoxColumn";
        barcodeDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // descriptionDataGridViewTextBoxColumn
        // 
        descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
        descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
        descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
        descriptionDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // palletIdDataGridViewTextBoxColumn
        // 
        palletIdDataGridViewTextBoxColumn.DataPropertyName = "PalletId";
        palletIdDataGridViewTextBoxColumn.HeaderText = "PalletId";
        palletIdDataGridViewTextBoxColumn.Name = "palletIdDataGridViewTextBoxColumn";
        palletIdDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // mainBoxIdDataGridViewTextBoxColumn
        // 
        mainBoxIdDataGridViewTextBoxColumn.DataPropertyName = "MainBoxId";
        mainBoxIdDataGridViewTextBoxColumn.HeaderText = "MainBoxId";
        mainBoxIdDataGridViewTextBoxColumn.Name = "mainBoxIdDataGridViewTextBoxColumn";
        mainBoxIdDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // palletDataGridViewTextBoxColumn
        // 
        palletDataGridViewTextBoxColumn.DataPropertyName = "Pallet";
        palletDataGridViewTextBoxColumn.HeaderText = "Pallet";
        palletDataGridViewTextBoxColumn.Name = "palletDataGridViewTextBoxColumn";
        palletDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // mainBoxDataGridViewTextBoxColumn
        // 
        mainBoxDataGridViewTextBoxColumn.DataPropertyName = "MainBox";
        mainBoxDataGridViewTextBoxColumn.HeaderText = "MainBox";
        mainBoxDataGridViewTextBoxColumn.Name = "mainBoxDataGridViewTextBoxColumn";
        mainBoxDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // boxesBindingSource
        // 
        boxesBindingSource.DataMember = "Boxes";
        boxesBindingSource.DataSource = palletBindingSource;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1185, 487);
        Controls.Add(DataGridViewBoxOnPallet);
        Controls.Add(DataGridViewPallet);
        Controls.Add(LabelBarcode);
        Controls.Add(LabelPalette);
        Controls.Add(ButtonTakeBox);
        Name = "MainForm";
        Text = "Inventory";
        ((System.ComponentModel.ISupportInitialize)DataGridViewPallet).EndInit();
        ((System.ComponentModel.ISupportInitialize)palletBindingSource).EndInit();
        ((System.ComponentModel.ISupportInitialize)DataGridViewBoxOnPallet).EndInit();
        ((System.ComponentModel.ISupportInitialize)boxesBindingSource).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Button ButtonTakeBox;
    private Label LabelPalette;
    private Label LabelBarcode;
    private DataGridView DataGridViewPallet;
    private BindingSource palletBindingSource;
    private DataGridViewTextBoxColumn palletNameDataGridViewTextBoxColumn;
    private DataGridView DataGridViewBoxOnPallet;
    private BindingSource boxesBindingSource;
    private DataGridViewTextBoxColumn boxIdDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn palletIdDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn mainBoxIdDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn palletDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn mainBoxDataGridViewTextBoxColumn;
}