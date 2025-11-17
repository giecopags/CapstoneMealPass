namespace CapstoneMealPass.Forms.Admin
{
    partial class ProductsUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsUserControl));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.sidePanel7 = new DevExpress.XtraEditors.SidePanel();
            this.gcProducts = new DevExpress.XtraGrid.GridControl();
            this.gvProducts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Category = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Stocks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StockStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.repositoryItemButtonDelete2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.sidePanel5 = new DevExpress.XtraEditors.SidePanel();
            this.addproductBTN = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.findTE = new DevExpress.XtraEditors.TextEdit();
            this.sidePanel6 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel4 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel3 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonDelete2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.findTE.Properties)).BeginInit();
            this.sidePanel6.SuspendLayout();
            this.sidePanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel7
            // 
            this.sidePanel7.AllowResize = false;
            this.sidePanel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.sidePanel7.Appearance.Options.UseBackColor = true;
            this.sidePanel7.Controls.Add(this.gcProducts);
            this.sidePanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel7.Location = new System.Drawing.Point(28, 81);
            this.sidePanel7.Name = "sidePanel7";
            this.sidePanel7.Size = new System.Drawing.Size(1068, 610);
            this.sidePanel7.TabIndex = 9;
            this.sidePanel7.Text = "sidePanel7";
            // 
            // gcProducts
            // 
            this.gcProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcProducts.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcProducts.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcProducts.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcProducts.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcProducts.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcProducts.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcProducts.Location = new System.Drawing.Point(0, 0);
            this.gcProducts.MainView = this.gvProducts;
            this.gcProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcProducts.Name = "gcProducts";
            this.gcProducts.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1,
            this.repositoryItemButtonEdit1,
            this.repositoryItemButtonDelete2});
            this.gcProducts.Size = new System.Drawing.Size(1068, 610);
            this.gcProducts.TabIndex = 8;
            this.gcProducts.UseEmbeddedNavigator = true;
            this.gcProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProducts});
            // 
            // gvProducts
            // 
            this.gvProducts.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.gvProducts.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvProducts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ProductID,
            this.gridColumn1,
            this.Category,
            this.Stocks,
            this.StockStatus,
            this.Price,
            this.gridColumn4});
            this.gvProducts.DetailHeight = 284;
            this.gvProducts.GridControl = this.gcProducts;
            this.gvProducts.Name = "gvProducts";
            this.gvProducts.OptionsBehavior.AutoExpandAllGroups = true;
            this.gvProducts.OptionsEditForm.PopupEditFormWidth = 686;
            this.gvProducts.OptionsView.RowAutoHeight = true;
            this.gvProducts.OptionsView.ShowGroupPanel = false;
            this.gvProducts.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvProducts_RowClick);
            this.gvProducts.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvProducts_RowCellStyle);
            // 
            // ProductID
            // 
            this.ProductID.AppearanceCell.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ProductID.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.ProductID.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProductID.AppearanceCell.Options.UseBackColor = true;
            this.ProductID.AppearanceCell.Options.UseFont = true;
            this.ProductID.AppearanceCell.Options.UseForeColor = true;
            this.ProductID.AppearanceCell.Options.UseTextOptions = true;
            this.ProductID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ProductID.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(21)))));
            this.ProductID.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.ProductID.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.ProductID.AppearanceHeader.Options.UseBackColor = true;
            this.ProductID.AppearanceHeader.Options.UseFont = true;
            this.ProductID.AppearanceHeader.Options.UseForeColor = true;
            this.ProductID.AppearanceHeader.Options.UseTextOptions = true;
            this.ProductID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ProductID.Caption = "#";
            this.ProductID.FieldName = "ProductID";
            this.ProductID.MinWidth = 21;
            this.ProductID.Name = "ProductID";
            this.ProductID.OptionsColumn.AllowEdit = false;
            this.ProductID.OptionsColumn.AllowFocus = false;
            this.ProductID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.ProductID.Visible = true;
            this.ProductID.VisibleIndex = 0;
            this.ProductID.Width = 93;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gridColumn1.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gridColumn1.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gridColumn1.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn1.AppearanceCell.Options.UseFont = true;
            this.gridColumn1.AppearanceCell.Options.UseForeColor = true;
            this.gridColumn1.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(21)))));
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn1.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.gridColumn1.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "Product Name";
            this.gridColumn1.FieldName = "ProductName";
            this.gridColumn1.MinWidth = 21;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 405;
            // 
            // Category
            // 
            this.Category.AppearanceCell.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Category.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Category.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Category.AppearanceCell.Options.UseBackColor = true;
            this.Category.AppearanceCell.Options.UseFont = true;
            this.Category.AppearanceCell.Options.UseForeColor = true;
            this.Category.AppearanceCell.Options.UseTextOptions = true;
            this.Category.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.Category.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(21)))));
            this.Category.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.Category.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.Category.AppearanceHeader.Options.UseBackColor = true;
            this.Category.AppearanceHeader.Options.UseFont = true;
            this.Category.AppearanceHeader.Options.UseForeColor = true;
            this.Category.AppearanceHeader.Options.UseTextOptions = true;
            this.Category.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Category.Caption = "Category";
            this.Category.FieldName = "CategoryName";
            this.Category.MinWidth = 21;
            this.Category.Name = "Category";
            this.Category.OptionsColumn.AllowEdit = false;
            this.Category.OptionsColumn.AllowFocus = false;
            this.Category.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.Category.Visible = true;
            this.Category.VisibleIndex = 2;
            this.Category.Width = 170;
            // 
            // Stocks
            // 
            this.Stocks.AppearanceCell.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Stocks.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Stocks.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Stocks.AppearanceCell.Options.UseBackColor = true;
            this.Stocks.AppearanceCell.Options.UseFont = true;
            this.Stocks.AppearanceCell.Options.UseForeColor = true;
            this.Stocks.AppearanceCell.Options.UseTextOptions = true;
            this.Stocks.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.Stocks.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(21)))));
            this.Stocks.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.Stocks.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.Stocks.AppearanceHeader.Options.UseBackColor = true;
            this.Stocks.AppearanceHeader.Options.UseFont = true;
            this.Stocks.AppearanceHeader.Options.UseForeColor = true;
            this.Stocks.AppearanceHeader.Options.UseTextOptions = true;
            this.Stocks.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Stocks.Caption = "Stocks";
            this.Stocks.FieldName = "Quantity";
            this.Stocks.MinWidth = 21;
            this.Stocks.Name = "Stocks";
            this.Stocks.OptionsColumn.AllowEdit = false;
            this.Stocks.OptionsColumn.AllowFocus = false;
            this.Stocks.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.Stocks.Visible = true;
            this.Stocks.VisibleIndex = 3;
            this.Stocks.Width = 230;
            // 
            // StockStatus
            // 
            this.StockStatus.AppearanceCell.BackColor = System.Drawing.Color.WhiteSmoke;
            this.StockStatus.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.StockStatus.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StockStatus.AppearanceCell.Options.UseBackColor = true;
            this.StockStatus.AppearanceCell.Options.UseFont = true;
            this.StockStatus.AppearanceCell.Options.UseForeColor = true;
            this.StockStatus.AppearanceCell.Options.UseTextOptions = true;
            this.StockStatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.StockStatus.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(21)))));
            this.StockStatus.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.StockStatus.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.StockStatus.AppearanceHeader.Options.UseBackColor = true;
            this.StockStatus.AppearanceHeader.Options.UseFont = true;
            this.StockStatus.AppearanceHeader.Options.UseForeColor = true;
            this.StockStatus.AppearanceHeader.Options.UseTextOptions = true;
            this.StockStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.StockStatus.Caption = "Stock Status";
            this.StockStatus.FieldName = "StockStatusName";
            this.StockStatus.MinWidth = 21;
            this.StockStatus.Name = "StockStatus";
            this.StockStatus.OptionsColumn.AllowEdit = false;
            this.StockStatus.OptionsColumn.AllowFocus = false;
            this.StockStatus.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.StockStatus.Visible = true;
            this.StockStatus.VisibleIndex = 4;
            this.StockStatus.Width = 286;
            // 
            // Price
            // 
            this.Price.AppearanceCell.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Price.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Price.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Price.AppearanceCell.Options.UseBackColor = true;
            this.Price.AppearanceCell.Options.UseFont = true;
            this.Price.AppearanceCell.Options.UseForeColor = true;
            this.Price.AppearanceCell.Options.UseTextOptions = true;
            this.Price.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Price.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(21)))));
            this.Price.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.Price.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.Price.AppearanceHeader.Options.UseBackColor = true;
            this.Price.AppearanceHeader.Options.UseFont = true;
            this.Price.AppearanceHeader.Options.UseForeColor = true;
            this.Price.AppearanceHeader.Options.UseTextOptions = true;
            this.Price.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Price.Caption = "Price";
            this.Price.FieldName = "Price";
            this.Price.MinWidth = 21;
            this.Price.Name = "Price";
            this.Price.OptionsColumn.AllowEdit = false;
            this.Price.OptionsColumn.AllowFocus = false;
            this.Price.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.Price.Visible = true;
            this.Price.VisibleIndex = 5;
            this.Price.Width = 208;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gridColumn4.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gridColumn4.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gridColumn4.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn4.AppearanceCell.Options.UseFont = true;
            this.gridColumn4.AppearanceCell.Options.UseForeColor = true;
            this.gridColumn4.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn4.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(21)))));
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn4.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.gridColumn4.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.Caption = "Edit";
            this.gridColumn4.ColumnEdit = this.repositoryItemButtonEdit1;
            this.gridColumn4.MinWidth = 21;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowFocus = false;
            this.gridColumn4.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 6;
            this.gridColumn4.Width = 167;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit1.ContextImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("repositoryItemButtonEdit1.ContextImageOptions.SvgImage")));
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // repositoryItemButtonDelete2
            // 
            this.repositoryItemButtonDelete2.Appearance.Options.UseTextOptions = true;
            this.repositoryItemButtonDelete2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemButtonDelete2.AutoHeight = false;
            this.repositoryItemButtonDelete2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.repositoryItemButtonDelete2.ContextImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("repositoryItemButtonDelete2.ContextImageOptions.SvgImage")));
            this.repositoryItemButtonDelete2.Name = "repositoryItemButtonDelete2";
            // 
            // sidePanel5
            // 
            this.sidePanel5.AllowResize = false;
            this.sidePanel5.BorderThickness = 0;
            this.sidePanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel5.Location = new System.Drawing.Point(0, 0);
            this.sidePanel5.Name = "sidePanel5";
            this.sidePanel5.Size = new System.Drawing.Size(1068, 30);
            this.sidePanel5.TabIndex = 0;
            this.sidePanel5.Text = "sidePanel5";
            // 
            // addproductBTN
            // 
            this.addproductBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(141)))), ((int)(((byte)(57)))));
            this.addproductBTN.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addproductBTN.Appearance.Options.UseBackColor = true;
            this.addproductBTN.Appearance.Options.UseFont = true;
            this.addproductBTN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("addproductBTN.ImageOptions.Image")));
            this.addproductBTN.Location = new System.Drawing.Point(105, 3);
            this.addproductBTN.Name = "addproductBTN";
            this.addproductBTN.Size = new System.Drawing.Size(150, 40);
            this.addproductBTN.TabIndex = 1;
            this.addproductBTN.Text = "Add Product";
            this.addproductBTN.Click += new System.EventHandler(this.addproductBTN_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(125)))), ((int)(((byte)(79)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(2, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(121, 36);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Products";
            // 
            // findTE
            // 
            this.findTE.Location = new System.Drawing.Point(148, 40);
            this.findTE.Name = "findTE";
            this.findTE.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.findTE.Properties.Appearance.Options.UseBackColor = true;
            this.findTE.Properties.AutoHeight = false;
            this.findTE.Size = new System.Drawing.Size(206, 23);
            this.findTE.TabIndex = 2;
            this.findTE.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.findTE_EditValueChanging);
            // 
            // sidePanel6
            // 
            this.sidePanel6.AllowResize = false;
            this.sidePanel6.BorderThickness = 0;
            this.sidePanel6.Controls.Add(this.addproductBTN);
            this.sidePanel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel6.Location = new System.Drawing.Point(807, 30);
            this.sidePanel6.Name = "sidePanel6";
            this.sidePanel6.Size = new System.Drawing.Size(261, 51);
            this.sidePanel6.TabIndex = 1;
            this.sidePanel6.Text = "sidePanel6";
            // 
            // sidePanel4
            // 
            this.sidePanel4.AllowResize = false;
            this.sidePanel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.sidePanel4.Appearance.Options.UseBackColor = true;
            this.sidePanel4.BorderThickness = 0;
            this.sidePanel4.Controls.Add(this.labelControl1);
            this.sidePanel4.Controls.Add(this.findTE);
            this.sidePanel4.Controls.Add(this.sidePanel6);
            this.sidePanel4.Controls.Add(this.sidePanel5);
            this.sidePanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel4.Location = new System.Drawing.Point(28, 0);
            this.sidePanel4.Name = "sidePanel4";
            this.sidePanel4.Size = new System.Drawing.Size(1068, 81);
            this.sidePanel4.TabIndex = 8;
            this.sidePanel4.Text = "sidePanel4";
            // 
            // sidePanel3
            // 
            this.sidePanel3.AllowResize = false;
            this.sidePanel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.sidePanel3.Appearance.Options.UseBackColor = true;
            this.sidePanel3.BorderThickness = 0;
            this.sidePanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sidePanel3.Location = new System.Drawing.Point(28, 691);
            this.sidePanel3.Name = "sidePanel3";
            this.sidePanel3.Size = new System.Drawing.Size(1068, 31);
            this.sidePanel3.TabIndex = 7;
            this.sidePanel3.Text = "sidePanel3";
            // 
            // sidePanel2
            // 
            this.sidePanel2.AllowResize = false;
            this.sidePanel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.sidePanel2.Appearance.Options.UseBackColor = true;
            this.sidePanel2.BorderThickness = 0;
            this.sidePanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel2.Location = new System.Drawing.Point(1096, 0);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(29, 722);
            this.sidePanel2.TabIndex = 6;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // sidePanel1
            // 
            this.sidePanel1.AllowResize = false;
            this.sidePanel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.sidePanel1.Appearance.Options.UseBackColor = true;
            this.sidePanel1.BorderThickness = 0;
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(28, 722);
            this.sidePanel1.TabIndex = 5;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // ProductsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidePanel7);
            this.Controls.Add(this.sidePanel4);
            this.Controls.Add(this.sidePanel3);
            this.Controls.Add(this.sidePanel2);
            this.Controls.Add(this.sidePanel1);
            this.Name = "ProductsUserControl";
            this.Size = new System.Drawing.Size(1125, 722);
            this.sidePanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonDelete2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.findTE.Properties)).EndInit();
            this.sidePanel6.ResumeLayout(false);
            this.sidePanel4.ResumeLayout(false);
            this.sidePanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SidePanel sidePanel7;
        private DevExpress.XtraEditors.SidePanel sidePanel5;
        private DevExpress.XtraEditors.SimpleButton addproductBTN;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit findTE;
        private DevExpress.XtraEditors.SidePanel sidePanel6;
        private DevExpress.XtraEditors.SidePanel sidePanel4;
        private DevExpress.XtraEditors.SidePanel sidePanel3;
        private DevExpress.XtraEditors.SidePanel sidePanel2;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraGrid.GridControl gcProducts;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProducts;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn Category;
        private DevExpress.XtraGrid.Columns.GridColumn ProductID;
        private DevExpress.XtraGrid.Columns.GridColumn Stocks;
        private DevExpress.XtraGrid.Columns.GridColumn StockStatus;
        private DevExpress.XtraGrid.Columns.GridColumn Price;
        internal DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonDelete2;
    }
}
