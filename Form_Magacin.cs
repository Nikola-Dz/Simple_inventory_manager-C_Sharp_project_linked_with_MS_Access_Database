using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

//using System.Configuration;

namespace Magacin_PBP
{
    public partial class Form_Magacin : Form
    {
        // Vrednosti za if uslove - inicjalizacija
        private bool bttn_Sacuvaj = false;
        private bool bttn_Izbrisi = false;

        public Form_Magacin()
        {
            InitializeComponent();
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void button_Izadji_Click(object sender, EventArgs e)
        {
            // Izlazak iz aplikacije
            Application.Exit();
        }

        private void Form_Magacin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'magacin_DatabaseDataSet.Table_Asortiman' table. You can move, or remove it, as needed.
            this.table_AsortimanTableAdapter.Fill(this.magacin_DatabaseDataSet.Table_Asortiman);

        }

        private void Form_Magacin_FormClosing(object sender, FormClosingEventArgs e)
        {
            // MessageBox - Izlazak iz aplikacije
            string msg = "Da li želite da zatvorite aplikaciju?";
            string caption = "Zatvaranje aplikacije";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon ico = MessageBoxIcon.Question;

            DialogResult result;

            result = MessageBox.Show(this, msg, caption, buttons, ico);

            if (result == DialogResult.Yes)
            {
                // Zatvaranje prozora
                e.Cancel = false;
            }

            else
            {
                e.Cancel = true;
            }
        }

        private void button_Prethodni_Click(object sender, EventArgs e)
        {
            if (TextBox_Naziv.Text == "" || (TextBox_Broj_komada.Text == "" && TextBox_Tezina.Text == "") || TextBox_Vrednost.Text == "" || comboBox_Kategorija.Text == "-Izaberite kategoriju-" || DateTimePicker_Datum_dospeca.Checked == false)
            {
                // MessageBox - Nije završen unos podataka
                string msg = "Niste završili unos podataka za trenutni proizvod!";
                string caption = "Greška";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon ico = MessageBoxIcon.Error;

                MessageBox.Show(this, msg, caption, buttons, ico);
            }

            else
            {
                this.table_AsortimanBindingSource.MovePrevious();
            }
        }

        private void button_Sledeci_Click(object sender, EventArgs e)
        {
            if (TextBox_Naziv.Text == "" || (TextBox_Broj_komada.Text == "" && TextBox_Tezina.Text == "") || TextBox_Vrednost.Text == "" || comboBox_Kategorija.Text == "-Izaberite kategoriju-" || DateTimePicker_Datum_dospeca.Checked == false)
            {
                // MessageBox - Nije završen unos podataka
                string msg = "Niste završili unos podataka za trenutni proizvod!";
                string caption = "Greška";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon ico = MessageBoxIcon.Error;

                MessageBox.Show(this, msg, caption, buttons, ico);
            }

            else
            {
                this.table_AsortimanBindingSource.MoveNext();
            }
        }

        private void button_Dodaj_Click(object sender, EventArgs e)
        {
            // Zaključaj tabelu
            DataGridView_Table_Asortiman.Enabled = false;

            if (TextBox_Naziv.Text == "" || (TextBox_Broj_komada.Text == "" && TextBox_Tezina.Text == "") || TextBox_Vrednost.Text == "" || comboBox_Kategorija.Text == "-Izaberite kategoriju-" || DateTimePicker_Datum_dospeca.Checked == false)
            {
                // MessageBox - Nije završen unos podataka
                string msg = "Niste završili unos podataka za trenutni proizvod!";
                string caption = "Greška";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon ico = MessageBoxIcon.Error;

                MessageBox.Show(this, msg, caption, buttons, ico);
            }

            else
            {
                this.table_AsortimanBindingSource.AddNew();

                // Vraća comboBox_Kategorija u početno stanje
                comboBox_Kategorija.SelectedIndex = 0;

                // Vraća DateTimePicker u početno stanje 
                DateTimePicker_Datum_dospeca.Checked = false;
            }
        }

