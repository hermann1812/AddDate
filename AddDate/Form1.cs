using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace AddDate
{
    public partial class Form1 : Form
    {
        // Caption for MessageBox
        public static readonly string caption = "AddDate - " + Assembly.GetEntryAssembly().GetName().Version;

        public Form1()
        {
            InitializeComponent();

            // Caption for form
            Text = caption;
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
            string datum = DateTime.Now.ToString("yyyy-MM-dd");

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
                    MessageBox.Show(ex.Message, "Error renaming");
                }
            }

            // Meldung über Erfolg anzeigen
            if (listBox_Dateiliste.Items.Count > 0)
            {
                Erfolgsmeldung();
            }

            listBox_Dateiliste.Items.Clear();
        }

        private void button_Leerzeichen_tauschen_Click(object sender, EventArgs e)
        {
            foreach (var file in listBox_Dateiliste.Items)
            {
                var newFileName = file.ToString().Replace(" ", "_");
                File.Move(file.ToString(), newFileName);
            }

            if (listBox_Dateiliste.Items.Count > 0)
            {
                Erfolgsmeldung();
            }

            listBox_Dateiliste.Items.Clear();
        }
        private void Erfolgsmeldung()
        {
            MessageBox.Show("Files have been successfully renamed!", caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}