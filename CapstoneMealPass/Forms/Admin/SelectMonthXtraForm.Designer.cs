namespace CapstoneMealPass.Forms.Admin
{
    partial class SelectMonthXtraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectMonthXtraForm));
            this.usernameLBL = new DevExpress.XtraEditors.LabelControl();
            this.printBTN = new DevExpress.XtraEditors.SimpleButton();
            this.dateDE = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDE.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLBL
            // 
            this.usernameLBL.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLBL.Appearance.ForeColor = System.Drawing.Color.White;
            this.usernameLBL.Appearance.Options.UseFont = true;
            this.usernameLBL.Appearance.Options.UseForeColor = true;
            this.usernameLBL.Location = new System.Drawing.Point(37, 22);
            this.usernameLBL.Name = "usernameLBL";
            this.usernameLBL.Size = new System.Drawing.Size(100, 18);
            this.usernameLBL.TabIndex = 29;
            this.usernameLBL.Text = "Select Month:";
            // 
            // printBTN
            // 
            this.printBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(141)))), ((int)(((byte)(57)))));
            this.printBTN.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printBTN.Appearance.Options.UseBackColor = true;
            this.printBTN.Appearance.Options.UseFont = true;
            this.printBTN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("printBTN.ImageOptions.Image")));
            this.printBTN.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.printBTN.Location = new System.Drawing.Point(159, 95);
            this.printBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.printBTN.Name = "printBTN";
            this.printBTN.Padding = new System.Windows.Forms.Padding(2);
            this.printBTN.Size = new System.Drawing.Size(93, 35);
            this.printBTN.TabIndex = 28;
            this.printBTN.Text = "Print";
            this.printBTN.Click += new System.EventHandler(this.printBTN_Click);
            // 
            // dateDE
            // 
            this.dateDE.EditValue = null;
            this.dateDE.Location = new System.Drawing.Point(36, 52);
            this.dateDE.Name = "dateDE";
            this.dateDE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDE.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDE.Properties.DisplayFormat.FormatString = "";
            this.dateDE.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateDE.Properties.EditFormat.FormatString = "";
            this.dateDE.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateDE.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.dateDE.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dateDE.Properties.MaskSettings.Set("mask", "Y");
            this.dateDE.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateDE.Properties.VistaCalendarInitialViewStyle = DevExpress.XtraEditors.VistaCalendarInitialViewStyle.YearView;
            this.dateDE.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView;
            this.dateDE.Size = new System.Drawing.Size(337, 28);
            this.dateDE.TabIndex = 27;
            // 
            // SelectMonthXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 163);
            this.Controls.Add(this.usernameLBL);
            this.Controls.Add(this.printBTN);
            this.Controls.Add(this.dateDE);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectMonthXtraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monthly Sales Report";
            ((System.ComponentModel.ISupportInitialize)(this.dateDE.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDE.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl usernameLBL;
        private DevExpress.XtraEditors.SimpleButton printBTN;
        private DevExpress.XtraEditors.DateEdit dateDE;
    }
}