namespace Client
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.klijentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosKlijentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmenaBrisanjeKlijentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uslugaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosUslugeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.brisanjeUslugeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.unosNovogTerminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledBrisanjeTerminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosTerminaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaBrisanjeTerminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblPrijavljeniKorisnik = new System.Windows.Forms.Label();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.BackColor = System.Drawing.Color.SkyBlue;
            this.menuMain.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.klijentToolStripMenuItem,
            this.uslugaToolStripMenuItem,
            this.terminiToolStripMenuItem1});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(1543, 28);
            this.menuMain.TabIndex = 1;
            this.menuMain.Text = "menuStrip1";
            // 
            // klijentToolStripMenuItem
            // 
            this.klijentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosKlijentaToolStripMenuItem,
            this.izmenaBrisanjeKlijentaToolStripMenuItem});
            this.klijentToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klijentToolStripMenuItem.Name = "klijentToolStripMenuItem";
            this.klijentToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.klijentToolStripMenuItem.Text = "Klijenti";
            // 
            // unosKlijentaToolStripMenuItem
            // 
            this.unosKlijentaToolStripMenuItem.BackColor = System.Drawing.Color.SkyBlue;
            this.unosKlijentaToolStripMenuItem.Name = "unosKlijentaToolStripMenuItem";
            this.unosKlijentaToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.unosKlijentaToolStripMenuItem.Text = "Unos novog klijenta";
            this.unosKlijentaToolStripMenuItem.Click += new System.EventHandler(this.unosKlijentaToolStripMenuItem_Click);
            // 
            // izmenaBrisanjeKlijentaToolStripMenuItem
            // 
            this.izmenaBrisanjeKlijentaToolStripMenuItem.BackColor = System.Drawing.Color.SkyBlue;
            this.izmenaBrisanjeKlijentaToolStripMenuItem.Name = "izmenaBrisanjeKlijentaToolStripMenuItem";
            this.izmenaBrisanjeKlijentaToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.izmenaBrisanjeKlijentaToolStripMenuItem.Text = "Izmena / Brisanje";
            this.izmenaBrisanjeKlijentaToolStripMenuItem.Click += new System.EventHandler(this.izmenaBrisanjeKlijentaToolStripMenuItem_Click);
            // 
            // uslugaToolStripMenuItem
            // 
            this.uslugaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosUslugeToolStripMenuItem1,
            this.brisanjeUslugeToolStripMenuItem});
            this.uslugaToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uslugaToolStripMenuItem.Name = "uslugaToolStripMenuItem";
            this.uslugaToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.uslugaToolStripMenuItem.Text = "Usluge";
            // 
            // unosUslugeToolStripMenuItem1
            // 
            this.unosUslugeToolStripMenuItem1.BackColor = System.Drawing.Color.SkyBlue;
            this.unosUslugeToolStripMenuItem1.Name = "unosUslugeToolStripMenuItem1";
            this.unosUslugeToolStripMenuItem1.Size = new System.Drawing.Size(272, 26);
            this.unosUslugeToolStripMenuItem1.Text = "Unos nove usluge";
            this.unosUslugeToolStripMenuItem1.Click += new System.EventHandler(this.unosUslugeToolStripMenuItem1_Click);
            // 
            // brisanjeUslugeToolStripMenuItem
            // 
            this.brisanjeUslugeToolStripMenuItem.BackColor = System.Drawing.Color.SkyBlue;
            this.brisanjeUslugeToolStripMenuItem.Name = "brisanjeUslugeToolStripMenuItem";
            this.brisanjeUslugeToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.brisanjeUslugeToolStripMenuItem.Text = "Pregled / Brisanje usluge";
            this.brisanjeUslugeToolStripMenuItem.Click += new System.EventHandler(this.brisanjeUslugeToolStripMenuItem_Click);
            // 
            // terminiToolStripMenuItem1
            // 
            this.terminiToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosNovogTerminaToolStripMenuItem,
            this.pregledBrisanjeTerminaToolStripMenuItem});
            this.terminiToolStripMenuItem1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.terminiToolStripMenuItem1.Name = "terminiToolStripMenuItem1";
            this.terminiToolStripMenuItem1.Size = new System.Drawing.Size(80, 24);
            this.terminiToolStripMenuItem1.Text = "Termini";
            this.terminiToolStripMenuItem1.Click += new System.EventHandler(this.terminiToolStripMenuItem1_Click);
            // 
            // unosNovogTerminaToolStripMenuItem
            // 
            this.unosNovogTerminaToolStripMenuItem.BackColor = System.Drawing.Color.SkyBlue;
            this.unosNovogTerminaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.unosNovogTerminaToolStripMenuItem.Name = "unosNovogTerminaToolStripMenuItem";
            this.unosNovogTerminaToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.unosNovogTerminaToolStripMenuItem.Text = "Unos novog termina";
            this.unosNovogTerminaToolStripMenuItem.Click += new System.EventHandler(this.unosTerminaToolStripMenuItem2_Click);
            // 
            // pregledBrisanjeTerminaToolStripMenuItem
            // 
            this.pregledBrisanjeTerminaToolStripMenuItem.BackColor = System.Drawing.Color.SkyBlue;
            this.pregledBrisanjeTerminaToolStripMenuItem.Name = "pregledBrisanjeTerminaToolStripMenuItem";
            this.pregledBrisanjeTerminaToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.pregledBrisanjeTerminaToolStripMenuItem.Text = "Pregled / Brisanje termina";
            this.pregledBrisanjeTerminaToolStripMenuItem.Click += new System.EventHandler(this.pretragaBrisanjeTerminaToolStripMenuItem_Click);
            // 
            // unosTerminaToolStripMenuItem2
            // 
            this.unosTerminaToolStripMenuItem2.BackColor = System.Drawing.Color.SkyBlue;
            this.unosTerminaToolStripMenuItem2.Name = "unosTerminaToolStripMenuItem2";
            this.unosTerminaToolStripMenuItem2.Size = new System.Drawing.Size(290, 26);
            this.unosTerminaToolStripMenuItem2.Text = "Unos";
            this.unosTerminaToolStripMenuItem2.Click += new System.EventHandler(this.unosTerminaToolStripMenuItem2_Click);
            // 
            // pretragaBrisanjeTerminaToolStripMenuItem
            // 
            this.pretragaBrisanjeTerminaToolStripMenuItem.BackColor = System.Drawing.Color.SkyBlue;
            this.pretragaBrisanjeTerminaToolStripMenuItem.Name = "pretragaBrisanjeTerminaToolStripMenuItem";
            this.pretragaBrisanjeTerminaToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.pretragaBrisanjeTerminaToolStripMenuItem.Text = "Pretraga / Brisanje termina";
            this.pretragaBrisanjeTerminaToolStripMenuItem.Click += new System.EventHandler(this.pretragaBrisanjeTerminaToolStripMenuItem_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Azure;
            this.pnlMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMain.BackgroundImage")));
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMain.Location = new System.Drawing.Point(0, 23);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1561, 716);
            this.pnlMain.TabIndex = 1;
            // 
            // lblPrijavljeniKorisnik
            // 
            this.lblPrijavljeniKorisnik.AutoSize = true;
            this.lblPrijavljeniKorisnik.BackColor = System.Drawing.Color.Azure;
            this.lblPrijavljeniKorisnik.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrijavljeniKorisnik.Location = new System.Drawing.Point(1142, 5);
            this.lblPrijavljeniKorisnik.Name = "lblPrijavljeniKorisnik";
            this.lblPrijavljeniKorisnik.Size = new System.Drawing.Size(40, 15);
            this.lblPrijavljeniKorisnik.TabIndex = 0;
            this.lblPrijavljeniKorisnik.Text = "label1";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1543, 738);
            this.Controls.Add(this.lblPrijavljeniKorisnik);
            this.Controls.Add(this.menuMain);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuMain;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Softverski sistem za praćenje rada centra za fizioterapiju - Klijentska strana";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem klijentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosKlijentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmenaBrisanjeKlijentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uslugaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosUslugeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem brisanjeUslugeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosTerminaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem pretragaBrisanjeTerminaToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblPrijavljeniKorisnik;
        private System.Windows.Forms.ToolStripMenuItem terminiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem unosNovogTerminaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledBrisanjeTerminaToolStripMenuItem;
    }
}