namespace CapstoneMealPass.Forms.Admin
{
    partial class EditPasswordRibbonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPasswordRibbonForm));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.confirmpassBE = new DevExpress.XtraEditors.ButtonEdit();
            this.passwordBE = new DevExpress.XtraEditors.ButtonEdit();
            this.lblConfirmPasswordCaption = new DevExpress.XtraEditors.LabelControl();
            this.saveBTN = new DevExpress.XtraEditors.SimpleButton();
            this.resultLBL = new DevExpress.XtraEditors.LabelControl();
            this.resultcaptionLBL = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmpassBE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordBE.Properties)).BeginInit();
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
            this.ribbon.Size = new System.Drawing.Size(506, 49);
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
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "eyeclose.png");
            this.imageCollection1.Images.SetKeyName(1, "eyeopen.png");
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(284, 107);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(115, 16);
            this.labelControl1.TabIndex = 67;
            this.labelControl1.Text = "Confirm Password";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Appearance.Options.UseForeColor = true;
            this.labelControl11.Location = new System.Drawing.Point(50, 106);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(92, 16);
            this.labelControl11.TabIndex = 66;
            this.labelControl11.Text = "New Password";
            // 
            // confirmpassBE
            // 
            this.confirmpassBE.EditValue = "";
            this.confirmpassBE.Location = new System.Drawing.Point(282, 73);
            this.confirmpassBE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirmpassBE.Name = "confirmpassBE";
            this.confirmpassBE.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.confirmpassBE.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpassBE.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.confirmpassBE.Properties.Appearance.Options.UseBackColor = true;
            this.confirmpassBE.Properties.Appearance.Options.UseFont = true;
            this.confirmpassBE.Properties.Appearance.Options.UseForeColor = true;
            this.confirmpassBE.Properties.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.confirmpassBE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.confirmpassBE.Size = new System.Drawing.Size(172, 28);
            this.confirmpassBE.TabIndex = 65;
            this.confirmpassBE.Tag = "close";
            this.confirmpassBE.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.confirmpassBE_ButtonPressed);
            this.confirmpassBE.EditValueChanged += new System.EventHandler(this.confirmpassBE_EditValueChanged);
            // 
            // passwordBE
            // 
            this.passwordBE.EditValue = "";
            this.passwordBE.Location = new System.Drawing.Point(48, 73);
            this.passwordBE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordBE.Name = "passwordBE";
            this.passwordBE.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.passwordBE.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBE.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.passwordBE.Properties.Appearance.Options.UseBackColor = true;
            this.passwordBE.Properties.Appearance.Options.UseFont = true;
            this.passwordBE.Properties.Appearance.Options.UseForeColor = true;
            this.passwordBE.Properties.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.passwordBE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.passwordBE.Size = new System.Drawing.Size(172, 28);
            this.passwordBE.TabIndex = 64;
            this.passwordBE.Tag = "close";
            this.passwordBE.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.passwordBE_ButtonPressed);
            this.passwordBE.EditValueChanged += new System.EventHandler(this.passwordBE_EditValueChanged);
            // 
            // lblConfirmPasswordCaption
            // 
            this.lblConfirmPasswordCaption.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPasswordCaption.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblConfirmPasswordCaption.Appearance.Options.UseFont = true;
            this.lblConfirmPasswordCaption.Appearance.Options.UseForeColor = true;
            this.lblConfirmPasswordCaption.Location = new System.Drawing.Point(287, 126);
            this.lblConfirmPasswordCaption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblConfirmPasswordCaption.Name = "lblConfirmPasswordCaption";
            this.lblConfirmPasswordCaption.Size = new System.Drawing.Size(0, 15);
            this.lblConfirmPasswordCaption.TabIndex = 63;
            // 
            // saveBTN
            // 
            this.saveBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(99)))));
            this.saveBTN.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBTN.Appearance.Options.UseBackColor = true;
            this.saveBTN.Appearance.Options.UseFont = true;
            this.saveBTN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("saveBTN.ImageOptions.Image")));
            this.saveBTN.Location = new System.Drawing.Point(153, 185);
            this.saveBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(199, 35);
            this.saveBTN.TabIndex = 62;
            this.saveBTN.Text = "Save New Password";

            // 
            // resultLBL
            // 
            this.resultLBL.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLBL.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.resultLBL.Appearance.Options.UseFont = true;
            this.resultLBL.Appearance.Options.UseForeColor = true;
            this.resultLBL.Location = new System.Drawing.Point(52, 129);
            this.resultLBL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resultLBL.Name = "resultLBL";
            this.resultLBL.Size = new System.Drawing.Size(0, 15);
            this.resultLBL.TabIndex = 61;
            // 
            // resultcaptionLBL
            // 
            this.resultcaptionLBL.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultcaptionLBL.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.resultcaptionLBL.Appearance.Options.UseFont = true;
            this.resultcaptionLBL.Appearance.Options.UseForeColor = true;
            this.resultcaptionLBL.Location = new System.Drawing.Point(52, 130);
            this.resultcaptionLBL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resultcaptionLBL.Name = "resultcaptionLBL";
            this.resultcaptionLBL.Size = new System.Drawing.Size(0, 15);
            this.resultcaptionLBL.TabIndex = 60;
            // 
            // EditPasswordRibbonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 244);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.confirmpassBE);
            this.Controls.Add(this.passwordBE);
            this.Controls.Add(this.lblConfirmPasswordCaption);
            this.Controls.Add(this.saveBTN);
            this.Controls.Add(this.resultLBL);
            this.Controls.Add(this.resultcaptionLBL);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("EditPasswordRibbonForm.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditPasswordRibbonForm";
            this.Ribbon = this.ribbon;
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Password";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmpassBE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordBE.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.ButtonEdit confirmpassBE;
        private DevExpress.XtraEditors.ButtonEdit passwordBE;
        private DevExpress.XtraEditors.LabelControl lblConfirmPasswordCaption;
        private DevExpress.XtraEditors.SimpleButton saveBTN;
        private DevExpress.XtraEditors.LabelControl resultLBL;
        private DevExpress.XtraEditors.LabelControl resultcaptionLBL;
    }
}