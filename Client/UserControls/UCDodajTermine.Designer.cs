namespace Client.UserControls
{
    partial class UCDodajTermine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCDodajTermine));
            this.lblDveTacke = new System.Windows.Forms.Label();
            this.txtMinuti = new System.Windows.Forms.TextBox();
            this.lblVreme = new System.Windows.Forms.Label();
            this.txtSati = new System.Windows.Forms.TextBox();
            this.btnSacuvajTermine = new System.Windows.Forms.Button();
            this.btnObrisiTermin = new System.Windows.Forms.Button();
            this.btnDodajTermin = new System.Windows.Forms.Button();
            this.rtbNapomena = new System.Windows.Forms.RichTextBox();
            this.lblVaucer = new System.Windows.Forms.Label();
            this.cbVaucer = new System.Windows.Forms.ComboBox();
            this.lblNapomena = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblUsluga = new System.Windows.Forms.Label();
            this.cbUsluga = new System.Windows.Forms.ComboBox();
            this.lblKlijent = new System.Windows.Forms.Label();
            this.cbKlijent = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnObavestiKlijenta = new System.Windows.Forms.Button();
            this.btnKalendar = new System.Windows.Forms.Button();
            this.dgvTermini = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDveTacke
            // 
            this.lblDveTacke.AutoSize = true;
            this.lblDveTacke.BackColor = System.Drawing.Color.Transparent;
            this.lblDveTacke.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDveTacke.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDveTacke.Location = new System.Drawing.Point(420, 287);
            this.lblDveTacke.Name = "lblDveTacke";
            this.lblDveTacke.Size = new System.Drawing.Size(15, 20);
            this.lblDveTacke.TabIndex = 44;
            this.lblDveTacke.Text = ":";
            // 
            // txtMinuti
            // 
            this.txtMinuti.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinuti.Location = new System.Drawing.Point(442, 284);
            this.txtMinuti.Name = "txtMinuti";
            this.txtMinuti.Size = new System.Drawing.Size(43, 27);
            this.txtMinuti.TabIndex = 43;
            // 
            // lblVreme
            // 
            this.lblVreme.AutoSize = true;
            this.lblVreme.BackColor = System.Drawing.Color.Transparent;
            this.lblVreme.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVreme.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblVreme.Location = new System.Drawing.Point(274, 287);
            this.lblVreme.Name = "lblVreme";
            this.lblVreme.Size = new System.Drawing.Size(55, 20);
            this.lblVreme.TabIndex = 42;
            this.lblVreme.Text = "Vreme";
            // 
            // txtSati
            // 
            this.txtSati.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSati.Location = new System.Drawing.Point(371, 284);
            this.txtSati.Name = "txtSati";
            this.txtSati.Size = new System.Drawing.Size(43, 27);
            this.txtSati.TabIndex = 41;
            // 
            // btnSacuvajTermine
            // 
            this.btnSacuvajTermine.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSacuvajTermine.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvajTermine.Location = new System.Drawing.Point(1098, 621);
            this.btnSacuvajTermine.Name = "btnSacuvajTermine";
            this.btnSacuvajTermine.Size = new System.Drawing.Size(188, 37);
            this.btnSacuvajTermine.TabIndex = 40;
            this.btnSacuvajTermine.Text = "Sačuvaj termine";
            this.btnSacuvajTermine.UseVisualStyleBackColor = false;
            this.btnSacuvajTermine.Click += new System.EventHandler(this.btnSacuvajTermine_Click);
            // 
            // btnObrisiTermin
            // 
            this.btnObrisiTermin.BackColor = System.Drawing.Color.SkyBlue;
            this.btnObrisiTermin.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiTermin.Location = new System.Drawing.Point(1143, 337);
            this.btnObrisiTermin.Name = "btnObrisiTermin";
            this.btnObrisiTermin.Size = new System.Drawing.Size(143, 37);
            this.btnObrisiTermin.TabIndex = 39;
            this.btnObrisiTermin.Text = "Obriši termin";
            this.btnObrisiTermin.UseVisualStyleBackColor = false;
            this.btnObrisiTermin.Click += new System.EventHandler(this.btnObrisiTermin_Click);
            // 
            // btnDodajTermin
            // 
            this.btnDodajTermin.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDodajTermin.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajTermin.Location = new System.Drawing.Point(976, 337);
            this.btnDodajTermin.Name = "btnDodajTermin";
            this.btnDodajTermin.Size = new System.Drawing.Size(151, 37);
            this.btnDodajTermin.TabIndex = 38;
            this.btnDodajTermin.Text = "Dodaj termin";
            this.btnDodajTermin.UseVisualStyleBackColor = false;
            this.btnDodajTermin.Click += new System.EventHandler(this.btnDodajTermin_Click);
            // 
            // rtbNapomena
            // 
            this.rtbNapomena.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbNapomena.Location = new System.Drawing.Point(976, 117);
            this.rtbNapomena.Name = "rtbNapomena";
            this.rtbNapomena.Size = new System.Drawing.Size(310, 128);
            this.rtbNapomena.TabIndex = 37;
            this.rtbNapomena.Text = "";
            // 
            // lblVaucer
            // 
            this.lblVaucer.AutoSize = true;
            this.lblVaucer.BackColor = System.Drawing.Color.Transparent;
            this.lblVaucer.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVaucer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblVaucer.Location = new System.Drawing.Point(848, 275);
            this.lblVaucer.Name = "lblVaucer";
            this.lblVaucer.Size = new System.Drawing.Size(58, 20);
            this.lblVaucer.TabIndex = 35;
            this.lblVaucer.Text = "Vaučer";
            // 
            // cbVaucer
            // 
            this.cbVaucer.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVaucer.FormattingEnabled = true;
            this.cbVaucer.Location = new System.Drawing.Point(976, 272);
            this.cbVaucer.Name = "cbVaucer";
            this.cbVaucer.Size = new System.Drawing.Size(310, 28);
            this.cbVaucer.TabIndex = 34;
            // 
            // lblNapomena
            // 
            this.lblNapomena.AutoSize = true;
            this.lblNapomena.BackColor = System.Drawing.Color.Transparent;
            this.lblNapomena.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNapomena.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNapomena.Location = new System.Drawing.Point(848, 120);
            this.lblNapomena.Name = "lblNapomena";
            this.lblNapomena.Size = new System.Drawing.Size(86, 20);
            this.lblNapomena.TabIndex = 33;
            this.lblNapomena.Text = "Napomena";
            // 
            // dtpDatum
            // 
            this.dtpDatum.CustomFormat = "";
            this.dtpDatum.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(371, 228);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(150, 27);
            this.dtpDatum.TabIndex = 31;
            this.dtpDatum.Value = new System.DateTime(2024, 7, 4, 0, 0, 0, 0);
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.BackColor = System.Drawing.Color.Transparent;
            this.lblDatum.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDatum.Location = new System.Drawing.Point(274, 233);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(57, 20);
            this.lblDatum.TabIndex = 30;
            this.lblDatum.Text = "Datum";
            // 
            // lblUsluga
            // 
            this.lblUsluga.AutoSize = true;
            this.lblUsluga.BackColor = System.Drawing.Color.Transparent;
            this.lblUsluga.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsluga.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUsluga.Location = new System.Drawing.Point(274, 174);
            this.lblUsluga.Name = "lblUsluga";
            this.lblUsluga.Size = new System.Drawing.Size(57, 20);
            this.lblUsluga.TabIndex = 29;
            this.lblUsluga.Text = "Usluga";
            // 
            // cbUsluga
            // 
            this.cbUsluga.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUsluga.FormattingEnabled = true;
            this.cbUsluga.Location = new System.Drawing.Point(371, 171);
            this.cbUsluga.Name = "cbUsluga";
            this.cbUsluga.Size = new System.Drawing.Size(411, 28);
            this.cbUsluga.TabIndex = 28;
            // 
            // lblKlijent
            // 
            this.lblKlijent.AutoSize = true;
            this.lblKlijent.BackColor = System.Drawing.Color.Transparent;
            this.lblKlijent.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKlijent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblKlijent.Location = new System.Drawing.Point(274, 122);
            this.lblKlijent.Name = "lblKlijent";
            this.lblKlijent.Size = new System.Drawing.Size(58, 20);
            this.lblKlijent.TabIndex = 27;
            this.lblKlijent.Text = "Klijent";
            // 
            // cbKlijent
            // 
            this.cbKlijent.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKlijent.FormattingEnabled = true;
            this.cbKlijent.Location = new System.Drawing.Point(371, 119);
            this.cbKlijent.Name = "cbKlijent";
            this.cbKlijent.Size = new System.Drawing.Size(411, 28);
            this.cbKlijent.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(614, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 36);
            this.label1.TabIndex = 45;
            this.label1.Text = "UNOS NOVOG TERMINA";
            // 
            // btnObavestiKlijenta
            // 
            this.btnObavestiKlijenta.BackColor = System.Drawing.Color.SkyBlue;
            this.btnObavestiKlijenta.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObavestiKlijenta.Location = new System.Drawing.Point(278, 621);
            this.btnObavestiKlijenta.Name = "btnObavestiKlijenta";
            this.btnObavestiKlijenta.Size = new System.Drawing.Size(243, 37);
            this.btnObavestiKlijenta.TabIndex = 46;
            this.btnObavestiKlijenta.Text = "Obavesti putem emaila";
            this.btnObavestiKlijenta.UseVisualStyleBackColor = false;
            this.btnObavestiKlijenta.Click += new System.EventHandler(this.btnObavestiKlijenta_Click);
            // 
            // btnKalendar
            // 
            this.btnKalendar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnKalendar.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKalendar.Location = new System.Drawing.Point(278, 337);
            this.btnKalendar.Name = "btnKalendar";
            this.btnKalendar.Size = new System.Drawing.Size(151, 37);
            this.btnKalendar.TabIndex = 47;
            this.btnKalendar.Text = "Kalendar";
            this.btnKalendar.UseVisualStyleBackColor = false;
            this.btnKalendar.Click += new System.EventHandler(this.btnKalendar_Click);
            // 
            // dgvTermini
            // 
            this.dgvTermini.AllowUserToAddRows = false;
            this.dgvTermini.AllowUserToDeleteRows = false;
            this.dgvTermini.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTermini.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTermini.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgvTermini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTermini.Location = new System.Drawing.Point(278, 390);
            this.dgvTermini.MultiSelect = false;
            this.dgvTermini.Name = "dgvTermini";
            this.dgvTermini.ReadOnly = true;
            this.dgvTermini.RowHeadersWidth = 51;
            this.dgvTermini.RowTemplate.Height = 24;
            this.dgvTermini.Size = new System.Drawing.Size(1008, 215);
            this.dgvTermini.TabIndex = 25;
            // 
            // UCDodajTermine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnKalendar);
            this.Controls.Add(this.btnObavestiKlijenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDveTacke);
            this.Controls.Add(this.txtMinuti);
            this.Controls.Add(this.lblVreme);
            this.Controls.Add(this.txtSati);
            this.Controls.Add(this.btnSacuvajTermine);
            this.Controls.Add(this.btnObrisiTermin);
            this.Controls.Add(this.btnDodajTermin);
            this.Controls.Add(this.rtbNapomena);
            this.Controls.Add(this.lblVaucer);
            this.Controls.Add(this.cbVaucer);
            this.Controls.Add(this.lblNapomena);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblUsluga);
            this.Controls.Add(this.cbUsluga);
            this.Controls.Add(this.lblKlijent);
            this.Controls.Add(this.cbKlijent);
            this.Controls.Add(this.dgvTermini);
            this.DoubleBuffered = true;
            this.Name = "UCDodajTermine";
            this.Size = new System.Drawing.Size(1561, 774);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDveTacke;
        private System.Windows.Forms.TextBox txtMinuti;
        private System.Windows.Forms.Label lblVreme;
        private System.Windows.Forms.TextBox txtSati;
        private System.Windows.Forms.Button btnSacuvajTermine;
        private System.Windows.Forms.Button btnObrisiTermin;
        private System.Windows.Forms.Button btnDodajTermin;
        private System.Windows.Forms.RichTextBox rtbNapomena;
        private System.Windows.Forms.Label lblVaucer;
        private System.Windows.Forms.ComboBox cbVaucer;
        private System.Windows.Forms.Label lblNapomena;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblUsluga;
        private System.Windows.Forms.ComboBox cbUsluga;
        private System.Windows.Forms.Label lblKlijent;
        private System.Windows.Forms.ComboBox cbKlijent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnObavestiKlijenta;
        private System.Windows.Forms.Button btnKalendar;
        private System.Windows.Forms.DataGridView dgvTermini;
    }
}
