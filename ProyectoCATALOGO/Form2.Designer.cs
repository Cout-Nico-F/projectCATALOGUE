namespace ProyectoCATALOGO
{
  partial class Form2
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.Label nombreLabel;
      System.Windows.Forms.Label creadoEnLabel;
      System.Windows.Forms.Label premiosGanadosLabel;
      System.Windows.Forms.Label favoritosLabel;
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
      this.dataSet_IceCreamsCatalogue = new ProyectoCATALOGO.DataSet_IceCreamsCatalogue();
      this.iceCreamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.iceCreamsTableAdapter = new ProyectoCATALOGO.DataSet_IceCreamsCatalogueTableAdapters.IceCreamsTableAdapter();
      this.tableAdapterManager = new ProyectoCATALOGO.DataSet_IceCreamsCatalogueTableAdapters.TableAdapterManager();
      this.iceCreamsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
      this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
      this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
      this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.nombreTextBox = new System.Windows.Forms.TextBox();
      this.creadoEnTextBox = new System.Windows.Forms.TextBox();
      this.premiosGanadosTextBox = new System.Windows.Forms.TextBox();
      this.favoritosTextBox = new System.Windows.Forms.TextBox();
      this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
      this.iceCreamsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
      nombreLabel = new System.Windows.Forms.Label();
      creadoEnLabel = new System.Windows.Forms.Label();
      premiosGanadosLabel = new System.Windows.Forms.Label();
      favoritosLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dataSet_IceCreamsCatalogue)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.iceCreamsBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.iceCreamsBindingNavigator)).BeginInit();
      this.iceCreamsBindingNavigator.SuspendLayout();
      this.SuspendLayout();
      // 
      // dataSet_IceCreamsCatalogue
      // 
      this.dataSet_IceCreamsCatalogue.DataSetName = "DataSet_IceCreamsCatalogue";
      this.dataSet_IceCreamsCatalogue.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // iceCreamsBindingSource
      // 
      this.iceCreamsBindingSource.DataMember = "IceCreams";
      this.iceCreamsBindingSource.DataSource = this.dataSet_IceCreamsCatalogue;
      // 
      // iceCreamsTableAdapter
      // 
      this.iceCreamsTableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.IceCreamsTableAdapter = this.iceCreamsTableAdapter;
      this.tableAdapterManager.UpdateOrder = ProyectoCATALOGO.DataSet_IceCreamsCatalogueTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // iceCreamsBindingNavigator
      // 
      this.iceCreamsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
      this.iceCreamsBindingNavigator.BindingSource = this.iceCreamsBindingSource;
      this.iceCreamsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
      this.iceCreamsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
      this.iceCreamsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.iceCreamsBindingNavigatorSaveItem});
      this.iceCreamsBindingNavigator.Location = new System.Drawing.Point(0, 0);
      this.iceCreamsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.iceCreamsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.iceCreamsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.iceCreamsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.iceCreamsBindingNavigator.Name = "iceCreamsBindingNavigator";
      this.iceCreamsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
      this.iceCreamsBindingNavigator.Size = new System.Drawing.Size(332, 25);
      this.iceCreamsBindingNavigator.TabIndex = 0;
      this.iceCreamsBindingNavigator.Text = "bindingNavigator1";
      // 
      // bindingNavigatorSeparator
      // 
      this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorPositionItem
      // 
      this.bindingNavigatorPositionItem.AccessibleName = "Position";
      this.bindingNavigatorPositionItem.AutoSize = false;
      this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
      this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
      this.bindingNavigatorPositionItem.Text = "0";
      this.bindingNavigatorPositionItem.ToolTipText = "Current position";
      // 
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
      this.bindingNavigatorCountItem.Text = "of {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
      // 
      // bindingNavigatorSeparator1
      // 
      this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorSeparator2
      // 
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
      // 
      // nombreLabel
      // 
      nombreLabel.AutoSize = true;
      nombreLabel.Image = global::ProyectoCATALOGO.Properties.Resources.fondovacio;
      nombreLabel.Location = new System.Drawing.Point(65, 85);
      nombreLabel.Name = "nombreLabel";
      nombreLabel.Size = new System.Drawing.Size(47, 13);
      nombreLabel.TabIndex = 1;
      nombreLabel.Text = "Nombre:";
      // 
      // nombreTextBox
      // 
      this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iceCreamsBindingSource, "Nombre", true));
      this.nombreTextBox.Location = new System.Drawing.Point(164, 82);
      this.nombreTextBox.Name = "nombreTextBox";
      this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
      this.nombreTextBox.TabIndex = 2;
      // 
      // creadoEnLabel
      // 
      creadoEnLabel.AutoSize = true;
      creadoEnLabel.Image = global::ProyectoCATALOGO.Properties.Resources.fondovacio;
      creadoEnLabel.Location = new System.Drawing.Point(65, 111);
      creadoEnLabel.Name = "creadoEnLabel";
      creadoEnLabel.Size = new System.Drawing.Size(60, 13);
      creadoEnLabel.TabIndex = 3;
      creadoEnLabel.Text = "Creado En:";
      // 
      // creadoEnTextBox
      // 
      this.creadoEnTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iceCreamsBindingSource, "CreadoEn", true));
      this.creadoEnTextBox.Location = new System.Drawing.Point(164, 108);
      this.creadoEnTextBox.Name = "creadoEnTextBox";
      this.creadoEnTextBox.Size = new System.Drawing.Size(100, 20);
      this.creadoEnTextBox.TabIndex = 4;
      // 
      // premiosGanadosLabel
      // 
      premiosGanadosLabel.AutoSize = true;
      premiosGanadosLabel.Image = global::ProyectoCATALOGO.Properties.Resources.fondovacio;
      premiosGanadosLabel.Location = new System.Drawing.Point(65, 137);
      premiosGanadosLabel.Name = "premiosGanadosLabel";
      premiosGanadosLabel.Size = new System.Drawing.Size(93, 13);
      premiosGanadosLabel.TabIndex = 5;
      premiosGanadosLabel.Text = "Premios Ganados:";
      // 
      // premiosGanadosTextBox
      // 
      this.premiosGanadosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iceCreamsBindingSource, "PremiosGanados", true));
      this.premiosGanadosTextBox.Location = new System.Drawing.Point(164, 134);
      this.premiosGanadosTextBox.Name = "premiosGanadosTextBox";
      this.premiosGanadosTextBox.Size = new System.Drawing.Size(100, 20);
      this.premiosGanadosTextBox.TabIndex = 6;
      // 
      // favoritosLabel
      // 
      favoritosLabel.AutoSize = true;
      favoritosLabel.Image = global::ProyectoCATALOGO.Properties.Resources.fondovacio;
      favoritosLabel.Location = new System.Drawing.Point(65, 163);
      favoritosLabel.Name = "favoritosLabel";
      favoritosLabel.Size = new System.Drawing.Size(53, 13);
      favoritosLabel.TabIndex = 7;
      favoritosLabel.Text = "Favoritos:";
      // 
      // favoritosTextBox
      // 
      this.favoritosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iceCreamsBindingSource, "Favoritos", true));
      this.favoritosTextBox.Location = new System.Drawing.Point(164, 160);
      this.favoritosTextBox.Name = "favoritosTextBox";
      this.favoritosTextBox.Size = new System.Drawing.Size(100, 20);
      this.favoritosTextBox.TabIndex = 8;
      // 
      // bindingNavigatorAddNewItem
      // 
      this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
      this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
      this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorAddNewItem.Text = "Add new";
      // 
      // bindingNavigatorDeleteItem
      // 
      this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
      this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
      this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorDeleteItem.Text = "Delete";
      // 
      // bindingNavigatorMoveFirstItem
      // 
      this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
      this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
      this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveFirstItem.Text = "Move first";
      // 
      // bindingNavigatorMovePreviousItem
      // 
      this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
      this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
      this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMovePreviousItem.Text = "Move previous";
      // 
      // bindingNavigatorMoveNextItem
      // 
      this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
      this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
      this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveNextItem.Text = "Move next";
      // 
      // bindingNavigatorMoveLastItem
      // 
      this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
      this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
      this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveLastItem.Text = "Move last";
      // 
      // iceCreamsBindingNavigatorSaveItem
      // 
      this.iceCreamsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.iceCreamsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("iceCreamsBindingNavigatorSaveItem.Image")));
      this.iceCreamsBindingNavigatorSaveItem.Name = "iceCreamsBindingNavigatorSaveItem";
      this.iceCreamsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
      this.iceCreamsBindingNavigatorSaveItem.Text = "Save Data";
      this.iceCreamsBindingNavigatorSaveItem.Click += new System.EventHandler(this.iceCreamsBindingNavigatorSaveItem_Click);
      // 
      // Form2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = global::ProyectoCATALOGO.Properties.Resources.fondovacio;
      this.ClientSize = new System.Drawing.Size(332, 222);
      this.Controls.Add(nombreLabel);
      this.Controls.Add(this.nombreTextBox);
      this.Controls.Add(creadoEnLabel);
      this.Controls.Add(this.creadoEnTextBox);
      this.Controls.Add(premiosGanadosLabel);
      this.Controls.Add(this.premiosGanadosTextBox);
      this.Controls.Add(favoritosLabel);
      this.Controls.Add(this.favoritosTextBox);
      this.Controls.Add(this.iceCreamsBindingNavigator);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.MaximizeBox = false;
      this.Name = "Form2";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Form2";
      this.Load += new System.EventHandler(this.Form2_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataSet_IceCreamsCatalogue)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.iceCreamsBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.iceCreamsBindingNavigator)).EndInit();
      this.iceCreamsBindingNavigator.ResumeLayout(false);
      this.iceCreamsBindingNavigator.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DataSet_IceCreamsCatalogue dataSet_IceCreamsCatalogue;
    private System.Windows.Forms.BindingSource iceCreamsBindingSource;
    private DataSet_IceCreamsCatalogueTableAdapters.IceCreamsTableAdapter iceCreamsTableAdapter;
    private DataSet_IceCreamsCatalogueTableAdapters.TableAdapterManager tableAdapterManager;
    private System.Windows.Forms.BindingNavigator iceCreamsBindingNavigator;
    private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
    private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
    private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    private System.Windows.Forms.ToolStripButton iceCreamsBindingNavigatorSaveItem;
    private System.Windows.Forms.TextBox nombreTextBox;
    private System.Windows.Forms.TextBox creadoEnTextBox;
    private System.Windows.Forms.TextBox premiosGanadosTextBox;
    private System.Windows.Forms.TextBox favoritosTextBox;
  }
}