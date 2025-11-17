namespace CapstoneMealPass.Forms.Staff
{
    partial class POSUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POSUserControl));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.sidePanel5 = new DevExpress.XtraEditors.SidePanel();
            this.cartGC = new DevExpress.XtraGrid.GridControl();
            this.cartGV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.No = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Product = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.ProductPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cancel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCancelBTN = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.sidePanel7 = new DevExpress.XtraEditors.SidePanel();
            this.grandtotalLBL = new DevExpress.XtraEditors.LabelControl();
            this.confirmBTN = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.sidePanel9 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel15 = new DevExpress.XtraEditors.SidePanel();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.mealsBTN = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.drinksBTN = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.allBTN = new DevExpress.XtraEditors.SimpleButton();
            this.sidePanel14 = new DevExpress.XtraEditors.SidePanel();
            this.addtocartBTN = new DevExpress.XtraEditors.SimpleButton();
            this.sidePanel12 = new DevExpress.XtraEditors.SidePanel();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.findTE = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.snacksBTN = new DevExpress.XtraEditors.SimpleButton();
            this.sidePanel4 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel3 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel10 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel11 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel6 = new DevExpress.XtraEditors.SidePanel();
            this.productsGC = new DevExpress.XtraGrid.GridControl();
            this.productsGV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Category = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Stocks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StockStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sidePanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCancelBTN)).BeginInit();
            this.sidePanel7.SuspendLayout();
            this.sidePanel9.SuspendLayout();
            this.sidePanel15.SuspendLayout();
            this.sidePanel14.SuspendLayout();
            this.sidePanel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.findTE.Properties)).BeginInit();
            this.sidePanel11.SuspendLayout();
            this.sidePanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsGV)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel5
            // 
            this.sidePanel5.BorderThickness = 0;
            this.sidePanel5.Controls.Add(this.cartGC);
            this.sidePanel5.Controls.Add(this.sidePanel7);
            this.sidePanel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel5.Location = new System.Drawing.Point(1139, 20);
            this.sidePanel5.Name = "sidePanel5";
            this.sidePanel5.Size = new System.Drawing.Size(471, 669);
            this.sidePanel5.TabIndex = 16;
            this.sidePanel5.Text = "sidePanel5";
            // 
            // cartGC
            // 
            this.cartGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartGC.Location = new System.Drawing.Point(0, 0);
            this.cartGC.MainView = this.cartGV;
            this.cartGC.Name = "cartGC";
            this.cartGC.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEdit1,
            this.repositoryItemCancelBTN});
            this.cartGC.Size = new System.Drawing.Size(471, 559);
            this.cartGC.TabIndex = 2;
            this.cartGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cartGV});
            // 
            // cartGV
            // 
            this.cartGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.No,
            this.Product,
            this.Quantity,
            this.ProductPrice,
            this.Total,
            this.Cancel});
            this.cartGV.GridControl = this.cartGC;
            this.cartGV.Name = "cartGV";
            this.cartGV.OptionsView.ShowGroupPanel = false;
            this.cartGV.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.cartGV_CellValueChanged);
            // 
            // No
            // 
            this.No.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.No.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.No.AppearanceCell.Options.UseFont = true;
            this.No.AppearanceCell.Options.UseForeColor = true;
            this.No.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(21)))));
            this.No.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.No.AppearanceHeader.Options.UseBackColor = true;
            this.No.AppearanceHeader.Options.UseFont = true;
            this.No.AppearanceHeader.Options.UseTextOptions = true;
            this.No.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.No.Caption = "ID";
            this.No.FieldName = "ProductID";
            this.No.Name = "No";
            this.No.OptionsColumn.AllowEdit = false;
            this.No.OptionsColumn.AllowFocus = false;
            this.No.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.No.Width = 99;
            // 
            // Product
            // 
            this.Product.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Product.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Product.AppearanceCell.Options.UseFont = true;
            this.Product.AppearanceCell.Options.UseForeColor = true;
            this.Product.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(21)))));
            this.Product.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.Product.AppearanceHeader.Options.UseBackColor = true;
            this.Product.AppearanceHeader.Options.UseFont = true;
            this.Product.AppearanceHeader.Options.UseTextOptions = true;
            this.Product.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Product.Caption = "Name";
            this.Product.FieldName = "ProductName";
            this.Product.Name = "Product";
            this.Product.OptionsColumn.AllowEdit = false;
            this.Product.OptionsColumn.AllowFocus = false;
            this.Product.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.Product.Visible = true;
            this.Product.VisibleIndex = 0;
            this.Product.Width = 452;
            // 
            // Quantity
            // 
            this.Quantity.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Quantity.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Quantity.AppearanceCell.Options.UseFont = true;
            this.Quantity.AppearanceCell.Options.UseForeColor = true;
            this.Quantity.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(21)))));
            this.Quantity.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.Quantity.AppearanceHeader.Options.UseBackColor = true;
            this.Quantity.AppearanceHeader.Options.UseFont = true;
            this.Quantity.AppearanceHeader.Options.UseTextOptions = true;
            this.Quantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Quantity.Caption = "Qty.";
            this.Quantity.ColumnEdit = this.repositoryItemSpinEdit1;
            this.Quantity.FieldName = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.Visible = true;
            this.Quantity.VisibleIndex = 1;
            this.Quantity.Width = 260;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            this.repositoryItemSpinEdit1.SpinStyle = DevExpress.XtraEditors.Controls.SpinStyles.Horizontal;
            // 
            // ProductPrice
            // 
            this.ProductPrice.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ProductPrice.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProductPrice.AppearanceCell.Options.UseFont = true;
            this.ProductPrice.AppearanceCell.Options.UseForeColor = true;
            this.ProductPrice.AppearanceCell.Options.UseTextOptions = true;
            this.ProductPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ProductPrice.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(21)))));
            this.ProductPrice.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.ProductPrice.AppearanceHeader.Options.UseBackColor = true;
            this.ProductPrice.AppearanceHeader.Options.UseFont = true;
            this.ProductPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.ProductPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ProductPrice.Caption = "Price";
            this.ProductPrice.FieldName = "Price";
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.OptionsColumn.AllowEdit = false;
            this.ProductPrice.OptionsColumn.AllowFocus = false;
            this.ProductPrice.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.ProductPrice.Visible = true;
            this.ProductPrice.VisibleIndex = 2;
            this.ProductPrice.Width = 274;
            // 
            // Total
            // 
            this.Total.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Total.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Total.AppearanceCell.Options.UseFont = true;
            this.Total.AppearanceCell.Options.UseForeColor = true;
            this.Total.AppearanceCell.Options.UseTextOptions = true;
            this.Total.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Total.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(21)))));
            this.Total.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.Total.AppearanceHeader.Options.UseBackColor = true;
            this.Total.AppearanceHeader.Options.UseFont = true;
            this.Total.AppearanceHeader.Options.UseTextOptions = true;
            this.Total.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Total.Caption = "Total";
            this.Total.FieldName = "Total";
            this.Total.Name = "Total";
            this.Total.OptionsColumn.AllowEdit = false;
            this.Total.OptionsColumn.AllowFocus = false;
            this.Total.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.Total.Visible = true;
            this.Total.VisibleIndex = 3;
            this.Total.Width = 267;
            // 
            // Cancel
            // 
            this.Cancel.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Cancel.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Cancel.AppearanceCell.Options.UseFont = true;
            this.Cancel.AppearanceCell.Options.UseForeColor = true;
            this.Cancel.AppearanceCell.Options.UseTextOptions = true;
            this.Cancel.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Cancel.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(21)))));
            this.Cancel.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.Cancel.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Cancel.AppearanceHeader.Options.UseBackColor = true;
            this.Cancel.AppearanceHeader.Options.UseFont = true;
            this.Cancel.AppearanceHeader.Options.UseForeColor = true;
            this.Cancel.AppearanceHeader.Options.UseTextOptions = true;
            this.Cancel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Cancel.Caption = "Cnl.";
            this.Cancel.ColumnEdit = this.repositoryItemCancelBTN;
            this.Cancel.FieldName = "Cancel";
            this.Cancel.Name = "Cancel";
            this.Cancel.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.Cancel.OptionsColumn.ReadOnly = true;
            this.Cancel.Visible = true;
            this.Cancel.VisibleIndex = 4;
            this.Cancel.Width = 97;
            // 
            // repositoryItemCancelBTN
            // 
            this.repositoryItemCancelBTN.AllowFocused = false;
            this.repositoryItemCancelBTN.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.repositoryItemCancelBTN.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemCancelBTN.Name = "repositoryItemCancelBTN";
            this.repositoryItemCancelBTN.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemCancelBTN.Click += new System.EventHandler(this.repositoryItemCancelBTN_Click);
            // 
            // sidePanel7
            // 
            this.sidePanel7.Appearance.BackColor = System.Drawing.Color.SeaGreen;
            this.sidePanel7.Appearance.BorderColor = System.Drawing.Color.Gray;
            this.sidePanel7.Appearance.Options.UseBackColor = true;
            this.sidePanel7.Appearance.Options.UseBorderColor = true;
            this.sidePanel7.Controls.Add(this.grandtotalLBL);
            this.sidePanel7.Controls.Add(this.confirmBTN);
            this.sidePanel7.Controls.Add(this.labelControl2);
            this.sidePanel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sidePanel7.Location = new System.Drawing.Point(0, 559);
            this.sidePanel7.Name = "sidePanel7";
            this.sidePanel7.Size = new System.Drawing.Size(471, 110);
            this.sidePanel7.TabIndex = 0;
            this.sidePanel7.Text = "sidePanel7";
            // 
            // grandtotalLBL
            // 
            this.grandtotalLBL.Appearance.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grandtotalLBL.Appearance.ForeColor = System.Drawing.Color.GreenYellow;
            this.grandtotalLBL.Appearance.Options.UseFont = true;
            this.grandtotalLBL.Appearance.Options.UseForeColor = true;
            this.grandtotalLBL.Location = new System.Drawing.Point(345, 28);
            this.grandtotalLBL.Name = "grandtotalLBL";
            this.grandtotalLBL.Size = new System.Drawing.Size(49, 23);
            this.grandtotalLBL.TabIndex = 7;
            this.grandtotalLBL.Text = "00.00";
            // 
            // confirmBTN
            // 
            this.confirmBTN.Appearance.BackColor = System.Drawing.Color.LightGreen;
            this.confirmBTN.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBTN.Appearance.ForeColor = System.Drawing.Color.ForestGreen;
            this.confirmBTN.Appearance.Options.UseBackColor = true;
            this.confirmBTN.Appearance.Options.UseFont = true;
            this.confirmBTN.Appearance.Options.UseForeColor = true;
            this.confirmBTN.Location = new System.Drawing.Point(345, 73);
            this.confirmBTN.Name = "confirmBTN";
            this.confirmBTN.Size = new System.Drawing.Size(120, 31);
            this.confirmBTN.TabIndex = 6;
            this.confirmBTN.Text = "Confirm";
            this.confirmBTN.Click += new System.EventHandler(this.confirmBTN_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Honeydew;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(147, 23);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(142, 28);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Grand Total:";
            // 
            // sidePanel9
            // 
            this.sidePanel9.BorderThickness = 0;
            this.sidePanel9.Controls.Add(this.sidePanel15);
            this.sidePanel9.Controls.Add(this.sidePanel14);
            this.sidePanel9.Controls.Add(this.sidePanel12);
            this.sidePanel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel9.Location = new System.Drawing.Point(0, 0);
            this.sidePanel9.Name = "sidePanel9";
            this.sidePanel9.Size = new System.Drawing.Size(1065, 199);
            this.sidePanel9.TabIndex = 2;
            this.sidePanel9.Text = "sidePanel9";
            // 
            // sidePanel15
            // 
            this.sidePanel15.AllowResize = false;
            this.sidePanel15.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.sidePanel15.Appearance.Options.UseBackColor = true;
            this.sidePanel15.BorderThickness = 0;
            this.sidePanel15.Controls.Add(this.labelControl7);
            this.sidePanel15.Controls.Add(this.mealsBTN);
            this.sidePanel15.Controls.Add(this.labelControl6);
            this.sidePanel15.Controls.Add(this.drinksBTN);
            this.sidePanel15.Controls.Add(this.labelControl5);
            this.sidePanel15.Controls.Add(this.allBTN);
            this.sidePanel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel15.Location = new System.Drawing.Point(243, 0);
            this.sidePanel15.Name = "sidePanel15";
            this.sidePanel15.Size = new System.Drawing.Size(707, 199);
            this.sidePanel15.TabIndex = 4;
            this.sidePanel15.Text = "sidePanel15";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(629, 131);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(18, 16);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "All";
            // 
            // mealsBTN
            // 
            this.mealsBTN.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.mealsBTN.AppearanceHovered.Options.UseBackColor = true;
            this.mealsBTN.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.mealsBTN.AppearancePressed.Options.UseBackColor = true;
            this.mealsBTN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mealsBTN.ImageOptions.Image")));
            this.mealsBTN.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.mealsBTN.Location = new System.Drawing.Point(133, 48);
            this.mealsBTN.Name = "mealsBTN";
            this.mealsBTN.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.mealsBTN.Size = new System.Drawing.Size(81, 77);
            this.mealsBTN.TabIndex = 8;
            this.mealsBTN.Text = "simpleButton2";
            this.mealsBTN.Click += new System.EventHandler(this.mealsBTN_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(381, 131);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(40, 16);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Drinks";
            // 
            // drinksBTN
            // 
            this.drinksBTN.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.drinksBTN.AppearanceHovered.Options.UseBackColor = true;
            this.drinksBTN.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.drinksBTN.AppearancePressed.Options.UseBackColor = true;
            this.drinksBTN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("drinksBTN.ImageOptions.Image")));
            this.drinksBTN.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.drinksBTN.Location = new System.Drawing.Point(360, 49);
            this.drinksBTN.Name = "drinksBTN";
            this.drinksBTN.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.drinksBTN.Size = new System.Drawing.Size(81, 77);
            this.drinksBTN.TabIndex = 9;
            this.drinksBTN.Text = "simpleButton3";
            this.drinksBTN.Click += new System.EventHandler(this.drinksBTN_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(154, 129);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(39, 16);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Meals";
            // 
            // allBTN
            // 
            this.allBTN.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.allBTN.AppearanceHovered.Options.UseBackColor = true;
            this.allBTN.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.allBTN.AppearancePressed.Options.UseBackColor = true;
            this.allBTN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("allBTN.ImageOptions.Image")));
            this.allBTN.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.allBTN.Location = new System.Drawing.Point(597, 48);
            this.allBTN.Name = "allBTN";
            this.allBTN.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.allBTN.Size = new System.Drawing.Size(81, 77);
            this.allBTN.TabIndex = 10;
            this.allBTN.Text = "simpleButton6";
            this.allBTN.Click += new System.EventHandler(this.allBTN_Click);
            // 
            // sidePanel14
            // 
            this.sidePanel14.AllowResize = false;
            this.sidePanel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.sidePanel14.Appearance.Options.UseBackColor = true;
            this.sidePanel14.BorderThickness = 0;
            this.sidePanel14.Controls.Add(this.addtocartBTN);
            this.sidePanel14.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel14.Location = new System.Drawing.Point(950, 0);
            this.sidePanel14.Name = "sidePanel14";
            this.sidePanel14.Size = new System.Drawing.Size(115, 199);
            this.sidePanel14.TabIndex = 3;
            this.sidePanel14.Text = "sidePanel14";
            // 
            // addtocartBTN
            // 
            this.addtocartBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(107)))), ((int)(((byte)(60)))));
            this.addtocartBTN.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addtocartBTN.Appearance.Options.UseBackColor = true;
            this.addtocartBTN.Appearance.Options.UseFont = true;
            this.addtocartBTN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("addtocartBTN.ImageOptions.Image")));
            this.addtocartBTN.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.addtocartBTN.Location = new System.Drawing.Point(7, 158);
            this.addtocartBTN.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.addtocartBTN.Name = "addtocartBTN";
            this.addtocartBTN.Padding = new System.Windows.Forms.Padding(2);
            this.addtocartBTN.Size = new System.Drawing.Size(101, 32);
            this.addtocartBTN.TabIndex = 27;
            this.addtocartBTN.Text = "Add";
            this.addtocartBTN.Click += new System.EventHandler(this.addtocartBTN_Click);
            // 
            // sidePanel12
            // 
            this.sidePanel12.AllowResize = false;
            this.sidePanel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.sidePanel12.Appearance.Options.UseBackColor = true;
            this.sidePanel12.BorderThickness = 0;
            this.sidePanel12.Controls.Add(this.labelControl4);
            this.sidePanel12.Controls.Add(this.findTE);
            this.sidePanel12.Controls.Add(this.labelControl1);
            this.sidePanel12.Controls.Add(this.snacksBTN);
            this.sidePanel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel12.Location = new System.Drawing.Point(0, 0);
            this.sidePanel12.Name = "sidePanel12";
            this.sidePanel12.Size = new System.Drawing.Size(243, 199);
            this.sidePanel12.TabIndex = 1;
            this.sidePanel12.Text = "sidePanel12";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(170, 129);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(46, 16);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Snacks";
            // 
            // findTE
            // 
            this.findTE.EditValue = "";
            this.findTE.Location = new System.Drawing.Point(6, 164);
            this.findTE.Name = "findTE";
            this.findTE.Size = new System.Drawing.Size(190, 28);
            this.findTE.TabIndex = 4;
            this.findTE.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.findTE_EditValueChanging);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(125)))), ((int)(((byte)(79)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(6, -8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(156, 36);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Categories";
            // 
            // snacksBTN
            // 
            this.snacksBTN.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.snacksBTN.AppearanceHovered.Options.UseBackColor = true;
            this.snacksBTN.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.snacksBTN.AppearancePressed.Options.UseBackColor = true;
            this.snacksBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("snacksBTN.BackgroundImage")));
            this.snacksBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.snacksBTN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("snacksBTN.ImageOptions.Image")));
            this.snacksBTN.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.snacksBTN.Location = new System.Drawing.Point(154, 48);
            this.snacksBTN.Name = "snacksBTN";
            this.snacksBTN.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.snacksBTN.Size = new System.Drawing.Size(81, 77);
            this.snacksBTN.TabIndex = 7;
            this.snacksBTN.Text = "simpleButton1";
            this.snacksBTN.Click += new System.EventHandler(this.snacksBTN_Click);
            // 
            // sidePanel4
            // 
            this.sidePanel4.AllowResize = false;
            this.sidePanel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.sidePanel4.Appearance.Options.UseBackColor = true;
            this.sidePanel4.BorderThickness = 0;
            this.sidePanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sidePanel4.Location = new System.Drawing.Point(39, 689);
            this.sidePanel4.Name = "sidePanel4";
            this.sidePanel4.Size = new System.Drawing.Size(1571, 33);
            this.sidePanel4.TabIndex = 15;
            this.sidePanel4.Text = "sidePanel4";
            // 
            // sidePanel3
            // 
            this.sidePanel3.AllowResize = false;
            this.sidePanel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.sidePanel3.Appearance.Options.UseBackColor = true;
            this.sidePanel3.BorderThickness = 0;
            this.sidePanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel3.Location = new System.Drawing.Point(1610, 20);
            this.sidePanel3.Name = "sidePanel3";
            this.sidePanel3.Size = new System.Drawing.Size(35, 702);
            this.sidePanel3.TabIndex = 14;
            this.sidePanel3.Text = "sidePanel3";
            // 
            // sidePanel2
            // 
            this.sidePanel2.AllowResize = false;
            this.sidePanel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.sidePanel2.Appearance.Options.UseBackColor = true;
            this.sidePanel2.BorderThickness = 0;
            this.sidePanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel2.Location = new System.Drawing.Point(0, 20);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(39, 702);
            this.sidePanel2.TabIndex = 13;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // sidePanel1
            // 
            this.sidePanel1.AllowResize = false;
            this.sidePanel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.sidePanel1.Appearance.Options.UseBackColor = true;
            this.sidePanel1.BorderThickness = 0;
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(1645, 20);
            this.sidePanel1.TabIndex = 12;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // sidePanel10
            // 
            this.sidePanel10.AllowResize = false;
            this.sidePanel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.sidePanel10.Appearance.Options.UseBackColor = true;
            this.sidePanel10.BorderThickness = 0;
            this.sidePanel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel10.Location = new System.Drawing.Point(1104, 20);
            this.sidePanel10.Name = "sidePanel10";
            this.sidePanel10.Size = new System.Drawing.Size(35, 669);
            this.sidePanel10.TabIndex = 18;
            this.sidePanel10.Text = "sidePanel10";
            // 
            // sidePanel11
            // 
            this.sidePanel11.BorderThickness = 0;
            this.sidePanel11.Controls.Add(this.sidePanel6);
            this.sidePanel11.Controls.Add(this.sidePanel9);
            this.sidePanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel11.Location = new System.Drawing.Point(39, 20);
            this.sidePanel11.Name = "sidePanel11";
            this.sidePanel11.Size = new System.Drawing.Size(1065, 669);
            this.sidePanel11.TabIndex = 19;
            this.sidePanel11.Text = "sidePanel11";
            // 
            // sidePanel6
            // 
            this.sidePanel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.sidePanel6.Appearance.Options.UseBackColor = true;
            this.sidePanel6.BorderThickness = 0;
            this.sidePanel6.Controls.Add(this.productsGC);
            this.sidePanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel6.Location = new System.Drawing.Point(0, 199);
            this.sidePanel6.Name = "sidePanel6";
            this.sidePanel6.Size = new System.Drawing.Size(1065, 470);
            this.sidePanel6.TabIndex = 3;
            this.sidePanel6.Text = "sidePanel6";
            // 
            // productsGC
            // 
            this.productsGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productsGC.Location = new System.Drawing.Point(0, 0);
            this.productsGC.MainView = this.productsGV;
            this.productsGC.Name = "productsGC";
            this.productsGC.Size = new System.Drawing.Size(1065, 470);
            this.productsGC.TabIndex = 1;
            this.productsGC.UseEmbeddedNavigator = true;
            this.productsGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.productsGV});
            // 
            // productsGV
            // 
            this.productsGV.Appearance.Row.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.productsGV.Appearance.Row.Options.UseForeColor = true;
            this.productsGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.ProductName,
            this.Category,
            this.Price,
            this.Stocks,
            this.StockStatus});
            this.productsGV.GridControl = this.productsGC;
            this.productsGV.Name = "productsGV";
            this.productsGV.OptionsView.EnableAppearanceEvenRow = true;
            this.productsGV.OptionsView.ShowGroupPanel = false;
            // 
            // ID
            // 
            this.ID.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ID.AppearanceCell.Options.UseFont = true;
            this.ID.AppearanceCell.Options.UseForeColor = true;
            this.ID.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(21)))));
            this.ID.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.ID.AppearanceHeader.Options.UseBackColor = true;
            this.ID.AppearanceHeader.Options.UseFont = true;
            this.ID.AppearanceHeader.Options.UseTextOptions = true;
            this.ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ID.Caption = "ID";
            this.ID.FieldName = "ProductID";
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.OptionsColumn.AllowFocus = false;
            this.ID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            this.ID.Width = 40;
            // 
            // ProductName
            // 
            this.ProductName.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProductName.AppearanceCell.Options.UseFont = true;
            this.ProductName.AppearanceCell.Options.UseForeColor = true;
            this.ProductName.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(21)))));
            this.ProductName.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.ProductName.AppearanceHeader.Options.UseBackColor = true;
            this.ProductName.AppearanceHeader.Options.UseFont = true;
            this.ProductName.AppearanceHeader.Options.UseTextOptions = true;
            this.ProductName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ProductName.Caption = "Product Name";
            this.ProductName.FieldName = "ProductName";
            this.ProductName.Name = "ProductName";
            this.ProductName.OptionsColumn.AllowEdit = false;
            this.ProductName.OptionsColumn.AllowFocus = false;
            this.ProductName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.ProductName.Visible = true;
            this.ProductName.VisibleIndex = 1;
            this.ProductName.Width = 369;
            // 
            // Category
            // 
            this.Category.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Category.AppearanceCell.Options.UseFont = true;
            this.Category.AppearanceCell.Options.UseForeColor = true;
            this.Category.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(21)))));
            this.Category.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.Category.AppearanceHeader.Options.UseBackColor = true;
            this.Category.AppearanceHeader.Options.UseFont = true;
            this.Category.AppearanceHeader.Options.UseTextOptions = true;
            this.Category.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Category.Caption = "Category";
            this.Category.FieldName = "CategoryName";
            this.Category.Name = "Category";
            this.Category.OptionsColumn.AllowEdit = false;
            this.Category.OptionsColumn.AllowFocus = false;
            this.Category.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.Category.Visible = true;
            this.Category.VisibleIndex = 2;
            this.Category.Width = 232;
            // 
            // Price
            // 
            this.Price.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Price.AppearanceCell.Options.UseFont = true;
            this.Price.AppearanceCell.Options.UseForeColor = true;
            this.Price.AppearanceCell.Options.UseTextOptions = true;
            this.Price.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Price.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(21)))));
            this.Price.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.Price.AppearanceHeader.Options.UseBackColor = true;
            this.Price.AppearanceHeader.Options.UseFont = true;
            this.Price.AppearanceHeader.Options.UseTextOptions = true;
            this.Price.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Price.Caption = "Price";
            this.Price.FieldName = "Price";
            this.Price.Name = "Price";
            this.Price.OptionsColumn.AllowEdit = false;
            this.Price.OptionsColumn.AllowFocus = false;
            this.Price.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.Price.Visible = true;
            this.Price.VisibleIndex = 5;
            this.Price.Width = 189;
            // 
            // Stocks
            // 
            this.Stocks.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stocks.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Stocks.AppearanceCell.Options.UseFont = true;
            this.Stocks.AppearanceCell.Options.UseForeColor = true;
            this.Stocks.AppearanceCell.Options.UseTextOptions = true;
            this.Stocks.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Stocks.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(21)))));
            this.Stocks.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.Stocks.AppearanceHeader.Options.UseBackColor = true;
            this.Stocks.AppearanceHeader.Options.UseFont = true;
            this.Stocks.AppearanceHeader.Options.UseTextOptions = true;
            this.Stocks.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Stocks.Caption = "Stocks";
            this.Stocks.FieldName = "Quantity";
            this.Stocks.Name = "Stocks";
            this.Stocks.OptionsColumn.AllowEdit = false;
            this.Stocks.OptionsColumn.AllowFocus = false;
            this.Stocks.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.Stocks.Visible = true;
            this.Stocks.VisibleIndex = 3;
            this.Stocks.Width = 185;
            // 
            // StockStatus
            // 
            this.StockStatus.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockStatus.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StockStatus.AppearanceCell.Options.UseFont = true;
            this.StockStatus.AppearanceCell.Options.UseForeColor = true;
            this.StockStatus.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(21)))));
            this.StockStatus.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.StockStatus.AppearanceHeader.Options.UseBackColor = true;
            this.StockStatus.AppearanceHeader.Options.UseFont = true;
            this.StockStatus.AppearanceHeader.Options.UseTextOptions = true;
            this.StockStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.StockStatus.Caption = "Stock Status";
            this.StockStatus.FieldName = "StockStatusName";
            this.StockStatus.Name = "StockStatus";
            this.StockStatus.OptionsColumn.AllowEdit = false;
            this.StockStatus.OptionsColumn.AllowFocus = false;
            this.StockStatus.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.StockStatus.Visible = true;
            this.StockStatus.VisibleIndex = 4;
            this.StockStatus.Width = 335;
            // 
            // POSUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidePanel11);
            this.Controls.Add(this.sidePanel10);
            this.Controls.Add(this.sidePanel5);
            this.Controls.Add(this.sidePanel4);
            this.Controls.Add(this.sidePanel3);
            this.Controls.Add(this.sidePanel2);
            this.Controls.Add(this.sidePanel1);
            this.Name = "POSUserControl";
            this.Size = new System.Drawing.Size(1645, 722);
            this.sidePanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cartGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCancelBTN)).EndInit();
            this.sidePanel7.ResumeLayout(false);
            this.sidePanel7.PerformLayout();
            this.sidePanel9.ResumeLayout(false);
            this.sidePanel15.ResumeLayout(false);
            this.sidePanel15.PerformLayout();
            this.sidePanel14.ResumeLayout(false);
            this.sidePanel12.ResumeLayout(false);
            this.sidePanel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.findTE.Properties)).EndInit();
            this.sidePanel11.ResumeLayout(false);
            this.sidePanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productsGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SidePanel sidePanel5;
        private DevExpress.XtraEditors.SidePanel sidePanel7;
        private DevExpress.XtraEditors.LabelControl grandtotalLBL;
        private DevExpress.XtraEditors.SimpleButton confirmBTN;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SidePanel sidePanel9;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton allBTN;
        private DevExpress.XtraEditors.SimpleButton drinksBTN;
        private DevExpress.XtraEditors.SimpleButton mealsBTN;
        private DevExpress.XtraEditors.SidePanel sidePanel12;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit findTE;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton snacksBTN;
        private DevExpress.XtraEditors.SidePanel sidePanel4;
        private DevExpress.XtraEditors.SidePanel sidePanel3;
        private DevExpress.XtraEditors.SidePanel sidePanel2;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.SidePanel sidePanel10;
        private DevExpress.XtraEditors.SidePanel sidePanel11;
        private DevExpress.XtraGrid.GridControl cartGC;
        private DevExpress.XtraGrid.Views.Grid.GridView cartGV;
        private DevExpress.XtraGrid.Columns.GridColumn No;
        private DevExpress.XtraGrid.Columns.GridColumn Product;
        private DevExpress.XtraGrid.Columns.GridColumn Quantity;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn ProductPrice;
        private DevExpress.XtraGrid.Columns.GridColumn Total;
        private DevExpress.XtraGrid.Columns.GridColumn Cancel;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemCancelBTN;
        private DevExpress.XtraEditors.SidePanel sidePanel14;
        private DevExpress.XtraEditors.SimpleButton addtocartBTN;
        private DevExpress.XtraEditors.SidePanel sidePanel15;
        private DevExpress.XtraEditors.SidePanel sidePanel6;
        private DevExpress.XtraGrid.GridControl productsGC;
        private DevExpress.XtraGrid.Views.Grid.GridView productsGV;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn ProductName;
        private DevExpress.XtraGrid.Columns.GridColumn Category;
        private DevExpress.XtraGrid.Columns.GridColumn Price;
        private DevExpress.XtraGrid.Columns.GridColumn Stocks;
        private DevExpress.XtraGrid.Columns.GridColumn StockStatus;
    }
}
