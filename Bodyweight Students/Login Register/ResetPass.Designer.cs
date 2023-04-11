namespace Bodyweight_Students
{
    partial class ResetPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPass));
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation2 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            this.nazivLbl = new Bunifu.UI.WinForms.BunifuLabel();
            this.backBtn = new Bunifu.UI.WinForms.BunifuImageButton();
            this.opisLbl = new Bunifu.UI.WinForms.BunifuLabel();
            this.prvaTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.drugaTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.subBtn = new System.Windows.Forms.Button();
            this.errorLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuTransition1 = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.SuspendLayout();
            // 
            // nazivLbl
            // 
            this.nazivLbl.AutoEllipsis = false;
            this.nazivLbl.AutoSize = false;
            this.nazivLbl.CursorType = null;
            this.bunifuTransition1.SetDecoration(this.nazivLbl, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.nazivLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.nazivLbl.ForeColor = System.Drawing.Color.White;
            this.nazivLbl.Location = new System.Drawing.Point(84, -5);
            this.nazivLbl.Name = "nazivLbl";
            this.nazivLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nazivLbl.Size = new System.Drawing.Size(199, 78);
            this.nazivLbl.TabIndex = 13;
            this.nazivLbl.Text = "Resetujte  lozinku";
            this.nazivLbl.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // backBtn
            // 
            this.backBtn.ActiveImage = null;
            this.backBtn.AllowAnimations = true;
            this.backBtn.AllowZooming = true;
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.backBtn, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
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
            this.backBtn.Location = new System.Drawing.Point(0, -5);
            this.backBtn.Name = "backBtn";
            this.backBtn.Rotation = 180;
            this.backBtn.ShowActiveImage = true;
            this.backBtn.ShowCursorChanges = true;
            this.backBtn.ShowImageBorders = true;
            this.backBtn.ShowSizeMarkers = true;
            this.backBtn.Size = new System.Drawing.Size(78, 76);
            this.backBtn.TabIndex = 18;
            this.backBtn.ToolTipText = "";
            this.backBtn.WaitOnLoad = false;
            this.backBtn.Zoom = 40;
            this.backBtn.ZoomSpeed = 10;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // opisLbl
            // 
            this.opisLbl.AutoEllipsis = false;
            this.opisLbl.AutoSize = false;
            this.opisLbl.CursorType = null;
            this.opisLbl.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.opisLbl.ForeColor = System.Drawing.Color.White;
            this.opisLbl.Location = new System.Drawing.Point(25, 91);
            this.opisLbl.Name = "opisLbl";
            this.opisLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.opisLbl.Size = new System.Drawing.Size(320, 52);
            this.opisLbl.TabIndex = 19;
            this.opisLbl.Text = "Molim vas unesite novu lozinku";
            this.opisLbl.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // prvaTxt
            // 
            this.prvaTxt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(85)))), ((int)(((byte)(123)))));
            this.prvaTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(85)))), ((int)(((byte)(123)))));
            this.prvaTxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(85)))), ((int)(((byte)(123)))));
            this.prvaTxt.BorderThickness = 3;
            this.prvaTxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.prvaTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prvaTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.prvaTxt.ForeColor = System.Drawing.Color.White;
            this.prvaTxt.isPassword = false;
            this.prvaTxt.Location = new System.Drawing.Point(25, 138);
            this.prvaTxt.Margin = new System.Windows.Forms.Padding(4);
            this.prvaTxt.MaxLength = 32767;
            this.prvaTxt.Name = "prvaTxt";
            this.prvaTxt.Size = new System.Drawing.Size(318, 44);
            this.prvaTxt.TabIndex = 20;
            this.prvaTxt.Text = "Password";
            this.prvaTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // drugaTxt
            // 
            this.drugaTxt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(85)))), ((int)(((byte)(123)))));
            this.drugaTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(85)))), ((int)(((byte)(123)))));
            this.drugaTxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(85)))), ((int)(((byte)(123)))));
            this.drugaTxt.BorderThickness = 3;
            this.drugaTxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.drugaTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.drugaTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.drugaTxt.ForeColor = System.Drawing.Color.White;
            this.drugaTxt.isPassword = false;
            this.drugaTxt.Location = new System.Drawing.Point(25, 200);
            this.drugaTxt.Margin = new System.Windows.Forms.Padding(4);
            this.drugaTxt.MaxLength = 32767;
            this.drugaTxt.Name = "drugaTxt";
            this.drugaTxt.Size = new System.Drawing.Size(318, 44);
            this.drugaTxt.TabIndex = 20;
            this.drugaTxt.Text = "Potvrdi password";
            this.drugaTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // subBtn
            // 
            this.subBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.subBtn.FlatAppearance.BorderSize = 0;
            this.subBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subBtn.ForeColor = System.Drawing.Color.White;
            this.subBtn.Location = new System.Drawing.Point(98, 251);
            this.subBtn.Name = "subBtn";
            this.subBtn.Size = new System.Drawing.Size(131, 55);
            this.subBtn.TabIndex = 21;
            this.subBtn.Text = "Potvrdi";
            this.subBtn.UseVisualStyleBackColor = false;
            this.subBtn.Click += new System.EventHandler(this.subBtn_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoEllipsis = false;
            this.errorLabel.AutoSize = false;
            this.errorLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.errorLabel.CursorType = null;
            this.errorLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.White;
            this.errorLabel.Location = new System.Drawing.Point(25, 321);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.errorLabel.Size = new System.Drawing.Size(317, 52);
            this.errorLabel.TabIndex = 22;
            this.errorLabel.Text = "Error Code";
            this.errorLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation2;
            // 
            // ResetPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(376, 397);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.subBtn);
            this.Controls.Add(this.drugaTxt);
            this.Controls.Add(this.prvaTxt);
            this.Controls.Add(this.opisLbl);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.nazivLbl);
            this.bunifuTransition1.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResetPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResetPass";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel nazivLbl;
        private Bunifu.UI.WinForms.BunifuImageButton backBtn;
        private Bunifu.UI.WinForms.BunifuLabel opisLbl;
        private Bunifu.Framework.UI.BunifuMetroTextbox prvaTxt;
        private Bunifu.Framework.UI.BunifuMetroTextbox drugaTxt;
        private System.Windows.Forms.Button subBtn;
        private Bunifu.UI.WinForms.BunifuLabel errorLabel;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuTransition bunifuTransition1;
    }
}