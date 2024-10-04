namespace Client.UserControls
{
    partial class UCIzmeniObrisiKlijenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCIzmeniObrisiKlijenta));
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.dgvKlijenti = new System.Windows.Forms.DataGridView();
            this.txtImePrezimeKriterijum = new System.Windows.Forms.TextBox();
            this.chbImePrezimeKriterijum = new System.Windows.Forms.CheckBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblBrojTermina = new System.Windows.Forms.Label();
            this.txtBrojTermina = new System.Windows.Forms.TextBox();
            this.cbTipKlijenta = new System.Windows.Forms.ComboBox();
            this.lblTipKlijenta = new System.Windows.Forms.Label();
            this.lblBrojTelefona = new System.Windows.Forms.Label();
            this.lblStarost = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.txtBrojTelefona = new System.Windows.Forms.TextBox();
            this.txtStarost = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.gbDetalji = new System.Windows.Forms.GroupBox();
            this.lblNaslov = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijenti)).BeginInit();
            this.gbDetalji.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.SkyBlue;
            this.btnObrisi.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.btnObrisi.Location = new System.Drawing.Point(456, 595);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(169, 38);
            this.btnObrisi.TabIndex = 13;
            this.btnObrisi.Text = "Obriši klijenta";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.BackColor = System.Drawing.Color.SkyBlue;
            this.btnIzmeni.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.btnIzmeni.Location = new System.Drawing.Point(948, 595);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(211, 38);
            this.btnIzmeni.TabIndex = 12;
            this.btnIzmeni.Text = "Izmeni klijenta";
            this.btnIzmeni.UseVisualStyleBackColor = false;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackColor = System.Drawing.Color.SkyBlue;
            this.btnPretrazi.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.btnPretrazi.Location = new System.Drawing.Point(456, 274);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(174, 38);
            this.btnPretrazi.TabIndex = 11;
            this.btnPretrazi.Text = "Pretraži klijente";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // dgvKlijenti
            // 
            this.dgvKlijenti.AllowUserToAddRows = false;
            this.dgvKlijenti.AllowUserToDeleteRows = false;
            this.dgvKlijenti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKlijenti.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgvKlijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKlijenti.Location = new System.Drawing.Point(206, 340);
            this.dgvKlijenti.MultiSelect = false;
            this.dgvKlijenti.Name = "dgvKlijenti";
            this.dgvKlijenti.ReadOnly = true;
            this.dgvKlijenti.RowHeadersWidth = 51;
            this.dgvKlijenti.RowTemplate.Height = 24;
            this.dgvKlijenti.Size = new System.Drawing.Size(488, 229);
            this.dgvKlijenti.TabIndex = 10;
            this.dgvKlijenti.SelectionChanged += new System.EventHandler(this.dgvKlijenti_SelectionChanged);
            // 
            // txtImePrezimeKriterijum
            // 
            this.txtImePrezimeKriterijum.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.txtImePrezimeKriterijum.Location = new System.Drawing.Point(456, 219);
            this.txtImePrezimeKriterijum.Name = "txtImePrezimeKriterijum";
            this.txtImePrezimeKriterijum.Size = new System.Drawing.Size(174, 27);
            this.txtImePrezimeKriterijum.TabIndex = 9;
            // 
            // chbImePrezimeKriterijum
            // 
            this.chbImePrezimeKriterijum.AutoSize = true;
            this.chbImePrezimeKriterijum.BackColor = System.Drawing.Color.Transparent;
            this.chbImePrezimeKriterijum.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.chbImePrezimeKriterijum.Location = new System.Drawing.Point(304, 221);
            this.chbImePrezimeKriterijum.Name = "chbImePrezimeKriterijum";
            this.chbImePrezimeKriterijum.Size = new System.Drawing.Size(131, 24);
            this.chbImePrezimeKriterijum.TabIndex = 8;
            this.chbImePrezimeKriterijum.Text = "Ime i prezime";
            this.chbImePrezimeKriterijum.UseVisualStyleBackColor = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.lblEmail.Location = new System.Drawing.Point(58, 296);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 20);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(204, 293);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(211, 27);
            this.txtEmail.TabIndex = 17;
            // 
            // lblBrojTermina
            // 
            this.lblBrojTermina.AutoSize = true;
            this.lblBrojTermina.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.lblBrojTermina.Location = new System.Drawing.Point(58, 403);
            this.lblBrojTermina.Name = "lblBrojTermina";
            this.lblBrojTermina.Size = new System.Drawing.Size(101, 20);
            this.lblBrojTermina.TabIndex = 16;
            this.lblBrojTermina.Text = "Broj termina";
            // 
            // txtBrojTermina
            // 
            this.txtBrojTermina.Enabled = false;
            this.txtBrojTermina.Location = new System.Drawing.Point(204, 400);
            this.txtBrojTermina.Name = "txtBrojTermina";
            this.txtBrojTermina.Size = new System.Drawing.Size(211, 27);
            this.txtBrojTermina.TabIndex = 15;
            // 
            // cbTipKlijenta
            // 
            this.cbTipKlijenta.FormattingEnabled = true;
            this.cbTipKlijenta.Location = new System.Drawing.Point(204, 344);
            this.cbTipKlijenta.Name = "cbTipKlijenta";
            this.cbTipKlijenta.Size = new System.Drawing.Size(211, 28);
            this.cbTipKlijenta.TabIndex = 14;
            // 
            // lblTipKlijenta
            // 
            this.lblTipKlijenta.AutoSize = true;
            this.lblTipKlijenta.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.lblTipKlijenta.Location = new System.Drawing.Point(58, 347);
            this.lblTipKlijenta.Name = "lblTipKlijenta";
            this.lblTipKlijenta.Size = new System.Drawing.Size(92, 20);
            this.lblTipKlijenta.TabIndex = 11;
            this.lblTipKlijenta.Text = "Tip klijenta";
            // 
            // lblBrojTelefona
            // 
            this.lblBrojTelefona.AutoSize = true;
            this.lblBrojTelefona.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.lblBrojTelefona.Location = new System.Drawing.Point(58, 239);
            this.lblBrojTelefona.Name = "lblBrojTelefona";
            this.lblBrojTelefona.Size = new System.Drawing.Size(102, 20);
            this.lblBrojTelefona.TabIndex = 10;
            this.lblBrojTelefona.Text = "Broj telefona";
            // 
            // lblStarost
            // 
            this.lblStarost.AutoSize = true;
            this.lblStarost.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.lblStarost.Location = new System.Drawing.Point(58, 179);
            this.lblStarost.Name = "lblStarost";
            this.lblStarost.Size = new System.Drawing.Size(60, 20);
            this.lblStarost.TabIndex = 9;
            this.lblStarost.Text = "Starost";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.lblPrezime.Location = new System.Drawing.Point(58, 124);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(69, 20);
            this.lblPrezime.TabIndex = 8;
            this.lblPrezime.Text = "Prezime";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.lblIme.Location = new System.Drawing.Point(58, 73);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(37, 20);
            this.lblIme.TabIndex = 7;
            this.lblIme.Text = "Ime";
            // 
            // txtBrojTelefona
            // 
            this.txtBrojTelefona.Location = new System.Drawing.Point(204, 236);
            this.txtBrojTelefona.Name = "txtBrojTelefona";
            this.txtBrojTelefona.Size = new System.Drawing.Size(211, 27);
            this.txtBrojTelefona.TabIndex = 5;
            // 
            // txtStarost
            // 
            this.txtStarost.Location = new System.Drawing.Point(204, 176);
            this.txtStarost.Name = "txtStarost";
            this.txtStarost.Size = new System.Drawing.Size(211, 27);
            this.txtStarost.TabIndex = 4;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(204, 121);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(211, 27);
            this.txtPrezime.TabIndex = 3;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(204, 70);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(211, 27);
            this.txtIme.TabIndex = 2;
            // 
            // gbDetalji
            // 
            this.gbDetalji.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.gbDetalji.BackColor = System.Drawing.Color.Transparent;
            this.gbDetalji.Controls.Add(this.lblEmail);
            this.gbDetalji.Controls.Add(this.txtEmail);
            this.gbDetalji.Controls.Add(this.lblBrojTermina);
            this.gbDetalji.Controls.Add(this.txtBrojTermina);
            this.gbDetalji.Controls.Add(this.cbTipKlijenta);
            this.gbDetalji.Controls.Add(this.lblTipKlijenta);
            this.gbDetalji.Controls.Add(this.lblBrojTelefona);
            this.gbDetalji.Controls.Add(this.lblStarost);
            this.gbDetalji.Controls.Add(this.lblPrezime);
            this.gbDetalji.Controls.Add(this.lblIme);
            this.gbDetalji.Controls.Add(this.txtBrojTelefona);
            this.gbDetalji.Controls.Add(this.txtStarost);
            this.gbDetalji.Controls.Add(this.txtPrezime);
            this.gbDetalji.Controls.Add(this.txtIme);
            this.gbDetalji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbDetalji.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.gbDetalji.Location = new System.Drawing.Point(744, 142);
            this.gbDetalji.Name = "gbDetalji";
            this.gbDetalji.Size = new System.Drawing.Size(513, 447);
            this.gbDetalji.TabIndex = 14;
            this.gbDetalji.TabStop = false;
            this.gbDetalji.Text = "Detalji";
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.BackColor = System.Drawing.Color.Transparent;
            this.lblNaslov.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.Location = new System.Drawing.Point(620, 61);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(321, 36);
            this.lblNaslov.TabIndex = 57;
            this.lblNaslov.Text = "PRETRAGA KLIJENATA";
            // 
            // UCIzmeniObrisiKlijenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.dgvKlijenti);
            this.Controls.Add(this.txtImePrezimeKriterijum);
            this.Controls.Add(this.chbImePrezimeKriterijum);
            this.Controls.Add(this.gbDetalji);
            this.DoubleBuffered = true;
            this.Name = "UCIzmeniObrisiKlijenta";
            this.Size = new System.Drawing.Size(1561, 774);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijenti)).EndInit();
            this.gbDetalji.ResumeLayout(false);
            this.gbDetalji.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.DataGridView dgvKlijenti;
        private System.Windows.Forms.TextBox txtImePrezimeKriterijum;
        private System.Windows.Forms.CheckBox chbImePrezimeKriterijum;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblBrojTermina;
        private System.Windows.Forms.TextBox txtBrojTermina;
        private System.Windows.Forms.ComboBox cbTipKlijenta;
        private System.Windows.Forms.Label lblTipKlijenta;
        private System.Windows.Forms.Label lblBrojTelefona;
        private System.Windows.Forms.Label lblStarost;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtBrojTelefona;
        private System.Windows.Forms.TextBox txtStarost;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.GroupBox gbDetalji;
        private System.Windows.Forms.Label lblNaslov;
    }
}