        private void button_Sacuvaj_Click(object sender, EventArgs e)
        {
            if (TextBox_Naziv.Text == "" || (TextBox_Broj_komada.Text == "" && TextBox_Tezina.Text == "") || TextBox_Vrednost.Text == "" || comboBox_Kategorija.Text == "-Izaberite kategoriju-" || DateTimePicker_Datum_dospeca.Checked == false)
            {
                // MessageBox - Nisu uneti svi podaci
                string msg = "Niste uneli sve podatke!";
                string caption = "Greška";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon ico = MessageBoxIcon.Error;

                MessageBox.Show(this, msg, caption, buttons, ico);
            }

            else
            {
                try
                {
                    // MessageBox - Sačuvanje izmena
                    string msg = "Da li želite da sačuvate izmene?";
                    string caption = "Sačuvanje izmena";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    MessageBoxIcon ico = MessageBoxIcon.Question;

                    DialogResult result;
                    
                    result = MessageBox.Show(this, msg, caption, buttons, ico);

                    if (result == DialogResult.Yes)
                    {
                        // Pokreće mehanizam za backgroundWorker
                        backgroundWorker.RunWorkerAsync();

                        // Sačuvaj
                        this.table_AsortimanBindingSource.EndEdit();
                        this.table_AsortimanTableAdapter.Update(this.magacin_DatabaseDataSet.Table_Asortiman);

                        // Osveži
                        this.table_AsortimanTableAdapter.Fill(this.magacin_DatabaseDataSet.Table_Asortiman);

                        // Otključaj tabelu
                        DataGridView_Table_Asortiman.Enabled = true;

                        // Prikaži toolStripProgressBar
                        toolStripProgressBar.Visible = true;

                        // Prikaži toolStripStatusLabel
                        toolStripStatusLabel.Visible = true;

                        //Promena vrednosti za if uslove - button_Sacuvaj 
                        bttn_Sacuvaj = true;
                    }

                    else
                    {
                        return;
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Došlo je do greške: " + ex.Message.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_Izbrisi_Click(object sender, EventArgs e)
        {
            try
            {
                // MessageBox - Brisanje proizvoda
                string msg = "Da li želite da izbrišete izabrani proizvod?";
                string caption = "Brisanje proizvoda";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                MessageBoxIcon ico = MessageBoxIcon.Question;

                DialogResult result;

                result = MessageBox.Show(this, msg, caption, buttons, ico);

                if (result == DialogResult.Yes)
                {
                    // Pokreće mehanizam za backgroundWorker
                    backgroundWorker.RunWorkerAsync();

                    // Brisanje
                    this.table_AsortimanBindingSource.RemoveCurrent();

                    // Sačuvaj
                    this.table_AsortimanBindingSource.EndEdit();
                    this.table_AsortimanTableAdapter.Update(this.magacin_DatabaseDataSet.Table_Asortiman);

                    // Osveži
                    this.table_AsortimanTableAdapter.Fill(this.magacin_DatabaseDataSet.Table_Asortiman);

                    // Otključaj tabelu
                    DataGridView_Table_Asortiman.Enabled = true;

                    // Prikaži toolStripProgressBar
                    toolStripProgressBar.Visible = true;

                    // Prikaži toolStripStatusLabel
                    toolStripStatusLabel.Visible = true;

                    //Promena vrednosti za if uslove - button_Izbrisi
                    bttn_Izbrisi = true;
                }
                
                else
                {
                    return;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške: " + ex.Message.ToString(), "Brisanje proizvoda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            button_Dodaj.PerformClick();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            button_Izbrisi.PerformClick();
        }

        private void bindingNavigatorUpdateItem_Click(object sender, EventArgs e)
        {
            button_Sacuvaj.PerformClick();
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            Form_Magacin_Load(sender, e);

            DateTimePicker_Datum_dospeca.Checked = true;
            DataGridView_Table_Asortiman.Enabled = true;
        }


        private void button_Export_Click(object sender, EventArgs e)
        {
            if (TextBox_Naziv.Text == "" || (TextBox_Broj_komada.Text == "" && TextBox_Tezina.Text == "") || TextBox_Vrednost.Text == "" || comboBox_Kategorija.Text == "-Izaberite kategoriju-" || DateTimePicker_Datum_dospeca.Checked == false)
            {
                // MessageBox - Nije završen unos podataka
                string msg = "Niste završili unos podataka za trenutni proizvod!";
                string caption = "Greška";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon ico = MessageBoxIcon.Error;

                MessageBox.Show(this, msg, caption, buttons, ico);
            }

            else
            {
                // SaveFileDialog
                SaveFileDialog sfd = new SaveFileDialog();

                sfd.FileName = "magacin_export";
                sfd.DefaultExt = "txt";
                sfd.Filter = "txt files (*.txt)|*.txt";


                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (Stream s = File.Open(sfd.FileName, FileMode.Create))
                    {
                        using (StreamWriter sw = new StreamWriter(s))
                        {
                            for (int i = 0; i < DataGridView_Table_Asortiman.Rows.Count - 1; i++)
                            {
                                for (int j = 0; j < DataGridView_Table_Asortiman.Columns.Count; j++)
                                {
                                    sw.Write(" " + DataGridView_Table_Asortiman.Rows[i].Cells[j].Value.ToString() + " " + "|");
                                }

                                sw.WriteLine("");
                                sw.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            }

                            sw.Close();
                        }
                    }
                }
            }
        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // Uvecavanje vrednosti - toolStripProgressBar
            for (int i = 0; i < 101; i++)
            {
                Thread.Sleep(10);
                backgroundWorker.WorkerReportsProgress = true;
                backgroundWorker.ReportProgress(i);
            }
        }


        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Aktivacija procesa - toolStripProgressBar
            toolStripProgressBar.Value = e.ProgressPercentage;
            toolStripStatusLabel.Text = e.ProgressPercentage.ToString() + "%";

            if (toolStripProgressBar.Value == 100)
            {
                //If uslov - button_Sacuvaj
                if (bttn_Sacuvaj == true)
                {
                    MessageBox.Show("Izmene su uspešno sačuvane.", "Sačuvanje izmena", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    bttn_Sacuvaj = false;
                }

                //If uslov - button_Izbrisi
                if (bttn_Izbrisi == true)
                {
                    MessageBox.Show("Proizvod je uspešno izbrisan.", "Brisanje proizvoda", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    bttn_Izbrisi = false;
                }

                // Deaktiviraj toolStripProgressBar i vrati na 0
                toolStripProgressBar.Value = 0;
                toolStripProgressBar.Visible = false;

                // Deaktiviraj toolStripStatusLabel
                toolStripStatusLabel.Visible = false;
            }
        }


        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_Naziv_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_Vrednost_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label_Vrednost_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_Kategorija_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}