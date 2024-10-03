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

            // Caption for form
            Text = caption;

            // Aktuelles Datum abrufen
            datum = DateTime.Now.ToString("yyyy_MM_dd");
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
                        listBox_Dateiliste.Items.Add(file);
                    }
                }
            }
        }

        private void button_Datum_hinzufügen_Click(object sender, EventArgs e)
        {
            // Für jede Datei in der ListBox...
            foreach (string file in listBox_Dateiliste.Items)
            {
                // ... neuen Dateinamen mit Datum erstellen und Leerzeichen mit Unterstrich ersetzen
                string neuerName = Path.Combine(Path.GetDirectoryName(file),
                    datum + "_" + Path.GetFileName(file).Replace(" ","_"));

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
                listBox_Dateiliste.Items.Add(file);
            }
        }

        private void listBox_Dateiliste_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox_Dateiliste.AllowDrop = true;
            listBox_Dateiliste.DragDrop += listBox_Dateiliste_DragDrop;
            listBox_Dateiliste.DragEnter += listBox_Dateiliste_DragEnter;
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

            listBox_Dateiliste.Items.Clear();
        }
    }
}