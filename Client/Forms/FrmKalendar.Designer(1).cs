namespace Client.Forms
{
    partial class FrmKalendar
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
            this.dgvTermini = new System.Windows.Forms.DataGridView();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.btnSortirajPoDatumu = new System.Windows.Forms.Button();
            this.btnSortirajPoImenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTermini
            // 
            this.dgvTermini.AllowUserToAddRows = false;
            this.dgvTermini.AllowUserToDeleteRows = false;
            this.dgvTermini.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTermini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTermini.Location = new System.Drawing.Point(23, 80);
            this.dgvTermini.Name = "dgvTermini";
            this.dgvTermini.ReadOnly = true;
            this.dgvTermini.RowHeadersWidth = 51;
            this.dgvTermini.RowTemplate.Height = 24;
            this.dgvTermini.Size = new System.Drawing.Size(785, 448);
            this.dgvTermini.TabIndex = 0;
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.BackColor = System.Drawing.Color.Transparent;
            this.lblNaslov.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.Location = new System.Drawing.Point(293, 24);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(479, 36);
            this.lblNaslov.TabIndex = 57;
            this.lblNaslov.Text = "KALENDAR ZAKAZANIH TERMINA";
            // 
            // btnSortirajPoDatumu
            // 
            this.btnSortirajPoDatumu.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSortirajPoDatumu.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortirajPoDatumu.Location = new System.Drawing.Point(831, 80);
            this.btnSortirajPoDatumu.Name = "btnSortirajPoDatumu";
            this.btnSortirajPoDatumu.Size = new System.Drawing.Size(200, 37);
            this.btnSortirajPoDatumu.TabIndex = 58;
            this.btnSortirajPoDatumu.Text = "Sortiraj po datumu";
            this.btnSortirajPoDatumu.UseVisualStyleBackColor = false;
            this.btnSortirajPoDatumu.Click += new System.EventHandler(this.btnSortirajPoDatumu_Click);
            // 
            // btnSortirajPoImenu
            // 
            this.btnSortirajPoImenu.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSortirajPoImenu.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortirajPoImenu.Location = new System.Drawing.Point(831, 134);
            this.btnSortirajPoImenu.Name = "btnSortirajPoImenu";
            this.btnSortirajPoImenu.Size = new System.Drawing.Size(200, 37);
            this.btnSortirajPoImenu.TabIndex = 59;
            this.btnSortirajPoImenu.Text = "Sortiraj po imenu";
            this.btnSortirajPoImenu.UseVisualStyleBackColor = false;
            this.btnSortirajPoImenu.Click += new System.EventHandler(this.btnSortirajPoImenu_Click);
            // 
            // FrmKalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 583);
            this.Controls.Add(this.btnSortirajPoImenu);
            this.Controls.Add(this.btnSortirajPoDatumu);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.dgvTermini);
            this.Name = "FrmKalendar";
            this.Text = "FrmKalendar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTermini;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Button btnSortirajPoDatumu;
        private System.Windows.Forms.Button btnSortirajPoImenu;
    }
}