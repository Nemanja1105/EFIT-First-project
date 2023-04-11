namespace AdminSide
{
    partial class DodajVjezbu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajVjezbu));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tezinaCombo = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label5 = new System.Windows.Forms.Label();
            this.tipCombo = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label6 = new System.Windows.Forms.Label();
            this.dioCombo = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label7 = new System.Windows.Forms.Label();
            this.cancelBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.dodajBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.nazivTxt = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.linkTxt = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.opisTxt = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(103)))), ((int)(((byte)(135)))));
            this.label1.Location = new System.Drawing.Point(93, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dodaj Vjezbu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(103)))), ((int)(((byte)(135)))));
            this.label2.Location = new System.Drawing.Point(27, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Naziv:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(103)))), ((int)(((byte)(135)))));
            this.label3.Location = new System.Drawing.Point(27, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "YouTube Link:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(103)))), ((int)(((byte)(135)))));
            this.label4.Location = new System.Drawing.Point(202, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tezina vjezbe:";
            // 
            // tezinaCombo
            // 
            this.tezinaCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tezinaCombo.BorderRadius = 3;
            this.tezinaCombo.Color = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(103)))), ((int)(((byte)(135)))));
            this.tezinaCombo.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.tezinaCombo.DisabledColor = System.Drawing.Color.Gray;
            this.tezinaCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.tezinaCombo.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.tezinaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tezinaCombo.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.tezinaCombo.FillDropDown = false;
            this.tezinaCombo.FillIndicator = false;
            this.tezinaCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tezinaCombo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tezinaCombo.ForeColor = System.Drawing.Color.DimGray;
            this.tezinaCombo.FormattingEnabled = true;
            this.tezinaCombo.Icon = null;
            this.tezinaCombo.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(103)))), ((int)(((byte)(135)))));
            this.tezinaCombo.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.tezinaCombo.ItemBackColor = System.Drawing.Color.White;
            this.tezinaCombo.ItemBorderColor = System.Drawing.Color.DimGray;
            this.tezinaCombo.ItemForeColor = System.Drawing.Color.DimGray;
            this.tezinaCombo.ItemHeight = 36;
            this.tezinaCombo.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tezinaCombo.Items.AddRange(new object[] {
            "Pocetni",
            "Srednji",
            "Napredni"});
            this.tezinaCombo.Location = new System.Drawing.Point(206, 87);
            this.tezinaCombo.Name = "tezinaCombo";
            this.tezinaCombo.Size = new System.Drawing.Size(144, 42);
            this.tezinaCombo.TabIndex = 19;
            this.tezinaCombo.Text = "Izabrati";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(103)))), ((int)(((byte)(135)))));
            this.label5.Location = new System.Drawing.Point(27, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tip vjezbe:";
            // 
            // tipCombo
            // 
            this.tipCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tipCombo.BorderRadius = 3;
            this.tipCombo.Color = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(103)))), ((int)(((byte)(135)))));
            this.tipCombo.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.tipCombo.DisabledColor = System.Drawing.Color.Gray;
            this.tipCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.tipCombo.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.tipCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipCombo.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.tipCombo.FillDropDown = false;
            this.tipCombo.FillIndicator = false;
            this.tipCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tipCombo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipCombo.ForeColor = System.Drawing.Color.DimGray;
            this.tipCombo.FormattingEnabled = true;
            this.tipCombo.Icon = null;
            this.tipCombo.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(103)))), ((int)(((byte)(135)))));
            this.tipCombo.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.tipCombo.ItemBackColor = System.Drawing.Color.White;
            this.tipCombo.ItemBorderColor = System.Drawing.Color.DimGray;
            this.tipCombo.ItemForeColor = System.Drawing.Color.DimGray;
            this.tipCombo.ItemHeight = 36;
            this.tipCombo.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tipCombo.Items.AddRange(new object[] {
            "Pocetni",
            "Srednji",
            "Napredni"});
            this.tipCombo.Location = new System.Drawing.Point(31, 158);
            this.tipCombo.Name = "tipCombo";
            this.tipCombo.Size = new System.Drawing.Size(144, 42);
            this.tipCombo.TabIndex = 19;
            this.tipCombo.Text = "Izabrati";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(103)))), ((int)(((byte)(135)))));
            this.label6.Location = new System.Drawing.Point(202, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Dio tijela:";
            // 
            // dioCombo
            // 
            this.dioCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.dioCombo.BorderRadius = 3;
            this.dioCombo.Color = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(103)))), ((int)(((byte)(135)))));
            this.dioCombo.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.dioCombo.DisabledColor = System.Drawing.Color.Gray;
            this.dioCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dioCombo.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.dioCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dioCombo.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.dioCombo.FillDropDown = false;
            this.dioCombo.FillIndicator = false;
            this.dioCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dioCombo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dioCombo.ForeColor = System.Drawing.Color.DimGray;
            this.dioCombo.FormattingEnabled = true;
            this.dioCombo.Icon = null;
            this.dioCombo.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(103)))), ((int)(((byte)(135)))));
            this.dioCombo.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.dioCombo.ItemBackColor = System.Drawing.Color.White;
            this.dioCombo.ItemBorderColor = System.Drawing.Color.DimGray;
            this.dioCombo.ItemForeColor = System.Drawing.Color.DimGray;
            this.dioCombo.ItemHeight = 36;
            this.dioCombo.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dioCombo.Items.AddRange(new object[] {
            "Pocetni",
            "Srednji",
            "Napredni"});
            this.dioCombo.Location = new System.Drawing.Point(206, 158);
            this.dioCombo.Name = "dioCombo";
            this.dioCombo.Size = new System.Drawing.Size(144, 42);
            this.dioCombo.TabIndex = 19;
            this.dioCombo.Text = "Izabrati";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(103)))), ((int)(((byte)(135)))));
            this.label7.Location = new System.Drawing.Point(27, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Opis:";
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelBtn.BackgroundImage")));
            this.cancelBtn.ButtonText = "Otkazi";
            this.cancelBtn.ButtonTextMarginLeft = 0;
            this.cancelBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.cancelBtn.DisabledFillColor = System.Drawing.Color.Gray;
            this.cancelBtn.DisabledForecolor = System.Drawing.Color.White;
            this.cancelBtn.ForeColor = System.Drawing.Color.DimGray;
            this.cancelBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.cancelBtn.IconPadding = 10;
            this.cancelBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.cancelBtn.IdleBorderColor = System.Drawing.Color.DimGray;
            this.cancelBtn.IdleBorderRadius = 1;
            this.cancelBtn.IdleBorderThickness = 0;
            this.cancelBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.cancelBtn.IdleIconLeftImage = null;
            this.cancelBtn.IdleIconRightImage = null;
            this.cancelBtn.Location = new System.Drawing.Point(31, 386);
            this.cancelBtn.Name = "cancelBtn";
            stateProperties1.BorderColor = System.Drawing.Color.DimGray;
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.cancelBtn.onHoverState = stateProperties1;
            this.cancelBtn.Size = new System.Drawing.Size(145, 45);
            this.cancelBtn.TabIndex = 20;
            this.cancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // dodajBtn
            // 
            this.dodajBtn.BackColor = System.Drawing.Color.Transparent;
            this.dodajBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dodajBtn.BackgroundImage")));
            this.dodajBtn.ButtonText = "Dodaj";
            this.dodajBtn.ButtonTextMarginLeft = 0;
            this.dodajBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dodajBtn.DisabledFillColor = System.Drawing.Color.Gray;
            this.dodajBtn.DisabledForecolor = System.Drawing.Color.White;
            this.dodajBtn.ForeColor = System.Drawing.Color.White;
            this.dodajBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.dodajBtn.IconPadding = 10;
            this.dodajBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.dodajBtn.IdleBorderColor = System.Drawing.Color.DimGray;
            this.dodajBtn.IdleBorderRadius = 1;
            this.dodajBtn.IdleBorderThickness = 0;
            this.dodajBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(157)))), ((int)(((byte)(68)))));
            this.dodajBtn.IdleIconLeftImage = null;
            this.dodajBtn.IdleIconRightImage = null;
            this.dodajBtn.Location = new System.Drawing.Point(205, 386);
            this.dodajBtn.Name = "dodajBtn";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(157)))), ((int)(((byte)(68)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(157)))), ((int)(((byte)(68)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.dodajBtn.onHoverState = stateProperties2;
            this.dodajBtn.Size = new System.Drawing.Size(145, 45);
            this.dodajBtn.TabIndex = 21;
            this.dodajBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dodajBtn.Click += new System.EventHandler(this.dodajBtn_Click);
            // 
            // nazivTxt
            // 
            this.nazivTxt.AcceptsReturn = false;
            this.nazivTxt.AcceptsTab = false;
            this.nazivTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.nazivTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.nazivTxt.BackColor = System.Drawing.Color.Transparent;
            this.nazivTxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nazivTxt.BackgroundImage")));
            this.nazivTxt.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(103)))), ((int)(((byte)(135)))));
            this.nazivTxt.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.nazivTxt.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(103)))), ((int)(((byte)(135)))));
            this.nazivTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(103)))), ((int)(((byte)(135)))));
            this.nazivTxt.BorderRadius = 1;
            this.nazivTxt.BorderThickness = 2;
            this.nazivTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.nazivTxt.DefaultFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nazivTxt.DefaultText = "";
            this.nazivTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.nazivTxt.HideSelection = true;
            this.nazivTxt.IconLeft = null;
            this.nazivTxt.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.nazivTxt.IconPadding = 10;
            this.nazivTxt.IconRight = null;
            this.nazivTxt.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.nazivTxt.Location = new System.Drawing.Point(31, 87);
            this.nazivTxt.MaxLength = 32767;
            this.nazivTxt.MinimumSize = new System.Drawing.Size(100, 35);
            this.nazivTxt.Modified = false;
            this.nazivTxt.Name = "nazivTxt";
            this.nazivTxt.PasswordChar = '\0';
            this.nazivTxt.ReadOnly = false;
            this.nazivTxt.SelectedText = "";
            this.nazivTxt.SelectionLength = 0;
            this.nazivTxt.SelectionStart = 0;
            this.nazivTxt.ShortcutsEnabled = true;
            this.nazivTxt.Size = new System.Drawing.Size(144, 42);
            this.nazivTxt.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.nazivTxt.TabIndex = 22;
            this.nazivTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nazivTxt.TextMarginLeft = 5;
            this.nazivTxt.TextPlaceholder = "Unesite naziv";
            this.nazivTxt.UseSystemPasswordChar = false;
            // 
            // linkTxt
            // 
            this.linkTxt.AcceptsReturn = false;
            this.linkTxt.AcceptsTab = false;
            this.linkTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.linkTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.linkTxt.BackColor = System.Drawing.Color.Transparent;
            this.linkTxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("linkTxt.BackgroundImage")));
            this.linkTxt.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(103)))), ((int)(((byte)(135)))));
            this.linkTxt.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.linkTxt.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(103)))), ((int)(((byte)(135)))));
            this.linkTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(103)))), ((int)(((byte)(135)))));
            this.linkTxt.BorderRadius = 1;
            this.linkTxt.BorderThickness = 2;
            this.linkTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.linkTxt.DefaultFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkTxt.DefaultText = "";
            this.linkTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.linkTxt.HideSelection = true;
            this.linkTxt.IconLeft = null;
            this.linkTxt.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.linkTxt.IconPadding = 10;
            this.linkTxt.IconRight = null;
            this.linkTxt.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.linkTxt.Location = new System.Drawing.Point(32, 229);
            this.linkTxt.MaxLength = 32767;
            this.linkTxt.MinimumSize = new System.Drawing.Size(100, 35);
            this.linkTxt.Modified = false;
            this.linkTxt.Name = "linkTxt";
            this.linkTxt.PasswordChar = '\0';
            this.linkTxt.ReadOnly = false;
            this.linkTxt.SelectedText = "";
            this.linkTxt.SelectionLength = 0;
            this.linkTxt.SelectionStart = 0;
            this.linkTxt.ShortcutsEnabled = true;
            this.linkTxt.Size = new System.Drawing.Size(318, 42);
            this.linkTxt.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.linkTxt.TabIndex = 22;
            this.linkTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.linkTxt.TextMarginLeft = 5;
            this.linkTxt.TextPlaceholder = "Unesite link";
            this.linkTxt.UseSystemPasswordChar = false;
            // 
            // opisTxt
            // 
            this.opisTxt.AcceptsReturn = false;
            this.opisTxt.AcceptsTab = false;
            this.opisTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.opisTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.opisTxt.BackColor = System.Drawing.Color.Transparent;
            this.opisTxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("opisTxt.BackgroundImage")));
            this.opisTxt.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(103)))), ((int)(((byte)(135)))));
            this.opisTxt.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.opisTxt.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(103)))), ((int)(((byte)(135)))));
            this.opisTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(103)))), ((int)(((byte)(135)))));
            this.opisTxt.BorderRadius = 1;
            this.opisTxt.BorderThickness = 2;
            this.opisTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.opisTxt.DefaultFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opisTxt.DefaultText = "";
            this.opisTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.opisTxt.HideSelection = true;
            this.opisTxt.IconLeft = null;
            this.opisTxt.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.opisTxt.IconPadding = 10;
            this.opisTxt.IconRight = null;
            this.opisTxt.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.opisTxt.Location = new System.Drawing.Point(31, 296);
            this.opisTxt.MaxLength = 32767;
            this.opisTxt.MinimumSize = new System.Drawing.Size(100, 35);
            this.opisTxt.Modified = false;
            this.opisTxt.Name = "opisTxt";
            this.opisTxt.PasswordChar = '\0';
            this.opisTxt.ReadOnly = false;
            this.opisTxt.SelectedText = "";
            this.opisTxt.SelectionLength = 0;
            this.opisTxt.SelectionStart = 0;
            this.opisTxt.ShortcutsEnabled = true;
            this.opisTxt.Size = new System.Drawing.Size(318, 65);
            this.opisTxt.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.opisTxt.TabIndex = 22;
            this.opisTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.opisTxt.TextMarginLeft = 5;
            this.opisTxt.TextPlaceholder = "Unesite opis";
            this.opisTxt.UseSystemPasswordChar = false;
            // 
            // DodajVjezbu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(395, 468);
            this.Controls.Add(this.opisTxt);
            this.Controls.Add(this.linkTxt);
            this.Controls.Add(this.nazivTxt);
            this.Controls.Add(this.dodajBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.dioCombo);
            this.Controls.Add(this.tipCombo);
            this.Controls.Add(this.tezinaCombo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DodajVjezbu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DodajVjezbu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.UI.WinForms.BunifuDropdown tezinaCombo;
        private System.Windows.Forms.Label label5;
        private Bunifu.UI.WinForms.BunifuDropdown tipCombo;
        private System.Windows.Forms.Label label6;
        private Bunifu.UI.WinForms.BunifuDropdown dioCombo;
        private System.Windows.Forms.Label label7;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton cancelBtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton dodajBtn;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox nazivTxt;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox linkTxt;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox opisTxt;
    }
}