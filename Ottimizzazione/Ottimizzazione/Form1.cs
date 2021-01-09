using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ottimizzazione
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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
                DialogResult dialogresult=MessageBox.Show("Sei sicuro di creare una nuova tabella? ", "Attenzione!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogresult==DialogResult.Yes)
                {
                    creaTabella();
                }
            }

        }

        public void creaTabella()
        {
            dataGridViewTabella.DataSource = null;
            if (numericUpDownConsumatori.Value < 2 || numericUpDownProduttori.Value < 2 || numericUpDownConsumatori.Text=="" || numericUpDownProduttori.Text=="")
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
            if(numericUpDownMaxCosti.Value == 0 || numericUpDownMinProdFabb.Value == 0 ||numericUpDownMaxProdFabb.Value ==0 || numericUpDownMinCosti.Value > numericUpDownMaxCosti.Value || numericUpDownMinProdFabb.Value > numericUpDownMaxProdFabb.Value)
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



                    dataGridViewTabella.Rows[dataGridViewTabella.RowCount-1].Cells[i].Value = val;
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
              if( e.ColumnIndex == 0){
                MessageBox.Show("Non puoi scrivere su questa casella", "Errore", MessageBoxButtons.OK,MessageBoxIcon.Error);
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
                        // var dt = (dataGridViewTabella.DataSource as DataTable).Rows[0];

                        //  DataTable TabellaNordOvest = (dataGridViewTabella.DataSource as DataTable).Copy();
                        // TabellaNordOvest dt;
                        // dataGridViewNordOvest.DataSource = TabellaNordOvest;


                        int costo_totale = 0;
                        //se produzione > fabbisogno ---> il fabbisogno verrà riempito completamente 





                        foreach (DataGridViewColumn dgvcoloumn in dataGridViewTabella.Columns)
                        {
                            dataGridViewNordOvest.Columns.Add(dgvcoloumn.Clone() as DataGridViewColumn);
                        }

                        DataGridViewRow row = new DataGridViewRow();

                        for (int i = 0; i < dataGridViewTabella.Rows.Count; i++)
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


                        var a = Convert.ToInt32(dataGridViewNordOvest.Rows[0].Cells[dataGridViewNordOvest.ColumnCount - 1].Value);
                        var b = Convert.ToInt32(dataGridViewNordOvest.Rows[dataGridViewNordOvest.Rows.Count - 1].Cells[1].Value);

                        int j = 0;
                        do
                        {



                            if (Convert.ToInt32(dataGridViewNordOvest.Rows[0].Cells[dataGridViewNordOvest.ColumnCount - 1].Value) > Convert.ToInt32(dataGridViewNordOvest.Rows[dataGridViewNordOvest.Rows.Count - 1].Cells[1].Value))
                            {
                                int differenza = Convert.ToInt32(dataGridViewNordOvest.Rows[0].Cells[dataGridViewNordOvest.ColumnCount - 1].Value) - Convert.ToInt32(dataGridViewNordOvest.Rows[dataGridViewNordOvest.Rows.Count - 1].Cells[1].Value);

                                int costo_per_prodotto = Convert.ToInt32(dataGridViewNordOvest.Rows[0].Cells[1].Value);

                                int costo_consegna = costo_per_prodotto * Convert.ToInt32(dataGridViewNordOvest.Rows[dataGridViewNordOvest.Rows.Count - 1].Cells[1].Value);


                                costo_totale += costo_consegna;

                                dataGridViewNordOvest.Rows[0].Cells[dataGridViewNordOvest.ColumnCount - 1].Value = differenza;

                                dataGridViewNordOvest.Columns.RemoveAt(1);



                            }
                            else if (Convert.ToInt32(dataGridViewNordOvest.Rows[0].Cells[dataGridViewNordOvest.ColumnCount - 1].Value) == Convert.ToInt32(dataGridViewNordOvest.Rows[dataGridViewNordOvest.Rows.Count - 1].Cells[1].Value))
                            {
                                int costo_per_prodotto = Convert.ToInt32(dataGridViewNordOvest.Rows[0].Cells[1].Value);

                                int costo_consegna = costo_per_prodotto * Convert.ToInt32(dataGridViewNordOvest.Rows[dataGridViewNordOvest.Rows.Count - 1].Cells[1].Value);

                                costo_totale += costo_consegna;


                                if (!(dataGridViewNordOvest.Rows.Count == 2 && dataGridViewNordOvest.Columns.Count == 1))
                                {
                                    dataGridViewNordOvest.Columns.RemoveAt(1);

                                    dataGridViewNordOvest.Rows.RemoveAt(0);
                                }

                            }
                            else //minore
                            {
                                int differenza = Math.Abs(Convert.ToInt32(dataGridViewNordOvest.Rows[0].Cells[dataGridViewNordOvest.ColumnCount - 1].Value) - Convert.ToInt32(dataGridViewNordOvest.Rows[dataGridViewNordOvest.Rows.Count - 1].Cells[1].Value));

                                int costo_per_prodotto = Convert.ToInt32(dataGridViewNordOvest.Rows[0].Cells[1].Value);

                                int costo_consegna = costo_per_prodotto * Convert.ToInt32(dataGridViewNordOvest.Rows[0].Cells[dataGridViewNordOvest.ColumnCount - 1].Value);

                                costo_totale += costo_consegna;

                                dataGridViewNordOvest.Rows[dataGridViewNordOvest.Rows.Count - 1].Cells[1].Value = differenza;

                                dataGridViewNordOvest.Rows.RemoveAt(0);

                            }
                            //j++;
                            //dataGridViewNordOvest.Rows[dataGridViewNordOvest.RowCount - 1].Cells[dataGridViewNordOvest.ColumnCount - 1].Value = j;
                            dataGridViewNordOvest.Refresh();
                            Thread.Sleep(900);

                        } while (dataGridViewNordOvest.Rows.Count != 2);
                        //dataGridViewNordOvest.Rows[0].Cells[1].Value * dataGridViewNordOvest.Rows[0].Cells[data]

                        break;
                    }
            }
        }
    }
}
