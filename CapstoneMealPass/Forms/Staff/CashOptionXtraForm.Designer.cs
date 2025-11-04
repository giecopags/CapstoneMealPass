namespace CapstoneMealPass.Forms.Staff
{
    partial class CashOptionXtraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashOptionXtraForm));
            this.accountbalanceLBL = new DevExpress.XtraEditors.LabelControl();
            this.totalamountLBL = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.confirmBTN = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cashpaymentTE = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashpaymentTE.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // accountbalanceLBL
            // 
            this.accountbalanceLBL.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountbalanceLBL.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.accountbalanceLBL.Appearance.Options.UseFont = true;
            this.accountbalanceLBL.Appearance.Options.UseForeColor = true;
            this.accountbalanceLBL.Location = new System.Drawing.Point(284, 121);
            this.accountbalanceLBL.Name = "accountbalanceLBL";
            this.accountbalanceLBL.Size = new System.Drawing.Size(32, 16);
            this.accountbalanceLBL.TabIndex = 17;
            this.accountbalanceLBL.Text = "00.00";
            // 
            // totalamountLBL
            // 
            this.totalamountLBL.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalamountLBL.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.totalamountLBL.Appearance.Options.UseFont = true;
            this.totalamountLBL.Appearance.Options.UseForeColor = true;
            this.totalamountLBL.Location = new System.Drawing.Point(284, 80);
            this.totalamountLBL.Name = "totalamountLBL";
            this.totalamountLBL.Size = new System.Drawing.Size(32, 16);
            this.totalamountLBL.TabIndex = 16;
            this.totalamountLBL.Text = "00.00";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(349, 26);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(186, 181);
            this.pictureEdit1.TabIndex = 15;
            // 
            // confirmBTN
            // 
            this.confirmBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(107)))), ((int)(((byte)(60)))));
            this.confirmBTN.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBTN.Appearance.Options.UseBackColor = true;
            this.confirmBTN.Appearance.Options.UseFont = true;
            this.confirmBTN.Location = new System.Drawing.Point(32, 164);
            this.confirmBTN.Name = "confirmBTN";
            this.confirmBTN.Size = new System.Drawing.Size(204, 31);
            this.confirmBTN.TabIndex = 14;
            this.confirmBTN.Text = "Confirm Purchase";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(33, 121);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 16);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Change:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(33, 80);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(89, 16);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Total Amount:";
            // 
            // cashpaymentTE
            // 
            this.cashpaymentTE.EditValue = "Input Payment";
            this.cashpaymentTE.Location = new System.Drawing.Point(32, 29);
            this.cashpaymentTE.Name = "cashpaymentTE";
            this.cashpaymentTE.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashpaymentTE.Properties.Appearance.Options.UseFont = true;
            this.cashpaymentTE.Properties.Appearance.Options.UseTextOptions = true;
            this.cashpaymentTE.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cashpaymentTE.Properties.AutoHeight = false;
            this.cashpaymentTE.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.cashpaymentTE.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.cashpaymentTE.Properties.MaskSettings.Set("mask", "c");
            this.cashpaymentTE.Size = new System.Drawing.Size(289, 28);
            this.cashpaymentTE.TabIndex = 11;
            // 
            // CashOptionXtraForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 229);
            this.Controls.Add(this.accountbalanceLBL);
            this.Controls.Add(this.totalamountLBL);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.confirmBTN);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cashpaymentTE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("CashOptionXtraForm.IconOptions.SvgImage")));
            this.Name = "CashOptionXtraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cash";
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashpaymentTE.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl accountbalanceLBL;
        private DevExpress.XtraEditors.LabelControl totalamountLBL;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SimpleButton confirmBTN;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit cashpaymentTE;
    }
}