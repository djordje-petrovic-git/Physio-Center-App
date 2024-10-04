namespace Client.Forms
{
    partial class FrmUnosNapomene
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
            this.rtbOpis = new System.Windows.Forms.RichTextBox();
            this.btnDodajNapomenu = new System.Windows.Forms.Button();
            this.cbTipNapomene = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbOpis
            // 
            this.rtbOpis.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbOpis.Location = new System.Drawing.Point(183, 91);
            this.rtbOpis.Name = "rtbOpis";
            this.rtbOpis.Size = new System.Drawing.Size(257, 101);
            this.rtbOpis.TabIndex = 12;
            this.rtbOpis.Text = "";
            // 
            // btnDodajNapomenu
            // 
            this.btnDodajNapomenu.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDodajNapomenu.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajNapomenu.Location = new System.Drawing.Point(216, 320);
            this.btnDodajNapomenu.Name = "btnDodajNapomenu";
            this.btnDodajNapomenu.Size = new System.Drawing.Size(200, 37);
            this.btnDodajNapomenu.TabIndex = 11;
            this.btnDodajNapomenu.Text = "Dodaj napomenu";
            this.btnDodajNapomenu.UseVisualStyleBackColor = false;
            this.btnDodajNapomenu.Click += new System.EventHandler(this.btnDodajNapomenu_Click);
            // 
            // cbTipNapomene
            // 
            this.cbTipNapomene.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipNapomene.FormattingEnabled = true;
            this.cbTipNapomene.Location = new System.Drawing.Point(183, 229);
            this.cbTipNapomene.Name = "cbTipNapomene";
            this.cbTipNapomene.Size = new System.Drawing.Size(257, 26);
            this.cbTipNapomene.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tip napomene";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Opis";
            // 
            // FrmUnosNapomene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(579, 450);
            this.Controls.Add(this.rtbOpis);
            this.Controls.Add(this.btnDodajNapomenu);
            this.Controls.Add(this.cbTipNapomene);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUnosNapomene";
            this.Text = "Forma za unos napomene";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbOpis;
        private System.Windows.Forms.Button btnDodajNapomenu;
        private System.Windows.Forms.ComboBox cbTipNapomene;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}