namespace Client.UserControls
{
    partial class UCDodajUslugu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCDodajUslugu));
            this.button1 = new System.Windows.Forms.Button();
            this.btnObrisiNapomenu = new System.Windows.Forms.Button();
            this.btnDodajNapomenu = new System.Windows.Forms.Button();
            this.cbVrstaUsluge = new System.Windows.Forms.ComboBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.txtTrajanje = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.unboundSource1 = new DevExpress.Data.UnboundSource(this.components);
            this.dgvNapomene = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.unboundSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNapomene)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1012, 490);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 39);
            this.button1.TabIndex = 36;
            this.button1.Text = "Sačuvaj uslugu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnSacuvajUslugu_Click);
            // 
            // btnObrisiNapomenu
            // 
            this.btnObrisiNapomenu.BackColor = System.Drawing.Color.SkyBlue;
            this.btnObrisiNapomenu.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiNapomenu.Location = new System.Drawing.Point(1012, 446);
            this.btnObrisiNapomenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnObrisiNapomenu.Name = "btnObrisiNapomenu";
            this.btnObrisiNapomenu.Size = new System.Drawing.Size(275, 39);
            this.btnObrisiNapomenu.TabIndex = 35;
            this.btnObrisiNapomenu.Text = "Obriši napomenu za uslugu";
            this.btnObrisiNapomenu.UseVisualStyleBackColor = false;
            this.btnObrisiNapomenu.Click += new System.EventHandler(this.btnObrisiNapomenu_Click);
            // 
            // btnDodajNapomenu
            // 
            this.btnDodajNapomenu.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDodajNapomenu.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajNapomenu.Location = new System.Drawing.Point(707, 446);
            this.btnDodajNapomenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodajNapomenu.Name = "btnDodajNapomenu";
            this.btnDodajNapomenu.Size = new System.Drawing.Size(275, 39);
            this.btnDodajNapomenu.TabIndex = 34;
            this.btnDodajNapomenu.Text = "Dodaj napomenu za uslugu";
            this.btnDodajNapomenu.UseVisualStyleBackColor = false;
            this.btnDodajNapomenu.Click += new System.EventHandler(this.btnDodajNapomenu_Click);
            // 
            // cbVrstaUsluge
            // 
            this.cbVrstaUsluge.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVrstaUsluge.FormattingEnabled = true;
            this.cbVrstaUsluge.Location = new System.Drawing.Point(397, 270);
            this.cbVrstaUsluge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbVrstaUsluge.Name = "cbVrstaUsluge";
            this.cbVrstaUsluge.Size = new System.Drawing.Size(273, 28);
            this.cbVrstaUsluge.TabIndex = 33;
            // 
            // txtCena
            // 
            this.txtCena.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCena.Location = new System.Drawing.Point(397, 393);
            this.txtCena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(273, 27);
            this.txtCena.TabIndex = 32;
            // 
            // txtTrajanje
            // 
            this.txtTrajanje.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrajanje.Location = new System.Drawing.Point(397, 338);
            this.txtTrajanje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTrajanje.Name = "txtTrajanje";
            this.txtTrajanje.Size = new System.Drawing.Size(273, 27);
            this.txtTrajanje.TabIndex = 31;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaziv.Location = new System.Drawing.Point(397, 206);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(273, 27);
            this.txtNaziv.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(275, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Vrsta usluge";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(275, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Trajanje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(275, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Cena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(275, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Naziv";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(637, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 36);
            this.label1.TabIndex = 37;
            this.label1.Text = "UNOS NOVE USLUGE";
            // 
            // dgvNapomene
            // 
            this.dgvNapomene.AllowUserToAddRows = false;
            this.dgvNapomene.AllowUserToDeleteRows = false;
            this.dgvNapomene.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNapomene.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvNapomene.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgvNapomene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNapomene.Location = new System.Drawing.Point(707, 206);
            this.dgvNapomene.MultiSelect = false;
            this.dgvNapomene.Name = "dgvNapomene";
            this.dgvNapomene.ReadOnly = true;
            this.dgvNapomene.RowHeadersWidth = 51;
            this.dgvNapomene.RowTemplate.Height = 24;
            this.dgvNapomene.Size = new System.Drawing.Size(577, 214);
            this.dgvNapomene.TabIndex = 38;
            // 
            // UCDodajUslugu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.dgvNapomene);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnObrisiNapomenu);
            this.Controls.Add(this.btnDodajNapomenu);
            this.Controls.Add(this.cbVrstaUsluge);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.txtTrajanje);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCDodajUslugu";
            this.Size = new System.Drawing.Size(1561, 774);
            ((System.ComponentModel.ISupportInitialize)(this.unboundSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNapomene)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnObrisiNapomenu;
        private System.Windows.Forms.Button btnDodajNapomenu;
        private System.Windows.Forms.ComboBox cbVrstaUsluge;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.TextBox txtTrajanje;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.Data.UnboundSource unboundSource1;
        private System.Windows.Forms.DataGridView dgvNapomene;
    }
}
