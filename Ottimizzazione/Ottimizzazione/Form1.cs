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
            DataTable dt = new DataTable();

            // first add your columns
            dt.Columns.Add(" ");
            for (int i = 1; i <= numericUpDownConsumatori.Value; i++)
            {
                dt.Columns.Add("Consumatore"+i);
            }

            // and then add your rows
            for (int i = 1; i <= numericUpDownProduttori.Value; i++)
            {
                var row = dt.NewRow();
                // Set values for columns with row[i] = xy
                row[0] = "Produttore" + i;

                dt.Rows.Add(row);
            }

           dataGridViewTabella.DataSource = dt;
            // var ele = new Matrix();


            ////dataGridViewTabella.DataSource = new BindingSource() {DataSource = ele };

            //for (int i =0;i<)
            

            //for (int i = 1; i < numericUpDownProduttori.Value ; i++)
            //{
            //    dataGridViewTabella.Rows.Add("Produttore" + i);
            //}
            //dataGridViewTabella.Rows.Add("Fabbisogno");
        }
    }
}
