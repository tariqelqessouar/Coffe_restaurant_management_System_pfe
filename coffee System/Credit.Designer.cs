namespace coffee_System
{
    partial class Credit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Credit));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.Servercombobox = new System.Windows.Forms.ComboBox();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.CreditDatagrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.iDcreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUSERWORKSERVERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUSERWORKCASHIERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datecreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montantcreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomUSERWORKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Afficherreglementbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Reglerbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Creditdate = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.CancelCreditFilterbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.CreditFilterbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Servercheckbox = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.Datecheckbox = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.home = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.PictureBox();
            this.dBTD_CoffeeManagement = new coffee_System.DBTD_CoffeeManagement();
            this.cREDIT_DGINFOTableAdapter = new coffee_System.DBTD_CoffeeManagementTableAdapters.CREDIT_DGINFOTableAdapter();
            this.coffeeManagement_dbDataSet = new coffee_System.CoffeeManagement_dbDataSet();
            this.cREDITDGINFOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CreditDatagrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTD_CoffeeManagement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeManagement_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cREDITDGINFOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.bunifuLabel3.Location = new System.Drawing.Point(824, 65);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(46, 23);
            this.bunifuLabel3.TabIndex = 21;
            this.bunifuLabel3.Text = "Serveur";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.Location = new System.Drawing.Point(520, 65);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(30, 23);
            this.bunifuLabel2.TabIndex = 19;
            this.bunifuLabel2.Text = "Date";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Servercombobox
            // 
            this.Servercombobox.FormattingEnabled = true;
            this.Servercombobox.Location = new System.Drawing.Point(877, 66);
            this.Servercombobox.Name = "Servercombobox";
            this.Servercombobox.Size = new System.Drawing.Size(148, 21);
            this.Servercombobox.TabIndex = 22;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel4.ForeColor = System.Drawing.Color.SlateBlue;
            this.bunifuLabel4.Location = new System.Drawing.Point(12, 107);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(102, 32);
            this.bunifuLabel4.TabIndex = 24;
            this.bunifuLabel4.Text = "Credit List :";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // CreditDatagrid
            // 
            this.CreditDatagrid.AllowCustomTheming = false;
            this.CreditDatagrid.AllowUserToAddRows = false;
            this.CreditDatagrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.CreditDatagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CreditDatagrid.AutoGenerateColumns = false;
            this.CreditDatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CreditDatagrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(235)))));
            this.CreditDatagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CreditDatagrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CreditDatagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CreditDatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CreditDatagrid.ColumnHeadersHeight = 40;
            this.CreditDatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDcreDataGridViewTextBoxColumn,
            this.idUSERWORKSERVERDataGridViewTextBoxColumn,
            this.idUSERWORKCASHIERDataGridViewTextBoxColumn,
            this.statutDataGridViewTextBoxColumn,
            this.datecreDataGridViewTextBoxColumn,
            this.montantcreDataGridViewTextBoxColumn,
            this.nomUSERWORKDataGridViewTextBoxColumn});
            this.CreditDatagrid.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.CreditDatagrid.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.CreditDatagrid.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.CreditDatagrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.CreditDatagrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.CreditDatagrid.CurrentTheme.BackColor = System.Drawing.Color.DarkSlateGray;
            this.CreditDatagrid.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.CreditDatagrid.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.CreditDatagrid.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.CreditDatagrid.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CreditDatagrid.CurrentTheme.Name = null;
            this.CreditDatagrid.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.CreditDatagrid.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.CreditDatagrid.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.CreditDatagrid.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.CreditDatagrid.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.CreditDatagrid.DataSource = this.cREDITDGINFOBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CreditDatagrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.CreditDatagrid.EnableHeadersVisualStyles = false;
            this.CreditDatagrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.CreditDatagrid.HeaderBackColor = System.Drawing.Color.DarkSlateGray;
            this.CreditDatagrid.HeaderBgColor = System.Drawing.Color.Empty;
            this.CreditDatagrid.HeaderForeColor = System.Drawing.Color.White;
            this.CreditDatagrid.Location = new System.Drawing.Point(45, 157);
            this.CreditDatagrid.Name = "CreditDatagrid";
            this.CreditDatagrid.ReadOnly = true;
            this.CreditDatagrid.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CreditDatagrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.CreditDatagrid.RowTemplate.Height = 40;
            this.CreditDatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CreditDatagrid.Size = new System.Drawing.Size(1253, 491);
            this.CreditDatagrid.TabIndex = 25;
            this.CreditDatagrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.DarkSlateGray;
            this.CreditDatagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CreditDatagrid_CellClick);
            this.CreditDatagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CreditDatagrid_CellContentClick);
            // 
            // iDcreDataGridViewTextBoxColumn
            // 
            this.iDcreDataGridViewTextBoxColumn.DataPropertyName = "ID_cre";
            this.iDcreDataGridViewTextBoxColumn.HeaderText = "ID_cre";
            this.iDcreDataGridViewTextBoxColumn.Name = "iDcreDataGridViewTextBoxColumn";
            this.iDcreDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDcreDataGridViewTextBoxColumn.Visible = false;
            // 
            // idUSERWORKSERVERDataGridViewTextBoxColumn
            // 
            this.idUSERWORKSERVERDataGridViewTextBoxColumn.DataPropertyName = "id_USER_WORK_SERVER";
            this.idUSERWORKSERVERDataGridViewTextBoxColumn.HeaderText = "id_USER_WORK_SERVER";
            this.idUSERWORKSERVERDataGridViewTextBoxColumn.Name = "idUSERWORKSERVERDataGridViewTextBoxColumn";
            this.idUSERWORKSERVERDataGridViewTextBoxColumn.ReadOnly = true;
            this.idUSERWORKSERVERDataGridViewTextBoxColumn.Visible = false;
            // 
            // idUSERWORKCASHIERDataGridViewTextBoxColumn
            // 
            this.idUSERWORKCASHIERDataGridViewTextBoxColumn.DataPropertyName = "id_USER_WORK_CASHIER";
            this.idUSERWORKCASHIERDataGridViewTextBoxColumn.HeaderText = "id_USER_WORK_CASHIER";
            this.idUSERWORKCASHIERDataGridViewTextBoxColumn.Name = "idUSERWORKCASHIERDataGridViewTextBoxColumn";
            this.idUSERWORKCASHIERDataGridViewTextBoxColumn.ReadOnly = true;
            this.idUSERWORKCASHIERDataGridViewTextBoxColumn.Visible = false;
            // 
            // statutDataGridViewTextBoxColumn
            // 
            this.statutDataGridViewTextBoxColumn.DataPropertyName = "Statut";
            this.statutDataGridViewTextBoxColumn.HeaderText = "Statut";
            this.statutDataGridViewTextBoxColumn.Name = "statutDataGridViewTextBoxColumn";
            this.statutDataGridViewTextBoxColumn.ReadOnly = true;
            this.statutDataGridViewTextBoxColumn.Visible = false;
            // 
            // datecreDataGridViewTextBoxColumn
            // 
            this.datecreDataGridViewTextBoxColumn.DataPropertyName = "Date_cre";
            this.datecreDataGridViewTextBoxColumn.HeaderText = "Date";
            this.datecreDataGridViewTextBoxColumn.Name = "datecreDataGridViewTextBoxColumn";
            this.datecreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // montantcreDataGridViewTextBoxColumn
            // 
            this.montantcreDataGridViewTextBoxColumn.DataPropertyName = "Montant_cre";
            this.montantcreDataGridViewTextBoxColumn.HeaderText = "Montant";
            this.montantcreDataGridViewTextBoxColumn.Name = "montantcreDataGridViewTextBoxColumn";
            this.montantcreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomUSERWORKDataGridViewTextBoxColumn
            // 
            this.nomUSERWORKDataGridViewTextBoxColumn.DataPropertyName = "Nom_USER_WORK";
            this.nomUSERWORKDataGridViewTextBoxColumn.HeaderText = "Server NAME";
            this.nomUSERWORKDataGridViewTextBoxColumn.Name = "nomUSERWORKDataGridViewTextBoxColumn";
            this.nomUSERWORKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Afficherreglementbtn
            // 
            this.Afficherreglementbtn.ActiveBorderThickness = 1;
            this.Afficherreglementbtn.ActiveCornerRadius = 20;
            this.Afficherreglementbtn.ActiveFillColor = System.Drawing.Color.Violet;
            this.Afficherreglementbtn.ActiveForecolor = System.Drawing.Color.White;
            this.Afficherreglementbtn.ActiveLineColor = System.Drawing.Color.Violet;
            this.Afficherreglementbtn.BackColor = System.Drawing.SystemColors.Control;
            this.Afficherreglementbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Afficherreglementbtn.BackgroundImage")));
            this.Afficherreglementbtn.ButtonText = "Afficher  Reglement";
            this.Afficherreglementbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Afficherreglementbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Afficherreglementbtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.Afficherreglementbtn.IdleBorderThickness = 1;
            this.Afficherreglementbtn.IdleCornerRadius = 20;
            this.Afficherreglementbtn.IdleFillColor = System.Drawing.Color.White;
            this.Afficherreglementbtn.IdleForecolor = System.Drawing.Color.Violet;
            this.Afficherreglementbtn.IdleLineColor = System.Drawing.Color.Violet;
            this.Afficherreglementbtn.Location = new System.Drawing.Point(996, 108);
            this.Afficherreglementbtn.Margin = new System.Windows.Forms.Padding(5);
            this.Afficherreglementbtn.Name = "Afficherreglementbtn";
            this.Afficherreglementbtn.Size = new System.Drawing.Size(171, 41);
            this.Afficherreglementbtn.TabIndex = 30;
            this.Afficherreglementbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Afficherreglementbtn.Click += new System.EventHandler(this.Afficherreglementbtn_Click);
            // 
            // Reglerbtn
            // 
            this.Reglerbtn.ActiveBorderThickness = 1;
            this.Reglerbtn.ActiveCornerRadius = 20;
            this.Reglerbtn.ActiveFillColor = System.Drawing.Color.Violet;
            this.Reglerbtn.ActiveForecolor = System.Drawing.Color.White;
            this.Reglerbtn.ActiveLineColor = System.Drawing.Color.Violet;
            this.Reglerbtn.BackColor = System.Drawing.SystemColors.Control;
            this.Reglerbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Reglerbtn.BackgroundImage")));
            this.Reglerbtn.ButtonText = "Regler";
            this.Reglerbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reglerbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reglerbtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.Reglerbtn.IdleBorderThickness = 1;
            this.Reglerbtn.IdleCornerRadius = 20;
            this.Reglerbtn.IdleFillColor = System.Drawing.Color.White;
            this.Reglerbtn.IdleForecolor = System.Drawing.Color.Violet;
            this.Reglerbtn.IdleLineColor = System.Drawing.Color.Violet;
            this.Reglerbtn.Location = new System.Drawing.Point(1177, 107);
            this.Reglerbtn.Margin = new System.Windows.Forms.Padding(5);
            this.Reglerbtn.Name = "Reglerbtn";
            this.Reglerbtn.Size = new System.Drawing.Size(121, 41);
            this.Reglerbtn.TabIndex = 29;
            this.Reglerbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Reglerbtn.Click += new System.EventHandler(this.Reglerbtn_Click);
            // 
            // Creditdate
            // 
            this.Creditdate.BackColor = System.Drawing.Color.Transparent;
            this.Creditdate.BorderRadius = 1;
            this.Creditdate.Color = System.Drawing.SystemColors.ControlLight;
            this.Creditdate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.Creditdate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.Creditdate.DisabledColor = System.Drawing.Color.Gray;
            this.Creditdate.DisplayWeekNumbers = false;
            this.Creditdate.DPHeight = 0;
            this.Creditdate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.Creditdate.FillDatePicker = false;
            this.Creditdate.ForeColor = System.Drawing.Color.DarkViolet;
            this.Creditdate.Icon = ((System.Drawing.Image)(resources.GetObject("Creditdate.Icon")));
            this.Creditdate.IconColor = System.Drawing.Color.DarkViolet;
            this.Creditdate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.Creditdate.Location = new System.Drawing.Point(565, 60);
            this.Creditdate.MinimumSize = new System.Drawing.Size(217, 32);
            this.Creditdate.Name = "Creditdate";
            this.Creditdate.Size = new System.Drawing.Size(217, 32);
            this.Creditdate.TabIndex = 18;
            // 
            // CancelCreditFilterbtn
            // 
            this.CancelCreditFilterbtn.Active = false;
            this.CancelCreditFilterbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.CancelCreditFilterbtn.BackColor = System.Drawing.Color.Transparent;
            this.CancelCreditFilterbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelCreditFilterbtn.BorderRadius = 0;
            this.CancelCreditFilterbtn.ButtonText = "Annuler";
            this.CancelCreditFilterbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelCreditFilterbtn.DisabledColor = System.Drawing.Color.Gray;
            this.CancelCreditFilterbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CancelCreditFilterbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(81)))), ((int)(((byte)(189)))));
            this.CancelCreditFilterbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.CancelCreditFilterbtn.Iconimage = global::coffee_System.Properties.Resources.icons8_cancel_32;
            this.CancelCreditFilterbtn.Iconimage_right = null;
            this.CancelCreditFilterbtn.Iconimage_right_Selected = null;
            this.CancelCreditFilterbtn.Iconimage_Selected = null;
            this.CancelCreditFilterbtn.IconMarginLeft = 0;
            this.CancelCreditFilterbtn.IconMarginRight = 0;
            this.CancelCreditFilterbtn.IconRightVisible = true;
            this.CancelCreditFilterbtn.IconRightZoom = 0D;
            this.CancelCreditFilterbtn.IconVisible = true;
            this.CancelCreditFilterbtn.IconZoom = 40D;
            this.CancelCreditFilterbtn.IsTab = false;
            this.CancelCreditFilterbtn.Location = new System.Drawing.Point(1190, 60);
            this.CancelCreditFilterbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CancelCreditFilterbtn.Name = "CancelCreditFilterbtn";
            this.CancelCreditFilterbtn.Normalcolor = System.Drawing.Color.Transparent;
            this.CancelCreditFilterbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.CancelCreditFilterbtn.OnHoverTextColor = System.Drawing.Color.Black;
            this.CancelCreditFilterbtn.selected = false;
            this.CancelCreditFilterbtn.Size = new System.Drawing.Size(111, 27);
            this.CancelCreditFilterbtn.TabIndex = 41;
            this.CancelCreditFilterbtn.Text = "Annuler";
            this.CancelCreditFilterbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CancelCreditFilterbtn.Textcolor = System.Drawing.SystemColors.WindowFrame;
            this.CancelCreditFilterbtn.TextFont = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F);
            this.CancelCreditFilterbtn.Click += new System.EventHandler(this.CancelCreditFilterbtn_Click);
            // 
            // CreditFilterbtn
            // 
            this.CreditFilterbtn.Active = false;
            this.CreditFilterbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.CreditFilterbtn.BackColor = System.Drawing.Color.Transparent;
            this.CreditFilterbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CreditFilterbtn.BorderRadius = 0;
            this.CreditFilterbtn.ButtonText = "filtrer";
            this.CreditFilterbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreditFilterbtn.DisabledColor = System.Drawing.Color.Gray;
            this.CreditFilterbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CreditFilterbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(81)))), ((int)(((byte)(189)))));
            this.CreditFilterbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.CreditFilterbtn.Iconimage = global::coffee_System.Properties.Resources.icons8_filter_24;
            this.CreditFilterbtn.Iconimage_right = null;
            this.CreditFilterbtn.Iconimage_right_Selected = null;
            this.CreditFilterbtn.Iconimage_Selected = null;
            this.CreditFilterbtn.IconMarginLeft = 0;
            this.CreditFilterbtn.IconMarginRight = 0;
            this.CreditFilterbtn.IconRightVisible = true;
            this.CreditFilterbtn.IconRightZoom = 0D;
            this.CreditFilterbtn.IconVisible = true;
            this.CreditFilterbtn.IconZoom = 40D;
            this.CreditFilterbtn.IsTab = false;
            this.CreditFilterbtn.Location = new System.Drawing.Point(1071, 60);
            this.CreditFilterbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CreditFilterbtn.Name = "CreditFilterbtn";
            this.CreditFilterbtn.Normalcolor = System.Drawing.Color.Transparent;
            this.CreditFilterbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.CreditFilterbtn.OnHoverTextColor = System.Drawing.Color.Black;
            this.CreditFilterbtn.selected = false;
            this.CreditFilterbtn.Size = new System.Drawing.Size(111, 27);
            this.CreditFilterbtn.TabIndex = 42;
            this.CreditFilterbtn.Text = "filtrer";
            this.CreditFilterbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CreditFilterbtn.Textcolor = System.Drawing.SystemColors.WindowFrame;
            this.CreditFilterbtn.TextFont = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F);
            this.CreditFilterbtn.Click += new System.EventHandler(this.CreditFilterbtn_Click);
            // 
            // Servercheckbox
            // 
            this.Servercheckbox.AllowBindingControlAnimation = true;
            this.Servercheckbox.AllowBindingControlColorChanges = false;
            this.Servercheckbox.AllowBindingControlLocation = true;
            this.Servercheckbox.AllowCheckBoxAnimation = false;
            this.Servercheckbox.AllowCheckmarkAnimation = true;
            this.Servercheckbox.AllowOnHoverStates = true;
            this.Servercheckbox.AutoCheck = true;
            this.Servercheckbox.BackColor = System.Drawing.Color.Transparent;
            this.Servercheckbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Servercheckbox.BackgroundImage")));
            this.Servercheckbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Servercheckbox.BindingControl = null;
            this.Servercheckbox.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.Servercheckbox.Checked = false;
            this.Servercheckbox.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.Servercheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Servercheckbox.CustomCheckmarkImage = null;
            this.Servercheckbox.Location = new System.Drawing.Point(1031, 67);
            this.Servercheckbox.MinimumSize = new System.Drawing.Size(17, 17);
            this.Servercheckbox.Name = "Servercheckbox";
            this.Servercheckbox.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.Servercheckbox.OnCheck.BorderRadius = 2;
            this.Servercheckbox.OnCheck.BorderThickness = 2;
            this.Servercheckbox.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.Servercheckbox.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.Servercheckbox.OnCheck.CheckmarkThickness = 2;
            this.Servercheckbox.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.Servercheckbox.OnDisable.BorderRadius = 2;
            this.Servercheckbox.OnDisable.BorderThickness = 2;
            this.Servercheckbox.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.Servercheckbox.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.Servercheckbox.OnDisable.CheckmarkThickness = 2;
            this.Servercheckbox.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.Servercheckbox.OnHoverChecked.BorderRadius = 2;
            this.Servercheckbox.OnHoverChecked.BorderThickness = 2;
            this.Servercheckbox.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.Servercheckbox.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.Servercheckbox.OnHoverChecked.CheckmarkThickness = 2;
            this.Servercheckbox.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.Servercheckbox.OnHoverUnchecked.BorderRadius = 2;
            this.Servercheckbox.OnHoverUnchecked.BorderThickness = 2;
            this.Servercheckbox.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.Servercheckbox.OnUncheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.Servercheckbox.OnUncheck.BorderRadius = 2;
            this.Servercheckbox.OnUncheck.BorderThickness = 2;
            this.Servercheckbox.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.Servercheckbox.Size = new System.Drawing.Size(21, 21);
            this.Servercheckbox.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Round;
            this.Servercheckbox.TabIndex = 48;
            this.Servercheckbox.ThreeState = false;
            this.Servercheckbox.ToolTipText = null;
            // 
            // Datecheckbox
            // 
            this.Datecheckbox.AllowBindingControlAnimation = true;
            this.Datecheckbox.AllowBindingControlColorChanges = false;
            this.Datecheckbox.AllowBindingControlLocation = true;
            this.Datecheckbox.AllowCheckBoxAnimation = false;
            this.Datecheckbox.AllowCheckmarkAnimation = true;
            this.Datecheckbox.AllowOnHoverStates = true;
            this.Datecheckbox.AutoCheck = true;
            this.Datecheckbox.BackColor = System.Drawing.Color.Transparent;
            this.Datecheckbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Datecheckbox.BackgroundImage")));
            this.Datecheckbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Datecheckbox.BindingControl = null;
            this.Datecheckbox.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.Datecheckbox.Checked = false;
            this.Datecheckbox.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.Datecheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Datecheckbox.CustomCheckmarkImage = null;
            this.Datecheckbox.Location = new System.Drawing.Point(788, 66);
            this.Datecheckbox.MinimumSize = new System.Drawing.Size(17, 17);
            this.Datecheckbox.Name = "Datecheckbox";
            this.Datecheckbox.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.Datecheckbox.OnCheck.BorderRadius = 2;
            this.Datecheckbox.OnCheck.BorderThickness = 2;
            this.Datecheckbox.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.Datecheckbox.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.Datecheckbox.OnCheck.CheckmarkThickness = 2;
            this.Datecheckbox.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.Datecheckbox.OnDisable.BorderRadius = 2;
            this.Datecheckbox.OnDisable.BorderThickness = 2;
            this.Datecheckbox.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.Datecheckbox.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.Datecheckbox.OnDisable.CheckmarkThickness = 2;
            this.Datecheckbox.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.Datecheckbox.OnHoverChecked.BorderRadius = 2;
            this.Datecheckbox.OnHoverChecked.BorderThickness = 2;
            this.Datecheckbox.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.Datecheckbox.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.Datecheckbox.OnHoverChecked.CheckmarkThickness = 2;
            this.Datecheckbox.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.Datecheckbox.OnHoverUnchecked.BorderRadius = 2;
            this.Datecheckbox.OnHoverUnchecked.BorderThickness = 2;
            this.Datecheckbox.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.Datecheckbox.OnUncheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.Datecheckbox.OnUncheck.BorderRadius = 2;
            this.Datecheckbox.OnUncheck.BorderThickness = 2;
            this.Datecheckbox.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.Datecheckbox.Size = new System.Drawing.Size(21, 21);
            this.Datecheckbox.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Round;
            this.Datecheckbox.TabIndex = 47;
            this.Datecheckbox.ThreeState = false;
            this.Datecheckbox.ToolTipText = null;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblusername);
            this.panel1.Controls.Add(this.home);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.close);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(12, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1286, 36);
            this.panel1.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(573, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Credit";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblusername.Location = new System.Drawing.Point(144, 10);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(136, 17);
            this.lblusername.TabIndex = 6;
            this.lblusername.Text = "(ELQESSOUAR TARIQ)";
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.Transparent;
            this.home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home.Image = ((System.Drawing.Image)(resources.GetObject("home.Image")));
            this.home.Location = new System.Drawing.Point(8, 3);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(29, 29);
            this.home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.home.TabIndex = 2;
            this.home.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "ESTA Coffee";
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(1252, 7);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(29, 20);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 0;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // dBTD_CoffeeManagement
            // 
            this.dBTD_CoffeeManagement.DataSetName = "DBTD_CoffeeManagement";
            this.dBTD_CoffeeManagement.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cREDIT_DGINFOTableAdapter
            // 
            this.cREDIT_DGINFOTableAdapter.ClearBeforeFill = true;
            // 
            // coffeeManagement_dbDataSet
            // 
            this.coffeeManagement_dbDataSet.DataSetName = "CoffeeManagement_dbDataSet";
            this.coffeeManagement_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cREDITDGINFOBindingSource
            // 
            this.cREDITDGINFOBindingSource.DataMember = "CREDIT_DGINFO";
            this.cREDITDGINFOBindingSource.DataSource = this.dBTD_CoffeeManagement;
            // 
            // Credit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 660);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Servercheckbox);
            this.Controls.Add(this.Datecheckbox);
            this.Controls.Add(this.CancelCreditFilterbtn);
            this.Controls.Add(this.CreditFilterbtn);
            this.Controls.Add(this.Afficherreglementbtn);
            this.Controls.Add(this.Reglerbtn);
            this.Controls.Add(this.CreditDatagrid);
            this.Controls.Add(this.bunifuLabel4);
            this.Controls.Add(this.Servercombobox);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.Creditdate);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Credit";
            this.Text = "Credit";
            this.Load += new System.EventHandler(this.Credit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CreditDatagrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTD_CoffeeManagement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeManagement_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cREDITDGINFOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuDatePicker Creditdate;
        private System.Windows.Forms.ComboBox Servercombobox;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuDataGridView CreditDatagrid;
        private Bunifu.Framework.UI.BunifuThinButton2 Reglerbtn;
        private Bunifu.Framework.UI.BunifuThinButton2 Afficherreglementbtn;
        private Bunifu.Framework.UI.BunifuFlatButton CancelCreditFilterbtn;
        private Bunifu.Framework.UI.BunifuFlatButton CreditFilterbtn;
        private Bunifu.UI.WinForms.BunifuCheckBox Servercheckbox;
        private Bunifu.UI.WinForms.BunifuCheckBox Datecheckbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.PictureBox home;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox close;
        private DBTD_CoffeeManagement dBTD_CoffeeManagement;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDcreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUSERWORKSERVERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUSERWORKCASHIERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datecreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montantcreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomUSERWORKDataGridViewTextBoxColumn;
        private DBTD_CoffeeManagementTableAdapters.CREDIT_DGINFOTableAdapter cREDIT_DGINFOTableAdapter;
        private CoffeeManagement_dbDataSet coffeeManagement_dbDataSet;
        private System.Windows.Forms.BindingSource cREDITDGINFOBindingSource;
    }
}