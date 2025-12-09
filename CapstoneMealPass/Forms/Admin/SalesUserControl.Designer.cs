namespace CapstoneMealPass.Forms.Admin
{
    partial class SalesUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesUserControl));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.sidePanel5 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel10 = new DevExpress.XtraEditors.SidePanel();
            this.filterBTN = new DevExpress.XtraEditors.SimpleButton();
            this.sidePanel12 = new DevExpress.XtraEditors.SidePanel();
            this.fromDateDE = new DevExpress.XtraEditors.DateEdit();
            this.toDateDE = new DevExpress.XtraEditors.DateEdit();
            this.findTE = new DevExpress.XtraEditors.TextEdit();
            this.sidePanel9 = new DevExpress.XtraEditors.SidePanel();
            this.printBTN = new DevExpress.XtraEditors.SimpleButton();
            this.sidePanel8 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel7 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.sidePanel3 = new DevExpress.XtraEditors.SidePanel();
            this.repositoryItemButtonDelete2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.TotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemsSold = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvSales = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcSales = new DevExpress.XtraGrid.GridControl();
            this.sidePanel4 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel6 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel11 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel5.SuspendLayout();
            this.sidePanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fromDateDE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDateDE.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDateDE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDateDE.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.findTE.Properties)).BeginInit();
            this.sidePanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonDelete2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSales)).BeginInit();
            this.sidePanel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel5
            // 
            this.sidePanel5.AllowResize = false;
            this.sidePanel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.sidePanel5.Appearance.Options.UseBackColor = true;
            this.sidePanel5.BorderThickness = 0;
            this.sidePanel5.Controls.Add(this.sidePanel10);
            this.sidePanel5.Controls.Add(this.findTE);
            this.sidePanel5.Controls.Add(this.sidePanel9);
            this.sidePanel5.Controls.Add(this.sidePanel8);
            this.sidePanel5.Controls.Add(this.sidePanel7);
            this.sidePanel5.Controls.Add(this.sidePanel1);
            this.sidePanel5.Controls.Add(this.labelControl2);
            this.sidePanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel5.Location = new System.Drawing.Point(25, 12);
            this.sidePanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel5.Name = "sidePanel5";
            this.sidePanel5.Size = new System.Drawing.Size(1027, 73);
            this.sidePanel5.TabIndex = 49;
            this.sidePanel5.Text = "sidePanel5";
            // 
            // sidePanel10
            // 
            this.sidePanel10.AllowResize = false;
            this.sidePanel10.BorderThickness = 0;
            this.sidePanel10.Controls.Add(this.filterBTN);
            this.sidePanel10.Controls.Add(this.sidePanel12);
            this.sidePanel10.Controls.Add(this.fromDateDE);
            this.sidePanel10.Controls.Add(this.toDateDE);
            this.sidePanel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel10.Location = new System.Drawing.Point(564, 12);
            this.sidePanel10.Name = "sidePanel10";
            this.sidePanel10.Size = new System.Drawing.Size(346, 55);
            this.sidePanel10.TabIndex = 31;
            this.sidePanel10.Text = "sidePanel10";
            // 
            // filterBTN
            // 
            this.filterBTN.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("filterBTN.ImageOptions.SvgImage")));
            this.filterBTN.ImageOptions.SvgImageSize = new System.Drawing.Size(29, 29);
            this.filterBTN.Location = new System.Drawing.Point(293, 13);
            this.filterBTN.Name = "filterBTN";
            this.filterBTN.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.filterBTN.Size = new System.Drawing.Size(37, 30);
            this.filterBTN.TabIndex = 32;
            this.filterBTN.Text = "simpleButton1";
            this.filterBTN.Click += new System.EventHandler(this.filterBTN_Click);
            // 
            // sidePanel12
            // 
            this.sidePanel12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sidePanel12.BackgroundImage")));
            this.sidePanel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sidePanel12.Location = new System.Drawing.Point(135, 14);
            this.sidePanel12.Name = "sidePanel12";
            this.sidePanel12.Size = new System.Drawing.Size(29, 29);
            this.sidePanel12.TabIndex = 32;
            this.sidePanel12.Text = "sidePanel12";
            // 
            // fromDateDE
            // 
            this.fromDateDE.EditValue = null;
            this.fromDateDE.Location = new System.Drawing.Point(11, 17);
            this.fromDateDE.Name = "fromDateDE";
            this.fromDateDE.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.fromDateDE.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDateDE.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fromDateDE.Properties.Appearance.Options.UseBackColor = true;
            this.fromDateDE.Properties.Appearance.Options.UseFont = true;
            this.fromDateDE.Properties.Appearance.Options.UseForeColor = true;
            this.fromDateDE.Properties.AutoHeight = false;
            this.fromDateDE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fromDateDE.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fromDateDE.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.fromDateDE.Size = new System.Drawing.Size(119, 23);
            this.fromDateDE.TabIndex = 31;
            // 
            // toDateDE
            // 
            this.toDateDE.EditValue = null;
            this.toDateDE.Location = new System.Drawing.Point(169, 17);
            this.toDateDE.Name = "toDateDE";
            this.toDateDE.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.toDateDE.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDateDE.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toDateDE.Properties.Appearance.Options.UseBackColor = true;
            this.toDateDE.Properties.Appearance.Options.UseFont = true;
            this.toDateDE.Properties.Appearance.Options.UseForeColor = true;
            this.toDateDE.Properties.AutoHeight = false;
            this.toDateDE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.toDateDE.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.toDateDE.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.toDateDE.Size = new System.Drawing.Size(119, 23);
            this.toDateDE.TabIndex = 30;
            // 
            // findTE
            // 
            this.findTE.Location = new System.Drawing.Point(104, 29);
            this.findTE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.findTE.Name = "findTE";
            this.findTE.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.findTE.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findTE.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.findTE.Properties.Appearance.Options.UseBackColor = true;
            this.findTE.Properties.Appearance.Options.UseFont = true;
            this.findTE.Properties.Appearance.Options.UseForeColor = true;
            this.findTE.Properties.AutoHeight = false;
            this.findTE.Size = new System.Drawing.Size(206, 23);
            this.findTE.TabIndex = 29;
            this.findTE.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.findTE_EditValueChanging);
            // 
            // sidePanel9
            // 
            this.sidePanel9.AllowResize = false;
            this.sidePanel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.sidePanel9.Appearance.Options.UseBackColor = true;
            this.sidePanel9.BorderThickness = 0;
            this.sidePanel9.Controls.Add(this.printBTN);
            this.sidePanel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel9.Location = new System.Drawing.Point(910, 12);
            this.sidePanel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel9.Name = "sidePanel9";
            this.sidePanel9.Size = new System.Drawing.Size(108, 55);
            this.sidePanel9.TabIndex = 28;
            this.sidePanel9.Text = "sidePanel9";
            // 
            // printBTN
            // 
            this.printBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(141)))), ((int)(((byte)(57)))));
            this.printBTN.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printBTN.Appearance.Options.UseBackColor = true;
            this.printBTN.Appearance.Options.UseFont = true;
            this.printBTN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("printBTN.ImageOptions.Image")));
            this.printBTN.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.printBTN.Location = new System.Drawing.Point(8, 11);
            this.printBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.printBTN.Name = "printBTN";
            this.printBTN.Padding = new System.Windows.Forms.Padding(2);
            this.printBTN.Size = new System.Drawing.Size(93, 35);
            this.printBTN.TabIndex = 24;
            this.printBTN.Text = "Print";
            this.printBTN.Click += new System.EventHandler(this.printBTN_Click);
            // 
            // sidePanel8
            // 
            this.sidePanel8.AllowResize = false;
            this.sidePanel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.sidePanel8.Appearance.Options.UseBackColor = true;
            this.sidePanel8.BorderThickness = 0;
            this.sidePanel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sidePanel8.Location = new System.Drawing.Point(0, 67);
            this.sidePanel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel8.Name = "sidePanel8";
            this.sidePanel8.Size = new System.Drawing.Size(1018, 6);
            this.sidePanel8.TabIndex = 27;
            this.sidePanel8.Text = "sidePanel8";
            // 
            // sidePanel7
            // 
            this.sidePanel7.AllowResize = false;
            this.sidePanel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.sidePanel7.Appearance.Options.UseBackColor = true;
            this.sidePanel7.BorderThickness = 0;
            this.sidePanel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel7.Location = new System.Drawing.Point(1018, 12);
            this.sidePanel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel7.Name = "sidePanel7";
            this.sidePanel7.Size = new System.Drawing.Size(9, 61);
            this.sidePanel7.TabIndex = 26;
            this.sidePanel7.Text = "sidePanel7";
            // 
            // sidePanel1
            // 
            this.sidePanel1.AllowResize = false;
            this.sidePanel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.sidePanel1.Appearance.Options.UseBackColor = true;
            this.sidePanel1.BorderThickness = 0;
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(1027, 12);
            this.sidePanel1.TabIndex = 25;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(125)))), ((int)(((byte)(79)))));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(9, 17);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 37);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Sales";
            // 
            // sidePanel3
            // 
            this.sidePanel3.AllowResize = false;
            this.sidePanel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.sidePanel3.Appearance.Options.UseBackColor = true;
            this.sidePanel3.BorderThickness = 0;
            this.sidePanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel3.Location = new System.Drawing.Point(1052, 12);
            this.sidePanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel3.Name = "sidePanel3";
            this.sidePanel3.Size = new System.Drawing.Size(24, 545);
            this.sidePanel3.TabIndex = 46;
            this.sidePanel3.Text = "sidePanel3";
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
            // TotalAmount
            // 
            this.TotalAmount.AppearanceCell.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TotalAmount.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TotalAmount.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TotalAmount.AppearanceCell.Options.UseBackColor = true;
            this.TotalAmount.AppearanceCell.Options.UseFont = true;
            this.TotalAmount.AppearanceCell.Options.UseForeColor = true;
            this.TotalAmount.AppearanceCell.Options.UseTextOptions = true;
            this.TotalAmount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TotalAmount.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(21)))));
            this.TotalAmount.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.TotalAmount.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.TotalAmount.AppearanceHeader.Options.UseBackColor = true;
            this.TotalAmount.AppearanceHeader.Options.UseFont = true;
            this.TotalAmount.AppearanceHeader.Options.UseForeColor = true;
            this.TotalAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.TotalAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TotalAmount.Caption = "Total Amount";
            this.TotalAmount.FieldName = "TotalAmount";
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.OptionsColumn.AllowEdit = false;
            this.TotalAmount.OptionsColumn.AllowFocus = false;
            this.TotalAmount.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.TotalAmount.Visible = true;
            this.TotalAmount.VisibleIndex = 5;
            this.TotalAmount.Width = 290;
            // 
            // ItemsSold
            // 
            this.ItemsSold.AppearanceCell.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ItemsSold.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ItemsSold.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ItemsSold.AppearanceCell.Options.UseBackColor = true;
            this.ItemsSold.AppearanceCell.Options.UseFont = true;
            this.ItemsSold.AppearanceCell.Options.UseForeColor = true;
            this.ItemsSold.AppearanceCell.Options.UseTextOptions = true;
            this.ItemsSold.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ItemsSold.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(21)))));
            this.ItemsSold.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.ItemsSold.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.ItemsSold.AppearanceHeader.Options.UseBackColor = true;
            this.ItemsSold.AppearanceHeader.Options.UseFont = true;
            this.ItemsSold.AppearanceHeader.Options.UseForeColor = true;
            this.ItemsSold.AppearanceHeader.Options.UseTextOptions = true;
            this.ItemsSold.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ItemsSold.Caption = "Items Sold";
            this.ItemsSold.FieldName = "ItemSold";
            this.ItemsSold.MinWidth = 21;
            this.ItemsSold.Name = "ItemsSold";
            this.ItemsSold.OptionsColumn.AllowEdit = false;
            this.ItemsSold.OptionsColumn.AllowFocus = false;
            this.ItemsSold.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.ItemsSold.Visible = true;
            this.ItemsSold.VisibleIndex = 4;
            this.ItemsSold.Width = 314;
            // 
            // Price
            // 
            this.Price.AppearanceCell.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Price.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Price.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Price.AppearanceCell.Options.UseBackColor = true;
            this.Price.AppearanceCell.Options.UseFont = true;
            this.Price.AppearanceCell.Options.UseForeColor = true;
            this.Price.AppearanceCell.Options.UseTextOptions = true;
            this.Price.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Price.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(21)))));
            this.Price.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.Price.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.Price.AppearanceHeader.Options.UseBackColor = true;
            this.Price.AppearanceHeader.Options.UseFont = true;
            this.Price.AppearanceHeader.Options.UseForeColor = true;
            this.Price.AppearanceHeader.Options.UseTextOptions = true;
            this.Price.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Price.Caption = "Price";
            this.Price.FieldName = "UnitPrice";
            this.Price.MinWidth = 21;
            this.Price.Name = "Price";
            this.Price.OptionsColumn.AllowEdit = false;
            this.Price.OptionsColumn.AllowFocus = false;
            this.Price.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.Price.Visible = true;
            this.Price.VisibleIndex = 3;
            this.Price.Width = 199;
            // 
            // CategoryName
            // 
            this.CategoryName.AppearanceCell.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CategoryName.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CategoryName.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CategoryName.AppearanceCell.Options.UseBackColor = true;
            this.CategoryName.AppearanceCell.Options.UseFont = true;
            this.CategoryName.AppearanceCell.Options.UseForeColor = true;
            this.CategoryName.AppearanceCell.Options.UseTextOptions = true;
            this.CategoryName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CategoryName.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(21)))));
            this.CategoryName.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.CategoryName.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.CategoryName.AppearanceHeader.Options.UseBackColor = true;
            this.CategoryName.AppearanceHeader.Options.UseFont = true;
            this.CategoryName.AppearanceHeader.Options.UseForeColor = true;
            this.CategoryName.AppearanceHeader.Options.UseTextOptions = true;
            this.CategoryName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CategoryName.Caption = "Category";
            this.CategoryName.FieldName = "CategoryName";
            this.CategoryName.MinWidth = 21;
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.OptionsColumn.AllowEdit = false;
            this.CategoryName.OptionsColumn.AllowFocus = false;
            this.CategoryName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.CategoryName.Visible = true;
            this.CategoryName.VisibleIndex = 2;
            this.CategoryName.Width = 215;
            // 
            // ProductID
            // 
            this.ProductID.AppearanceCell.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ProductID.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ProductID.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProductID.AppearanceCell.Options.UseBackColor = true;
            this.ProductID.AppearanceCell.Options.UseFont = true;
            this.ProductID.AppearanceCell.Options.UseForeColor = true;
            this.ProductID.AppearanceCell.Options.UseTextOptions = true;
            this.ProductID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ProductID.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(21)))));
            this.ProductID.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.ProductID.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.ProductID.AppearanceHeader.Options.UseBackColor = true;
            this.ProductID.AppearanceHeader.Options.UseFont = true;
            this.ProductID.AppearanceHeader.Options.UseForeColor = true;
            this.ProductID.AppearanceHeader.Options.UseTextOptions = true;
            this.ProductID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ProductID.Caption = "ID";
            this.ProductID.FieldName = "ProductID";
            this.ProductID.MinWidth = 21;
            this.ProductID.Name = "ProductID";
            this.ProductID.OptionsColumn.AllowEdit = false;
            this.ProductID.OptionsColumn.AllowFocus = false;
            this.ProductID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.ProductID.Visible = true;
            this.ProductID.VisibleIndex = 0;
            this.ProductID.Width = 66;
            // 
            // gvSales
            // 
            this.gvSales.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ProductID,
            this.ProductName,
            this.CategoryName,
            this.Price,
            this.ItemsSold,
            this.TotalAmount});
            this.gvSales.DetailHeight = 284;
            this.gvSales.GridControl = this.gcSales;
            this.gvSales.Name = "gvSales";
            this.gvSales.OptionsBehavior.AutoExpandAllGroups = true;
            this.gvSales.OptionsEditForm.PopupEditFormWidth = 686;
            this.gvSales.OptionsView.RowAutoHeight = true;
            this.gvSales.OptionsView.ShowGroupPanel = false;
            // 
            // ProductName
            // 
            this.ProductName.AppearanceCell.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ProductName.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ProductName.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProductName.AppearanceCell.Options.UseBackColor = true;
            this.ProductName.AppearanceCell.Options.UseFont = true;
            this.ProductName.AppearanceCell.Options.UseForeColor = true;
            this.ProductName.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(21)))));
            this.ProductName.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.ProductName.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.ProductName.AppearanceHeader.Options.UseBackColor = true;
            this.ProductName.AppearanceHeader.Options.UseFont = true;
            this.ProductName.AppearanceHeader.Options.UseForeColor = true;
            this.ProductName.AppearanceHeader.Options.UseTextOptions = true;
            this.ProductName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ProductName.Caption = "ProductName";
            this.ProductName.FieldName = "ProductName";
            this.ProductName.MinWidth = 21;
            this.ProductName.Name = "ProductName";
            this.ProductName.OptionsColumn.AllowEdit = false;
            this.ProductName.OptionsColumn.AllowFocus = false;
            this.ProductName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.ProductName.Visible = true;
            this.ProductName.VisibleIndex = 1;
            this.ProductName.Width = 475;
            // 
            // gcSales
            // 
            this.gcSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSales.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcSales.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcSales.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcSales.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcSales.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcSales.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcSales.Location = new System.Drawing.Point(0, 0);
            this.gcSales.MainView = this.gvSales;
            this.gcSales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcSales.Name = "gcSales";
            this.gcSales.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1,
            this.repositoryItemButtonEdit1,
            this.repositoryItemButtonDelete2});
            this.gcSales.Size = new System.Drawing.Size(1027, 472);
            this.gcSales.TabIndex = 50;
            this.gcSales.UseEmbeddedNavigator = true;
            this.gcSales.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSales});
            // 
            // sidePanel4
            // 
            this.sidePanel4.AllowResize = false;
            this.sidePanel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.sidePanel4.Appearance.Options.UseBackColor = true;
            this.sidePanel4.BorderThickness = 0;
            this.sidePanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sidePanel4.Location = new System.Drawing.Point(25, 557);
            this.sidePanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel4.Name = "sidePanel4";
            this.sidePanel4.Size = new System.Drawing.Size(1051, 33);
            this.sidePanel4.TabIndex = 47;
            this.sidePanel4.Text = "sidePanel4";
            // 
            // sidePanel2
            // 
            this.sidePanel2.AllowResize = false;
            this.sidePanel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.sidePanel2.Appearance.Options.UseBackColor = true;
            this.sidePanel2.BorderThickness = 0;
            this.sidePanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel2.Location = new System.Drawing.Point(0, 12);
            this.sidePanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(25, 578);
            this.sidePanel2.TabIndex = 45;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // sidePanel6
            // 
            this.sidePanel6.AllowResize = false;
            this.sidePanel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.sidePanel6.Appearance.Options.UseBackColor = true;
            this.sidePanel6.BorderThickness = 0;
            this.sidePanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel6.Location = new System.Drawing.Point(0, 0);
            this.sidePanel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel6.Name = "sidePanel6";
            this.sidePanel6.Size = new System.Drawing.Size(1076, 12);
            this.sidePanel6.TabIndex = 48;
            this.sidePanel6.Text = "sidePanel6";
            // 
            // sidePanel11
            // 
            this.sidePanel11.AllowResize = false;
            this.sidePanel11.BorderThickness = 0;
            this.sidePanel11.Controls.Add(this.gcSales);
            this.sidePanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel11.Location = new System.Drawing.Point(25, 85);
            this.sidePanel11.Name = "sidePanel11";
            this.sidePanel11.Size = new System.Drawing.Size(1027, 472);
            this.sidePanel11.TabIndex = 51;
            this.sidePanel11.Text = "sidePanel11";
            // 
            // SalesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidePanel11);
            this.Controls.Add(this.sidePanel5);
            this.Controls.Add(this.sidePanel3);
            this.Controls.Add(this.sidePanel4);
            this.Controls.Add(this.sidePanel2);
            this.Controls.Add(this.sidePanel6);
            this.Name = "SalesUserControl";
            this.Size = new System.Drawing.Size(1076, 590);
            this.Load += new System.EventHandler(this.SalesUserControl_Load);
            this.sidePanel5.ResumeLayout(false);
            this.sidePanel5.PerformLayout();
            this.sidePanel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fromDateDE.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDateDE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDateDE.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDateDE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.findTE.Properties)).EndInit();
            this.sidePanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonDelete2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSales)).EndInit();
            this.sidePanel11.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SidePanel sidePanel5;
        private DevExpress.XtraEditors.SidePanel sidePanel10;
        private DevExpress.XtraEditors.DateEdit toDateDE;
        private DevExpress.XtraEditors.TextEdit findTE;
        private DevExpress.XtraEditors.SidePanel sidePanel9;
        private DevExpress.XtraEditors.SimpleButton printBTN;
        private DevExpress.XtraEditors.SidePanel sidePanel8;
        private DevExpress.XtraEditors.SidePanel sidePanel7;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SidePanel sidePanel3;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonDelete2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn TotalAmount;
        private DevExpress.XtraGrid.Columns.GridColumn ItemsSold;
        private DevExpress.XtraGrid.Columns.GridColumn Price;
        private DevExpress.XtraGrid.Columns.GridColumn CategoryName;
        private DevExpress.XtraGrid.Columns.GridColumn ProductID;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSales;
        private DevExpress.XtraGrid.Columns.GridColumn ProductName;
        private DevExpress.XtraGrid.GridControl gcSales;
        private DevExpress.XtraEditors.SidePanel sidePanel4;
        private DevExpress.XtraEditors.SidePanel sidePanel2;
        private DevExpress.XtraEditors.SidePanel sidePanel6;
        private DevExpress.XtraEditors.SidePanel sidePanel11;
        private DevExpress.XtraEditors.SidePanel sidePanel12;
        private DevExpress.XtraEditors.DateEdit fromDateDE;
        private DevExpress.XtraEditors.SimpleButton filterBTN;
    }
}
