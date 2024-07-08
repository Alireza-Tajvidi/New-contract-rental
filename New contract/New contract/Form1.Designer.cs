namespace New_contract
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCreatecontract = new System.Windows.Forms.Button();
            this.nmrRent = new System.Windows.Forms.NumericUpDown();
            this.panContractend = new System.Windows.Forms.Panel();
            this.panContractstart = new System.Windows.Forms.Panel();
            this.txtTenant = new System.Windows.Forms.TextBox();
            this.panTenant = new System.Windows.Forms.Panel();
            this.lbContractend = new System.Windows.Forms.Label();
            this.lbContractstart = new System.Windows.Forms.Label();
            this.txtDeedid_newcontract = new System.Windows.Forms.TextBox();
            this.panRoomcount = new System.Windows.Forms.Panel();
            this.panExpenses = new System.Windows.Forms.Panel();
            this.panRent = new System.Windows.Forms.Panel();
            this.panDeedid_newcontract = new System.Windows.Forms.Panel();
            this.lbDownpayment = new System.Windows.Forms.Label();
            this.lbExpenses = new System.Windows.Forms.Label();
            this.lbRent = new System.Windows.Forms.Label();
            this.lbTenant = new System.Windows.Forms.Label();
            this.lbDeedid_newcontract = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbAssetregistry = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbNewcontract = new System.Windows.Forms.Label();
            this.lbTenantregistry = new System.Windows.Forms.Label();
            this.panLicense = new System.Windows.Forms.Panel();
            this.panLeaseend = new System.Windows.Forms.Panel();
            this.panLatency = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panNewcontract = new System.Windows.Forms.Panel();
            this.panAssetregistry = new System.Windows.Forms.Panel();
            this.panTenantregistry = new System.Windows.Forms.Panel();
            this.lbLicense = new System.Windows.Forms.Label();
            this.lbLeaseend = new System.Windows.Forms.Label();
            this.lbLatency = new System.Windows.Forms.Label();
            this.lbCollection = new System.Windows.Forms.Label();
            this.panTopbar = new System.Windows.Forms.Panel();
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.panOptions = new System.Windows.Forms.Panel();
            this.panOpt3 = new System.Windows.Forms.Panel();
            this.panOpt2 = new System.Windows.Forms.Panel();
            this.panOpt1 = new System.Windows.Forms.Panel();
            this.dtpcContractstart = new System.Windows.Forms.DateTimePicker();
            this.dtpcContractend = new System.Windows.Forms.DateTimePicker();
            this.nmrExpenses = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nmrRent)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panTopbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            this.panOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreatecontract
            // 
            this.btnCreatecontract.BackColor = System.Drawing.Color.IndianRed;
            this.btnCreatecontract.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCreatecontract.Location = new System.Drawing.Point(630, 347);
            this.btnCreatecontract.Name = "btnCreatecontract";
            this.btnCreatecontract.Size = new System.Drawing.Size(367, 46);
            this.btnCreatecontract.TabIndex = 73;
            this.btnCreatecontract.Text = "Kontrat oluştur";
            this.btnCreatecontract.UseVisualStyleBackColor = false;
            // 
            // nmrRent
            // 
            this.nmrRent.BackColor = System.Drawing.Color.Gainsboro;
            this.nmrRent.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nmrRent.Location = new System.Drawing.Point(678, 180);
            this.nmrRent.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmrRent.Minimum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.nmrRent.Name = "nmrRent";
            this.nmrRent.ReadOnly = true;
            this.nmrRent.Size = new System.Drawing.Size(319, 20);
            this.nmrRent.TabIndex = 68;
            this.nmrRent.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // panContractend
            // 
            this.panContractend.BackColor = System.Drawing.Color.SlateGray;
            this.panContractend.Location = new System.Drawing.Point(214, 382);
            this.panContractend.Name = "panContractend";
            this.panContractend.Size = new System.Drawing.Size(367, 3);
            this.panContractend.TabIndex = 59;
            // 
            // panContractstart
            // 
            this.panContractstart.BackColor = System.Drawing.Color.SlateGray;
            this.panContractstart.Location = new System.Drawing.Point(213, 326);
            this.panContractstart.Name = "panContractstart";
            this.panContractstart.Size = new System.Drawing.Size(367, 3);
            this.panContractstart.TabIndex = 58;
            // 
            // txtTenant
            // 
            this.txtTenant.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTenant.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenant.Location = new System.Drawing.Point(272, 236);
            this.txtTenant.Multiline = true;
            this.txtTenant.Name = "txtTenant";
            this.txtTenant.Size = new System.Drawing.Size(308, 25);
            this.txtTenant.TabIndex = 65;
            // 
            // panTenant
            // 
            this.panTenant.BackColor = System.Drawing.Color.SlateGray;
            this.panTenant.Location = new System.Drawing.Point(213, 267);
            this.panTenant.Name = "panTenant";
            this.panTenant.Size = new System.Drawing.Size(367, 3);
            this.panTenant.TabIndex = 57;
            // 
            // lbContractend
            // 
            this.lbContractend.AutoSize = true;
            this.lbContractend.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContractend.Location = new System.Drawing.Point(214, 357);
            this.lbContractend.Name = "lbContractend";
            this.lbContractend.Size = new System.Drawing.Size(79, 21);
            this.lbContractend.TabIndex = 52;
            this.lbContractend.Text = "Kira bitişi:";
            this.lbContractend.UseMnemonic = false;
            // 
            // lbContractstart
            // 
            this.lbContractstart.AutoSize = true;
            this.lbContractstart.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContractstart.Location = new System.Drawing.Point(213, 301);
            this.lbContractstart.Name = "lbContractstart";
            this.lbContractstart.Size = new System.Drawing.Size(117, 21);
            this.lbContractstart.TabIndex = 51;
            this.lbContractstart.Text = "Kira Başlangıcı:";
            this.lbContractstart.UseMnemonic = false;
            // 
            // txtDeedid_newcontract
            // 
            this.txtDeedid_newcontract.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDeedid_newcontract.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeedid_newcontract.Location = new System.Drawing.Point(320, 175);
            this.txtDeedid_newcontract.Multiline = true;
            this.txtDeedid_newcontract.Name = "txtDeedid_newcontract";
            this.txtDeedid_newcontract.Size = new System.Drawing.Size(260, 25);
            this.txtDeedid_newcontract.TabIndex = 66;
            // 
            // panRoomcount
            // 
            this.panRoomcount.BackColor = System.Drawing.Color.SlateGray;
            this.panRoomcount.Location = new System.Drawing.Point(630, 319);
            this.panRoomcount.Name = "panRoomcount";
            this.panRoomcount.Size = new System.Drawing.Size(367, 3);
            this.panRoomcount.TabIndex = 62;
            // 
            // panExpenses
            // 
            this.panExpenses.BackColor = System.Drawing.Color.SlateGray;
            this.panExpenses.Location = new System.Drawing.Point(630, 265);
            this.panExpenses.Name = "panExpenses";
            this.panExpenses.Size = new System.Drawing.Size(367, 3);
            this.panExpenses.TabIndex = 63;
            // 
            // panRent
            // 
            this.panRent.BackColor = System.Drawing.Color.SlateGray;
            this.panRent.Location = new System.Drawing.Point(630, 206);
            this.panRent.Name = "panRent";
            this.panRent.Size = new System.Drawing.Size(367, 3);
            this.panRent.TabIndex = 60;
            // 
            // panDeedid_newcontract
            // 
            this.panDeedid_newcontract.BackColor = System.Drawing.Color.SlateGray;
            this.panDeedid_newcontract.Location = new System.Drawing.Point(213, 206);
            this.panDeedid_newcontract.Name = "panDeedid_newcontract";
            this.panDeedid_newcontract.Size = new System.Drawing.Size(367, 3);
            this.panDeedid_newcontract.TabIndex = 61;
            // 
            // lbDownpayment
            // 
            this.lbDownpayment.AutoSize = true;
            this.lbDownpayment.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDownpayment.Location = new System.Drawing.Point(630, 294);
            this.lbDownpayment.Name = "lbDownpayment";
            this.lbDownpayment.Size = new System.Drawing.Size(65, 21);
            this.lbDownpayment.TabIndex = 56;
            this.lbDownpayment.Text = "Depozit:";
            this.lbDownpayment.UseMnemonic = false;
            // 
            // lbExpenses
            // 
            this.lbExpenses.AutoSize = true;
            this.lbExpenses.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExpenses.Location = new System.Drawing.Point(630, 240);
            this.lbExpenses.Name = "lbExpenses";
            this.lbExpenses.Size = new System.Drawing.Size(51, 21);
            this.lbExpenses.TabIndex = 55;
            this.lbExpenses.Text = "Aidat:";
            this.lbExpenses.UseMnemonic = false;
            // 
            // lbRent
            // 
            this.lbRent.AutoSize = true;
            this.lbRent.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRent.Location = new System.Drawing.Point(630, 181);
            this.lbRent.Name = "lbRent";
            this.lbRent.Size = new System.Drawing.Size(42, 21);
            this.lbRent.TabIndex = 54;
            this.lbRent.Text = "Kira:";
            this.lbRent.UseMnemonic = false;
            // 
            // lbTenant
            // 
            this.lbTenant.AutoSize = true;
            this.lbTenant.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenant.Location = new System.Drawing.Point(213, 242);
            this.lbTenant.Name = "lbTenant";
            this.lbTenant.Size = new System.Drawing.Size(53, 21);
            this.lbTenant.TabIndex = 50;
            this.lbTenant.Text = "Kiracı:";
            this.lbTenant.UseMnemonic = false;
            // 
            // lbDeedid_newcontract
            // 
            this.lbDeedid_newcontract.AutoSize = true;
            this.lbDeedid_newcontract.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDeedid_newcontract.Location = new System.Drawing.Point(213, 181);
            this.lbDeedid_newcontract.Name = "lbDeedid_newcontract";
            this.lbDeedid_newcontract.Size = new System.Drawing.Size(101, 21);
            this.lbDeedid_newcontract.TabIndex = 53;
            this.lbDeedid_newcontract.Text = "Tapu Kimliği:";
            this.lbDeedid_newcontract.UseMnemonic = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.lbAssetregistry);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.lbTenantregistry);
            this.panel1.Controls.Add(this.panLicense);
            this.panel1.Controls.Add(this.panLeaseend);
            this.panel1.Controls.Add(this.panLatency);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panNewcontract);
            this.panel1.Controls.Add(this.panAssetregistry);
            this.panel1.Controls.Add(this.panTenantregistry);
            this.panel1.Controls.Add(this.lbLicense);
            this.panel1.Controls.Add(this.lbLeaseend);
            this.panel1.Controls.Add(this.lbLatency);
            this.panel1.Controls.Add(this.lbCollection);
            this.panel1.Location = new System.Drawing.Point(1, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 539);
            this.panel1.TabIndex = 49;
            // 
            // lbAssetregistry
            // 
            this.lbAssetregistry.AutoSize = true;
            this.lbAssetregistry.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAssetregistry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(132)))), ((int)(((byte)(47)))));
            this.lbAssetregistry.Location = new System.Drawing.Point(16, 68);
            this.lbAssetregistry.Name = "lbAssetregistry";
            this.lbAssetregistry.Size = new System.Drawing.Size(103, 24);
            this.lbAssetregistry.TabIndex = 0;
            this.lbAssetregistry.Text = "Mülk kayıdı";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel4.Controls.Add(this.lbNewcontract);
            this.panel4.Location = new System.Drawing.Point(7, 117);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(190, 29);
            this.panel4.TabIndex = 4;
            // 
            // lbNewcontract
            // 
            this.lbNewcontract.AutoSize = true;
            this.lbNewcontract.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewcontract.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(132)))), ((int)(((byte)(47)))));
            this.lbNewcontract.Location = new System.Drawing.Point(9, 5);
            this.lbNewcontract.Name = "lbNewcontract";
            this.lbNewcontract.Size = new System.Drawing.Size(108, 24);
            this.lbNewcontract.TabIndex = 0;
            this.lbNewcontract.Text = "Yeni kontrat";
            // 
            // lbTenantregistry
            // 
            this.lbTenantregistry.AutoSize = true;
            this.lbTenantregistry.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenantregistry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(132)))), ((int)(((byte)(47)))));
            this.lbTenantregistry.Location = new System.Drawing.Point(16, 19);
            this.lbTenantregistry.Name = "lbTenantregistry";
            this.lbTenantregistry.Size = new System.Drawing.Size(110, 24);
            this.lbTenantregistry.TabIndex = 0;
            this.lbTenantregistry.Text = "Kiracı kayıdı";
            // 
            // panLicense
            // 
            this.panLicense.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panLicense.Location = new System.Drawing.Point(7, 345);
            this.panLicense.Name = "panLicense";
            this.panLicense.Size = new System.Drawing.Size(190, 3);
            this.panLicense.TabIndex = 1;
            // 
            // panLeaseend
            // 
            this.panLeaseend.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panLeaseend.Location = new System.Drawing.Point(7, 296);
            this.panLeaseend.Name = "panLeaseend";
            this.panLeaseend.Size = new System.Drawing.Size(190, 3);
            this.panLeaseend.TabIndex = 1;
            // 
            // panLatency
            // 
            this.panLatency.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panLatency.Location = new System.Drawing.Point(7, 246);
            this.panLatency.Name = "panLatency";
            this.panLatency.Size = new System.Drawing.Size(190, 3);
            this.panLatency.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Location = new System.Drawing.Point(7, 197);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 3);
            this.panel2.TabIndex = 1;
            // 
            // panNewcontract
            // 
            this.panNewcontract.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panNewcontract.Location = new System.Drawing.Point(7, 146);
            this.panNewcontract.Name = "panNewcontract";
            this.panNewcontract.Size = new System.Drawing.Size(190, 3);
            this.panNewcontract.TabIndex = 1;
            // 
            // panAssetregistry
            // 
            this.panAssetregistry.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panAssetregistry.Location = new System.Drawing.Point(7, 95);
            this.panAssetregistry.Name = "panAssetregistry";
            this.panAssetregistry.Size = new System.Drawing.Size(190, 3);
            this.panAssetregistry.TabIndex = 1;
            // 
            // panTenantregistry
            // 
            this.panTenantregistry.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panTenantregistry.Location = new System.Drawing.Point(7, 46);
            this.panTenantregistry.Name = "panTenantregistry";
            this.panTenantregistry.Size = new System.Drawing.Size(190, 3);
            this.panTenantregistry.TabIndex = 1;
            // 
            // lbLicense
            // 
            this.lbLicense.AutoSize = true;
            this.lbLicense.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLicense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(132)))), ((int)(((byte)(47)))));
            this.lbLicense.Location = new System.Drawing.Point(16, 318);
            this.lbLicense.Name = "lbLicense";
            this.lbLicense.Size = new System.Drawing.Size(104, 24);
            this.lbLicense.TabIndex = 0;
            this.lbLicense.Text = "Lisanslama";
            // 
            // lbLeaseend
            // 
            this.lbLeaseend.AutoSize = true;
            this.lbLeaseend.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLeaseend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(132)))), ((int)(((byte)(47)))));
            this.lbLeaseend.Location = new System.Drawing.Point(16, 269);
            this.lbLeaseend.Name = "lbLeaseend";
            this.lbLeaseend.Size = new System.Drawing.Size(129, 24);
            this.lbLeaseend.TabIndex = 0;
            this.lbLeaseend.Text = "Bitecek kiralar";
            // 
            // lbLatency
            // 
            this.lbLatency.AutoSize = true;
            this.lbLatency.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLatency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(132)))), ((int)(((byte)(47)))));
            this.lbLatency.Location = new System.Drawing.Point(16, 219);
            this.lbLatency.Name = "lbLatency";
            this.lbLatency.Size = new System.Drawing.Size(104, 24);
            this.lbLatency.TabIndex = 0;
            this.lbLatency.Text = "Gecikmeler";
            // 
            // lbCollection
            // 
            this.lbCollection.AutoSize = true;
            this.lbCollection.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCollection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(132)))), ((int)(((byte)(47)))));
            this.lbCollection.Location = new System.Drawing.Point(16, 170);
            this.lbCollection.Name = "lbCollection";
            this.lbCollection.Size = new System.Drawing.Size(74, 24);
            this.lbCollection.TabIndex = 0;
            this.lbCollection.Text = "Tahsilat";
            // 
            // panTopbar
            // 
            this.panTopbar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panTopbar.Controls.Add(this.picProfile);
            this.panTopbar.Controls.Add(this.panOptions);
            this.panTopbar.Location = new System.Drawing.Point(-4, -1);
            this.panTopbar.Name = "panTopbar";
            this.panTopbar.Size = new System.Drawing.Size(1016, 53);
            this.panTopbar.TabIndex = 48;
            // 
            // picProfile
            // 
            this.picProfile.Image = ((System.Drawing.Image)(resources.GetObject("picProfile.Image")));
            this.picProfile.Location = new System.Drawing.Point(959, 7);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(43, 39);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProfile.TabIndex = 2;
            this.picProfile.TabStop = false;
            // 
            // panOptions
            // 
            this.panOptions.Controls.Add(this.panOpt3);
            this.panOptions.Controls.Add(this.panOpt2);
            this.panOptions.Controls.Add(this.panOpt1);
            this.panOptions.Location = new System.Drawing.Point(17, 11);
            this.panOptions.Name = "panOptions";
            this.panOptions.Size = new System.Drawing.Size(39, 39);
            this.panOptions.TabIndex = 1;
            // 
            // panOpt3
            // 
            this.panOpt3.BackColor = System.Drawing.Color.White;
            this.panOpt3.Enabled = false;
            this.panOpt3.Location = new System.Drawing.Point(3, 25);
            this.panOpt3.Name = "panOpt3";
            this.panOpt3.Size = new System.Drawing.Size(25, 5);
            this.panOpt3.TabIndex = 1;
            // 
            // panOpt2
            // 
            this.panOpt2.BackColor = System.Drawing.Color.White;
            this.panOpt2.Enabled = false;
            this.panOpt2.Location = new System.Drawing.Point(3, 14);
            this.panOpt2.Name = "panOpt2";
            this.panOpt2.Size = new System.Drawing.Size(25, 5);
            this.panOpt2.TabIndex = 1;
            // 
            // panOpt1
            // 
            this.panOpt1.BackColor = System.Drawing.Color.White;
            this.panOpt1.Enabled = false;
            this.panOpt1.Location = new System.Drawing.Point(3, 3);
            this.panOpt1.Name = "panOpt1";
            this.panOpt1.Size = new System.Drawing.Size(25, 5);
            this.panOpt1.TabIndex = 1;
            // 
            // dtpcContractstart
            // 
            this.dtpcContractstart.Location = new System.Drawing.Point(336, 301);
            this.dtpcContractstart.Name = "dtpcContractstart";
            this.dtpcContractstart.Size = new System.Drawing.Size(244, 20);
            this.dtpcContractstart.TabIndex = 74;
            // 
            // dtpcContractend
            // 
            this.dtpcContractend.Location = new System.Drawing.Point(299, 360);
            this.dtpcContractend.Name = "dtpcContractend";
            this.dtpcContractend.Size = new System.Drawing.Size(282, 20);
            this.dtpcContractend.TabIndex = 75;
            // 
            // nmrExpenses
            // 
            this.nmrExpenses.BackColor = System.Drawing.Color.Gainsboro;
            this.nmrExpenses.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nmrExpenses.Location = new System.Drawing.Point(687, 240);
            this.nmrExpenses.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmrExpenses.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nmrExpenses.Name = "nmrExpenses";
            this.nmrExpenses.ReadOnly = true;
            this.nmrExpenses.Size = new System.Drawing.Size(310, 20);
            this.nmrExpenses.TabIndex = 68;
            this.nmrExpenses.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.Gainsboro;
            this.numericUpDown1.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(701, 294);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(297, 20);
            this.numericUpDown1.TabIndex = 68;
            this.numericUpDown1.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 588);
            this.Controls.Add(this.dtpcContractend);
            this.Controls.Add(this.dtpcContractstart);
            this.Controls.Add(this.btnCreatecontract);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.nmrExpenses);
            this.Controls.Add(this.nmrRent);
            this.Controls.Add(this.panContractend);
            this.Controls.Add(this.panContractstart);
            this.Controls.Add(this.txtTenant);
            this.Controls.Add(this.panTenant);
            this.Controls.Add(this.lbContractend);
            this.Controls.Add(this.lbContractstart);
            this.Controls.Add(this.txtDeedid_newcontract);
            this.Controls.Add(this.panRoomcount);
            this.Controls.Add(this.panExpenses);
            this.Controls.Add(this.panRent);
            this.Controls.Add(this.panDeedid_newcontract);
            this.Controls.Add(this.lbDownpayment);
            this.Controls.Add(this.lbExpenses);
            this.Controls.Add(this.lbRent);
            this.Controls.Add(this.lbTenant);
            this.Controls.Add(this.lbDeedid_newcontract);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panTopbar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nmrRent)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panTopbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            this.panOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmrExpenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreatecontract;
        private System.Windows.Forms.NumericUpDown nmrRent;
        private System.Windows.Forms.Panel panContractend;
        private System.Windows.Forms.Panel panContractstart;
        private System.Windows.Forms.TextBox txtTenant;
        private System.Windows.Forms.Panel panTenant;
        private System.Windows.Forms.Label lbContractend;
        private System.Windows.Forms.Label lbContractstart;
        private System.Windows.Forms.TextBox txtDeedid_newcontract;
        private System.Windows.Forms.Panel panRoomcount;
        private System.Windows.Forms.Panel panExpenses;
        private System.Windows.Forms.Panel panRent;
        private System.Windows.Forms.Panel panDeedid_newcontract;
        private System.Windows.Forms.Label lbDownpayment;
        private System.Windows.Forms.Label lbExpenses;
        private System.Windows.Forms.Label lbRent;
        private System.Windows.Forms.Label lbTenant;
        private System.Windows.Forms.Label lbDeedid_newcontract;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbAssetregistry;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbNewcontract;
        private System.Windows.Forms.Label lbTenantregistry;
        private System.Windows.Forms.Panel panLicense;
        private System.Windows.Forms.Panel panLeaseend;
        private System.Windows.Forms.Panel panLatency;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panNewcontract;
        private System.Windows.Forms.Panel panAssetregistry;
        private System.Windows.Forms.Panel panTenantregistry;
        private System.Windows.Forms.Label lbLicense;
        private System.Windows.Forms.Label lbLeaseend;
        private System.Windows.Forms.Label lbLatency;
        private System.Windows.Forms.Label lbCollection;
        private System.Windows.Forms.Panel panTopbar;
        private System.Windows.Forms.PictureBox picProfile;
        private System.Windows.Forms.Panel panOptions;
        private System.Windows.Forms.Panel panOpt3;
        private System.Windows.Forms.Panel panOpt2;
        private System.Windows.Forms.Panel panOpt1;
        private System.Windows.Forms.DateTimePicker dtpcContractstart;
        private System.Windows.Forms.DateTimePicker dtpcContractend;
        private System.Windows.Forms.NumericUpDown nmrExpenses;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

