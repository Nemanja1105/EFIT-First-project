namespace Bodyweight_Students
{
    partial class verCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(verCode));
            this.opisLbl = new Bunifu.UI.WinForms.BunifuLabel();
            this.nazivLbl = new Bunifu.UI.WinForms.BunifuLabel();
            this.codeTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.subBtn = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.backBtn = new Bunifu.UI.WinForms.BunifuImageButton();
            this.errorLbl = new Bunifu.UI.WinForms.BunifuLabel();
            this.ResendBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFormFadeTransition1 = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.SuspendLayout();
            // 
            // opisLbl
            // 
            this.opisLbl.AutoEllipsis = false;
            this.opisLbl.AutoSize = false;
            this.opisLbl.CursorType = null;
            this.opisLbl.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.opisLbl.ForeColor = System.Drawing.Color.White;
            this.opisLbl.Location = new System.Drawing.Point(45, 97);
            this.opisLbl.Name = "opisLbl";
            this.opisLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.opisLbl.Size = new System.Drawing.Size(320, 88);
            this.opisLbl.TabIndex = 5;
            this.opisLbl.Text = "Zelimo da budemo sigurn da ste to vi.Kako bismo utvrdili vas identitet, unesite v" +
    "erifikacioni kod koji smo vam poslali";
            this.opisLbl.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // nazivLbl
            // 
            this.nazivLbl.AutoEllipsis = false;
            this.nazivLbl.AutoSize = false;
            this.nazivLbl.CursorType = null;
            this.nazivLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.nazivLbl.ForeColor = System.Drawing.Color.White;
            this.nazivLbl.Location = new System.Drawing.Point(94, -1);
            this.nazivLbl.Name = "nazivLbl";
            this.nazivLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nazivLbl.Size = new System.Drawing.Size(231, 108);
            this.nazivLbl.TabIndex = 4;
            this.nazivLbl.Text = "Unesite ver. kod\r\n";
            this.nazivLbl.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
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
            this.codeTxt.Location = new System.Drawing.Point(22, 193);
            this.codeTxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.codeTxt.MaxLength = 32767;
            this.codeTxt.Name = "codeTxt";
            this.codeTxt.Size = new System.Drawing.Size(363, 45);
            this.codeTxt.TabIndex = 6;
            this.codeTxt.Text = "Enter here";
            this.codeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // subBtn
            // 
            this.subBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.subBtn.FlatAppearance.BorderSize = 0;
            this.subBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subBtn.ForeColor = System.Drawing.Color.White;
            this.subBtn.Location = new System.Drawing.Point(122, 256);
            this.subBtn.Name = "subBtn";
            this.subBtn.Size = new System.Drawing.Size(131, 55);
            this.subBtn.TabIndex = 7;
            this.subBtn.Text = "Potvrdi";
            this.subBtn.UseVisualStyleBackColor = false;
            this.subBtn.Click += new System.EventHandler(this.subBtn_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
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
            this.backBtn.Location = new System.Drawing.Point(0, -1);
            this.backBtn.Name = "backBtn";
            this.backBtn.Rotation = 180;
            this.backBtn.ShowActiveImage = true;
            this.backBtn.ShowCursorChanges = true;
            this.backBtn.ShowImageBorders = true;
            this.backBtn.ShowSizeMarkers = true;
            this.backBtn.Size = new System.Drawing.Size(78, 76);
            this.backBtn.TabIndex = 9;
            this.backBtn.ToolTipText = "";
            this.backBtn.WaitOnLoad = false;
            this.backBtn.Zoom = 40;
            this.backBtn.ZoomSpeed = 10;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // errorLbl
            // 
            this.errorLbl.AutoEllipsis = false;
            this.errorLbl.AutoSize = false;
            this.errorLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.errorLbl.CursorType = null;
            this.errorLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLbl.ForeColor = System.Drawing.Color.White;
            this.errorLbl.Location = new System.Drawing.Point(35, 361);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.errorLbl.Size = new System.Drawing.Size(317, 48);
            this.errorLbl.TabIndex = 8;
            this.errorLbl.Text = "Error Code";
            this.errorLbl.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
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
            this.ResendBtn.Location = new System.Drawing.Point(69, 317);
            this.ResendBtn.Name = "ResendBtn";
            this.ResendBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.ResendBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.ResendBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.ResendBtn.selected = false;
            this.ResendBtn.Size = new System.Drawing.Size(194, 38);
            this.ResendBtn.TabIndex = 11;
            this.ResendBtn.Text = "Ponovo pošalji kod";
            this.ResendBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ResendBtn.Textcolor = System.Drawing.Color.White;
            this.ResendBtn.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResendBtn.Click += new System.EventHandler(this.ResendBtn_Click);
            // 
            // bunifuFormFadeTransition1
            // 
            this.bunifuFormFadeTransition1.Delay = 1;
            // 
            // verCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(399, 441);
            this.Controls.Add(this.ResendBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.subBtn);
            this.Controls.Add(this.codeTxt);
            this.Controls.Add(this.opisLbl);
            this.Controls.Add(this.nazivLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "verCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "verCode";
            this.Load += new System.EventHandler(this.verCode_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel opisLbl;
        private Bunifu.UI.WinForms.BunifuLabel nazivLbl;
        private Bunifu.Framework.UI.BunifuMaterialTextbox codeTxt;
        private System.Windows.Forms.Button subBtn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuImageButton backBtn;
        private Bunifu.UI.WinForms.BunifuLabel errorLbl;
        private Bunifu.Framework.UI.BunifuFlatButton ResendBtn;
        private Bunifu.Framework.UI.BunifuFormFadeTransition bunifuFormFadeTransition1;
    }
}