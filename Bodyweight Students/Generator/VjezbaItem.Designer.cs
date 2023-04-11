namespace Bodyweight_Students
{
    partial class VjezbaItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VjezbaItem));
            this.indLbl = new System.Windows.Forms.Label();
            this.yt1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.nazLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nivLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.opisLbl = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SuspendLayout();
            // 
            // indLbl
            // 
            this.indLbl.AutoSize = true;
            this.indLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indLbl.ForeColor = System.Drawing.Color.White;
            this.indLbl.Location = new System.Drawing.Point(3, 3);
            this.indLbl.Name = "indLbl";
            this.indLbl.Size = new System.Drawing.Size(23, 21);
            this.indLbl.TabIndex = 0;
            this.indLbl.Text = "1.";
            // 
            // yt1
            // 
            this.yt1.ActiveImage = null;
            this.yt1.AllowAnimations = true;
            this.yt1.AllowZooming = true;
            this.yt1.BackColor = System.Drawing.Color.Transparent;
            this.yt1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("yt1.ErrorImage")));
            this.yt1.FadeWhenInactive = false;
            this.yt1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.yt1.Image = global::Bodyweight_Students.Resursi.film;
            this.yt1.ImageActive = null;
            this.yt1.ImageLocation = null;
            this.yt1.ImageMargin = 10;
            this.yt1.ImageSize = new System.Drawing.Size(49, 29);
            this.yt1.ImageZoomSize = new System.Drawing.Size(59, 39);
            this.yt1.InitialImage = ((System.Drawing.Image)(resources.GetObject("yt1.InitialImage")));
            this.yt1.Location = new System.Drawing.Point(635, 0);
            this.yt1.Name = "yt1";
            this.yt1.Rotation = 0;
            this.yt1.ShowActiveImage = true;
            this.yt1.ShowCursorChanges = true;
            this.yt1.ShowImageBorders = true;
            this.yt1.ShowSizeMarkers = true;
            this.yt1.Size = new System.Drawing.Size(59, 39);
            this.yt1.TabIndex = 3;
            this.yt1.ToolTipText = "";
            this.yt1.WaitOnLoad = false;
            this.yt1.Zoom = 10;
            this.yt1.ZoomSpeed = 10;
            this.yt1.Click += new System.EventHandler(this.yt1_Click);
            // 
            // nazLbl
            // 
            this.nazLbl.AutoSize = true;
            this.nazLbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nazLbl.ForeColor = System.Drawing.Color.White;
            this.nazLbl.Location = new System.Drawing.Point(46, 0);
            this.nazLbl.Name = "nazLbl";
            this.nazLbl.Size = new System.Drawing.Size(140, 24);
            this.nazLbl.TabIndex = 0;
            this.nazLbl.Text = "Naziv Vjezbe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(394, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tezina vjezbe:";
            // 
            // nivLbl
            // 
            this.nivLbl.AutoSize = true;
            this.nivLbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nivLbl.ForeColor = System.Drawing.Color.White;
            this.nivLbl.Location = new System.Drawing.Point(540, 3);
            this.nivLbl.Name = "nivLbl";
            this.nivLbl.Size = new System.Drawing.Size(56, 24);
            this.nivLbl.TabIndex = 0;
            this.nivLbl.Text = "Nivo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Opis:";
            // 
            // opisLbl
            // 
            this.opisLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opisLbl.ForeColor = System.Drawing.Color.White;
            this.opisLbl.Location = new System.Drawing.Point(3, 51);
            this.opisLbl.Name = "opisLbl";
            this.opisLbl.Size = new System.Drawing.Size(688, 115);
            this.opisLbl.TabIndex = 0;
            this.opisLbl.Text = resources.GetString("opisLbl.Text");
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // VjezbaItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.yt1);
            this.Controls.Add(this.nivLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.opisLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nazLbl);
            this.Controls.Add(this.indLbl);
            this.Name = "VjezbaItem";
            this.Size = new System.Drawing.Size(694, 167);
            this.Load += new System.EventHandler(this.VjezbaItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label indLbl;
        private Bunifu.UI.WinForms.BunifuImageButton yt1;
        private System.Windows.Forms.Label nazLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nivLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label opisLbl;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}
