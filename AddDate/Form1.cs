﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddDate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Dateien_auswählen_Click(object sender, EventArgs e)
        {
            // OpenFileDialog zum Auswählen von Dateien
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Multiselect = true;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // Dateinamen in die ListBox einfügen
                    foreach (string file in dlg.FileNames)
                    {
                        listBox_Dateiliste.Items.Add(file);
                    }
                }
            }
        }

        private void button_Datum_hinzufügen_Click(object sender, EventArgs e)
        {
            // Aktuelles Datum abrufen
            string datum = DateTime.Now.ToString("yyyy_MM_dd");

            // Für jede Datei in der ListBox...
            foreach (string file in listBox_Dateiliste.Items)
            {
                // ... neuen Dateinamen mit Datum erstellen
                string neuerName = Path.Combine(Path.GetDirectoryName(file),
                    datum + "_" + Path.GetFileName(file));

                // Datei umbenennen
                try
                {
                    File.Move(file, neuerName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Fehler beim Umbenennen");
                }
            }

            // Meldung über Erfolg anzeigen
            MessageBox.Show("Dateien wurden erfolgreich umbenannt!");
        }
    }
}