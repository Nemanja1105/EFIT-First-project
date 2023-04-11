namespace Bodyweight_Students
{
    partial class ForgotVerCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotVerCode));
            this.ResendBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.backBtn = new Bunifu.UI.WinForms.BunifuImageButton();
            this.errorLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.subBtn = new System.Windows.Forms.Button();
            this.codeTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.opisLbl = new Bunifu.UI.WinForms.BunifuLabel();
            this.nazivLbl = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuFormFadeTransition1 = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.SuspendLayout();
            // 
            // ResendBtn
            // 
            this.ResendBtn.Active = false;
            this.ResendBtn.Activecolor = System.Drawing.Color.Transparent;
            this.ResendBtn.BackColor = System.Drawing.Color.Transparent;
            this.ResendBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ResendBtn.BorderRadius = 0;
            this.ResendBtn.ButtonText = "Ponovo pošalji kod";
            this.ResendBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResendBtn.DisabledColor = System.Drawing.Color.Gray;
            this.ResendBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.ResendBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("ResendBtn.Iconimage")));
            this.ResendBtn.Iconimage_right = null;
            this.ResendBtn.Iconimage_right_Selected = null;
            this.ResendBtn.Iconimage_Selected = null;
            this.ResendBtn.IconMarginLeft = 0;
            this.ResendBtn.IconMarginRight = 0;
            this.ResendBtn.IconRightVisible = true;
            this.ResendBtn.IconRightZoom = 0D;
            this.ResendBtn.IconVisible = false;
            this.ResendBtn.IconZoom = 90D;
            this.ResendBtn.IsTab = false;
            this.ResendBtn.Location = new System.Drawing.Point(76, 268);
            this.ResendBtn.Name = "ResendBtn";
            this.ResendBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.ResendBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.ResendBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.ResendBtn.selected = false;
            this.ResendBtn.Size = new System.Drawing.Size(161, 42);
            this.ResendBtn.TabIndex = 18;
            this.ResendBtn.Text = "Ponovo pošalji kod";
            this.ResendBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ResendBtn.Textcolor = System.Drawing.Color.White;
            this.ResendBtn.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResendBtn.Click += new System.EventHandler(this.ResendBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.ActiveImage = null;
            this.backBtn.AllowAnimations = true;
            this.backBtn.AllowZooming = true;
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("backBtn.ErrorImage")));
            this.backBtn.FadeWhenInactive = false;
            this.backBtn.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.ImageActive = null;
            this.backBtn.ImageLocation = null;
            this.backBtn.ImageMargin = 40;
            this.backBtn.ImageSize = new System.Drawing.Size(38, 36);
            this.backBtn.ImageZoomSize = new System.Drawing.Size(78, 76);
            this.backBtn.InitialImage = ((System.Drawing.Image)(resources.GetObject("backBtn.InitialImage")));
            this.backBtn.Location = new System.Drawing.Point(-1, -4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Rotation = 180;
            this.backBtn.ShowActiveImage = true;
            this.backBtn.ShowCursorChanges = true;
            this.backBtn.ShowImageBorders = true;
            this.backBtn.ShowSizeMarkers = true;
            this.backBtn.Size = new System.Drawing.Size(78, 76);
            this.backBtn.TabIndex = 17;
            this.backBtn.ToolTipText = "";
            this.backBtn.WaitOnLoad = false;
            this.backBtn.Zoom = 40;
            this.backBtn.ZoomSpeed = 10;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoEllipsis = false;
            this.errorLabel.AutoSize = false;
            this.errorLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.errorLabel.CursorType = null;
            this.errorLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.White;
            this.errorLabel.Location = new System.Drawing.Point(21, 316);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.errorLabel.Size = new System.Drawing.Size(317, 52);
            this.errorLabel.TabIndex = 16;
            this.errorLabel.Text = "Error Code";
            this.errorLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // subBtn
            // 
            this.subBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.subBtn.FlatAppearance.BorderSize = 0;
            this.subBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subBtn.ForeColor = System.Drawing.Color.White;
            this.subBtn.Location = new System.Drawing.Point(106, 207);
            this.subBtn.Name = "subBtn";
            this.subBtn.Size = new System.Drawing.Size(131, 55);
            this.subBtn.TabIndex = 15;
            this.subBtn.Text = "Potvrdi";
            this.subBtn.UseVisualStyleBackColor = false;
            this.subBtn.Click += new System.EventHandler(this.subBtn_Click);
            // 
            // codeTxt
            // 
            this.codeTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.codeTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.codeTxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.codeTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.codeTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeTxt.ForeColor = System.Drawing.Color.White;
            this.codeTxt.HintForeColor = System.Drawing.Color.Empty;
            this.codeTxt.HintText = "";
            this.codeTxt.isPassword = false;
            this.codeTxt.LineFocusedColor = System.Drawing.Color.White;
            this.codeTxt.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(85)))), ((int)(((byte)(123)))));
            this.codeTxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(85)))), ((int)(((byte)(123)))));
            this.codeTxt.LineThickness = 4;
            this.codeTxt.Location = new System.Drawing.Point(33, 154);
            this.codeTxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.codeTxt.MaxLength = 32767;
            this.codeTxt.Name = "codeTxt";
            this.codeTxt.Size = new System.Drawing.Size(303, 45);
            this.codeTxt.TabIndex = 14;
            this.codeTxt.Text = "Enter here";
            this.codeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // opisLbl
            // 
            this.opisLbl.AutoEllipsis = false;
            this.opisLbl.AutoSize = false;
            this.opisLbl.CursorType = null;
            this.opisLbl.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.opisLbl.ForeColor = System.Drawing.Color.White;
            this.opisLbl.Location = new System.Drawing.Point(21, 96);
            this.opisLbl.Name = "opisLbl";
            this.opisLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.opisLbl.Size = new System.Drawing.Size(320, 50);
            this.opisLbl.TabIndex = 13;
            this.opisLbl.Text = "Unesite verifikacioni kod koji smo vam poslali";
            this.opisLbl.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // nazivLbl
            // 
            this.nazivLbl.AutoEllipsis = false;
            this.nazivLbl.AutoSize = false;
            this.nazivLbl.CursorType = null;
            this.nazivLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.nazivLbl.ForeColor = System.Drawing.Color.White;
            this.nazivLbl.Location = new System.Drawing.Point(93, 12);
            this.nazivLbl.Name = "nazivLbl";
            this.nazivLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nazivLbl.Size = new System.Drawing.Size(199, 78);
            this.nazivLbl.TabIndex = 12;
            this.nazivLbl.Text = "Unesite verifikacioni kod";
            this.nazivLbl.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuFormFadeTransition1
            // 
            this.bunifuFormFadeTransition1.Delay = 1;
            // 
            // ForgotVerCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(350, 380);
            this.Controls.Add(this.ResendBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.subBtn);
            this.Controls.Add(this.codeTxt);
            this.Controls.Add(this.opisLbl);
            this.Controls.Add(this.nazivLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotVerCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotVerCode";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton ResendBtn;
        private Bunifu.UI.WinForms.BunifuImageButton backBtn;
        private Bunifu.UI.WinForms.BunifuLabel errorLabel;
        private System.Windows.Forms.Button subBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox codeTxt;
        private Bunifu.UI.WinForms.BunifuLabel opisLbl;
        private Bunifu.UI.WinForms.BunifuLabel nazivLbl;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFormFadeTransition bunifuFormFadeTransition1;
    }
}