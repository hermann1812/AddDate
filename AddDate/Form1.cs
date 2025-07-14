using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace AddDate
{
    public partial class Form1 : Form
    {
        // Caption for MessageBox
        public static readonly string caption = "AddDate - " + Assembly.GetEntryAssembly().GetName().Version;

        // Aktuelles Datum
        public string datum = DateTime.Now.ToString("yyyy_MM_dd");

        public Form1()
        {
            InitializeComponent();

            // Initialisiere den MonthCalendar
            monthCalendar1.DateSelected += MonthCalendar1_DateSelected;

            // Setze das aktuelle Datum im MonthCalendar
            toolTip1.SetToolTip(monthCalendar1, "Klicke auf ein Datum, um es auszuwählen.");

            // Caption for form
            Text = caption;

            // Aktuelles Datum abrufen
            label_Datum.Text = "Datum = " + datum;
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
                        // Nur hinzufügen, wenn es sich um eine Datei handelt und sie noch nicht in der Liste ist
                        if (File.Exists(file) && !listBox_Dateiliste.Items.Contains(file))
                        {
                            listBox_Dateiliste.Items.Add(file);
                        }
                    }
                }
            }
        }

        private void button_Datum_hinzufügen_Click(object sender, EventArgs e)
        {
            // Für jede Datei in der ListBox...
            foreach (string file in listBox_Dateiliste.Items)
            {
<<<<<<< HEAD
                // ... neuen Dateinamen mit Datum erstellen und Leerzeichen mit Unterstrich ersetzen
                string neuerName = Path.Combine(Path.GetDirectoryName(file), datum + "_" + Path.GetFileName(file).Replace(" ", "_"));

                // Überprüfen, ob die Datei bereits existiert
                if (File.Exists(neuerName))
                {
                    MessageBox.Show("Datei existiert bereits: " + neuerName, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    continue;
                }
=======
                // ... aktuelles Datum abrufen
                datum = datum = DateTime.Now.ToString("yyyy_MM_dd");
>>>>>>> 488b64b818bc17800cf8e2c4a6741be10cb97d5c

                // ... neuen Dateinamen mit Datum erstellen und Leerzeichen mit Unterstrich ersetzen
                string neuerName = Path.Combine(Path.GetDirectoryName(file), datum + "_" + Path.GetFileName(file).Replace(" ", "_"));

                // Überprüfen, ob die Datei bereits existiert
                if (File.Exists(neuerName))
                {
                    MessageBox.Show($"Die Datei existiert bereits:\n{neuerName}", caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    continue;
                }
                
                // Datei umbenennen
                try
                {
                    File.Move(file, neuerName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Datum aktualisieren und anzeigen
            label_Datum.Text = "Datum = " + datum;

            // ListBox leeren
            listBox_Dateiliste.Items.Clear();
        }

        private void button_Aus_ListBox_entfernen_Click(object sender, EventArgs e)
        {
            // Überprüfen, ob die ListBox Elemente enthält
            if (listBox_Dateiliste.Items.Count == 0)
            {
                return;
            }

            // Liste der zu entfernenden Elemente erstellen
            List<object> itemsToRemove = new List<object>();

            // Alle ausgewählten Elemente durchlaufen
            foreach (object item in listBox_Dateiliste.SelectedItems)
            {
                // Element zur Entfernungsliste hinzufügen
                itemsToRemove.Add(item);
            }

            // Alle Elemente aus der ListBox entfernen
            foreach (object item in itemsToRemove)
            {
                listBox_Dateiliste.Items.Remove(item);
            }
        }

        private void listBox_Dateiliste_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                // Nur hinzufügen, wenn es sich um eine Datei handelt und sie noch nicht in der Liste ist
                if (File.Exists(file) && !listBox_Dateiliste.Items.Contains(file))
                {
                    listBox_Dateiliste.Items.Add(file);
                }
            }
        }

        private void listBox_Dateiliste_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Drag & Drop aktivieren
            listBox_Dateiliste.AllowDrop = true;
            listBox_Dateiliste.DragDrop += listBox_Dateiliste_DragDrop;
            listBox_Dateiliste.DragEnter += listBox_Dateiliste_DragEnter;

            // Tooltips zuweisen (Voraussetzung: ToolTip-Komponente mit Namen "toolTip1" vorhanden)
            toolTip1.SetToolTip(monthCalendar1, "Klicke auf ein Datum im Kalender, um es für die Umbenennung zu verwenden.");
            toolTip1.SetToolTip(listBox_Dateiliste, "Hier siehst du die ausgewählten Dateien.\nDu kannst Dateien auch per Drag & Drop hinzufügen.");
            toolTip1.SetToolTip(button_Dateien_auswählen, "Klicke hier, um Dateien zur Liste hinzuzufügen.");
            toolTip1.SetToolTip(button_Aus_ListBox_entfernen, "Entfernt die markierten Dateien aus der Liste.");
            toolTip1.SetToolTip(button_Datum_hinzufügen, "Fügt das gewählte Datum dem Dateinamen voran (z. B. 2025_07_14_Datei.txt).");
            toolTip1.SetToolTip(button_LeerzeichenErsetzen, "Ersetzt Leerzeichen in den Dateinamen durch Unterstriche.");
            toolTip1.SetToolTip(button_Erstelldatum, "Verwendet das Änderungsdatum der Datei zur Umbenennung.");
            toolTip1.SetToolTip(label_Datum, "Aktuell gewähltes Datum für die Umbenennung.");
        }

        private void MonthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            // Zeige das ausgewählte Datum in einem Label an (optional)
            datum = e.Start.ToString("yyyy_MM_dd");
            label_Datum.Text = "Datum = " + datum;
        }

        private void button_LeerzeichenErsetzen_Click(object sender, EventArgs e)
        {
            // Für jede Datei in der ListBox...
            foreach (string file in listBox_Dateiliste.Items)
            {
                // ... neuen Dateinamen erstellen und Leerzeichen mit Unterstrich ersetzen
                string neuerName = Path.Combine(Path.GetDirectoryName(file), Path.GetFileName(file).Replace(" ", "_"));

                // Überprüfen, ob die Datei bereits existiert
                if (File.Exists(neuerName))
                {
<<<<<<< HEAD
                    MessageBox.Show("Datei existiert bereits: " + neuerName, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
=======
                    MessageBox.Show($"Die Datei existiert bereits:\n{neuerName}", caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
>>>>>>> 488b64b818bc17800cf8e2c4a6741be10cb97d5c
                    continue;
                }

                // Datei umbenennen
                try
                {
                    File.Move(file, neuerName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Datum aktualisieren und anzeigen
            label_Datum.Text = "Datum = " + datum;

            // ListBox leeren
            listBox_Dateiliste.Items.Clear();
        }

        private void button_Erstelldatum_Click(object sender, EventArgs e)
        {
            // Für jede Datei in der ListBox...
            foreach (string file in listBox_Dateiliste.Items)
            {
                datum = File.GetLastWriteTime(file).ToString("yyyy_MM_dd");

                // ... neuen Dateinamen mit Datum erstellen und Leerzeichen mit Unterstrich ersetzen
<<<<<<< HEAD
                string neuerName = Path.Combine(Path.GetDirectoryName(file), datum + "_" + Path.GetFileName(file).Replace(" ", "_"));
=======
                string neuerName = Path.Combine(Path.GetDirectoryName(file),datum + "_" + Path.GetFileName(file).Replace(" ", "_"));
>>>>>>> 488b64b818bc17800cf8e2c4a6741be10cb97d5c

                // Überprüfen, ob die Datei bereits existiert
                if (File.Exists(neuerName))
                {
<<<<<<< HEAD
                    MessageBox.Show("Datei existiert bereits: " + neuerName, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
=======
                    MessageBox.Show($"Die Datei existiert bereits:\n{neuerName}", caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
>>>>>>> 488b64b818bc17800cf8e2c4a6741be10cb97d5c
                    continue;
                }

                // Datei umbenennen
                try
                {
                    File.Move(file, neuerName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Datum aktualisieren und anzeigen
            label_Datum.Text = "Datum = " + datum;

            // ListBox leeren
            listBox_Dateiliste.Items.Clear();
        }
    }
}