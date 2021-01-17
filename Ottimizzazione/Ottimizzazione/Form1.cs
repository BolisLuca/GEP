using System;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Ottimizzazione
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form form2;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCreaTabella_Click(object sender, EventArgs e)
        {

            if (dataGridViewTabella.Rows.Count == 0)
            {
                creaTabella();
            }
            else
            {
                DialogResult dialogresult = MessageBox.Show("Sei sicuro di creare una nuova tabella? ", "Attenzione!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogresult == DialogResult.Yes)
                {
                    creaTabella();
                }
            }

        }

        public void creaTabella()
        {
            dataGridViewTabella.DataSource = null;
            if (numericUpDownConsumatori.Value < 2 || numericUpDownProduttori.Value < 2 || numericUpDownConsumatori.Text == "" || numericUpDownProduttori.Text == "")
            {
                MessageBox.Show("Inserire produttori e consumatori maggiori di 1", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataTable dt = new DataTable();

            // first add your columns
            dt.Columns.Add(" ");
            for (int i = 1; i <= numericUpDownConsumatori.Value; i++)
            {
                dt.Columns.Add("Consumatore" + i);
            }
            dt.Columns.Add("Produzione");

            // and then add your rows
            for (int i = 1; i <= numericUpDownProduttori.Value; i++)
            {

                // Set values for columns with row[i] = xy
                dt.Rows.Add("Produttore" + i);
            }
            dt.Rows.Add("Fabbisogno");
            dataGridViewTabella.DataSource = new BindingSource() { DataSource = dt };
            dataGridViewTabella.RowHeadersVisible = false;

            foreach (DataGridViewColumn column in dataGridViewTabella.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;


            }
            dataGridViewTabella.AutoResizeColumns();

            // var ele = new Matrix();


            ////dataGridViewTabella.DataSource = new BindingSource() {DataSource = ele };

            //for (int i =0;i<)


            //for (int i = 1; i < numericUpDownProduttori.Value ; i++)
            //{
            //    dataGridViewTabella.Rows.Add("Produttore" + i);
            //}
            //dataGridViewTabella.Rows.Add("Fabbisogno");

        }
        Random rand = new Random();
        private void buttonCosto_Click(object sender, EventArgs e)
        {
            if (dataGridViewTabella.DataSource == null)
            {
                MessageBox.Show("Devi creare prima la tabella", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (numericUpDownMaxCosti.Value == 0 || numericUpDownMinProdFabb.Value == 0 || numericUpDownMaxProdFabb.Value == 0 || numericUpDownMinCosti.Value > numericUpDownMaxCosti.Value || numericUpDownMinProdFabb.Value > numericUpDownMaxProdFabb.Value)
            {
                MessageBox.Show("Range non validi: Il massimo non può essere 0 e il minimo non può essere maggiore del massimo", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool modificheEseguite = false;

            //-scegliere colori

            //-relativizzare la dimensione

            for (int i = 0; i < dataGridViewTabella.Rows.Count; i++)
            {
                for (int j = 1; j < dataGridViewTabella.Columns.Count; j++)
                {
                    //if (dataGridViewTabella.Rows[i].Cells[j].Value != "")

                    if (dataGridViewTabella.Rows[i].Cells[j].Value.ToString() != "")
                    {
                        modificheEseguite = true;
                        break;

                    }

                }
                if (modificheEseguite)
                {
                    break;
                }
            }


            if (modificheEseguite)
            {
                DialogResult dialogresult = MessageBox.Show("Sei sicuro di voler generare nuovi valori?", "Attenzione", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogresult == DialogResult.No)
                {
                    return;
                }
            }




            for (int i = 0; i < dataGridViewTabella.Rows.Count - 1; i++)
            {
                for (int j = 1; j < dataGridViewTabella.Columns.Count - 1; j++)
                {
                    dataGridViewTabella.Rows[i].Cells[j].Value = rand.Next(int.Parse(numericUpDownMinCosti.Value.ToString()), int.Parse(numericUpDownMaxCosti.Value.ToString()));
                }

            }


            if (dataGridViewTabella.Rows.Count <= dataGridViewTabella.Columns.Count)
            {
                //parto da fabbisogno
                int totale = 0;
                for (int i = 1; i < dataGridViewTabella.Columns.Count - 1; i++)
                {
                    var val = rand.Next(Decimal.ToInt32(numericUpDownMinProdFabb.Value), Decimal.ToInt32(numericUpDownMaxProdFabb.Value));
                    dataGridViewTabella.Rows[dataGridViewTabella.RowCount - 1].Cells[i].Value = val;
                    totale += val;
                }

                for (int i = 0; i < dataGridViewTabella.Rows.Count - 2; i++)
                {
                    int val = 0;

                    if (totale > (numericUpDownMaxProdFabb.Value - numericUpDownMinProdFabb.Value))
                    {
                        val = rand.Next(Decimal.ToInt32(numericUpDownMinProdFabb.Value), Decimal.ToInt32(numericUpDownMaxProdFabb.Value));
                    }
                    else
                    {
                        if (totale < numericUpDownMaxProdFabb.Value && totale > numericUpDownMinProdFabb.Value)
                        {
                            val = rand.Next(Decimal.ToInt32(numericUpDownMinProdFabb.Value), totale);
                        }
                    }



                    dataGridViewTabella.Rows[i].Cells[dataGridViewTabella.Columns.Count - 1].Value = val;
                    totale -= val;
                }
                dataGridViewTabella.Rows[dataGridViewTabella.Rows.Count - 2].Cells[dataGridViewTabella.Columns.Count - 1].Value = totale;
            }
            else
            {
                //Parto da Produzione


                int totale = 0;
                for (int i = 0; i < dataGridViewTabella.Rows.Count - 1; i++)
                {
                    var val = rand.Next(Decimal.ToInt32(numericUpDownMinProdFabb.Value), Decimal.ToInt32(numericUpDownMaxProdFabb.Value));
                    dataGridViewTabella.Rows[i].Cells[dataGridViewTabella.Columns.Count - 1].Value = val;
                    totale += val;
                }

                for (int i = 1; i < dataGridViewTabella.Columns.Count - 2; i++)
                {
                    int val = 0;

                    if (totale > (numericUpDownMaxProdFabb.Value - numericUpDownMinProdFabb.Value))
                    {
                        val = rand.Next(Decimal.ToInt32(numericUpDownMinProdFabb.Value), Decimal.ToInt32(numericUpDownMaxProdFabb.Value));
                    }
                    else
                    {
                        if (totale < numericUpDownMaxProdFabb.Value && totale > numericUpDownMinProdFabb.Value)
                        {
                            val = rand.Next(Decimal.ToInt32(numericUpDownMinProdFabb.Value), totale);
                        }
                    }


                    
                    dataGridViewTabella.Rows[dataGridViewTabella.RowCount - 1].Cells[i].Value = val;
                    totale -= val;
                }
                dataGridViewTabella.Rows[dataGridViewTabella.Rows.Count - 1].Cells[dataGridViewTabella.Columns.Count - 2].Value = totale;
            }
        }

        private void dataGridViewTabella_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewTabella_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                MessageBox.Show("Non puoi scrivere su questa casella", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridViewTabella.CurrentCell = null;
            }

        }

        private void dataGridViewTabella_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(CheckKey);
        }

        private void CheckKey(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
               && e.KeyChar != '.') //se non è un carattere di controllo Unicode, se non è un digit o se è diverso da . non accetto la modifica
            {
                e.Handled = true; //evento control.key press gestito -->non accetta la modifica richiesta
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    {
                        break;
                    }

                case 1:
                    {
                        if (dataGridViewTabella.DataSource == null)
                        {
                            MessageBox.Show("Devi prima creare la tabella iniziale", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tabControl1.SelectedIndex = 0;
                            return;

                        }

                        for (int i = 0; i < dataGridViewTabella.Rows.Count; i++)
                        {
                            for (int a = 1; a < dataGridViewTabella.Columns.Count; a++)
                            {
                                if(a==dataGridViewTabella.Columns.Count-1)
                                {
                                    break;
                                }

                                if (dataGridViewTabella.Rows[i].Cells[a].Value.ToString() == "")
                                {
                                    MessageBox.Show("Assicurati di aver inserito tutti i valori", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    tabControl1.SelectedIndex = 0;
                                    return;
                                }

                            }
                            if (i == dataGridViewTabella.Rows.Count-1)
                            {
                                break;
                            }
                        }

                        // var dt = (dataGridViewTabella.DataSource as DataTable).Rows[0];

                        //  DataTable TabellaNordOvest = (dataGridViewTabella.DataSource as DataTable).Copy();
                        // TabellaNordOvest dt;
                        // dataGridViewNordOvest.DataSource = TabellaNordOvest;


                        int costo_totale = 0;

                        //se produzione > fabbisogno ---> il fabbisogno verrà riempito completamente 


                        dataGridViewNordOvest.Rows.Clear();
                        dataGridViewNordOvest.Columns.Clear();



                        foreach (DataGridViewColumn dgvcoloumn in dataGridViewTabella.Columns) //clona la struttura
                        {
                            dataGridViewNordOvest.Columns.Add(dgvcoloumn.Clone() as DataGridViewColumn);
                        }

                        DataGridViewRow row = new DataGridViewRow();

                        for (int i = 0; i < dataGridViewTabella.Rows.Count; i++) //inserisco i vaalori delle righe
                        {
                            row = (DataGridViewRow)dataGridViewTabella.Rows[i].Clone();
                            int intColIndex = 0;
                            foreach (DataGridViewCell cell in dataGridViewTabella.Rows[i].Cells)
                            {
                                row.Cells[intColIndex].Value = cell.Value;
                                intColIndex++;
                            }
                            dataGridViewNordOvest.Rows.Add(row);
                        }
                        dataGridViewNordOvest.AllowUserToAddRows = false;
                        dataGridViewNordOvest.RowHeadersVisible = false;
                        dataGridViewNordOvest.Refresh();


                        int j = 0;


                        do
                        {

                            if (j == 0)
                            {
                                if(form2 == null)
                                {
                                    Thread.Sleep(500);
                                    form2 = new Form2();
                                    form2.Show();
                                  
                                }
                                Form2.acquisisci("\n- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  \n");
                                Form2.acquisisci("METODO   NORD-OVEST\n\n");
                            }
                           

                            //produzione > fabbisogno 

                            var produzione = Convert.ToInt32(dataGridViewNordOvest.Rows[0].Cells[dataGridViewNordOvest.ColumnCount - 1].Value);

                            var fabbisogno = Convert.ToInt32(dataGridViewNordOvest.Rows[dataGridViewNordOvest.Rows.Count - 1].Cells[1].Value);

                            if (produzione > fabbisogno)
                            {
                                int differenza = produzione - fabbisogno;

                                dataGridViewNordOvest.Rows[0].Cells[1].Style.ForeColor = Color.Red;

                                int costo_per_prodotto = Convert.ToInt32(dataGridViewNordOvest.Rows[0].Cells[1].Value);

                                int costo_consegna = costo_per_prodotto * fabbisogno;


                                costo_totale += costo_consegna;



                                dataGridViewNordOvest.Columns[1].DefaultCellStyle.BackColor = Color.Yellow;

                                string step = "Da" + dataGridViewNordOvest.Rows[0].Cells[0].Value.ToString() + " a " + dataGridViewNordOvest.Columns[1].HeaderText.ToString() + " : " + fabbisogno.ToString() + " unità a " + costo_per_prodotto.ToString() + "€ = " + costo_consegna.ToString();



                                Form2.acquisisci(step);

                                dataGridViewNordOvest.Refresh();

                                Thread.Sleep(1000);

                                dataGridViewNordOvest.Rows[0].Cells[dataGridViewNordOvest.ColumnCount - 1].Value = differenza;

                                dataGridViewNordOvest.Columns.RemoveAt(1);


                                dataGridViewNordOvest.Refresh();
                            }
                            else
                            {
                                if (produzione == fabbisogno)
                                {
                                    int costo_per_prodotto = Convert.ToInt32(dataGridViewNordOvest.Rows[0].Cells[1].Value);

                                    int costo_consegna = costo_per_prodotto * fabbisogno;

                                    costo_totale += costo_consegna;

                                    dataGridViewNordOvest.Columns[1].DefaultCellStyle.BackColor = Color.Yellow;
                                    dataGridViewNordOvest.Rows[0].DefaultCellStyle.BackColor = Color.Yellow;

                                    dataGridViewNordOvest.Refresh();

                                    

                                    if (dataGridViewNordOvest.Rows.Count != 2 && dataGridViewNordOvest.Columns.Count != 2)
                                    {
                                        string stepp = "Da" + dataGridViewNordOvest.Rows[0].Cells[0].Value.ToString() + " a " + dataGridViewNordOvest.Columns[1].HeaderText.ToString() + " : " + fabbisogno.ToString() + " unità a " + costo_per_prodotto.ToString() + "€ = " + costo_consegna.ToString();
                                        Form2.acquisisci(stepp);
                                        dataGridViewNordOvest.Columns.RemoveAt(1);

                                        dataGridViewNordOvest.Rows.RemoveAt(0);

                                        
                                        dataGridViewNordOvest.Refresh();
                                    }
                                    else
                                    {
                                        string step = "Da" + dataGridViewNordOvest.Rows[0].Cells[0].Value.ToString() + " a " + dataGridViewNordOvest.Columns[1].HeaderText.ToString() + " : " + fabbisogno.ToString() + " unità a " + costo_per_prodotto.ToString() + "€ = " + costo_consegna.ToString();
                                        Form2.acquisisci(step);
                                        break;
                                    }
                                    
                                    Thread.Sleep(1000);




                                }
                                else //produzione minore fabbisogno 7 9
                                {
                                    int differenza = fabbisogno - produzione;

                                    int costo_per_prodotto = Convert.ToInt32(dataGridViewNordOvest.Rows[0].Cells[1].Value);

                                    int costo_consegna = costo_per_prodotto * produzione;

                                    costo_totale += costo_consegna;

                                    dataGridViewNordOvest.Rows[0].DefaultCellStyle.BackColor = Color.Yellow;
                                    dataGridViewNordOvest.Refresh();


                                    Thread.Sleep(1000);

                                    dataGridViewNordOvest.Rows[dataGridViewNordOvest.Rows.Count - 1].Cells[1].Value = differenza;

                                    string step = "Da" + dataGridViewNordOvest.Rows[0].Cells[0].Value.ToString() + " a " + dataGridViewNordOvest.Columns[1].HeaderText.ToString() + " : " + produzione.ToString() + " unità a " + costo_per_prodotto.ToString() + "€ = " + costo_consegna.ToString();
                                    Form2.acquisisci(step);

                                    dataGridViewNordOvest.Rows.RemoveAt(0);


                                    dataGridViewNordOvest.Refresh();

                                }

                            }



                            j++;
                        } while (dataGridViewNordOvest.Rows.Count != 1);

                        string tot = "Il Costo Totale è: " + costo_totale + "€";
                        Form2.acquisisci(tot);

                        //dataGridViewNordOvest.Rows[0].Cells[1].Value * dataGridViewNordOvest.Rows[0].Cells[data]
                        //form2.Close();
                        break;
                    }

                case 2:
                    {
                       

                        if (dataGridViewTabella.DataSource == null)
                        {
                            MessageBox.Show("Devi prima creare la tabella iniziale", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tabControl1.SelectedIndex = 0;
                            return;

                        }
                        for (int i = 0; i < dataGridViewTabella.Rows.Count; i++)
                        {
                            for (int a = 1; a < dataGridViewTabella.Columns.Count; a++)
                            {
                                if (a == dataGridViewTabella.Columns.Count - 1)
                                {
                                    break;
                                }

                                if (dataGridViewTabella.Rows[i].Cells[a].Value.ToString() == "")
                                {
                                    MessageBox.Show("Assicurati di aver inserito tutti i valori", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    tabControl1.SelectedIndex = 0;
                                    return;
                                }

                            }
                            if (i == dataGridViewTabella.Rows.Count - 1)
                            {
                                break;
                            }
                        }



                        int costo_totale = 0;

                        //se produzione > fabbisogno ---> il fabbisogno verrà riempito completamente 

                        dataGridViewMinimiCosti.DataSource = null;
                        dataGridViewMinimiCosti.Rows.Clear();
                        dataGridViewMinimiCosti.Columns.Clear();

                        //var  dt = new DataTable();


                        // foreach (DataGridViewColumn dgvcoloumn in dataGridViewTabella.Columns) //clona la struttura
                        // {
                        //     dt.Columns.Add(dgvcoloumn.Clone() as DataGridViewColumn);
                        // }

                        // DataGridViewRow row = new DataGridViewRow();

                        // for (int i = 0; i < dataGridViewTabella.Rows.Count; i++) //inserisco i vaalori delle righe
                        // {
                        //     row = (DataGridViewRow)dataGridViewTabella.Rows[i].Clone();
                        //     int intColIndex = 0;
                        //     foreach (DataGridViewCell cell in dataGridViewTabella.Rows[i].Cells)
                        //     {
                        //         row.Cells[intColIndex].Value = cell.Value;
                        //         intColIndex++;
                        //     }
                        //     dataGridViewMinimiCosti.Rows.Add(row);
                        // }

                        var dt = new DataTable();

                        dt.Columns.Add(" ");
                        for (int i = 1; i <= dataGridViewTabella.Columns.Count - 2; i++)
                        {
                            dt.Columns.Add("Consumatore" + i);
                        }
                        dt.Columns.Add("Produzione");

                        object[] cellValues = new object[dataGridViewTabella.Columns.Count];
                        foreach (DataGridViewRow row in dataGridViewTabella.Rows)
                        {
                            for (int i = 0; i < row.Cells.Count; i++)
                            {
                                cellValues[i] = row.Cells[i].Value;
                            }
                            dt.Rows.Add(cellValues);
                        }

                        //BindingSource source = new BindingSource();

                        //source.DataSource = dt;

                        dataGridViewMinimiCosti.DataSource = dt;
                        dataGridViewMinimiCosti.AllowUserToAddRows = false;
                        dataGridViewMinimiCosti.RowHeadersVisible = false;
                        dataGridViewMinimiCosti.Refresh();

                        foreach (DataGridViewColumn column in dataGridViewMinimiCosti.Columns)
                        {
                            column.SortMode = DataGridViewColumnSortMode.NotSortable;


                        }

                        int k = 0;

                        int min = 0;
                        int yposizionemin = 0;
                        int xposizionemin = 0;


                        do
                        {

                            if (k == 0)
                            {
                                if (form2 == null)
                                {
                                    Thread.Sleep(500);
                                    form2 = new Form2();
                                    form2.Show();

                                }
                                Form2.acquisisci("\n- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  \n");
                                Form2.acquisisci("      METODO  MINIMI COSTI   \n\n");
                            }




                            for (int i = 0; i < dt.Rows.Count - 1; i++)
                            {
                                for (int j = 1; j < dt.Columns.Count - 1; j++)
                                {
                                    if (i == 0 && j == 1)
                                    {
                                        min = Convert.ToInt32(dt.Rows[0][1]);
                                        yposizionemin = 0;
                                        xposizionemin = 1;

                                    }
                                    else
                                    {


                                        var val = Convert.ToInt32(dt.Rows[i][j]);
                                        if (min.CompareTo(val) > 0)
                                        {
                                            min = Convert.ToInt32(dt.Rows[i][j]);
                                            yposizionemin = i;
                                            xposizionemin = j;
                                        }
                                        else
                                        {
                                            if (Convert.ToInt32(dt.Rows[i][j]) == min)
                                            {
                                                int nprodotti;

                                                int produzioneAttuale = Convert.ToInt32(dt.Rows[i][dt.Columns.Count - 1]);
                                                int fabbisognoAttuale = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][j]);

                                                if (produzioneAttuale > fabbisognoAttuale)
                                                {
                                                    nprodotti = fabbisognoAttuale;
                                                }
                                                else
                                                {
                                                    if (produzioneAttuale < fabbisognoAttuale)
                                                    {
                                                        nprodotti = produzioneAttuale;
                                                    }
                                                    else
                                                    {
                                                        nprodotti = fabbisognoAttuale;
                                                    }
                                                }
                                                int nprodottimin = 0;
                                                int produzioneMin = Convert.ToInt32(dt.Rows[yposizionemin][xposizionemin]);
                                                int fabbisognoMin = Convert.ToInt32(dt.Rows[yposizionemin][xposizionemin]);
                                                if (produzioneMin > fabbisognoMin)
                                                {
                                                    nprodottimin = fabbisognoMin;
                                                }
                                                else
                                                {
                                                    if (produzioneMin < fabbisognoMin)
                                                    {
                                                        nprodottimin = produzioneMin;
                                                    }
                                                    else
                                                    {
                                                        nprodottimin = fabbisognoMin;
                                                    }
                                                }

                                                if (nprodotti < nprodottimin)
                                                {
                                                    yposizionemin = i;
                                                    xposizionemin = j;
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                            //



                            var produzione = Convert.ToInt32(dt.Rows[yposizionemin][dt.Columns.Count - 1]);

                            var fabbisogno = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][xposizionemin]);

                            dataGridViewMinimiCosti.Rows[yposizionemin].Cells[xposizionemin].Style.ForeColor = Color.Red;
                            dataGridViewMinimiCosti.Refresh();

                            if (produzione > fabbisogno)
                            {
                                int differenza = produzione - fabbisogno;



                                int costo_per_prodotto = Convert.ToInt32(dt.Rows[yposizionemin][xposizionemin]);

                                int costo_consegna = costo_per_prodotto * fabbisogno;


                                costo_totale += costo_consegna;



                                dataGridViewMinimiCosti.Columns[xposizionemin].DefaultCellStyle.BackColor = Color.Yellow;

                                string step = "Da" + dt.Rows[yposizionemin][0].ToString() + " a " + dt.Columns[xposizionemin].ToString() + " : " + fabbisogno.ToString() + " unità a " + costo_per_prodotto.ToString() + "€ = " + costo_consegna.ToString();



                                Form2.acquisisci(step);

                                dataGridViewMinimiCosti.Refresh();

                                Thread.Sleep(1000);

                                dt.Rows[yposizionemin][dt.Columns.Count - 1] = differenza;


                                //  dataGridViewMinimiCosti.Columns.RemoveAt(xposizionemin);
                                dt.Columns.RemoveAt(xposizionemin);
                                // dataGridViewMinimiCosti.DataSource = typeof(DataTable);
                                //  dataGridViewMinimiCosti.DataSource = dt;
                                // source.ResetBindings(true);
                                //   dataGridViewMinimiCosti.Invalidate();
                                // dataGridViewMinimiCosti.Update();
                                // source.a

                                dt.AcceptChanges();

                                //    dataGridViewMinimiCosti.Rows.Clear();
                                //      dataGridViewMinimiCosti = null;
                                //     dataGridViewMinimiCosti.DataSource = dt;
                                ///dataGridViewMinimiCosti.RefreshEdit();
                                dataGridViewMinimiCosti.Refresh();

                            }
                            else
                            {
                                if (produzione == fabbisogno)
                                {
                                    int costo_per_prodotto = Convert.ToInt32(dt.Rows[yposizionemin][xposizionemin]);

                                    int costo_consegna = costo_per_prodotto * fabbisogno;

                                    costo_totale += costo_consegna;

                                    dataGridViewMinimiCosti.Columns[xposizionemin].DefaultCellStyle.BackColor = Color.Yellow;
                                    dataGridViewMinimiCosti.Rows[yposizionemin].DefaultCellStyle.BackColor = Color.Yellow;

                                    dataGridViewMinimiCosti.Refresh();

                                    Thread.Sleep(1000);


                                    //dataGridViewMinimiCosti.Columns.RemoveAt(xposizionemin);

                                    //dataGridViewMinimiCosti.Rows.RemoveAt(yposizionemin);

                                    //  dataGridViewMinimiCosti.DataSource = typeof(DataTable);

                                    //  dataGridViewMinimiCosti.DataSource = dt ;

                                    //  source.ResetBindings(true);
                                    //  dataGridViewMinimiCosti.Invalidate();

                                    // dataGridViewMinimiCosti.Update();
                                    //dataGridViewMinimiCosti.RefreshEdit();

                                    // dataGridViewMinimiCosti.Rows.Clear();
                                    //  dataGridViewMinimiCosti = null;
                                    //   dataGridViewMinimiCosti.DataSource = dt;
                                    dataGridViewMinimiCosti.Refresh();

                                    if (dt.Rows.Count != 2 && dt.Columns.Count != 2)
                                    {


                                        string step = "Da" + dt.Rows[yposizionemin][0].ToString() + " a " + dt.Columns[xposizionemin].ToString() + " : " + fabbisogno.ToString() + " unità a " + costo_per_prodotto.ToString() + "€ = " + costo_consegna.ToString();
                                        Form2.acquisisci(step);
                                        dt.Columns.RemoveAt(xposizionemin);

                                        dt.Rows.RemoveAt(yposizionemin);


                                        dt.AcceptChanges();

                                    }
                                    else
                                    {
                                        string step = "Da" + dt.Rows[yposizionemin][0].ToString() + " a " + dt.Columns[xposizionemin].ToString() + " : " + fabbisogno.ToString() + " unità a " + costo_per_prodotto.ToString() + "€ = " + costo_consegna.ToString();
                                        Form2.acquisisci(step);
                                        break;
                                    }


                                    }
                                else //produzione minore fabbisogno 7 9
                                {
                                    int differenza = fabbisogno - produzione;

                                    int costo_per_prodotto = Convert.ToInt32(dt.Rows[yposizionemin][xposizionemin]);

                                    int costo_consegna = costo_per_prodotto * fabbisogno;

                                    costo_totale += costo_consegna;

                                    dataGridViewMinimiCosti.Rows[yposizionemin].DefaultCellStyle.BackColor = Color.Yellow;
                                    dataGridViewMinimiCosti.Refresh();


                                    Thread.Sleep(1000);

                                    dt.Rows[dataGridViewMinimiCosti.Rows.Count - 1][xposizionemin] = differenza;

                                    string step = "Da" + dt.Rows[yposizionemin][0].ToString() + " a " + dt.Columns[xposizionemin].ToString() + " : " + fabbisogno.ToString() + " unità a " + costo_per_prodotto.ToString() + "€ = " + costo_consegna.ToString();
                                    Form2.acquisisci(step);
                                    dataGridViewMinimiCosti.Refresh();

                                    Thread.Sleep(1000);

                                    //dataGridViewMinimiCosti.Rows.RemoveAt(yposizionemin);
                                    dt.Rows.RemoveAt(yposizionemin);
                                    // dataGridViewMinimiCosti.Columns.Clear();
                                    //  dataGridViewMinimiCosti.DataSource = typeof(DataTable);
                                    //   dataGridViewMinimiCosti.DataSource = dt ;
                                    //  source.ResetBindings(true);
                                    //   dataGridViewMinimiCosti.Invalidate();
                                    //    dataGridViewMinimiCosti.Update();
                                    dt.AcceptChanges();

                                    //dataGridViewMinimiCosti.Rows.Clear();
                                    //dataGridViewMinimiCosti = null;
                                    //dataGridViewMinimiCosti.DataSource = dt;


                                    //  dataGridViewMinimiCosti.RefreshEdit();
                                    dataGridViewMinimiCosti.Refresh();

                                }

                            }



                            k++;
                        } while (dataGridViewMinimiCosti.Rows.Count != 1);
                        string tot = "Il Costo Totale è: " + costo_totale + "€";
                        Form2.acquisisci(tot);

                        break;
                    }
            }


        }
    }
}