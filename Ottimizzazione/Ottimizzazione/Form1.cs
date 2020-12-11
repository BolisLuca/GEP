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
                DialogResult dialogresult=MessageBox.Show("Sei sicuro di creare una nuova tabella?", "Attenzione", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogresult==DialogResult.Yes)
                {
                    creaTabella();
                }
            }

        }

        public void creaTabella()
        {
            if (numericUpDownConsumatori.Value == 0 || numericUpDownProduttori.Value == 0)
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

            // and then add your rows
            for (int i = 1; i <= numericUpDownProduttori.Value; i++)
            {

                // Set values for columns with row[i] = xy
                dt.Rows.Add("Produttore" + i);
            }

            dataGridViewTabella.DataSource = dt;
            dataGridViewTabella.RowHeadersVisible = false;
            // var ele = new Matrix();


            ////dataGridViewTabella.DataSource = new BindingSource() {DataSource = ele };

            //for (int i =0;i<)


            //for (int i = 1; i < numericUpDownProduttori.Value ; i++)
            //{
            //    dataGridViewTabella.Rows.Add("Produttore" + i);
            //}
            //dataGridViewTabella.Rows.Add("Fabbisogno");

        }
        private void buttonCosto_Click(object sender, EventArgs e)
        {
            if(numericUpDownMin.Value==0 || numericUpDownMax.Value == 0 || numericUpDownMin.Value > numericUpDownMax.Value)
            {
                MessageBox.Show("Valori non validi: non possono essere 0 e il minimo non può essere maggiore del massimo", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
