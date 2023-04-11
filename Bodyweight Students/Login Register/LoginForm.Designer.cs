namespace Bodyweight_Students
{
    public partial class LoginForm
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
            this.email_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.password_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.rem_checkBox = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.remLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.signInBtn = new System.Windows.Forms.Button();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.errorLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ResendBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.regBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // email_txt
            // 
            this.email_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.email_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.email_txt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.email_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.email_txt.ForeColor = System.Drawing.Color.White;
            this.email_txt.HintForeColor = System.Drawing.Color.Empty;
            this.email_txt.HintText = "ee";
            this.email_txt.isPassword = false;
            this.email_txt.LineFocusedColor = System.Drawing.Color.White;
            this.email_txt.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(85)))), ((int)(((byte)(123)))));
            this.email_txt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(85)))), ((int)(((byte)(123)))));
            this.email_txt.LineThickness = 3;
            this.email_txt.Location = new System.Drawing.Point(41, 184);
            this.email_txt.Margin = new System.Windows.Forms.Padding(4);
            this.email_txt.MaxLength = 32767;
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(343, 32);
            this.email_txt.TabIndex = 1;
            this.email_txt.Text = "Email";
            this.email_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.email_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.email_txt_KeyDown);
            this.email_txt.Leave += new System.EventHandler(this.email_txt_Leave);
            // 
            // password_txt
            // 
            this.password_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.password_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.password_txt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.password_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.password_txt.ForeColor = System.Drawing.Color.White;
            this.password_txt.HintForeColor = System.Drawing.Color.Empty;
            this.password_txt.HintText = "";
            this.password_txt.isPassword = true;
            this.password_txt.LineFocusedColor = System.Drawing.Color.White;
            this.password_txt.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(85)))), ((int)(((byte)(123)))));
            this.password_txt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(85)))), ((int)(((byte)(123)))));
            this.password_txt.LineThickness = 3;
            this.password_txt.Location = new System.Drawing.Point(41, 249);
            this.password_txt.Margin = new System.Windows.Forms.Padding(4);
            this.password_txt.MaxLength = 32767;
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(343, 32);
            this.password_txt.TabIndex = 2;
            this.password_txt.Text = "Password";
            this.password_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.password_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.email_txt_KeyDown);
            this.password_txt.Leave += new System.EventHandler(this.password_txt_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 249);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(5, 184);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(60, 75);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(240, 50);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Dobrodošli";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rem_checkBox
            // 
            this.rem_checkBox.AllowBindingControlAnimation = true;
            this.rem_checkBox.AllowBindingControlLocation = true;
            this.rem_checkBox.AllowCheckBoxAnimation = true;
            this.rem_checkBox.AllowCheckmarkAnimation = true;
            this.rem_checkBox.AllowOnHoverStates = true;
            this.rem_checkBox.BackColor = System.Drawing.Color.Transparent;
            this.rem_checkBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rem_checkBox.BackgroundImage")));
            this.rem_checkBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rem_checkBox.BindingControl = null;
            this.rem_checkBox.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.rem_checkBox.Checked = true;
            this.rem_checkBox.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.rem_checkBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rem_checkBox.CustomCheckmarkImage = null;
            this.rem_checkBox.Location = new System.Drawing.Point(12, 312);
            this.rem_checkBox.MinimumSize = new System.Drawing.Size(17, 17);
            this.rem_checkBox.Name = "rem_checkBox";
            this.rem_checkBox.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.rem_checkBox.OnCheck.BorderRadius = 2;
            this.rem_checkBox.OnCheck.BorderThickness = 2;
            this.rem_checkBox.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.rem_checkBox.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.rem_checkBox.OnCheck.CheckmarkThickness = 2;
            this.rem_checkBox.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.rem_checkBox.OnDisable.BorderRadius = 2;
            this.rem_checkBox.OnDisable.BorderThickness = 2;
            this.rem_checkBox.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.rem_checkBox.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.rem_checkBox.OnDisable.CheckmarkThickness = 2;
            this.rem_checkBox.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.rem_checkBox.OnHoverChecked.BorderRadius = 2;
            this.rem_checkBox.OnHoverChecked.BorderThickness = 2;
            this.rem_checkBox.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.rem_checkBox.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.rem_checkBox.OnHoverChecked.CheckmarkThickness = 2;
            this.rem_checkBox.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.rem_checkBox.OnHoverUnchecked.BorderRadius = 2;
            this.rem_checkBox.OnHoverUnchecked.BorderThickness = 2;
            this.rem_checkBox.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.rem_checkBox.OnUncheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.rem_checkBox.OnUncheck.BorderRadius = 2;
            this.rem_checkBox.OnUncheck.BorderThickness = 2;
            this.rem_checkBox.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.rem_checkBox.Size = new System.Drawing.Size(21, 21);
            this.rem_checkBox.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.rem_checkBox.TabIndex = 5;
            this.rem_checkBox.ThreeState = false;
            this.rem_checkBox.ToolTipText = "remeber";
            this.rem_checkBox.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.rem_checkBox_CheckedChanged);
            // 
            // remLabel
            // 
            this.remLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remLabel.ForeColor = System.Drawing.Color.White;
            this.remLabel.Location = new System.Drawing.Point(37, 312);
            this.remLabel.Name = "remLabel";
            this.remLabel.Size = new System.Drawing.Size(146, 21);
            this.remLabel.TabIndex = 4;
            this.remLabel.Text = "Zapamti lozinku";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(352, 2);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(45, 41);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 6;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // signInBtn
            // 
            this.signInBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.signInBtn.FlatAppearance.BorderSize = 0;
            this.signInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signInBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInBtn.ForeColor = System.Drawing.Color.White;
            this.signInBtn.Location = new System.Drawing.Point(117, 369);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(166, 44);
            this.signInBtn.TabIndex = 7;
            this.signInBtn.Text = "Prijavi se";
            this.signInBtn.UseVisualStyleBackColor = false;
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(8, 445);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(242, 24);
            this.bunifuCustomLabel4.TabIndex = 4;
            this.bunifuCustomLabel4.Text = "Niste registrovani?";
            this.bunifuCustomLabel4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoEllipsis = false;
            this.errorLabel.AutoSize = false;
            this.errorLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.errorLabel.CursorType = null;
            this.errorLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.errorLabel.ForeColor = System.Drawing.Color.White;
            this.errorLabel.Location = new System.Drawing.Point(25, 496);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.errorLabel.Size = new System.Drawing.Size(344, 46);
            this.errorLabel.TabIndex = 8;
            this.errorLabel.Text = "errorLabel";
            this.errorLabel.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // ResendBtn
            // 
            this.ResendBtn.Active = false;
            this.ResendBtn.Activecolor = System.Drawing.Color.Transparent;
            this.ResendBtn.BackColor = System.Drawing.Color.Transparent;
            this.ResendBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ResendBtn.BorderRadius = 0;
            this.ResendBtn.ButtonText = "Zaboravili ste lozinku?";
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
            this.ResendBtn.Location = new System.Drawing.Point(167, 295);
            this.ResendBtn.Name = "ResendBtn";
            this.ResendBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.ResendBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.ResendBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.ResendBtn.selected = false;
            this.ResendBtn.Size = new System.Drawing.Size(217, 38);
            this.ResendBtn.TabIndex = 12;
            this.ResendBtn.Text = "Zaboravili ste lozinku?";
            this.ResendBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ResendBtn.Textcolor = System.Drawing.Color.White;
            this.ResendBtn.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResendBtn.Click += new System.EventHandler(this.ResendBtn_Click);
            // 
            // regBtn
            // 
            this.regBtn.Active = false;
            this.regBtn.Activecolor = System.Drawing.Color.Transparent;
            this.regBtn.BackColor = System.Drawing.Color.Transparent;
            this.regBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.regBtn.BorderRadius = 0;
            this.regBtn.ButtonText = "Registruj se";
            this.regBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regBtn.DisabledColor = System.Drawing.Color.Gray;
            this.regBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.regBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("regBtn.Iconimage")));
            this.regBtn.Iconimage_right = null;
            this.regBtn.Iconimage_right_Selected = null;
            this.regBtn.Iconimage_Selected = null;
            this.regBtn.IconMarginLeft = 0;
            this.regBtn.IconMarginRight = 0;
            this.regBtn.IconRightVisible = true;
            this.regBtn.IconRightZoom = 0D;
            this.regBtn.IconVisible = false;
            this.regBtn.IconZoom = 90D;
            this.regBtn.IsTab = false;
            this.regBtn.Location = new System.Drawing.Point(228, 431);
            this.regBtn.Name = "regBtn";
            this.regBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.regBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.regBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.regBtn.selected = false;
            this.regBtn.Size = new System.Drawing.Size(141, 38);
            this.regBtn.TabIndex = 12;
            this.regBtn.Text = "Registruj se";
            this.regBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.regBtn.Textcolor = System.Drawing.Color.White;
            this.regBtn.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(402, 563);
            this.Controls.Add(this.regBtn);
            this.Controls.Add(this.ResendBtn);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.signInBtn);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.rem_checkBox);
            this.Controls.Add(this.remLabel);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.email_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox email_txt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox password_txt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.UI.WinForms.BunifuCheckBox rem_checkBox;
        private Bunifu.Framework.UI.BunifuCustomLabel remLabel;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Button signInBtn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.UI.WinForms.BunifuLabel errorLabel;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton ResendBtn;
        private Bunifu.Framework.UI.BunifuFlatButton regBtn;
    }
}

