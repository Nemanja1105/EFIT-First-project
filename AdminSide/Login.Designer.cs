namespace AdminSide
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.prijavaBtn = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse();
            this.errorLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.user_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.passTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(53, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(240, 50);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Admin Login";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // prijavaBtn
            // 
            this.prijavaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.prijavaBtn.FlatAppearance.BorderSize = 0;
            this.prijavaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prijavaBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prijavaBtn.ForeColor = System.Drawing.Color.White;
            this.prijavaBtn.Location = new System.Drawing.Point(87, 153);
            this.prijavaBtn.Name = "prijavaBtn";
            this.prijavaBtn.Size = new System.Drawing.Size(166, 44);
            this.prijavaBtn.TabIndex = 8;
            this.prijavaBtn.Text = "Prijavi se";
            this.prijavaBtn.UseVisualStyleBackColor = false;
            this.prijavaBtn.Click += new System.EventHandler(this.prijavaBtn_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoEllipsis = false;
            this.errorLabel.AutoSize = false;
            this.errorLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.errorLabel.CursorType = null;
            this.errorLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.errorLabel.ForeColor = System.Drawing.Color.White;
            this.errorLabel.Location = new System.Drawing.Point(5, 203);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.errorLabel.Size = new System.Drawing.Size(340, 41);
            this.errorLabel.TabIndex = 0;
            this.errorLabel.Text = "errorLabel";
            this.errorLabel.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // user_txt
            // 
            this.user_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.user_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.user_txt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.user_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.user_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_txt.ForeColor = System.Drawing.Color.White;
            this.user_txt.HintForeColor = System.Drawing.Color.Empty;
            this.user_txt.HintText = "";
            this.user_txt.isPassword = false;
            this.user_txt.LineFocusedColor = System.Drawing.Color.White;
            this.user_txt.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(85)))), ((int)(((byte)(123)))));
            this.user_txt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(85)))), ((int)(((byte)(123)))));
            this.user_txt.LineThickness = 3;
            this.user_txt.Location = new System.Drawing.Point(51, 63);
            this.user_txt.Margin = new System.Windows.Forms.Padding(4);
            this.user_txt.MaxLength = 32767;
            this.user_txt.Name = "user_txt";
            this.user_txt.Size = new System.Drawing.Size(289, 33);
            this.user_txt.TabIndex = 1;
            this.user_txt.Text = "Username";
            this.user_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.user_txt.Enter += new System.EventHandler(this.user_txt_Enter);
            this.user_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.email_txt_KeyDown);
            this.user_txt.Leave += new System.EventHandler(this.user_txt_Leave);
            // 
            // passTxt
            // 
            this.passTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.passTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.passTxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.passTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTxt.ForeColor = System.Drawing.Color.White;
            this.passTxt.HintForeColor = System.Drawing.Color.Empty;
            this.passTxt.HintText = "";
            this.passTxt.isPassword = true;
            this.passTxt.LineFocusedColor = System.Drawing.Color.White;
            this.passTxt.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(85)))), ((int)(((byte)(123)))));
            this.passTxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(85)))), ((int)(((byte)(123)))));
            this.passTxt.LineThickness = 3;
            this.passTxt.Location = new System.Drawing.Point(51, 104);
            this.passTxt.Margin = new System.Windows.Forms.Padding(4);
            this.passTxt.MaxLength = 32767;
            this.passTxt.Name = "passTxt";
            this.passTxt.Size = new System.Drawing.Size(289, 33);
            this.passTxt.TabIndex = 2;
            this.passTxt.Text = "Password";
            this.passTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passTxt.Enter += new System.EventHandler(this.bunifuMaterialTextbox1_Enter);
            this.passTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.email_txt_KeyDown);
            this.passTxt.Leave += new System.EventHandler(this.passTxt_Leave);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(353, 262);
            this.Controls.Add(this.passTxt);
            this.Controls.Add(this.user_txt);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.prijavaBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button prijavaBtn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuLabel errorLabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox user_txt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passTxt;
    }
}

