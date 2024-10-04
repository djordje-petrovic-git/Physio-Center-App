namespace Client.UserControls
{
    partial class UCObrisiUslugu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCObrisiUslugu));
            this.chbNaziv = new System.Windows.Forms.CheckBox();
            this.chbVrsta = new System.Windows.Forms.CheckBox();
            this.txtNazivKriterijuma = new System.Windows.Forms.TextBox();
            this.cbVrstaKriterijuma = new System.Windows.Forms.ComboBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.dgvUsluge = new System.Windows.Forms.DataGridView();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.gbDetalji = new System.Windows.Forms.GroupBox();
            this.dgvNapomene = new System.Windows.Forms.DataGridView();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.txtTrajanje = new System.Windows.Forms.TextBox();
            this.txtUkupnoTermina = new System.Windows.Forms.TextBox();
            this.txtVrsta = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNaslov = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsluge)).BeginInit();
            this.gbDetalji.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNapomene)).BeginInit();
            this.SuspendLayout();
            // 
            // chbNaziv
            // 
            this.chbNaziv.AutoSize = true;
            this.chbNaziv.BackColor = System.Drawing.Color.Transparent;
            this.chbNaziv.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbNaziv.Location = new System.Drawing.Point(59, 89);
            this.chbNaziv.Name = "chbNaziv";
            this.chbNaziv.Size = new System.Drawing.Size(123, 24);
            this.chbNaziv.TabIndex = 0;
            this.chbNaziv.Text = "Naziv usluge";
            this.chbNaziv.UseVisualStyleBackColor = false;
            // 
            // chbVrsta
            // 
            this.chbVrsta.AutoSize = true;
            this.chbVrsta.BackColor = System.Drawing.Color.Transparent;
            this.chbVrsta.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbVrsta.Location = new System.Drawing.Point(59, 130);
            this.chbVrsta.Name = "chbVrsta";
            this.chbVrsta.Size = new System.Drawing.Size(118, 24);
            this.chbVrsta.TabIndex = 1;
            this.chbVrsta.Text = "Vrsta usluge";
            this.chbVrsta.UseVisualStyleBackColor = false;
            // 
            // txtNazivKriterijuma
            // 
            this.txtNazivKriterijuma.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.txtNazivKriterijuma.Location = new System.Drawing.Point(218, 87);
            this.txtNazivKriterijuma.Name = "txtNazivKriterijuma";
            this.txtNazivKriterijuma.Size = new System.Drawing.Size(248, 27);
            this.txtNazivKriterijuma.TabIndex = 2;
            // 
            // cbVrstaKriterijuma
            // 
            this.cbVrstaKriterijuma.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.cbVrstaKriterijuma.FormattingEnabled = true;
            this.cbVrstaKriterijuma.Location = new System.Drawing.Point(218, 128);
            this.cbVrstaKriterijuma.Name = "cbVrstaKriterijuma";
            this.cbVrstaKriterijuma.Size = new System.Drawing.Size(248, 28);
            this.cbVrstaKriterijuma.TabIndex = 3;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackColor = System.Drawing.Color.SkyBlue;
            this.btnPretrazi.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretrazi.Location = new System.Drawing.Point(561, 105);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(161, 35);
            this.btnPretrazi.TabIndex = 4;
            this.btnPretrazi.Text = "Pretrazi uslugu";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // dgvUsluge
            // 
            this.dgvUsluge.AllowUserToAddRows = false;
            this.dgvUsluge.AllowUserToDeleteRows = false;
            this.dgvUsluge.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsluge.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgvUsluge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsluge.Location = new System.Drawing.Point(59, 188);
            this.dgvUsluge.Name = "dgvUsluge";
            this.dgvUsluge.RowHeadersWidth = 51;
            this.dgvUsluge.RowTemplate.Height = 24;
            this.dgvUsluge.Size = new System.Drawing.Size(663, 385);
            this.dgvUsluge.TabIndex = 5;
            this.dgvUsluge.SelectionChanged += new System.EventHandler(this.dgvUsluge_SelectionChanged);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.SkyBlue;
            this.btnObrisi.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Location = new System.Drawing.Point(561, 590);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(161, 36);
            this.btnObrisi.TabIndex = 6;
            this.btnObrisi.Text = "Obrisi uslugu";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // gbDetalji
            // 
            this.gbDetalji.BackColor = System.Drawing.Color.Transparent;
            this.gbDetalji.Controls.Add(this.dgvNapomene);
            this.gbDetalji.Controls.Add(this.txtCena);
            this.gbDetalji.Controls.Add(this.txtTrajanje);
            this.gbDetalji.Controls.Add(this.txtUkupnoTermina);
            this.gbDetalji.Controls.Add(this.txtVrsta);
            this.gbDetalji.Controls.Add(this.txtNaziv);
            this.gbDetalji.Controls.Add(this.label5);
            this.gbDetalji.Controls.Add(this.label4);
            this.gbDetalji.Controls.Add(this.label3);
            this.gbDetalji.Controls.Add(this.label2);
            this.gbDetalji.Controls.Add(this.label1);
            this.gbDetalji.Enabled = false;
            this.gbDetalji.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.gbDetalji.Location = new System.Drawing.Point(781, 134);
            this.gbDetalji.Name = "gbDetalji";
            this.gbDetalji.Size = new System.Drawing.Size(721, 475);
            this.gbDetalji.TabIndex = 7;
            this.gbDetalji.TabStop = false;
            this.gbDetalji.Text = "Detalji";
            // 
            // dgvNapomene
            // 
            this.dgvNapomene.AllowUserToAddRows = false;
            this.dgvNapomene.AllowUserToDeleteRows = false;
            this.dgvNapomene.AllowUserToOrderColumns = true;
            this.dgvNapomene.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNapomene.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgvNapomene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNapomene.Location = new System.Drawing.Point(45, 243);
            this.dgvNapomene.Name = "dgvNapomene";
            this.dgvNapomene.RowHeadersWidth = 51;
            this.dgvNapomene.RowTemplate.Height = 24;
            this.dgvNapomene.Size = new System.Drawing.Size(656, 195);
            this.dgvNapomene.TabIndex = 10;
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(240, 201);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(96, 27);
            this.txtCena.TabIndex = 9;
            // 
            // txtTrajanje
            // 
            this.txtTrajanje.Location = new System.Drawing.Point(240, 164);
            this.txtTrajanje.Name = "txtTrajanje";
            this.txtTrajanje.Size = new System.Drawing.Size(96, 27);
            this.txtTrajanje.TabIndex = 8;
            // 
            // txtUkupnoTermina
            // 
            this.txtUkupnoTermina.Location = new System.Drawing.Point(240, 127);
            this.txtUkupnoTermina.Name = "txtUkupnoTermina";
            this.txtUkupnoTermina.Size = new System.Drawing.Size(96, 27);
            this.txtUkupnoTermina.TabIndex = 7;
            // 
            // txtVrsta
            // 
            this.txtVrsta.Location = new System.Drawing.Point(240, 89);
            this.txtVrsta.Name = "txtVrsta";
            this.txtVrsta.Size = new System.Drawing.Size(243, 27);
            this.txtVrsta.TabIndex = 6;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(240, 52);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(243, 27);
            this.txtNaziv.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ukupan broj termina";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vrsta usluge";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trajanje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cena";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.BackColor = System.Drawing.Color.Transparent;
            this.lblNaslov.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.Location = new System.Drawing.Point(585, 24);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(390, 36);
            this.lblNaslov.TabIndex = 58;
            this.lblNaslov.Text = "INFORMACIJE O USLUGAMA";
            // 
            // UCObrisiUslugu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.gbDetalji);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.dgvUsluge);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.cbVrstaKriterijuma);
            this.Controls.Add(this.txtNazivKriterijuma);
            this.Controls.Add(this.chbVrsta);
            this.Controls.Add(this.chbNaziv);
            this.DoubleBuffered = true;
            this.Name = "UCObrisiUslugu";
            this.Size = new System.Drawing.Size(1561, 708);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsluge)).EndInit();
            this.gbDetalji.ResumeLayout(false);
            this.gbDetalji.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNapomene)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbNaziv;
        private System.Windows.Forms.CheckBox chbVrsta;
        private System.Windows.Forms.TextBox txtNazivKriterijuma;
        private System.Windows.Forms.ComboBox cbVrstaKriterijuma;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.DataGridView dgvUsluge;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.GroupBox gbDetalji;
        private System.Windows.Forms.DataGridView dgvNapomene;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.TextBox txtTrajanje;
        private System.Windows.Forms.TextBox txtUkupnoTermina;
        private System.Windows.Forms.TextBox txtVrsta;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNaslov;
    }
}
