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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_Dateien_auswählen = new System.Windows.Forms.Button();
            this.button_Datum_hinzufügen = new System.Windows.Forms.Button();
            this.listBox_Dateiliste = new System.Windows.Forms.ListBox();
            this.button_Aus_ListBox_entfernen = new System.Windows.Forms.Button();
            this.label_Datum = new System.Windows.Forms.Label();
            this.button_LeerzeichenErsetzen = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button_Erstelldatum = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // button_Dateien_auswählen
            // 
            this.button_Dateien_auswählen.Location = new System.Drawing.Point(15, 148);
            this.button_Dateien_auswählen.Name = "button_Dateien_auswählen";
            this.button_Dateien_auswählen.Size = new System.Drawing.Size(112, 23);
            this.button_Dateien_auswählen.TabIndex = 0;
            this.button_Dateien_auswählen.Text = "Dateien auswählen";
            this.button_Dateien_auswählen.UseVisualStyleBackColor = true;
            this.button_Dateien_auswählen.Click += new System.EventHandler(this.button_Dateien_auswählen_Click);
            // 
            // button_Datum_hinzufügen
            // 
            this.button_Datum_hinzufügen.Location = new System.Drawing.Point(15, 25);
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
            this.listBox_Dateiliste.Location = new System.Drawing.Point(15, 183);
            this.listBox_Dateiliste.Name = "listBox_Dateiliste";
            this.listBox_Dateiliste.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox_Dateiliste.Size = new System.Drawing.Size(440, 238);
            this.listBox_Dateiliste.TabIndex = 2;
            // 
            // button_Aus_ListBox_entfernen
            // 
            this.button_Aus_ListBox_entfernen.Location = new System.Drawing.Point(15, 427);
            this.button_Aus_ListBox_entfernen.Name = "button_Aus_ListBox_entfernen";
            this.button_Aus_ListBox_entfernen.Size = new System.Drawing.Size(142, 23);
            this.button_Aus_ListBox_entfernen.TabIndex = 4;
            this.button_Aus_ListBox_entfernen.Text = "Aus ListBox entfernen";
            this.button_Aus_ListBox_entfernen.UseVisualStyleBackColor = true;
            this.button_Aus_ListBox_entfernen.Click += new System.EventHandler(this.button_Aus_ListBox_entfernen_Click);
            // 
            // label_Datum
            // 
            this.label_Datum.AutoSize = true;
            this.label_Datum.Location = new System.Drawing.Point(12, 9);
            this.label_Datum.Name = "label_Datum";
            this.label_Datum.Size = new System.Drawing.Size(50, 13);
            this.label_Datum.TabIndex = 6;
            this.label_Datum.Text = "Datum = ";
            // 
            // button_LeerzeichenErsetzen
            // 
            this.button_LeerzeichenErsetzen.Location = new System.Drawing.Point(15, 79);
            this.button_LeerzeichenErsetzen.Name = "button_LeerzeichenErsetzen";
            this.button_LeerzeichenErsetzen.Size = new System.Drawing.Size(112, 48);
            this.button_LeerzeichenErsetzen.TabIndex = 7;
            this.button_LeerzeichenErsetzen.Text = "Leerzeichen mit\r\nUnterstrich ersetzen\r\n";
            this.button_LeerzeichenErsetzen.UseVisualStyleBackColor = true;
            this.button_LeerzeichenErsetzen.Click += new System.EventHandler(this.button_LeerzeichenErsetzen_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(139, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 8;
            // 
            // button_Erstelldatum
            // 
            this.button_Erstelldatum.Location = new System.Drawing.Point(345, 25);
            this.button_Erstelldatum.Name = "button_Erstelldatum";
            this.button_Erstelldatum.Size = new System.Drawing.Size(95, 47);
            this.button_Erstelldatum.TabIndex = 9;
            this.button_Erstelldatum.Text = "Änderungsdatum\r\nhinzufügen";
            this.button_Erstelldatum.UseVisualStyleBackColor = true;
            this.button_Erstelldatum.Click += new System.EventHandler(this.button_Erstelldatum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 459);
            this.Controls.Add(this.button_Erstelldatum);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.button_LeerzeichenErsetzen);
            this.Controls.Add(this.label_Datum);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Dateien_auswählen;
        private System.Windows.Forms.Button button_Datum_hinzufügen;
        private System.Windows.Forms.ListBox listBox_Dateiliste;
        private System.Windows.Forms.Button button_Aus_ListBox_entfernen;
        private System.Windows.Forms.Label label_Datum;
        private System.Windows.Forms.Button button_LeerzeichenErsetzen;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button_Erstelldatum;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

