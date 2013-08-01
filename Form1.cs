using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Xml;

namespace grafLoader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileInfo fi1 = new FileInfo(Properties.Settings.Default.eseguibileRemoto);
            lbl_versione_programma.Text = "Versione: "+fi1.LastWriteTime.ToShortDateString();
            lbl_caricamento_programma.Text = "Caricamento del programma: " + Properties.Settings.Default.nomeProgramma;
            backgroundWorker1.RunWorkerAsync();            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                FileInfo fi1 = new FileInfo(Properties.Settings.Default.eseguibileRemoto);
                FileInfo fi2 = new FileInfo(Properties.Settings.Default.eseguibileLocale);
                //Se la directory locale non esiste, la creo
                if (!(Directory.Exists(Properties.Settings.Default.cartellaLocale)))
                {
                    Directory.CreateDirectory(Properties.Settings.Default.cartellaLocale);
                }
                //Controllo che il timestamp di modifica del file eseguibile remoto sia
                //più recente di quello locale
                if (fi1.LastWriteTime.Ticks > fi2.LastWriteTime.Ticks)
                {
                    if (Properties.Settings.Default.copiaTutto)
                    {
                        //Devo copiare tutto il contenuto della directory in locale
                        foreach (string fileTrovato in Directory.GetFiles(Properties.Settings.Default.cartellaRemota))
                        {
                            FileInfo FTEMP = new FileInfo(fileTrovato);
                            //Codice per accedere alla label del form (concorrenza)
                            if (lbl_log.InvokeRequired)
                            {
                                lbl_log.Invoke((MethodInvoker)delegate { lbl_log.Text = "Sto copiando " + FTEMP.Name;});
                            }
                            else
                            {
                                lbl_log.Text = "Sto copiando " + FTEMP.Name;
                            }
                            //Copio il file remoto in locale
                            File.Copy(fileTrovato, Properties.Settings.Default.cartellaLocale + FTEMP.Name, true);
                        }
                    }
                    else
                    {
                        //Procedura per la copia solo di alcuni files (ad esempio, eseguibili Visual Fox)
                        foreach (string nomeFile in Properties.Settings.Default.copiaSoloQuestiFiles)
                        {
                            FileInfo FTEMP = new FileInfo(nomeFile);
                            //Codice per accedere alla label del form (concorrenza)
                            if (lbl_log.InvokeRequired)
                            {
                                lbl_log.Invoke((MethodInvoker)delegate { lbl_log.Text = "Sto copiando " + FTEMP.Name; });
                            }
                            else
                            {
                                lbl_log.Text = "Sto copiando " + FTEMP.Name;
                            }
                            File.Copy(Properties.Settings.Default.cartellaRemota + nomeFile, Properties.Settings.Default.cartellaLocale + nomeFile, true);
                        }
                    }

                }

                
            }
            catch (Exception ex) { }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //Al termine della copia, mi preparo ad eseguire il programma
            ProcessStartInfo p = new ProcessStartInfo();
            p.FileName = Properties.Settings.Default.eseguibileLocale;
            p.Arguments = Properties.Settings.Default.parametri;
            //Se è impostato "eseguiDa" (ad esempio per JT) eseguo il programma dal percorso impostato
            if (Properties.Settings.Default.eseguiDa.Length > 0) p.WorkingDirectory = Properties.Settings.Default.eseguiDa;
            //Altrimenti uso la cartella locale
            else p.WorkingDirectory = Properties.Settings.Default.cartellaLocale;
            try
            {
                //Eseguo il programma
                Process.Start(p);
            }
            catch (Exception exep)
            {
                MessageBox.Show("Impossibile avviare il programma richiesto\r\n" + exep.Message);
            }
            Application.Exit();
        }
    }
}