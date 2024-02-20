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
        boxesBindingSource = new BindingSource(components);
        label1 = new Label();
        TextBoxesToTake = new TextBox();
        listBoxMessages = new ListBox();
        ((System.ComponentModel.ISupportInitialize)DataGridViewPallet).BeginInit();
        ((System.ComponentModel.ISupportInitialize)palletBindingSource).BeginInit();
        ((System.ComponentModel.ISupportInitialize)DataGridViewBoxOnPallet).BeginInit();
        ((System.ComponentModel.ISupportInitialize)boxesBindingSource).BeginInit();
        SuspendLayout();
        // 
        // ButtonTakeBox
        // 
        ButtonTakeBox.Location = new Point(178, 124);
        ButtonTakeBox.Name = "ButtonTakeBox";
        ButtonTakeBox.Size = new Size(150, 57);
        ButtonTakeBox.TabIndex = 1;
        ButtonTakeBox.Text = "Take Box(es)";
        ButtonTakeBox.UseVisualStyleBackColor = true;
        ButtonTakeBox.Click += ButtonTakeBox_Click;
        // 
        // LabelPalette
        // 
        LabelPalette.AutoSize = true;
        LabelPalette.Location = new Point(42, 196);
        LabelPalette.Name = "LabelPalette";
        LabelPalette.Size = new Size(85, 17);
        LabelPalette.TabIndex = 3;
        LabelPalette.Text = "Select Palette";
        // 
        // LabelBarcode
        // 
        LabelBarcode.AutoSize = true;
        LabelBarcode.Location = new Point(42, 313);
        LabelBarcode.Name = "LabelBarcode";
        LabelBarcode.Size = new Size(98, 17);
        LabelBarcode.TabIndex = 4;
        LabelBarcode.Text = "Available Boxes";
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
        DataGridViewPallet.Location = new Point(178, 196);
        DataGridViewPallet.MultiSelect = false;
        DataGridViewPallet.Name = "DataGridViewPallet";
        DataGridViewPallet.ReadOnly = true;
        DataGridViewPallet.RowHeadersVisible = false;
        DataGridViewPallet.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
        DataGridViewPallet.RowTemplate.ReadOnly = true;
        DataGridViewPallet.RowTemplate.Resizable = DataGridViewTriState.False;
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
        DataGridViewBoxOnPallet.AllowUserToResizeColumns = false;
        DataGridViewBoxOnPallet.AllowUserToResizeRows = false;
        DataGridViewBoxOnPallet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DataGridViewBoxOnPallet.Location = new Point(178, 299);
        DataGridViewBoxOnPallet.Name = "DataGridViewBoxOnPallet";
        DataGridViewBoxOnPallet.ReadOnly = true;
        DataGridViewBoxOnPallet.RowHeadersVisible = false;
        DataGridViewBoxOnPallet.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
        DataGridViewBoxOnPallet.RowTemplate.ReadOnly = true;
        DataGridViewBoxOnPallet.RowTemplate.Resizable = DataGridViewTriState.False;
        DataGridViewBoxOnPallet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        DataGridViewBoxOnPallet.Size = new Size(240, 150);
        DataGridViewBoxOnPallet.TabIndex = 6;
        // 
        // boxesBindingSource
        // 
        boxesBindingSource.DataMember = "Boxes";
        boxesBindingSource.DataSource = palletBindingSource;
        // 
        // label1
        // 
        label1.Location = new Point(42, 42);
        label1.Name = "label1";
        label1.Size = new Size(100, 51);
        label1.TabIndex = 8;
        label1.Text = "Enter barcodes to take boxes";
        // 
        // TextBoxesToTake
        // 
        TextBoxesToTake.AcceptsReturn = true;
        TextBoxesToTake.Location = new Point(178, 39);
        TextBoxesToTake.Multiline = true;
        TextBoxesToTake.Name = "TextBoxesToTake";
        TextBoxesToTake.Size = new Size(150, 79);
        TextBoxesToTake.TabIndex = 9;
        TextBoxesToTake.Text = "abc20";
        // 
        // listBoxMessages
        // 
        listBoxMessages.FormattingEnabled = true;
        listBoxMessages.ItemHeight = 17;
        listBoxMessages.Location = new Point(468, 24);
        listBoxMessages.Name = "listBoxMessages";
        listBoxMessages.Size = new Size(372, 157);
        listBoxMessages.TabIndex = 10;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(872, 487);
        Controls.Add(listBoxMessages);
        Controls.Add(TextBoxesToTake);
        Controls.Add(label1);
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
    private Label label1;
    private TextBox TextBoxesToTake;
    private ListBox listBoxMessages;
}