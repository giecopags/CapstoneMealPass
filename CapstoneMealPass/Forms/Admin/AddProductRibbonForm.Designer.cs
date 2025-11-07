namespace CapstoneMealPass.Forms.Admin
{
    partial class AddProductRibbonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductRibbonForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lowstocklevelTE = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.quantityTE = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.addproductBTN = new DevExpress.XtraEditors.SimpleButton();
            this.priceTE = new DevExpress.XtraEditors.TextEdit();
            this.categoryCBE = new DevExpress.XtraEditors.ComboBoxEdit();
            this.productnameTE = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowstocklevelTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryCBE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productnameTE.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(516, 49);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.LightGray;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(75, 435);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(100, 16);
            this.labelControl5.TabIndex = 45;
            this.labelControl5.Text = "Low Stock Level";
            // 
            // lowstocklevelTE
            // 
            this.lowstocklevelTE.Location = new System.Drawing.Point(75, 392);
            this.lowstocklevelTE.Margin = new System.Windows.Forms.Padding(4);
            this.lowstocklevelTE.Name = "lowstocklevelTE";
            this.lowstocklevelTE.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.lowstocklevelTE.Properties.Appearance.BorderColor = System.Drawing.Color.White;
            this.lowstocklevelTE.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.lowstocklevelTE.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lowstocklevelTE.Properties.Appearance.Options.UseBackColor = true;
            this.lowstocklevelTE.Properties.Appearance.Options.UseBorderColor = true;
            this.lowstocklevelTE.Properties.Appearance.Options.UseFont = true;
            this.lowstocklevelTE.Properties.Appearance.Options.UseForeColor = true;
            this.lowstocklevelTE.Properties.AutoHeight = false;
            this.lowstocklevelTE.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.lowstocklevelTE.Properties.MaskSettings.Set("mask", "d");
            this.lowstocklevelTE.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.lowstocklevelTE.Size = new System.Drawing.Size(362, 40);
            this.lowstocklevelTE.TabIndex = 44;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.LightGray;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(75, 356);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(56, 16);
            this.labelControl4.TabIndex = 43;
            this.labelControl4.Text = "Quantity";
            // 
            // quantityTE
            // 
            this.quantityTE.Location = new System.Drawing.Point(75, 313);
            this.quantityTE.Margin = new System.Windows.Forms.Padding(4);
            this.quantityTE.Name = "quantityTE";
            this.quantityTE.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.quantityTE.Properties.Appearance.BorderColor = System.Drawing.Color.White;
            this.quantityTE.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.quantityTE.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.quantityTE.Properties.Appearance.Options.UseBackColor = true;
            this.quantityTE.Properties.Appearance.Options.UseBorderColor = true;
            this.quantityTE.Properties.Appearance.Options.UseFont = true;
            this.quantityTE.Properties.Appearance.Options.UseForeColor = true;
            this.quantityTE.Properties.AutoHeight = false;
            this.quantityTE.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.quantityTE.Properties.MaskSettings.Set("mask", "d");
            this.quantityTE.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.quantityTE.Size = new System.Drawing.Size(362, 40);
            this.quantityTE.TabIndex = 42;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.LightGray;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(75, 277);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 16);
            this.labelControl3.TabIndex = 41;
            this.labelControl3.Text = "Price";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.LightGray;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(75, 199);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 16);
            this.labelControl2.TabIndex = 40;
            this.labelControl2.Text = "Category";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.LightGray;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(75, 121);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(92, 16);
            this.labelControl1.TabIndex = 39;
            this.labelControl1.Text = "Product Name";
            // 
            // addproductBTN
            // 
            this.addproductBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(99)))));
            this.addproductBTN.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addproductBTN.Appearance.Options.UseBackColor = true;
            this.addproductBTN.Appearance.Options.UseFont = true;
            this.addproductBTN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("addproductBTN.ImageOptions.Image")));
            this.addproductBTN.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.addproductBTN.Location = new System.Drawing.Point(167, 487);
            this.addproductBTN.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.addproductBTN.Name = "addproductBTN";
            this.addproductBTN.Padding = new System.Windows.Forms.Padding(2);
            this.addproductBTN.Size = new System.Drawing.Size(182, 47);
            this.addproductBTN.TabIndex = 38;
            this.addproductBTN.Text = "Add Product";
            this.addproductBTN.Click += new System.EventHandler(this.addproductBTN_Click);
            // 
            // priceTE
            // 
            this.priceTE.Location = new System.Drawing.Point(75, 234);
            this.priceTE.Margin = new System.Windows.Forms.Padding(4);
            this.priceTE.Name = "priceTE";
            this.priceTE.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.priceTE.Properties.Appearance.BorderColor = System.Drawing.Color.White;
            this.priceTE.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.priceTE.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.priceTE.Properties.Appearance.Options.UseBackColor = true;
            this.priceTE.Properties.Appearance.Options.UseBorderColor = true;
            this.priceTE.Properties.Appearance.Options.UseFont = true;
            this.priceTE.Properties.Appearance.Options.UseForeColor = true;
            this.priceTE.Properties.AutoHeight = false;
            this.priceTE.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.priceTE.Properties.MaskSettings.Set("mask", "n");
            this.priceTE.Size = new System.Drawing.Size(362, 40);
            this.priceTE.TabIndex = 37;
            // 
            // categoryCBE
            // 
            this.categoryCBE.Location = new System.Drawing.Point(75, 155);
            this.categoryCBE.Margin = new System.Windows.Forms.Padding(4);
            this.categoryCBE.Name = "categoryCBE";
            this.categoryCBE.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.categoryCBE.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.categoryCBE.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.categoryCBE.Properties.Appearance.Options.UseBackColor = true;
            this.categoryCBE.Properties.Appearance.Options.UseFont = true;
            this.categoryCBE.Properties.Appearance.Options.UseForeColor = true;
            this.categoryCBE.Properties.AutoHeight = false;
            this.categoryCBE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.categoryCBE.Properties.Items.AddRange(new object[] {
            "Snacks",
            "Drinks",
            "Meals"});
            this.categoryCBE.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.categoryCBE.Size = new System.Drawing.Size(362, 40);
            this.categoryCBE.TabIndex = 36;
            // 
            // productnameTE
            // 
            this.productnameTE.Location = new System.Drawing.Point(75, 77);
            this.productnameTE.Margin = new System.Windows.Forms.Padding(4);
            this.productnameTE.Name = "productnameTE";
            this.productnameTE.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.productnameTE.Properties.Appearance.BorderColor = System.Drawing.Color.White;
            this.productnameTE.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.productnameTE.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.productnameTE.Properties.Appearance.Options.UseBackColor = true;
            this.productnameTE.Properties.Appearance.Options.UseBorderColor = true;
            this.productnameTE.Properties.Appearance.Options.UseFont = true;
            this.productnameTE.Properties.Appearance.Options.UseForeColor = true;
            this.productnameTE.Properties.AutoHeight = false;
            this.productnameTE.Size = new System.Drawing.Size(362, 40);
            this.productnameTE.TabIndex = 35;
            // 
            // AddProductRibbonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 562);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.lowstocklevelTE);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.quantityTE);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.addproductBTN);
            this.Controls.Add(this.priceTE);
            this.Controls.Add(this.categoryCBE);
            this.Controls.Add(this.productnameTE);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("AddProductRibbonForm.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddProductRibbonForm";
            this.Ribbon = this.ribbon;
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowstocklevelTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryCBE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productnameTE.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit lowstocklevelTE;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit quantityTE;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton addproductBTN;
        private DevExpress.XtraEditors.TextEdit priceTE;
        private DevExpress.XtraEditors.ComboBoxEdit categoryCBE;
        private DevExpress.XtraEditors.TextEdit productnameTE;
    }
}