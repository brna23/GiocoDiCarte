namespace bernabe.mattia._4j.giocoDiCarte
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.list_value = new System.Windows.Forms.ListBox();
            this.list_value2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_gioca = new System.Windows.Forms.Button();
            this.list_seme1 = new System.Windows.Forms.ListBox();
            this.list_seme2 = new System.Windows.Forms.ListBox();
            this.Out1 = new System.Windows.Forms.Label();
            this.Out2 = new System.Windows.Forms.Label();
            this.risultato = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // list_value
            // 
            this.list_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_value.FormattingEnabled = true;
            this.list_value.ItemHeight = 20;
            this.list_value.Location = new System.Drawing.Point(59, 89);
            this.list_value.Name = "list_value";
            this.list_value.Size = new System.Drawing.Size(122, 264);
            this.list_value.TabIndex = 0;
            // 
            // list_value2
            // 
            this.list_value2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_value2.FormattingEnabled = true;
            this.list_value2.ItemHeight = 20;
            this.list_value2.Location = new System.Drawing.Point(619, 89);
            this.list_value2.Name = "list_value2";
            this.list_value2.Size = new System.Drawing.Size(120, 264);
            this.list_value2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 53);
            this.label1.TabIndex = 10;
            this.label1.Text = "Seleziona due carte";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_gioca
            // 
            this.btn_gioca.Location = new System.Drawing.Point(324, 198);
            this.btn_gioca.Name = "btn_gioca";
            this.btn_gioca.Size = new System.Drawing.Size(148, 48);
            this.btn_gioca.TabIndex = 11;
            this.btn_gioca.Text = "GIOCA";
            this.btn_gioca.UseVisualStyleBackColor = true;
            this.btn_gioca.Click += new System.EventHandler(this.btn_gioca_Click);
            // 
            // list_seme1
            // 
            this.list_seme1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_seme1.FormattingEnabled = true;
            this.list_seme1.ItemHeight = 16;
            this.list_seme1.Location = new System.Drawing.Point(187, 177);
            this.list_seme1.Name = "list_seme1";
            this.list_seme1.Size = new System.Drawing.Size(102, 84);
            this.list_seme1.TabIndex = 12;
            // 
            // list_seme2
            // 
            this.list_seme2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_seme2.FormattingEnabled = true;
            this.list_seme2.ItemHeight = 16;
            this.list_seme2.Location = new System.Drawing.Point(506, 177);
            this.list_seme2.Name = "list_seme2";
            this.list_seme2.Size = new System.Drawing.Size(107, 84);
            this.list_seme2.TabIndex = 13;
            // 
            // Out1
            // 
            this.Out1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Out1.Location = new System.Drawing.Point(208, 275);
            this.Out1.Name = "Out1";
            this.Out1.Size = new System.Drawing.Size(51, 23);
            this.Out1.TabIndex = 14;
            // 
            // Out2
            // 
            this.Out2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Out2.Location = new System.Drawing.Point(533, 275);
            this.Out2.Name = "Out2";
            this.Out2.Size = new System.Drawing.Size(54, 23);
            this.Out2.TabIndex = 15;
            // 
            // risultato
            // 
            this.risultato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.risultato.Location = new System.Drawing.Point(272, 343);
            this.risultato.Name = "risultato";
            this.risultato.Size = new System.Drawing.Size(277, 62);
            this.risultato.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.risultato);
            this.Controls.Add(this.Out2);
            this.Controls.Add(this.Out1);
            this.Controls.Add(this.list_seme2);
            this.Controls.Add(this.list_seme1);
            this.Controls.Add(this.btn_gioca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_value2);
            this.Controls.Add(this.list_value);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox list_value;
        private System.Windows.Forms.ListBox list_value2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_gioca;
        private System.Windows.Forms.ListBox list_seme1;
        private System.Windows.Forms.ListBox list_seme2;
        private System.Windows.Forms.Label Out1;
        private System.Windows.Forms.Label Out2;
        private System.Windows.Forms.Label risultato;
    }
}

