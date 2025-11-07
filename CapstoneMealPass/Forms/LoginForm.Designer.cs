namespace CapstoneMealPass.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.directXFormContainerControl1 = new DevExpress.XtraEditors.DirectXFormContainerControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.passwordTE = new DevExpress.XtraEditors.TextEdit();
            this.usernameTE = new DevExpress.XtraEditors.TextEdit();
            this.showCE = new DevExpress.XtraEditors.CheckEdit();
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            this.loginBTN = new DevExpress.XtraEditors.SimpleButton();
            this.directXFormContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showCE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // directXFormContainerControl1
            // 
            this.directXFormContainerControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.directXFormContainerControl1.Controls.Add(this.labelControl1);
            this.directXFormContainerControl1.Controls.Add(this.passwordTE);
            this.directXFormContainerControl1.Controls.Add(this.usernameTE);
            this.directXFormContainerControl1.Location = new System.Drawing.Point(113, 169);
            this.directXFormContainerControl1.Name = "directXFormContainerControl1";
            this.directXFormContainerControl1.Size = new System.Drawing.Size(723, 254);
            this.directXFormContainerControl1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(107)))), ((int)(((byte)(60)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(257, 100);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(212, 32);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Let\'s get started!";
            // 
            // passwordTE
            // 
            this.passwordTE.EditValue = "Password";
            this.passwordTE.Location = new System.Drawing.Point(177, 208);
            this.passwordTE.Name = "passwordTE";
            this.passwordTE.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.passwordTE.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.passwordTE.Properties.Appearance.Options.UseFont = true;
            this.passwordTE.Properties.Appearance.Options.UseForeColor = true;
            this.passwordTE.Properties.AutoHeight = false;
            this.passwordTE.Size = new System.Drawing.Size(376, 36);
            this.passwordTE.TabIndex = 1;
            // 
            // usernameTE
            // 
            this.usernameTE.EditValue = "Username";
            this.usernameTE.Location = new System.Drawing.Point(177, 154);
            this.usernameTE.Name = "usernameTE";
            this.usernameTE.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.usernameTE.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.usernameTE.Properties.Appearance.Options.UseFont = true;
            this.usernameTE.Properties.Appearance.Options.UseForeColor = true;
            this.usernameTE.Properties.AutoHeight = false;
            this.usernameTE.Size = new System.Drawing.Size(376, 36);
            this.usernameTE.TabIndex = 0;
            // 
            // showCE
            // 
            this.showCE.Location = new System.Drawing.Point(601, 419);
            this.showCE.Name = "showCE";
            this.showCE.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.showCE.Properties.Appearance.ForeColor = System.Drawing.Color.Green;
            this.showCE.Properties.Appearance.Options.UseFont = true;
            this.showCE.Properties.Appearance.Options.UseForeColor = true;
            this.showCE.Properties.Caption = "Show";
            this.showCE.Size = new System.Drawing.Size(65, 22);
            this.showCE.TabIndex = 2;
            this.showCE.CheckedChanged += new System.EventHandler(this.showCE_CheckedChanged);
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.Add("mp-logo", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.mp-logo"))));
            this.svgImageCollection1.Add("closebutton", "image://svgimages/richedit/clearheaderandfooter.svg");
            // 
            // loginBTN
            // 
            this.loginBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(107)))), ((int)(((byte)(60)))));
            this.loginBTN.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBTN.Appearance.Options.UseBackColor = true;
            this.loginBTN.Appearance.Options.UseFont = true;
            this.loginBTN.Location = new System.Drawing.Point(412, 455);
            this.loginBTN.Name = "loginBTN";
            this.loginBTN.Size = new System.Drawing.Size(132, 35);
            this.loginBTN.TabIndex = 1;
            this.loginBTN.Text = "Login";
            this.loginBTN.Click += new System.EventHandler(this.loginBTN_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ChildControls.Add(this.directXFormContainerControl1);
            this.ChildControls.Add(this.loginBTN);
            this.ChildControls.Add(this.showCE);
            this.ClientSize = new System.Drawing.Size(857, 586);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.HtmlImages = this.svgImageCollection1;
            this.HtmlTemplate.Styles = resources.GetString("LoginForm.HtmlTemplate.Styles");
            this.HtmlTemplate.Template = resources.GetString("LoginForm.HtmlTemplate.Template");
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.directXFormContainerControl1.ResumeLayout(false);
            this.directXFormContainerControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showCE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DirectXFormContainerControl directXFormContainerControl1;
        private DevExpress.Utils.SvgImageCollection svgImageCollection1;
        private DevExpress.XtraEditors.TextEdit usernameTE;
        private DevExpress.XtraEditors.TextEdit passwordTE;
        private DevExpress.XtraEditors.CheckEdit showCE;
        private DevExpress.XtraEditors.SimpleButton loginBTN;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}