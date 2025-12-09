namespace CapstoneMealPass.Forms.Staff
{
    partial class TopUpXtraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopUpXtraForm));
            this.topupamountTE = new DevExpress.XtraEditors.TextEdit();
            this.accountbalanceLBL = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.confirmBTN = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.studentidTE = new DevExpress.XtraEditors.TextEdit();
            this.statusLBL = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.topupamountTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentidTE.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // topupamountTE
            // 
            this.topupamountTE.Location = new System.Drawing.Point(34, 159);
            this.topupamountTE.Name = "topupamountTE";
            this.topupamountTE.Properties.AutoHeight = false;
            this.topupamountTE.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.topupamountTE.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.topupamountTE.Properties.MaskSettings.Set("mask", "n");
            this.topupamountTE.Size = new System.Drawing.Size(289, 28);
            this.topupamountTE.TabIndex = 18;
            // 
            // accountbalanceLBL
            // 
            this.accountbalanceLBL.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountbalanceLBL.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.accountbalanceLBL.Appearance.Options.UseFont = true;
            this.accountbalanceLBL.Appearance.Options.UseForeColor = true;
            this.accountbalanceLBL.Location = new System.Drawing.Point(285, 77);
            this.accountbalanceLBL.Name = "accountbalanceLBL";
            this.accountbalanceLBL.Size = new System.Drawing.Size(32, 16);
            this.accountbalanceLBL.TabIndex = 17;
            this.accountbalanceLBL.Text = "00.00";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(363, 38);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(225, 236);
            this.pictureEdit1.TabIndex = 16;
            // 
            // confirmBTN
            // 
            this.confirmBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(107)))), ((int)(((byte)(60)))));
            this.confirmBTN.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBTN.Appearance.Options.UseBackColor = true;
            this.confirmBTN.Appearance.Options.UseFont = true;
            this.confirmBTN.Location = new System.Drawing.Point(33, 223);
            this.confirmBTN.Name = "confirmBTN";
            this.confirmBTN.Size = new System.Drawing.Size(204, 31);
            this.confirmBTN.TabIndex = 15;
            this.confirmBTN.Text = "Confirm Top-Up";
            this.confirmBTN.Click += new System.EventHandler(this.confirmBTN_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(34, 129);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(135, 18);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Amount to Top-Up:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(99)))));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(34, 78);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(116, 16);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Account Balance:";
            // 
            // studentidTE
            // 
            this.studentidTE.Location = new System.Drawing.Point(33, 29);
            this.studentidTE.Name = "studentidTE";
            this.studentidTE.Properties.AutoHeight = false;
            this.studentidTE.Size = new System.Drawing.Size(289, 28);
            this.studentidTE.TabIndex = 12;
            // 
            // statusLBL
            // 
            this.statusLBL.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLBL.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(99)))));
            this.statusLBL.Appearance.Options.UseFont = true;
            this.statusLBL.Appearance.Options.UseForeColor = true;
            this.statusLBL.Location = new System.Drawing.Point(372, 16);
            this.statusLBL.Name = "statusLBL";
            this.statusLBL.Size = new System.Drawing.Size(44, 16);
            this.statusLBL.TabIndex = 19;
            this.statusLBL.Text = "STATUS";
            // 
            // TopUpXtraForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 281);
            this.Controls.Add(this.statusLBL);
            this.Controls.Add(this.topupamountTE);
            this.Controls.Add(this.accountbalanceLBL);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.confirmBTN);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.studentidTE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("TopUpXtraForm.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TopUpXtraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Top-Up";
            this.Load += new System.EventHandler(this.TopUpXtraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.topupamountTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentidTE.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit topupamountTE;
        private DevExpress.XtraEditors.LabelControl accountbalanceLBL;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SimpleButton confirmBTN;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit studentidTE;
        private DevExpress.XtraEditors.LabelControl statusLBL;
    }
}