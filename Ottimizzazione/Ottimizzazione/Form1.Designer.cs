namespace Ottimizzazione
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewTabella = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownProduttori = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownConsumatori = new System.Windows.Forms.NumericUpDown();
            this.buttonCreaTabella = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMin = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonCosto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabella)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProduttori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownConsumatori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTabella
            // 
            this.dataGridViewTabella.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTabella.Location = new System.Drawing.Point(32, 145);
            this.dataGridViewTabella.Name = "dataGridViewTabella";
            this.dataGridViewTabella.RowHeadersWidth = 51;
            this.dataGridViewTabella.RowTemplate.Height = 24;
            this.dataGridViewTabella.Size = new System.Drawing.Size(882, 256);
            this.dataGridViewTabella.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Produttori:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Consumatori:";
            // 
            // numericUpDownProduttori
            // 
            this.numericUpDownProduttori.Location = new System.Drawing.Point(32, 65);
            this.numericUpDownProduttori.Name = "numericUpDownProduttori";
            this.numericUpDownProduttori.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownProduttori.TabIndex = 3;
            // 
            // numericUpDownConsumatori
            // 
            this.numericUpDownConsumatori.Location = new System.Drawing.Point(177, 65);
            this.numericUpDownConsumatori.Name = "numericUpDownConsumatori";
            this.numericUpDownConsumatori.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownConsumatori.TabIndex = 4;
            // 
            // buttonCreaTabella
            // 
            this.buttonCreaTabella.Location = new System.Drawing.Point(120, 93);
            this.buttonCreaTabella.Name = "buttonCreaTabella";
            this.buttonCreaTabella.Size = new System.Drawing.Size(99, 34);
            this.buttonCreaTabella.TabIndex = 5;
            this.buttonCreaTabella.Text = "Crea";
            this.buttonCreaTabella.UseVisualStyleBackColor = true;
            this.buttonCreaTabella.Click += new System.EventHandler(this.buttonCreaTabella_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Creazione Tabella";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(381, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "Costo trasporti";
            // 
            // numericUpDownMax
            // 
            this.numericUpDownMax.Location = new System.Drawing.Point(498, 65);
            this.numericUpDownMax.Name = "numericUpDownMax";
            this.numericUpDownMax.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownMax.TabIndex = 10;
            // 
            // numericUpDownMin
            // 
            this.numericUpDownMin.Location = new System.Drawing.Point(353, 65);
            this.numericUpDownMin.Name = "numericUpDownMin";
            this.numericUpDownMin.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownMin.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(513, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Massimo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(373, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Minimo:";
            // 
            // buttonCosto
            // 
            this.buttonCosto.Location = new System.Drawing.Point(447, 93);
            this.buttonCosto.Name = "buttonCosto";
            this.buttonCosto.Size = new System.Drawing.Size(99, 34);
            this.buttonCosto.TabIndex = 12;
            this.buttonCosto.Text = "Crea";
            this.buttonCosto.UseVisualStyleBackColor = true;
            this.buttonCosto.Click += new System.EventHandler(this.buttonCosto_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(954, 413);
            this.Controls.Add(this.buttonCosto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownMax);
            this.Controls.Add(this.numericUpDownMin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCreaTabella);
            this.Controls.Add(this.numericUpDownConsumatori);
            this.Controls.Add(this.numericUpDownProduttori);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewTabella);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabella)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProduttori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownConsumatori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTabella;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownProduttori;
        private System.Windows.Forms.NumericUpDown numericUpDownConsumatori;
        private System.Windows.Forms.Button buttonCreaTabella;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownMax;
        private System.Windows.Forms.NumericUpDown numericUpDownMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCosto;
    }
}

