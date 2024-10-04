namespace Client.UserControls
{
    partial class UCPretraziObrisiTermin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPretraziObrisiTermin));
            this.lblDveTacke = new System.Windows.Forms.Label();
            this.txtMinuti = new System.Windows.Forms.TextBox();
            this.lblVreme = new System.Windows.Forms.Label();
            this.txtSati = new System.Windows.Forms.TextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
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
            this.dgvTermini = new System.Windows.Forms.DataGridView();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.chbKlijentKriterijum = new System.Windows.Forms.CheckBox();
            this.chbDatumVremeKriterijum = new System.Windows.Forms.CheckBox();
            this.cbKlijentKriterijum = new System.Windows.Forms.ComboBox();
            this.dtpDatumKriterijum = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMinutiKriterijum = new System.Windows.Forms.TextBox();
            this.txtSatiKriterijum = new System.Windows.Forms.TextBox();
            this.gbDetalji = new System.Windows.Forms.GroupBox();
            this.btnObrisiTermin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).BeginInit();
            this.gbDetalji.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDveTacke
            // 
            this.lblDveTacke.AutoSize = true;
            this.lblDveTacke.BackColor = System.Drawing.Color.Transparent;
            this.lblDveTacke.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.lblDveTacke.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDveTacke.Location = new System.Drawing.Point(171, 179);
            this.lblDveTacke.Name = "lblDveTacke";
            this.lblDveTacke.Size = new System.Drawing.Size(13, 20);
            this.lblDveTacke.TabIndex = 44;
            this.lblDveTacke.Text = ":";
            // 
            // txtMinuti
            // 
            this.txtMinuti.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.txtMinuti.Location = new System.Drawing.Point(192, 176);
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
            this.lblVreme.Location = new System.Drawing.Point(20, 180);
            this.lblVreme.Name = "lblVreme";
            this.lblVreme.Size = new System.Drawing.Size(55, 20);
            this.lblVreme.TabIndex = 42;
            this.lblVreme.Text = "Vreme";
            // 
            // txtSati
            // 
            this.txtSati.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.txtSati.Location = new System.Drawing.Point(122, 176);
            this.txtSati.Name = "txtSati";
            this.txtSati.Size = new System.Drawing.Size(43, 27);
            this.txtSati.TabIndex = 41;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackColor = System.Drawing.Color.SkyBlue;
            this.btnPretrazi.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.btnPretrazi.Location = new System.Drawing.Point(1216, 106);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(190, 37);
            this.btnPretrazi.TabIndex = 58;
            this.btnPretrazi.Text = "Pretraži termine";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click_1);
            // 
            // rtbNapomena
            // 
            this.rtbNapomena.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.rtbNapomena.Location = new System.Drawing.Point(799, 46);
            this.rtbNapomena.Name = "rtbNapomena";
            this.rtbNapomena.Size = new System.Drawing.Size(418, 129);
            this.rtbNapomena.TabIndex = 38;
            this.rtbNapomena.Text = "";
            // 
            // lblVaucer
            // 
            this.lblVaucer.AutoSize = true;
            this.lblVaucer.BackColor = System.Drawing.Color.Transparent;
            this.lblVaucer.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVaucer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblVaucer.Location = new System.Drawing.Point(20, 224);
            this.lblVaucer.Name = "lblVaucer";
            this.lblVaucer.Size = new System.Drawing.Size(58, 20);
            this.lblVaucer.TabIndex = 36;
            this.lblVaucer.Text = "Vaučer";
            // 
            // cbVaucer
            // 
            this.cbVaucer.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.cbVaucer.FormattingEnabled = true;
            this.cbVaucer.Location = new System.Drawing.Point(121, 221);
            this.cbVaucer.Name = "cbVaucer";
            this.cbVaucer.Size = new System.Drawing.Size(472, 28);
            this.cbVaucer.TabIndex = 35;
            // 
            // lblNapomena
            // 
            this.lblNapomena.AutoSize = true;
            this.lblNapomena.BackColor = System.Drawing.Color.Transparent;
            this.lblNapomena.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNapomena.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNapomena.Location = new System.Drawing.Point(654, 49);
            this.lblNapomena.Name = "lblNapomena";
            this.lblNapomena.Size = new System.Drawing.Size(86, 20);
            this.lblNapomena.TabIndex = 34;
            this.lblNapomena.Text = "Napomena";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(121, 135);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(150, 27);
            this.dtpDatum.TabIndex = 32;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.BackColor = System.Drawing.Color.Transparent;
            this.lblDatum.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDatum.Location = new System.Drawing.Point(20, 140);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(57, 20);
            this.lblDatum.TabIndex = 31;
            this.lblDatum.Text = "Datum";
            // 
            // lblUsluga
            // 
            this.lblUsluga.AutoSize = true;
            this.lblUsluga.BackColor = System.Drawing.Color.Transparent;
            this.lblUsluga.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsluga.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUsluga.Location = new System.Drawing.Point(20, 98);
            this.lblUsluga.Name = "lblUsluga";
            this.lblUsluga.Size = new System.Drawing.Size(57, 20);
            this.lblUsluga.TabIndex = 30;
            this.lblUsluga.Text = "Usluga";
            // 
            // cbUsluga
            // 
            this.cbUsluga.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.cbUsluga.FormattingEnabled = true;
            this.cbUsluga.Location = new System.Drawing.Point(122, 95);
            this.cbUsluga.Name = "cbUsluga";
            this.cbUsluga.Size = new System.Drawing.Size(472, 28);
            this.cbUsluga.TabIndex = 29;
            // 
            // lblKlijent
            // 
            this.lblKlijent.AutoSize = true;
            this.lblKlijent.BackColor = System.Drawing.Color.Transparent;
            this.lblKlijent.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKlijent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblKlijent.Location = new System.Drawing.Point(20, 54);
            this.lblKlijent.Name = "lblKlijent";
            this.lblKlijent.Size = new System.Drawing.Size(58, 20);
            this.lblKlijent.TabIndex = 28;
            this.lblKlijent.Text = "Klijent";
            // 
            // cbKlijent
            // 
            this.cbKlijent.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.cbKlijent.FormattingEnabled = true;
            this.cbKlijent.Location = new System.Drawing.Point(122, 51);
            this.cbKlijent.Name = "cbKlijent";
            this.cbKlijent.Size = new System.Drawing.Size(472, 28);
            this.cbKlijent.TabIndex = 27;
            // 
            // dgvTermini
            // 
            this.dgvTermini.AllowUserToAddRows = false;
            this.dgvTermini.AllowUserToDeleteRows = false;
            this.dgvTermini.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTermini.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgvTermini.ColumnHeadersHeight = 29;
            this.dgvTermini.Location = new System.Drawing.Point(154, 152);
            this.dgvTermini.Name = "dgvTermini";
            this.dgvTermini.RowHeadersWidth = 51;
            this.dgvTermini.Size = new System.Drawing.Size(1252, 126);
            this.dgvTermini.TabIndex = 70;
            this.dgvTermini.SelectionChanged += new System.EventHandler(this.dgvTermini_SelectionChanged);
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.BackColor = System.Drawing.Color.Transparent;
            this.lblNaslov.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.Location = new System.Drawing.Point(550, 24);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(460, 36);
            this.lblNaslov.TabIndex = 56;
            this.lblNaslov.Text = "PRETRAGA I BRISANJE TERMINA";
            // 
            // chbKlijentKriterijum
            // 
            this.chbKlijentKriterijum.AutoSize = true;
            this.chbKlijentKriterijum.BackColor = System.Drawing.Color.Transparent;
            this.chbKlijentKriterijum.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.chbKlijentKriterijum.Location = new System.Drawing.Point(476, 111);
            this.chbKlijentKriterijum.Name = "chbKlijentKriterijum";
            this.chbKlijentKriterijum.Size = new System.Drawing.Size(80, 24);
            this.chbKlijentKriterijum.TabIndex = 60;
            this.chbKlijentKriterijum.Text = "Klijent";
            this.chbKlijentKriterijum.UseVisualStyleBackColor = false;
            // 
            // chbDatumVremeKriterijum
            // 
            this.chbDatumVremeKriterijum.AutoSize = true;
            this.chbDatumVremeKriterijum.BackColor = System.Drawing.Color.Transparent;
            this.chbDatumVremeKriterijum.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.chbDatumVremeKriterijum.Location = new System.Drawing.Point(990, 110);
            this.chbDatumVremeKriterijum.Name = "chbDatumVremeKriterijum";
            this.chbDatumVremeKriterijum.Size = new System.Drawing.Size(138, 24);
            this.chbDatumVremeKriterijum.TabIndex = 62;
            this.chbDatumVremeKriterijum.Text = "Datum i vreme";
            this.chbDatumVremeKriterijum.UseVisualStyleBackColor = false;
            // 
            // cbKlijentKriterijum
            // 
            this.cbKlijentKriterijum.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.cbKlijentKriterijum.FormattingEnabled = true;
            this.cbKlijentKriterijum.Location = new System.Drawing.Point(154, 109);
            this.cbKlijentKriterijum.Name = "cbKlijentKriterijum";
            this.cbKlijentKriterijum.Size = new System.Drawing.Size(316, 28);
            this.cbKlijentKriterijum.TabIndex = 63;
            // 
            // dtpDatumKriterijum
            // 
            this.dtpDatumKriterijum.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.dtpDatumKriterijum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumKriterijum.Location = new System.Drawing.Point(689, 109);
            this.dtpDatumKriterijum.Name = "dtpDatumKriterijum";
            this.dtpDatumKriterijum.Size = new System.Drawing.Size(162, 27);
            this.dtpDatumKriterijum.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(920, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 20);
            this.label1.TabIndex = 68;
            this.label1.Text = ":";
            // 
            // txtMinutiKriterijum
            // 
            this.txtMinutiKriterijum.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.txtMinutiKriterijum.Location = new System.Drawing.Point(941, 108);
            this.txtMinutiKriterijum.Name = "txtMinutiKriterijum";
            this.txtMinutiKriterijum.Size = new System.Drawing.Size(43, 27);
            this.txtMinutiKriterijum.TabIndex = 67;
            // 
            // txtSatiKriterijum
            // 
            this.txtSatiKriterijum.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.txtSatiKriterijum.Location = new System.Drawing.Point(871, 109);
            this.txtSatiKriterijum.Name = "txtSatiKriterijum";
            this.txtSatiKriterijum.Size = new System.Drawing.Size(43, 27);
            this.txtSatiKriterijum.TabIndex = 66;
            // 
            // gbDetalji
            // 
            this.gbDetalji.BackColor = System.Drawing.Color.Transparent;
            this.gbDetalji.Controls.Add(this.rtbNapomena);
            this.gbDetalji.Controls.Add(this.cbKlijent);
            this.gbDetalji.Controls.Add(this.lblKlijent);
            this.gbDetalji.Controls.Add(this.cbUsluga);
            this.gbDetalji.Controls.Add(this.lblUsluga);
            this.gbDetalji.Controls.Add(this.lblDatum);
            this.gbDetalji.Controls.Add(this.dtpDatum);
            this.gbDetalji.Controls.Add(this.lblNapomena);
            this.gbDetalji.Controls.Add(this.cbVaucer);
            this.gbDetalji.Controls.Add(this.lblDveTacke);
            this.gbDetalji.Controls.Add(this.lblVaucer);
            this.gbDetalji.Controls.Add(this.txtMinuti);
            this.gbDetalji.Controls.Add(this.lblVreme);
            this.gbDetalji.Controls.Add(this.txtSati);
            this.gbDetalji.Enabled = false;
            this.gbDetalji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbDetalji.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetalji.Location = new System.Drawing.Point(154, 304);
            this.gbDetalji.Name = "gbDetalji";
            this.gbDetalji.Size = new System.Drawing.Size(1252, 273);
            this.gbDetalji.TabIndex = 69;
            this.gbDetalji.TabStop = false;
            this.gbDetalji.Text = "Detalji";
            // 
            // btnObrisiTermin
            // 
            this.btnObrisiTermin.BackColor = System.Drawing.Color.SkyBlue;
            this.btnObrisiTermin.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiTermin.Location = new System.Drawing.Point(1216, 593);
            this.btnObrisiTermin.Name = "btnObrisiTermin";
            this.btnObrisiTermin.Size = new System.Drawing.Size(190, 37);
            this.btnObrisiTermin.TabIndex = 71;
            this.btnObrisiTermin.Text = "Obrisi termin";
            this.btnObrisiTermin.UseVisualStyleBackColor = false;
            this.btnObrisiTermin.Click += new System.EventHandler(this.btnObrisiTermin_Click);
            // 
            // UCPretraziObrisiTermin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnObrisiTermin);
            this.Controls.Add(this.gbDetalji);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMinutiKriterijum);
            this.Controls.Add(this.txtSatiKriterijum);
            this.Controls.Add(this.dtpDatumKriterijum);
            this.Controls.Add(this.cbKlijentKriterijum);
            this.Controls.Add(this.chbDatumVremeKriterijum);
            this.Controls.Add(this.chbKlijentKriterijum);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.dgvTermini);
            this.Controls.Add(this.lblNaslov);
            this.DoubleBuffered = true;
            this.Name = "UCPretraziObrisiTermin";
            this.Size = new System.Drawing.Size(1561, 708);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).EndInit();
            this.gbDetalji.ResumeLayout(false);
            this.gbDetalji.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbDetalji;
        private System.Windows.Forms.RichTextBox rtbNapomena;
        private System.Windows.Forms.ComboBox cbKlijent;
        private System.Windows.Forms.Label lblKlijent;
        private System.Windows.Forms.ComboBox cbUsluga;
        private System.Windows.Forms.Label lblUsluga;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label lblNapomena;
        private System.Windows.Forms.ComboBox cbVaucer;
        private System.Windows.Forms.Label lblDveTacke;
        private System.Windows.Forms.Label lblVaucer;
        private System.Windows.Forms.TextBox txtMinuti;
        private System.Windows.Forms.Label lblVreme;
        private System.Windows.Forms.TextBox txtSati;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMinutiKriterijum;
        private System.Windows.Forms.TextBox txtSatiKriterijum;
        private System.Windows.Forms.DateTimePicker dtpDatumKriterijum;
        private System.Windows.Forms.ComboBox cbKlijentKriterijum;
        private System.Windows.Forms.CheckBox chbDatumVremeKriterijum;
        private System.Windows.Forms.CheckBox chbKlijentKriterijum;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.DataGridView dgvTermini;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Button btnObrisiTermin;
    }
}
