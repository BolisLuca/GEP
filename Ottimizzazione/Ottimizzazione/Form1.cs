using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
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
            if (numericUpDownConsumatori.Value == 0 || numericUpDownProduttori.Value == 0 || numericUpDownConsumatori.Text=="" || numericUpDownProduttori.Text=="")
            {
                MessageBox.Show("Non ci possono essere 0 consumatori o 0 Produttori", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            dataGridViewTabella.DataSource = dt;
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


    }
}
