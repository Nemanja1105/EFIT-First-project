namespace Bodyweight_Students
{
    partial class VjezbaPrikaz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VjezbaPrikaz));
            this.opisLbl = new System.Windows.Forms.Label();
            this.vjeLbl1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.SuspendLayout();
            // 
            // opisLbl
            // 
            this.opisLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opisLbl.ForeColor = System.Drawing.Color.White;
            this.opisLbl.Location = new System.Drawing.Point(158, 577);
            this.opisLbl.Name = "opisLbl";
            this.opisLbl.Size = new System.Drawing.Size(680, 118);
            this.opisLbl.TabIndex = 13;
            this.opisLbl.Text = resources.GetString("opisLbl.Text");
            // 
            // vjeLbl1
            // 
            this.vjeLbl1.AutoSize = true;
            this.vjeLbl1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vjeLbl1.ForeColor = System.Drawing.Color.White;
            this.vjeLbl1.Location = new System.Drawing.Point(107, 577);
            this.vjeLbl1.Name = "vjeLbl1";
            this.vjeLbl1.Size = new System.Drawing.Size(55, 22);
            this.vjeLbl1.TabIndex = 11;
            this.vjeLbl1.Text = "Opis:";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 574);
            this.panel1.TabIndex = 10;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlayerDialog_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PlayerDialog_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PlayerDialog_MouseUp);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveImage = null;
            this.bunifuImageButton1.AllowAnimations = true;
            this.bunifuImageButton1.AllowZooming = true;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.FadeWhenInactive = false;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.Image = global::Bodyweight_Students.Properties.Resources.arrow;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 10;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(78, 79);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(88, 89);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(0, 615);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 270;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = true;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(88, 89);
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.ZoomSpeed = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // VjezbaPrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1021, 700);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.opisLbl);
            this.Controls.Add(this.vjeLbl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VjezbaPrikaz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VjezbaPrikaz";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlayerDialog_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PlayerDialog_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PlayerDialog_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label opisLbl;
        private System.Windows.Forms.Label vjeLbl1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
    }
}