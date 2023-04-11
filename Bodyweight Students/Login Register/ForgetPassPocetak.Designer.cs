namespace Bodyweight_Students
{
    partial class ForgetPassPocetak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPassPocetak));
            this.backBtn = new Bunifu.UI.WinForms.BunifuImageButton();
            this.errorLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.SignUpLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.subBtn = new System.Windows.Forms.Button();
            this.email_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.opisLbl = new Bunifu.UI.WinForms.BunifuLabel();
            this.naslov = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuFormFadeTransition1 = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SuspendLayout();
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
            this.backBtn.ImageSize = new System.Drawing.Size(24, 26);
            this.backBtn.ImageZoomSize = new System.Drawing.Size(64, 66);
            this.backBtn.InitialImage = ((System.Drawing.Image)(resources.GetObject("backBtn.InitialImage")));
            this.backBtn.Location = new System.Drawing.Point(-6, 6);
            this.backBtn.Name = "backBtn";
            this.backBtn.Rotation = 180;
            this.backBtn.ShowActiveImage = true;
            this.backBtn.ShowCursorChanges = true;
            this.backBtn.ShowImageBorders = true;
            this.backBtn.ShowSizeMarkers = true;
            this.backBtn.Size = new System.Drawing.Size(64, 66);
            this.backBtn.TabIndex = 34;
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
            this.errorLabel.Location = new System.Drawing.Point(32, 311);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.errorLabel.Size = new System.Drawing.Size(307, 45);
            this.errorLabel.TabIndex = 33;
            this.errorLabel.Text = "Error Code";
            this.errorLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // SignUpLbl
            // 
            this.SignUpLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpLbl.ForeColor = System.Drawing.Color.White;
            this.SignUpLbl.Location = new System.Drawing.Point(232, 270);
            this.SignUpLbl.Name = "SignUpLbl";
            this.SignUpLbl.Size = new System.Drawing.Size(122, 24);
            this.SignUpLbl.TabIndex = 31;
            this.SignUpLbl.Text = "Registrujte se";
            this.SignUpLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(3, 270);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(242, 24);
            this.bunifuCustomLabel4.TabIndex = 32;
            this.bunifuCustomLabel4.Text = "Niste registrovani?";
            this.bunifuCustomLabel4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // subBtn
            // 
            this.subBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.subBtn.FlatAppearance.BorderSize = 0;
            this.subBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subBtn.ForeColor = System.Drawing.Color.White;
            this.subBtn.Location = new System.Drawing.Point(90, 203);
            this.subBtn.Name = "subBtn";
            this.subBtn.Size = new System.Drawing.Size(167, 55);
            this.subBtn.TabIndex = 30;
            this.subBtn.Text = "Nova lozinka";
            this.subBtn.UseVisualStyleBackColor = false;
            this.subBtn.Click += new System.EventHandler(this.subBtn_Click);
            // 
            // email_txt
            // 
            this.email_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.email_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.email_txt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.email_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email_txt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_txt.ForeColor = System.Drawing.Color.White;
            this.email_txt.HintForeColor = System.Drawing.Color.Empty;
            this.email_txt.HintText = "";
            this.email_txt.isPassword = false;
            this.email_txt.LineFocusedColor = System.Drawing.Color.White;
            this.email_txt.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(85)))), ((int)(((byte)(123)))));
            this.email_txt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(85)))), ((int)(((byte)(123)))));
            this.email_txt.LineThickness = 4;
            this.email_txt.Location = new System.Drawing.Point(32, 137);
            this.email_txt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.email_txt.MaxLength = 32767;
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(307, 45);
            this.email_txt.TabIndex = 29;
            this.email_txt.Text = "Email";
            this.email_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.email_txt.Leave += new System.EventHandler(this.email_txt_Leave);
            // 
            // opisLbl
            // 
            this.opisLbl.AutoEllipsis = false;
            this.opisLbl.AutoSize = false;
            this.opisLbl.CursorType = null;
            this.opisLbl.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.opisLbl.ForeColor = System.Drawing.Color.White;
            this.opisLbl.Location = new System.Drawing.Point(32, 78);
            this.opisLbl.Name = "opisLbl";
            this.opisLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.opisLbl.Size = new System.Drawing.Size(307, 51);
            this.opisLbl.TabIndex = 28;
            this.opisLbl.Text = "Unesite email na koji ćemo vam poslati verifikacioni kod ";
            this.opisLbl.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // naslov
            // 
            this.naslov.AutoEllipsis = false;
            this.naslov.CursorType = null;
            this.naslov.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.naslov.ForeColor = System.Drawing.Color.White;
            this.naslov.Location = new System.Drawing.Point(57, 22);
            this.naslov.Name = "naslov";
            this.naslov.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.naslov.Size = new System.Drawing.Size(207, 25);
            this.naslov.TabIndex = 27;
            this.naslov.Text = "Zaboravili ste lozinku?";
            this.naslov.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // bunifuFormFadeTransition1
            // 
            this.bunifuFormFadeTransition1.Delay = 1;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // ForgetPassPocetak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(387, 380);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.SignUpLbl);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.subBtn);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.opisLbl);
            this.Controls.Add(this.naslov);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgetPassPocetak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgetPassPocetak";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuImageButton backBtn;
        private Bunifu.UI.WinForms.BunifuLabel errorLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel SignUpLbl;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.Button subBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox email_txt;
        private Bunifu.UI.WinForms.BunifuLabel opisLbl;
        private Bunifu.UI.WinForms.BunifuLabel naslov;
        private Bunifu.Framework.UI.BunifuFormFadeTransition bunifuFormFadeTransition1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}