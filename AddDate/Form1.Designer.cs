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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_Dateien_auswählen = new System.Windows.Forms.Button();
            this.button_Datum_hinzufügen = new System.Windows.Forms.Button();
            this.listBox_Dateiliste = new System.Windows.Forms.ListBox();
            this.button_Aus_ListBox_entfernen = new System.Windows.Forms.Button();
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
            this.button_Datum_hinzufügen.Size = new System.Drawing.Size(112, 48);
            this.button_Datum_hinzufügen.TabIndex = 1;
            this.button_Datum_hinzufügen.Text = "Datum hinzufügen\r\nund Leerzeichen mit\r\nUnterstrich ersetzen\r\n";
            this.button_Datum_hinzufügen.UseVisualStyleBackColor = true;
            this.button_Datum_hinzufügen.Click += new System.EventHandler(this.button_Datum_hinzufügen_Click);
            // 
            // listBox_Dateiliste
            // 
            this.listBox_Dateiliste.FormattingEnabled = true;
            this.listBox_Dateiliste.HorizontalScrollbar = true;
            this.listBox_Dateiliste.Location = new System.Drawing.Point(13, 98);
            this.listBox_Dateiliste.Name = "listBox_Dateiliste";
            this.listBox_Dateiliste.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox_Dateiliste.Size = new System.Drawing.Size(434, 238);
            this.listBox_Dateiliste.TabIndex = 2;
            // 
            // button_Aus_ListBox_entfernen
            // 
            this.button_Aus_ListBox_entfernen.Location = new System.Drawing.Point(131, 12);
            this.button_Aus_ListBox_entfernen.Name = "button_Aus_ListBox_entfernen";
            this.button_Aus_ListBox_entfernen.Size = new System.Drawing.Size(142, 23);
            this.button_Aus_ListBox_entfernen.TabIndex = 4;
            this.button_Aus_ListBox_entfernen.Text = "Aus ListBox entfernen";
            this.button_Aus_ListBox_entfernen.UseVisualStyleBackColor = true;
            this.button_Aus_ListBox_entfernen.Click += new System.EventHandler(this.button_Aus_ListBox_entfernen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 347);
            this.Controls.Add(this.button_Aus_ListBox_entfernen);
            this.Controls.Add(this.listBox_Dateiliste);
            this.Controls.Add(this.button_Datum_hinzufügen);
            this.Controls.Add(this.button_Dateien_auswählen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Dateien_auswählen;
        private System.Windows.Forms.Button button_Datum_hinzufügen;
        private System.Windows.Forms.ListBox listBox_Dateiliste;
        private System.Windows.Forms.Button button_Aus_ListBox_entfernen;
    }
}

