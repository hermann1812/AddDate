namespace AddDate
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Dateien_auswählen = new System.Windows.Forms.Button();
            this.button_Datum_hinzufügen = new System.Windows.Forms.Button();
            this.listBox_Dateiliste = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button_Dateien_auswählen
            // 
            this.button_Dateien_auswählen.Location = new System.Drawing.Point(13, 13);
            this.button_Dateien_auswählen.Name = "button_Dateien_auswählen";
            this.button_Dateien_auswählen.Size = new System.Drawing.Size(112, 23);
            this.button_Dateien_auswählen.TabIndex = 0;
            this.button_Dateien_auswählen.Text = "Dateien auswählen";
            this.button_Dateien_auswählen.UseVisualStyleBackColor = true;
            this.button_Dateien_auswählen.Click += new System.EventHandler(this.button_Dateien_auswählen_Click);
            // 
            // button_Datum_hinzufügen
            // 
            this.button_Datum_hinzufügen.Location = new System.Drawing.Point(13, 42);
            this.button_Datum_hinzufügen.Name = "button_Datum_hinzufügen";
            this.button_Datum_hinzufügen.Size = new System.Drawing.Size(112, 23);
            this.button_Datum_hinzufügen.TabIndex = 1;
            this.button_Datum_hinzufügen.Text = "Datum hinzufügen";
            this.button_Datum_hinzufügen.UseVisualStyleBackColor = true;
            this.button_Datum_hinzufügen.Click += new System.EventHandler(this.button_Datum_hinzufügen_Click);
            // 
            // listBox_Dateiliste
            // 
            this.listBox_Dateiliste.FormattingEnabled = true;
            this.listBox_Dateiliste.Location = new System.Drawing.Point(13, 72);
            this.listBox_Dateiliste.Name = "listBox_Dateiliste";
            this.listBox_Dateiliste.Size = new System.Drawing.Size(434, 264);
            this.listBox_Dateiliste.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 347);
            this.Controls.Add(this.listBox_Dateiliste);
            this.Controls.Add(this.button_Datum_hinzufügen);
            this.Controls.Add(this.button_Dateien_auswählen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Dateien_auswählen;
        private System.Windows.Forms.Button button_Datum_hinzufügen;
        private System.Windows.Forms.ListBox listBox_Dateiliste;
    }
}

